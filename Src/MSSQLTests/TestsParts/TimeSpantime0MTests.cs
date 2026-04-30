

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
    Id = 4,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 53, milliseconds: 874),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 8,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 56, milliseconds: 875),
    ModelInner = new TimeSpantime0MI
{
    Id = 7,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 12, milliseconds: 656),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 15,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 33, milliseconds: 324),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 18,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 25, milliseconds: 941),
    ModelInner = new TimeSpantime0MI
{
    Id = 13,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 13, milliseconds: 692),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 19,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 11, milliseconds: 16),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 27,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 40, milliseconds: 859),
    ModelInner = new TimeSpantime0MI
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 47, milliseconds: 965),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 34,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 25, milliseconds: 193),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 40, milliseconds: 902),
},
            new TimeSpantime0M
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 17, milliseconds: 787),
    ModelInner = new TimeSpantime0MI
{
    Id = 18,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 53, milliseconds: 78),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 48, milliseconds: 44),
},
            new TimeSpantime0M
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 16, seconds: 24, milliseconds: 474),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 55,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 26, milliseconds: 115),
    ModelInner = new TimeSpantime0MI
{
    Id = 27,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 49, milliseconds: 632),
    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 40, milliseconds: 820),
},
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 48, seconds: 23, milliseconds: 452),
},
            new TimeSpantime0M
{
    Id = 56,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 42, seconds: 21, milliseconds: 925),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 62,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 36, milliseconds: 867),
    ModelInner = new TimeSpantime0MI
{
    Id = 29,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 11, milliseconds: 656),
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 34, seconds: 12, milliseconds: 563),
},
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 58, milliseconds: 194),
},
            new TimeSpantime0M
{
    Id = 69,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 36, seconds: 26, milliseconds: 933),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 72,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 43, milliseconds: 75),
    ModelInner = new TimeSpantime0MI
{
    Id = 33,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 18, milliseconds: 477),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 76,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 3, seconds: 26, milliseconds: 824),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 78,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 32, milliseconds: 10),
    ModelInner = new TimeSpantime0MI
{
    Id = 38,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 40, milliseconds: 667),
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 24, milliseconds: 462),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 80,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 0, milliseconds: 350),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 87,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 5, milliseconds: 6),
    ModelInner = new TimeSpantime0MI
{
    Id = 42,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 201),
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 55, milliseconds: 820),
},
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 33, milliseconds: 813),
},
            new TimeSpantime0M
{
    Id = 90,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 37, milliseconds: 979),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 91,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 36, milliseconds: 664),
    ModelInner = new TimeSpantime0MI
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 1, milliseconds: 616),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 95,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 50, milliseconds: 878),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 98,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 39, milliseconds: 808),
    ModelInner = new TimeSpantime0MI
{
    Id = 44,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 3, milliseconds: 937),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 55, milliseconds: 793),
},
            new TimeSpantime0M
{
    Id = 106,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 43, milliseconds: 632),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 16, milliseconds: 694),
},
            new TimeSpantime0M
{
    Id = 109,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 54, milliseconds: 612),
    ModelInner = new TimeSpantime0MI
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 48, milliseconds: 442),
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 44, milliseconds: 156),
},
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 1, milliseconds: 519),
},
            new TimeSpantime0M
{
    Id = 118,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 22, milliseconds: 27),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 58, milliseconds: 832),
},
            new TimeSpantime0M
{
    Id = 124,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 47, milliseconds: 615),
    ModelInner = new TimeSpantime0MI
{
    Id = 57,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 49, milliseconds: 822),
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 30, milliseconds: 959),
},
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 36, milliseconds: 559),
},
            new TimeSpantime0M
{
    Id = 128,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 41, milliseconds: 683),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 49, milliseconds: 395),
},
            new TimeSpantime0M
{
    Id = 129,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 24, milliseconds: 898),
    ModelInner = new TimeSpantime0MI
{
    Id = 66,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 17, milliseconds: 373),
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 15, seconds: 6, milliseconds: 960),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 135,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 52, milliseconds: 237),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 140,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 23, milliseconds: 299),
    ModelInner = new TimeSpantime0MI
{
    Id = 69,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 48, milliseconds: 91),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.timespantime0mi(
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(32)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(32))
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
INSERT INTO dbo.timespantime0mi(
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
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)17),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)17, 
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

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.timespantime0m(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(32)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(32),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
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
INSERT INTO dbo.timespantime0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.TimeSpan), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)17),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)17,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantime0M), typeof(FlatTimeSpantime0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM dbo.timespantime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpantime0M>();
                var models2 = new List<FlatTimeSpantime0M>();
                await((ITimeSpanSingleTypetime)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.timespantime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpantime0M>();
                var models2 = new List<FlatTimeSpantime0M>();
                ((ITimeSpanSingleTypetime)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM dbo.timespantime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanSingleTypetime)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
FROM dbo.timespantime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanSingleTypetime)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpantime0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
                var models = await((ITimeSpanSingleTypetime)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanSingleTypetime)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantime0M), typeof(FlatTimeSpantime0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM dbo.timespantime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpantime0M>();
                var models2 = new List<FlatTimeSpantime0M>();
                await((ITimeSpanSingleTypetime)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.timespantime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpantime0M>();
                var models2 = new List<FlatTimeSpantime0M>();
                ((ITimeSpanSingleTypetime)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
FROM dbo.timespantime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanSingleTypetime)this).DynQuerySelectModelAsync(connection,  query, 0);
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
FROM dbo.timespantime0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanSingleTypetime)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpantime0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)),
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
                var models = await((ITimeSpanSingleTypetime)this).SelectModelAsync(connection, 0);
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
                var models = ((ITimeSpanSingleTypetime)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantime0M), typeof(FlatTimeSpantime0M)],
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpantime0M>();
                var models2 = new List<FlatTimeSpantime0M>();
                await((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var firstItems2 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                var secondItems2 = new List<FlatTimeSpantime0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var firstItems2 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpantime0M>();
                var models2 = new List<FlatTimeSpantime0M>();
                ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var firstItems2 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                var secondItems2 = new List<FlatTimeSpantime0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var firstItems2 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
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
FROM dbo.timespantime0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[2], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[18],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[19],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[20],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[21],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[22],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[23],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[24],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[25],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[26],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                var secondItems2 = new List<FlatTimeSpantime0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM dbo.timespantime0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                var secondItems2 = new List<FlatTimeSpantime0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpantime0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeSpantime0M.AssertModel(models[0],_testData[10], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[11], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[12], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[13], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[16],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[17],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[18],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpantime0M.AssertModel(models[0],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeSpantime0M.AssertModel(models[0],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeSpantime0M.AssertModel(models[0],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantime0M), typeof(FlatTimeSpantime0M)],
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpantime0M>();
                var models2 = new List<FlatTimeSpantime0M>();
                await((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var firstItems2 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                var secondItems2 = new List<FlatTimeSpantime0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 4, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var firstItems2 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[29], false);
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpantime0M>();
                var models2 = new List<FlatTimeSpantime0M>();
                ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var firstItems2 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                var secondItems2 = new List<FlatTimeSpantime0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 118, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var firstItems2 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 128, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[2], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[18],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[19],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[20],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[21],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[22],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[23],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[24],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[25],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[26],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[27],_testData[29], false);
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                var secondItems2 = new List<FlatTimeSpantime0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 109, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[2], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[18],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[19],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[20],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[21],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[22],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[23],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[24],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[25],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[26],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[27],_testData[29], false);
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
FROM dbo.timespantime0m m
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
FROM dbo.timespantime0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantime0M>();
                var secondItems1 = new List<FlatTimeSpantime0M>();
                var secondItems2 = new List<FlatTimeSpantime0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatch(connection, 78, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpantime0M)],
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
            dbType: (System.Data.DbType)11)]
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatchAsync(connection, 34, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeSpantime0M.AssertModel(models[0],_testData[7], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[8], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[9], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[10], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[11], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[12], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[13], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[16],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[17],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[18],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[19],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[20],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[21],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeSpantime0M.AssertModel(models[0],_testData[13], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatch(connection, 109, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpantime0M.AssertModel(models[0],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        TimeSpantime0M.AssertModel(models[0],_testData[4], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[5], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[6], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[7], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[8], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[9], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[10], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[11], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[12], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[13], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[16],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[17],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[18],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[19],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[20],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[21],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[22],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[23],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[24],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[25],_testData[29], false);
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
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
TimeSpantime0M.AssertModel(models[0],_testData[8], false);TimeSpantime0M.AssertModel(models[1],_testData[9], false);TimeSpantime0M.AssertModel(models[2],_testData[10], false);TimeSpantime0M.AssertModel(models[3],_testData[11], false);TimeSpantime0M.AssertModel(models[4],_testData[12], false);TimeSpantime0M.AssertModel(models[5],_testData[13], false);TimeSpantime0M.AssertModel(models[6],_testData[14], false);TimeSpantime0M.AssertModel(models[7],_testData[15], false);TimeSpantime0M.AssertModel(models[8],_testData[16], false);TimeSpantime0M.AssertModel(models[9],_testData[17], false);TimeSpantime0M.AssertModel(models[10],_testData[18], false);TimeSpantime0M.AssertModel(models[11],_testData[19], false);TimeSpantime0M.AssertModel(models[12],_testData[20], false);TimeSpantime0M.AssertModel(models[13],_testData[21], false);TimeSpantime0M.AssertModel(models[14],_testData[22], false);TimeSpantime0M.AssertModel(models[15],_testData[23], false);TimeSpantime0M.AssertModel(models[16],_testData[24], false);TimeSpantime0M.AssertModel(models[17],_testData[25], false);TimeSpantime0M.AssertModel(models[18],_testData[26], false);TimeSpantime0M.AssertModel(models[19],_testData[27], false);TimeSpantime0M.AssertModel(models[20],_testData[28], false);TimeSpantime0M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
TimeSpantime0M.AssertModel(models[0],_testData[23], false);TimeSpantime0M.AssertModel(models[1],_testData[24], false);TimeSpantime0M.AssertModel(models[2],_testData[25], false);TimeSpantime0M.AssertModel(models[3],_testData[26], false);TimeSpantime0M.AssertModel(models[4],_testData[27], false);TimeSpantime0M.AssertModel(models[5],_testData[28], false);TimeSpantime0M.AssertModel(models[6],_testData[29], false);
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 53, milliseconds: 874))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 56, milliseconds: 875))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 12, milliseconds: 656))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 33, milliseconds: 324))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 25, milliseconds: 941))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 13, milliseconds: 692))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 11, milliseconds: 16))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 40, milliseconds: 859))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 47, milliseconds: 965))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 25, milliseconds: 193))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 40, milliseconds: 902))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 17, milliseconds: 787))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 53, milliseconds: 78))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 48, milliseconds: 44))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 16, seconds: 24, milliseconds: 474))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 26, milliseconds: 115))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 49, milliseconds: 632))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 40, milliseconds: 820))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 48, seconds: 23, milliseconds: 452))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 42, seconds: 21, milliseconds: 925))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 36, milliseconds: 867))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 11, milliseconds: 656))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 34, seconds: 12, milliseconds: 563))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 58, milliseconds: 194))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 36, seconds: 26, milliseconds: 933))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 43, milliseconds: 75))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 18, milliseconds: 477))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 3, seconds: 26, milliseconds: 824))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 32, milliseconds: 10))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 40, milliseconds: 667))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 24, milliseconds: 462))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 0, milliseconds: 350))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 5, milliseconds: 6))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 201))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 55, milliseconds: 820))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 33, milliseconds: 813))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 37, milliseconds: 979))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 36, milliseconds: 664))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 1, milliseconds: 616))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 50, milliseconds: 878))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 39, milliseconds: 808))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 3, milliseconds: 937))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 55, milliseconds: 793))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 43, milliseconds: 632))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 16, milliseconds: 694))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 54, milliseconds: 612))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 48, milliseconds: 442))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 44, milliseconds: 156))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 1, milliseconds: 519))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 22, milliseconds: 27))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 58, milliseconds: 832))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 47, milliseconds: 615))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 49, milliseconds: 822))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 30, milliseconds: 959))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 36, milliseconds: 559))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 41, milliseconds: 683))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 49, milliseconds: 395))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 24, milliseconds: 898))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 17, milliseconds: 373))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 15, seconds: 6, milliseconds: 960))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 52, milliseconds: 237))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 23, milliseconds: 299))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 48, milliseconds: 91))));//InnerModel.Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 53, milliseconds: 874))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 56, milliseconds: 875))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 12, milliseconds: 656))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 33, milliseconds: 324))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 25, milliseconds: 941))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 13, milliseconds: 692))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 11, milliseconds: 16))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 40, milliseconds: 859))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 47, milliseconds: 965))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 25, milliseconds: 193))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 40, milliseconds: 902))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 17, milliseconds: 787))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 53, milliseconds: 78))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 48, milliseconds: 44))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 16, seconds: 24, milliseconds: 474))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 26, milliseconds: 115))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 49, milliseconds: 632))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 40, milliseconds: 820))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 48, seconds: 23, milliseconds: 452))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 42, seconds: 21, milliseconds: 925))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 36, milliseconds: 867))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 11, milliseconds: 656))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 34, seconds: 12, milliseconds: 563))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 58, milliseconds: 194))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 36, seconds: 26, milliseconds: 933))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 43, milliseconds: 75))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 18, milliseconds: 477))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 3, seconds: 26, milliseconds: 824))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 32, milliseconds: 10))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 40, milliseconds: 667))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 24, milliseconds: 462))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 0, milliseconds: 350))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 5, milliseconds: 6))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 201))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 55, milliseconds: 820))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 33, milliseconds: 813))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 37, milliseconds: 979))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 36, milliseconds: 664))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 1, milliseconds: 616))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 50, milliseconds: 878))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 39, milliseconds: 808))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 3, milliseconds: 937))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 55, milliseconds: 793))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 43, milliseconds: 632))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 16, milliseconds: 694))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 54, milliseconds: 612))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 48, milliseconds: 442))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 44, milliseconds: 156))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 1, milliseconds: 519))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 22, milliseconds: 27))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 58, milliseconds: 832))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 47, milliseconds: 615))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 49, milliseconds: 822))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 30, milliseconds: 959))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 36, milliseconds: 559))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 41, milliseconds: 683))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 49, milliseconds: 395))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 24, milliseconds: 898))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 17, milliseconds: 373))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 15, seconds: 6, milliseconds: 960))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 52, milliseconds: 237))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 23, milliseconds: 299))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 48, milliseconds: 91))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


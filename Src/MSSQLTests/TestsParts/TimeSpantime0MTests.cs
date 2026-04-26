

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
    Id = 3,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 32, milliseconds: 877),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 42, milliseconds: 923),
},
            new TimeSpantime0M
{
    Id = 5,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 17, milliseconds: 242),
    ModelInner = new TimeSpantime0MI
{
    Id = 9,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 22, milliseconds: 1),
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 31, milliseconds: 523),
},
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 41, seconds: 5, milliseconds: 679),
},
            new TimeSpantime0M
{
    Id = 11,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 37, milliseconds: 476),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 20, milliseconds: 756),
},
            new TimeSpantime0M
{
    Id = 18,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 4, milliseconds: 308),
    ModelInner = new TimeSpantime0MI
{
    Id = 16,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 8, milliseconds: 986),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 22,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 21, milliseconds: 420),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 38, milliseconds: 377),
},
            new TimeSpantime0M
{
    Id = 25,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 5, milliseconds: 452),
    ModelInner = new TimeSpantime0MI
{
    Id = 23,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 11, milliseconds: 193),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 38, milliseconds: 168),
},
            new TimeSpantime0M
{
    Id = 27,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 46, seconds: 57, milliseconds: 384),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 33, milliseconds: 879),
},
            new TimeSpantime0M
{
    Id = 33,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 28, seconds: 14, milliseconds: 955),
    ModelInner = new TimeSpantime0MI
{
    Id = 28,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 31, milliseconds: 52),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 38,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 54, milliseconds: 106),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 18, milliseconds: 472),
},
            new TimeSpantime0M
{
    Id = 39,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 48, milliseconds: 719),
    ModelInner = new TimeSpantime0MI
{
    Id = 36,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 19, milliseconds: 111),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 40,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 21, milliseconds: 520),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 46,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 27, seconds: 33, milliseconds: 220),
    ModelInner = new TimeSpantime0MI
{
    Id = 42,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 17, milliseconds: 280),
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 32, milliseconds: 648),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 54,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 31, seconds: 22, milliseconds: 872),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 19, milliseconds: 84),
},
            new TimeSpantime0M
{
    Id = 56,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 58, seconds: 23, milliseconds: 995),
    ModelInner = new TimeSpantime0MI
{
    Id = 45,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 30, milliseconds: 510),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 63,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 42, seconds: 47, milliseconds: 127),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 38, milliseconds: 262),
},
            new TimeSpantime0M
{
    Id = 65,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 23, seconds: 6, milliseconds: 646),
    ModelInner = new TimeSpantime0MI
{
    Id = 46,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 20, milliseconds: 931),
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 37, milliseconds: 706),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 71,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 18, milliseconds: 76),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 54, seconds: 18, milliseconds: 589),
},
            new TimeSpantime0M
{
    Id = 79,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 17, milliseconds: 727),
    ModelInner = new TimeSpantime0MI
{
    Id = 48,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 19, milliseconds: 888),
    NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 27, milliseconds: 574),
},
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 14, seconds: 11, milliseconds: 178),
},
            new TimeSpantime0M
{
    Id = 86,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 13, seconds: 10, milliseconds: 29),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 95,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 33, milliseconds: 286),
    ModelInner = new TimeSpantime0MI
{
    Id = 57,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 14, milliseconds: 148),
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 50, milliseconds: 772),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 104,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 30, milliseconds: 75),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 34, milliseconds: 992),
},
            new TimeSpantime0M
{
    Id = 112,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 7, milliseconds: 807),
    ModelInner = new TimeSpantime0MI
{
    Id = 66,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 40, milliseconds: 619),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 50, milliseconds: 81),
},
            new TimeSpantime0M
{
    Id = 117,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 30, seconds: 23, milliseconds: 324),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 120,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 47, seconds: 7, milliseconds: 253),
    ModelInner = new TimeSpantime0MI
{
    Id = 75,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 26, milliseconds: 105),
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 58, milliseconds: 876),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 121,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 51, milliseconds: 651),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 49, milliseconds: 536),
},
            new TimeSpantime0M
{
    Id = 124,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 48, milliseconds: 63),
    ModelInner = new TimeSpantime0MI
{
    Id = 84,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 55, milliseconds: 122),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 131,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 1, milliseconds: 988),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 52, milliseconds: 101),
},
            new TimeSpantime0M
{
    Id = 132,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 7, milliseconds: 471),
    ModelInner = new TimeSpantime0MI
{
    Id = 91,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 45, milliseconds: 222),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 46, milliseconds: 423),
},
            new TimeSpantime0M
{
    Id = 133,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 35, milliseconds: 163),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 141,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 14, milliseconds: 948),
    ModelInner = new TimeSpantime0MI
{
    Id = 92,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 12, milliseconds: 303),
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(32)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(32))
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(32)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(32),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[29], false);
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
                parametr1.Value = 3;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[23],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[23],_testData[29], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[24],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[26],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpantime0M.AssertModel(models[0],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeSpantime0M.AssertModel(models[0],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpantime0M.AssertModel(models[0],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        TimeSpantime0M.AssertModel(models[0],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 104, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[29], false);
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
                await ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 132, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[19],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[25],_testData[29], false);
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
                 ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatch(connection, 56, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[15],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 3, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[1], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[2], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[18],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[19],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[20],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[21],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[22],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[23],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[24],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[25],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[26],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[27],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[14],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[15],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[16],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[17],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[18],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatch(connection, 95, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatchAsync(connection, 121, 112))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeSpantime0M.AssertModel(models[0],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatch(connection, 71, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        TimeSpantime0M.AssertModel(models[0],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        TimeSpantime0M.AssertModel(models[0],_testData[11], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[12], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[13], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[16],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[17],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[18],_testData[29], false);
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
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
TimeSpantime0M.AssertModel(models[0],_testData[21], false);TimeSpantime0M.AssertModel(models[1],_testData[22], false);TimeSpantime0M.AssertModel(models[2],_testData[23], false);TimeSpantime0M.AssertModel(models[3],_testData[24], false);TimeSpantime0M.AssertModel(models[4],_testData[25], false);TimeSpantime0M.AssertModel(models[5],_testData[26], false);TimeSpantime0M.AssertModel(models[6],_testData[27], false);TimeSpantime0M.AssertModel(models[7],_testData[28], false);TimeSpantime0M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
TimeSpantime0M.AssertModel(models[0],_testData[12], false);TimeSpantime0M.AssertModel(models[1],_testData[13], false);TimeSpantime0M.AssertModel(models[2],_testData[14], false);TimeSpantime0M.AssertModel(models[3],_testData[15], false);TimeSpantime0M.AssertModel(models[4],_testData[16], false);TimeSpantime0M.AssertModel(models[5],_testData[17], false);TimeSpantime0M.AssertModel(models[6],_testData[18], false);TimeSpantime0M.AssertModel(models[7],_testData[19], false);TimeSpantime0M.AssertModel(models[8],_testData[20], false);TimeSpantime0M.AssertModel(models[9],_testData[21], false);TimeSpantime0M.AssertModel(models[10],_testData[22], false);TimeSpantime0M.AssertModel(models[11],_testData[23], false);TimeSpantime0M.AssertModel(models[12],_testData[24], false);TimeSpantime0M.AssertModel(models[13],_testData[25], false);TimeSpantime0M.AssertModel(models[14],_testData[26], false);TimeSpantime0M.AssertModel(models[15],_testData[27], false);TimeSpantime0M.AssertModel(models[16],_testData[28], false);TimeSpantime0M.AssertModel(models[17],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 32, milliseconds: 877))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 42, milliseconds: 923))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 17, milliseconds: 242))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 22, milliseconds: 1))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 31, milliseconds: 523))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 41, seconds: 5, milliseconds: 679))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 37, milliseconds: 476))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 20, milliseconds: 756))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 4, milliseconds: 308))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 8, milliseconds: 986))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 21, milliseconds: 420))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 38, milliseconds: 377))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 5, milliseconds: 452))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 11, milliseconds: 193))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 38, milliseconds: 168))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 46, seconds: 57, milliseconds: 384))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 33, milliseconds: 879))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 28, seconds: 14, milliseconds: 955))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 31, milliseconds: 52))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 54, milliseconds: 106))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 18, milliseconds: 472))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 48, milliseconds: 719))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 19, milliseconds: 111))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 21, milliseconds: 520))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 27, seconds: 33, milliseconds: 220))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 17, milliseconds: 280))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 32, milliseconds: 648))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 31, seconds: 22, milliseconds: 872))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 19, milliseconds: 84))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 58, seconds: 23, milliseconds: 995))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 30, milliseconds: 510))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 42, seconds: 47, milliseconds: 127))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 38, milliseconds: 262))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 23, seconds: 6, milliseconds: 646))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 20, milliseconds: 931))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 37, milliseconds: 706))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 18, milliseconds: 76))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 54, seconds: 18, milliseconds: 589))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 17, milliseconds: 727))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 19, milliseconds: 888))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 27, milliseconds: 574))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 14, seconds: 11, milliseconds: 178))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 13, seconds: 10, milliseconds: 29))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 33, milliseconds: 286))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 14, milliseconds: 148))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 50, milliseconds: 772))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 30, milliseconds: 75))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 34, milliseconds: 992))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 7, milliseconds: 807))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 40, milliseconds: 619))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 50, milliseconds: 81))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 30, seconds: 23, milliseconds: 324))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 47, seconds: 7, milliseconds: 253))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 26, milliseconds: 105))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 58, milliseconds: 876))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 51, milliseconds: 651))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 49, milliseconds: 536))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 48, milliseconds: 63))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 55, milliseconds: 122))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 1, milliseconds: 988))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 52, milliseconds: 101))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 7, milliseconds: 471))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 45, milliseconds: 222))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 46, milliseconds: 423))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 35, milliseconds: 163))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 14, milliseconds: 948))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 12, milliseconds: 303))));//InnerModel.Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 32, milliseconds: 877))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 42, milliseconds: 923))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 17, milliseconds: 242))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 22, milliseconds: 1))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 31, milliseconds: 523))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 41, seconds: 5, milliseconds: 679))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 37, milliseconds: 476))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 20, milliseconds: 756))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 4, milliseconds: 308))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 8, milliseconds: 986))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 21, milliseconds: 420))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 38, milliseconds: 377))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 5, milliseconds: 452))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 11, milliseconds: 193))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 38, milliseconds: 168))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 46, seconds: 57, milliseconds: 384))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 33, milliseconds: 879))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 28, seconds: 14, milliseconds: 955))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 31, milliseconds: 52))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 54, milliseconds: 106))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 18, milliseconds: 472))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 48, milliseconds: 719))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 19, milliseconds: 111))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 21, milliseconds: 520))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 27, seconds: 33, milliseconds: 220))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 17, milliseconds: 280))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 32, milliseconds: 648))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 31, seconds: 22, milliseconds: 872))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 19, milliseconds: 84))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 58, seconds: 23, milliseconds: 995))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 30, milliseconds: 510))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 42, seconds: 47, milliseconds: 127))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 38, milliseconds: 262))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 23, seconds: 6, milliseconds: 646))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 20, milliseconds: 931))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 37, milliseconds: 706))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 18, milliseconds: 76))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 54, seconds: 18, milliseconds: 589))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 17, milliseconds: 727))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 19, milliseconds: 888))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 27, milliseconds: 574))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 14, seconds: 11, milliseconds: 178))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 13, seconds: 10, milliseconds: 29))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 33, milliseconds: 286))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 14, milliseconds: 148))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 50, milliseconds: 772))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 30, milliseconds: 75))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 34, milliseconds: 992))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 7, milliseconds: 807))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 40, milliseconds: 619))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 50, milliseconds: 81))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 30, seconds: 23, milliseconds: 324))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 47, seconds: 7, milliseconds: 253))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 26, milliseconds: 105))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 58, milliseconds: 876))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 51, milliseconds: 651))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 49, milliseconds: 536))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 48, milliseconds: 63))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 55, milliseconds: 122))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 1, milliseconds: 988))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 52, milliseconds: 101))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 7, milliseconds: 471))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 45, milliseconds: 222))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 46, milliseconds: 423))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 35, milliseconds: 163))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 14, milliseconds: 948))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 12, milliseconds: 303))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


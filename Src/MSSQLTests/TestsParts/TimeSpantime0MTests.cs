

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
    Id = 2,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 47, milliseconds: 49),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 58, milliseconds: 200),
},
            new TimeSpantime0M
{
    Id = 3,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 47, milliseconds: 973),
    ModelInner = new TimeSpantime0MI
{
    Id = 3,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 34, milliseconds: 991),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 4,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 22, milliseconds: 997),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 47, milliseconds: 513),
},
            new TimeSpantime0M
{
    Id = 8,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 20, milliseconds: 808),
    ModelInner = new TimeSpantime0MI
{
    Id = 6,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 3, milliseconds: 918),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 49, milliseconds: 283),
},
            new TimeSpantime0M
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 40, milliseconds: 563),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 18,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 47, milliseconds: 287),
    ModelInner = new TimeSpantime0MI
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 41, milliseconds: 585),
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 51, milliseconds: 20),
},
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 50, milliseconds: 777),
},
            new TimeSpantime0M
{
    Id = 20,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 573),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 6, milliseconds: 651),
},
            new TimeSpantime0M
{
    Id = 28,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 37, milliseconds: 226),
    ModelInner = new TimeSpantime0MI
{
    Id = 18,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 31, milliseconds: 176),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 52, seconds: 22, milliseconds: 216),
},
            new TimeSpantime0M
{
    Id = 33,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 34, milliseconds: 936),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 54, milliseconds: 346),
},
            new TimeSpantime0M
{
    Id = 40,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 37, milliseconds: 731),
    ModelInner = new TimeSpantime0MI
{
    Id = 22,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 25, milliseconds: 737),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 47, milliseconds: 927),
},
            new TimeSpantime0M
{
    Id = 46,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 17, milliseconds: 722),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 54,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 20, milliseconds: 496),
    ModelInner = new TimeSpantime0MI
{
    Id = 28,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 43, milliseconds: 864),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 60,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 16, milliseconds: 152),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 68,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 20, milliseconds: 269),
    ModelInner = new TimeSpantime0MI
{
    Id = 37,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 29, milliseconds: 573),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 69,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 3, milliseconds: 309),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 55, milliseconds: 853),
},
            new TimeSpantime0M
{
    Id = 77,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 14, milliseconds: 785),
    ModelInner = new TimeSpantime0MI
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 4, milliseconds: 907),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 85,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 1, milliseconds: 733),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 88,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 13, milliseconds: 814),
    ModelInner = new TimeSpantime0MI
{
    Id = 47,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 27, milliseconds: 223),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 94,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 5, milliseconds: 881),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 97,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 12, milliseconds: 802),
    ModelInner = new TimeSpantime0MI
{
    Id = 56,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 0, milliseconds: 611),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 102,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 46, milliseconds: 679),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 103,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 244),
    ModelInner = new TimeSpantime0MI
{
    Id = 61,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 32, milliseconds: 258),
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 17, milliseconds: 982),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 111,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 22, milliseconds: 335),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 17, seconds: 18, milliseconds: 935),
},
            new TimeSpantime0M
{
    Id = 115,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 11, milliseconds: 342),
    ModelInner = new TimeSpantime0MI
{
    Id = 62,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 20, seconds: 51, milliseconds: 806),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 116,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 9, milliseconds: 588),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 56, seconds: 45, milliseconds: 956),
},
            new TimeSpantime0M
{
    Id = 120,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 31, milliseconds: 150),
    ModelInner = new TimeSpantime0MI
{
    Id = 64,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 16, milliseconds: 172),
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 4, milliseconds: 46),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 122,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 54, milliseconds: 437),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 19, milliseconds: 543),
},
            new TimeSpantime0M
{
    Id = 126,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 20, milliseconds: 412),
    ModelInner = new TimeSpantime0MI
{
    Id = 66,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 2, milliseconds: 144),
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 28, seconds: 49, milliseconds: 707),
},
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 11, milliseconds: 770),
},
            new TimeSpantime0M
{
    Id = 127,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 6, milliseconds: 782),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 1, milliseconds: 336),
},
            new TimeSpantime0M
{
    Id = 136,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 2, milliseconds: 981),
    ModelInner = new TimeSpantime0MI
{
    Id = 74,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 54, milliseconds: 272),
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 6, milliseconds: 140),
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
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
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models =  ((ITimeSpanSingleTypetime)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models =  ((ITimeSpanSingleTypetime)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpantime0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantime0M)],
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
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
                        Assert.That(models, Has.Count.EqualTo(2));
FlatTimeSpantime0M.AssertModel(models[0],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatTimeSpantime0M.AssertModel(models[0],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[29], false);
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
                        Assert.That(models, Has.Count.EqualTo(18));
FlatTimeSpantime0M.AssertModel(models[0],_testData[12], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[13], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[14], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[15], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[14],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[15],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[16],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatTimeSpantime0M.AssertModel(models[0],_testData[11], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[12], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[13], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[14], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[15], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[14],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[15],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[16],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[17],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
TimeSpantime0M.AssertModel(models[0],_testData[4], false);TimeSpantime0M.AssertModel(models[1],_testData[5], false);TimeSpantime0M.AssertModel(models[2],_testData[6], false);TimeSpantime0M.AssertModel(models[3],_testData[7], false);TimeSpantime0M.AssertModel(models[4],_testData[8], false);TimeSpantime0M.AssertModel(models[5],_testData[9], false);TimeSpantime0M.AssertModel(models[6],_testData[10], false);TimeSpantime0M.AssertModel(models[7],_testData[11], false);TimeSpantime0M.AssertModel(models[8],_testData[12], false);TimeSpantime0M.AssertModel(models[9],_testData[13], false);TimeSpantime0M.AssertModel(models[10],_testData[14], false);TimeSpantime0M.AssertModel(models[11],_testData[15], false);TimeSpantime0M.AssertModel(models[12],_testData[16], false);TimeSpantime0M.AssertModel(models[13],_testData[17], false);TimeSpantime0M.AssertModel(models[14],_testData[18], false);TimeSpantime0M.AssertModel(models[15],_testData[19], false);TimeSpantime0M.AssertModel(models[16],_testData[20], false);TimeSpantime0M.AssertModel(models[17],_testData[21], false);TimeSpantime0M.AssertModel(models[18],_testData[22], false);TimeSpantime0M.AssertModel(models[19],_testData[23], false);TimeSpantime0M.AssertModel(models[20],_testData[24], false);TimeSpantime0M.AssertModel(models[21],_testData[25], false);TimeSpantime0M.AssertModel(models[22],_testData[26], false);TimeSpantime0M.AssertModel(models[23],_testData[27], false);TimeSpantime0M.AssertModel(models[24],_testData[28], false);TimeSpantime0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
TimeSpantime0M.AssertModel(models[0],_testData[10], false);TimeSpantime0M.AssertModel(models[1],_testData[11], false);TimeSpantime0M.AssertModel(models[2],_testData[12], false);TimeSpantime0M.AssertModel(models[3],_testData[13], false);TimeSpantime0M.AssertModel(models[4],_testData[14], false);TimeSpantime0M.AssertModel(models[5],_testData[15], false);TimeSpantime0M.AssertModel(models[6],_testData[16], false);TimeSpantime0M.AssertModel(models[7],_testData[17], false);TimeSpantime0M.AssertModel(models[8],_testData[18], false);TimeSpantime0M.AssertModel(models[9],_testData[19], false);TimeSpantime0M.AssertModel(models[10],_testData[20], false);TimeSpantime0M.AssertModel(models[11],_testData[21], false);TimeSpantime0M.AssertModel(models[12],_testData[22], false);TimeSpantime0M.AssertModel(models[13],_testData[23], false);TimeSpantime0M.AssertModel(models[14],_testData[24], false);TimeSpantime0M.AssertModel(models[15],_testData[25], false);TimeSpantime0M.AssertModel(models[16],_testData[26], false);TimeSpantime0M.AssertModel(models[17],_testData[27], false);TimeSpantime0M.AssertModel(models[18],_testData[28], false);TimeSpantime0M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
TimeSpantime0M.AssertModel(models[0],_testData[19], false);TimeSpantime0M.AssertModel(models[1],_testData[20], false);TimeSpantime0M.AssertModel(models[2],_testData[21], false);TimeSpantime0M.AssertModel(models[3],_testData[22], false);TimeSpantime0M.AssertModel(models[4],_testData[23], false);TimeSpantime0M.AssertModel(models[5],_testData[24], false);TimeSpantime0M.AssertModel(models[6],_testData[25], false);TimeSpantime0M.AssertModel(models[7],_testData[26], false);TimeSpantime0M.AssertModel(models[8],_testData[27], false);TimeSpantime0M.AssertModel(models[9],_testData[28], false);TimeSpantime0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
TimeSpantime0M.AssertModel(models[0],_testData[4], false);TimeSpantime0M.AssertModel(models[1],_testData[5], false);TimeSpantime0M.AssertModel(models[2],_testData[6], false);TimeSpantime0M.AssertModel(models[3],_testData[7], false);TimeSpantime0M.AssertModel(models[4],_testData[8], false);TimeSpantime0M.AssertModel(models[5],_testData[9], false);TimeSpantime0M.AssertModel(models[6],_testData[10], false);TimeSpantime0M.AssertModel(models[7],_testData[11], false);TimeSpantime0M.AssertModel(models[8],_testData[12], false);TimeSpantime0M.AssertModel(models[9],_testData[13], false);TimeSpantime0M.AssertModel(models[10],_testData[14], false);TimeSpantime0M.AssertModel(models[11],_testData[15], false);TimeSpantime0M.AssertModel(models[12],_testData[16], false);TimeSpantime0M.AssertModel(models[13],_testData[17], false);TimeSpantime0M.AssertModel(models[14],_testData[18], false);TimeSpantime0M.AssertModel(models[15],_testData[19], false);TimeSpantime0M.AssertModel(models[16],_testData[20], false);TimeSpantime0M.AssertModel(models[17],_testData[21], false);TimeSpantime0M.AssertModel(models[18],_testData[22], false);TimeSpantime0M.AssertModel(models[19],_testData[23], false);TimeSpantime0M.AssertModel(models[20],_testData[24], false);TimeSpantime0M.AssertModel(models[21],_testData[25], false);TimeSpantime0M.AssertModel(models[22],_testData[26], false);TimeSpantime0M.AssertModel(models[23],_testData[27], false);TimeSpantime0M.AssertModel(models[24],_testData[28], false);TimeSpantime0M.AssertModel(models[25],_testData[29], false);
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 18, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatTimeSpantime0M.AssertModel(models[0],_testData[6], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[7], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[8], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[9], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[10], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[11], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[12], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[13], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[14], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[15], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[14],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[15],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[16],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[17],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[18],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[19],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[20],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[21],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[22],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[23],_testData[29], false);
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
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 2, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatTimeSpantime0M.AssertModel(models[0],_testData[14], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[15], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[14],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatTimeSpantime0M.AssertModel(models[0],_testData[1], false);FlatTimeSpantime0M.AssertModel(models[1],_testData[2], false);FlatTimeSpantime0M.AssertModel(models[2],_testData[3], false);FlatTimeSpantime0M.AssertModel(models[3],_testData[4], false);FlatTimeSpantime0M.AssertModel(models[4],_testData[5], false);FlatTimeSpantime0M.AssertModel(models[5],_testData[6], false);FlatTimeSpantime0M.AssertModel(models[6],_testData[7], false);FlatTimeSpantime0M.AssertModel(models[7],_testData[8], false);FlatTimeSpantime0M.AssertModel(models[8],_testData[9], false);FlatTimeSpantime0M.AssertModel(models[9],_testData[10], false);FlatTimeSpantime0M.AssertModel(models[10],_testData[11], false);FlatTimeSpantime0M.AssertModel(models[11],_testData[12], false);FlatTimeSpantime0M.AssertModel(models[12],_testData[13], false);FlatTimeSpantime0M.AssertModel(models[13],_testData[14], false);FlatTimeSpantime0M.AssertModel(models[14],_testData[15], false);FlatTimeSpantime0M.AssertModel(models[15],_testData[16], false);FlatTimeSpantime0M.AssertModel(models[16],_testData[17], false);FlatTimeSpantime0M.AssertModel(models[17],_testData[18], false);FlatTimeSpantime0M.AssertModel(models[18],_testData[19], false);FlatTimeSpantime0M.AssertModel(models[19],_testData[20], false);FlatTimeSpantime0M.AssertModel(models[20],_testData[21], false);FlatTimeSpantime0M.AssertModel(models[21],_testData[22], false);FlatTimeSpantime0M.AssertModel(models[22],_testData[23], false);FlatTimeSpantime0M.AssertModel(models[23],_testData[24], false);FlatTimeSpantime0M.AssertModel(models[24],_testData[25], false);FlatTimeSpantime0M.AssertModel(models[25],_testData[26], false);FlatTimeSpantime0M.AssertModel(models[26],_testData[27], false);FlatTimeSpantime0M.AssertModel(models[27],_testData[28], false);FlatTimeSpantime0M.AssertModel(models[28],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelBatchAsync(connection, 2, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
TimeSpantime0M.AssertModel(models[0],_testData[1], false);TimeSpantime0M.AssertModel(models[1],_testData[2], false);TimeSpantime0M.AssertModel(models[2],_testData[3], false);TimeSpantime0M.AssertModel(models[3],_testData[4], false);TimeSpantime0M.AssertModel(models[4],_testData[5], false);TimeSpantime0M.AssertModel(models[5],_testData[6], false);TimeSpantime0M.AssertModel(models[6],_testData[7], false);TimeSpantime0M.AssertModel(models[7],_testData[8], false);TimeSpantime0M.AssertModel(models[8],_testData[9], false);TimeSpantime0M.AssertModel(models[9],_testData[10], false);TimeSpantime0M.AssertModel(models[10],_testData[11], false);TimeSpantime0M.AssertModel(models[11],_testData[12], false);TimeSpantime0M.AssertModel(models[12],_testData[13], false);TimeSpantime0M.AssertModel(models[13],_testData[14], false);TimeSpantime0M.AssertModel(models[14],_testData[15], false);TimeSpantime0M.AssertModel(models[15],_testData[16], false);TimeSpantime0M.AssertModel(models[16],_testData[17], false);TimeSpantime0M.AssertModel(models[17],_testData[18], false);TimeSpantime0M.AssertModel(models[18],_testData[19], false);TimeSpantime0M.AssertModel(models[19],_testData[20], false);TimeSpantime0M.AssertModel(models[20],_testData[21], false);TimeSpantime0M.AssertModel(models[21],_testData[22], false);TimeSpantime0M.AssertModel(models[22],_testData[23], false);TimeSpantime0M.AssertModel(models[23],_testData[24], false);TimeSpantime0M.AssertModel(models[24],_testData[25], false);TimeSpantime0M.AssertModel(models[25],_testData[26], false);TimeSpantime0M.AssertModel(models[26],_testData[27], false);TimeSpantime0M.AssertModel(models[27],_testData[28], false);TimeSpantime0M.AssertModel(models[28],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelBatch(connection, 120, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
TimeSpantime0M.AssertModel(models[0],_testData[26], false);TimeSpantime0M.AssertModel(models[1],_testData[27], false);TimeSpantime0M.AssertModel(models[2],_testData[28], false);TimeSpantime0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
TimeSpantime0M.AssertModel(models[0],_testData[16], false);TimeSpantime0M.AssertModel(models[1],_testData[17], false);TimeSpantime0M.AssertModel(models[2],_testData[18], false);TimeSpantime0M.AssertModel(models[3],_testData[19], false);TimeSpantime0M.AssertModel(models[4],_testData[20], false);TimeSpantime0M.AssertModel(models[5],_testData[21], false);TimeSpantime0M.AssertModel(models[6],_testData[22], false);TimeSpantime0M.AssertModel(models[7],_testData[23], false);TimeSpantime0M.AssertModel(models[8],_testData[24], false);TimeSpantime0M.AssertModel(models[9],_testData[25], false);TimeSpantime0M.AssertModel(models[10],_testData[26], false);TimeSpantime0M.AssertModel(models[11],_testData[27], false);TimeSpantime0M.AssertModel(models[12],_testData[28], false);TimeSpantime0M.AssertModel(models[13],_testData[29], false);
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
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
TimeSpantime0M.AssertModel(models[0],_testData[14], false);TimeSpantime0M.AssertModel(models[1],_testData[15], false);TimeSpantime0M.AssertModel(models[2],_testData[16], false);TimeSpantime0M.AssertModel(models[3],_testData[17], false);TimeSpantime0M.AssertModel(models[4],_testData[18], false);TimeSpantime0M.AssertModel(models[5],_testData[19], false);TimeSpantime0M.AssertModel(models[6],_testData[20], false);TimeSpantime0M.AssertModel(models[7],_testData[21], false);TimeSpantime0M.AssertModel(models[8],_testData[22], false);TimeSpantime0M.AssertModel(models[9],_testData[23], false);TimeSpantime0M.AssertModel(models[10],_testData[24], false);TimeSpantime0M.AssertModel(models[11],_testData[25], false);TimeSpantime0M.AssertModel(models[12],_testData[26], false);TimeSpantime0M.AssertModel(models[13],_testData[27], false);TimeSpantime0M.AssertModel(models[14],_testData[28], false);TimeSpantime0M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
TimeSpantime0M.AssertModel(models[0],_testData[7], false);TimeSpantime0M.AssertModel(models[1],_testData[8], false);TimeSpantime0M.AssertModel(models[2],_testData[9], false);TimeSpantime0M.AssertModel(models[3],_testData[10], false);TimeSpantime0M.AssertModel(models[4],_testData[11], false);TimeSpantime0M.AssertModel(models[5],_testData[12], false);TimeSpantime0M.AssertModel(models[6],_testData[13], false);TimeSpantime0M.AssertModel(models[7],_testData[14], false);TimeSpantime0M.AssertModel(models[8],_testData[15], false);TimeSpantime0M.AssertModel(models[9],_testData[16], false);TimeSpantime0M.AssertModel(models[10],_testData[17], false);TimeSpantime0M.AssertModel(models[11],_testData[18], false);TimeSpantime0M.AssertModel(models[12],_testData[19], false);TimeSpantime0M.AssertModel(models[13],_testData[20], false);TimeSpantime0M.AssertModel(models[14],_testData[21], false);TimeSpantime0M.AssertModel(models[15],_testData[22], false);TimeSpantime0M.AssertModel(models[16],_testData[23], false);TimeSpantime0M.AssertModel(models[17],_testData[24], false);TimeSpantime0M.AssertModel(models[18],_testData[25], false);TimeSpantime0M.AssertModel(models[19],_testData[26], false);TimeSpantime0M.AssertModel(models[20],_testData[27], false);TimeSpantime0M.AssertModel(models[21],_testData[28], false);TimeSpantime0M.AssertModel(models[22],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 47, milliseconds: 49))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 58, milliseconds: 200))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 47, milliseconds: 973))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 34, milliseconds: 991))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 22, milliseconds: 997))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 47, milliseconds: 513))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 20, milliseconds: 808))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 3, milliseconds: 918))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 49, milliseconds: 283))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 40, milliseconds: 563))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 47, milliseconds: 287))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 41, milliseconds: 585))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 51, milliseconds: 20))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 50, milliseconds: 777))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 573))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 6, milliseconds: 651))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 37, milliseconds: 226))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 31, milliseconds: 176))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 52, seconds: 22, milliseconds: 216))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 34, milliseconds: 936))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 54, milliseconds: 346))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 37, milliseconds: 731))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 25, milliseconds: 737))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 47, milliseconds: 927))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 17, milliseconds: 722))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 20, milliseconds: 496))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 43, milliseconds: 864))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 16, milliseconds: 152))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 20, milliseconds: 269))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 29, milliseconds: 573))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 3, milliseconds: 309))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 55, milliseconds: 853))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 14, milliseconds: 785))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 4, milliseconds: 907))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 1, milliseconds: 733))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 13, milliseconds: 814))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 27, milliseconds: 223))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 5, milliseconds: 881))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 12, milliseconds: 802))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 0, milliseconds: 611))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 46, milliseconds: 679))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 244))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 32, milliseconds: 258))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 17, milliseconds: 982))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 22, milliseconds: 335))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 17, seconds: 18, milliseconds: 935))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 11, milliseconds: 342))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 20, seconds: 51, milliseconds: 806))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 9, milliseconds: 588))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 56, seconds: 45, milliseconds: 956))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 31, milliseconds: 150))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 16, milliseconds: 172))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 4, milliseconds: 46))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 54, milliseconds: 437))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 19, milliseconds: 543))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 20, milliseconds: 412))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 2, milliseconds: 144))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 28, seconds: 49, milliseconds: 707))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 11, milliseconds: 770))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 6, milliseconds: 782))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 1, milliseconds: 336))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 2, milliseconds: 981))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 54, milliseconds: 272))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 6, milliseconds: 140))));//InnerModel.NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 47, milliseconds: 49))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 58, milliseconds: 200))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 47, milliseconds: 973))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 34, milliseconds: 991))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 22, milliseconds: 997))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 47, milliseconds: 513))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 20, milliseconds: 808))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 3, milliseconds: 918))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 49, milliseconds: 283))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 40, milliseconds: 563))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 47, milliseconds: 287))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 41, milliseconds: 585))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 51, milliseconds: 20))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 50, milliseconds: 777))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 573))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 6, milliseconds: 651))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 37, milliseconds: 226))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 31, milliseconds: 176))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 52, seconds: 22, milliseconds: 216))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 34, milliseconds: 936))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 54, milliseconds: 346))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 37, milliseconds: 731))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 25, milliseconds: 737))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 47, milliseconds: 927))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 17, milliseconds: 722))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 20, milliseconds: 496))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 43, milliseconds: 864))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 16, milliseconds: 152))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 20, milliseconds: 269))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 29, milliseconds: 573))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 3, milliseconds: 309))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 55, milliseconds: 853))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 14, milliseconds: 785))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 4, milliseconds: 907))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 1, milliseconds: 733))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 13, milliseconds: 814))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 27, milliseconds: 223))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 5, milliseconds: 881))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 12, milliseconds: 802))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 0, milliseconds: 611))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 46, milliseconds: 679))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 244))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 32, milliseconds: 258))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 17, milliseconds: 982))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 22, milliseconds: 335))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 17, seconds: 18, milliseconds: 935))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 11, milliseconds: 342))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 20, seconds: 51, milliseconds: 806))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 9, milliseconds: 588))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 56, seconds: 45, milliseconds: 956))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 31, milliseconds: 150))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 16, milliseconds: 172))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 4, milliseconds: 46))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 54, milliseconds: 437))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 19, milliseconds: 543))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 20, milliseconds: 412))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 2, milliseconds: 144))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 28, seconds: 49, milliseconds: 707))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 11, milliseconds: 770))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 6, milliseconds: 782))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 1, milliseconds: 336))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 2, milliseconds: 981))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 54, milliseconds: 272))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 6, milliseconds: 140))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


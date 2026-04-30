

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
    Value = new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 17, milliseconds: 33),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 12,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 53, seconds: 25, milliseconds: 87),
    ModelInner = new TimeSpantime0MI
{
    Id = 5,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 2, milliseconds: 58),
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 23, milliseconds: 710),
},
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 37, milliseconds: 693),
},
            new TimeSpantime0M
{
    Id = 20,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 50, milliseconds: 302),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 50, milliseconds: 693),
},
            new TimeSpantime0M
{
    Id = 27,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 50, seconds: 24, milliseconds: 446),
    ModelInner = new TimeSpantime0MI
{
    Id = 7,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 12, milliseconds: 103),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 5, milliseconds: 724),
},
            new TimeSpantime0M
{
    Id = 36,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 7, milliseconds: 855),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 45,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 49, milliseconds: 957),
    ModelInner = new TimeSpantime0MI
{
    Id = 16,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 14, milliseconds: 159),
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 15, milliseconds: 622),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 47,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 37, milliseconds: 336),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 44, milliseconds: 12),
},
            new TimeSpantime0M
{
    Id = 56,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 13, seconds: 31, milliseconds: 119),
    ModelInner = new TimeSpantime0MI
{
    Id = 23,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 51, milliseconds: 608),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 13, milliseconds: 2),
},
            new TimeSpantime0M
{
    Id = 57,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 0, milliseconds: 330),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 59,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 46, milliseconds: 936),
    ModelInner = new TimeSpantime0MI
{
    Id = 30,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 27, milliseconds: 43),
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 438),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 60,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 3, milliseconds: 926),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 61,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 19, milliseconds: 876),
    ModelInner = new TimeSpantime0MI
{
    Id = 32,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 39, seconds: 38, milliseconds: 873),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 62,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 9, seconds: 52, milliseconds: 136),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 5, milliseconds: 838),
},
            new TimeSpantime0M
{
    Id = 64,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 50, milliseconds: 917),
    ModelInner = new TimeSpantime0MI
{
    Id = 35,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 44, seconds: 45, milliseconds: 166),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 18, milliseconds: 592),
},
            new TimeSpantime0M
{
    Id = 73,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 22, milliseconds: 477),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 21, milliseconds: 411),
},
            new TimeSpantime0M
{
    Id = 77,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 11, seconds: 20, milliseconds: 374),
    ModelInner = new TimeSpantime0MI
{
    Id = 44,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 18, milliseconds: 484),
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 16, milliseconds: 588),
},
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 45, milliseconds: 99),
},
            new TimeSpantime0M
{
    Id = 80,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 6, milliseconds: 247),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 89,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 4, milliseconds: 433),
    ModelInner = new TimeSpantime0MI
{
    Id = 52,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 51, milliseconds: 372),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 3, milliseconds: 702),
},
            new TimeSpantime0M
{
    Id = 98,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 6, milliseconds: 811),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 106,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 56, milliseconds: 750),
    ModelInner = new TimeSpantime0MI
{
    Id = 57,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 52, milliseconds: 777),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 27, milliseconds: 34),
},
            new TimeSpantime0M
{
    Id = 112,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 23, milliseconds: 128),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 11, milliseconds: 144),
},
            new TimeSpantime0M
{
    Id = 121,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 3, milliseconds: 116),
    ModelInner = new TimeSpantime0MI
{
    Id = 61,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 9, milliseconds: 859),
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 40, milliseconds: 165),
},
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 51, milliseconds: 531),
},
            new TimeSpantime0M
{
    Id = 129,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 36, milliseconds: 971),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 131,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 50, milliseconds: 956),
    ModelInner = new TimeSpantime0MI
{
    Id = 68,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 53, seconds: 28, milliseconds: 446),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 47, milliseconds: 128),
},
            new TimeSpantime0M
{
    Id = 139,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 10, milliseconds: 763),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 40, milliseconds: 218),
},
            new TimeSpantime0M
{
    Id = 141,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 24, seconds: 56, milliseconds: 7),
    ModelInner = new TimeSpantime0MI
{
    Id = 70,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 43, milliseconds: 166),
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 41, milliseconds: 818),
},
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 143,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 24, milliseconds: 93),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 147,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 11, milliseconds: 972),
    ModelInner = new TimeSpantime0MI
{
    Id = 73,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 38, seconds: 40, milliseconds: 169),
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 8, seconds: 50, milliseconds: 213),
},
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 32, milliseconds: 182),
},
            new TimeSpantime0M
{
    Id = 153,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 7, milliseconds: 233),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantime0M
{
    Id = 156,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 55, milliseconds: 610),
    ModelInner = new TimeSpantime0MI
{
    Id = 82,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 31, seconds: 23, milliseconds: 857),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 49, milliseconds: 807),
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[29], false);
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
                parametr1.Value = 147;
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
                 ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[29], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[29], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[13],_testData[29], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeSpantime0M.AssertModel(models[0],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        TimeSpantime0M.AssertModel(models[0],_testData[12], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[13], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[16],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        TimeSpantime0M.AssertModel(models[0],_testData[5], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[6], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[7], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[8], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[9], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[10], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[11], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[12], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[13], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[16],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[17],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[18],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[19],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[20],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[21],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[22],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[23],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[24],_testData[29], false);
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
                await ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 77, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(secondItems2[12],_testData[29], false);
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
                await ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 77, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpantime0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[29], false);
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
                 ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatTimeSpantime0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(secondItems1[7],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 147, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[29], false);
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
                await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatch(connection, 139, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeSpantime0M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(models[13],_testData[29], false);
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
                 ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatch(connection, 20, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatTimeSpantime0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeSpantime0M.AssertModel(firstItems1[26],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatchAsync(connection, 147, 59))
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatch(connection, 59, 56))
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeSpantime0M.AssertModel(models[0],_testData[8], false);
                        TimeSpantime0M.AssertModel(models[1],_testData[9], false);
                        TimeSpantime0M.AssertModel(models[2],_testData[10], false);
                        TimeSpantime0M.AssertModel(models[3],_testData[11], false);
                        TimeSpantime0M.AssertModel(models[4],_testData[12], false);
                        TimeSpantime0M.AssertModel(models[5],_testData[13], false);
                        TimeSpantime0M.AssertModel(models[6],_testData[14], false);
                        TimeSpantime0M.AssertModel(models[7],_testData[15], false);
                        TimeSpantime0M.AssertModel(models[8],_testData[16], false);
                        TimeSpantime0M.AssertModel(models[9],_testData[17], false);
                        TimeSpantime0M.AssertModel(models[10],_testData[18], false);
                        TimeSpantime0M.AssertModel(models[11],_testData[19], false);
                        TimeSpantime0M.AssertModel(models[12],_testData[20], false);
                        TimeSpantime0M.AssertModel(models[13],_testData[21], false);
                        TimeSpantime0M.AssertModel(models[14],_testData[22], false);
                        TimeSpantime0M.AssertModel(models[15],_testData[23], false);
                        TimeSpantime0M.AssertModel(models[16],_testData[24], false);
                        TimeSpantime0M.AssertModel(models[17],_testData[25], false);
                        TimeSpantime0M.AssertModel(models[18],_testData[26], false);
                        TimeSpantime0M.AssertModel(models[19],_testData[27], false);
                        TimeSpantime0M.AssertModel(models[20],_testData[28], false);
                        TimeSpantime0M.AssertModel(models[21],_testData[29], false);
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
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
TimeSpantime0M.AssertModel(models[0],_testData[24], false);TimeSpantime0M.AssertModel(models[1],_testData[25], false);TimeSpantime0M.AssertModel(models[2],_testData[26], false);TimeSpantime0M.AssertModel(models[3],_testData[27], false);TimeSpantime0M.AssertModel(models[4],_testData[28], false);TimeSpantime0M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
TimeSpantime0M.AssertModel(models[0],_testData[6], false);TimeSpantime0M.AssertModel(models[1],_testData[7], false);TimeSpantime0M.AssertModel(models[2],_testData[8], false);TimeSpantime0M.AssertModel(models[3],_testData[9], false);TimeSpantime0M.AssertModel(models[4],_testData[10], false);TimeSpantime0M.AssertModel(models[5],_testData[11], false);TimeSpantime0M.AssertModel(models[6],_testData[12], false);TimeSpantime0M.AssertModel(models[7],_testData[13], false);TimeSpantime0M.AssertModel(models[8],_testData[14], false);TimeSpantime0M.AssertModel(models[9],_testData[15], false);TimeSpantime0M.AssertModel(models[10],_testData[16], false);TimeSpantime0M.AssertModel(models[11],_testData[17], false);TimeSpantime0M.AssertModel(models[12],_testData[18], false);TimeSpantime0M.AssertModel(models[13],_testData[19], false);TimeSpantime0M.AssertModel(models[14],_testData[20], false);TimeSpantime0M.AssertModel(models[15],_testData[21], false);TimeSpantime0M.AssertModel(models[16],_testData[22], false);TimeSpantime0M.AssertModel(models[17],_testData[23], false);TimeSpantime0M.AssertModel(models[18],_testData[24], false);TimeSpantime0M.AssertModel(models[19],_testData[25], false);TimeSpantime0M.AssertModel(models[20],_testData[26], false);TimeSpantime0M.AssertModel(models[21],_testData[27], false);TimeSpantime0M.AssertModel(models[22],_testData[28], false);TimeSpantime0M.AssertModel(models[23],_testData[29], false);
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
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 17, milliseconds: 33))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 53, seconds: 25, milliseconds: 87))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 2, milliseconds: 58))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 23, milliseconds: 710))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 37, milliseconds: 693))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 50, milliseconds: 302))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 50, milliseconds: 693))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 50, seconds: 24, milliseconds: 446))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 12, milliseconds: 103))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 5, milliseconds: 724))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 7, milliseconds: 855))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 49, milliseconds: 957))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 14, milliseconds: 159))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 15, milliseconds: 622))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 37, milliseconds: 336))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 44, milliseconds: 12))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 13, seconds: 31, milliseconds: 119))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 51, milliseconds: 608))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 13, milliseconds: 2))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 0, milliseconds: 330))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 46, milliseconds: 936))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 27, milliseconds: 43))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 438))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 3, milliseconds: 926))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 19, milliseconds: 876))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 39, seconds: 38, milliseconds: 873))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 9, seconds: 52, milliseconds: 136))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 5, milliseconds: 838))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 50, milliseconds: 917))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 44, seconds: 45, milliseconds: 166))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 18, milliseconds: 592))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 22, milliseconds: 477))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 21, milliseconds: 411))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 11, seconds: 20, milliseconds: 374))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 18, milliseconds: 484))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 16, milliseconds: 588))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 45, milliseconds: 99))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 6, milliseconds: 247))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 4, milliseconds: 433))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 51, milliseconds: 372))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 3, milliseconds: 702))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 6, milliseconds: 811))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 56, milliseconds: 750))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 52, milliseconds: 777))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 27, milliseconds: 34))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 23, milliseconds: 128))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 11, milliseconds: 144))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 3, milliseconds: 116))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 9, milliseconds: 859))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 40, milliseconds: 165))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 51, milliseconds: 531))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 36, milliseconds: 971))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 50, milliseconds: 956))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 53, seconds: 28, milliseconds: 446))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 47, milliseconds: 128))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 10, milliseconds: 763))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 40, milliseconds: 218))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 24, seconds: 56, milliseconds: 7))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 43, milliseconds: 166))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 41, milliseconds: 818))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 24, milliseconds: 93))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 11, milliseconds: 972))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 38, seconds: 40, milliseconds: 169))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 8, seconds: 50, milliseconds: 213))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 32, milliseconds: 182))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 7, milliseconds: 233))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 55, milliseconds: 610))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 31, seconds: 23, milliseconds: 857))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 49, milliseconds: 807))));

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
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 17, milliseconds: 33))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 53, seconds: 25, milliseconds: 87))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 2, milliseconds: 58))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 23, milliseconds: 710))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 37, milliseconds: 693))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 50, milliseconds: 302))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 50, milliseconds: 693))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 50, seconds: 24, milliseconds: 446))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 12, milliseconds: 103))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 5, milliseconds: 724))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 7, milliseconds: 855))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 49, milliseconds: 957))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 14, milliseconds: 159))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 15, milliseconds: 622))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 37, milliseconds: 336))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 44, milliseconds: 12))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 13, seconds: 31, milliseconds: 119))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 51, milliseconds: 608))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 13, milliseconds: 2))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 0, milliseconds: 330))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 46, milliseconds: 936))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 27, milliseconds: 43))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 37, milliseconds: 438))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 3, milliseconds: 926))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 19, milliseconds: 876))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 39, seconds: 38, milliseconds: 873))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 9, seconds: 52, milliseconds: 136))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 5, milliseconds: 838))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 50, milliseconds: 917))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 44, seconds: 45, milliseconds: 166))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 18, milliseconds: 592))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 22, milliseconds: 477))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 21, milliseconds: 411))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 11, seconds: 20, milliseconds: 374))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 18, milliseconds: 484))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 16, milliseconds: 588))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 45, milliseconds: 99))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 6, milliseconds: 247))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 4, milliseconds: 433))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 51, milliseconds: 372))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 3, milliseconds: 702))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 6, milliseconds: 811))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 56, milliseconds: 750))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 52, milliseconds: 777))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 27, milliseconds: 34))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 23, milliseconds: 128))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 11, milliseconds: 144))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 3, milliseconds: 116))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 9, milliseconds: 859))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 40, milliseconds: 165))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 51, milliseconds: 531))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 36, milliseconds: 971))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 50, milliseconds: 956))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 53, seconds: 28, milliseconds: 446))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 47, milliseconds: 128))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 10, milliseconds: 763))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 40, milliseconds: 218))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 24, seconds: 56, milliseconds: 7))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 43, milliseconds: 166))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 41, milliseconds: 818))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 24, milliseconds: 93))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 11, milliseconds: 972))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 38, seconds: 40, milliseconds: 169))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 8, seconds: 50, milliseconds: 213))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 32, milliseconds: 182))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 7, milliseconds: 233))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 55, milliseconds: 610))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 31, seconds: 23, milliseconds: 857))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 49, milliseconds: 807))));

            }
        }

#endregion

    }
}


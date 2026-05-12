

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

        private readonly TimeSpantimeE0M[] _testData = new TimeSpantimeE0M[]
        {
            new TimeSpantimeE0M
{
    Id = 2,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 41, milliseconds: 141),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 33, milliseconds: 864),
},
            new TimeSpantimeE0M
{
    Id = 9,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 57, milliseconds: 821),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 3,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 14, milliseconds: 226),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 17, milliseconds: 889),
},
            new TimeSpantimeE0M
{
    Id = 11,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 53, milliseconds: 860),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 21, milliseconds: 705),
},
            new TimeSpantimeE0M
{
    Id = 19,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 54, milliseconds: 120),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 6,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 58, milliseconds: 401),
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 713),
},
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 30, seconds: 19, milliseconds: 0),
},
            new TimeSpantimeE0M
{
    Id = 22,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 40, milliseconds: 837),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 40, milliseconds: 680),
},
            new TimeSpantimeE0M
{
    Id = 29,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 31, milliseconds: 854),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 11,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 11, milliseconds: 530),
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 0, milliseconds: 725),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 36,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 47, milliseconds: 786),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 44,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 20, milliseconds: 41),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 16, milliseconds: 52),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 22, milliseconds: 217),
},
            new TimeSpantimeE0M
{
    Id = 53,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 40, milliseconds: 157),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 55,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 45, milliseconds: 394),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 23,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 10, milliseconds: 285),
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 0, milliseconds: 722),
},
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 18, milliseconds: 114),
},
            new TimeSpantimeE0M
{
    Id = 62,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 18, milliseconds: 82),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 65,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 17, milliseconds: 150),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 31,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 22, milliseconds: 52),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 33, milliseconds: 890),
},
            new TimeSpantimeE0M
{
    Id = 69,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 48, milliseconds: 784),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 47, seconds: 41, milliseconds: 911),
},
            new TimeSpantimeE0M
{
    Id = 70,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 40, seconds: 38, milliseconds: 395),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 37,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 44, milliseconds: 230),
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 55, milliseconds: 404),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 72,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 22, milliseconds: 982),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 77,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 36, milliseconds: 435),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 11, milliseconds: 572),
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 0, milliseconds: 569),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 86,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 1, milliseconds: 704),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 22, milliseconds: 806),
},
            new TimeSpantimeE0M
{
    Id = 88,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 51, milliseconds: 411),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 48,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 53, milliseconds: 370),
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 807),
},
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 27, milliseconds: 117),
},
            new TimeSpantimeE0M
{
    Id = 91,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 0, milliseconds: 747),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 94,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 52, milliseconds: 653),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 55, milliseconds: 814),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 95,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 20, milliseconds: 465),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 16, milliseconds: 367),
},
            new TimeSpantimeE0M
{
    Id = 98,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 13, milliseconds: 626),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 57,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 57, milliseconds: 40),
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 58, milliseconds: 734),
},
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 9, milliseconds: 496),
},
            new TimeSpantimeE0M
{
    Id = 99,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 29, milliseconds: 261),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 46, milliseconds: 428),
},
            new TimeSpantimeE0M
{
    Id = 103,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 15, milliseconds: 891),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 61,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 36, milliseconds: 1),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 109,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 2, milliseconds: 998),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 19, seconds: 20, milliseconds: 375),
},
            new TimeSpantimeE0M
{
    Id = 115,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 15, milliseconds: 965),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 66,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 39, milliseconds: 481),
    NullableValue = new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 46, milliseconds: 554),
},
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 58, milliseconds: 226),
},
            new TimeSpantimeE0M
{
    Id = 118,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 6, milliseconds: 522),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 49, milliseconds: 12),
},
            new TimeSpantimeE0M
{
    Id = 123,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 34, milliseconds: 350),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 73,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 37, milliseconds: 275),
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 18, milliseconds: 189),
},
    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 16, seconds: 26, milliseconds: 6),
},
            new TimeSpantimeE0M
{
    Id = 126,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 10, seconds: 20, milliseconds: 556),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 29, milliseconds: 893),
},
            new TimeSpantimeE0M
{
    Id = 129,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 23, milliseconds: 198),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 80,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 13, milliseconds: 902),
    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 40, seconds: 37, milliseconds: 924),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 135,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 10, milliseconds: 515),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 10, milliseconds: 980),
},
            new TimeSpantimeE0M
{
    Id = 140,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 26, milliseconds: 187),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 89,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 7, milliseconds: 492),
    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 49, milliseconds: 499),
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 145,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 39, seconds: 20, milliseconds: 724),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 25, milliseconds: 543),
},
            new TimeSpantimeE0M
{
    Id = 147,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 45, milliseconds: 206),
    ModelInner = new TimeSpantimeE0MI
{
    Id = 95,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 23, milliseconds: 785),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpantimeE0M
{
    Id = 149,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 33, milliseconds: 515),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 18, milliseconds: 759),
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.timespantimee0mi(
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
INSERT INTO dbo.timespantimee0mi(
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.timespantimee0m(
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
                parametrName: "timespantimee0mi_id", 
                methodParametrName: "timespantimee0mi_id", 
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
INSERT INTO dbo.timespantimee0m(
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
                parametrName: "timespantimee0mi_id", 
                methodParametrName: "timespantimee0mi_id", 
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M), typeof(FlatTimeSpantimeE0M)],
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
FROM dbo.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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
FROM dbo.timespantimee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M)],
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.timespantimee0m m
LEFT JOIN dbo.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpantimeE0M)],
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
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanSingleTypetime)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpantimeE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M), typeof(FlatTimeSpantimeE0M)],
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpantimeE0M)],
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
LEFT JOIN dbo.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpantimeE0M)],
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
FROM dbo.timespantimee0m m
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
                parametr1.Value = 36;
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
                parametr1.Value = 77;
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[13],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[14],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[15],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[16],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[17],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 55;
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[24],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[25],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[26],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[27],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[28],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM dbo.timespantimee0m m
LEFT JOIN dbo.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[16], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[17], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[18], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[19], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[15],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[16],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[17],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[18],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 129, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var firstItems2 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionMMDynQuerySelectModelBatch(connection, 94, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[13],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[14],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[15],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[16],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[17],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[18],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                await ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 88, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[24],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[25],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[26],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[27],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[28],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeSpantimeE0M.AssertModel(models[0],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(models[1],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(models[2],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(models[3],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(models[4],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(models[5],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(models[6],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(models[7],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(models[8],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(models[9],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(models[10],_testData[34], false);
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
FROM dbo.timespantimee0m m
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
FROM dbo.timespantimee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems1 = new List<FlatTimeSpantimeE0M>();
                var secondItems2 = new List<FlatTimeSpantimeE0M>();
                 ((ITimeSpanSingleTypetime)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 2, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatTimeSpantimeE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM dbo.timespantimee0m m
LEFT JOIN dbo.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
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
                foreach(var batchResult in await ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[15], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[16], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[17], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[18], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[19], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[15],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[16],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[17],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[18],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[1], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[2], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[3], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[4], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[5], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[6], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[7], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[8], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[9], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[10], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[11], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[12], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[13], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[14], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[15], false);
                        TimeSpantimeE0M.AssertModel(models[15],_testData[16], false);
                        TimeSpantimeE0M.AssertModel(models[16],_testData[17], false);
                        TimeSpantimeE0M.AssertModel(models[17],_testData[18], false);
                        TimeSpantimeE0M.AssertModel(models[18],_testData[19], false);
                        TimeSpantimeE0M.AssertModel(models[19],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[20],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[21],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[22],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[23],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[24],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[25],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[26],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[27],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[28],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[29],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[30],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[31],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[32],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypetime)this).DbConnectionSTSelectModelBatch(connection, 65, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[12], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[13], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[14], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[15], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[16], false);
                        TimeSpantimeE0M.AssertModel(models[5],_testData[17], false);
                        TimeSpantimeE0M.AssertModel(models[6],_testData[18], false);
                        TimeSpantimeE0M.AssertModel(models[7],_testData[19], false);
                        TimeSpantimeE0M.AssertModel(models[8],_testData[20], false);
                        TimeSpantimeE0M.AssertModel(models[9],_testData[21], false);
                        TimeSpantimeE0M.AssertModel(models[10],_testData[22], false);
                        TimeSpantimeE0M.AssertModel(models[11],_testData[23], false);
                        TimeSpantimeE0M.AssertModel(models[12],_testData[24], false);
                        TimeSpantimeE0M.AssertModel(models[13],_testData[25], false);
                        TimeSpantimeE0M.AssertModel(models[14],_testData[26], false);
                        TimeSpantimeE0M.AssertModel(models[15],_testData[27], false);
                        TimeSpantimeE0M.AssertModel(models[16],_testData[28], false);
                        TimeSpantimeE0M.AssertModel(models[17],_testData[29], false);
                        TimeSpantimeE0M.AssertModel(models[18],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[19],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[20],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[21],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpantimeE0M.AssertModel(models[0],_testData[30], false);
                        TimeSpantimeE0M.AssertModel(models[1],_testData[31], false);
                        TimeSpantimeE0M.AssertModel(models[2],_testData[32], false);
                        TimeSpantimeE0M.AssertModel(models[3],_testData[33], false);
                        TimeSpantimeE0M.AssertModel(models[4],_testData[34], false);
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
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                TimeSpantimeE0M.AssertModel(models[0],_testData[24], false);
                TimeSpantimeE0M.AssertModel(models[1],_testData[25], false);
                TimeSpantimeE0M.AssertModel(models[2],_testData[26], false);
                TimeSpantimeE0M.AssertModel(models[3],_testData[27], false);
                TimeSpantimeE0M.AssertModel(models[4],_testData[28], false);
                TimeSpantimeE0M.AssertModel(models[5],_testData[29], false);
                TimeSpantimeE0M.AssertModel(models[6],_testData[30], false);
                TimeSpantimeE0M.AssertModel(models[7],_testData[31], false);
                TimeSpantimeE0M.AssertModel(models[8],_testData[32], false);
                TimeSpantimeE0M.AssertModel(models[9],_testData[33], false);
                TimeSpantimeE0M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                TimeSpantimeE0M.AssertModel(models[0],_testData[30], false);
                TimeSpantimeE0M.AssertModel(models[1],_testData[31], false);
                TimeSpantimeE0M.AssertModel(models[2],_testData[32], false);
                TimeSpantimeE0M.AssertModel(models[3],_testData[33], false);
                TimeSpantimeE0M.AssertModel(models[4],_testData[34], false);
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
FROM dbo.timespantimee0m m
LEFT JOIN dbo.timespantimee0mi mi ON mi.id = m.timespantimee0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 41, milliseconds: 141))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 33, milliseconds: 864))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 57, milliseconds: 821))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 14, milliseconds: 226))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 17, milliseconds: 889))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 53, milliseconds: 860))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 21, milliseconds: 705))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 54, milliseconds: 120))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 58, milliseconds: 401))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 713))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 30, seconds: 19, milliseconds: 0))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 40, milliseconds: 837))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 40, milliseconds: 680))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 31, milliseconds: 854))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 11, milliseconds: 530))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 0, milliseconds: 725))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 47, milliseconds: 786))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 20, milliseconds: 41))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 16, milliseconds: 52))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 22, milliseconds: 217))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 40, milliseconds: 157))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 45, milliseconds: 394))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 10, milliseconds: 285))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 0, milliseconds: 722))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 18, milliseconds: 114))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 18, milliseconds: 82))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 17, milliseconds: 150))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 22, milliseconds: 52))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 33, milliseconds: 890))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 48, milliseconds: 784))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 47, seconds: 41, milliseconds: 911))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 40, seconds: 38, milliseconds: 395))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 44, milliseconds: 230))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 55, milliseconds: 404))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 22, milliseconds: 982))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 36, milliseconds: 435))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 11, milliseconds: 572))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 0, milliseconds: 569))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 1, milliseconds: 704))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 22, milliseconds: 806))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 51, milliseconds: 411))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 53, milliseconds: 370))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 807))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 27, milliseconds: 117))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 0, milliseconds: 747))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 52, milliseconds: 653))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 55, milliseconds: 814))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 20, milliseconds: 465))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 16, milliseconds: 367))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 13, milliseconds: 626))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 57, milliseconds: 40))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 58, milliseconds: 734))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 9, milliseconds: 496))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 29, milliseconds: 261))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 46, milliseconds: 428))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 15, milliseconds: 891))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 36, milliseconds: 1))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 2, milliseconds: 998))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 19, seconds: 20, milliseconds: 375))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 15, milliseconds: 965))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 39, milliseconds: 481))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 46, milliseconds: 554))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 58, milliseconds: 226))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 6, milliseconds: 522))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 49, milliseconds: 12))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 34, milliseconds: 350))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 37, milliseconds: 275))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 18, milliseconds: 189))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 16, seconds: 26, milliseconds: 6))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 10, seconds: 20, milliseconds: 556))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 29, milliseconds: 893))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 23, milliseconds: 198))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 13, milliseconds: 902))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 40, seconds: 37, milliseconds: 924))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 10, milliseconds: 515))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 10, milliseconds: 980))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 26, milliseconds: 187))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 7, milliseconds: 492))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 49, milliseconds: 499))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 39, seconds: 20, milliseconds: 724))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 25, milliseconds: 543))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 45, milliseconds: 206))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 23, milliseconds: 785))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 33, milliseconds: 515))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 18, milliseconds: 759))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 41, milliseconds: 141))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 33, milliseconds: 864))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 57, milliseconds: 821))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 14, milliseconds: 226))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 17, milliseconds: 889))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 53, milliseconds: 860))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 21, milliseconds: 705))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 54, milliseconds: 120))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 58, milliseconds: 401))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 23, milliseconds: 713))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 30, seconds: 19, milliseconds: 0))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 40, milliseconds: 837))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 40, milliseconds: 680))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 31, milliseconds: 854))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 11, milliseconds: 530))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 0, milliseconds: 725))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 47, milliseconds: 786))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 20, milliseconds: 41))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 16, milliseconds: 52))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 22, milliseconds: 217))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 40, milliseconds: 157))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 45, milliseconds: 394))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 10, milliseconds: 285))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 0, milliseconds: 722))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 18, milliseconds: 114))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 18, milliseconds: 82))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 17, milliseconds: 150))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 22, milliseconds: 52))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 33, milliseconds: 890))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 48, milliseconds: 784))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 47, seconds: 41, milliseconds: 911))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 40, seconds: 38, milliseconds: 395))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 44, milliseconds: 230))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 55, milliseconds: 404))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 22, milliseconds: 982))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 36, milliseconds: 435))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 11, milliseconds: 572))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 0, milliseconds: 569))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 1, milliseconds: 704))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 22, milliseconds: 806))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 51, milliseconds: 411))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 53, milliseconds: 370))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 807))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 27, milliseconds: 117))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 0, milliseconds: 747))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 52, milliseconds: 653))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 55, milliseconds: 814))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 20, milliseconds: 465))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 16, milliseconds: 367))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 13, milliseconds: 626))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 57, milliseconds: 40))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 58, milliseconds: 734))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 9, milliseconds: 496))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 29, milliseconds: 261))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 46, milliseconds: 428))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 15, milliseconds: 891))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 36, milliseconds: 1))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 2, milliseconds: 998))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 19, seconds: 20, milliseconds: 375))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 15, milliseconds: 965))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 39, milliseconds: 481))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 46, milliseconds: 554))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 58, milliseconds: 226))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 6, milliseconds: 522))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 49, milliseconds: 12))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 34, milliseconds: 350))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 37, milliseconds: 275))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 18, milliseconds: 189))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 16, seconds: 26, milliseconds: 6))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 10, seconds: 20, milliseconds: 556))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 29, milliseconds: 893))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 23, milliseconds: 198))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 13, milliseconds: 902))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 40, seconds: 37, milliseconds: 924))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 10, milliseconds: 515))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 10, milliseconds: 980))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 26, milliseconds: 187))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 7, milliseconds: 492))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 49, milliseconds: 499))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 39, seconds: 20, milliseconds: 724))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 25, milliseconds: 543))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 45, milliseconds: 206))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 23, milliseconds: 785))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 33, milliseconds: 515))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 18, milliseconds: 759))));

            }
        }

#endregion

    }
}


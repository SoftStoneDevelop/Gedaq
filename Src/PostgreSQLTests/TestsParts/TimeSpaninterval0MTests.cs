

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface ITimeSpanSingleTypeinterval
    {
    }
    
    internal partial class TimeSpanSingleTypeinterval : ITimeSpanSingleTypeinterval
    {


#region TestData

        private readonly TimeSpaninterval0M[] _testData = new TimeSpaninterval0M[]
        {
            new TimeSpaninterval0M
{
    Id = 1,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 25, milliseconds: 950),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 4,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 17, milliseconds: 431),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 5,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 37, milliseconds: 915),
    NullableValue = new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 13, milliseconds: 194),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 10,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 53, milliseconds: 485),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 18,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 21, milliseconds: 773),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 46, milliseconds: 373),
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 1, milliseconds: 561),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 22,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 24, milliseconds: 508),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 26,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 17, milliseconds: 842),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 22,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 56, milliseconds: 289),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 9, milliseconds: 441),
},
            new TimeSpaninterval0M
{
    Id = 33,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 29, seconds: 12, milliseconds: 150),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 7, milliseconds: 861),
},
            new TimeSpaninterval0M
{
    Id = 34,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 22, milliseconds: 918),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 24,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 13, milliseconds: 171),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 44, milliseconds: 242),
},
            new TimeSpaninterval0M
{
    Id = 39,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 34, milliseconds: 50),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 58, milliseconds: 723),
},
            new TimeSpaninterval0M
{
    Id = 45,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 17, seconds: 41, milliseconds: 631),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 26,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 32, milliseconds: 966),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 47,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 15, milliseconds: 176),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 36, milliseconds: 988),
},
            new TimeSpaninterval0M
{
    Id = 55,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 39, milliseconds: 399),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 28,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 7, milliseconds: 33),
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 44, milliseconds: 747),
},
    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 19, milliseconds: 805),
},
            new TimeSpaninterval0M
{
    Id = 60,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 33, milliseconds: 395),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 51, milliseconds: 847),
},
            new TimeSpaninterval0M
{
    Id = 69,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 7, milliseconds: 96),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 35,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 12, milliseconds: 776),
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 11, milliseconds: 922),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 74,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 31, milliseconds: 248),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 16, milliseconds: 413),
},
            new TimeSpaninterval0M
{
    Id = 82,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 15, milliseconds: 391),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 3, milliseconds: 789),
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 53, milliseconds: 448),
},
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 20, milliseconds: 542),
},
            new TimeSpaninterval0M
{
    Id = 91,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 20, milliseconds: 865),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 7, seconds: 40, milliseconds: 42),
},
            new TimeSpaninterval0M
{
    Id = 94,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 21, milliseconds: 501),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 44,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 5, milliseconds: 603),
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 14, milliseconds: 409),
},
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 17, milliseconds: 229),
},
            new TimeSpaninterval0M
{
    Id = 99,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 19, milliseconds: 641),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 30, milliseconds: 525),
},
            new TimeSpaninterval0M
{
    Id = 107,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 35, seconds: 23, milliseconds: 258),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 47,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 44, milliseconds: 343),
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 55, milliseconds: 760),
},
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 23, seconds: 44, milliseconds: 590),
},
            new TimeSpaninterval0M
{
    Id = 113,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 9, milliseconds: 89),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 15, milliseconds: 722),
},
            new TimeSpaninterval0M
{
    Id = 122,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 9, milliseconds: 85),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 53,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 5, milliseconds: 270),
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 8, milliseconds: 429),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 127,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 49, milliseconds: 297),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 131,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 24, milliseconds: 915),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 56,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 52, milliseconds: 724),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 132,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 40, milliseconds: 426),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 139,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 37, milliseconds: 578),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 64,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 1, milliseconds: 345),
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 11, milliseconds: 457),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 144,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 24, milliseconds: 156),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 17, milliseconds: 886),
},
            new TimeSpaninterval0M
{
    Id = 151,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 31, milliseconds: 151),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 69,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 52, milliseconds: 161),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 27, milliseconds: 574),
},
            new TimeSpaninterval0M
{
    Id = 158,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 52, milliseconds: 904),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 29, seconds: 13, milliseconds: 669),
},
            new TimeSpaninterval0M
{
    Id = 164,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 12, milliseconds: 928),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 72,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 5, milliseconds: 729),
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 477),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 173,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 3, milliseconds: 160),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 31, milliseconds: 608),
},
            new TimeSpaninterval0M
{
    Id = 180,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 50, milliseconds: 617),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 77,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 15, milliseconds: 171),
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 4, milliseconds: 15),
},
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 2, milliseconds: 879),
},
            new TimeSpaninterval0M
{
    Id = 182,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 14, seconds: 28, milliseconds: 934),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 191,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 56, milliseconds: 717),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 79,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 47, milliseconds: 244),
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 55, milliseconds: 83),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 198,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 54, seconds: 15, milliseconds: 868),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 33, milliseconds: 412),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespaninterval0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespaninterval0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(TimeSpaninterval0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((ITimeSpanSingleTypeinterval)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypeinterval)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanSingleTypeinterval)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((ITimeSpanSingleTypeinterval)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanSingleTypeinterval)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeSpanSingleTypeinterval)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanSingleTypeinterval)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.timespaninterval0mi(
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
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

                changedRows =  ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespaninterval0m(
	id,
    value,
    nullablevalue,
    timespaninterval0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespaninterval0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
                changedRows =  ((ITimeSpanSingleTypeinterval)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanSingleTypeinterval)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanSingleTypeinterval)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanSingleTypeinterval)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespaninterval0m(
	id,
    value,
    nullablevalue,
    timespaninterval0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    timespaninterval0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpaninterval0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan>();
                    ((NpgsqlParameter<System.TimeSpan>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(30);
                    ((NpgsqlParameter<System.TimeSpan>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(30);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan>();
                    ((NpgsqlParameter<System.TimeSpan>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(30);
                    ((NpgsqlParameter<System.TimeSpan>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(30);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 9, milliseconds: 441)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan>();
                    ((NpgsqlParameter<System.TimeSpan>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(30);
                    ((NpgsqlParameter<System.TimeSpan>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(30);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 7, milliseconds: 861)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan>();
                    ((NpgsqlParameter<System.TimeSpan>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(30);
                    ((NpgsqlParameter<System.TimeSpan>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(30);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 44, milliseconds: 242)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespaninterval0m(
	id,
    value,
    nullablevalue,
    timespaninterval0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    timespaninterval0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpaninterval0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespaninterval0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan? nullable = null;
                nullable =  ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 58, milliseconds: 723)));
                nullable =  ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan? nullable = null;
                nullable = await ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 36, milliseconds: 988)));
                nullable = await ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 19, milliseconds: 805)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpaninterval0M> models = null;

                models =  ((ITimeSpanSingleTypeinterval)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpaninterval0M.AssertModel(models[0],_testData[12], true);
                models =  ((ITimeSpanSingleTypeinterval)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpaninterval0M.AssertModel(models[0],_testData[13], true);
                models =  ((ITimeSpanSingleTypeinterval)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpaninterval0M.AssertModel(models[0],_testData[14], true);
                models =  ((ITimeSpanSingleTypeinterval)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpaninterval0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpaninterval0M> models = null;

                models = await ((ITimeSpanSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpaninterval0M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpaninterval0M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpaninterval0M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpaninterval0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.timespaninterval0m(
	id,
    value,
    nullablevalue,
    timespaninterval0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timespaninterval0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.TimeSpan), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespaninterval0mi_id", 
                methodParametrName: "timespaninterval0mi_id", 
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

                changedRows =  ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M), typeof(FlatTimeSpaninterval0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
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
FROM public.timespaninterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpaninterval0M>();
                var models2 = new List<FlatTimeSpaninterval0M>();
                await ((ITimeSpanSingleTypeinterval)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespaninterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpaninterval0M>();
                var models2 = new List<FlatTimeSpaninterval0M>();
                ((ITimeSpanSingleTypeinterval)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
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
FROM public.timespaninterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespaninterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpaninterval0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanSingleTypeinterval)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanSingleTypeinterval)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M), typeof(FlatTimeSpaninterval0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.timespaninterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpaninterval0M>();
                var models2 = new List<FlatTimeSpaninterval0M>();
                await ((ITimeSpanSingleTypeinterval)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespaninterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpaninterval0M>();
                var models2 = new List<FlatTimeSpaninterval0M>();
                ((ITimeSpanSingleTypeinterval)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.timespaninterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespaninterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpaninterval0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanSingleTypeinterval)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M), typeof(FlatTimeSpaninterval0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpaninterval0M>();
                var models2 = new List<FlatTimeSpaninterval0M>();
                await((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 182;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var firstItems2 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems2 = new List<FlatTimeSpaninterval0M>();
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var firstItems2 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpaninterval0M>();
                var models2 = new List<FlatTimeSpaninterval0M>();
                ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var firstItems2 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems2 = new List<FlatTimeSpaninterval0M>();
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var firstItems2 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[17],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(models[18],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(models[19],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(models[20],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(models[21],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems2 = new List<FlatTimeSpaninterval0M>();
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(models[14],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[14],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[15],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[16],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[17],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[18],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[19],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[20],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[21],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[22],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[23],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[24],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[25],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[26],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(models[27],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(models[28],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(models[29],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(models[30],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems2 = new List<FlatTimeSpaninterval0M>();
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpaninterval0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
                var models = await((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[29], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[30], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[31], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[32], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[33], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[3], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[4], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[5], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[6], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[7], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[8], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[9], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[10], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[11], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[12], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[13], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[14], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[15], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[14],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[15],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[16],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[17],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[18],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[19],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[20],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[21],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[22],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[23],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[24],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[25],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[26],_testData[29], false);
                        TimeSpaninterval0M.AssertModel(models[27],_testData[30], false);
                        TimeSpaninterval0M.AssertModel(models[28],_testData[31], false);
                        TimeSpaninterval0M.AssertModel(models[29],_testData[32], false);
                        TimeSpaninterval0M.AssertModel(models[30],_testData[33], false);
                        TimeSpaninterval0M.AssertModel(models[31],_testData[34], false);
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
                var models = ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 182;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[33], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[29], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[30], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[31], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[32], false);
                        TimeSpaninterval0M.AssertModel(models[14],_testData[33], false);
                        TimeSpaninterval0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M), typeof(FlatTimeSpaninterval0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpaninterval0M>();
                var models2 = new List<FlatTimeSpaninterval0M>();
                await((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var firstItems2 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems2 = new List<FlatTimeSpaninterval0M>();
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 107, query1, 173, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var firstItems2 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 4, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpaninterval0M>();
                var models2 = new List<FlatTimeSpaninterval0M>();
                ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var firstItems2 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems2 = new List<FlatTimeSpaninterval0M>();
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 22, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var firstItems2 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatch(connection, 69, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 182, query1, 144, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[34], false);
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems2 = new List<FlatTimeSpaninterval0M>();
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 131, query1, 173, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[14],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[15],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[16],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[17],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[18],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[19],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(models[20],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(models[21],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(models[22],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(models[23],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[34], false);
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
FROM public.timespaninterval0m m
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
FROM public.timespaninterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems1 = new List<FlatTimeSpaninterval0M>();
                var secondItems2 = new List<FlatTimeSpaninterval0M>();
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpaninterval0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)),
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
                var models = await((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelBatchAsync(connection, 55, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[12], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[13], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[14], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[15], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[14],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[15],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[16],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[17],_testData[29], false);
                        TimeSpaninterval0M.AssertModel(models[18],_testData[30], false);
                        TimeSpaninterval0M.AssertModel(models[19],_testData[31], false);
                        TimeSpaninterval0M.AssertModel(models[20],_testData[32], false);
                        TimeSpaninterval0M.AssertModel(models[21],_testData[33], false);
                        TimeSpaninterval0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[11], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[12], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[13], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[14], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[15], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[14],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[15],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[16],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[17],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[18],_testData[29], false);
                        TimeSpaninterval0M.AssertModel(models[19],_testData[30], false);
                        TimeSpaninterval0M.AssertModel(models[20],_testData[31], false);
                        TimeSpaninterval0M.AssertModel(models[21],_testData[32], false);
                        TimeSpaninterval0M.AssertModel(models[22],_testData[33], false);
                        TimeSpaninterval0M.AssertModel(models[23],_testData[34], false);
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
                var models = ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelBatch(connection, 113, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[29], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[30], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[31], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[32], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[33], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[29], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[30], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[31], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[32], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[33], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((ITimeSpanSingleTypeinterval)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));
TimeSpaninterval0M.AssertModel(models[0],_testData[2], false);TimeSpaninterval0M.AssertModel(models[1],_testData[3], false);TimeSpaninterval0M.AssertModel(models[2],_testData[4], false);TimeSpaninterval0M.AssertModel(models[3],_testData[5], false);TimeSpaninterval0M.AssertModel(models[4],_testData[6], false);TimeSpaninterval0M.AssertModel(models[5],_testData[7], false);TimeSpaninterval0M.AssertModel(models[6],_testData[8], false);TimeSpaninterval0M.AssertModel(models[7],_testData[9], false);TimeSpaninterval0M.AssertModel(models[8],_testData[10], false);TimeSpaninterval0M.AssertModel(models[9],_testData[11], false);TimeSpaninterval0M.AssertModel(models[10],_testData[12], false);TimeSpaninterval0M.AssertModel(models[11],_testData[13], false);TimeSpaninterval0M.AssertModel(models[12],_testData[14], false);TimeSpaninterval0M.AssertModel(models[13],_testData[15], false);TimeSpaninterval0M.AssertModel(models[14],_testData[16], false);TimeSpaninterval0M.AssertModel(models[15],_testData[17], false);TimeSpaninterval0M.AssertModel(models[16],_testData[18], false);TimeSpaninterval0M.AssertModel(models[17],_testData[19], false);TimeSpaninterval0M.AssertModel(models[18],_testData[20], false);TimeSpaninterval0M.AssertModel(models[19],_testData[21], false);TimeSpaninterval0M.AssertModel(models[20],_testData[22], false);TimeSpaninterval0M.AssertModel(models[21],_testData[23], false);TimeSpaninterval0M.AssertModel(models[22],_testData[24], false);TimeSpaninterval0M.AssertModel(models[23],_testData[25], false);TimeSpaninterval0M.AssertModel(models[24],_testData[26], false);TimeSpaninterval0M.AssertModel(models[25],_testData[27], false);TimeSpaninterval0M.AssertModel(models[26],_testData[28], false);TimeSpaninterval0M.AssertModel(models[27],_testData[29], false);TimeSpaninterval0M.AssertModel(models[28],_testData[30], false);TimeSpaninterval0M.AssertModel(models[29],_testData[31], false);TimeSpaninterval0M.AssertModel(models[30],_testData[32], false);TimeSpaninterval0M.AssertModel(models[31],_testData[33], false);TimeSpaninterval0M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypeinterval)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
TimeSpaninterval0M.AssertModel(models[0],_testData[15], false);TimeSpaninterval0M.AssertModel(models[1],_testData[16], false);TimeSpaninterval0M.AssertModel(models[2],_testData[17], false);TimeSpaninterval0M.AssertModel(models[3],_testData[18], false);TimeSpaninterval0M.AssertModel(models[4],_testData[19], false);TimeSpaninterval0M.AssertModel(models[5],_testData[20], false);TimeSpaninterval0M.AssertModel(models[6],_testData[21], false);TimeSpaninterval0M.AssertModel(models[7],_testData[22], false);TimeSpaninterval0M.AssertModel(models[8],_testData[23], false);TimeSpaninterval0M.AssertModel(models[9],_testData[24], false);TimeSpaninterval0M.AssertModel(models[10],_testData[25], false);TimeSpaninterval0M.AssertModel(models[11],_testData[26], false);TimeSpaninterval0M.AssertModel(models[12],_testData[27], false);TimeSpaninterval0M.AssertModel(models[13],_testData[28], false);TimeSpaninterval0M.AssertModel(models[14],_testData[29], false);TimeSpaninterval0M.AssertModel(models[15],_testData[30], false);TimeSpaninterval0M.AssertModel(models[16],_testData[31], false);TimeSpaninterval0M.AssertModel(models[17],_testData[32], false);TimeSpaninterval0M.AssertModel(models[18],_testData[33], false);TimeSpaninterval0M.AssertModel(models[19],_testData[34], false);
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 25, milliseconds: 950))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 17, milliseconds: 431))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 37, milliseconds: 915))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 13, milliseconds: 194))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 53, milliseconds: 485))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 21, milliseconds: 773))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 46, milliseconds: 373))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 1, milliseconds: 561))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 24, milliseconds: 508))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 17, milliseconds: 842))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 56, milliseconds: 289))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 9, milliseconds: 441))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 29, seconds: 12, milliseconds: 150))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 7, milliseconds: 861))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 22, milliseconds: 918))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 13, milliseconds: 171))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 44, milliseconds: 242))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 34, milliseconds: 50))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 58, milliseconds: 723))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 17, seconds: 41, milliseconds: 631))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 32, milliseconds: 966))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 15, milliseconds: 176))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 36, milliseconds: 988))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 39, milliseconds: 399))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 7, milliseconds: 33))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 44, milliseconds: 747))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 19, milliseconds: 805))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 33, milliseconds: 395))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 51, milliseconds: 847))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 7, milliseconds: 96))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 12, milliseconds: 776))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 11, milliseconds: 922))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 31, milliseconds: 248))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 16, milliseconds: 413))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 15, milliseconds: 391))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 3, milliseconds: 789))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 53, milliseconds: 448))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 20, milliseconds: 542))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 20, milliseconds: 865))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 7, seconds: 40, milliseconds: 42))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 21, milliseconds: 501))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 5, milliseconds: 603))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 14, milliseconds: 409))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 17, milliseconds: 229))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 19, milliseconds: 641))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 30, milliseconds: 525))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 35, seconds: 23, milliseconds: 258))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 44, milliseconds: 343))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 55, milliseconds: 760))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 23, seconds: 44, milliseconds: 590))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 9, milliseconds: 89))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 15, milliseconds: 722))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 9, milliseconds: 85))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 5, milliseconds: 270))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 8, milliseconds: 429))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 49, milliseconds: 297))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 24, milliseconds: 915))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 52, milliseconds: 724))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 40, milliseconds: 426))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 37, milliseconds: 578))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 1, milliseconds: 345))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 11, milliseconds: 457))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 24, milliseconds: 156))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 17, milliseconds: 886))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 31, milliseconds: 151))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 52, milliseconds: 161))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 27, milliseconds: 574))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 52, milliseconds: 904))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 29, seconds: 13, milliseconds: 669))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 12, milliseconds: 928))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 5, milliseconds: 729))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 477))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 3, milliseconds: 160))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 31, milliseconds: 608))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 50, milliseconds: 617))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 15, milliseconds: 171))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 4, milliseconds: 15))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 2, milliseconds: 879))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 14, seconds: 28, milliseconds: 934))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 56, milliseconds: 717))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 47, milliseconds: 244))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 55, milliseconds: 83))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 54, seconds: 15, milliseconds: 868))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 33, milliseconds: 412))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 25, milliseconds: 950))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 17, milliseconds: 431))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 37, milliseconds: 915))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 13, milliseconds: 194))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 53, milliseconds: 485))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 21, milliseconds: 773))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 46, milliseconds: 373))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 1, milliseconds: 561))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 24, milliseconds: 508))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 17, milliseconds: 842))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 56, milliseconds: 289))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 9, milliseconds: 441))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 29, seconds: 12, milliseconds: 150))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 7, milliseconds: 861))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 22, milliseconds: 918))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 13, milliseconds: 171))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 44, milliseconds: 242))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 34, milliseconds: 50))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 58, milliseconds: 723))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 17, seconds: 41, milliseconds: 631))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 32, milliseconds: 966))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 15, milliseconds: 176))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 36, milliseconds: 988))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 39, milliseconds: 399))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 7, milliseconds: 33))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 44, milliseconds: 747))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 19, milliseconds: 805))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 33, milliseconds: 395))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 51, milliseconds: 847))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 7, milliseconds: 96))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 12, milliseconds: 776))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 11, milliseconds: 922))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 31, milliseconds: 248))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 16, milliseconds: 413))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 15, milliseconds: 391))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 3, milliseconds: 789))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 53, milliseconds: 448))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 20, milliseconds: 542))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 20, milliseconds: 865))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 7, seconds: 40, milliseconds: 42))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 21, milliseconds: 501))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 5, milliseconds: 603))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 14, milliseconds: 409))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 17, milliseconds: 229))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 19, milliseconds: 641))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 30, milliseconds: 525))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 35, seconds: 23, milliseconds: 258))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 44, milliseconds: 343))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 55, milliseconds: 760))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 23, seconds: 44, milliseconds: 590))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 9, milliseconds: 89))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 15, milliseconds: 722))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 9, milliseconds: 85))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 5, milliseconds: 270))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 8, milliseconds: 429))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 49, milliseconds: 297))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 24, milliseconds: 915))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 52, milliseconds: 724))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 40, milliseconds: 426))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 37, milliseconds: 578))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 1, milliseconds: 345))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 11, milliseconds: 457))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 24, milliseconds: 156))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 17, milliseconds: 886))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 31, milliseconds: 151))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 52, milliseconds: 161))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 27, milliseconds: 574))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 52, milliseconds: 904))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 29, seconds: 13, milliseconds: 669))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 12, milliseconds: 928))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 5, milliseconds: 729))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 477))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 3, milliseconds: 160))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 31, milliseconds: 608))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 50, milliseconds: 617))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 15, milliseconds: 171))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 4, milliseconds: 15))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 2, milliseconds: 879))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 14, seconds: 28, milliseconds: 934))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 56, milliseconds: 717))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 47, milliseconds: 244))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 55, milliseconds: 83))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 54, seconds: 15, milliseconds: 868))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 33, milliseconds: 412))));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_timespaninterval0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpaninterval0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpaninterval0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpaninterval0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpaninterval0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanSingleTypeinterval)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespaninterval0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanSingleTypeinterval)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpaninterval0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpaninterval0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanSingleTypeinterval)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespaninterval0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanSingleTypeinterval)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_timespaninterval0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpaninterval0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpaninterval0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpaninterval0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpaninterval0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanSingleTypeinterval)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespaninterval0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanSingleTypeinterval)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpaninterval0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpaninterval0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanSingleTypeinterval)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespaninterval0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanSingleTypeinterval)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_timespaninterval0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpaninterval0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespaninterval0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpaninterval0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpaninterval0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanSingleTypeinterval)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanSingleTypeinterval)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpaninterval0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanSingleTypeinterval)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanSingleTypeinterval)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_timespaninterval0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpaninterval0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespaninterval0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpaninterval0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpaninterval0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpaninterval0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanSingleTypeinterval)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanSingleTypeinterval)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpaninterval0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpaninterval0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanSingleTypeinterval)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanSingleTypeinterval)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespaninterval0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespaninterval0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpaninterval0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void ImportModelConfig()
        {
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
FROM public.binary_timespaninterval0m m
LEFT JOIN public.binary_timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpaninterval0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpaninterval0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanSingleTypeinterval)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanSingleTypeinterval)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpaninterval0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpaninterval0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanSingleTypeinterval)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanSingleTypeinterval)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpaninterval0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespaninterval0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespaninterval0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpaninterval0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanSingleTypeinterval)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpaninterval0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpaninterval0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpaninterval0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespaninterval0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpaninterval0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ITimeSpanSingleTypeinterval)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespaninterval0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpaninterval0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespaninterval0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpaninterval0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpaninterval0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ITimeSpanSingleTypeinterval)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpaninterval0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


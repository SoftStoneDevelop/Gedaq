

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
    Id = 8,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 30, milliseconds: 966),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 13,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 5, milliseconds: 923),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 3,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 26, milliseconds: 280),
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 58, milliseconds: 968),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 22,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 23, milliseconds: 558),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 7, milliseconds: 312),
},
            new TimeSpaninterval0M
{
    Id = 30,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 24, milliseconds: 542),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 9,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 6, seconds: 52, milliseconds: 185),
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 38, milliseconds: 201),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 37,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 6, milliseconds: 522),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 45,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 33, milliseconds: 629),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 11,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 56, seconds: 5, milliseconds: 571),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 28, milliseconds: 495),
},
            new TimeSpaninterval0M
{
    Id = 47,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 18, milliseconds: 346),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 52,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 17, milliseconds: 437),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 20,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 38, milliseconds: 331),
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 8, milliseconds: 481),
},
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 16, seconds: 9, milliseconds: 912),
},
            new TimeSpaninterval0M
{
    Id = 53,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 43, milliseconds: 123),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 54,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 4, milliseconds: 787),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 26,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 28, milliseconds: 768),
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 0, milliseconds: 170),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 56,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 648),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 64,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 28, milliseconds: 299),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 33,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 31, milliseconds: 210),
    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 16, milliseconds: 906),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 68,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 48, milliseconds: 455),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 598),
},
            new TimeSpaninterval0M
{
    Id = 71,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 24, milliseconds: 552),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 39,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 8, milliseconds: 19),
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 14, milliseconds: 620),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 75,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 46, milliseconds: 759),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 83,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 27, milliseconds: 729),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 41,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 58, milliseconds: 779),
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 41, milliseconds: 664),
},
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 51, milliseconds: 341),
},
            new TimeSpaninterval0M
{
    Id = 86,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 43, milliseconds: 933),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 33, milliseconds: 29),
},
            new TimeSpaninterval0M
{
    Id = 89,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 58, milliseconds: 745),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 49,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 17, milliseconds: 527),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 92,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 26, milliseconds: 196),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 99,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 2, milliseconds: 440),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 57,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 45, milliseconds: 26),
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 32, milliseconds: 94),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 100,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 8, milliseconds: 401),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 1, milliseconds: 666),
},
            new TimeSpaninterval0M
{
    Id = 104,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 36, milliseconds: 571),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 59,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 40, milliseconds: 942),
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 33, milliseconds: 813),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 105,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 55, milliseconds: 341),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 22, milliseconds: 345),
},
            new TimeSpaninterval0M
{
    Id = 107,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 21, milliseconds: 582),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 67,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 32, milliseconds: 484),
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 52, seconds: 33, milliseconds: 278),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 111,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 41, milliseconds: 74),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 34, seconds: 37, milliseconds: 369),
},
            new TimeSpaninterval0M
{
    Id = 112,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 54, milliseconds: 785),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 71,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 43, milliseconds: 135),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 117,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 15, milliseconds: 789),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 10, milliseconds: 827),
},
            new TimeSpaninterval0M
{
    Id = 120,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 38, milliseconds: 264),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 73,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 35, milliseconds: 551),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 6, milliseconds: 159),
},
            new TimeSpaninterval0M
{
    Id = 126,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 23, milliseconds: 482),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 2, milliseconds: 189),
},
            new TimeSpaninterval0M
{
    Id = 127,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 48, milliseconds: 218),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 74,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 54, milliseconds: 59),
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 0, milliseconds: 485),
},
    NullableValue = null,
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
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 28, milliseconds: 495)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 16, seconds: 9, milliseconds: 912)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M)],
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((ITimeSpanSingleTypeinterval)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M)],
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((ITimeSpanSingleTypeinterval)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatTimeSpaninterval0M.AssertModel(models[0],_testData[27], false);FlatTimeSpaninterval0M.AssertModel(models[1],_testData[28], false);FlatTimeSpaninterval0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatTimeSpaninterval0M.AssertModel(models[0],_testData[22], false);FlatTimeSpaninterval0M.AssertModel(models[1],_testData[23], false);FlatTimeSpaninterval0M.AssertModel(models[2],_testData[24], false);FlatTimeSpaninterval0M.AssertModel(models[3],_testData[25], false);FlatTimeSpaninterval0M.AssertModel(models[4],_testData[26], false);FlatTimeSpaninterval0M.AssertModel(models[5],_testData[27], false);FlatTimeSpaninterval0M.AssertModel(models[6],_testData[28], false);FlatTimeSpaninterval0M.AssertModel(models[7],_testData[29], false);
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatTimeSpaninterval0M.AssertModel(models[0],_testData[17], false);FlatTimeSpaninterval0M.AssertModel(models[1],_testData[18], false);FlatTimeSpaninterval0M.AssertModel(models[2],_testData[19], false);FlatTimeSpaninterval0M.AssertModel(models[3],_testData[20], false);FlatTimeSpaninterval0M.AssertModel(models[4],_testData[21], false);FlatTimeSpaninterval0M.AssertModel(models[5],_testData[22], false);FlatTimeSpaninterval0M.AssertModel(models[6],_testData[23], false);FlatTimeSpaninterval0M.AssertModel(models[7],_testData[24], false);FlatTimeSpaninterval0M.AssertModel(models[8],_testData[25], false);FlatTimeSpaninterval0M.AssertModel(models[9],_testData[26], false);FlatTimeSpaninterval0M.AssertModel(models[10],_testData[27], false);FlatTimeSpaninterval0M.AssertModel(models[11],_testData[28], false);FlatTimeSpaninterval0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatTimeSpaninterval0M.AssertModel(models[0],_testData[2], false);FlatTimeSpaninterval0M.AssertModel(models[1],_testData[3], false);FlatTimeSpaninterval0M.AssertModel(models[2],_testData[4], false);FlatTimeSpaninterval0M.AssertModel(models[3],_testData[5], false);FlatTimeSpaninterval0M.AssertModel(models[4],_testData[6], false);FlatTimeSpaninterval0M.AssertModel(models[5],_testData[7], false);FlatTimeSpaninterval0M.AssertModel(models[6],_testData[8], false);FlatTimeSpaninterval0M.AssertModel(models[7],_testData[9], false);FlatTimeSpaninterval0M.AssertModel(models[8],_testData[10], false);FlatTimeSpaninterval0M.AssertModel(models[9],_testData[11], false);FlatTimeSpaninterval0M.AssertModel(models[10],_testData[12], false);FlatTimeSpaninterval0M.AssertModel(models[11],_testData[13], false);FlatTimeSpaninterval0M.AssertModel(models[12],_testData[14], false);FlatTimeSpaninterval0M.AssertModel(models[13],_testData[15], false);FlatTimeSpaninterval0M.AssertModel(models[14],_testData[16], false);FlatTimeSpaninterval0M.AssertModel(models[15],_testData[17], false);FlatTimeSpaninterval0M.AssertModel(models[16],_testData[18], false);FlatTimeSpaninterval0M.AssertModel(models[17],_testData[19], false);FlatTimeSpaninterval0M.AssertModel(models[18],_testData[20], false);FlatTimeSpaninterval0M.AssertModel(models[19],_testData[21], false);FlatTimeSpaninterval0M.AssertModel(models[20],_testData[22], false);FlatTimeSpaninterval0M.AssertModel(models[21],_testData[23], false);FlatTimeSpaninterval0M.AssertModel(models[22],_testData[24], false);FlatTimeSpaninterval0M.AssertModel(models[23],_testData[25], false);FlatTimeSpaninterval0M.AssertModel(models[24],_testData[26], false);FlatTimeSpaninterval0M.AssertModel(models[25],_testData[27], false);FlatTimeSpaninterval0M.AssertModel(models[26],_testData[28], false);FlatTimeSpaninterval0M.AssertModel(models[27],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
TimeSpaninterval0M.AssertModel(models[0],_testData[18], false);TimeSpaninterval0M.AssertModel(models[1],_testData[19], false);TimeSpaninterval0M.AssertModel(models[2],_testData[20], false);TimeSpaninterval0M.AssertModel(models[3],_testData[21], false);TimeSpaninterval0M.AssertModel(models[4],_testData[22], false);TimeSpaninterval0M.AssertModel(models[5],_testData[23], false);TimeSpaninterval0M.AssertModel(models[6],_testData[24], false);TimeSpaninterval0M.AssertModel(models[7],_testData[25], false);TimeSpaninterval0M.AssertModel(models[8],_testData[26], false);TimeSpaninterval0M.AssertModel(models[9],_testData[27], false);TimeSpaninterval0M.AssertModel(models[10],_testData[28], false);TimeSpaninterval0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
TimeSpaninterval0M.AssertModel(models[0],_testData[8], false);TimeSpaninterval0M.AssertModel(models[1],_testData[9], false);TimeSpaninterval0M.AssertModel(models[2],_testData[10], false);TimeSpaninterval0M.AssertModel(models[3],_testData[11], false);TimeSpaninterval0M.AssertModel(models[4],_testData[12], false);TimeSpaninterval0M.AssertModel(models[5],_testData[13], false);TimeSpaninterval0M.AssertModel(models[6],_testData[14], false);TimeSpaninterval0M.AssertModel(models[7],_testData[15], false);TimeSpaninterval0M.AssertModel(models[8],_testData[16], false);TimeSpaninterval0M.AssertModel(models[9],_testData[17], false);TimeSpaninterval0M.AssertModel(models[10],_testData[18], false);TimeSpaninterval0M.AssertModel(models[11],_testData[19], false);TimeSpaninterval0M.AssertModel(models[12],_testData[20], false);TimeSpaninterval0M.AssertModel(models[13],_testData[21], false);TimeSpaninterval0M.AssertModel(models[14],_testData[22], false);TimeSpaninterval0M.AssertModel(models[15],_testData[23], false);TimeSpaninterval0M.AssertModel(models[16],_testData[24], false);TimeSpaninterval0M.AssertModel(models[17],_testData[25], false);TimeSpaninterval0M.AssertModel(models[18],_testData[26], false);TimeSpaninterval0M.AssertModel(models[19],_testData[27], false);TimeSpaninterval0M.AssertModel(models[20],_testData[28], false);TimeSpaninterval0M.AssertModel(models[21],_testData[29], false);
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

                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
TimeSpaninterval0M.AssertModel(models[0],_testData[28], false);TimeSpaninterval0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
TimeSpaninterval0M.AssertModel(models[0],_testData[2], false);TimeSpaninterval0M.AssertModel(models[1],_testData[3], false);TimeSpaninterval0M.AssertModel(models[2],_testData[4], false);TimeSpaninterval0M.AssertModel(models[3],_testData[5], false);TimeSpaninterval0M.AssertModel(models[4],_testData[6], false);TimeSpaninterval0M.AssertModel(models[5],_testData[7], false);TimeSpaninterval0M.AssertModel(models[6],_testData[8], false);TimeSpaninterval0M.AssertModel(models[7],_testData[9], false);TimeSpaninterval0M.AssertModel(models[8],_testData[10], false);TimeSpaninterval0M.AssertModel(models[9],_testData[11], false);TimeSpaninterval0M.AssertModel(models[10],_testData[12], false);TimeSpaninterval0M.AssertModel(models[11],_testData[13], false);TimeSpaninterval0M.AssertModel(models[12],_testData[14], false);TimeSpaninterval0M.AssertModel(models[13],_testData[15], false);TimeSpaninterval0M.AssertModel(models[14],_testData[16], false);TimeSpaninterval0M.AssertModel(models[15],_testData[17], false);TimeSpaninterval0M.AssertModel(models[16],_testData[18], false);TimeSpaninterval0M.AssertModel(models[17],_testData[19], false);TimeSpaninterval0M.AssertModel(models[18],_testData[20], false);TimeSpaninterval0M.AssertModel(models[19],_testData[21], false);TimeSpaninterval0M.AssertModel(models[20],_testData[22], false);TimeSpaninterval0M.AssertModel(models[21],_testData[23], false);TimeSpaninterval0M.AssertModel(models[22],_testData[24], false);TimeSpaninterval0M.AssertModel(models[23],_testData[25], false);TimeSpaninterval0M.AssertModel(models[24],_testData[26], false);TimeSpaninterval0M.AssertModel(models[25],_testData[27], false);TimeSpaninterval0M.AssertModel(models[26],_testData[28], false);TimeSpaninterval0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpaninterval0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 56, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatTimeSpaninterval0M.AssertModel(models[0],_testData[11], false);FlatTimeSpaninterval0M.AssertModel(models[1],_testData[12], false);FlatTimeSpaninterval0M.AssertModel(models[2],_testData[13], false);FlatTimeSpaninterval0M.AssertModel(models[3],_testData[14], false);FlatTimeSpaninterval0M.AssertModel(models[4],_testData[15], false);FlatTimeSpaninterval0M.AssertModel(models[5],_testData[16], false);FlatTimeSpaninterval0M.AssertModel(models[6],_testData[17], false);FlatTimeSpaninterval0M.AssertModel(models[7],_testData[18], false);FlatTimeSpaninterval0M.AssertModel(models[8],_testData[19], false);FlatTimeSpaninterval0M.AssertModel(models[9],_testData[20], false);FlatTimeSpaninterval0M.AssertModel(models[10],_testData[21], false);FlatTimeSpaninterval0M.AssertModel(models[11],_testData[22], false);FlatTimeSpaninterval0M.AssertModel(models[12],_testData[23], false);FlatTimeSpaninterval0M.AssertModel(models[13],_testData[24], false);FlatTimeSpaninterval0M.AssertModel(models[14],_testData[25], false);FlatTimeSpaninterval0M.AssertModel(models[15],_testData[26], false);FlatTimeSpaninterval0M.AssertModel(models[16],_testData[27], false);FlatTimeSpaninterval0M.AssertModel(models[17],_testData[28], false);FlatTimeSpaninterval0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatTimeSpaninterval0M.AssertModel(models[0],_testData[3], false);FlatTimeSpaninterval0M.AssertModel(models[1],_testData[4], false);FlatTimeSpaninterval0M.AssertModel(models[2],_testData[5], false);FlatTimeSpaninterval0M.AssertModel(models[3],_testData[6], false);FlatTimeSpaninterval0M.AssertModel(models[4],_testData[7], false);FlatTimeSpaninterval0M.AssertModel(models[5],_testData[8], false);FlatTimeSpaninterval0M.AssertModel(models[6],_testData[9], false);FlatTimeSpaninterval0M.AssertModel(models[7],_testData[10], false);FlatTimeSpaninterval0M.AssertModel(models[8],_testData[11], false);FlatTimeSpaninterval0M.AssertModel(models[9],_testData[12], false);FlatTimeSpaninterval0M.AssertModel(models[10],_testData[13], false);FlatTimeSpaninterval0M.AssertModel(models[11],_testData[14], false);FlatTimeSpaninterval0M.AssertModel(models[12],_testData[15], false);FlatTimeSpaninterval0M.AssertModel(models[13],_testData[16], false);FlatTimeSpaninterval0M.AssertModel(models[14],_testData[17], false);FlatTimeSpaninterval0M.AssertModel(models[15],_testData[18], false);FlatTimeSpaninterval0M.AssertModel(models[16],_testData[19], false);FlatTimeSpaninterval0M.AssertModel(models[17],_testData[20], false);FlatTimeSpaninterval0M.AssertModel(models[18],_testData[21], false);FlatTimeSpaninterval0M.AssertModel(models[19],_testData[22], false);FlatTimeSpaninterval0M.AssertModel(models[20],_testData[23], false);FlatTimeSpaninterval0M.AssertModel(models[21],_testData[24], false);FlatTimeSpaninterval0M.AssertModel(models[22],_testData[25], false);FlatTimeSpaninterval0M.AssertModel(models[23],_testData[26], false);FlatTimeSpaninterval0M.AssertModel(models[24],_testData[27], false);FlatTimeSpaninterval0M.AssertModel(models[25],_testData[28], false);FlatTimeSpaninterval0M.AssertModel(models[26],_testData[29], false);
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
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
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatch(connection, 45, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatTimeSpaninterval0M.AssertModel(models[0],_testData[6], false);FlatTimeSpaninterval0M.AssertModel(models[1],_testData[7], false);FlatTimeSpaninterval0M.AssertModel(models[2],_testData[8], false);FlatTimeSpaninterval0M.AssertModel(models[3],_testData[9], false);FlatTimeSpaninterval0M.AssertModel(models[4],_testData[10], false);FlatTimeSpaninterval0M.AssertModel(models[5],_testData[11], false);FlatTimeSpaninterval0M.AssertModel(models[6],_testData[12], false);FlatTimeSpaninterval0M.AssertModel(models[7],_testData[13], false);FlatTimeSpaninterval0M.AssertModel(models[8],_testData[14], false);FlatTimeSpaninterval0M.AssertModel(models[9],_testData[15], false);FlatTimeSpaninterval0M.AssertModel(models[10],_testData[16], false);FlatTimeSpaninterval0M.AssertModel(models[11],_testData[17], false);FlatTimeSpaninterval0M.AssertModel(models[12],_testData[18], false);FlatTimeSpaninterval0M.AssertModel(models[13],_testData[19], false);FlatTimeSpaninterval0M.AssertModel(models[14],_testData[20], false);FlatTimeSpaninterval0M.AssertModel(models[15],_testData[21], false);FlatTimeSpaninterval0M.AssertModel(models[16],_testData[22], false);FlatTimeSpaninterval0M.AssertModel(models[17],_testData[23], false);FlatTimeSpaninterval0M.AssertModel(models[18],_testData[24], false);FlatTimeSpaninterval0M.AssertModel(models[19],_testData[25], false);FlatTimeSpaninterval0M.AssertModel(models[20],_testData[26], false);FlatTimeSpaninterval0M.AssertModel(models[21],_testData[27], false);FlatTimeSpaninterval0M.AssertModel(models[22],_testData[28], false);FlatTimeSpaninterval0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatTimeSpaninterval0M.AssertModel(models[0],_testData[27], false);FlatTimeSpaninterval0M.AssertModel(models[1],_testData[28], false);FlatTimeSpaninterval0M.AssertModel(models[2],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelBatchAsync(connection, 22, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
TimeSpaninterval0M.AssertModel(models[0],_testData[3], false);TimeSpaninterval0M.AssertModel(models[1],_testData[4], false);TimeSpaninterval0M.AssertModel(models[2],_testData[5], false);TimeSpaninterval0M.AssertModel(models[3],_testData[6], false);TimeSpaninterval0M.AssertModel(models[4],_testData[7], false);TimeSpaninterval0M.AssertModel(models[5],_testData[8], false);TimeSpaninterval0M.AssertModel(models[6],_testData[9], false);TimeSpaninterval0M.AssertModel(models[7],_testData[10], false);TimeSpaninterval0M.AssertModel(models[8],_testData[11], false);TimeSpaninterval0M.AssertModel(models[9],_testData[12], false);TimeSpaninterval0M.AssertModel(models[10],_testData[13], false);TimeSpaninterval0M.AssertModel(models[11],_testData[14], false);TimeSpaninterval0M.AssertModel(models[12],_testData[15], false);TimeSpaninterval0M.AssertModel(models[13],_testData[16], false);TimeSpaninterval0M.AssertModel(models[14],_testData[17], false);TimeSpaninterval0M.AssertModel(models[15],_testData[18], false);TimeSpaninterval0M.AssertModel(models[16],_testData[19], false);TimeSpaninterval0M.AssertModel(models[17],_testData[20], false);TimeSpaninterval0M.AssertModel(models[18],_testData[21], false);TimeSpaninterval0M.AssertModel(models[19],_testData[22], false);TimeSpaninterval0M.AssertModel(models[20],_testData[23], false);TimeSpaninterval0M.AssertModel(models[21],_testData[24], false);TimeSpaninterval0M.AssertModel(models[22],_testData[25], false);TimeSpaninterval0M.AssertModel(models[23],_testData[26], false);TimeSpaninterval0M.AssertModel(models[24],_testData[27], false);TimeSpaninterval0M.AssertModel(models[25],_testData[28], false);TimeSpaninterval0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
TimeSpaninterval0M.AssertModel(models[0],_testData[13], false);TimeSpaninterval0M.AssertModel(models[1],_testData[14], false);TimeSpaninterval0M.AssertModel(models[2],_testData[15], false);TimeSpaninterval0M.AssertModel(models[3],_testData[16], false);TimeSpaninterval0M.AssertModel(models[4],_testData[17], false);TimeSpaninterval0M.AssertModel(models[5],_testData[18], false);TimeSpaninterval0M.AssertModel(models[6],_testData[19], false);TimeSpaninterval0M.AssertModel(models[7],_testData[20], false);TimeSpaninterval0M.AssertModel(models[8],_testData[21], false);TimeSpaninterval0M.AssertModel(models[9],_testData[22], false);TimeSpaninterval0M.AssertModel(models[10],_testData[23], false);TimeSpaninterval0M.AssertModel(models[11],_testData[24], false);TimeSpaninterval0M.AssertModel(models[12],_testData[25], false);TimeSpaninterval0M.AssertModel(models[13],_testData[26], false);TimeSpaninterval0M.AssertModel(models[14],_testData[27], false);TimeSpaninterval0M.AssertModel(models[15],_testData[28], false);TimeSpaninterval0M.AssertModel(models[16],_testData[29], false);
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
                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpaninterval0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelBatch(connection, 54, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
TimeSpaninterval0M.AssertModel(models[0],_testData[10], false);TimeSpaninterval0M.AssertModel(models[1],_testData[11], false);TimeSpaninterval0M.AssertModel(models[2],_testData[12], false);TimeSpaninterval0M.AssertModel(models[3],_testData[13], false);TimeSpaninterval0M.AssertModel(models[4],_testData[14], false);TimeSpaninterval0M.AssertModel(models[5],_testData[15], false);TimeSpaninterval0M.AssertModel(models[6],_testData[16], false);TimeSpaninterval0M.AssertModel(models[7],_testData[17], false);TimeSpaninterval0M.AssertModel(models[8],_testData[18], false);TimeSpaninterval0M.AssertModel(models[9],_testData[19], false);TimeSpaninterval0M.AssertModel(models[10],_testData[20], false);TimeSpaninterval0M.AssertModel(models[11],_testData[21], false);TimeSpaninterval0M.AssertModel(models[12],_testData[22], false);TimeSpaninterval0M.AssertModel(models[13],_testData[23], false);TimeSpaninterval0M.AssertModel(models[14],_testData[24], false);TimeSpaninterval0M.AssertModel(models[15],_testData[25], false);TimeSpaninterval0M.AssertModel(models[16],_testData[26], false);TimeSpaninterval0M.AssertModel(models[17],_testData[27], false);TimeSpaninterval0M.AssertModel(models[18],_testData[28], false);TimeSpaninterval0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
TimeSpaninterval0M.AssertModel(models[0],_testData[22], false);TimeSpaninterval0M.AssertModel(models[1],_testData[23], false);TimeSpaninterval0M.AssertModel(models[2],_testData[24], false);TimeSpaninterval0M.AssertModel(models[3],_testData[25], false);TimeSpaninterval0M.AssertModel(models[4],_testData[26], false);TimeSpaninterval0M.AssertModel(models[5],_testData[27], false);TimeSpaninterval0M.AssertModel(models[6],_testData[28], false);TimeSpaninterval0M.AssertModel(models[7],_testData[29], false);
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
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models = await ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
TimeSpaninterval0M.AssertModel(models[0],_testData[17], false);TimeSpaninterval0M.AssertModel(models[1],_testData[18], false);TimeSpaninterval0M.AssertModel(models[2],_testData[19], false);TimeSpaninterval0M.AssertModel(models[3],_testData[20], false);TimeSpaninterval0M.AssertModel(models[4],_testData[21], false);TimeSpaninterval0M.AssertModel(models[5],_testData[22], false);TimeSpaninterval0M.AssertModel(models[6],_testData[23], false);TimeSpaninterval0M.AssertModel(models[7],_testData[24], false);TimeSpaninterval0M.AssertModel(models[8],_testData[25], false);TimeSpaninterval0M.AssertModel(models[9],_testData[26], false);TimeSpaninterval0M.AssertModel(models[10],_testData[27], false);TimeSpaninterval0M.AssertModel(models[11],_testData[28], false);TimeSpaninterval0M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypeinterval)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
TimeSpaninterval0M.AssertModel(models[0],_testData[3], false);TimeSpaninterval0M.AssertModel(models[1],_testData[4], false);TimeSpaninterval0M.AssertModel(models[2],_testData[5], false);TimeSpaninterval0M.AssertModel(models[3],_testData[6], false);TimeSpaninterval0M.AssertModel(models[4],_testData[7], false);TimeSpaninterval0M.AssertModel(models[5],_testData[8], false);TimeSpaninterval0M.AssertModel(models[6],_testData[9], false);TimeSpaninterval0M.AssertModel(models[7],_testData[10], false);TimeSpaninterval0M.AssertModel(models[8],_testData[11], false);TimeSpaninterval0M.AssertModel(models[9],_testData[12], false);TimeSpaninterval0M.AssertModel(models[10],_testData[13], false);TimeSpaninterval0M.AssertModel(models[11],_testData[14], false);TimeSpaninterval0M.AssertModel(models[12],_testData[15], false);TimeSpaninterval0M.AssertModel(models[13],_testData[16], false);TimeSpaninterval0M.AssertModel(models[14],_testData[17], false);TimeSpaninterval0M.AssertModel(models[15],_testData[18], false);TimeSpaninterval0M.AssertModel(models[16],_testData[19], false);TimeSpaninterval0M.AssertModel(models[17],_testData[20], false);TimeSpaninterval0M.AssertModel(models[18],_testData[21], false);TimeSpaninterval0M.AssertModel(models[19],_testData[22], false);TimeSpaninterval0M.AssertModel(models[20],_testData[23], false);TimeSpaninterval0M.AssertModel(models[21],_testData[24], false);TimeSpaninterval0M.AssertModel(models[22],_testData[25], false);TimeSpaninterval0M.AssertModel(models[23],_testData[26], false);TimeSpaninterval0M.AssertModel(models[24],_testData[27], false);TimeSpaninterval0M.AssertModel(models[25],_testData[28], false);TimeSpaninterval0M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 30, milliseconds: 966))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 5, milliseconds: 923))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 26, milliseconds: 280))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 58, milliseconds: 968))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 23, milliseconds: 558))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 7, milliseconds: 312))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 24, milliseconds: 542))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 6, seconds: 52, milliseconds: 185))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 38, milliseconds: 201))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 6, milliseconds: 522))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 33, milliseconds: 629))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 56, seconds: 5, milliseconds: 571))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 28, milliseconds: 495))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 18, milliseconds: 346))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 17, milliseconds: 437))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 38, milliseconds: 331))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 8, milliseconds: 481))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 16, seconds: 9, milliseconds: 912))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 43, milliseconds: 123))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 4, milliseconds: 787))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 28, milliseconds: 768))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 0, milliseconds: 170))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 648))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 28, milliseconds: 299))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 31, milliseconds: 210))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 16, milliseconds: 906))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 48, milliseconds: 455))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 598))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 24, milliseconds: 552))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 8, milliseconds: 19))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 14, milliseconds: 620))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 46, milliseconds: 759))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 27, milliseconds: 729))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 58, milliseconds: 779))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 41, milliseconds: 664))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 51, milliseconds: 341))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 43, milliseconds: 933))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 33, milliseconds: 29))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 58, milliseconds: 745))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 17, milliseconds: 527))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 26, milliseconds: 196))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 2, milliseconds: 440))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 45, milliseconds: 26))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 32, milliseconds: 94))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 8, milliseconds: 401))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 1, milliseconds: 666))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 36, milliseconds: 571))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 40, milliseconds: 942))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 33, milliseconds: 813))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 55, milliseconds: 341))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 22, milliseconds: 345))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 21, milliseconds: 582))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 32, milliseconds: 484))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 52, seconds: 33, milliseconds: 278))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 41, milliseconds: 74))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 34, seconds: 37, milliseconds: 369))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 54, milliseconds: 785))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 43, milliseconds: 135))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 15, milliseconds: 789))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 10, milliseconds: 827))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 38, milliseconds: 264))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 35, milliseconds: 551))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 6, milliseconds: 159))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 23, milliseconds: 482))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 2, milliseconds: 189))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 48, milliseconds: 218))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 54, milliseconds: 59))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 0, milliseconds: 485))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 30, milliseconds: 966))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 5, milliseconds: 923))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 26, milliseconds: 280))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 58, milliseconds: 968))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 23, milliseconds: 558))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 7, milliseconds: 312))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 24, milliseconds: 542))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 6, seconds: 52, milliseconds: 185))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 38, milliseconds: 201))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 6, milliseconds: 522))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 33, milliseconds: 629))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 56, seconds: 5, milliseconds: 571))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 28, milliseconds: 495))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 18, milliseconds: 346))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 17, milliseconds: 437))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 38, milliseconds: 331))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 8, milliseconds: 481))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 16, seconds: 9, milliseconds: 912))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 43, milliseconds: 123))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 4, milliseconds: 787))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 28, milliseconds: 768))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 0, milliseconds: 170))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 31, milliseconds: 648))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 28, milliseconds: 299))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 31, milliseconds: 210))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 16, milliseconds: 906))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 48, milliseconds: 455))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 9, milliseconds: 598))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 24, milliseconds: 552))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 8, milliseconds: 19))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 14, milliseconds: 620))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 46, milliseconds: 759))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 27, milliseconds: 729))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 58, milliseconds: 779))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 41, milliseconds: 664))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 51, milliseconds: 341))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 43, milliseconds: 933))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 33, milliseconds: 29))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 58, milliseconds: 745))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 17, milliseconds: 527))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 26, milliseconds: 196))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 2, milliseconds: 440))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 45, milliseconds: 26))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 32, milliseconds: 94))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 8, milliseconds: 401))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 1, milliseconds: 666))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 36, milliseconds: 571))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 40, milliseconds: 942))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 33, milliseconds: 813))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 55, milliseconds: 341))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 22, milliseconds: 345))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 21, milliseconds: 582))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 32, milliseconds: 484))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 52, seconds: 33, milliseconds: 278))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 41, milliseconds: 74))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 34, seconds: 37, milliseconds: 369))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 54, milliseconds: 785))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 43, milliseconds: 135))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 15, milliseconds: 789))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 10, milliseconds: 827))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 38, milliseconds: 264))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 35, milliseconds: 551))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 6, milliseconds: 159))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 23, milliseconds: 482))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 2, milliseconds: 189))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 48, milliseconds: 218))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 54, milliseconds: 59))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 0, milliseconds: 485))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(TimeSpaninterval0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpaninterval0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ITimeSpanSingleTypeinterval)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanSingleTypeinterval)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((ITimeSpanSingleTypeinterval)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ITimeSpanSingleTypeinterval)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpaninterval0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpaninterval0M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((ITimeSpanSingleTypeinterval)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanSingleTypeinterval)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                TimeSpaninterval0M.AssertModel(models[0],_testData[0], false);
                TimeSpaninterval0M.AssertModel(models[1],_testData[1], false);
                TimeSpaninterval0M.AssertModel(models[2],_testData[2], false);
                TimeSpaninterval0M.AssertModel(models[3],_testData[3], false);
                TimeSpaninterval0M.AssertModel(models[4],_testData[4], false);
                TimeSpaninterval0M.AssertModel(models[5],_testData[5], false);
                TimeSpaninterval0M.AssertModel(models[6],_testData[6], false);
                TimeSpaninterval0M.AssertModel(models[7],_testData[7], false);
                TimeSpaninterval0M.AssertModel(models[8],_testData[8], false);
                TimeSpaninterval0M.AssertModel(models[9],_testData[9], false);
                TimeSpaninterval0M.AssertModel(models[10],_testData[10], false);
                TimeSpaninterval0M.AssertModel(models[11],_testData[11], false);
                TimeSpaninterval0M.AssertModel(models[12],_testData[12], false);
                TimeSpaninterval0M.AssertModel(models[13],_testData[13], false);
                TimeSpaninterval0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((ITimeSpanSingleTypeinterval)this).ImportModelAsync(connection, importCollection);
                models = await ((ITimeSpanSingleTypeinterval)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                TimeSpaninterval0M.AssertModel(models[0],_testData[0], false);
                TimeSpaninterval0M.AssertModel(models[1],_testData[1], false);
                TimeSpaninterval0M.AssertModel(models[2],_testData[2], false);
                TimeSpaninterval0M.AssertModel(models[3],_testData[3], false);
                TimeSpaninterval0M.AssertModel(models[4],_testData[4], false);
                TimeSpaninterval0M.AssertModel(models[5],_testData[5], false);
                TimeSpaninterval0M.AssertModel(models[6],_testData[6], false);
                TimeSpaninterval0M.AssertModel(models[7],_testData[7], false);
                TimeSpaninterval0M.AssertModel(models[8],_testData[8], false);
                TimeSpaninterval0M.AssertModel(models[9],_testData[9], false);
                TimeSpaninterval0M.AssertModel(models[10],_testData[10], false);
                TimeSpaninterval0M.AssertModel(models[11],_testData[11], false);
                TimeSpaninterval0M.AssertModel(models[12],_testData[12], false);
                TimeSpaninterval0M.AssertModel(models[13],_testData[13], false);
                TimeSpaninterval0M.AssertModel(models[14],_testData[14], false);
                TimeSpaninterval0M.AssertModel(models[15],_testData[15], false);
                TimeSpaninterval0M.AssertModel(models[16],_testData[16], false);
                TimeSpaninterval0M.AssertModel(models[17],_testData[17], false);
                TimeSpaninterval0M.AssertModel(models[18],_testData[18], false);
                TimeSpaninterval0M.AssertModel(models[19],_testData[19], false);
                TimeSpaninterval0M.AssertModel(models[20],_testData[20], false);
                TimeSpaninterval0M.AssertModel(models[21],_testData[21], false);
                TimeSpaninterval0M.AssertModel(models[22],_testData[22], false);
                TimeSpaninterval0M.AssertModel(models[23],_testData[23], false);
                TimeSpaninterval0M.AssertModel(models[24],_testData[24], false);
                TimeSpaninterval0M.AssertModel(models[25],_testData[25], false);
                TimeSpaninterval0M.AssertModel(models[26],_testData[26], false);
                TimeSpaninterval0M.AssertModel(models[27],_testData[27], false);
                TimeSpaninterval0M.AssertModel(models[28],_testData[28], false);
                TimeSpaninterval0M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanSingleTypeinterval)this).ExportModelInner(connection).ToList();
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

        [Test, Order(2)]
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

#endregion

    }
}


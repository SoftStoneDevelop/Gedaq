

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
    Value = new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 37, milliseconds: 525),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 8,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 29, milliseconds: 624),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 3,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 56, milliseconds: 166),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 17,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 53, milliseconds: 519),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 40, milliseconds: 606),
},
            new TimeSpaninterval0M
{
    Id = 26,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 14, milliseconds: 778),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 7,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 50, milliseconds: 564),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 33,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 23, milliseconds: 816),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 4, milliseconds: 529),
},
            new TimeSpaninterval0M
{
    Id = 40,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 34, milliseconds: 438),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 0, milliseconds: 168),
    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 56, milliseconds: 844),
},
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 39, milliseconds: 639),
},
            new TimeSpaninterval0M
{
    Id = 43,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 55, milliseconds: 400),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 44,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 26, milliseconds: 146),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 15,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 14, milliseconds: 947),
    NullableValue = new TimeSpan(days: 0, hours: 1, minutes: 16, seconds: 23, milliseconds: 952),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 48,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 41, milliseconds: 251),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 55, seconds: 52, milliseconds: 318),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 20,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 45, seconds: 32, milliseconds: 956),
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 232),
},
    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 11, milliseconds: 360),
},
            new TimeSpaninterval0M
{
    Id = 60,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 34, milliseconds: 899),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 23, milliseconds: 181),
},
            new TimeSpaninterval0M
{
    Id = 68,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 31, milliseconds: 473),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 22,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 3, milliseconds: 576),
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 51, milliseconds: 598),
},
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 35, milliseconds: 488),
},
            new TimeSpaninterval0M
{
    Id = 71,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 24, seconds: 39, milliseconds: 291),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 1, milliseconds: 586),
},
            new TimeSpaninterval0M
{
    Id = 77,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 41, milliseconds: 588),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 26,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 9, milliseconds: 631),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 86,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 11, milliseconds: 8),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 93,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 45, milliseconds: 14),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 34,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 38, milliseconds: 459),
    NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 54, milliseconds: 635),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 101,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 14, milliseconds: 950),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 39, milliseconds: 762),
},
            new TimeSpaninterval0M
{
    Id = 108,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 12, milliseconds: 385),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 39,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 17, milliseconds: 763),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 114,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 36, milliseconds: 320),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 58, milliseconds: 815),
},
            new TimeSpaninterval0M
{
    Id = 120,
    Value = new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 45, milliseconds: 930),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 44,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 37, milliseconds: 55),
    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 1, milliseconds: 547),
},
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 20, milliseconds: 661),
},
            new TimeSpaninterval0M
{
    Id = 122,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 20, milliseconds: 320),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 39, milliseconds: 770),
},
            new TimeSpaninterval0M
{
    Id = 124,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 49, milliseconds: 482),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 46,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 50, milliseconds: 264),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 132,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 10, milliseconds: 633),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 13, milliseconds: 968),
},
            new TimeSpaninterval0M
{
    Id = 139,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 42, milliseconds: 603),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 47,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 27, milliseconds: 159),
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 28, milliseconds: 440),
},
    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 12, milliseconds: 641),
},
            new TimeSpaninterval0M
{
    Id = 143,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 8, milliseconds: 337),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 43, milliseconds: 321),
},
            new TimeSpaninterval0M
{
    Id = 145,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 48, milliseconds: 366),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 50,
    Value = new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 7, milliseconds: 595),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 148,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 44, milliseconds: 821),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 51, milliseconds: 208),
},
            new TimeSpaninterval0M
{
    Id = 156,
    Value = new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 54, milliseconds: 7),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 53,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 35, milliseconds: 932),
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 25, milliseconds: 916),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 159,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 8, seconds: 2, milliseconds: 703),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 167,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 25, milliseconds: 974),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 57,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 46, milliseconds: 304),
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 4, milliseconds: 529)));
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
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 39, milliseconds: 639)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 11, milliseconds: 360)));
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
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 23, milliseconds: 181)));
                nullable = await ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 35, milliseconds: 488)));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((ITimeSpanSingleTypeinterval)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanSingleTypeinterval)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((ITimeSpanSingleTypeinterval)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[13], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[14], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[15], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[14],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[15],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[1], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[2], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[3], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[4], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[5], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[6], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[7], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[8], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[9], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[10], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[11], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[12], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[13], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[14], false);
                        TimeSpaninterval0M.AssertModel(models[14],_testData[15], false);
                        TimeSpaninterval0M.AssertModel(models[15],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[16],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[17],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[18],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[19],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[20],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[21],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[22],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[23],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[24],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[25],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[26],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[27],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 93, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[20],_testData[29], false);
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
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[25],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpaninterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[29], false);
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
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 122, query1, 43, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[14],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[15],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[16],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[17],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[18],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[19],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[20],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[21],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[22],_testData[29], false);
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
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 156, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatch(connection, 1, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[1], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(models[14],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(models[15],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[16],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[17],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[18],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[19],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[20],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[21],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[22],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[23],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[24],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[25],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[26],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[27],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[14],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[15],_testData[29], false);
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
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatch(connection, 43, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelBatch(connection, 93, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[2], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[3], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[4], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[5], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[6], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[7], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[8], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[9], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[10], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[11], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[12], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[13], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[14], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[15], false);
                        TimeSpaninterval0M.AssertModel(models[14],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[15],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[16],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[17],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[18],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[19],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[20],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[21],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[22],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[23],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[24],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[25],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[26],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[27],_testData[29], false);
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
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
TimeSpaninterval0M.AssertModel(models[0],_testData[23], false);TimeSpaninterval0M.AssertModel(models[1],_testData[24], false);TimeSpaninterval0M.AssertModel(models[2],_testData[25], false);TimeSpaninterval0M.AssertModel(models[3],_testData[26], false);TimeSpaninterval0M.AssertModel(models[4],_testData[27], false);TimeSpaninterval0M.AssertModel(models[5],_testData[28], false);TimeSpaninterval0M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypeinterval)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
TimeSpaninterval0M.AssertModel(models[0],_testData[7], false);TimeSpaninterval0M.AssertModel(models[1],_testData[8], false);TimeSpaninterval0M.AssertModel(models[2],_testData[9], false);TimeSpaninterval0M.AssertModel(models[3],_testData[10], false);TimeSpaninterval0M.AssertModel(models[4],_testData[11], false);TimeSpaninterval0M.AssertModel(models[5],_testData[12], false);TimeSpaninterval0M.AssertModel(models[6],_testData[13], false);TimeSpaninterval0M.AssertModel(models[7],_testData[14], false);TimeSpaninterval0M.AssertModel(models[8],_testData[15], false);TimeSpaninterval0M.AssertModel(models[9],_testData[16], false);TimeSpaninterval0M.AssertModel(models[10],_testData[17], false);TimeSpaninterval0M.AssertModel(models[11],_testData[18], false);TimeSpaninterval0M.AssertModel(models[12],_testData[19], false);TimeSpaninterval0M.AssertModel(models[13],_testData[20], false);TimeSpaninterval0M.AssertModel(models[14],_testData[21], false);TimeSpaninterval0M.AssertModel(models[15],_testData[22], false);TimeSpaninterval0M.AssertModel(models[16],_testData[23], false);TimeSpaninterval0M.AssertModel(models[17],_testData[24], false);TimeSpaninterval0M.AssertModel(models[18],_testData[25], false);TimeSpaninterval0M.AssertModel(models[19],_testData[26], false);TimeSpaninterval0M.AssertModel(models[20],_testData[27], false);TimeSpaninterval0M.AssertModel(models[21],_testData[28], false);TimeSpaninterval0M.AssertModel(models[22],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 37, milliseconds: 525))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 29, milliseconds: 624))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 56, milliseconds: 166))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 53, milliseconds: 519))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 40, milliseconds: 606))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 14, milliseconds: 778))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 50, milliseconds: 564))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 23, milliseconds: 816))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 4, milliseconds: 529))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 34, milliseconds: 438))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 0, milliseconds: 168))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 56, milliseconds: 844))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 39, milliseconds: 639))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 55, milliseconds: 400))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 26, milliseconds: 146))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 14, milliseconds: 947))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 16, seconds: 23, milliseconds: 952))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 41, milliseconds: 251))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 55, seconds: 52, milliseconds: 318))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 45, seconds: 32, milliseconds: 956))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 232))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 11, milliseconds: 360))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 34, milliseconds: 899))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 23, milliseconds: 181))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 31, milliseconds: 473))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 3, milliseconds: 576))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 51, milliseconds: 598))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 35, milliseconds: 488))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 24, seconds: 39, milliseconds: 291))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 1, milliseconds: 586))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 41, milliseconds: 588))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 9, milliseconds: 631))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 11, milliseconds: 8))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 45, milliseconds: 14))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 38, milliseconds: 459))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 54, milliseconds: 635))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 14, milliseconds: 950))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 39, milliseconds: 762))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 12, milliseconds: 385))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 17, milliseconds: 763))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 36, milliseconds: 320))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 58, milliseconds: 815))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 45, milliseconds: 930))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 37, milliseconds: 55))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 1, milliseconds: 547))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 20, milliseconds: 661))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 20, milliseconds: 320))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 39, milliseconds: 770))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 49, milliseconds: 482))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 50, milliseconds: 264))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 10, milliseconds: 633))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 13, milliseconds: 968))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 42, milliseconds: 603))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 27, milliseconds: 159))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 28, milliseconds: 440))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 12, milliseconds: 641))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 8, milliseconds: 337))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 43, milliseconds: 321))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 48, milliseconds: 366))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 7, milliseconds: 595))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 44, milliseconds: 821))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 51, milliseconds: 208))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 54, milliseconds: 7))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 35, milliseconds: 932))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 25, milliseconds: 916))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 8, seconds: 2, milliseconds: 703))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 25, milliseconds: 974))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 46, milliseconds: 304))));//InnerModel.Value

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
                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 37, milliseconds: 525))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 29, milliseconds: 624))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 56, milliseconds: 166))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 53, milliseconds: 519))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 40, milliseconds: 606))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 14, milliseconds: 778))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 50, milliseconds: 564))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 23, milliseconds: 816))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 4, milliseconds: 529))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 34, milliseconds: 438))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 0, milliseconds: 168))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 56, milliseconds: 844))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 39, milliseconds: 639))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 55, milliseconds: 400))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 26, milliseconds: 146))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 14, milliseconds: 947))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 16, seconds: 23, milliseconds: 952))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 41, milliseconds: 251))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 55, seconds: 52, milliseconds: 318))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 45, seconds: 32, milliseconds: 956))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 8, milliseconds: 232))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 11, milliseconds: 360))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 34, milliseconds: 899))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 23, milliseconds: 181))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 31, milliseconds: 473))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 3, milliseconds: 576))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 51, milliseconds: 598))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 35, milliseconds: 488))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 24, seconds: 39, milliseconds: 291))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 1, milliseconds: 586))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 41, milliseconds: 588))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 9, milliseconds: 631))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 11, milliseconds: 8))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 45, milliseconds: 14))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 38, milliseconds: 459))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 54, milliseconds: 635))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 14, milliseconds: 950))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 39, milliseconds: 762))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 12, milliseconds: 385))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 17, milliseconds: 763))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 36, milliseconds: 320))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 58, milliseconds: 815))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 45, milliseconds: 930))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 37, milliseconds: 55))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 1, milliseconds: 547))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 20, milliseconds: 661))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 20, milliseconds: 320))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 39, milliseconds: 770))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 49, milliseconds: 482))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 50, milliseconds: 264))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 10, milliseconds: 633))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 13, milliseconds: 968))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 42, milliseconds: 603))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 27, milliseconds: 159))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 28, milliseconds: 440))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 12, milliseconds: 641))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 8, milliseconds: 337))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 43, milliseconds: 321))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 48, milliseconds: 366))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 7, milliseconds: 595))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 44, milliseconds: 821))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 51, milliseconds: 208))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 54, milliseconds: 7))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 35, milliseconds: 932))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 25, milliseconds: 916))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 8, seconds: 2, milliseconds: 703))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 25, milliseconds: 974))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 46, milliseconds: 304))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpaninterval0MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanSingleTypeinterval)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpaninterval0MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanSingleTypeinterval)this).DynQuerySelectImportModelInner(connection);
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpaninterval0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanSingleTypeinterval)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanSingleTypeinterval)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpaninterval0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanSingleTypeinterval)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanSingleTypeinterval)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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


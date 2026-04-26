

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
    Id = 6,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 37, milliseconds: 357),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 15,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 40, milliseconds: 643),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 6,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 30, milliseconds: 783),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 24,
    Value = new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 58, milliseconds: 304),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 21, milliseconds: 592),
},
            new TimeSpaninterval0M
{
    Id = 30,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 43, milliseconds: 812),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 14,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 54, milliseconds: 271),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 38,
    Value = new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 3, milliseconds: 110),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 44,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 9, milliseconds: 994),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 22,
    Value = new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 12, milliseconds: 79),
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 4, milliseconds: 332),
},
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 11, milliseconds: 568),
},
            new TimeSpaninterval0M
{
    Id = 51,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 50, milliseconds: 532),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 52,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 53, milliseconds: 754),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 27,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 35, seconds: 48, milliseconds: 632),
    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 4, milliseconds: 746),
},
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 9, milliseconds: 343),
},
            new TimeSpaninterval0M
{
    Id = 58,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 34, milliseconds: 779),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 41, milliseconds: 876),
},
            new TimeSpaninterval0M
{
    Id = 61,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 1, milliseconds: 796),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 31,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 27, milliseconds: 44),
    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 20, milliseconds: 816),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 64,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 0, milliseconds: 366),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 14, milliseconds: 117),
},
            new TimeSpaninterval0M
{
    Id = 66,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 56, milliseconds: 107),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 34,
    Value = new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 10, milliseconds: 802),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 74,
    Value = new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 26, milliseconds: 688),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 81,
    Value = new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 49, milliseconds: 809),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 39,
    Value = new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 45, milliseconds: 566),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 87,
    Value = new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 20, milliseconds: 578),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 95,
    Value = new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 20, milliseconds: 658),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 44,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 20, milliseconds: 121),
    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 37, milliseconds: 196),
},
    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 54, milliseconds: 802),
},
            new TimeSpaninterval0M
{
    Id = 98,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 41, seconds: 4, milliseconds: 120),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 103,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 33, milliseconds: 998),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 48,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 34, milliseconds: 112),
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 0, milliseconds: 249),
},
    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 11, seconds: 19, milliseconds: 193),
},
            new TimeSpaninterval0M
{
    Id = 104,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 32, milliseconds: 572),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 107,
    Value = new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 3, milliseconds: 813),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 49,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 25, milliseconds: 395),
    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 31, milliseconds: 144),
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 113,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 58, milliseconds: 251),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 122,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 55, milliseconds: 897),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 57,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 29, seconds: 30, milliseconds: 290),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 126,
    Value = new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 42, milliseconds: 535),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 127,
    Value = new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 50, milliseconds: 228),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 59,
    Value = new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 48, milliseconds: 593),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 11, milliseconds: 713),
},
            new TimeSpaninterval0M
{
    Id = 130,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 53, milliseconds: 177),
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpaninterval0M
{
    Id = 131,
    Value = new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 47, milliseconds: 748),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 66,
    Value = new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 19, milliseconds: 187),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 6, milliseconds: 226),
},
            new TimeSpaninterval0M
{
    Id = 137,
    Value = new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 30, milliseconds: 349),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 51, milliseconds: 770),
},
            new TimeSpaninterval0M
{
    Id = 144,
    Value = new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 50, milliseconds: 876),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 68,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 20, milliseconds: 759),
    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 41, seconds: 12, milliseconds: 746),
},
    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 53, milliseconds: 745),
},
            new TimeSpaninterval0M
{
    Id = 150,
    Value = new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 42, milliseconds: 794),
    ModelInner = null,
    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 13, milliseconds: 411),
},
            new TimeSpaninterval0M
{
    Id = 154,
    Value = new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 57, milliseconds: 642),
    ModelInner = new TimeSpaninterval0MI
{
    Id = 69,
    Value = new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 44, milliseconds: 518),
    NullableValue = null,
},
    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 559),
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
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 11, milliseconds: 568)));
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
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 9, milliseconds: 343)));
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
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 41, milliseconds: 876)));
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
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 14, milliseconds: 117)));
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[26],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[29], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[29], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[29], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[2], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[3], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(models[14],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[15],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[16],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[17],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[18],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[19],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[20],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[21],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[22],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[23],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[24],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[25],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[26],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[25],_testData[29], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[15], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[16], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[13],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[14],_testData[29], false);
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
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 66, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[29], false);
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
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 87, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[29], false);
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
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[24],_testData[29], false);
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
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatch(connection, 66, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems2[17],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 95, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeSpaninterval0M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                await ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 6, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
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
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatch(connection, 66, query1, 113, query2))
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
                 ((ITimeSpanSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatch(connection, 66, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeSpaninterval0M.AssertModel(secondItems2[16],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelBatchAsync(connection, 98, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[17], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanSingleTypeinterval)this).DbConnectionSTSelectModelBatch(connection, 137, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeSpaninterval0M.AssertModel(models[0],_testData[18], false);
                        TimeSpaninterval0M.AssertModel(models[1],_testData[19], false);
                        TimeSpaninterval0M.AssertModel(models[2],_testData[20], false);
                        TimeSpaninterval0M.AssertModel(models[3],_testData[21], false);
                        TimeSpaninterval0M.AssertModel(models[4],_testData[22], false);
                        TimeSpaninterval0M.AssertModel(models[5],_testData[23], false);
                        TimeSpaninterval0M.AssertModel(models[6],_testData[24], false);
                        TimeSpaninterval0M.AssertModel(models[7],_testData[25], false);
                        TimeSpaninterval0M.AssertModel(models[8],_testData[26], false);
                        TimeSpaninterval0M.AssertModel(models[9],_testData[27], false);
                        TimeSpaninterval0M.AssertModel(models[10],_testData[28], false);
                        TimeSpaninterval0M.AssertModel(models[11],_testData[29], false);
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
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
TimeSpaninterval0M.AssertModel(models[0],_testData[22], false);TimeSpaninterval0M.AssertModel(models[1],_testData[23], false);TimeSpaninterval0M.AssertModel(models[2],_testData[24], false);TimeSpaninterval0M.AssertModel(models[3],_testData[25], false);TimeSpaninterval0M.AssertModel(models[4],_testData[26], false);TimeSpaninterval0M.AssertModel(models[5],_testData[27], false);TimeSpaninterval0M.AssertModel(models[6],_testData[28], false);TimeSpaninterval0M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypeinterval)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
TimeSpaninterval0M.AssertModel(models[0],_testData[18], false);TimeSpaninterval0M.AssertModel(models[1],_testData[19], false);TimeSpaninterval0M.AssertModel(models[2],_testData[20], false);TimeSpaninterval0M.AssertModel(models[3],_testData[21], false);TimeSpaninterval0M.AssertModel(models[4],_testData[22], false);TimeSpaninterval0M.AssertModel(models[5],_testData[23], false);TimeSpaninterval0M.AssertModel(models[6],_testData[24], false);TimeSpaninterval0M.AssertModel(models[7],_testData[25], false);TimeSpaninterval0M.AssertModel(models[8],_testData[26], false);TimeSpaninterval0M.AssertModel(models[9],_testData[27], false);TimeSpaninterval0M.AssertModel(models[10],_testData[28], false);TimeSpaninterval0M.AssertModel(models[11],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 37, milliseconds: 357))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 40, milliseconds: 643))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 30, milliseconds: 783))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 58, milliseconds: 304))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 21, milliseconds: 592))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 43, milliseconds: 812))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 54, milliseconds: 271))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 3, milliseconds: 110))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 9, milliseconds: 994))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 12, milliseconds: 79))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 4, milliseconds: 332))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 11, milliseconds: 568))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 50, milliseconds: 532))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 53, milliseconds: 754))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 35, seconds: 48, milliseconds: 632))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 4, milliseconds: 746))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 9, milliseconds: 343))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 34, milliseconds: 779))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 41, milliseconds: 876))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 1, milliseconds: 796))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 27, milliseconds: 44))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 20, milliseconds: 816))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 0, milliseconds: 366))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 14, milliseconds: 117))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 56, milliseconds: 107))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 10, milliseconds: 802))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 26, milliseconds: 688))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 49, milliseconds: 809))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 45, milliseconds: 566))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 20, milliseconds: 578))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 20, milliseconds: 658))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 20, milliseconds: 121))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 37, milliseconds: 196))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 54, milliseconds: 802))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 41, seconds: 4, milliseconds: 120))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 33, milliseconds: 998))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 34, milliseconds: 112))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 0, milliseconds: 249))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 11, seconds: 19, milliseconds: 193))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 32, milliseconds: 572))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 3, milliseconds: 813))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 25, milliseconds: 395))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 31, milliseconds: 144))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 58, milliseconds: 251))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 55, milliseconds: 897))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 29, seconds: 30, milliseconds: 290))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 42, milliseconds: 535))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 50, milliseconds: 228))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 48, milliseconds: 593))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 11, milliseconds: 713))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 53, milliseconds: 177))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 47, milliseconds: 748))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 19, milliseconds: 187))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 6, milliseconds: 226))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 30, milliseconds: 349))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 51, milliseconds: 770))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 50, milliseconds: 876))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 20, milliseconds: 759))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 41, seconds: 12, milliseconds: 746))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 53, milliseconds: 745))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 42, milliseconds: 794))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 13, milliseconds: 411))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 57, milliseconds: 642))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 44, milliseconds: 518))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 559))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 37, milliseconds: 357))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 40, milliseconds: 643))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 30, milliseconds: 783))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 58, milliseconds: 304))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 21, milliseconds: 592))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 43, milliseconds: 812))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 54, milliseconds: 271))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 3, milliseconds: 110))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 9, milliseconds: 994))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 12, milliseconds: 79))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 4, milliseconds: 332))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 11, milliseconds: 568))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 50, milliseconds: 532))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 53, milliseconds: 754))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 35, seconds: 48, milliseconds: 632))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 4, milliseconds: 746))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 9, milliseconds: 343))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 34, milliseconds: 779))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 41, milliseconds: 876))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 1, milliseconds: 796))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 27, milliseconds: 44))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 20, milliseconds: 816))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 0, milliseconds: 366))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 14, milliseconds: 117))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 56, milliseconds: 107))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 10, milliseconds: 802))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 26, milliseconds: 688))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 49, milliseconds: 809))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 45, milliseconds: 566))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 20, milliseconds: 578))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 20, milliseconds: 658))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 20, milliseconds: 121))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 37, milliseconds: 196))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 54, milliseconds: 802))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 41, seconds: 4, milliseconds: 120))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 33, milliseconds: 998))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 34, milliseconds: 112))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 0, milliseconds: 249))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 11, seconds: 19, milliseconds: 193))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 32, milliseconds: 572))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 3, milliseconds: 813))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 25, milliseconds: 395))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 31, milliseconds: 144))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 58, milliseconds: 251))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 55, milliseconds: 897))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 29, seconds: 30, milliseconds: 290))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 42, milliseconds: 535))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 50, milliseconds: 228))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 48, milliseconds: 593))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 11, milliseconds: 713))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 53, milliseconds: 177))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 47, milliseconds: 748))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 19, milliseconds: 187))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 6, milliseconds: 226))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 30, milliseconds: 349))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 51, milliseconds: 770))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 50, milliseconds: 876))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 20, milliseconds: 759))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 41, seconds: 12, milliseconds: 746))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 53, milliseconds: 745))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 42, milliseconds: 794))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 13, milliseconds: 411))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 57, milliseconds: 642))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 44, milliseconds: 518))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 25, milliseconds: 559))));

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




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
    internal partial interface ITimeSpanSingleTypetime_without_time_zone
    {
    }
    
    internal partial class TimeSpanSingleTypetime_without_time_zone : ITimeSpanSingleTypetime_without_time_zone
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zone0mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zone0mi(
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
            queryMapType: typeof(TimeSpantime_without_time_zone0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                )
            ]
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

                changedRows =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelInner(connection, 1590206218, new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292), new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelInner(connection, 1007982353, new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893), new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863));
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

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelInnerAsync(connection, 1935592782, new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelInnerAsync(connection, 1417704363, new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturning()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelInnerReturning(connection, 588725715, new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268), new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590));
                Assert.That(id, Is.EqualTo(588725715));

                id =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelInnerReturning(connection, 1511076362, new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387), new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595));
                Assert.That(id, Is.EqualTo(1511076362));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelInnerReturningAsync(connection, 443190068, new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558), new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101));
                Assert.That(id, Is.EqualTo(443190068));

                id = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelInnerReturningAsync(connection, 1113679522, new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515), null);
                Assert.That(id, Is.EqualTo(1113679522));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zone0mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(17)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17), 
                nullable: true
                )
            ]
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

                changedRows =  ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertInnerModel(connection, 706063418, new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970), new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605));
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

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1481392852, new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 88278930, new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388), new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1829179379, new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1979544116, new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636), new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1429496256, new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 749626992, new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363), new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timespantime_without_time_zone0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespantime_without_time_zone0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
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

                changedRows =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModel(connection, 1551372402, new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModel(connection, 661177871, new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370), new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718), 1590206218);
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

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelAsync(connection, 469900549, new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556), new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelAsync(connection, 1009039561, new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157), new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949), 1007982353);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan? nullable = null;

                nullable =  ((ITimeSpanSingleTypetime_without_time_zone)this).ScalarInsertModelReturning(connection, 649531402, new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384), new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                nullable =  ((ITimeSpanSingleTypetime_without_time_zone)this).ScalarInsertModelReturning(connection, 644345121, new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389), null, 1935592782);

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

                nullable = await ((ITimeSpanSingleTypetime_without_time_zone)this).ScalarInsertModelReturningAsync(connection, 1889583790, new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781), null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((ITimeSpanSingleTypetime_without_time_zone)this).ScalarInsertModelReturningAsync(connection, 693579263, new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499), null, 1417704363);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timespantime_without_time_zone0mi_id
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
    timespantime_without_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(TimeSpantime_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespantime_without_time_zone0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpantime_without_time_zone0M> models = null;
                TimeSpantime_without_time_zone0M model = null;

                models =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelReturning(connection, 1006591252, new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278), new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelReturning(connection, 72594249, new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116), null, 588725715).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72594249));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(588725715));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelReturning(connection, 558281559, new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758), new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelReturning(connection, 1123191003, new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542), null, 1511076362).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpantime_without_time_zone0M> models = null;
                TimeSpantime_without_time_zone0M model = null;

                models = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, 802255889, new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, 1033900183, new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980), new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52), 443190068).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, 1971937962, new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanSingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, 935254079, new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532), null, 1113679522).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.timespantime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timespantime_without_time_zone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timespantime_without_time_zone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.TimeSpan), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(17)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime_without_time_zone0mi_id", 
                methodParametrName: "timespantime_without_time_zone0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true
            )
            ]
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

                changedRows =  ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModel(connection, 291927602, new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModel(connection, 959425730, new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17), new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587), 706063418);
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

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1331178779, new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727), new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 348541579, new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704), null, 1481392852);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 948508310, new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525), new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1911167390, new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944), new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137), 88278930);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 49677666, new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 222472933, new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359), null, 1829179379);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 560670635, new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551), new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1335731964, new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647), new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727), 1979544116);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1511038425, new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 318176227, new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732), null, 1429496256);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1807844390, new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 677468820, new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426), new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644), 749626992);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region Select Models

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
FROM public.timespantime_without_time_zone0m m
LEFT JOIN public.timespantime_without_time_zone0mi mi ON mi.id = m.timespantime_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeSpantime_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanSingleTypetime_without_time_zone)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(49677666));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72594249));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(588725715));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222472933));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829179379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291927602));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318176227));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429496256));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(348541579));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1481392852));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948508310));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypetime_without_time_zone)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(49677666));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72594249));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(588725715));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222472933));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829179379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291927602));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318176227));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429496256));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(348541579));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1481392852));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948508310));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

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
FROM public.timespantime_without_time_zone0m m
LEFT JOIN public.timespantime_without_time_zone0mi mi ON mi.id = m.timespantime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeSpantime_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11)
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(49677666));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72594249));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(588725715));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222472933));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829179379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291927602));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318176227));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429496256));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(348541579));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1481392852));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948508310));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(49677666));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72594249));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(588725715));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222472933));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829179379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291927602));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318176227));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429496256));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(348541579));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1481392852));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948508310));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime_without_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 1009039561);
                var models =  ((ITimeSpanSingleTypetime_without_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(10));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeSpanSingleTypetime_without_time_zone)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanSingleTypetime_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 318176227);
                var models = await ((ITimeSpanSingleTypetime_without_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(348541579));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1481392852));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948508310));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionSelectModelBatch(connection, 348541579, 948508310))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948508310));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(13));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
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
                await foreach(var batchResult in ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionSelectModelBatchAsync(connection, 1807844390, 72594249))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(3));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222472933));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829179379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291927602));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318176227));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429496256));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(348541579));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1481392852));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948508310));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
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
FROM public.timespantime_without_time_zone0m m
LEFT JOIN public.timespantime_without_time_zone0mi mi ON mi.id = m.timespantime_without_time_zone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapType: typeof(object[]),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime_without_time_zone)
            )
            ]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49677666)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72594249)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((588725715)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((222472933)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1829179379)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((291927602)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((318176227)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1429496256)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((348541579)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1481392852)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((469900549)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((558281559)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((560670635)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((644345121)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1935592782)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((649531402)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((661177871)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1590206218)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((677468820)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((749626992)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((693579263)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1417704363)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((802255889)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((935254079)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1113679522)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((948508310)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((959425730)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((706063418)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1006591252)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1009039561)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1007982353)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1033900183)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((443190068)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1123191003)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1511076362)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1331178779)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1335731964)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1979544116)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1511038425)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1551372402)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1807844390)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1889583790)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1911167390)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88278930)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1971937962)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypetime_without_time_zone)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49677666)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72594249)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((588725715)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((222472933)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1829179379)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((291927602)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((318176227)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1429496256)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((348541579)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1481392852)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((469900549)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((558281559)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((560670635)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((644345121)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1935592782)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((649531402)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((661177871)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1590206218)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((677468820)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((749626992)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((693579263)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1417704363)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((802255889)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((935254079)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1113679522)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((948508310)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((959425730)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((706063418)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1006591252)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1009039561)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1007982353)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1033900183)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((443190068)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1123191003)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1511076362)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1331178779)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1335731964)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1979544116)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1511038425)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1551372402)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1807844390)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1889583790)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1911167390)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88278930)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1971937962)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespantime_without_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zone0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_timespantime_without_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zone0MI),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpantime_without_time_zone0MI>(7);

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 88278930,
                    Value = new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388),
                    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 443190068,
                    Value = new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558),
                    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 588725715,
                    Value = new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268),
                    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 706063418,
                    Value = new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970),
                    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 749626992,
                    Value = new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363),
                    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1007982353,
                    Value = new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893),
                    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1113679522,
                    Value = new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515),
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88278930));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443190068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(588725715));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(706063418));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749626992));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1007982353));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113679522));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1417704363,
                    Value = new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1429496256,
                    Value = new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1481392852,
                    Value = new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1511076362,
                    Value = new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387),
                    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1590206218,
                    Value = new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292),
                    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1829179379,
                    Value = new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1935592782,
                    Value = new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0MI
                {
                    Id = 1979544116,
                    Value = new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636),
                    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88278930));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443190068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(588725715));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(706063418));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749626992));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1007982353));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113679522));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417704363));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429496256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481392852));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511076362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1590206218));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1829179379));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1935592782));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979544116));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespantime_without_time_zone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespantime_without_time_zone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpantime_without_time_zone0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_timespantime_without_time_zone0m m
LEFT JOIN public.binary_timespantime_without_time_zone0mi mi ON mi.id = m.timespantime_without_time_zone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeSpantime_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpantime_without_time_zone0M>(15);

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 49677666,
                    Value = new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 72594249,
                    Value = new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116),
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 588725715
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 222472933,
                    Value = new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359),
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1829179379
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 291927602,
                    Value = new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 318176227,
                    Value = new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732),
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1429496256
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 348541579,
                    Value = new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704),
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1481392852
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 469900549,
                    Value = new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556),
                    NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 558281559,
                    Value = new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758),
                    NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 560670635,
                    Value = new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551),
                    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 644345121,
                    Value = new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389),
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1935592782
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 649531402,
                    Value = new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384),
                    NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 661177871,
                    Value = new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370),
                    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718),

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1590206218
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 677468820,
                    Value = new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426),
                    NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644),

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 749626992
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 693579263,
                    Value = new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499),
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1417704363
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 802255889,
                    Value = new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526),
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(49677666));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72594249));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(588725715));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222472933));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829179379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291927602));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318176227));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429496256));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(348541579));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1481392852));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 935254079,
                    Value = new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532),
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1113679522
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 948508310,
                    Value = new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525),
                    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 959425730,
                    Value = new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17),
                    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587),

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 706063418
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1006591252,
                    Value = new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278),
                    NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1009039561,
                    Value = new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157),
                    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949),

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1007982353
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1033900183,
                    Value = new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980),
                    NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52),

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 443190068
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1123191003,
                    Value = new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542),
                    NullableValue = null,

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1511076362
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1331178779,
                    Value = new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727),
                    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1335731964,
                    Value = new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647),
                    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727),

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 1979544116
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1511038425,
                    Value = new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1551372402,
                    Value = new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1807844390,
                    Value = new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1889583790,
                    Value = new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1911167390,
                    Value = new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944),
                    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137),

                    ModelInner = new TimeSpantime_without_time_zone0MI 
                    {
                        Id = 88278930
                    }

                });

                importCollection.Add(
                new TimeSpantime_without_time_zone0M
                {
                    Id = 1971937962,
                    Value = new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276),
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(49677666));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72594249));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(588725715));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(222472933));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829179379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291927602));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318176227));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429496256));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(348541579));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1481392852));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(469900549));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558281559));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560670635));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(644345121));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1935592782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649531402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661177871));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1590206218));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677468820));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749626992));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693579263));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1417704363));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802255889));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935254079));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1113679522));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948508310));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959425730));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(706063418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1006591252));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009039561));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1007982353));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033900183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(443190068));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)));


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123191003));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1511076362));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)));


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331178779));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1335731964));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1979544116));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1511038425));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551372402));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1807844390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889583790));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1911167390));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88278930));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)));


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971937962));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespantime_without_time_zone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespantime_without_time_zone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(TimeSpantime_without_time_zone0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zone0M>(30);

                expected.Add(
                    49677666,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 49677666,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    72594249,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 72594249,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 588725715,
                            Value = new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268),
                            NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)
                        }

                    }
                );

                expected.Add(
                    222472933,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 222472933,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1829179379,
                            Value = new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    291927602,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 291927602,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    318176227,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 318176227,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1429496256,
                            Value = new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    348541579,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 348541579,
                        Value = new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1481392852,
                            Value = new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    469900549,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 469900549,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556),
                        NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208),

                        ModelInner = null

                    }
                );

                expected.Add(
                    558281559,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 558281559,
                        Value = new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758),
                        NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225),

                        ModelInner = null

                    }
                );

                expected.Add(
                    560670635,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 560670635,
                        Value = new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551),
                        NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428),

                        ModelInner = null

                    }
                );

                expected.Add(
                    644345121,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 644345121,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1935592782,
                            Value = new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    649531402,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 649531402,
                        Value = new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384),
                        NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328),

                        ModelInner = null

                    }
                );

                expected.Add(
                    661177871,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 661177871,
                        Value = new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370),
                        NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1590206218,
                            Value = new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292),
                            NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)
                        }

                    }
                );

                expected.Add(
                    677468820,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 677468820,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426),
                        NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 749626992,
                            Value = new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363),
                            NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)
                        }

                    }
                );

                expected.Add(
                    693579263,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 693579263,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1417704363,
                            Value = new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    802255889,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 802255889,
                        Value = new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    935254079,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 935254079,
                        Value = new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1113679522,
                            Value = new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    948508310,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 948508310,
                        Value = new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525),
                        NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426),

                        ModelInner = null

                    }
                );

                expected.Add(
                    959425730,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 959425730,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17),
                        NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 706063418,
                            Value = new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970),
                            NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)
                        }

                    }
                );

                expected.Add(
                    1006591252,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1006591252,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278),
                        NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1009039561,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1009039561,
                        Value = new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157),
                        NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1007982353,
                            Value = new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893),
                            NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)
                        }

                    }
                );

                expected.Add(
                    1033900183,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1033900183,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980),
                        NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 443190068,
                            Value = new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558),
                            NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)
                        }

                    }
                );

                expected.Add(
                    1123191003,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1123191003,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1511076362,
                            Value = new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387),
                            NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)
                        }

                    }
                );

                expected.Add(
                    1331178779,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1331178779,
                        Value = new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727),
                        NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1335731964,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1335731964,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1979544116,
                            Value = new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636),
                            NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)
                        }

                    }
                );

                expected.Add(
                    1511038425,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1511038425,
                        Value = new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1551372402,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1551372402,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1807844390,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1807844390,
                        Value = new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1889583790,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1889583790,
                        Value = new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1911167390,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1911167390,
                        Value = new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944),
                        NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 88278930,
                            Value = new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388),
                            NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)
                        }

                    }
                );

                expected.Add(
                    1971937962,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1971937962,
                        Value = new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                var models =  ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zone0M>(30);

                expected.Add(
                    49677666,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 49677666,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 14, milliseconds: 164),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    72594249,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 72594249,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 49, milliseconds: 116),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 588725715,
                            Value = new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268),
                            NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)
                        }

                    }
                );

                expected.Add(
                    222472933,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 222472933,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 11, milliseconds: 359),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1829179379,
                            Value = new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    291927602,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 291927602,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 14, milliseconds: 747),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    318176227,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 318176227,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 10, milliseconds: 732),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1429496256,
                            Value = new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    348541579,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 348541579,
                        Value = new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 37, milliseconds: 704),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1481392852,
                            Value = new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    469900549,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 469900549,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 25, milliseconds: 556),
                        NullableValue = new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 22, milliseconds: 208),

                        ModelInner = null

                    }
                );

                expected.Add(
                    558281559,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 558281559,
                        Value = new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 41, milliseconds: 758),
                        NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 18, milliseconds: 225),

                        ModelInner = null

                    }
                );

                expected.Add(
                    560670635,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 560670635,
                        Value = new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 14, milliseconds: 551),
                        NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 43, milliseconds: 428),

                        ModelInner = null

                    }
                );

                expected.Add(
                    644345121,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 644345121,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 21, milliseconds: 389),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1935592782,
                            Value = new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    649531402,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 649531402,
                        Value = new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 56, milliseconds: 384),
                        NullableValue = new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 37, milliseconds: 328),

                        ModelInner = null

                    }
                );

                expected.Add(
                    661177871,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 661177871,
                        Value = new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 370),
                        NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 10, milliseconds: 718),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1590206218,
                            Value = new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292),
                            NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)
                        }

                    }
                );

                expected.Add(
                    677468820,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 677468820,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 51, milliseconds: 426),
                        NullableValue = new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 18, milliseconds: 644),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 749626992,
                            Value = new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363),
                            NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)
                        }

                    }
                );

                expected.Add(
                    693579263,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 693579263,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 28, milliseconds: 499),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1417704363,
                            Value = new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    802255889,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 802255889,
                        Value = new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 3, milliseconds: 526),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    935254079,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 935254079,
                        Value = new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 27, milliseconds: 532),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1113679522,
                            Value = new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    948508310,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 948508310,
                        Value = new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 56, milliseconds: 525),
                        NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 42, milliseconds: 426),

                        ModelInner = null

                    }
                );

                expected.Add(
                    959425730,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 959425730,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 57, milliseconds: 17),
                        NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 0, milliseconds: 587),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 706063418,
                            Value = new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970),
                            NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)
                        }

                    }
                );

                expected.Add(
                    1006591252,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1006591252,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 38, milliseconds: 278),
                        NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 779),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1009039561,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1009039561,
                        Value = new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 21, milliseconds: 157),
                        NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 36, milliseconds: 949),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1007982353,
                            Value = new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893),
                            NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)
                        }

                    }
                );

                expected.Add(
                    1033900183,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1033900183,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 4, milliseconds: 980),
                        NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 1, milliseconds: 52),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 443190068,
                            Value = new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558),
                            NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)
                        }

                    }
                );

                expected.Add(
                    1123191003,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1123191003,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 26, milliseconds: 542),
                        NullableValue = null,

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1511076362,
                            Value = new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387),
                            NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)
                        }

                    }
                );

                expected.Add(
                    1331178779,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1331178779,
                        Value = new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 30, milliseconds: 727),
                        NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 47, milliseconds: 44),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1335731964,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1335731964,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 4, milliseconds: 647),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 17, milliseconds: 727),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 1979544116,
                            Value = new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636),
                            NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)
                        }

                    }
                );

                expected.Add(
                    1511038425,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1511038425,
                        Value = new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 20, milliseconds: 586),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1551372402,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1551372402,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 15, milliseconds: 367),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1807844390,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1807844390,
                        Value = new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 323),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1889583790,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1889583790,
                        Value = new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 5, milliseconds: 781),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1911167390,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1911167390,
                        Value = new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 13, milliseconds: 944),
                        NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 9, milliseconds: 137),

                        ModelInner = new TimeSpantime_without_time_zone0MI
                        {
                            Id = 88278930,
                            Value = new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388),
                            NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)
                        }

                    }
                );

                expected.Add(
                    1971937962,
                    new TimeSpantime_without_time_zone0M
                    {
                        Id = 1971937962,
                        Value = new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 13, milliseconds: 276),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                var models = await ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespantime_without_time_zone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(TimeSpantime_without_time_zone0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zone0MI>(15);

                expected.Add(
                    88278930,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 88278930,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388),
                        NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)
                    }
                );

                expected.Add(
                    443190068,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 443190068,
                        Value = new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558),
                        NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)
                    }
                );

                expected.Add(
                    588725715,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 588725715,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268),
                        NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)
                    }
                );

                expected.Add(
                    706063418,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 706063418,
                        Value = new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)
                    }
                );

                expected.Add(
                    749626992,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 749626992,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363),
                        NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)
                    }
                );

                expected.Add(
                    1007982353,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1007982353,
                        Value = new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893),
                        NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)
                    }
                );

                expected.Add(
                    1113679522,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1113679522,
                        Value = new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1417704363,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1417704363,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1429496256,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1429496256,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1481392852,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1481392852,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1511076362,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1511076362,
                        Value = new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)
                    }
                );

                expected.Add(
                    1590206218,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1590206218,
                        Value = new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292),
                        NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)
                    }
                );

                expected.Add(
                    1829179379,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1829179379,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1935592782,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1935592782,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1979544116,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1979544116,
                        Value = new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)
                    }
                );

                var models =  ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,TimeSpantime_without_time_zone0MI>(15);

                expected.Add(
                    88278930,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 88278930,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 13, milliseconds: 388),
                        NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 0, milliseconds: 908)
                    }
                );

                expected.Add(
                    443190068,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 443190068,
                        Value = new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 32, milliseconds: 558),
                        NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 101)
                    }
                );

                expected.Add(
                    588725715,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 588725715,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 268),
                        NullableValue = new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 10, milliseconds: 590)
                    }
                );

                expected.Add(
                    706063418,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 706063418,
                        Value = new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 24, milliseconds: 970),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 34, milliseconds: 605)
                    }
                );

                expected.Add(
                    749626992,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 749626992,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 42, milliseconds: 363),
                        NullableValue = new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 50, milliseconds: 740)
                    }
                );

                expected.Add(
                    1007982353,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1007982353,
                        Value = new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 27, milliseconds: 893),
                        NullableValue = new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 50, milliseconds: 863)
                    }
                );

                expected.Add(
                    1113679522,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1113679522,
                        Value = new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 19, milliseconds: 515),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1417704363,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1417704363,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 57, milliseconds: 904),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1429496256,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1429496256,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 23, milliseconds: 214),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1481392852,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1481392852,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 39, milliseconds: 244),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1511076362,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1511076362,
                        Value = new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 54, milliseconds: 387),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 57, milliseconds: 595)
                    }
                );

                expected.Add(
                    1590206218,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1590206218,
                        Value = new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 49, milliseconds: 292),
                        NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 5, milliseconds: 88)
                    }
                );

                expected.Add(
                    1829179379,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1829179379,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 266),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1935592782,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1935592782,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 322),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1979544116,
                    new TimeSpantime_without_time_zone0MI
                    {
                        Id = 1979544116,
                        Value = new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 636),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 12, milliseconds: 189)
                    }
                );

                var models = await ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        #endregion

    }
}


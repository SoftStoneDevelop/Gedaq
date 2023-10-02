

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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                )
            ]
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
            queryMapType: typeof(TimeSpaninterval0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
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

                changedRows =  ((ITimeSpanSingleTypeinterval)this).InsertModelInner(connection, 105777560, new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759), new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypeinterval)this).InsertModelInner(connection, 997038888, new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950), new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355));
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

                changedRows = await ((ITimeSpanSingleTypeinterval)this).InsertModelInnerAsync(connection, 1762879386, new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61), new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).InsertModelInnerAsync(connection, 854432511, new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875), null);
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

                id =  ((ITimeSpanSingleTypeinterval)this).InsertModelInnerReturning(connection, 1184100126, new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559), null);
                Assert.That(id, Is.EqualTo(1184100126));

                id =  ((ITimeSpanSingleTypeinterval)this).InsertModelInnerReturning(connection, 1941362541, new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212), new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22));
                Assert.That(id, Is.EqualTo(1941362541));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeSpanSingleTypeinterval)this).InsertModelInnerReturningAsync(connection, 338611577, new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599), null);
                Assert.That(id, Is.EqualTo(338611577));

                id = await ((ITimeSpanSingleTypeinterval)this).InsertModelInnerReturningAsync(connection, 683547007, new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406), new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733));
                Assert.That(id, Is.EqualTo(683547007));

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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                dbType: (System.Data.DbType)(13)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
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

                changedRows =  ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModel(connection, 2063658349, new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859), null);
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

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 243804389, new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 29033415, new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143), new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 140717512, new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158), new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 1658325509, new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 1735999266, new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 1121703671, new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662), new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838));
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespaninterval0mi_id", 
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

                changedRows =  ((ITimeSpanSingleTypeinterval)this).InsertModel(connection, 320746785, new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545), new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypeinterval)this).InsertModel(connection, 948550347, new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355), new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605), 105777560);
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

                changedRows = await ((ITimeSpanSingleTypeinterval)this).InsertModelAsync(connection, 1704505215, new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983), new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).InsertModelAsync(connection, 506134771, new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129), null, 997038888);
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

                nullable =  ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturning(connection, 59204384, new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75), new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873)));

                nullable =  ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturning(connection, 1036133703, new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919), null, 1762879386);

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

                nullable = await ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturningAsync(connection, 716985524, new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817), null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((ITimeSpanSingleTypeinterval)this).ScalarInsertModelReturningAsync(connection, 1943939411, new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592), new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73), 854432511);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

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
            queryMapType: typeof(TimeSpaninterval0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespaninterval0mi_id", 
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
                List<TimeSpaninterval0M> models = null;
                TimeSpaninterval0M model = null;

                models =  ((ITimeSpanSingleTypeinterval)this).InsertModelReturning(connection, 1839877064, new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360), new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeSpanSingleTypeinterval)this).InsertModelReturning(connection, 966028068, new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422), new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807), 1184100126).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeSpanSingleTypeinterval)this).InsertModelReturning(connection, 722533464, new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159), new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722533464));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeSpanSingleTypeinterval)this).InsertModelReturning(connection, 1762991864, new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92), new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335), 1941362541).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

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
                List<TimeSpaninterval0M> models = null;
                TimeSpaninterval0M model = null;

                models = await ((ITimeSpanSingleTypeinterval)this).InsertModelReturningAsync(connection, 2015170481, new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanSingleTypeinterval)this).InsertModelReturningAsync(connection, 1051749573, new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813), null, 338611577).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051749573));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(338611577));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanSingleTypeinterval)this).InsertModelReturningAsync(connection, 1330764195, new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86), new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330764195));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeSpanSingleTypeinterval)this).InsertModelReturningAsync(connection, 2098915202, new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106), null, 683547007).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeSpan)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
            queryMapType: null,
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
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespaninterval0mi_id", 
                methodParametrName: "timespaninterval0mi_id", 
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

                changedRows =  ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModel(connection, 90746014, new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131), new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModel(connection, 843765298, new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97), new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92), 2063658349);
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

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 2077326133, new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 526103303, new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684), null, 243804389);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 527178809, new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78), new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1002077238, new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486), new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63), 29033415);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1331790903, new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 763374698, new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229), null, 140717512);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1192351683, new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 266077367, new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689), new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868), 1658325509);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1407844698, new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466), new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1309435306, new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109), new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978), 1735999266);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1461388307, new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623), new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 474917235, new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403), new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932), 1121703671);
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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeSpaninterval0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                var models =  ((ITimeSpanSingleTypeinterval)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59204384));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90746014));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266077367));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658325509));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320746785));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(474917235));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121703671));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506134771));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(997038888));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526103303));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243804389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527178809));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(716985524));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722533464));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(763374698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(140717512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(843765298));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2063658349));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948550347));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(105777560));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002077238));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(29033415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036133703));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762879386));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051749573));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(338611577));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192351683));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309435306));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1735999266));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330764195));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331790903));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407844698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1461388307));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704505215));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59204384));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90746014));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266077367));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658325509));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320746785));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(474917235));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121703671));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506134771));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(997038888));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526103303));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243804389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527178809));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(716985524));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722533464));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(763374698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(140717512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(843765298));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2063658349));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948550347));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(105777560));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002077238));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(29033415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036133703));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762879386));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051749573));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(338611577));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192351683));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309435306));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1735999266));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330764195));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331790903));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407844698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1461388307));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704505215));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

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
            queryMapType: typeof(TimeSpaninterval0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59204384));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90746014));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266077367));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658325509));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320746785));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(474917235));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121703671));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506134771));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(997038888));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526103303));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243804389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527178809));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(716985524));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722533464));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(763374698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(140717512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(843765298));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2063658349));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948550347));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(105777560));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002077238));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(29033415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036133703));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762879386));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051749573));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(338611577));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192351683));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309435306));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1735999266));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330764195));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331790903));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407844698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1461388307));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704505215));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59204384));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90746014));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266077367));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658325509));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320746785));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(474917235));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121703671));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506134771));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(997038888));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526103303));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243804389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527178809));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(716985524));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722533464));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(763374698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(140717512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(843765298));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2063658349));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948550347));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(105777560));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002077238));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(29033415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036133703));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762879386));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051749573));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(338611577));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192351683));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309435306));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1735999266));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330764195));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331790903));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407844698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1461388307));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704505215));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypeinterval)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 1407844698);
                var models =  ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(8));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1461388307));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704505215));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeSpanSingleTypeinterval)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 1762991864);
                var models = await ((ITimeSpanSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(5));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                 foreach(var batchResult in ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelBatch(connection, 526103303, 1943939411))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(23));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527178809));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(716985524));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722533464));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(763374698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(140717512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(843765298));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2063658349));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948550347));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(105777560));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002077238));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(29033415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036133703));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762879386));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051749573));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(338611577));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192351683));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309435306));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1735999266));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330764195));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331790903));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407844698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1461388307));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704505215));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(3));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

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
                await foreach(var batchResult in ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelBatchAsync(connection, 843765298, 1839877064))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(18));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948550347));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(105777560));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002077238));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(29033415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036133703));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762879386));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051749573));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(338611577));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192351683));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309435306));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1735999266));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330764195));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331790903));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407844698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1461388307));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704505215));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

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
FROM public.timespaninterval0m m
LEFT JOIN public.timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
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
            asPartInterface: typeof(ITimeSpanSingleTypeinterval)
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
                var models =  ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59204384)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90746014)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((266077367)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1658325509)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((320746785)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((474917235)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1121703671)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((506134771)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((997038888)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((526103303)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((243804389)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((527178809)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((716985524)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((722533464)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((763374698)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((140717512)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((843765298)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2063658349)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((948550347)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((105777560)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((966028068)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1184100126)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1002077238)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29033415)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1036133703)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1762879386)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1051749573)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((338611577)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1192351683)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1309435306)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1735999266)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1330764195)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1331790903)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1407844698)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1461388307)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1704505215)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1762991864)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1941362541)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1839877064)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1943939411)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((854432511)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2015170481)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2077326133)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2098915202)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((683547007)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanSingleTypeinterval)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59204384)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90746014)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((266077367)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1658325509)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((320746785)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((474917235)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1121703671)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((506134771)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((997038888)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((526103303)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((243804389)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((527178809)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((716985524)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((722533464)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((763374698)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((140717512)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((843765298)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2063658349)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((948550347)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((105777560)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((966028068)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1184100126)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1002077238)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29033415)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1036133703)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1762879386)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1051749573)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((338611577)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1192351683)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1309435306)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1735999266)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1330764195)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1331790903)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1407844698)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1461388307)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1704505215)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1762991864)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1941362541)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1839877064)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1943939411)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((854432511)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2015170481)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2077326133)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2098915202)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((683547007)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733))));//InnerModel.NullableValue

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
FROM public.binary_timespaninterval0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeSpaninterval0MI),
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

                var importCollection = new List<TimeSpaninterval0MI>(7);

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 29033415,
                    Value = new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143),
                    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 105777560,
                    Value = new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759),
                    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 140717512,
                    Value = new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158),
                    NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 243804389,
                    Value = new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 338611577,
                    Value = new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 683547007,
                    Value = new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406),
                    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 854432511,
                    Value = new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875),
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29033415));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(105777560));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140717512));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(243804389));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338611577));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683547007));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(854432511));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 997038888,
                    Value = new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950),
                    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 1121703671,
                    Value = new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662),
                    NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 1184100126,
                    Value = new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 1658325509,
                    Value = new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 1735999266,
                    Value = new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 1762879386,
                    Value = new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61),
                    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 1941362541,
                    Value = new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212),
                    NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)
                });

                importCollection.Add(
                new TimeSpaninterval0MI
                {
                    Id = 2063658349,
                    Value = new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859),
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29033415));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(105777560));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140717512));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(243804389));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338611577));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683547007));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(854432511));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(997038888));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1121703671));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1184100126));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1658325509));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735999266));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762879386));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1941362541));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2063658349));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859)));

                Assert.That(model.NullableValue, Is.Null);


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
FROM public.binary_timespaninterval0m m
LEFT JOIN public.binary_timespaninterval0mi mi ON mi.id = m.timespaninterval0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeSpaninterval0M),
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

                var importCollection = new List<TimeSpaninterval0M>(15);

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 59204384,
                    Value = new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75),
                    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 90746014,
                    Value = new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131),
                    NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 266077367,
                    Value = new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689),
                    NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 1658325509
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 320746785,
                    Value = new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545),
                    NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 474917235,
                    Value = new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403),
                    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 1121703671
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 506134771,
                    Value = new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129),
                    NullableValue = null,

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 997038888
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 526103303,
                    Value = new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684),
                    NullableValue = null,

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 243804389
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 527178809,
                    Value = new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78),
                    NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 716985524,
                    Value = new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 722533464,
                    Value = new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159),
                    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 763374698,
                    Value = new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229),
                    NullableValue = null,

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 140717512
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 843765298,
                    Value = new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97),
                    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 2063658349
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 948550347,
                    Value = new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355),
                    NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 105777560
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 966028068,
                    Value = new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422),
                    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 1184100126
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1002077238,
                    Value = new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486),
                    NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 29033415
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59204384));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90746014));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266077367));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658325509));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320746785));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(474917235));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121703671));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506134771));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(997038888));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526103303));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243804389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527178809));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(716985524));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722533464));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(763374698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(140717512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(843765298));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2063658349));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948550347));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(105777560));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002077238));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(29033415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));

                importCollection.Clear();

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1036133703,
                    Value = new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919),
                    NullableValue = null,

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 1762879386
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1051749573,
                    Value = new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813),
                    NullableValue = null,

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 338611577
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1192351683,
                    Value = new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1309435306,
                    Value = new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109),
                    NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 1735999266
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1330764195,
                    Value = new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86),
                    NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1331790903,
                    Value = new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1407844698,
                    Value = new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466),
                    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1461388307,
                    Value = new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623),
                    NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1704505215,
                    Value = new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983),
                    NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1762991864,
                    Value = new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92),
                    NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 1941362541
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1839877064,
                    Value = new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360),
                    NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 1943939411,
                    Value = new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592),
                    NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73),

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 854432511
                    }

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 2015170481,
                    Value = new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 2077326133,
                    Value = new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpaninterval0M
                {
                    Id = 2098915202,
                    Value = new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106),
                    NullableValue = null,

                    ModelInner = new TimeSpaninterval0MI 
                    {
                        Id = 683547007
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59204384));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90746014));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266077367));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658325509));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320746785));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(474917235));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121703671));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(506134771));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(997038888));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(526103303));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243804389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527178809));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(716985524));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722533464));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(763374698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(140717512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(843765298));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2063658349));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948550347));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(105777560));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966028068));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1184100126));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002077238));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(29033415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)));


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036133703));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762879386));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)));


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051749573));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(338611577));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192351683));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309435306));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1735999266));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330764195));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331790903));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407844698));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1461388307));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704505215));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762991864));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941362541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)));


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1839877064));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943939411));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(854432511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015170481));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2077326133));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098915202));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(683547007));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)));


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

                var expected = new Dictionary<System.Int32,TimeSpaninterval0M>(30);

                expected.Add(
                    59204384,
                    new TimeSpaninterval0M
                    {
                        Id = 59204384,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75),
                        NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873),

                        ModelInner = null

                    }
                );

                expected.Add(
                    90746014,
                    new TimeSpaninterval0M
                    {
                        Id = 90746014,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131),
                        NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459),

                        ModelInner = null

                    }
                );

                expected.Add(
                    266077367,
                    new TimeSpaninterval0M
                    {
                        Id = 266077367,
                        Value = new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689),
                        NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1658325509,
                            Value = new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    320746785,
                    new TimeSpaninterval0M
                    {
                        Id = 320746785,
                        Value = new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545),
                        NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198),

                        ModelInner = null

                    }
                );

                expected.Add(
                    474917235,
                    new TimeSpaninterval0M
                    {
                        Id = 474917235,
                        Value = new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403),
                        NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1121703671,
                            Value = new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662),
                            NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)
                        }

                    }
                );

                expected.Add(
                    506134771,
                    new TimeSpaninterval0M
                    {
                        Id = 506134771,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 997038888,
                            Value = new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950),
                            NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)
                        }

                    }
                );

                expected.Add(
                    526103303,
                    new TimeSpaninterval0M
                    {
                        Id = 526103303,
                        Value = new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 243804389,
                            Value = new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    527178809,
                    new TimeSpaninterval0M
                    {
                        Id = 527178809,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78),
                        NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688),

                        ModelInner = null

                    }
                );

                expected.Add(
                    716985524,
                    new TimeSpaninterval0M
                    {
                        Id = 716985524,
                        Value = new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    722533464,
                    new TimeSpaninterval0M
                    {
                        Id = 722533464,
                        Value = new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159),
                        NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605),

                        ModelInner = null

                    }
                );

                expected.Add(
                    763374698,
                    new TimeSpaninterval0M
                    {
                        Id = 763374698,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 140717512,
                            Value = new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158),
                            NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)
                        }

                    }
                );

                expected.Add(
                    843765298,
                    new TimeSpaninterval0M
                    {
                        Id = 843765298,
                        Value = new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97),
                        NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 2063658349,
                            Value = new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    948550347,
                    new TimeSpaninterval0M
                    {
                        Id = 948550347,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355),
                        NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 105777560,
                            Value = new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759),
                            NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)
                        }

                    }
                );

                expected.Add(
                    966028068,
                    new TimeSpaninterval0M
                    {
                        Id = 966028068,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422),
                        NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1184100126,
                            Value = new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1002077238,
                    new TimeSpaninterval0M
                    {
                        Id = 1002077238,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486),
                        NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 29033415,
                            Value = new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143),
                            NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)
                        }

                    }
                );

                expected.Add(
                    1036133703,
                    new TimeSpaninterval0M
                    {
                        Id = 1036133703,
                        Value = new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1762879386,
                            Value = new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61),
                            NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)
                        }

                    }
                );

                expected.Add(
                    1051749573,
                    new TimeSpaninterval0M
                    {
                        Id = 1051749573,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 338611577,
                            Value = new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1192351683,
                    new TimeSpaninterval0M
                    {
                        Id = 1192351683,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1309435306,
                    new TimeSpaninterval0M
                    {
                        Id = 1309435306,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109),
                        NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1735999266,
                            Value = new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1330764195,
                    new TimeSpaninterval0M
                    {
                        Id = 1330764195,
                        Value = new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86),
                        NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1331790903,
                    new TimeSpaninterval0M
                    {
                        Id = 1331790903,
                        Value = new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1407844698,
                    new TimeSpaninterval0M
                    {
                        Id = 1407844698,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466),
                        NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1461388307,
                    new TimeSpaninterval0M
                    {
                        Id = 1461388307,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623),
                        NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1704505215,
                    new TimeSpaninterval0M
                    {
                        Id = 1704505215,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983),
                        NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1762991864,
                    new TimeSpaninterval0M
                    {
                        Id = 1762991864,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92),
                        NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1941362541,
                            Value = new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212),
                            NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)
                        }

                    }
                );

                expected.Add(
                    1839877064,
                    new TimeSpaninterval0M
                    {
                        Id = 1839877064,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1943939411,
                    new TimeSpaninterval0M
                    {
                        Id = 1943939411,
                        Value = new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592),
                        NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 854432511,
                            Value = new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2015170481,
                    new TimeSpaninterval0M
                    {
                        Id = 2015170481,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2077326133,
                    new TimeSpaninterval0M
                    {
                        Id = 2077326133,
                        Value = new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2098915202,
                    new TimeSpaninterval0M
                    {
                        Id = 2098915202,
                        Value = new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 683547007,
                            Value = new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406),
                            NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)
                        }

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

                var expected = new Dictionary<System.Int32,TimeSpaninterval0M>(30);

                expected.Add(
                    59204384,
                    new TimeSpaninterval0M
                    {
                        Id = 59204384,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 29, milliseconds: 75),
                        NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 42, milliseconds: 873),

                        ModelInner = null

                    }
                );

                expected.Add(
                    90746014,
                    new TimeSpaninterval0M
                    {
                        Id = 90746014,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 131),
                        NullableValue = new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 50, milliseconds: 459),

                        ModelInner = null

                    }
                );

                expected.Add(
                    266077367,
                    new TimeSpaninterval0M
                    {
                        Id = 266077367,
                        Value = new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 35, milliseconds: 689),
                        NullableValue = new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 11, milliseconds: 868),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1658325509,
                            Value = new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    320746785,
                    new TimeSpaninterval0M
                    {
                        Id = 320746785,
                        Value = new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 26, milliseconds: 545),
                        NullableValue = new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 21, milliseconds: 198),

                        ModelInner = null

                    }
                );

                expected.Add(
                    474917235,
                    new TimeSpaninterval0M
                    {
                        Id = 474917235,
                        Value = new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 57, milliseconds: 403),
                        NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 932),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1121703671,
                            Value = new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662),
                            NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)
                        }

                    }
                );

                expected.Add(
                    506134771,
                    new TimeSpaninterval0M
                    {
                        Id = 506134771,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 43, milliseconds: 129),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 997038888,
                            Value = new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950),
                            NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)
                        }

                    }
                );

                expected.Add(
                    526103303,
                    new TimeSpaninterval0M
                    {
                        Id = 526103303,
                        Value = new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 35, milliseconds: 684),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 243804389,
                            Value = new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    527178809,
                    new TimeSpaninterval0M
                    {
                        Id = 527178809,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 24, milliseconds: 78),
                        NullableValue = new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 23, milliseconds: 688),

                        ModelInner = null

                    }
                );

                expected.Add(
                    716985524,
                    new TimeSpaninterval0M
                    {
                        Id = 716985524,
                        Value = new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 20, milliseconds: 817),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    722533464,
                    new TimeSpaninterval0M
                    {
                        Id = 722533464,
                        Value = new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 40, milliseconds: 159),
                        NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 605),

                        ModelInner = null

                    }
                );

                expected.Add(
                    763374698,
                    new TimeSpaninterval0M
                    {
                        Id = 763374698,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 35, milliseconds: 229),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 140717512,
                            Value = new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158),
                            NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)
                        }

                    }
                );

                expected.Add(
                    843765298,
                    new TimeSpaninterval0M
                    {
                        Id = 843765298,
                        Value = new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 51, milliseconds: 97),
                        NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 16, milliseconds: 92),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 2063658349,
                            Value = new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    948550347,
                    new TimeSpaninterval0M
                    {
                        Id = 948550347,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 24, milliseconds: 355),
                        NullableValue = new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 53, milliseconds: 605),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 105777560,
                            Value = new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759),
                            NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)
                        }

                    }
                );

                expected.Add(
                    966028068,
                    new TimeSpaninterval0M
                    {
                        Id = 966028068,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 33, milliseconds: 422),
                        NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 33, milliseconds: 807),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1184100126,
                            Value = new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1002077238,
                    new TimeSpaninterval0M
                    {
                        Id = 1002077238,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 39, milliseconds: 486),
                        NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 40, milliseconds: 63),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 29033415,
                            Value = new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143),
                            NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)
                        }

                    }
                );

                expected.Add(
                    1036133703,
                    new TimeSpaninterval0M
                    {
                        Id = 1036133703,
                        Value = new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 919),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1762879386,
                            Value = new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61),
                            NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)
                        }

                    }
                );

                expected.Add(
                    1051749573,
                    new TimeSpaninterval0M
                    {
                        Id = 1051749573,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 41, milliseconds: 813),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 338611577,
                            Value = new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1192351683,
                    new TimeSpaninterval0M
                    {
                        Id = 1192351683,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 52, milliseconds: 417),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1309435306,
                    new TimeSpaninterval0M
                    {
                        Id = 1309435306,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 19, milliseconds: 109),
                        NullableValue = new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 33, milliseconds: 978),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1735999266,
                            Value = new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1330764195,
                    new TimeSpaninterval0M
                    {
                        Id = 1330764195,
                        Value = new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 34, milliseconds: 86),
                        NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 7, milliseconds: 52),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1331790903,
                    new TimeSpaninterval0M
                    {
                        Id = 1331790903,
                        Value = new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 58, milliseconds: 61),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1407844698,
                    new TimeSpaninterval0M
                    {
                        Id = 1407844698,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 51, milliseconds: 466),
                        NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 32, milliseconds: 465),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1461388307,
                    new TimeSpaninterval0M
                    {
                        Id = 1461388307,
                        Value = new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 6, milliseconds: 623),
                        NullableValue = new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 52, milliseconds: 224),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1704505215,
                    new TimeSpaninterval0M
                    {
                        Id = 1704505215,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 41, milliseconds: 983),
                        NullableValue = new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 50, milliseconds: 591),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1762991864,
                    new TimeSpaninterval0M
                    {
                        Id = 1762991864,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 92),
                        NullableValue = new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 31, milliseconds: 335),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 1941362541,
                            Value = new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212),
                            NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)
                        }

                    }
                );

                expected.Add(
                    1839877064,
                    new TimeSpaninterval0M
                    {
                        Id = 1839877064,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 15, milliseconds: 360),
                        NullableValue = new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 34, milliseconds: 933),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1943939411,
                    new TimeSpaninterval0M
                    {
                        Id = 1943939411,
                        Value = new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 12, milliseconds: 592),
                        NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 73),

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 854432511,
                            Value = new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2015170481,
                    new TimeSpaninterval0M
                    {
                        Id = 2015170481,
                        Value = new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 37, milliseconds: 51),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2077326133,
                    new TimeSpaninterval0M
                    {
                        Id = 2077326133,
                        Value = new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 22, milliseconds: 815),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2098915202,
                    new TimeSpaninterval0M
                    {
                        Id = 2098915202,
                        Value = new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 54, milliseconds: 106),
                        NullableValue = null,

                        ModelInner = new TimeSpaninterval0MI
                        {
                            Id = 683547007,
                            Value = new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406),
                            NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)
                        }

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
COPY public.binary_timespaninterval0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
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

                var expected = new Dictionary<System.Int32,TimeSpaninterval0MI>(15);

                expected.Add(
                    29033415,
                    new TimeSpaninterval0MI
                    {
                        Id = 29033415,
                        Value = new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143),
                        NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)
                    }
                );

                expected.Add(
                    105777560,
                    new TimeSpaninterval0MI
                    {
                        Id = 105777560,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759),
                        NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)
                    }
                );

                expected.Add(
                    140717512,
                    new TimeSpaninterval0MI
                    {
                        Id = 140717512,
                        Value = new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158),
                        NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)
                    }
                );

                expected.Add(
                    243804389,
                    new TimeSpaninterval0MI
                    {
                        Id = 243804389,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264),
                        NullableValue = null
                    }
                );

                expected.Add(
                    338611577,
                    new TimeSpaninterval0MI
                    {
                        Id = 338611577,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599),
                        NullableValue = null
                    }
                );

                expected.Add(
                    683547007,
                    new TimeSpaninterval0MI
                    {
                        Id = 683547007,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406),
                        NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)
                    }
                );

                expected.Add(
                    854432511,
                    new TimeSpaninterval0MI
                    {
                        Id = 854432511,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875),
                        NullableValue = null
                    }
                );

                expected.Add(
                    997038888,
                    new TimeSpaninterval0MI
                    {
                        Id = 997038888,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950),
                        NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)
                    }
                );

                expected.Add(
                    1121703671,
                    new TimeSpaninterval0MI
                    {
                        Id = 1121703671,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662),
                        NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)
                    }
                );

                expected.Add(
                    1184100126,
                    new TimeSpaninterval0MI
                    {
                        Id = 1184100126,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1658325509,
                    new TimeSpaninterval0MI
                    {
                        Id = 1658325509,
                        Value = new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1735999266,
                    new TimeSpaninterval0MI
                    {
                        Id = 1735999266,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1762879386,
                    new TimeSpaninterval0MI
                    {
                        Id = 1762879386,
                        Value = new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61),
                        NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)
                    }
                );

                expected.Add(
                    1941362541,
                    new TimeSpaninterval0MI
                    {
                        Id = 1941362541,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212),
                        NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)
                    }
                );

                expected.Add(
                    2063658349,
                    new TimeSpaninterval0MI
                    {
                        Id = 2063658349,
                        Value = new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859),
                        NullableValue = null
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

                var expected = new Dictionary<System.Int32,TimeSpaninterval0MI>(15);

                expected.Add(
                    29033415,
                    new TimeSpaninterval0MI
                    {
                        Id = 29033415,
                        Value = new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 8, milliseconds: 143),
                        NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 13, milliseconds: 138)
                    }
                );

                expected.Add(
                    105777560,
                    new TimeSpaninterval0MI
                    {
                        Id = 105777560,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 33, milliseconds: 759),
                        NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 7, milliseconds: 968)
                    }
                );

                expected.Add(
                    140717512,
                    new TimeSpaninterval0MI
                    {
                        Id = 140717512,
                        Value = new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 58, milliseconds: 158),
                        NullableValue = new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 0, milliseconds: 890)
                    }
                );

                expected.Add(
                    243804389,
                    new TimeSpaninterval0MI
                    {
                        Id = 243804389,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 26, milliseconds: 264),
                        NullableValue = null
                    }
                );

                expected.Add(
                    338611577,
                    new TimeSpaninterval0MI
                    {
                        Id = 338611577,
                        Value = new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 3, milliseconds: 599),
                        NullableValue = null
                    }
                );

                expected.Add(
                    683547007,
                    new TimeSpaninterval0MI
                    {
                        Id = 683547007,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 24, milliseconds: 406),
                        NullableValue = new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 733)
                    }
                );

                expected.Add(
                    854432511,
                    new TimeSpaninterval0MI
                    {
                        Id = 854432511,
                        Value = new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 26, milliseconds: 875),
                        NullableValue = null
                    }
                );

                expected.Add(
                    997038888,
                    new TimeSpaninterval0MI
                    {
                        Id = 997038888,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 950),
                        NullableValue = new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 51, milliseconds: 355)
                    }
                );

                expected.Add(
                    1121703671,
                    new TimeSpaninterval0MI
                    {
                        Id = 1121703671,
                        Value = new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 58, milliseconds: 662),
                        NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 47, milliseconds: 838)
                    }
                );

                expected.Add(
                    1184100126,
                    new TimeSpaninterval0MI
                    {
                        Id = 1184100126,
                        Value = new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 25, milliseconds: 559),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1658325509,
                    new TimeSpaninterval0MI
                    {
                        Id = 1658325509,
                        Value = new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 344),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1735999266,
                    new TimeSpaninterval0MI
                    {
                        Id = 1735999266,
                        Value = new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 8, milliseconds: 801),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1762879386,
                    new TimeSpaninterval0MI
                    {
                        Id = 1762879386,
                        Value = new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 22, milliseconds: 61),
                        NullableValue = new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 21, milliseconds: 462)
                    }
                );

                expected.Add(
                    1941362541,
                    new TimeSpaninterval0MI
                    {
                        Id = 1941362541,
                        Value = new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 212),
                        NullableValue = new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 52, milliseconds: 22)
                    }
                );

                expected.Add(
                    2063658349,
                    new TimeSpaninterval0MI
                    {
                        Id = 2063658349,
                        Value = new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 21, milliseconds: 859),
                        NullableValue = null
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


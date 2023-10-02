

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
    internal partial interface ITimeOnlySingleTypetime_without_time_zone
    {
    }
    
    internal partial class TimeOnlySingleTypetime_without_time_zone : ITimeOnlySingleTypetime_without_time_zone
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0mi(
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
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
INSERT INTO public.timeonlytime_without_time_zone0mi(
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
            queryMapType: typeof(TimeOnlytime_without_time_zone0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
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

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInner(connection, 66883165, new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInner(connection, 1283875881, new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670), new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600));
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

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerAsync(connection, 596770787, new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerAsync(connection, 284926655, new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182), null);
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

                id =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerReturning(connection, 1278825437, new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830), new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877));
                Assert.That(id, Is.EqualTo(1278825437));

                id =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerReturning(connection, 1981295070, new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907), new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355));
                Assert.That(id, Is.EqualTo(1981295070));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerReturningAsync(connection, 936661240, new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827), null);
                Assert.That(id, Is.EqualTo(936661240));

                id = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerReturningAsync(connection, 1352881684, new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663), new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82));
                Assert.That(id, Is.EqualTo(1352881684));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0mi(
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(17)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
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

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModel(connection, 746735517, new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329), null);
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

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 489455896, new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 215929643, new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111), new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 630725644, new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 881817271, new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774), new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1838840105, new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 2031022551, new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zone0mi_id
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zone0mi_id", 
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

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModel(connection, 1739177658, new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815), new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModel(connection, 1231433845, new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886), null, 66883165);
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

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelAsync(connection, 48129578, new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639), new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelAsync(connection, 1886032192, new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583), new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610), 1283875881);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zone0mi_id
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
    timeonlytime_without_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(TimeOnlytime_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zone0mi_id", 
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
                List<TimeOnlytime_without_time_zone0M> models = null;
                TimeOnlytime_without_time_zone0M model = null;

                models =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturning(connection, 945069282, new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(945069282));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturning(connection, 2067484912, new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577), new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718), 596770787).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturning(connection, 636539084, new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(636539084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturning(connection, 1263548211, new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175), null, 284926655).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zone0M> models = null;
                TimeOnlytime_without_time_zone0M model = null;

                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, 904958640, new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915), new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904958640));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, 1645965019, new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375), new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769), 1278825437).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, 880400107, new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528), new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880400107));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, 1251787174, new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775), new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437), 1981295070).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251787174));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1981295070));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timeonlytime_without_time_zone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.TimeOnly), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(17)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timeonlytime_without_time_zone0mi_id", 
                methodParametrName: "timeonlytime_without_time_zone0mi_id", 
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

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModel(connection, 1374838988, new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModel(connection, 1047201916, new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701), null, 936661240);
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

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1588648474, new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 516196781, new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684), null, 1352881684);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 179831742, new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804), new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1545701143, new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179), null, 746735517);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1408036836, new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842), new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1034847259, new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763), null, 489455896);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1479129084, new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 788973308, new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384), null, 215929643);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1797468720, new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 745384691, new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584), null, 630725644);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 256886448, new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259), new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1112098363, new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19), null, 881817271);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 327656636, new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619), new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 3692998, new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403), null, 1838840105);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1405320056, new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, 253467142, new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716), null, 2031022551);
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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeOnlytime_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
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
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3692998));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1838840105));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48129578));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(179831742));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253467142));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031022551));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(256886448));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(327656636));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516196781));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1352881684));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(636539084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745384691));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(630725644));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788973308));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(215929643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880400107));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904958640));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(945069282));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1034847259));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489455896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047201916));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(936661240));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112098363));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881817271));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1231433845));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66883165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251787174));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1981295070));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374838988));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1405320056));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1408036836));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1479129084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3692998));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1838840105));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48129578));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(179831742));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253467142));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031022551));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(256886448));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(327656636));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516196781));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1352881684));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(636539084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745384691));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(630725644));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788973308));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(215929643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880400107));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904958640));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(945069282));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1034847259));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489455896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047201916));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(936661240));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112098363));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881817271));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1231433845));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66883165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251787174));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1981295070));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374838988));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1405320056));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1408036836));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1479129084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeOnlytime_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
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
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3692998));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1838840105));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48129578));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(179831742));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253467142));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031022551));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(256886448));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(327656636));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516196781));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1352881684));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(636539084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745384691));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(630725644));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788973308));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(215929643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880400107));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904958640));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(945069282));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1034847259));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489455896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047201916));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(936661240));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112098363));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881817271));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1231433845));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66883165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251787174));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1981295070));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374838988));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1405320056));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1408036836));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1479129084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3692998));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1838840105));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48129578));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(179831742));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253467142));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031022551));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(256886448));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(327656636));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516196781));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1352881684));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(636539084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745384691));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(630725644));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788973308));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(215929643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880400107));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904958640));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(945069282));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1034847259));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489455896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047201916));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(936661240));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112098363));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881817271));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1231433845));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66883165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251787174));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1981295070));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374838988));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1405320056));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1408036836));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1479129084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlySingleTypetime_without_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlySingleTypetime_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 1251787174);
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(12));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374838988));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1405320056));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1408036836));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1479129084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeOnlySingleTypetime_without_time_zone)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlySingleTypetime_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 1645965019);
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(4));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
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
                 foreach(var batchResult in ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelBatch(connection, 1479129084, 788973308))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880400107));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904958640));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(945069282));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1034847259));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489455896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047201916));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(936661240));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112098363));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881817271));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1231433845));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66883165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251787174));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1981295070));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374838988));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1405320056));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1408036836));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1479129084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
                await foreach(var batchResult in ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelBatchAsync(connection, 1479129084, 1034847259))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047201916));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(936661240));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112098363));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881817271));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1231433845));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66883165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251787174));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1981295070));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374838988));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1405320056));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1408036836));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1479129084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
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
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3692998)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1838840105)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48129578)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475)).ToTimeSpan()));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179831742)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733)).ToTimeSpan()));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((253467142)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2031022551)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((256886448)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809)).ToTimeSpan()));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((327656636)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944)).ToTimeSpan()));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((516196781)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1352881684)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((636539084)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((745384691)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((630725644)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((788973308)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((215929643)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((880400107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)).ToTimeSpan()));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((904958640)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)).ToTimeSpan()));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((945069282)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1034847259)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((489455896)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1047201916)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((936661240)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1112098363)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((881817271)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1231433845)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66883165)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1251787174)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1981295070)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)).ToTimeSpan()));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1263548211)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((284926655)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1374838988)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1405320056)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1408036836)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)).ToTimeSpan()));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1479129084)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1545701143)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((746735517)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1588648474)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1645965019)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1278825437)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)).ToTimeSpan()));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1739177658)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)).ToTimeSpan()));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1797468720)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1886032192)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1283875881)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)).ToTimeSpan()));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2067484912)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((596770787)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)).ToTimeSpan()));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3692998)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1838840105)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48129578)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475)).ToTimeSpan()));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179831742)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733)).ToTimeSpan()));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((253467142)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2031022551)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((256886448)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809)).ToTimeSpan()));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((327656636)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944)).ToTimeSpan()));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((516196781)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1352881684)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((636539084)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((745384691)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((630725644)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((788973308)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((215929643)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((880400107)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)).ToTimeSpan()));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((904958640)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)).ToTimeSpan()));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((945069282)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1034847259)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((489455896)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1047201916)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((936661240)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1112098363)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((881817271)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1231433845)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66883165)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1251787174)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1981295070)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)).ToTimeSpan()));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1263548211)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((284926655)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1374838988)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1405320056)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1408036836)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)).ToTimeSpan()));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1479129084)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1545701143)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((746735517)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1588648474)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1645965019)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1278825437)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)).ToTimeSpan()));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1739177658)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)).ToTimeSpan()));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1797468720)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)).ToTimeSpan()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1886032192)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1283875881)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)).ToTimeSpan()));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)).ToTimeSpan()));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)).ToTimeSpan()));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2067484912)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)).ToTimeSpan()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((596770787)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)).ToTimeSpan()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)).ToTimeSpan()));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zone0MI),
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
FROM public.binary_timeonlytime_without_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zone0MI),
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

                var importCollection = new List<TimeOnlytime_without_time_zone0MI>(7);

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 66883165,
                    Value = new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 215929643,
                    Value = new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111),
                    NullableValue = new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 284926655,
                    Value = new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 489455896,
                    Value = new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 596770787,
                    Value = new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 630725644,
                    Value = new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 746735517,
                    Value = new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329),
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66883165));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(215929643));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(284926655));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489455896));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596770787));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630725644));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(746735517));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 881817271,
                    Value = new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774),
                    NullableValue = new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 936661240,
                    Value = new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 1278825437,
                    Value = new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830),
                    NullableValue = new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 1283875881,
                    Value = new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670),
                    NullableValue = new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 1352881684,
                    Value = new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663),
                    NullableValue = new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 1838840105,
                    Value = new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393),
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 1981295070,
                    Value = new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907),
                    NullableValue = new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0MI
                {
                    Id = 2031022551,
                    Value = new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193),
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66883165));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(215929643));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(284926655));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489455896));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596770787));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630725644));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(746735517));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(881817271));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(936661240));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278825437));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1283875881));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1352881684));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1838840105));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981295070));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2031022551));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)));

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zone0M),
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
FROM public.binary_timeonlytime_without_time_zone0m m
LEFT JOIN public.binary_timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zone0M),
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

                var importCollection = new List<TimeOnlytime_without_time_zone0M>(15);

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 3692998,
                    Value = new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 1838840105
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 48129578,
                    Value = new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639),
                    NullableValue = new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 179831742,
                    Value = new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804),
                    NullableValue = new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 253467142,
                    Value = new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 2031022551
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 256886448,
                    Value = new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259),
                    NullableValue = new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 327656636,
                    Value = new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619),
                    NullableValue = new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 516196781,
                    Value = new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 1352881684
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 636539084,
                    Value = new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 745384691,
                    Value = new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 630725644
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 788973308,
                    Value = new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 215929643
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 880400107,
                    Value = new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528),
                    NullableValue = new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 904958640,
                    Value = new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915),
                    NullableValue = new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 945069282,
                    Value = new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1034847259,
                    Value = new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 489455896
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1047201916,
                    Value = new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 936661240
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3692998));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1838840105));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48129578));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(179831742));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253467142));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031022551));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(256886448));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(327656636));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516196781));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1352881684));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(636539084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745384691));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(630725644));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788973308));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(215929643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880400107));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904958640));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(945069282));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1034847259));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489455896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047201916));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(936661240));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1112098363,
                    Value = new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 881817271
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1231433845,
                    Value = new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 66883165
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1251787174,
                    Value = new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775),
                    NullableValue = new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437),

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 1981295070
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1263548211,
                    Value = new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 284926655
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1374838988,
                    Value = new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1405320056,
                    Value = new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1408036836,
                    Value = new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842),
                    NullableValue = new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1479129084,
                    Value = new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1545701143,
                    Value = new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179),
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 746735517
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1588648474,
                    Value = new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1645965019,
                    Value = new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375),
                    NullableValue = new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769),

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 1278825437
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1739177658,
                    Value = new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815),
                    NullableValue = new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741),

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1797468720,
                    Value = new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 1886032192,
                    Value = new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583),
                    NullableValue = new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610),

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 1283875881
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zone0M
                {
                    Id = 2067484912,
                    Value = new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577),
                    NullableValue = new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718),

                    ModelInner = new TimeOnlytime_without_time_zone0MI 
                    {
                        Id = 596770787
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3692998));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1838840105));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48129578));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(179831742));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253467142));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031022551));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(256886448));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(327656636));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516196781));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1352881684));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(636539084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745384691));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(630725644));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788973308));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(215929643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880400107));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904958640));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(945069282));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1034847259));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(489455896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047201916));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(936661240));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112098363));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881817271));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)));


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1231433845));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66883165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1251787174));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1981295070));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263548211));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284926655));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374838988));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1405320056));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1408036836));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1479129084));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1545701143));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746735517));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588648474));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645965019));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1278825437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)));


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1739177658));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1797468720));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886032192));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283875881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)));


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2067484912));
                Assert.That(model.Value, Is.EqualTo(new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(596770787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zone0M),
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zone0M>(30);

                expected.Add(
                    3692998,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 3692998,
                        Value = new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1838840105,
                            Value = new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    48129578,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 48129578,
                        Value = new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639),
                        NullableValue = new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475),

                        ModelInner = null

                    }
                );

                expected.Add(
                    179831742,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 179831742,
                        Value = new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804),
                        NullableValue = new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733),

                        ModelInner = null

                    }
                );

                expected.Add(
                    253467142,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 253467142,
                        Value = new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 2031022551,
                            Value = new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    256886448,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 256886448,
                        Value = new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259),
                        NullableValue = new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809),

                        ModelInner = null

                    }
                );

                expected.Add(
                    327656636,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 327656636,
                        Value = new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619),
                        NullableValue = new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944),

                        ModelInner = null

                    }
                );

                expected.Add(
                    516196781,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 516196781,
                        Value = new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1352881684,
                            Value = new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663),
                            NullableValue = new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)
                        }

                    }
                );

                expected.Add(
                    636539084,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 636539084,
                        Value = new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    745384691,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 745384691,
                        Value = new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 630725644,
                            Value = new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    788973308,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 788973308,
                        Value = new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 215929643,
                            Value = new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111),
                            NullableValue = new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)
                        }

                    }
                );

                expected.Add(
                    880400107,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 880400107,
                        Value = new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528),
                        NullableValue = new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943),

                        ModelInner = null

                    }
                );

                expected.Add(
                    904958640,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 904958640,
                        Value = new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915),
                        NullableValue = new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341),

                        ModelInner = null

                    }
                );

                expected.Add(
                    945069282,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 945069282,
                        Value = new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1034847259,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1034847259,
                        Value = new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 489455896,
                            Value = new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1047201916,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1047201916,
                        Value = new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 936661240,
                            Value = new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1112098363,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1112098363,
                        Value = new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 881817271,
                            Value = new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774),
                            NullableValue = new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)
                        }

                    }
                );

                expected.Add(
                    1231433845,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1231433845,
                        Value = new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 66883165,
                            Value = new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1251787174,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1251787174,
                        Value = new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775),
                        NullableValue = new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437),

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1981295070,
                            Value = new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907),
                            NullableValue = new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)
                        }

                    }
                );

                expected.Add(
                    1263548211,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1263548211,
                        Value = new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 284926655,
                            Value = new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1374838988,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1374838988,
                        Value = new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1405320056,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1405320056,
                        Value = new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1408036836,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1408036836,
                        Value = new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842),
                        NullableValue = new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1479129084,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1479129084,
                        Value = new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1545701143,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1545701143,
                        Value = new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 746735517,
                            Value = new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1588648474,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1588648474,
                        Value = new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1645965019,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1645965019,
                        Value = new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375),
                        NullableValue = new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769),

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1278825437,
                            Value = new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830),
                            NullableValue = new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)
                        }

                    }
                );

                expected.Add(
                    1739177658,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1739177658,
                        Value = new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815),
                        NullableValue = new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1797468720,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1797468720,
                        Value = new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1886032192,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1886032192,
                        Value = new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583),
                        NullableValue = new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610),

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1283875881,
                            Value = new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670),
                            NullableValue = new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)
                        }

                    }
                );

                expected.Add(
                    2067484912,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 2067484912,
                        Value = new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577),
                        NullableValue = new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718),

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 596770787,
                            Value = new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399),
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly)default));
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zone0M>(30);

                expected.Add(
                    3692998,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 3692998,
                        Value = new TimeOnly(hour: 6, minute: 9, second: 50, millisecond: 403),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1838840105,
                            Value = new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    48129578,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 48129578,
                        Value = new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 639),
                        NullableValue = new TimeOnly(hour: 8, minute: 29, second: 28, millisecond: 475),

                        ModelInner = null

                    }
                );

                expected.Add(
                    179831742,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 179831742,
                        Value = new TimeOnly(hour: 9, minute: 27, second: 40, millisecond: 804),
                        NullableValue = new TimeOnly(hour: 19, minute: 14, second: 35, millisecond: 733),

                        ModelInner = null

                    }
                );

                expected.Add(
                    253467142,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 253467142,
                        Value = new TimeOnly(hour: 6, minute: 4, second: 52, millisecond: 716),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 2031022551,
                            Value = new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    256886448,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 256886448,
                        Value = new TimeOnly(hour: 8, minute: 35, second: 0, millisecond: 259),
                        NullableValue = new TimeOnly(hour: 5, minute: 55, second: 11, millisecond: 809),

                        ModelInner = null

                    }
                );

                expected.Add(
                    327656636,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 327656636,
                        Value = new TimeOnly(hour: 21, minute: 20, second: 22, millisecond: 619),
                        NullableValue = new TimeOnly(hour: 17, minute: 47, second: 13, millisecond: 944),

                        ModelInner = null

                    }
                );

                expected.Add(
                    516196781,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 516196781,
                        Value = new TimeOnly(hour: 13, minute: 47, second: 38, millisecond: 684),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1352881684,
                            Value = new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663),
                            NullableValue = new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)
                        }

                    }
                );

                expected.Add(
                    636539084,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 636539084,
                        Value = new TimeOnly(hour: 18, minute: 47, second: 20, millisecond: 189),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    745384691,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 745384691,
                        Value = new TimeOnly(hour: 6, minute: 47, second: 26, millisecond: 584),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 630725644,
                            Value = new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    788973308,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 788973308,
                        Value = new TimeOnly(hour: 9, minute: 23, second: 25, millisecond: 384),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 215929643,
                            Value = new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111),
                            NullableValue = new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)
                        }

                    }
                );

                expected.Add(
                    880400107,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 880400107,
                        Value = new TimeOnly(hour: 6, minute: 10, second: 41, millisecond: 528),
                        NullableValue = new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 943),

                        ModelInner = null

                    }
                );

                expected.Add(
                    904958640,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 904958640,
                        Value = new TimeOnly(hour: 18, minute: 44, second: 43, millisecond: 915),
                        NullableValue = new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 341),

                        ModelInner = null

                    }
                );

                expected.Add(
                    945069282,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 945069282,
                        Value = new TimeOnly(hour: 3, minute: 19, second: 51, millisecond: 179),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1034847259,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1034847259,
                        Value = new TimeOnly(hour: 7, minute: 27, second: 32, millisecond: 763),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 489455896,
                            Value = new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1047201916,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1047201916,
                        Value = new TimeOnly(hour: 22, minute: 0, second: 52, millisecond: 701),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 936661240,
                            Value = new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1112098363,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1112098363,
                        Value = new TimeOnly(hour: 9, minute: 17, second: 15, millisecond: 19),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 881817271,
                            Value = new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774),
                            NullableValue = new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)
                        }

                    }
                );

                expected.Add(
                    1231433845,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1231433845,
                        Value = new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 886),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 66883165,
                            Value = new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1251787174,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1251787174,
                        Value = new TimeOnly(hour: 9, minute: 15, second: 30, millisecond: 775),
                        NullableValue = new TimeOnly(hour: 12, minute: 17, second: 16, millisecond: 437),

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1981295070,
                            Value = new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907),
                            NullableValue = new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)
                        }

                    }
                );

                expected.Add(
                    1263548211,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1263548211,
                        Value = new TimeOnly(hour: 2, minute: 45, second: 31, millisecond: 175),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 284926655,
                            Value = new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1374838988,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1374838988,
                        Value = new TimeOnly(hour: 14, minute: 1, second: 36, millisecond: 696),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1405320056,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1405320056,
                        Value = new TimeOnly(hour: 0, minute: 36, second: 26, millisecond: 487),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1408036836,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1408036836,
                        Value = new TimeOnly(hour: 15, minute: 48, second: 3, millisecond: 842),
                        NullableValue = new TimeOnly(hour: 4, minute: 7, second: 23, millisecond: 844),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1479129084,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1479129084,
                        Value = new TimeOnly(hour: 14, minute: 46, second: 41, millisecond: 219),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1545701143,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1545701143,
                        Value = new TimeOnly(hour: 11, minute: 36, second: 36, millisecond: 179),
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 746735517,
                            Value = new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1588648474,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1588648474,
                        Value = new TimeOnly(hour: 12, minute: 16, second: 19, millisecond: 335),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1645965019,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1645965019,
                        Value = new TimeOnly(hour: 12, minute: 42, second: 33, millisecond: 375),
                        NullableValue = new TimeOnly(hour: 15, minute: 40, second: 35, millisecond: 769),

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1278825437,
                            Value = new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830),
                            NullableValue = new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)
                        }

                    }
                );

                expected.Add(
                    1739177658,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1739177658,
                        Value = new TimeOnly(hour: 0, minute: 6, second: 40, millisecond: 815),
                        NullableValue = new TimeOnly(hour: 22, minute: 39, second: 48, millisecond: 741),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1797468720,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1797468720,
                        Value = new TimeOnly(hour: 20, minute: 22, second: 3, millisecond: 284),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1886032192,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 1886032192,
                        Value = new TimeOnly(hour: 21, minute: 8, second: 54, millisecond: 583),
                        NullableValue = new TimeOnly(hour: 7, minute: 26, second: 35, millisecond: 610),

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 1283875881,
                            Value = new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670),
                            NullableValue = new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)
                        }

                    }
                );

                expected.Add(
                    2067484912,
                    new TimeOnlytime_without_time_zone0M
                    {
                        Id = 2067484912,
                        Value = new TimeOnly(hour: 10, minute: 55, second: 10, millisecond: 577),
                        NullableValue = new TimeOnly(hour: 0, minute: 14, second: 48, millisecond: 718),

                        ModelInner = new TimeOnlytime_without_time_zone0MI
                        {
                            Id = 596770787,
                            Value = new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399),
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zone0MI),
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zone0MI>(15);

                expected.Add(
                    66883165,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 66883165,
                        Value = new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710),
                        NullableValue = null
                    }
                );

                expected.Add(
                    215929643,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 215929643,
                        Value = new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111),
                        NullableValue = new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)
                    }
                );

                expected.Add(
                    284926655,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 284926655,
                        Value = new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182),
                        NullableValue = null
                    }
                );

                expected.Add(
                    489455896,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 489455896,
                        Value = new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425),
                        NullableValue = null
                    }
                );

                expected.Add(
                    596770787,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 596770787,
                        Value = new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399),
                        NullableValue = null
                    }
                );

                expected.Add(
                    630725644,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 630725644,
                        Value = new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489),
                        NullableValue = null
                    }
                );

                expected.Add(
                    746735517,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 746735517,
                        Value = new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329),
                        NullableValue = null
                    }
                );

                expected.Add(
                    881817271,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 881817271,
                        Value = new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774),
                        NullableValue = new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)
                    }
                );

                expected.Add(
                    936661240,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 936661240,
                        Value = new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1278825437,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1278825437,
                        Value = new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830),
                        NullableValue = new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)
                    }
                );

                expected.Add(
                    1283875881,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1283875881,
                        Value = new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670),
                        NullableValue = new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)
                    }
                );

                expected.Add(
                    1352881684,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1352881684,
                        Value = new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663),
                        NullableValue = new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)
                    }
                );

                expected.Add(
                    1838840105,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1838840105,
                        Value = new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1981295070,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1981295070,
                        Value = new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907),
                        NullableValue = new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)
                    }
                );

                expected.Add(
                    2031022551,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 2031022551,
                        Value = new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193),
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zone0MI>(15);

                expected.Add(
                    66883165,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 66883165,
                        Value = new TimeOnly(hour: 8, minute: 58, second: 22, millisecond: 710),
                        NullableValue = null
                    }
                );

                expected.Add(
                    215929643,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 215929643,
                        Value = new TimeOnly(hour: 17, minute: 24, second: 48, millisecond: 111),
                        NullableValue = new TimeOnly(hour: 22, minute: 16, second: 16, millisecond: 482)
                    }
                );

                expected.Add(
                    284926655,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 284926655,
                        Value = new TimeOnly(hour: 0, minute: 5, second: 4, millisecond: 182),
                        NullableValue = null
                    }
                );

                expected.Add(
                    489455896,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 489455896,
                        Value = new TimeOnly(hour: 18, minute: 45, second: 2, millisecond: 425),
                        NullableValue = null
                    }
                );

                expected.Add(
                    596770787,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 596770787,
                        Value = new TimeOnly(hour: 0, minute: 40, second: 13, millisecond: 399),
                        NullableValue = null
                    }
                );

                expected.Add(
                    630725644,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 630725644,
                        Value = new TimeOnly(hour: 22, minute: 19, second: 54, millisecond: 489),
                        NullableValue = null
                    }
                );

                expected.Add(
                    746735517,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 746735517,
                        Value = new TimeOnly(hour: 9, minute: 15, second: 44, millisecond: 329),
                        NullableValue = null
                    }
                );

                expected.Add(
                    881817271,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 881817271,
                        Value = new TimeOnly(hour: 19, minute: 57, second: 3, millisecond: 774),
                        NullableValue = new TimeOnly(hour: 18, minute: 5, second: 52, millisecond: 631)
                    }
                );

                expected.Add(
                    936661240,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 936661240,
                        Value = new TimeOnly(hour: 19, minute: 15, second: 1, millisecond: 827),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1278825437,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1278825437,
                        Value = new TimeOnly(hour: 15, minute: 8, second: 53, millisecond: 830),
                        NullableValue = new TimeOnly(hour: 6, minute: 35, second: 29, millisecond: 877)
                    }
                );

                expected.Add(
                    1283875881,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1283875881,
                        Value = new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 670),
                        NullableValue = new TimeOnly(hour: 13, minute: 22, second: 8, millisecond: 600)
                    }
                );

                expected.Add(
                    1352881684,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1352881684,
                        Value = new TimeOnly(hour: 6, minute: 0, second: 15, millisecond: 663),
                        NullableValue = new TimeOnly(hour: 22, minute: 5, second: 52, millisecond: 82)
                    }
                );

                expected.Add(
                    1838840105,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1838840105,
                        Value = new TimeOnly(hour: 6, minute: 52, second: 34, millisecond: 393),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1981295070,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 1981295070,
                        Value = new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 907),
                        NullableValue = new TimeOnly(hour: 5, minute: 43, second: 14, millisecond: 355)
                    }
                );

                expected.Add(
                    2031022551,
                    new TimeOnlytime_without_time_zone0MI
                    {
                        Id = 2031022551,
                        Value = new TimeOnly(hour: 5, minute: 35, second: 16, millisecond: 193),
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


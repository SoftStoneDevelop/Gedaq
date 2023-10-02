

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
    internal partial interface IDateTimeSingleTypetimestamp_without_time_zone
    {
    }
    
    internal partial class DateTimeSingleTypetimestamp_without_time_zone : IDateTimeSingleTypetimestamp_without_time_zone
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0mi(
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
            queryMapType: typeof(DateTimetimestamp_without_time_zone0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)
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

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInner(connection, 273238864, new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInner(connection, 8581899, new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local));
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

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerAsync(connection, 1736376190, new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerAsync(connection, 1263525151, new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local), null);
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

                id =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerReturning(connection, 1111681138, new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local), null);
                Assert.That(id, Is.EqualTo(1111681138));

                id =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerReturning(connection, 1122654055, new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local), null);
                Assert.That(id, Is.EqualTo(1122654055));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerReturningAsync(connection, 2142297695, new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local));
                Assert.That(id, Is.EqualTo(2142297695));

                id = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelInnerReturningAsync(connection, 262577283, new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local));
                Assert.That(id, Is.EqualTo(262577283));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(26)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(26), 
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

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModel(connection, 990061802, new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local), null);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 189290135, new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 655347646, new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 680847674, new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1427045854, new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local), new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 702874701, new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local), new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1326670294, new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zone0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zone0mi_id", 
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

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModel(connection, 254104999, new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local), new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModel(connection, 1253393480, new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local), new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local), 273238864);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelAsync(connection, 618140093, new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelAsync(connection, 966716755, new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local), 8581899);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime? nullable = null;

                nullable =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturning(connection, 1708487729, new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                nullable =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturning(connection, 88630928, new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local), new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local), 1736376190);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local)));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime? nullable = null;

                nullable = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturningAsync(connection, 194946532, new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local), null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ScalarInsertModelReturningAsync(connection, 1755645508, new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local), null, 1263525151);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zone0mi_id
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
    datetimetimestamp_without_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(21)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_without_time_zone0mi_id", 
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
                List<DateTimetimestamp_without_time_zone0M> models = null;
                DateTimetimestamp_without_time_zone0M model = null;

                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, 601843437, new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local), new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, 1468185802, new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local), new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local), 1111681138).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, 1852880361, new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturning(connection, 1509184139, new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local), null, 1122654055).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateTimetimestamp_without_time_zone0M> models = null;
                DateTimetimestamp_without_time_zone0M model = null;

                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, 1278973634, new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, 1227758809, new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local), null, 2142297695).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, 1164844363, new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).InsertModelReturningAsync(connection, 259811609, new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local), 262577283).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_without_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_without_time_zone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimetimestamp_without_time_zone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateTime), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(26)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(26),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimetimestamp_without_time_zone0mi_id", 
                methodParametrName: "datetimetimestamp_without_time_zone0mi_id", 
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

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModel(connection, 63956355, new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModel(connection, 571474006, new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local), null, 990061802);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 92803419, new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 98885454, new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local), null, 189290135);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 347814873, new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local), new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1407186152, new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local), null, 655347646);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1366249385, new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 1846986214, new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local), new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local), 680847674);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 790115460, new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 453387630, new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local), null, 1427045854);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 579715307, new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 108884196, new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local), 702874701);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 103830741, new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionInsertModelAsync(connection, 78172430, new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local), null, 1326670294);
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
FROM public.datetimetimestamp_without_time_zone0m m
LEFT JOIN public.datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
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
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63956355));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78172430));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1326670294));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88630928));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1736376190));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92803419));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98885454));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(189290135));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103830741));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108884196));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702874701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(194946532));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254104999));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347814873));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453387630));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427045854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618140093));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790115460));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63956355));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78172430));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1326670294));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88630928));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1736376190));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92803419));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98885454));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(189290135));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103830741));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108884196));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702874701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(194946532));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254104999));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347814873));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453387630));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427045854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618140093));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790115460));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

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
FROM public.datetimetimestamp_without_time_zone0m m
LEFT JOIN public.datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
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
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63956355));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78172430));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1326670294));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88630928));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1736376190));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92803419));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98885454));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(189290135));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103830741));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108884196));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702874701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(194946532));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254104999));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347814873));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453387630));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427045854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618140093));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790115460));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63956355));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78172430));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1326670294));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88630928));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1736376190));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92803419));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98885454));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(189290135));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103830741));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108884196));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702874701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(194946532));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254104999));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347814873));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453387630));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427045854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618140093));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790115460));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 254104999);
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(21));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347814873));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453387630));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427045854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618140093));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790115460));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeSingleTypetimestamp_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 453387630);
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(18));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618140093));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790115460));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
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
                 foreach(var batchResult in ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelBatch(connection, 1407186152, 194946532))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254104999));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347814873));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453387630));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427045854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618140093));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790115460));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

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
                await foreach(var batchResult in ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelBatchAsync(connection, 1468185802, 790115460))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(13));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

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
FROM public.datetimetimestamp_without_time_zone0m m
LEFT JOIN public.datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_without_time_zone)
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
                var models =  ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63956355)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78172430)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1326670294)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88630928)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1736376190)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92803419)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98885454)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((189290135)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103830741)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108884196)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((702874701)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194946532)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((254104999)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((259811609)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((262577283)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((347814873)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((453387630)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1427045854)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((571474006)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((990061802)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((579715307)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((601843437)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((618140093)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((790115460)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((966716755)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8581899)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1164844363)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1227758809)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2142297695)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1253393480)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((273238864)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1278973634)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1366249385)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1407186152)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((655347646)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1468185802)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1111681138)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1509184139)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1122654055)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1708487729)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1755645508)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1263525151)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1846986214)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((680847674)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1852880361)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_without_time_zone)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63956355)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78172430)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1326670294)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88630928)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1736376190)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92803419)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98885454)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((189290135)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103830741)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108884196)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((702874701)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194946532)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((254104999)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((259811609)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((262577283)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((347814873)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((453387630)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1427045854)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((571474006)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((990061802)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((579715307)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((601843437)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((618140093)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((790115460)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((966716755)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8581899)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1164844363)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1227758809)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2142297695)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1253393480)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((273238864)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1278973634)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1366249385)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1407186152)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((655347646)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1468185802)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1111681138)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1509184139)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1122654055)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1708487729)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1755645508)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1263525151)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1846986214)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((680847674)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1852880361)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local))));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
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
FROM public.binary_datetimetimestamp_without_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0MI),
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

                var importCollection = new List<DateTimetimestamp_without_time_zone0MI>(7);

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 8581899,
                    Value = new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 189290135,
                    Value = new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 262577283,
                    Value = new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 273238864,
                    Value = new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 655347646,
                    Value = new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 680847674,
                    Value = new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 702874701,
                    Value = new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8581899));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(189290135));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(262577283));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273238864));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(655347646));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(680847674));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702874701));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)));

                importCollection.Clear();

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 990061802,
                    Value = new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 1111681138,
                    Value = new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 1122654055,
                    Value = new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 1263525151,
                    Value = new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 1326670294,
                    Value = new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 1427045854,
                    Value = new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 1736376190,
                    Value = new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0MI
                {
                    Id = 2142297695,
                    Value = new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8581899));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(189290135));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(262577283));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273238864));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(655347646));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(680847674));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702874701));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(990061802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1111681138));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122654055));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263525151));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326670294));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427045854));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1736376190));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142297695));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_without_time_zone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21)
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
FROM public.binary_datetimetimestamp_without_time_zone0m m
LEFT JOIN public.binary_datetimetimestamp_without_time_zone0mi mi ON mi.id = m.datetimetimestamp_without_time_zone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0M),
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

                var importCollection = new List<DateTimetimestamp_without_time_zone0M>(15);

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 63956355,
                    Value = new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 78172430,
                    Value = new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 1326670294
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 88630928,
                    Value = new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local),

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 1736376190
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 92803419,
                    Value = new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 98885454,
                    Value = new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 189290135
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 103830741,
                    Value = new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 108884196,
                    Value = new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local),

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 702874701
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 194946532,
                    Value = new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 254104999,
                    Value = new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 259811609,
                    Value = new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local),

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 262577283
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 347814873,
                    Value = new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 453387630,
                    Value = new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 1427045854
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 571474006,
                    Value = new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 990061802
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 579715307,
                    Value = new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 601843437,
                    Value = new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local),

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63956355));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78172430));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1326670294));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88630928));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1736376190));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92803419));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98885454));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(189290135));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103830741));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108884196));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702874701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(194946532));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254104999));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347814873));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453387630));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427045854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 618140093,
                    Value = new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 790115460,
                    Value = new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 966716755,
                    Value = new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local),

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 8581899
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1164844363,
                    Value = new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1227758809,
                    Value = new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 2142297695
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1253393480,
                    Value = new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local),

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 273238864
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1278973634,
                    Value = new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1366249385,
                    Value = new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1407186152,
                    Value = new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 655347646
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1468185802,
                    Value = new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local),

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 1111681138
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1509184139,
                    Value = new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 1122654055
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1708487729,
                    Value = new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1755645508,
                    Value = new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 1263525151
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1846986214,
                    Value = new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local),

                    ModelInner = new DateTimetimestamp_without_time_zone0MI 
                    {
                        Id = 680847674
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_without_time_zone0M
                {
                    Id = 1852880361,
                    Value = new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local),
                    NullableValue = new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local),

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63956355));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78172430));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1326670294));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88630928));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1736376190));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92803419));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98885454));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(189290135));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103830741));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108884196));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702874701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(194946532));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254104999));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259811609));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(262577283));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347814873));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453387630));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427045854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571474006));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(990061802));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579715307));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601843437));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618140093));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790115460));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(966716755));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8581899));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164844363));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227758809));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2142297695));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253393480));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273238864));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1278973634));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1366249385));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407186152));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655347646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1468185802));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1111681138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509184139));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122654055));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1708487729));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755645508));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1263525151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1846986214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(680847674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)));


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1852880361));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_without_time_zone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_without_time_zone0M>(30);

                expected.Add(
                    63956355,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 63956355,
                        Value = new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    78172430,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 78172430,
                        Value = new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1326670294,
                            Value = new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    88630928,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 88630928,
                        Value = new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1736376190,
                            Value = new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    92803419,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 92803419,
                        Value = new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    98885454,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 98885454,
                        Value = new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 189290135,
                            Value = new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    103830741,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 103830741,
                        Value = new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    108884196,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 108884196,
                        Value = new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 702874701,
                            Value = new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    194946532,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 194946532,
                        Value = new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    254104999,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 254104999,
                        Value = new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    259811609,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 259811609,
                        Value = new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 262577283,
                            Value = new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    347814873,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 347814873,
                        Value = new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    453387630,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 453387630,
                        Value = new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1427045854,
                            Value = new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    571474006,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 571474006,
                        Value = new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 990061802,
                            Value = new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    579715307,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 579715307,
                        Value = new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    601843437,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 601843437,
                        Value = new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    618140093,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 618140093,
                        Value = new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    790115460,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 790115460,
                        Value = new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    966716755,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 966716755,
                        Value = new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 8581899,
                            Value = new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    1164844363,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1164844363,
                        Value = new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1227758809,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1227758809,
                        Value = new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 2142297695,
                            Value = new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    1253393480,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1253393480,
                        Value = new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 273238864,
                            Value = new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1278973634,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1278973634,
                        Value = new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1366249385,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1366249385,
                        Value = new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1407186152,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1407186152,
                        Value = new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 655347646,
                            Value = new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1468185802,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1468185802,
                        Value = new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1111681138,
                            Value = new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1509184139,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1509184139,
                        Value = new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1122654055,
                            Value = new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1708487729,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1708487729,
                        Value = new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1755645508,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1755645508,
                        Value = new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1263525151,
                            Value = new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1846986214,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1846986214,
                        Value = new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 680847674,
                            Value = new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    1852880361,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1852880361,
                        Value = new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_without_time_zone0M>(30);

                expected.Add(
                    63956355,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 63956355,
                        Value = new DateTime(year: 1924, month: 10, day: 2, hour: 19, minute: 19, second: 47, millisecond: 848, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 2015, month: 10, day: 8, hour: 11, minute: 13, second: 4, millisecond: 213, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    78172430,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 78172430,
                        Value = new DateTime(year: 1978, month: 10, day: 4, hour: 16, minute: 37, second: 3, millisecond: 513, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1326670294,
                            Value = new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    88630928,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 88630928,
                        Value = new DateTime(year: 1979, month: 10, day: 9, hour: 22, minute: 3, second: 47, millisecond: 823, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1944, month: 10, day: 10, hour: 13, minute: 9, second: 38, millisecond: 948, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1736376190,
                            Value = new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    92803419,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 92803419,
                        Value = new DateTime(year: 2000, month: 10, day: 10, hour: 17, minute: 1, second: 17, millisecond: 398, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    98885454,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 98885454,
                        Value = new DateTime(year: 1977, month: 10, day: 14, hour: 18, minute: 30, second: 58, millisecond: 37, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 189290135,
                            Value = new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    103830741,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 103830741,
                        Value = new DateTime(year: 1928, month: 10, day: 7, hour: 9, minute: 37, second: 1, millisecond: 698, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    108884196,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 108884196,
                        Value = new DateTime(year: 2007, month: 10, day: 4, hour: 13, minute: 11, second: 20, millisecond: 678, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1994, month: 10, day: 6, hour: 21, minute: 31, second: 3, millisecond: 169, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 702874701,
                            Value = new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    194946532,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 194946532,
                        Value = new DateTime(year: 1932, month: 10, day: 4, hour: 16, minute: 51, second: 51, millisecond: 155, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    254104999,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 254104999,
                        Value = new DateTime(year: 2003, month: 10, day: 6, hour: 6, minute: 21, second: 5, millisecond: 132, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 2017, month: 10, day: 5, hour: 7, minute: 57, second: 47, millisecond: 253, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    259811609,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 259811609,
                        Value = new DateTime(year: 1936, month: 10, day: 6, hour: 1, minute: 29, second: 1, millisecond: 831, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1979, month: 10, day: 9, hour: 12, minute: 29, second: 38, millisecond: 871, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 262577283,
                            Value = new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    347814873,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 347814873,
                        Value = new DateTime(year: 1927, month: 10, day: 9, hour: 4, minute: 7, second: 10, millisecond: 524, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 2014, month: 10, day: 12, hour: 14, minute: 13, second: 19, millisecond: 432, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    453387630,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 453387630,
                        Value = new DateTime(year: 1992, month: 10, day: 16, hour: 22, minute: 44, second: 18, millisecond: 113, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1427045854,
                            Value = new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    571474006,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 571474006,
                        Value = new DateTime(year: 1974, month: 10, day: 10, hour: 16, minute: 18, second: 53, millisecond: 2, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 990061802,
                            Value = new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    579715307,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 579715307,
                        Value = new DateTime(year: 1955, month: 10, day: 1, hour: 15, minute: 49, second: 22, millisecond: 368, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1969, month: 10, day: 10, hour: 15, minute: 7, second: 27, millisecond: 363, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    601843437,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 601843437,
                        Value = new DateTime(year: 1955, month: 10, day: 16, hour: 13, minute: 20, second: 43, millisecond: 905, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1970, month: 10, day: 7, hour: 20, minute: 11, second: 26, millisecond: 2, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    618140093,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 618140093,
                        Value = new DateTime(year: 1940, month: 10, day: 10, hour: 5, minute: 40, second: 2, millisecond: 238, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    790115460,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 790115460,
                        Value = new DateTime(year: 1984, month: 10, day: 4, hour: 8, minute: 52, second: 1, millisecond: 120, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1957, month: 10, day: 5, hour: 15, minute: 30, second: 52, millisecond: 563, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    966716755,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 966716755,
                        Value = new DateTime(year: 1917, month: 10, day: 15, hour: 22, minute: 20, second: 11, millisecond: 96, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1969, month: 10, day: 15, hour: 9, minute: 17, second: 29, millisecond: 591, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 8581899,
                            Value = new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    1164844363,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1164844363,
                        Value = new DateTime(year: 1945, month: 10, day: 11, hour: 12, minute: 9, second: 38, millisecond: 153, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1227758809,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1227758809,
                        Value = new DateTime(year: 1962, month: 10, day: 8, hour: 19, minute: 22, second: 44, millisecond: 938, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 2142297695,
                            Value = new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    1253393480,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1253393480,
                        Value = new DateTime(year: 1956, month: 10, day: 8, hour: 16, minute: 37, second: 18, millisecond: 311, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1917, month: 10, day: 14, hour: 11, minute: 40, second: 51, millisecond: 901, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 273238864,
                            Value = new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1278973634,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1278973634,
                        Value = new DateTime(year: 1965, month: 10, day: 14, hour: 2, minute: 18, second: 34, millisecond: 842, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1366249385,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1366249385,
                        Value = new DateTime(year: 1995, month: 10, day: 16, hour: 7, minute: 44, second: 18, millisecond: 673, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1407186152,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1407186152,
                        Value = new DateTime(year: 2015, month: 10, day: 17, hour: 13, minute: 4, second: 43, millisecond: 651, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 655347646,
                            Value = new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1468185802,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1468185802,
                        Value = new DateTime(year: 2001, month: 10, day: 16, hour: 19, minute: 6, second: 30, millisecond: 170, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1952, month: 10, day: 8, hour: 6, minute: 54, second: 10, millisecond: 413, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1111681138,
                            Value = new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1509184139,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1509184139,
                        Value = new DateTime(year: 2002, month: 10, day: 15, hour: 11, minute: 16, second: 55, millisecond: 157, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1122654055,
                            Value = new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1708487729,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1708487729,
                        Value = new DateTime(year: 1978, month: 10, day: 19, hour: 1, minute: 17, second: 40, millisecond: 85, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1961, month: 10, day: 9, hour: 20, minute: 6, second: 22, millisecond: 252, kind: DateTimeKind.Local),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1755645508,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1755645508,
                        Value = new DateTime(year: 1918, month: 10, day: 13, hour: 5, minute: 9, second: 20, millisecond: 55, kind: DateTimeKind.Local),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 1263525151,
                            Value = new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1846986214,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1846986214,
                        Value = new DateTime(year: 2010, month: 10, day: 15, hour: 13, minute: 11, second: 42, millisecond: 655, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1927, month: 10, day: 9, hour: 18, minute: 24, second: 46, millisecond: 629, kind: DateTimeKind.Local),

                        ModelInner = new DateTimetimestamp_without_time_zone0MI
                        {
                            Id = 680847674,
                            Value = new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local),
                            NullableValue = new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)
                        }

                    }
                );

                expected.Add(
                    1852880361,
                    new DateTimetimestamp_without_time_zone0M
                    {
                        Id = 1852880361,
                        Value = new DateTime(year: 2007, month: 10, day: 17, hour: 4, minute: 19, second: 58, millisecond: 722, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1990, month: 10, day: 10, hour: 15, minute: 14, second: 35, millisecond: 152, kind: DateTimeKind.Local),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_without_time_zone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DateTimetimestamp_without_time_zone0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(21),
                (NpgsqlTypes.NpgsqlDbType)(21)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_without_time_zone0MI>(15);

                expected.Add(
                    8581899,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 8581899,
                        Value = new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    189290135,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 189290135,
                        Value = new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    262577283,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 262577283,
                        Value = new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    273238864,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 273238864,
                        Value = new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    655347646,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 655347646,
                        Value = new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    680847674,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 680847674,
                        Value = new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    702874701,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 702874701,
                        Value = new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    990061802,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 990061802,
                        Value = new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1111681138,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1111681138,
                        Value = new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1122654055,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1122654055,
                        Value = new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1263525151,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1263525151,
                        Value = new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1326670294,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1326670294,
                        Value = new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1427045854,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1427045854,
                        Value = new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    1736376190,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1736376190,
                        Value = new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    2142297695,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 2142297695,
                        Value = new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_without_time_zone0MI>(15);

                expected.Add(
                    8581899,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 8581899,
                        Value = new DateTime(year: 1989, month: 10, day: 15, hour: 15, minute: 18, second: 16, millisecond: 414, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1994, month: 10, day: 8, hour: 10, minute: 28, second: 18, millisecond: 752, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    189290135,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 189290135,
                        Value = new DateTime(year: 2006, month: 10, day: 9, hour: 20, minute: 51, second: 45, millisecond: 714, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1953, month: 10, day: 16, hour: 5, minute: 48, second: 11, millisecond: 113, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    262577283,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 262577283,
                        Value = new DateTime(year: 1978, month: 10, day: 14, hour: 1, minute: 25, second: 16, millisecond: 265, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1998, month: 10, day: 7, hour: 18, minute: 7, second: 46, millisecond: 458, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    273238864,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 273238864,
                        Value = new DateTime(year: 1937, month: 10, day: 13, hour: 16, minute: 16, second: 23, millisecond: 925, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    655347646,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 655347646,
                        Value = new DateTime(year: 2012, month: 10, day: 7, hour: 20, minute: 50, second: 19, millisecond: 998, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    680847674,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 680847674,
                        Value = new DateTime(year: 1938, month: 10, day: 1, hour: 19, minute: 49, second: 23, millisecond: 956, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1934, month: 10, day: 17, hour: 12, minute: 16, second: 33, millisecond: 186, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    702874701,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 702874701,
                        Value = new DateTime(year: 1974, month: 10, day: 2, hour: 5, minute: 37, second: 49, millisecond: 836, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 2000, month: 10, day: 19, hour: 11, minute: 53, second: 57, millisecond: 267, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    990061802,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 990061802,
                        Value = new DateTime(year: 2019, month: 10, day: 4, hour: 12, minute: 54, second: 18, millisecond: 454, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1111681138,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1111681138,
                        Value = new DateTime(year: 1919, month: 10, day: 15, hour: 22, minute: 1, second: 3, millisecond: 949, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1122654055,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1122654055,
                        Value = new DateTime(year: 1984, month: 10, day: 5, hour: 2, minute: 18, second: 49, millisecond: 29, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1263525151,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1263525151,
                        Value = new DateTime(year: 1952, month: 10, day: 13, hour: 16, minute: 23, second: 28, millisecond: 396, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1326670294,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1326670294,
                        Value = new DateTime(year: 1944, month: 10, day: 7, hour: 8, minute: 36, second: 45, millisecond: 273, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1427045854,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1427045854,
                        Value = new DateTime(year: 2009, month: 10, day: 16, hour: 19, minute: 17, second: 39, millisecond: 883, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1955, month: 10, day: 6, hour: 14, minute: 21, second: 50, millisecond: 349, kind: DateTimeKind.Local)
                    }
                );

                expected.Add(
                    1736376190,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 1736376190,
                        Value = new DateTime(year: 1943, month: 10, day: 3, hour: 6, minute: 7, second: 19, millisecond: 529, kind: DateTimeKind.Local),
                        NullableValue = null
                    }
                );

                expected.Add(
                    2142297695,
                    new DateTimetimestamp_without_time_zone0MI
                    {
                        Id = 2142297695,
                        Value = new DateTime(year: 1984, month: 10, day: 6, hour: 2, minute: 42, second: 52, millisecond: 534, kind: DateTimeKind.Local),
                        NullableValue = new DateTime(year: 1953, month: 10, day: 8, hour: 19, minute: 30, second: 15, millisecond: 281, kind: DateTimeKind.Local)
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


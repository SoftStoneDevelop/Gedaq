

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
    internal partial interface IDateTimeSingleTypetimestamp_with_time_zone
    {
    }
    
    internal partial class DateTimeSingleTypetimestamp_with_time_zone : IDateTimeSingleTypetimestamp_with_time_zone
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0mi(
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
            queryMapType: typeof(DateTimetimestamp_with_time_zone0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)
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

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInner(connection, 490158021, new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc), new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInner(connection, 2129238832, new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc));
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

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerAsync(connection, 180694923, new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerAsync(connection, 1937936586, new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc), new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc));
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

                id =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerReturning(connection, 1019228446, new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc), null);
                Assert.That(id, Is.EqualTo(1019228446));

                id =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerReturning(connection, 2112905734, new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc), new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc));
                Assert.That(id, Is.EqualTo(2112905734));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerReturningAsync(connection, 1793241977, new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc), new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc));
                Assert.That(id, Is.EqualTo(1793241977));

                id = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelInnerReturningAsync(connection, 399592973, new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc), new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc));
                Assert.That(id, Is.EqualTo(399592973));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                dbType: (System.Data.DbType)(6)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(6), 
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

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModel(connection, 849761165, new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc), new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc));
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

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 881964955, new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 284636504, new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc), new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1621302415, new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc), new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 2057253292, new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc), new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 904996933, new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertInnerModelAsync(connection, 1041272811, new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc), new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zone0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zone0mi_id", 
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

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModel(connection, 1585475065, new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModel(connection, 754817001, new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc), null, 490158021);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelAsync(connection, 66880207, new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc), new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelAsync(connection, 1337375019, new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc), null, 2129238832);
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

                nullable =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturning(connection, 47547971, new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc), null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturning(connection, 1508460768, new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc), null, 180694923);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.DateTime? nullable = null;

                nullable = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturningAsync(connection, 274059910, new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc), new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc)));

                nullable = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ScalarInsertModelReturningAsync(connection, 300209025, new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc), null, 1937936586);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zone0mi_id
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
    datetimetimestamp_with_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(26)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "datetimetimestamp_with_time_zone0mi_id", 
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
                List<DateTimetimestamp_with_time_zone0M> models = null;
                DateTimetimestamp_with_time_zone0M model = null;

                models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturning(connection, 2039039172, new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc), new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturning(connection, 92692979, new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc), new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc), 1019228446).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92692979));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1019228446));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturning(connection, 1647604119, new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturning(connection, 749040505, new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc), 2112905734).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749040505));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112905734));

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
                List<DateTimetimestamp_with_time_zone0M> models = null;
                DateTimetimestamp_with_time_zone0M model = null;

                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturningAsync(connection, 1179081784, new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc), new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturningAsync(connection, 1916234681, new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc), null, 1793241977).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturningAsync(connection, 1218961298, new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).InsertModelReturningAsync(connection, 46577214, new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc), 399592973).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46577214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(399592973));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateTime)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.datetimetimestamp_with_time_zone0m(
	id,
    value,
    nullablevalue,
    datetimetimestamp_with_time_zone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimetimestamp_with_time_zone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateTime), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(6)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(6),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimetimestamp_with_time_zone0mi_id", 
                methodParametrName: "datetimetimestamp_with_time_zone0mi_id", 
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

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModel(connection, 203044567, new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc), new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModel(connection, 106416710, new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc), null, 849761165);
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

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 1623275884, new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc), new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 2117401201, new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc), new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc), 881964955);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 140261396, new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 805281061, new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc), new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc), 284636504);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 893522444, new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 1036581200, new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc), null, 1621302415);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 378409198, new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc), new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 1634873619, new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc), new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc), 2057253292);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 1105123904, new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc), new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 2123283949, new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc), new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc), 904996933);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 1639748938, new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc), new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionInsertModelAsync(connection, 969158963, new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc), null, 1041272811);
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
FROM public.datetimetimestamp_with_time_zone0m m
LEFT JOIN public.datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46577214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(399592973));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(47547971));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66880207));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92692979));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1019228446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106416710));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(849761165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140261396));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(203044567));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(274059910));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(300209025));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937936586));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(378409198));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749040505));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112905734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754817001));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490158021));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(805281061));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284636504));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893522444));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036581200));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621302415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46577214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(399592973));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(47547971));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66880207));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92692979));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1019228446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106416710));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(849761165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140261396));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(203044567));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(274059910));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(300209025));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937936586));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(378409198));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749040505));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112905734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754817001));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490158021));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(805281061));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284636504));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893522444));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036581200));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621302415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

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
FROM public.datetimetimestamp_with_time_zone0m m
LEFT JOIN public.datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46577214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(399592973));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(47547971));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66880207));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92692979));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1019228446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106416710));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(849761165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140261396));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(203044567));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(274059910));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(300209025));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937936586));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(378409198));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749040505));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112905734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754817001));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490158021));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(805281061));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284636504));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893522444));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036581200));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621302415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46577214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(399592973));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(47547971));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66880207));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92692979));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1019228446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106416710));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(849761165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140261396));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(203044567));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(274059910));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(300209025));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937936586));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(378409198));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749040505));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112905734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754817001));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490158021));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(805281061));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284636504));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893522444));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036581200));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621302415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 749040505);
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(19));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754817001));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490158021));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(805281061));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284636504));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893522444));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036581200));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621302415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeSingleTypetimestamp_with_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 1916234681);
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(3));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                 foreach(var batchResult in ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelBatch(connection, 893522444, 1036581200))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036581200));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621302415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

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
                await foreach(var batchResult in ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelBatchAsync(connection, 1218961298, 46577214))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(29));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(47547971));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66880207));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92692979));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1019228446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106416710));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(849761165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140261396));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(203044567));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(274059910));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(300209025));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937936586));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(378409198));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749040505));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112905734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754817001));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490158021));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(805281061));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284636504));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893522444));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036581200));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621302415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[28];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

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
FROM public.datetimetimestamp_with_time_zone0m m
LEFT JOIN public.datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypetimestamp_with_time_zone)
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
                var models =  ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46577214)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((399592973)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47547971)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66880207)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92692979)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1019228446)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106416710)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((849761165)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140261396)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((203044567)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((274059910)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((300209025)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1937936586)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((378409198)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((749040505)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2112905734)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((754817001)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((490158021)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((805281061)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((284636504)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((893522444)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((969158963)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1041272811)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1036581200)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1621302415)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1105123904)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1179081784)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1218961298)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1337375019)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2129238832)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1508460768)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((180694923)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1585475065)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1623275884)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1634873619)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2057253292)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1639748938)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1647604119)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1916234681)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1793241977)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2039039172)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2117401201)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((881964955)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2123283949)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((904996933)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypetimestamp_with_time_zone)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46577214)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((399592973)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47547971)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66880207)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92692979)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1019228446)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106416710)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((849761165)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140261396)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((203044567)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((274059910)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((300209025)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1937936586)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((378409198)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((749040505)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2112905734)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((754817001)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((490158021)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((805281061)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((284636504)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((893522444)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((969158963)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1041272811)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1036581200)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1621302415)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1105123904)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1179081784)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1218961298)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1337375019)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2129238832)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1508460768)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((180694923)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1585475065)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1623275884)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1634873619)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2057253292)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1639748938)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1647604119)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1916234681)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1793241977)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2039039172)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2117401201)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((881964955)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2123283949)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((904996933)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc))));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(26)
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
FROM public.binary_datetimetimestamp_with_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0MI),
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

                var importCollection = new List<DateTimetimestamp_with_time_zone0MI>(7);

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 180694923,
                    Value = new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 284636504,
                    Value = new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 399592973,
                    Value = new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 490158021,
                    Value = new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 849761165,
                    Value = new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 881964955,
                    Value = new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 904996933,
                    Value = new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc),
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(180694923));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(284636504));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(399592973));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(490158021));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849761165));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(881964955));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904996933));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 1019228446,
                    Value = new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc),
                    NullableValue = null
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 1041272811,
                    Value = new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 1621302415,
                    Value = new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 1793241977,
                    Value = new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 1937936586,
                    Value = new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 2057253292,
                    Value = new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 2112905734,
                    Value = new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)
                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0MI
                {
                    Id = 2129238832,
                    Value = new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(180694923));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(284636504));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(399592973));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(490158021));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849761165));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(881964955));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904996933));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1019228446));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1041272811));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1621302415));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1793241977));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937936586));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2057253292));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2112905734));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2129238832));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
datetimetimestamp_with_time_zone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26)
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
FROM public.binary_datetimetimestamp_with_time_zone0m m
LEFT JOIN public.binary_datetimetimestamp_with_time_zone0mi mi ON mi.id = m.datetimetimestamp_with_time_zone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0M),
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

                var importCollection = new List<DateTimetimestamp_with_time_zone0M>(15);

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 46577214,
                    Value = new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc),

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 399592973
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 47547971,
                    Value = new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 66880207,
                    Value = new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 92692979,
                    Value = new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc),

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 1019228446
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 106416710,
                    Value = new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 849761165
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 140261396,
                    Value = new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 203044567,
                    Value = new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 274059910,
                    Value = new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 300209025,
                    Value = new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 1937936586
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 378409198,
                    Value = new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 749040505,
                    Value = new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc),

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 2112905734
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 754817001,
                    Value = new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 490158021
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 805281061,
                    Value = new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc),

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 284636504
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 893522444,
                    Value = new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 969158963,
                    Value = new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 1041272811
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46577214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(399592973));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(47547971));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66880207));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92692979));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1019228446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106416710));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(849761165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140261396));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(203044567));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(274059910));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(300209025));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937936586));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(378409198));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749040505));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112905734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754817001));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490158021));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(805281061));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284636504));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893522444));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));

                importCollection.Clear();

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1036581200,
                    Value = new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 1621302415
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1105123904,
                    Value = new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1179081784,
                    Value = new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1218961298,
                    Value = new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1337375019,
                    Value = new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 2129238832
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1508460768,
                    Value = new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 180694923
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1585475065,
                    Value = new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1623275884,
                    Value = new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1634873619,
                    Value = new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc),

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 2057253292
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1639748938,
                    Value = new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1647604119,
                    Value = new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 1916234681,
                    Value = new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc),
                    NullableValue = null,

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 1793241977
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 2039039172,
                    Value = new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc),

                    ModelInner = null

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 2117401201,
                    Value = new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc),

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 881964955
                    }

                });

                importCollection.Add(
                new DateTimetimestamp_with_time_zone0M
                {
                    Id = 2123283949,
                    Value = new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc),
                    NullableValue = new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc),

                    ModelInner = new DateTimetimestamp_with_time_zone0MI 
                    {
                        Id = 904996933
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46577214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(399592973));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(47547971));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66880207));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92692979));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1019228446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106416710));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(849761165));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140261396));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(203044567));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(274059910));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(300209025));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937936586));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(378409198));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749040505));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112905734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754817001));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490158021));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(805281061));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(284636504));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893522444));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(969158963));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041272811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)));


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1036581200));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621302415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)));


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105123904));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1179081784));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218961298));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337375019));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2129238832));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508460768));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(180694923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585475065));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1623275884));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634873619));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057253292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639748938));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1647604119));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1916234681));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793241977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)));


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2039039172));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2117401201));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(881964955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123283949));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(904996933));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_datetimetimestamp_with_time_zone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    datetimetimestamp_with_time_zone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zone0M>(30);

                expected.Add(
                    46577214,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 46577214,
                        Value = new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 399592973,
                            Value = new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    47547971,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 47547971,
                        Value = new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    66880207,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 66880207,
                        Value = new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    92692979,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 92692979,
                        Value = new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1019228446,
                            Value = new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    106416710,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 106416710,
                        Value = new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 849761165,
                            Value = new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    140261396,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 140261396,
                        Value = new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    203044567,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 203044567,
                        Value = new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    274059910,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 274059910,
                        Value = new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    300209025,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 300209025,
                        Value = new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1937936586,
                            Value = new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    378409198,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 378409198,
                        Value = new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    749040505,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 749040505,
                        Value = new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 2112905734,
                            Value = new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    754817001,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 754817001,
                        Value = new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 490158021,
                            Value = new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    805281061,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 805281061,
                        Value = new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 284636504,
                            Value = new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    893522444,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 893522444,
                        Value = new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    969158963,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 969158963,
                        Value = new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1041272811,
                            Value = new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    1036581200,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1036581200,
                        Value = new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1621302415,
                            Value = new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    1105123904,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1105123904,
                        Value = new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1179081784,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1179081784,
                        Value = new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1218961298,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1218961298,
                        Value = new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1337375019,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1337375019,
                        Value = new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 2129238832,
                            Value = new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    1508460768,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1508460768,
                        Value = new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 180694923,
                            Value = new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1585475065,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1585475065,
                        Value = new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1623275884,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1623275884,
                        Value = new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1634873619,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1634873619,
                        Value = new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 2057253292,
                            Value = new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    1639748938,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1639748938,
                        Value = new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1647604119,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1647604119,
                        Value = new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1916234681,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1916234681,
                        Value = new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1793241977,
                            Value = new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    2039039172,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 2039039172,
                        Value = new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2117401201,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 2117401201,
                        Value = new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 881964955,
                            Value = new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2123283949,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 2123283949,
                        Value = new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 904996933,
                            Value = new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc),
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zone0M>(30);

                expected.Add(
                    46577214,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 46577214,
                        Value = new DateTime(year: 2017, month: 10, day: 15, hour: 18, minute: 51, second: 36, millisecond: 680, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1961, month: 10, day: 8, hour: 9, minute: 41, second: 10, millisecond: 567, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 399592973,
                            Value = new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    47547971,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 47547971,
                        Value = new DateTime(year: 1963, month: 10, day: 16, hour: 21, minute: 50, second: 13, millisecond: 304, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    66880207,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 66880207,
                        Value = new DateTime(year: 1944, month: 10, day: 15, hour: 4, minute: 52, second: 7, millisecond: 153, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1976, month: 10, day: 17, hour: 17, minute: 26, second: 58, millisecond: 288, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    92692979,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 92692979,
                        Value = new DateTime(year: 1973, month: 10, day: 6, hour: 4, minute: 23, second: 17, millisecond: 859, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1932, month: 10, day: 2, hour: 15, minute: 8, second: 18, millisecond: 566, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1019228446,
                            Value = new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    106416710,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 106416710,
                        Value = new DateTime(year: 1969, month: 10, day: 13, hour: 18, minute: 56, second: 53, millisecond: 705, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 849761165,
                            Value = new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    140261396,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 140261396,
                        Value = new DateTime(year: 1995, month: 10, day: 11, hour: 13, minute: 9, second: 14, millisecond: 410, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    203044567,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 203044567,
                        Value = new DateTime(year: 2008, month: 10, day: 11, hour: 21, minute: 47, second: 29, millisecond: 495, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1956, month: 10, day: 7, hour: 6, minute: 49, second: 48, millisecond: 492, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    274059910,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 274059910,
                        Value = new DateTime(year: 1936, month: 10, day: 1, hour: 7, minute: 42, second: 49, millisecond: 231, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1993, month: 10, day: 6, hour: 16, minute: 42, second: 12, millisecond: 690, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    300209025,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 300209025,
                        Value = new DateTime(year: 1961, month: 10, day: 3, hour: 1, minute: 26, second: 40, millisecond: 364, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1937936586,
                            Value = new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    378409198,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 378409198,
                        Value = new DateTime(year: 1995, month: 10, day: 19, hour: 8, minute: 8, second: 35, millisecond: 7, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1995, month: 10, day: 15, hour: 14, minute: 26, second: 32, millisecond: 486, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    749040505,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 749040505,
                        Value = new DateTime(year: 1939, month: 10, day: 17, hour: 8, minute: 57, second: 2, millisecond: 404, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1962, month: 10, day: 16, hour: 2, minute: 36, second: 22, millisecond: 668, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 2112905734,
                            Value = new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    754817001,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 754817001,
                        Value = new DateTime(year: 1929, month: 10, day: 13, hour: 21, minute: 13, second: 4, millisecond: 347, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 490158021,
                            Value = new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    805281061,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 805281061,
                        Value = new DateTime(year: 1935, month: 10, day: 15, hour: 16, minute: 26, second: 34, millisecond: 126, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1957, month: 10, day: 13, hour: 4, minute: 48, second: 49, millisecond: 366, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 284636504,
                            Value = new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    893522444,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 893522444,
                        Value = new DateTime(year: 1997, month: 10, day: 4, hour: 17, minute: 35, second: 28, millisecond: 977, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    969158963,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 969158963,
                        Value = new DateTime(year: 1978, month: 10, day: 14, hour: 19, minute: 43, second: 53, millisecond: 503, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1041272811,
                            Value = new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    1036581200,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1036581200,
                        Value = new DateTime(year: 1947, month: 10, day: 19, hour: 10, minute: 9, second: 29, millisecond: 456, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1621302415,
                            Value = new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    1105123904,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1105123904,
                        Value = new DateTime(year: 2016, month: 10, day: 4, hour: 22, minute: 23, second: 49, millisecond: 716, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1948, month: 10, day: 14, hour: 16, minute: 24, second: 46, millisecond: 752, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1179081784,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1179081784,
                        Value = new DateTime(year: 1986, month: 10, day: 2, hour: 15, minute: 53, second: 20, millisecond: 229, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1970, month: 10, day: 17, hour: 22, minute: 40, second: 1, millisecond: 837, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1218961298,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1218961298,
                        Value = new DateTime(year: 1934, month: 10, day: 19, hour: 17, minute: 47, second: 40, millisecond: 660, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1337375019,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1337375019,
                        Value = new DateTime(year: 1964, month: 10, day: 7, hour: 2, minute: 42, second: 46, millisecond: 236, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 2129238832,
                            Value = new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    1508460768,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1508460768,
                        Value = new DateTime(year: 1943, month: 10, day: 17, hour: 20, minute: 10, second: 47, millisecond: 469, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 180694923,
                            Value = new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1585475065,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1585475065,
                        Value = new DateTime(year: 1989, month: 10, day: 3, hour: 17, minute: 30, second: 2, millisecond: 821, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1623275884,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1623275884,
                        Value = new DateTime(year: 1995, month: 10, day: 19, hour: 16, minute: 23, second: 42, millisecond: 195, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1961, month: 10, day: 14, hour: 5, minute: 1, second: 35, millisecond: 797, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1634873619,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1634873619,
                        Value = new DateTime(year: 1920, month: 10, day: 14, hour: 10, minute: 35, second: 9, millisecond: 632, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1962, month: 10, day: 13, hour: 2, minute: 45, second: 6, millisecond: 768, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 2057253292,
                            Value = new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    1639748938,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1639748938,
                        Value = new DateTime(year: 1947, month: 10, day: 3, hour: 9, minute: 55, second: 28, millisecond: 231, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1996, month: 10, day: 13, hour: 12, minute: 8, second: 50, millisecond: 110, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1647604119,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1647604119,
                        Value = new DateTime(year: 1946, month: 10, day: 15, hour: 13, minute: 34, second: 48, millisecond: 599, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1916234681,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 1916234681,
                        Value = new DateTime(year: 1936, month: 10, day: 10, hour: 8, minute: 17, second: 3, millisecond: 69, kind: DateTimeKind.Utc),
                        NullableValue = null,

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 1793241977,
                            Value = new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc),
                            NullableValue = new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)
                        }

                    }
                );

                expected.Add(
                    2039039172,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 2039039172,
                        Value = new DateTime(year: 1956, month: 10, day: 17, hour: 16, minute: 39, second: 50, millisecond: 853, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1953, month: 10, day: 16, hour: 10, minute: 34, second: 10, millisecond: 417, kind: DateTimeKind.Utc),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2117401201,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 2117401201,
                        Value = new DateTime(year: 1967, month: 10, day: 6, hour: 6, minute: 53, second: 47, millisecond: 811, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1938, month: 10, day: 17, hour: 15, minute: 26, second: 9, millisecond: 340, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 881964955,
                            Value = new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2123283949,
                    new DateTimetimestamp_with_time_zone0M
                    {
                        Id = 2123283949,
                        Value = new DateTime(year: 1932, month: 10, day: 19, hour: 3, minute: 3, second: 41, millisecond: 430, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 2003, month: 10, day: 5, hour: 13, minute: 35, second: 6, millisecond: 305, kind: DateTimeKind.Utc),

                        ModelInner = new DateTimetimestamp_with_time_zone0MI
                        {
                            Id = 904996933,
                            Value = new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc),
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
COPY public.binary_datetimetimestamp_with_time_zone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DateTimetimestamp_with_time_zone0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(26),
                (NpgsqlTypes.NpgsqlDbType)(26)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zone0MI>(15);

                expected.Add(
                    180694923,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 180694923,
                        Value = new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc),
                        NullableValue = null
                    }
                );

                expected.Add(
                    284636504,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 284636504,
                        Value = new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    399592973,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 399592973,
                        Value = new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    490158021,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 490158021,
                        Value = new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    849761165,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 849761165,
                        Value = new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    881964955,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 881964955,
                        Value = new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc),
                        NullableValue = null
                    }
                );

                expected.Add(
                    904996933,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 904996933,
                        Value = new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1019228446,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1019228446,
                        Value = new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1041272811,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1041272811,
                        Value = new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    1621302415,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1621302415,
                        Value = new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    1793241977,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1793241977,
                        Value = new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    1937936586,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1937936586,
                        Value = new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    2057253292,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 2057253292,
                        Value = new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    2112905734,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 2112905734,
                        Value = new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    2129238832,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 2129238832,
                        Value = new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)
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

                var expected = new Dictionary<System.Int32,DateTimetimestamp_with_time_zone0MI>(15);

                expected.Add(
                    180694923,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 180694923,
                        Value = new DateTime(year: 2019, month: 10, day: 6, hour: 16, minute: 10, second: 34, millisecond: 59, kind: DateTimeKind.Utc),
                        NullableValue = null
                    }
                );

                expected.Add(
                    284636504,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 284636504,
                        Value = new DateTime(year: 1997, month: 10, day: 13, hour: 12, minute: 19, second: 32, millisecond: 933, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1969, month: 10, day: 11, hour: 1, minute: 11, second: 11, millisecond: 369, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    399592973,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 399592973,
                        Value = new DateTime(year: 1941, month: 10, day: 6, hour: 6, minute: 53, second: 25, millisecond: 28, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 2008, month: 10, day: 13, hour: 7, minute: 46, second: 35, millisecond: 166, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    490158021,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 490158021,
                        Value = new DateTime(year: 1923, month: 10, day: 4, hour: 16, minute: 19, second: 22, millisecond: 31, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1940, month: 10, day: 7, hour: 15, minute: 27, second: 18, millisecond: 271, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    849761165,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 849761165,
                        Value = new DateTime(year: 1978, month: 10, day: 11, hour: 7, minute: 38, second: 9, millisecond: 363, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1978, month: 10, day: 9, hour: 7, minute: 18, second: 29, millisecond: 290, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    881964955,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 881964955,
                        Value = new DateTime(year: 1944, month: 10, day: 14, hour: 21, minute: 9, second: 8, millisecond: 735, kind: DateTimeKind.Utc),
                        NullableValue = null
                    }
                );

                expected.Add(
                    904996933,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 904996933,
                        Value = new DateTime(year: 1926, month: 10, day: 19, hour: 8, minute: 29, second: 10, millisecond: 508, kind: DateTimeKind.Utc),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1019228446,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1019228446,
                        Value = new DateTime(year: 1920, month: 10, day: 6, hour: 1, minute: 56, second: 15, millisecond: 727, kind: DateTimeKind.Utc),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1041272811,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1041272811,
                        Value = new DateTime(year: 1950, month: 10, day: 7, hour: 11, minute: 54, second: 12, millisecond: 770, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1984, month: 10, day: 7, hour: 15, minute: 30, second: 29, millisecond: 989, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    1621302415,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1621302415,
                        Value = new DateTime(year: 1949, month: 10, day: 9, hour: 6, minute: 51, second: 49, millisecond: 779, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1982, month: 10, day: 14, hour: 7, minute: 17, second: 53, millisecond: 600, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    1793241977,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1793241977,
                        Value = new DateTime(year: 1977, month: 10, day: 18, hour: 20, minute: 46, second: 9, millisecond: 782, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 2002, month: 10, day: 15, hour: 4, minute: 25, second: 5, millisecond: 188, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    1937936586,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 1937936586,
                        Value = new DateTime(year: 1926, month: 10, day: 10, hour: 17, minute: 12, second: 6, millisecond: 650, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1920, month: 10, day: 9, hour: 9, minute: 19, second: 2, millisecond: 419, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    2057253292,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 2057253292,
                        Value = new DateTime(year: 1927, month: 10, day: 7, hour: 22, minute: 51, second: 26, millisecond: 680, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1917, month: 10, day: 1, hour: 5, minute: 39, second: 3, millisecond: 964, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    2112905734,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 2112905734,
                        Value = new DateTime(year: 2011, month: 10, day: 17, hour: 21, minute: 14, second: 31, millisecond: 886, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1939, month: 10, day: 17, hour: 4, minute: 7, second: 53, millisecond: 392, kind: DateTimeKind.Utc)
                    }
                );

                expected.Add(
                    2129238832,
                    new DateTimetimestamp_with_time_zone0MI
                    {
                        Id = 2129238832,
                        Value = new DateTime(year: 1924, month: 10, day: 13, hour: 18, minute: 19, second: 41, millisecond: 316, kind: DateTimeKind.Utc),
                        NullableValue = new DateTime(year: 1956, month: 10, day: 12, hour: 12, minute: 20, second: 6, millisecond: 457, kind: DateTimeKind.Utc)
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


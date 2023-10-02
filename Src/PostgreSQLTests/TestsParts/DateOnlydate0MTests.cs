

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
    internal partial interface IDateOnlySingleTypedate
    {
    }
    
    internal partial class DateOnlySingleTypedate : IDateOnlySingleTypedate
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0mi(
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
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0mi(
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
            queryMapType: typeof(DateOnlydate0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)
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

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModelInner(connection, 88935646, new DateOnly(year: 1959, month: 10, day: 8), new DateOnly(year: 1966, month: 10, day: 8));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModelInner(connection, 1151899225, new DateOnly(year: 1960, month: 10, day: 12), new DateOnly(year: 2001, month: 10, day: 14));
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

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelInnerAsync(connection, 1535692914, new DateOnly(year: 1971, month: 10, day: 17), new DateOnly(year: 1975, month: 10, day: 14));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelInnerAsync(connection, 1561496310, new DateOnly(year: 1920, month: 10, day: 13), null);
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

                id =  ((IDateOnlySingleTypedate)this).InsertModelInnerReturning(connection, 940082705, new DateOnly(year: 1951, month: 10, day: 16), null);
                Assert.That(id, Is.EqualTo(940082705));

                id =  ((IDateOnlySingleTypedate)this).InsertModelInnerReturning(connection, 236944069, new DateOnly(year: 1953, month: 10, day: 16), new DateOnly(year: 2008, month: 10, day: 15));
                Assert.That(id, Is.EqualTo(236944069));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateOnlySingleTypedate)this).InsertModelInnerReturningAsync(connection, 715783796, new DateOnly(year: 1986, month: 10, day: 4), new DateOnly(year: 1919, month: 10, day: 15));
                Assert.That(id, Is.EqualTo(715783796));

                id = await ((IDateOnlySingleTypedate)this).InsertModelInnerReturningAsync(connection, 111588203, new DateOnly(year: 2013, month: 10, day: 15), new DateOnly(year: 1983, month: 10, day: 12));
                Assert.That(id, Is.EqualTo(111588203));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0mi(
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
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(5)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(5), 
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

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModel(connection, 142667442, new DateOnly(year: 2008, month: 10, day: 2), null);
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

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 690810343, new DateOnly(year: 1920, month: 10, day: 17), new DateOnly(year: 1950, month: 10, day: 7));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1516451808, new DateOnly(year: 2007, month: 10, day: 12), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 143477292, new DateOnly(year: 1958, month: 10, day: 9), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 491214156, new DateOnly(year: 1936, month: 10, day: 16), new DateOnly(year: 2003, month: 10, day: 3));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1629458446, new DateOnly(year: 1949, month: 10, day: 4), new DateOnly(year: 1991, month: 10, day: 11));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 874812854, new DateOnly(year: 2013, month: 10, day: 5), new DateOnly(year: 2005, month: 10, day: 7));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
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
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydate0mi_id", 
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

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModel(connection, 1910786397, new DateOnly(year: 1995, month: 10, day: 6), new DateOnly(year: 1922, month: 10, day: 9), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModel(connection, 740421188, new DateOnly(year: 1957, month: 10, day: 15), new DateOnly(year: 1955, month: 10, day: 13), 88935646);
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

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelAsync(connection, 1830489449, new DateOnly(year: 1978, month: 10, day: 9), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelAsync(connection, 1331257336, new DateOnly(year: 1936, month: 10, day: 16), new DateOnly(year: 1949, month: 10, day: 18), 1151899225);
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
INSERT INTO public.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
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
    dateonlydate0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DateOnlydate0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydate0mi_id", 
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
                List<DateOnlydate0M> models = null;
                DateOnlydate0M model = null;

                models =  ((IDateOnlySingleTypedate)this).InsertModelReturning(connection, 630620807, new DateOnly(year: 1918, month: 10, day: 15), new DateOnly(year: 1931, month: 10, day: 12), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630620807));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateOnlySingleTypedate)this).InsertModelReturning(connection, 1064986348, new DateOnly(year: 2008, month: 10, day: 8), new DateOnly(year: 1929, month: 10, day: 7), 1535692914).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDateOnlySingleTypedate)this).InsertModelReturning(connection, 1632078199, new DateOnly(year: 1923, month: 10, day: 11), new DateOnly(year: 1966, month: 10, day: 10), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateOnlySingleTypedate)this).InsertModelReturning(connection, 1503934841, new DateOnly(year: 1957, month: 10, day: 7), new DateOnly(year: 2007, month: 10, day: 3), 1561496310).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydate0M> models = null;
                DateOnlydate0M model = null;

                models = await ((IDateOnlySingleTypedate)this).InsertModelReturningAsync(connection, 1977539172, new DateOnly(year: 1989, month: 10, day: 12), new DateOnly(year: 1950, month: 10, day: 6), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlySingleTypedate)this).InsertModelReturningAsync(connection, 962527802, new DateOnly(year: 2012, month: 10, day: 8), new DateOnly(year: 2003, month: 10, day: 6), 940082705).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlySingleTypedate)this).InsertModelReturningAsync(connection, 702991084, new DateOnly(year: 1926, month: 10, day: 5), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlySingleTypedate)this).InsertModelReturningAsync(connection, 11100286, new DateOnly(year: 1941, month: 10, day: 17), null, 236944069).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(11100286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1941, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(236944069));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @dateonlydate0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateOnly), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(5)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(5),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "dateonlydate0mi_id", 
                methodParametrName: "dateonlydate0mi_id", 
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

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, 814558315, new DateOnly(year: 1970, month: 10, day: 15), new DateOnly(year: 1980, month: 10, day: 3), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, 1997845494, new DateOnly(year: 1920, month: 10, day: 6), null, 715783796);
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

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 2045404580, new DateOnly(year: 2019, month: 10, day: 7), new DateOnly(year: 1933, month: 10, day: 19), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1889891468, new DateOnly(year: 1935, month: 10, day: 8), new DateOnly(year: 1917, month: 10, day: 15), 111588203);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1257629576, new DateOnly(year: 1940, month: 10, day: 15), new DateOnly(year: 1929, month: 10, day: 11), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1050565675, new DateOnly(year: 1966, month: 10, day: 19), null, 142667442);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 2137047359, new DateOnly(year: 2004, month: 10, day: 16), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 633128763, new DateOnly(year: 1953, month: 10, day: 2), new DateOnly(year: 1975, month: 10, day: 18), 690810343);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 2071705920, new DateOnly(year: 1976, month: 10, day: 10), new DateOnly(year: 2008, month: 10, day: 7), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 5283319, new DateOnly(year: 1962, month: 10, day: 12), new DateOnly(year: 1963, month: 10, day: 6), 1516451808);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1660422786, new DateOnly(year: 1980, month: 10, day: 3), new DateOnly(year: 1992, month: 10, day: 1), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1858026772, new DateOnly(year: 2014, month: 10, day: 14), new DateOnly(year: 1927, month: 10, day: 12), 143477292);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 517171404, new DateOnly(year: 1960, month: 10, day: 3), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 2071619099, new DateOnly(year: 1975, month: 10, day: 17), null, 491214156);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 459961350, new DateOnly(year: 2001, month: 10, day: 5), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1103416651, new DateOnly(year: 1940, month: 10, day: 7), null, 1629458446);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 633594744, new DateOnly(year: 1923, month: 10, day: 1), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1942633967, new DateOnly(year: 1927, month: 10, day: 4), null, 874812854);
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
FROM public.dateonlydate0m m
LEFT JOIN public.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateOnlydate0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                var models =  ((IDateOnlySingleTypedate)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5283319));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1963, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1516451808));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(11100286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1941, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(236944069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 15)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459961350));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517171404));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630620807));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633128763));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(690810343));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633594744));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740421188));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88935646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

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
                var models = await ((IDateOnlySingleTypedate)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5283319));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1963, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1516451808));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(11100286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1941, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(236944069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 15)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459961350));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517171404));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630620807));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633128763));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(690810343));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633594744));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740421188));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88935646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

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
FROM public.dateonlydate0m m
LEFT JOIN public.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateOnlydate0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                var models =  ((IDateOnlySingleTypedate)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5283319));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1963, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1516451808));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(11100286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1941, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(236944069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 15)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459961350));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517171404));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630620807));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633128763));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(690810343));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633594744));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740421188));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88935646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

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
                var models = await ((IDateOnlySingleTypedate)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5283319));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1963, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1516451808));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(11100286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1941, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(236944069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 15)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459961350));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517171404));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630620807));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633128763));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(690810343));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633594744));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740421188));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88935646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

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
                 using var cmd =  ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 740421188);
                var models =  ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(21));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

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
                await using var cmd = await ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 630620807);
                var models = await ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633128763));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(690810343));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633594744));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740421188));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88935646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                 foreach(var batchResult in ((IDateOnlySingleTypedate)this).DbConnectionSelectModelBatch(connection, 633594744, 1830489449))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(23));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740421188));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88935646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

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
                await foreach(var batchResult in ((IDateOnlySingleTypedate)this).DbConnectionSelectModelBatchAsync(connection, 814558315, 1050565675))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(18));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

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
FROM public.dateonlydate0m m
LEFT JOIN public.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
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
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                var models =  ((IDateOnlySingleTypedate)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5283319)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1962, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1516451808)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2007, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1963, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11100286)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1941, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((236944069)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1953, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((459961350)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((517171404)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((630620807)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1931, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((633128763)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1953, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((690810343)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1975, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((633594744)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((702991084)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((740421188)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1957, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88935646)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1959, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((814558315)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((962527802)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((940082705)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1951, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2003, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1050565675)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((142667442)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1064986348)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1535692914)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1971, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1975, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1103416651)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1629458446)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1257629576)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1331257336)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1151899225)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1503934841)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1957, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1561496310)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2007, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1632078199)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1660422786)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1992, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1830489449)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1978, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1858026772)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2014, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((143477292)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1958, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1927, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1889891468)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1935, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((111588203)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1983, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1917, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1910786397)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1995, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1942633967)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1927, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((874812854)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2005, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1977539172)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1989, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1997845494)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((715783796)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1986, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2045404580)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2019, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1933, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2071619099)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1975, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((491214156)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2003, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2071705920)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1976, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2137047359)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2004, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

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
                var models = await ((IDateOnlySingleTypedate)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5283319)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1962, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1516451808)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2007, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1963, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11100286)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1941, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((236944069)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1953, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((459961350)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((517171404)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((630620807)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1931, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((633128763)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1953, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((690810343)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1975, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((633594744)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((702991084)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((740421188)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1957, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88935646)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1959, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((814558315)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((962527802)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((940082705)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1951, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2003, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1050565675)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((142667442)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1064986348)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1535692914)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1971, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1975, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1103416651)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1629458446)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1257629576)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1331257336)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1151899225)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1503934841)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1957, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1561496310)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2007, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1632078199)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1660422786)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1992, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1830489449)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1978, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1858026772)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2014, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((143477292)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1958, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1927, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1889891468)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1935, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((111588203)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1983, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1917, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1910786397)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1995, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1942633967)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1927, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((874812854)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2005, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1977539172)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1989, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1997845494)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((715783796)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1986, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2045404580)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2019, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1933, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2071619099)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1975, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((491214156)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2003, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2071705920)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1976, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2137047359)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2004, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

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
COPY public.binary_dateonlydate0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateOnlydate0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
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
FROM public.binary_dateonlydate0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DateOnlydate0MI),
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

                var importCollection = new List<DateOnlydate0MI>(7);

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 88935646,
                    Value = new DateOnly(year: 1959, month: 10, day: 8),
                    NullableValue = new DateOnly(year: 1966, month: 10, day: 8)
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 111588203,
                    Value = new DateOnly(year: 2013, month: 10, day: 15),
                    NullableValue = new DateOnly(year: 1983, month: 10, day: 12)
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 142667442,
                    Value = new DateOnly(year: 2008, month: 10, day: 2),
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 143477292,
                    Value = new DateOnly(year: 1958, month: 10, day: 9),
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 236944069,
                    Value = new DateOnly(year: 1953, month: 10, day: 16),
                    NullableValue = new DateOnly(year: 2008, month: 10, day: 15)
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 491214156,
                    Value = new DateOnly(year: 1936, month: 10, day: 16),
                    NullableValue = new DateOnly(year: 2003, month: 10, day: 3)
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 690810343,
                    Value = new DateOnly(year: 1920, month: 10, day: 17),
                    NullableValue = new DateOnly(year: 1950, month: 10, day: 7)
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88935646));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111588203));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142667442));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143477292));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(236944069));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 15)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491214156));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690810343));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));

                importCollection.Clear();

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 715783796,
                    Value = new DateOnly(year: 1986, month: 10, day: 4),
                    NullableValue = new DateOnly(year: 1919, month: 10, day: 15)
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 874812854,
                    Value = new DateOnly(year: 2013, month: 10, day: 5),
                    NullableValue = new DateOnly(year: 2005, month: 10, day: 7)
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 940082705,
                    Value = new DateOnly(year: 1951, month: 10, day: 16),
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 1151899225,
                    Value = new DateOnly(year: 1960, month: 10, day: 12),
                    NullableValue = new DateOnly(year: 2001, month: 10, day: 14)
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 1516451808,
                    Value = new DateOnly(year: 2007, month: 10, day: 12),
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 1535692914,
                    Value = new DateOnly(year: 1971, month: 10, day: 17),
                    NullableValue = new DateOnly(year: 1975, month: 10, day: 14)
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 1561496310,
                    Value = new DateOnly(year: 1920, month: 10, day: 13),
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydate0MI
                {
                    Id = 1629458446,
                    Value = new DateOnly(year: 1949, month: 10, day: 4),
                    NullableValue = new DateOnly(year: 1991, month: 10, day: 11)
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88935646));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111588203));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142667442));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143477292));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(236944069));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 15)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491214156));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690810343));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(715783796));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(874812854));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(940082705));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1151899225));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516451808));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1535692914));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1561496310));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1629458446));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydate0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
dateonlydate0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateOnlydate0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7)
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
FROM public.binary_dateonlydate0m m
LEFT JOIN public.binary_dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DateOnlydate0M),
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

                var importCollection = new List<DateOnlydate0M>(15);

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 5283319,
                    Value = new DateOnly(year: 1962, month: 10, day: 12),
                    NullableValue = new DateOnly(year: 1963, month: 10, day: 6),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 1516451808
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 11100286,
                    Value = new DateOnly(year: 1941, month: 10, day: 17),
                    NullableValue = null,

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 236944069
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 459961350,
                    Value = new DateOnly(year: 2001, month: 10, day: 5),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 517171404,
                    Value = new DateOnly(year: 1960, month: 10, day: 3),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 630620807,
                    Value = new DateOnly(year: 1918, month: 10, day: 15),
                    NullableValue = new DateOnly(year: 1931, month: 10, day: 12),

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 633128763,
                    Value = new DateOnly(year: 1953, month: 10, day: 2),
                    NullableValue = new DateOnly(year: 1975, month: 10, day: 18),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 690810343
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 633594744,
                    Value = new DateOnly(year: 1923, month: 10, day: 1),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 702991084,
                    Value = new DateOnly(year: 1926, month: 10, day: 5),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 740421188,
                    Value = new DateOnly(year: 1957, month: 10, day: 15),
                    NullableValue = new DateOnly(year: 1955, month: 10, day: 13),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 88935646
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 814558315,
                    Value = new DateOnly(year: 1970, month: 10, day: 15),
                    NullableValue = new DateOnly(year: 1980, month: 10, day: 3),

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 962527802,
                    Value = new DateOnly(year: 2012, month: 10, day: 8),
                    NullableValue = new DateOnly(year: 2003, month: 10, day: 6),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 940082705
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1050565675,
                    Value = new DateOnly(year: 1966, month: 10, day: 19),
                    NullableValue = null,

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 142667442
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1064986348,
                    Value = new DateOnly(year: 2008, month: 10, day: 8),
                    NullableValue = new DateOnly(year: 1929, month: 10, day: 7),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 1535692914
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1103416651,
                    Value = new DateOnly(year: 1940, month: 10, day: 7),
                    NullableValue = null,

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 1629458446
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1257629576,
                    Value = new DateOnly(year: 1940, month: 10, day: 15),
                    NullableValue = new DateOnly(year: 1929, month: 10, day: 11),

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5283319));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1963, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1516451808));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(11100286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1941, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(236944069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 15)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459961350));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517171404));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630620807));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633128763));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(690810343));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633594744));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740421188));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88935646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1331257336,
                    Value = new DateOnly(year: 1936, month: 10, day: 16),
                    NullableValue = new DateOnly(year: 1949, month: 10, day: 18),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 1151899225
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1503934841,
                    Value = new DateOnly(year: 1957, month: 10, day: 7),
                    NullableValue = new DateOnly(year: 2007, month: 10, day: 3),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 1561496310
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1632078199,
                    Value = new DateOnly(year: 1923, month: 10, day: 11),
                    NullableValue = new DateOnly(year: 1966, month: 10, day: 10),

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1660422786,
                    Value = new DateOnly(year: 1980, month: 10, day: 3),
                    NullableValue = new DateOnly(year: 1992, month: 10, day: 1),

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1830489449,
                    Value = new DateOnly(year: 1978, month: 10, day: 9),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1858026772,
                    Value = new DateOnly(year: 2014, month: 10, day: 14),
                    NullableValue = new DateOnly(year: 1927, month: 10, day: 12),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 143477292
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1889891468,
                    Value = new DateOnly(year: 1935, month: 10, day: 8),
                    NullableValue = new DateOnly(year: 1917, month: 10, day: 15),

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 111588203
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1910786397,
                    Value = new DateOnly(year: 1995, month: 10, day: 6),
                    NullableValue = new DateOnly(year: 1922, month: 10, day: 9),

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1942633967,
                    Value = new DateOnly(year: 1927, month: 10, day: 4),
                    NullableValue = null,

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 874812854
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1977539172,
                    Value = new DateOnly(year: 1989, month: 10, day: 12),
                    NullableValue = new DateOnly(year: 1950, month: 10, day: 6),

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 1997845494,
                    Value = new DateOnly(year: 1920, month: 10, day: 6),
                    NullableValue = null,

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 715783796
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 2045404580,
                    Value = new DateOnly(year: 2019, month: 10, day: 7),
                    NullableValue = new DateOnly(year: 1933, month: 10, day: 19),

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 2071619099,
                    Value = new DateOnly(year: 1975, month: 10, day: 17),
                    NullableValue = null,

                    ModelInner = new DateOnlydate0MI 
                    {
                        Id = 491214156
                    }

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 2071705920,
                    Value = new DateOnly(year: 1976, month: 10, day: 10),
                    NullableValue = new DateOnly(year: 2008, month: 10, day: 7),

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydate0M
                {
                    Id = 2137047359,
                    Value = new DateOnly(year: 2004, month: 10, day: 16),
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5283319));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1963, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1516451808));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(11100286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1941, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(236944069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 15)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459961350));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517171404));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630620807));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633128763));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(690810343));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 7)));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633594744));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702991084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740421188));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(88935646));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 8)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 8)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(814558315));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(962527802));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(940082705));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1951, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1050565675));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142667442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1064986348));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535692914));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 14)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1103416651));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1629458446));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 11)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257629576));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1929, month: 10, day: 11)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1331257336));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 18)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1151899225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 14)));


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503934841));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1957, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1561496310));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1632078199));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1660422786));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1992, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830489449));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858026772));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2014, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(143477292));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889891468));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(111588203));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 12)));


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910786397));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942633967));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1927, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874812854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 7)));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1977539172));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1989, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 6)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997845494));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(715783796));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 15)));


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045404580));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071619099));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491214156));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2003, month: 10, day: 3)));


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071705920));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2008, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137047359));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydate0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    dateonlydate0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DateOnlydate0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7)
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

                var expected = new Dictionary<System.Int32,DateOnlydate0M>(30);

                expected.Add(
                    5283319,
                    new DateOnlydate0M
                    {
                        Id = 5283319,
                        Value = new DateOnly(year: 1962, month: 10, day: 12),
                        NullableValue = new DateOnly(year: 1963, month: 10, day: 6),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1516451808,
                            Value = new DateOnly(year: 2007, month: 10, day: 12),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    11100286,
                    new DateOnlydate0M
                    {
                        Id = 11100286,
                        Value = new DateOnly(year: 1941, month: 10, day: 17),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 236944069,
                            Value = new DateOnly(year: 1953, month: 10, day: 16),
                            NullableValue = new DateOnly(year: 2008, month: 10, day: 15)
                        }

                    }
                );

                expected.Add(
                    459961350,
                    new DateOnlydate0M
                    {
                        Id = 459961350,
                        Value = new DateOnly(year: 2001, month: 10, day: 5),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    517171404,
                    new DateOnlydate0M
                    {
                        Id = 517171404,
                        Value = new DateOnly(year: 1960, month: 10, day: 3),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    630620807,
                    new DateOnlydate0M
                    {
                        Id = 630620807,
                        Value = new DateOnly(year: 1918, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1931, month: 10, day: 12),

                        ModelInner = null

                    }
                );

                expected.Add(
                    633128763,
                    new DateOnlydate0M
                    {
                        Id = 633128763,
                        Value = new DateOnly(year: 1953, month: 10, day: 2),
                        NullableValue = new DateOnly(year: 1975, month: 10, day: 18),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 690810343,
                            Value = new DateOnly(year: 1920, month: 10, day: 17),
                            NullableValue = new DateOnly(year: 1950, month: 10, day: 7)
                        }

                    }
                );

                expected.Add(
                    633594744,
                    new DateOnlydate0M
                    {
                        Id = 633594744,
                        Value = new DateOnly(year: 1923, month: 10, day: 1),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    702991084,
                    new DateOnlydate0M
                    {
                        Id = 702991084,
                        Value = new DateOnly(year: 1926, month: 10, day: 5),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    740421188,
                    new DateOnlydate0M
                    {
                        Id = 740421188,
                        Value = new DateOnly(year: 1957, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1955, month: 10, day: 13),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 88935646,
                            Value = new DateOnly(year: 1959, month: 10, day: 8),
                            NullableValue = new DateOnly(year: 1966, month: 10, day: 8)
                        }

                    }
                );

                expected.Add(
                    814558315,
                    new DateOnlydate0M
                    {
                        Id = 814558315,
                        Value = new DateOnly(year: 1970, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1980, month: 10, day: 3),

                        ModelInner = null

                    }
                );

                expected.Add(
                    962527802,
                    new DateOnlydate0M
                    {
                        Id = 962527802,
                        Value = new DateOnly(year: 2012, month: 10, day: 8),
                        NullableValue = new DateOnly(year: 2003, month: 10, day: 6),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 940082705,
                            Value = new DateOnly(year: 1951, month: 10, day: 16),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1050565675,
                    new DateOnlydate0M
                    {
                        Id = 1050565675,
                        Value = new DateOnly(year: 1966, month: 10, day: 19),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 142667442,
                            Value = new DateOnly(year: 2008, month: 10, day: 2),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1064986348,
                    new DateOnlydate0M
                    {
                        Id = 1064986348,
                        Value = new DateOnly(year: 2008, month: 10, day: 8),
                        NullableValue = new DateOnly(year: 1929, month: 10, day: 7),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1535692914,
                            Value = new DateOnly(year: 1971, month: 10, day: 17),
                            NullableValue = new DateOnly(year: 1975, month: 10, day: 14)
                        }

                    }
                );

                expected.Add(
                    1103416651,
                    new DateOnlydate0M
                    {
                        Id = 1103416651,
                        Value = new DateOnly(year: 1940, month: 10, day: 7),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1629458446,
                            Value = new DateOnly(year: 1949, month: 10, day: 4),
                            NullableValue = new DateOnly(year: 1991, month: 10, day: 11)
                        }

                    }
                );

                expected.Add(
                    1257629576,
                    new DateOnlydate0M
                    {
                        Id = 1257629576,
                        Value = new DateOnly(year: 1940, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1929, month: 10, day: 11),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1331257336,
                    new DateOnlydate0M
                    {
                        Id = 1331257336,
                        Value = new DateOnly(year: 1936, month: 10, day: 16),
                        NullableValue = new DateOnly(year: 1949, month: 10, day: 18),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1151899225,
                            Value = new DateOnly(year: 1960, month: 10, day: 12),
                            NullableValue = new DateOnly(year: 2001, month: 10, day: 14)
                        }

                    }
                );

                expected.Add(
                    1503934841,
                    new DateOnlydate0M
                    {
                        Id = 1503934841,
                        Value = new DateOnly(year: 1957, month: 10, day: 7),
                        NullableValue = new DateOnly(year: 2007, month: 10, day: 3),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1561496310,
                            Value = new DateOnly(year: 1920, month: 10, day: 13),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1632078199,
                    new DateOnlydate0M
                    {
                        Id = 1632078199,
                        Value = new DateOnly(year: 1923, month: 10, day: 11),
                        NullableValue = new DateOnly(year: 1966, month: 10, day: 10),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1660422786,
                    new DateOnlydate0M
                    {
                        Id = 1660422786,
                        Value = new DateOnly(year: 1980, month: 10, day: 3),
                        NullableValue = new DateOnly(year: 1992, month: 10, day: 1),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1830489449,
                    new DateOnlydate0M
                    {
                        Id = 1830489449,
                        Value = new DateOnly(year: 1978, month: 10, day: 9),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1858026772,
                    new DateOnlydate0M
                    {
                        Id = 1858026772,
                        Value = new DateOnly(year: 2014, month: 10, day: 14),
                        NullableValue = new DateOnly(year: 1927, month: 10, day: 12),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 143477292,
                            Value = new DateOnly(year: 1958, month: 10, day: 9),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1889891468,
                    new DateOnlydate0M
                    {
                        Id = 1889891468,
                        Value = new DateOnly(year: 1935, month: 10, day: 8),
                        NullableValue = new DateOnly(year: 1917, month: 10, day: 15),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 111588203,
                            Value = new DateOnly(year: 2013, month: 10, day: 15),
                            NullableValue = new DateOnly(year: 1983, month: 10, day: 12)
                        }

                    }
                );

                expected.Add(
                    1910786397,
                    new DateOnlydate0M
                    {
                        Id = 1910786397,
                        Value = new DateOnly(year: 1995, month: 10, day: 6),
                        NullableValue = new DateOnly(year: 1922, month: 10, day: 9),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1942633967,
                    new DateOnlydate0M
                    {
                        Id = 1942633967,
                        Value = new DateOnly(year: 1927, month: 10, day: 4),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 874812854,
                            Value = new DateOnly(year: 2013, month: 10, day: 5),
                            NullableValue = new DateOnly(year: 2005, month: 10, day: 7)
                        }

                    }
                );

                expected.Add(
                    1977539172,
                    new DateOnlydate0M
                    {
                        Id = 1977539172,
                        Value = new DateOnly(year: 1989, month: 10, day: 12),
                        NullableValue = new DateOnly(year: 1950, month: 10, day: 6),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1997845494,
                    new DateOnlydate0M
                    {
                        Id = 1997845494,
                        Value = new DateOnly(year: 1920, month: 10, day: 6),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 715783796,
                            Value = new DateOnly(year: 1986, month: 10, day: 4),
                            NullableValue = new DateOnly(year: 1919, month: 10, day: 15)
                        }

                    }
                );

                expected.Add(
                    2045404580,
                    new DateOnlydate0M
                    {
                        Id = 2045404580,
                        Value = new DateOnly(year: 2019, month: 10, day: 7),
                        NullableValue = new DateOnly(year: 1933, month: 10, day: 19),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2071619099,
                    new DateOnlydate0M
                    {
                        Id = 2071619099,
                        Value = new DateOnly(year: 1975, month: 10, day: 17),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 491214156,
                            Value = new DateOnly(year: 1936, month: 10, day: 16),
                            NullableValue = new DateOnly(year: 2003, month: 10, day: 3)
                        }

                    }
                );

                expected.Add(
                    2071705920,
                    new DateOnlydate0M
                    {
                        Id = 2071705920,
                        Value = new DateOnly(year: 1976, month: 10, day: 10),
                        NullableValue = new DateOnly(year: 2008, month: 10, day: 7),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2137047359,
                    new DateOnlydate0M
                    {
                        Id = 2137047359,
                        Value = new DateOnly(year: 2004, month: 10, day: 16),
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly)default));
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

                var expected = new Dictionary<System.Int32,DateOnlydate0M>(30);

                expected.Add(
                    5283319,
                    new DateOnlydate0M
                    {
                        Id = 5283319,
                        Value = new DateOnly(year: 1962, month: 10, day: 12),
                        NullableValue = new DateOnly(year: 1963, month: 10, day: 6),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1516451808,
                            Value = new DateOnly(year: 2007, month: 10, day: 12),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    11100286,
                    new DateOnlydate0M
                    {
                        Id = 11100286,
                        Value = new DateOnly(year: 1941, month: 10, day: 17),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 236944069,
                            Value = new DateOnly(year: 1953, month: 10, day: 16),
                            NullableValue = new DateOnly(year: 2008, month: 10, day: 15)
                        }

                    }
                );

                expected.Add(
                    459961350,
                    new DateOnlydate0M
                    {
                        Id = 459961350,
                        Value = new DateOnly(year: 2001, month: 10, day: 5),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    517171404,
                    new DateOnlydate0M
                    {
                        Id = 517171404,
                        Value = new DateOnly(year: 1960, month: 10, day: 3),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    630620807,
                    new DateOnlydate0M
                    {
                        Id = 630620807,
                        Value = new DateOnly(year: 1918, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1931, month: 10, day: 12),

                        ModelInner = null

                    }
                );

                expected.Add(
                    633128763,
                    new DateOnlydate0M
                    {
                        Id = 633128763,
                        Value = new DateOnly(year: 1953, month: 10, day: 2),
                        NullableValue = new DateOnly(year: 1975, month: 10, day: 18),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 690810343,
                            Value = new DateOnly(year: 1920, month: 10, day: 17),
                            NullableValue = new DateOnly(year: 1950, month: 10, day: 7)
                        }

                    }
                );

                expected.Add(
                    633594744,
                    new DateOnlydate0M
                    {
                        Id = 633594744,
                        Value = new DateOnly(year: 1923, month: 10, day: 1),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    702991084,
                    new DateOnlydate0M
                    {
                        Id = 702991084,
                        Value = new DateOnly(year: 1926, month: 10, day: 5),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    740421188,
                    new DateOnlydate0M
                    {
                        Id = 740421188,
                        Value = new DateOnly(year: 1957, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1955, month: 10, day: 13),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 88935646,
                            Value = new DateOnly(year: 1959, month: 10, day: 8),
                            NullableValue = new DateOnly(year: 1966, month: 10, day: 8)
                        }

                    }
                );

                expected.Add(
                    814558315,
                    new DateOnlydate0M
                    {
                        Id = 814558315,
                        Value = new DateOnly(year: 1970, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1980, month: 10, day: 3),

                        ModelInner = null

                    }
                );

                expected.Add(
                    962527802,
                    new DateOnlydate0M
                    {
                        Id = 962527802,
                        Value = new DateOnly(year: 2012, month: 10, day: 8),
                        NullableValue = new DateOnly(year: 2003, month: 10, day: 6),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 940082705,
                            Value = new DateOnly(year: 1951, month: 10, day: 16),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1050565675,
                    new DateOnlydate0M
                    {
                        Id = 1050565675,
                        Value = new DateOnly(year: 1966, month: 10, day: 19),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 142667442,
                            Value = new DateOnly(year: 2008, month: 10, day: 2),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1064986348,
                    new DateOnlydate0M
                    {
                        Id = 1064986348,
                        Value = new DateOnly(year: 2008, month: 10, day: 8),
                        NullableValue = new DateOnly(year: 1929, month: 10, day: 7),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1535692914,
                            Value = new DateOnly(year: 1971, month: 10, day: 17),
                            NullableValue = new DateOnly(year: 1975, month: 10, day: 14)
                        }

                    }
                );

                expected.Add(
                    1103416651,
                    new DateOnlydate0M
                    {
                        Id = 1103416651,
                        Value = new DateOnly(year: 1940, month: 10, day: 7),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1629458446,
                            Value = new DateOnly(year: 1949, month: 10, day: 4),
                            NullableValue = new DateOnly(year: 1991, month: 10, day: 11)
                        }

                    }
                );

                expected.Add(
                    1257629576,
                    new DateOnlydate0M
                    {
                        Id = 1257629576,
                        Value = new DateOnly(year: 1940, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1929, month: 10, day: 11),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1331257336,
                    new DateOnlydate0M
                    {
                        Id = 1331257336,
                        Value = new DateOnly(year: 1936, month: 10, day: 16),
                        NullableValue = new DateOnly(year: 1949, month: 10, day: 18),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1151899225,
                            Value = new DateOnly(year: 1960, month: 10, day: 12),
                            NullableValue = new DateOnly(year: 2001, month: 10, day: 14)
                        }

                    }
                );

                expected.Add(
                    1503934841,
                    new DateOnlydate0M
                    {
                        Id = 1503934841,
                        Value = new DateOnly(year: 1957, month: 10, day: 7),
                        NullableValue = new DateOnly(year: 2007, month: 10, day: 3),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 1561496310,
                            Value = new DateOnly(year: 1920, month: 10, day: 13),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1632078199,
                    new DateOnlydate0M
                    {
                        Id = 1632078199,
                        Value = new DateOnly(year: 1923, month: 10, day: 11),
                        NullableValue = new DateOnly(year: 1966, month: 10, day: 10),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1660422786,
                    new DateOnlydate0M
                    {
                        Id = 1660422786,
                        Value = new DateOnly(year: 1980, month: 10, day: 3),
                        NullableValue = new DateOnly(year: 1992, month: 10, day: 1),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1830489449,
                    new DateOnlydate0M
                    {
                        Id = 1830489449,
                        Value = new DateOnly(year: 1978, month: 10, day: 9),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1858026772,
                    new DateOnlydate0M
                    {
                        Id = 1858026772,
                        Value = new DateOnly(year: 2014, month: 10, day: 14),
                        NullableValue = new DateOnly(year: 1927, month: 10, day: 12),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 143477292,
                            Value = new DateOnly(year: 1958, month: 10, day: 9),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1889891468,
                    new DateOnlydate0M
                    {
                        Id = 1889891468,
                        Value = new DateOnly(year: 1935, month: 10, day: 8),
                        NullableValue = new DateOnly(year: 1917, month: 10, day: 15),

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 111588203,
                            Value = new DateOnly(year: 2013, month: 10, day: 15),
                            NullableValue = new DateOnly(year: 1983, month: 10, day: 12)
                        }

                    }
                );

                expected.Add(
                    1910786397,
                    new DateOnlydate0M
                    {
                        Id = 1910786397,
                        Value = new DateOnly(year: 1995, month: 10, day: 6),
                        NullableValue = new DateOnly(year: 1922, month: 10, day: 9),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1942633967,
                    new DateOnlydate0M
                    {
                        Id = 1942633967,
                        Value = new DateOnly(year: 1927, month: 10, day: 4),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 874812854,
                            Value = new DateOnly(year: 2013, month: 10, day: 5),
                            NullableValue = new DateOnly(year: 2005, month: 10, day: 7)
                        }

                    }
                );

                expected.Add(
                    1977539172,
                    new DateOnlydate0M
                    {
                        Id = 1977539172,
                        Value = new DateOnly(year: 1989, month: 10, day: 12),
                        NullableValue = new DateOnly(year: 1950, month: 10, day: 6),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1997845494,
                    new DateOnlydate0M
                    {
                        Id = 1997845494,
                        Value = new DateOnly(year: 1920, month: 10, day: 6),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 715783796,
                            Value = new DateOnly(year: 1986, month: 10, day: 4),
                            NullableValue = new DateOnly(year: 1919, month: 10, day: 15)
                        }

                    }
                );

                expected.Add(
                    2045404580,
                    new DateOnlydate0M
                    {
                        Id = 2045404580,
                        Value = new DateOnly(year: 2019, month: 10, day: 7),
                        NullableValue = new DateOnly(year: 1933, month: 10, day: 19),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2071619099,
                    new DateOnlydate0M
                    {
                        Id = 2071619099,
                        Value = new DateOnly(year: 1975, month: 10, day: 17),
                        NullableValue = null,

                        ModelInner = new DateOnlydate0MI
                        {
                            Id = 491214156,
                            Value = new DateOnly(year: 1936, month: 10, day: 16),
                            NullableValue = new DateOnly(year: 2003, month: 10, day: 3)
                        }

                    }
                );

                expected.Add(
                    2071705920,
                    new DateOnlydate0M
                    {
                        Id = 2071705920,
                        Value = new DateOnly(year: 1976, month: 10, day: 10),
                        NullableValue = new DateOnly(year: 2008, month: 10, day: 7),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2137047359,
                    new DateOnlydate0M
                    {
                        Id = 2137047359,
                        Value = new DateOnly(year: 2004, month: 10, day: 16),
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydate0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DateOnlydate0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
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

                var expected = new Dictionary<System.Int32,DateOnlydate0MI>(15);

                expected.Add(
                    88935646,
                    new DateOnlydate0MI
                    {
                        Id = 88935646,
                        Value = new DateOnly(year: 1959, month: 10, day: 8),
                        NullableValue = new DateOnly(year: 1966, month: 10, day: 8)
                    }
                );

                expected.Add(
                    111588203,
                    new DateOnlydate0MI
                    {
                        Id = 111588203,
                        Value = new DateOnly(year: 2013, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1983, month: 10, day: 12)
                    }
                );

                expected.Add(
                    142667442,
                    new DateOnlydate0MI
                    {
                        Id = 142667442,
                        Value = new DateOnly(year: 2008, month: 10, day: 2),
                        NullableValue = null
                    }
                );

                expected.Add(
                    143477292,
                    new DateOnlydate0MI
                    {
                        Id = 143477292,
                        Value = new DateOnly(year: 1958, month: 10, day: 9),
                        NullableValue = null
                    }
                );

                expected.Add(
                    236944069,
                    new DateOnlydate0MI
                    {
                        Id = 236944069,
                        Value = new DateOnly(year: 1953, month: 10, day: 16),
                        NullableValue = new DateOnly(year: 2008, month: 10, day: 15)
                    }
                );

                expected.Add(
                    491214156,
                    new DateOnlydate0MI
                    {
                        Id = 491214156,
                        Value = new DateOnly(year: 1936, month: 10, day: 16),
                        NullableValue = new DateOnly(year: 2003, month: 10, day: 3)
                    }
                );

                expected.Add(
                    690810343,
                    new DateOnlydate0MI
                    {
                        Id = 690810343,
                        Value = new DateOnly(year: 1920, month: 10, day: 17),
                        NullableValue = new DateOnly(year: 1950, month: 10, day: 7)
                    }
                );

                expected.Add(
                    715783796,
                    new DateOnlydate0MI
                    {
                        Id = 715783796,
                        Value = new DateOnly(year: 1986, month: 10, day: 4),
                        NullableValue = new DateOnly(year: 1919, month: 10, day: 15)
                    }
                );

                expected.Add(
                    874812854,
                    new DateOnlydate0MI
                    {
                        Id = 874812854,
                        Value = new DateOnly(year: 2013, month: 10, day: 5),
                        NullableValue = new DateOnly(year: 2005, month: 10, day: 7)
                    }
                );

                expected.Add(
                    940082705,
                    new DateOnlydate0MI
                    {
                        Id = 940082705,
                        Value = new DateOnly(year: 1951, month: 10, day: 16),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1151899225,
                    new DateOnlydate0MI
                    {
                        Id = 1151899225,
                        Value = new DateOnly(year: 1960, month: 10, day: 12),
                        NullableValue = new DateOnly(year: 2001, month: 10, day: 14)
                    }
                );

                expected.Add(
                    1516451808,
                    new DateOnlydate0MI
                    {
                        Id = 1516451808,
                        Value = new DateOnly(year: 2007, month: 10, day: 12),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1535692914,
                    new DateOnlydate0MI
                    {
                        Id = 1535692914,
                        Value = new DateOnly(year: 1971, month: 10, day: 17),
                        NullableValue = new DateOnly(year: 1975, month: 10, day: 14)
                    }
                );

                expected.Add(
                    1561496310,
                    new DateOnlydate0MI
                    {
                        Id = 1561496310,
                        Value = new DateOnly(year: 1920, month: 10, day: 13),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1629458446,
                    new DateOnlydate0MI
                    {
                        Id = 1629458446,
                        Value = new DateOnly(year: 1949, month: 10, day: 4),
                        NullableValue = new DateOnly(year: 1991, month: 10, day: 11)
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

                var expected = new Dictionary<System.Int32,DateOnlydate0MI>(15);

                expected.Add(
                    88935646,
                    new DateOnlydate0MI
                    {
                        Id = 88935646,
                        Value = new DateOnly(year: 1959, month: 10, day: 8),
                        NullableValue = new DateOnly(year: 1966, month: 10, day: 8)
                    }
                );

                expected.Add(
                    111588203,
                    new DateOnlydate0MI
                    {
                        Id = 111588203,
                        Value = new DateOnly(year: 2013, month: 10, day: 15),
                        NullableValue = new DateOnly(year: 1983, month: 10, day: 12)
                    }
                );

                expected.Add(
                    142667442,
                    new DateOnlydate0MI
                    {
                        Id = 142667442,
                        Value = new DateOnly(year: 2008, month: 10, day: 2),
                        NullableValue = null
                    }
                );

                expected.Add(
                    143477292,
                    new DateOnlydate0MI
                    {
                        Id = 143477292,
                        Value = new DateOnly(year: 1958, month: 10, day: 9),
                        NullableValue = null
                    }
                );

                expected.Add(
                    236944069,
                    new DateOnlydate0MI
                    {
                        Id = 236944069,
                        Value = new DateOnly(year: 1953, month: 10, day: 16),
                        NullableValue = new DateOnly(year: 2008, month: 10, day: 15)
                    }
                );

                expected.Add(
                    491214156,
                    new DateOnlydate0MI
                    {
                        Id = 491214156,
                        Value = new DateOnly(year: 1936, month: 10, day: 16),
                        NullableValue = new DateOnly(year: 2003, month: 10, day: 3)
                    }
                );

                expected.Add(
                    690810343,
                    new DateOnlydate0MI
                    {
                        Id = 690810343,
                        Value = new DateOnly(year: 1920, month: 10, day: 17),
                        NullableValue = new DateOnly(year: 1950, month: 10, day: 7)
                    }
                );

                expected.Add(
                    715783796,
                    new DateOnlydate0MI
                    {
                        Id = 715783796,
                        Value = new DateOnly(year: 1986, month: 10, day: 4),
                        NullableValue = new DateOnly(year: 1919, month: 10, day: 15)
                    }
                );

                expected.Add(
                    874812854,
                    new DateOnlydate0MI
                    {
                        Id = 874812854,
                        Value = new DateOnly(year: 2013, month: 10, day: 5),
                        NullableValue = new DateOnly(year: 2005, month: 10, day: 7)
                    }
                );

                expected.Add(
                    940082705,
                    new DateOnlydate0MI
                    {
                        Id = 940082705,
                        Value = new DateOnly(year: 1951, month: 10, day: 16),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1151899225,
                    new DateOnlydate0MI
                    {
                        Id = 1151899225,
                        Value = new DateOnly(year: 1960, month: 10, day: 12),
                        NullableValue = new DateOnly(year: 2001, month: 10, day: 14)
                    }
                );

                expected.Add(
                    1516451808,
                    new DateOnlydate0MI
                    {
                        Id = 1516451808,
                        Value = new DateOnly(year: 2007, month: 10, day: 12),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1535692914,
                    new DateOnlydate0MI
                    {
                        Id = 1535692914,
                        Value = new DateOnly(year: 1971, month: 10, day: 17),
                        NullableValue = new DateOnly(year: 1975, month: 10, day: 14)
                    }
                );

                expected.Add(
                    1561496310,
                    new DateOnlydate0MI
                    {
                        Id = 1561496310,
                        Value = new DateOnly(year: 1920, month: 10, day: 13),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1629458446,
                    new DateOnlydate0MI
                    {
                        Id = 1629458446,
                        Value = new DateOnly(year: 1949, month: 10, day: 4),
                        NullableValue = new DateOnly(year: 1991, month: 10, day: 11)
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


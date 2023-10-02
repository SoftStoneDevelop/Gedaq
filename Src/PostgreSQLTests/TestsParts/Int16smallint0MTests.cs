

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
    internal partial interface IInt16SingleTypesmallint
    {
    }
    
    internal partial class Int16SingleTypesmallint : IInt16SingleTypesmallint
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0mi(
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
            queryMapType: typeof(Int16smallint0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
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

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, 1144500183, 25256, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, 1074252540, 3710, null);
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

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, 1344863697, 25253, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, 1410974813, 30090, 22560);
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

                id =  ((IInt16SingleTypesmallint)this).InsertModelInnerReturning(connection, 1114614418, 15570, 10936);
                Assert.That(id, Is.EqualTo(1114614418));

                id =  ((IInt16SingleTypesmallint)this).InsertModelInnerReturning(connection, 101655635, 22277, 29289);
                Assert.That(id, Is.EqualTo(101655635));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IInt16SingleTypesmallint)this).InsertModelInnerReturningAsync(connection, 1597822046, 6269, 22976);
                Assert.That(id, Is.EqualTo(1597822046));

                id = await ((IInt16SingleTypesmallint)this).InsertModelInnerReturningAsync(connection, 1575272793, 10733, 29333);
                Assert.That(id, Is.EqualTo(1575272793));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10), 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModel(connection, 1315953990, 19509, null);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1265191147, 26156, 11195);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 2046085109, 19974, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1464576410, 24420, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1617788475, 27893, 31128);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1887755955, 19584, 9893);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1175260151, 30357, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
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
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallint0mi_id", 
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

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, 441471977, 20616, 29514, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, 944074750, 15950, null, 1144500183);
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

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, 660670276, 27793, 14572, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, 954026688, 28815, null, 1074252540);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16? nullable = null;

                nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelReturning(connection, 1189822788, 9797, 10663, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(10663));

                nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelReturning(connection, 448785547, 5430, 18289, 1344863697);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(18289));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16? nullable = null;

                nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelReturningAsync(connection, 1894052972, 21585, 5661, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(5661));

                nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelReturningAsync(connection, 1161084701, 6091, null, 1410974813);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
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
    int16smallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Int16smallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallint0mi_id", 
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
                List<Int16smallint0M> models = null;
                Int16smallint0M model = null;

                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, 360089141, 25708, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(360089141));
                Assert.That(model.Value, Is.EqualTo(25708));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, 2080361755, 32704, 12956, 1114614418).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int16)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, 742353542, 14554, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, 2147231950, 6395, 5672, 101655635).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int16)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallint0M> models = null;
                Int16smallint0M model = null;

                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, 446753401, 27771, 14003, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(446753401));
                Assert.That(model.Value, Is.EqualTo(27771));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14003));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, 1651613554, 15207, null, 1597822046).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int16)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, 91147818, 11795, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91147818));
                Assert.That(model.Value, Is.EqualTo(11795));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, 447734332, 15961, 16682, 1575272793).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447734332));
                Assert.That(model.Value, Is.EqualTo(15961));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(16682));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1575272793));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int16)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int16), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallint0mi_id", 
                methodParametrName: "int16smallint0mi_id", 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, 102935412, 5183, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, 703837013, 30839, null, 1315953990);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1985075637, 1629, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1403514121, 28701, null, 1265191147);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1726376327, 32500, 30552, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1421023382, 7175, null, 2046085109);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1467005059, 31719, 29857, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1869641560, 8695, null, 1464576410);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1306255703, 8234, 6249, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 659232662, 18750, 14298, 1617788475);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 344179468, 15550, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1556778174, 5125, null, 1887755955);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 604920071, 15783, 32657, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 268215553, 4817, 14112, 1175260151);
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Int16smallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
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
                var models =  ((IInt16SingleTypesmallint)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91147818));
                Assert.That(model.Value, Is.EqualTo(11795));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(102935412));
                Assert.That(model.Value, Is.EqualTo(5183));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268215553));
                Assert.That(model.Value, Is.EqualTo(4817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1175260151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30357));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(344179468));
                Assert.That(model.Value, Is.EqualTo(15550));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(360089141));
                Assert.That(model.Value, Is.EqualTo(25708));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(441471977));
                Assert.That(model.Value, Is.EqualTo(20616));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29514));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(446753401));
                Assert.That(model.Value, Is.EqualTo(27771));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14003));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447734332));
                Assert.That(model.Value, Is.EqualTo(15961));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(16682));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1575272793));

                Assert.That(model.ModelInner.Value, Is.EqualTo(10733));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29333));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(448785547));
                Assert.That(model.Value, Is.EqualTo(5430));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(18289));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1344863697));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25253));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(604920071));
                Assert.That(model.Value, Is.EqualTo(15783));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(32657));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954026688));
                Assert.That(model.Value, Is.EqualTo(28815));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1074252540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3710));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1161084701));
                Assert.That(model.Value, Is.EqualTo(6091));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1410974813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30090));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22560));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189822788));
                Assert.That(model.Value, Is.EqualTo(9797));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10663));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1306255703));
                Assert.That(model.Value, Is.EqualTo(8234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6249));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403514121));
                Assert.That(model.Value, Is.EqualTo(28701));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265191147));

                Assert.That(model.ModelInner.Value, Is.EqualTo(26156));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(11195));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421023382));
                Assert.That(model.Value, Is.EqualTo(7175));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2046085109));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19974));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467005059));
                Assert.That(model.Value, Is.EqualTo(31719));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29857));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556778174));
                Assert.That(model.Value, Is.EqualTo(5125));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1887755955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19584));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(9893));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(6269));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22976));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726376327));
                Assert.That(model.Value, Is.EqualTo(32500));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(30552));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869641560));
                Assert.That(model.Value, Is.EqualTo(8695));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464576410));

                Assert.That(model.ModelInner.Value, Is.EqualTo(24420));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91147818));
                Assert.That(model.Value, Is.EqualTo(11795));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(102935412));
                Assert.That(model.Value, Is.EqualTo(5183));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268215553));
                Assert.That(model.Value, Is.EqualTo(4817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1175260151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30357));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(344179468));
                Assert.That(model.Value, Is.EqualTo(15550));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(360089141));
                Assert.That(model.Value, Is.EqualTo(25708));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(441471977));
                Assert.That(model.Value, Is.EqualTo(20616));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29514));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(446753401));
                Assert.That(model.Value, Is.EqualTo(27771));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14003));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447734332));
                Assert.That(model.Value, Is.EqualTo(15961));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(16682));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1575272793));

                Assert.That(model.ModelInner.Value, Is.EqualTo(10733));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29333));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(448785547));
                Assert.That(model.Value, Is.EqualTo(5430));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(18289));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1344863697));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25253));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(604920071));
                Assert.That(model.Value, Is.EqualTo(15783));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(32657));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954026688));
                Assert.That(model.Value, Is.EqualTo(28815));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1074252540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3710));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1161084701));
                Assert.That(model.Value, Is.EqualTo(6091));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1410974813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30090));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22560));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189822788));
                Assert.That(model.Value, Is.EqualTo(9797));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10663));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1306255703));
                Assert.That(model.Value, Is.EqualTo(8234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6249));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403514121));
                Assert.That(model.Value, Is.EqualTo(28701));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265191147));

                Assert.That(model.ModelInner.Value, Is.EqualTo(26156));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(11195));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421023382));
                Assert.That(model.Value, Is.EqualTo(7175));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2046085109));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19974));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467005059));
                Assert.That(model.Value, Is.EqualTo(31719));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29857));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556778174));
                Assert.That(model.Value, Is.EqualTo(5125));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1887755955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19584));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(9893));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(6269));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22976));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726376327));
                Assert.That(model.Value, Is.EqualTo(32500));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(30552));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869641560));
                Assert.That(model.Value, Is.EqualTo(8695));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464576410));

                Assert.That(model.ModelInner.Value, Is.EqualTo(24420));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Int16smallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
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
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91147818));
                Assert.That(model.Value, Is.EqualTo(11795));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(102935412));
                Assert.That(model.Value, Is.EqualTo(5183));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268215553));
                Assert.That(model.Value, Is.EqualTo(4817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1175260151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30357));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(344179468));
                Assert.That(model.Value, Is.EqualTo(15550));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(360089141));
                Assert.That(model.Value, Is.EqualTo(25708));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(441471977));
                Assert.That(model.Value, Is.EqualTo(20616));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29514));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(446753401));
                Assert.That(model.Value, Is.EqualTo(27771));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14003));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447734332));
                Assert.That(model.Value, Is.EqualTo(15961));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(16682));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1575272793));

                Assert.That(model.ModelInner.Value, Is.EqualTo(10733));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29333));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(448785547));
                Assert.That(model.Value, Is.EqualTo(5430));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(18289));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1344863697));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25253));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(604920071));
                Assert.That(model.Value, Is.EqualTo(15783));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(32657));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954026688));
                Assert.That(model.Value, Is.EqualTo(28815));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1074252540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3710));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1161084701));
                Assert.That(model.Value, Is.EqualTo(6091));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1410974813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30090));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22560));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189822788));
                Assert.That(model.Value, Is.EqualTo(9797));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10663));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1306255703));
                Assert.That(model.Value, Is.EqualTo(8234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6249));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403514121));
                Assert.That(model.Value, Is.EqualTo(28701));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265191147));

                Assert.That(model.ModelInner.Value, Is.EqualTo(26156));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(11195));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421023382));
                Assert.That(model.Value, Is.EqualTo(7175));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2046085109));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19974));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467005059));
                Assert.That(model.Value, Is.EqualTo(31719));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29857));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556778174));
                Assert.That(model.Value, Is.EqualTo(5125));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1887755955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19584));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(9893));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(6269));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22976));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726376327));
                Assert.That(model.Value, Is.EqualTo(32500));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(30552));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869641560));
                Assert.That(model.Value, Is.EqualTo(8695));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464576410));

                Assert.That(model.ModelInner.Value, Is.EqualTo(24420));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91147818));
                Assert.That(model.Value, Is.EqualTo(11795));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(102935412));
                Assert.That(model.Value, Is.EqualTo(5183));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268215553));
                Assert.That(model.Value, Is.EqualTo(4817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1175260151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30357));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(344179468));
                Assert.That(model.Value, Is.EqualTo(15550));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(360089141));
                Assert.That(model.Value, Is.EqualTo(25708));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(441471977));
                Assert.That(model.Value, Is.EqualTo(20616));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29514));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(446753401));
                Assert.That(model.Value, Is.EqualTo(27771));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14003));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447734332));
                Assert.That(model.Value, Is.EqualTo(15961));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(16682));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1575272793));

                Assert.That(model.ModelInner.Value, Is.EqualTo(10733));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29333));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(448785547));
                Assert.That(model.Value, Is.EqualTo(5430));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(18289));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1344863697));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25253));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(604920071));
                Assert.That(model.Value, Is.EqualTo(15783));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(32657));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954026688));
                Assert.That(model.Value, Is.EqualTo(28815));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1074252540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3710));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1161084701));
                Assert.That(model.Value, Is.EqualTo(6091));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1410974813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30090));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22560));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189822788));
                Assert.That(model.Value, Is.EqualTo(9797));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10663));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1306255703));
                Assert.That(model.Value, Is.EqualTo(8234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6249));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403514121));
                Assert.That(model.Value, Is.EqualTo(28701));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265191147));

                Assert.That(model.ModelInner.Value, Is.EqualTo(26156));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(11195));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421023382));
                Assert.That(model.Value, Is.EqualTo(7175));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2046085109));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19974));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467005059));
                Assert.That(model.Value, Is.EqualTo(31719));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29857));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556778174));
                Assert.That(model.Value, Is.EqualTo(5125));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1887755955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19584));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(9893));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(6269));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22976));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726376327));
                Assert.That(model.Value, Is.EqualTo(32500));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(30552));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869641560));
                Assert.That(model.Value, Is.EqualTo(8695));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464576410));

                Assert.That(model.ModelInner.Value, Is.EqualTo(24420));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 1985075637);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(2));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 91147818);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(29));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(102935412));
                Assert.That(model.Value, Is.EqualTo(5183));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268215553));
                Assert.That(model.Value, Is.EqualTo(4817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1175260151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30357));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(344179468));
                Assert.That(model.Value, Is.EqualTo(15550));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(360089141));
                Assert.That(model.Value, Is.EqualTo(25708));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(441471977));
                Assert.That(model.Value, Is.EqualTo(20616));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29514));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(446753401));
                Assert.That(model.Value, Is.EqualTo(27771));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14003));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447734332));
                Assert.That(model.Value, Is.EqualTo(15961));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(16682));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1575272793));

                Assert.That(model.ModelInner.Value, Is.EqualTo(10733));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29333));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(448785547));
                Assert.That(model.Value, Is.EqualTo(5430));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(18289));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1344863697));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25253));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(604920071));
                Assert.That(model.Value, Is.EqualTo(15783));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(32657));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954026688));
                Assert.That(model.Value, Is.EqualTo(28815));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1074252540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3710));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1161084701));
                Assert.That(model.Value, Is.EqualTo(6091));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1410974813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30090));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22560));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189822788));
                Assert.That(model.Value, Is.EqualTo(9797));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10663));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1306255703));
                Assert.That(model.Value, Is.EqualTo(8234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6249));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403514121));
                Assert.That(model.Value, Is.EqualTo(28701));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265191147));

                Assert.That(model.ModelInner.Value, Is.EqualTo(26156));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(11195));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421023382));
                Assert.That(model.Value, Is.EqualTo(7175));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2046085109));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19974));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467005059));
                Assert.That(model.Value, Is.EqualTo(31719));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29857));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556778174));
                Assert.That(model.Value, Is.EqualTo(5125));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1887755955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19584));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(9893));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(6269));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22976));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726376327));
                Assert.That(model.Value, Is.EqualTo(32500));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(30552));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869641560));
                Assert.That(model.Value, Is.EqualTo(8695));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464576410));

                Assert.That(model.ModelInner.Value, Is.EqualTo(24420));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
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
                 foreach(var batchResult in ((IInt16SingleTypesmallint)this).DbConnectionSelectModelBatch(connection, 1869641560, 1894052972))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(3));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

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
                await foreach(var batchResult in ((IInt16SingleTypesmallint)this).DbConnectionSelectModelBatchAsync(connection, 604920071, 447734332))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954026688));
                Assert.That(model.Value, Is.EqualTo(28815));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1074252540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3710));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1161084701));
                Assert.That(model.Value, Is.EqualTo(6091));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1410974813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30090));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22560));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189822788));
                Assert.That(model.Value, Is.EqualTo(9797));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10663));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1306255703));
                Assert.That(model.Value, Is.EqualTo(8234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6249));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403514121));
                Assert.That(model.Value, Is.EqualTo(28701));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265191147));

                Assert.That(model.ModelInner.Value, Is.EqualTo(26156));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(11195));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421023382));
                Assert.That(model.Value, Is.EqualTo(7175));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2046085109));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19974));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467005059));
                Assert.That(model.Value, Is.EqualTo(31719));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29857));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556778174));
                Assert.That(model.Value, Is.EqualTo(5125));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1887755955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19584));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(9893));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(6269));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22976));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726376327));
                Assert.That(model.Value, Is.EqualTo(32500));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(30552));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869641560));
                Assert.That(model.Value, Is.EqualTo(8695));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464576410));

                Assert.That(model.ModelInner.Value, Is.EqualTo(24420));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(448785547));
                Assert.That(model.Value, Is.EqualTo(5430));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(18289));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1344863697));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25253));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(604920071));
                Assert.That(model.Value, Is.EqualTo(15783));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(32657));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954026688));
                Assert.That(model.Value, Is.EqualTo(28815));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1074252540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3710));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1161084701));
                Assert.That(model.Value, Is.EqualTo(6091));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1410974813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30090));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22560));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189822788));
                Assert.That(model.Value, Is.EqualTo(9797));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10663));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1306255703));
                Assert.That(model.Value, Is.EqualTo(8234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6249));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403514121));
                Assert.That(model.Value, Is.EqualTo(28701));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265191147));

                Assert.That(model.ModelInner.Value, Is.EqualTo(26156));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(11195));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421023382));
                Assert.That(model.Value, Is.EqualTo(7175));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2046085109));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19974));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467005059));
                Assert.That(model.Value, Is.EqualTo(31719));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29857));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556778174));
                Assert.That(model.Value, Is.EqualTo(5125));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1887755955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19584));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(9893));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(6269));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22976));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726376327));
                Assert.That(model.Value, Is.EqualTo(32500));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(30552));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869641560));
                Assert.That(model.Value, Is.EqualTo(8695));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464576410));

                Assert.That(model.ModelInner.Value, Is.EqualTo(24420));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));

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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
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
            asPartInterface: typeof(IInt16SingleTypesmallint)
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
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91147818)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11795)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102935412)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5183)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((268215553)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4817)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1175260151)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((30357)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((14112)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((344179468)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15550)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((360089141)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25708)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((441471977)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20616)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29514)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((446753401)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27771)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14003)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((447734332)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15961)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1575272793)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10733)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((29333)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16682)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((448785547)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5430)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1344863697)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25253)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((18289)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((604920071)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15783)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((32657)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((659232662)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18750)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1617788475)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27893)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31128)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14298)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((660670276)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27793)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14572)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((703837013)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30839)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1315953990)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19509)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((742353542)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14554)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((944074750)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15950)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1144500183)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25256)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((954026688)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28815)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1074252540)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((3710)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1161084701)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6091)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1410974813)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((30090)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22560)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1189822788)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9797)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10663)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1306255703)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8234)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((6249)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1403514121)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28701)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1265191147)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((26156)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((11195)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1421023382)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7175)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2046085109)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19974)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1467005059)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31719)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29857)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1556778174)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5125)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1887755955)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19584)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((9893)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1651613554)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15207)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1597822046)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((6269)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22976)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1726376327)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32500)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((30552)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1869641560)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8695)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1464576410)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24420)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1894052972)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21585)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((5661)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1985075637)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1629)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2080361755)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32704)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1114614418)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15570)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((10936)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12956)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2147231950)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6395)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101655635)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((22277)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((29289)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((5672)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91147818)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11795)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102935412)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5183)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((268215553)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4817)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1175260151)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((30357)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((14112)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((344179468)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15550)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((360089141)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25708)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((441471977)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20616)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29514)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((446753401)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27771)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14003)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((447734332)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15961)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1575272793)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10733)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((29333)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16682)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((448785547)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5430)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1344863697)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25253)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((18289)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((604920071)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15783)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((32657)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((659232662)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18750)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1617788475)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27893)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31128)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14298)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((660670276)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27793)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14572)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((703837013)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30839)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1315953990)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19509)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((742353542)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14554)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((944074750)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15950)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1144500183)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25256)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((954026688)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28815)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1074252540)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((3710)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1161084701)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6091)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1410974813)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((30090)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22560)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1189822788)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9797)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10663)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1306255703)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8234)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((6249)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1403514121)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28701)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1265191147)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((26156)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((11195)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1421023382)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7175)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2046085109)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19974)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1467005059)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31719)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29857)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1556778174)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5125)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1887755955)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19584)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((9893)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1651613554)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15207)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1597822046)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((6269)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22976)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1726376327)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32500)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((30552)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1869641560)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8695)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1464576410)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24420)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1894052972)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21585)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((5661)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1985075637)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1629)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2080361755)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32704)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1114614418)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15570)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((10936)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12956)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2147231950)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6395)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101655635)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((22277)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((29289)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((5672)));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int16smallint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
FROM public.binary_int16smallint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Int16smallint0MI),
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

                var importCollection = new List<Int16smallint0MI>(7);

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 101655635,
                    Value = 22277,
                    NullableValue = 29289
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1074252540,
                    Value = 3710,
                    NullableValue = null
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1114614418,
                    Value = 15570,
                    NullableValue = 10936
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1144500183,
                    Value = 25256,
                    NullableValue = null
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1175260151,
                    Value = 30357,
                    NullableValue = null
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1265191147,
                    Value = 26156,
                    NullableValue = 11195
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1315953990,
                    Value = 19509,
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101655635));
                Assert.That(model.Value, Is.EqualTo(22277));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29289));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074252540));
                Assert.That(model.Value, Is.EqualTo(3710));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114614418));
                Assert.That(model.Value, Is.EqualTo(15570));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10936));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144500183));
                Assert.That(model.Value, Is.EqualTo(25256));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1175260151));
                Assert.That(model.Value, Is.EqualTo(30357));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1265191147));
                Assert.That(model.Value, Is.EqualTo(26156));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(11195));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315953990));
                Assert.That(model.Value, Is.EqualTo(19509));

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1344863697,
                    Value = 25253,
                    NullableValue = null
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1410974813,
                    Value = 30090,
                    NullableValue = 22560
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1464576410,
                    Value = 24420,
                    NullableValue = null
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1575272793,
                    Value = 10733,
                    NullableValue = 29333
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1597822046,
                    Value = 6269,
                    NullableValue = 22976
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1617788475,
                    Value = 27893,
                    NullableValue = 31128
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 1887755955,
                    Value = 19584,
                    NullableValue = 9893
                });

                importCollection.Add(
                new Int16smallint0MI
                {
                    Id = 2046085109,
                    Value = 19974,
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101655635));
                Assert.That(model.Value, Is.EqualTo(22277));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29289));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074252540));
                Assert.That(model.Value, Is.EqualTo(3710));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114614418));
                Assert.That(model.Value, Is.EqualTo(15570));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10936));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144500183));
                Assert.That(model.Value, Is.EqualTo(25256));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1175260151));
                Assert.That(model.Value, Is.EqualTo(30357));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1265191147));
                Assert.That(model.Value, Is.EqualTo(26156));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(11195));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315953990));
                Assert.That(model.Value, Is.EqualTo(19509));

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1344863697));
                Assert.That(model.Value, Is.EqualTo(25253));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1410974813));
                Assert.That(model.Value, Is.EqualTo(30090));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(22560));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1464576410));
                Assert.That(model.Value, Is.EqualTo(24420));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1575272793));
                Assert.That(model.Value, Is.EqualTo(10733));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29333));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1597822046));
                Assert.That(model.Value, Is.EqualTo(6269));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(22976));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617788475));
                Assert.That(model.Value, Is.EqualTo(27893));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(31128));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1887755955));
                Assert.That(model.Value, Is.EqualTo(19584));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9893));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2046085109));
                Assert.That(model.Value, Is.EqualTo(19974));

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int16smallint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int16smallint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
FROM public.binary_int16smallint0m m
LEFT JOIN public.binary_int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Int16smallint0M),
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

                var importCollection = new List<Int16smallint0M>(15);

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 91147818,
                    Value = 11795,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 102935412,
                    Value = 5183,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 268215553,
                    Value = 4817,
                    NullableValue = 14112,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1175260151
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 344179468,
                    Value = 15550,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 360089141,
                    Value = 25708,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 441471977,
                    Value = 20616,
                    NullableValue = 29514,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 446753401,
                    Value = 27771,
                    NullableValue = 14003,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 447734332,
                    Value = 15961,
                    NullableValue = 16682,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1575272793
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 448785547,
                    Value = 5430,
                    NullableValue = 18289,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1344863697
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 604920071,
                    Value = 15783,
                    NullableValue = 32657,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 659232662,
                    Value = 18750,
                    NullableValue = 14298,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1617788475
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 660670276,
                    Value = 27793,
                    NullableValue = 14572,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 703837013,
                    Value = 30839,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1315953990
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 742353542,
                    Value = 14554,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 944074750,
                    Value = 15950,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1144500183
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91147818));
                Assert.That(model.Value, Is.EqualTo(11795));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(102935412));
                Assert.That(model.Value, Is.EqualTo(5183));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268215553));
                Assert.That(model.Value, Is.EqualTo(4817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1175260151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30357));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(344179468));
                Assert.That(model.Value, Is.EqualTo(15550));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(360089141));
                Assert.That(model.Value, Is.EqualTo(25708));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(441471977));
                Assert.That(model.Value, Is.EqualTo(20616));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29514));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(446753401));
                Assert.That(model.Value, Is.EqualTo(27771));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14003));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447734332));
                Assert.That(model.Value, Is.EqualTo(15961));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(16682));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1575272793));

                Assert.That(model.ModelInner.Value, Is.EqualTo(10733));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29333));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(448785547));
                Assert.That(model.Value, Is.EqualTo(5430));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(18289));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1344863697));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25253));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(604920071));
                Assert.That(model.Value, Is.EqualTo(15783));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(32657));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 954026688,
                    Value = 28815,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1074252540
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1161084701,
                    Value = 6091,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1410974813
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1189822788,
                    Value = 9797,
                    NullableValue = 10663,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1306255703,
                    Value = 8234,
                    NullableValue = 6249,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1403514121,
                    Value = 28701,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1265191147
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1421023382,
                    Value = 7175,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 2046085109
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1467005059,
                    Value = 31719,
                    NullableValue = 29857,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1556778174,
                    Value = 5125,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1887755955
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1651613554,
                    Value = 15207,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1597822046
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1726376327,
                    Value = 32500,
                    NullableValue = 30552,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1869641560,
                    Value = 8695,
                    NullableValue = null,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1464576410
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1894052972,
                    Value = 21585,
                    NullableValue = 5661,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 1985075637,
                    Value = 1629,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 2080361755,
                    Value = 32704,
                    NullableValue = 12956,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 1114614418
                    }

                });

                importCollection.Add(
                new Int16smallint0M
                {
                    Id = 2147231950,
                    Value = 6395,
                    NullableValue = 5672,

                    ModelInner = new Int16smallint0MI 
                    {
                        Id = 101655635
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91147818));
                Assert.That(model.Value, Is.EqualTo(11795));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(102935412));
                Assert.That(model.Value, Is.EqualTo(5183));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268215553));
                Assert.That(model.Value, Is.EqualTo(4817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1175260151));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30357));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(344179468));
                Assert.That(model.Value, Is.EqualTo(15550));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(360089141));
                Assert.That(model.Value, Is.EqualTo(25708));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(441471977));
                Assert.That(model.Value, Is.EqualTo(20616));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29514));

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(446753401));
                Assert.That(model.Value, Is.EqualTo(27771));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14003));

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(447734332));
                Assert.That(model.Value, Is.EqualTo(15961));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(16682));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1575272793));

                Assert.That(model.ModelInner.Value, Is.EqualTo(10733));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29333));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(448785547));
                Assert.That(model.Value, Is.EqualTo(5430));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(18289));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1344863697));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25253));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(604920071));
                Assert.That(model.Value, Is.EqualTo(15783));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(32657));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659232662));
                Assert.That(model.Value, Is.EqualTo(18750));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14298));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617788475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27893));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31128));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660670276));
                Assert.That(model.Value, Is.EqualTo(27793));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(14572));

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(703837013));
                Assert.That(model.Value, Is.EqualTo(30839));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1315953990));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19509));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(742353542));
                Assert.That(model.Value, Is.EqualTo(14554));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(944074750));
                Assert.That(model.Value, Is.EqualTo(15950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1144500183));

                Assert.That(model.ModelInner.Value, Is.EqualTo(25256));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954026688));
                Assert.That(model.Value, Is.EqualTo(28815));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1074252540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3710));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1161084701));
                Assert.That(model.Value, Is.EqualTo(6091));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1410974813));

                Assert.That(model.ModelInner.Value, Is.EqualTo(30090));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22560));


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1189822788));
                Assert.That(model.Value, Is.EqualTo(9797));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(10663));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1306255703));
                Assert.That(model.Value, Is.EqualTo(8234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6249));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403514121));
                Assert.That(model.Value, Is.EqualTo(28701));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265191147));

                Assert.That(model.ModelInner.Value, Is.EqualTo(26156));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(11195));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1421023382));
                Assert.That(model.Value, Is.EqualTo(7175));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2046085109));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19974));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467005059));
                Assert.That(model.Value, Is.EqualTo(31719));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(29857));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556778174));
                Assert.That(model.Value, Is.EqualTo(5125));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1887755955));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19584));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(9893));


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1651613554));
                Assert.That(model.Value, Is.EqualTo(15207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1597822046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(6269));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(22976));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726376327));
                Assert.That(model.Value, Is.EqualTo(32500));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(30552));

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869641560));
                Assert.That(model.Value, Is.EqualTo(8695));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464576410));

                Assert.That(model.ModelInner.Value, Is.EqualTo(24420));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1894052972));
                Assert.That(model.Value, Is.EqualTo(21585));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5661));

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985075637));
                Assert.That(model.Value, Is.EqualTo(1629));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080361755));
                Assert.That(model.Value, Is.EqualTo(32704));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(12956));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114614418));

                Assert.That(model.ModelInner.Value, Is.EqualTo(15570));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(10936));


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2147231950));
                Assert.That(model.Value, Is.EqualTo(6395));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5672));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101655635));

                Assert.That(model.ModelInner.Value, Is.EqualTo(22277));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(29289));


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int16smallint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Int16smallint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
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

                var expected = new Dictionary<System.Int32,Int16smallint0M>(30);

                expected.Add(
                    91147818,
                    new Int16smallint0M
                    {
                        Id = 91147818,
                        Value = 11795,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    102935412,
                    new Int16smallint0M
                    {
                        Id = 102935412,
                        Value = 5183,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    268215553,
                    new Int16smallint0M
                    {
                        Id = 268215553,
                        Value = 4817,
                        NullableValue = 14112,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1175260151,
                            Value = 30357,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    344179468,
                    new Int16smallint0M
                    {
                        Id = 344179468,
                        Value = 15550,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    360089141,
                    new Int16smallint0M
                    {
                        Id = 360089141,
                        Value = 25708,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    441471977,
                    new Int16smallint0M
                    {
                        Id = 441471977,
                        Value = 20616,
                        NullableValue = 29514,

                        ModelInner = null

                    }
                );

                expected.Add(
                    446753401,
                    new Int16smallint0M
                    {
                        Id = 446753401,
                        Value = 27771,
                        NullableValue = 14003,

                        ModelInner = null

                    }
                );

                expected.Add(
                    447734332,
                    new Int16smallint0M
                    {
                        Id = 447734332,
                        Value = 15961,
                        NullableValue = 16682,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1575272793,
                            Value = 10733,
                            NullableValue = 29333
                        }

                    }
                );

                expected.Add(
                    448785547,
                    new Int16smallint0M
                    {
                        Id = 448785547,
                        Value = 5430,
                        NullableValue = 18289,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1344863697,
                            Value = 25253,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    604920071,
                    new Int16smallint0M
                    {
                        Id = 604920071,
                        Value = 15783,
                        NullableValue = 32657,

                        ModelInner = null

                    }
                );

                expected.Add(
                    659232662,
                    new Int16smallint0M
                    {
                        Id = 659232662,
                        Value = 18750,
                        NullableValue = 14298,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1617788475,
                            Value = 27893,
                            NullableValue = 31128
                        }

                    }
                );

                expected.Add(
                    660670276,
                    new Int16smallint0M
                    {
                        Id = 660670276,
                        Value = 27793,
                        NullableValue = 14572,

                        ModelInner = null

                    }
                );

                expected.Add(
                    703837013,
                    new Int16smallint0M
                    {
                        Id = 703837013,
                        Value = 30839,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1315953990,
                            Value = 19509,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    742353542,
                    new Int16smallint0M
                    {
                        Id = 742353542,
                        Value = 14554,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    944074750,
                    new Int16smallint0M
                    {
                        Id = 944074750,
                        Value = 15950,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1144500183,
                            Value = 25256,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    954026688,
                    new Int16smallint0M
                    {
                        Id = 954026688,
                        Value = 28815,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1074252540,
                            Value = 3710,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1161084701,
                    new Int16smallint0M
                    {
                        Id = 1161084701,
                        Value = 6091,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1410974813,
                            Value = 30090,
                            NullableValue = 22560
                        }

                    }
                );

                expected.Add(
                    1189822788,
                    new Int16smallint0M
                    {
                        Id = 1189822788,
                        Value = 9797,
                        NullableValue = 10663,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1306255703,
                    new Int16smallint0M
                    {
                        Id = 1306255703,
                        Value = 8234,
                        NullableValue = 6249,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1403514121,
                    new Int16smallint0M
                    {
                        Id = 1403514121,
                        Value = 28701,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1265191147,
                            Value = 26156,
                            NullableValue = 11195
                        }

                    }
                );

                expected.Add(
                    1421023382,
                    new Int16smallint0M
                    {
                        Id = 1421023382,
                        Value = 7175,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 2046085109,
                            Value = 19974,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1467005059,
                    new Int16smallint0M
                    {
                        Id = 1467005059,
                        Value = 31719,
                        NullableValue = 29857,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1556778174,
                    new Int16smallint0M
                    {
                        Id = 1556778174,
                        Value = 5125,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1887755955,
                            Value = 19584,
                            NullableValue = 9893
                        }

                    }
                );

                expected.Add(
                    1651613554,
                    new Int16smallint0M
                    {
                        Id = 1651613554,
                        Value = 15207,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1597822046,
                            Value = 6269,
                            NullableValue = 22976
                        }

                    }
                );

                expected.Add(
                    1726376327,
                    new Int16smallint0M
                    {
                        Id = 1726376327,
                        Value = 32500,
                        NullableValue = 30552,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1869641560,
                    new Int16smallint0M
                    {
                        Id = 1869641560,
                        Value = 8695,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1464576410,
                            Value = 24420,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1894052972,
                    new Int16smallint0M
                    {
                        Id = 1894052972,
                        Value = 21585,
                        NullableValue = 5661,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1985075637,
                    new Int16smallint0M
                    {
                        Id = 1985075637,
                        Value = 1629,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2080361755,
                    new Int16smallint0M
                    {
                        Id = 2080361755,
                        Value = 32704,
                        NullableValue = 12956,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1114614418,
                            Value = 15570,
                            NullableValue = 10936
                        }

                    }
                );

                expected.Add(
                    2147231950,
                    new Int16smallint0M
                    {
                        Id = 2147231950,
                        Value = 6395,
                        NullableValue = 5672,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 101655635,
                            Value = 22277,
                            NullableValue = 29289
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int16)default));
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

                var expected = new Dictionary<System.Int32,Int16smallint0M>(30);

                expected.Add(
                    91147818,
                    new Int16smallint0M
                    {
                        Id = 91147818,
                        Value = 11795,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    102935412,
                    new Int16smallint0M
                    {
                        Id = 102935412,
                        Value = 5183,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    268215553,
                    new Int16smallint0M
                    {
                        Id = 268215553,
                        Value = 4817,
                        NullableValue = 14112,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1175260151,
                            Value = 30357,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    344179468,
                    new Int16smallint0M
                    {
                        Id = 344179468,
                        Value = 15550,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    360089141,
                    new Int16smallint0M
                    {
                        Id = 360089141,
                        Value = 25708,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    441471977,
                    new Int16smallint0M
                    {
                        Id = 441471977,
                        Value = 20616,
                        NullableValue = 29514,

                        ModelInner = null

                    }
                );

                expected.Add(
                    446753401,
                    new Int16smallint0M
                    {
                        Id = 446753401,
                        Value = 27771,
                        NullableValue = 14003,

                        ModelInner = null

                    }
                );

                expected.Add(
                    447734332,
                    new Int16smallint0M
                    {
                        Id = 447734332,
                        Value = 15961,
                        NullableValue = 16682,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1575272793,
                            Value = 10733,
                            NullableValue = 29333
                        }

                    }
                );

                expected.Add(
                    448785547,
                    new Int16smallint0M
                    {
                        Id = 448785547,
                        Value = 5430,
                        NullableValue = 18289,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1344863697,
                            Value = 25253,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    604920071,
                    new Int16smallint0M
                    {
                        Id = 604920071,
                        Value = 15783,
                        NullableValue = 32657,

                        ModelInner = null

                    }
                );

                expected.Add(
                    659232662,
                    new Int16smallint0M
                    {
                        Id = 659232662,
                        Value = 18750,
                        NullableValue = 14298,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1617788475,
                            Value = 27893,
                            NullableValue = 31128
                        }

                    }
                );

                expected.Add(
                    660670276,
                    new Int16smallint0M
                    {
                        Id = 660670276,
                        Value = 27793,
                        NullableValue = 14572,

                        ModelInner = null

                    }
                );

                expected.Add(
                    703837013,
                    new Int16smallint0M
                    {
                        Id = 703837013,
                        Value = 30839,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1315953990,
                            Value = 19509,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    742353542,
                    new Int16smallint0M
                    {
                        Id = 742353542,
                        Value = 14554,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    944074750,
                    new Int16smallint0M
                    {
                        Id = 944074750,
                        Value = 15950,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1144500183,
                            Value = 25256,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    954026688,
                    new Int16smallint0M
                    {
                        Id = 954026688,
                        Value = 28815,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1074252540,
                            Value = 3710,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1161084701,
                    new Int16smallint0M
                    {
                        Id = 1161084701,
                        Value = 6091,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1410974813,
                            Value = 30090,
                            NullableValue = 22560
                        }

                    }
                );

                expected.Add(
                    1189822788,
                    new Int16smallint0M
                    {
                        Id = 1189822788,
                        Value = 9797,
                        NullableValue = 10663,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1306255703,
                    new Int16smallint0M
                    {
                        Id = 1306255703,
                        Value = 8234,
                        NullableValue = 6249,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1403514121,
                    new Int16smallint0M
                    {
                        Id = 1403514121,
                        Value = 28701,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1265191147,
                            Value = 26156,
                            NullableValue = 11195
                        }

                    }
                );

                expected.Add(
                    1421023382,
                    new Int16smallint0M
                    {
                        Id = 1421023382,
                        Value = 7175,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 2046085109,
                            Value = 19974,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1467005059,
                    new Int16smallint0M
                    {
                        Id = 1467005059,
                        Value = 31719,
                        NullableValue = 29857,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1556778174,
                    new Int16smallint0M
                    {
                        Id = 1556778174,
                        Value = 5125,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1887755955,
                            Value = 19584,
                            NullableValue = 9893
                        }

                    }
                );

                expected.Add(
                    1651613554,
                    new Int16smallint0M
                    {
                        Id = 1651613554,
                        Value = 15207,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1597822046,
                            Value = 6269,
                            NullableValue = 22976
                        }

                    }
                );

                expected.Add(
                    1726376327,
                    new Int16smallint0M
                    {
                        Id = 1726376327,
                        Value = 32500,
                        NullableValue = 30552,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1869641560,
                    new Int16smallint0M
                    {
                        Id = 1869641560,
                        Value = 8695,
                        NullableValue = null,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1464576410,
                            Value = 24420,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1894052972,
                    new Int16smallint0M
                    {
                        Id = 1894052972,
                        Value = 21585,
                        NullableValue = 5661,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1985075637,
                    new Int16smallint0M
                    {
                        Id = 1985075637,
                        Value = 1629,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2080361755,
                    new Int16smallint0M
                    {
                        Id = 2080361755,
                        Value = 32704,
                        NullableValue = 12956,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 1114614418,
                            Value = 15570,
                            NullableValue = 10936
                        }

                    }
                );

                expected.Add(
                    2147231950,
                    new Int16smallint0M
                    {
                        Id = 2147231950,
                        Value = 6395,
                        NullableValue = 5672,

                        ModelInner = new Int16smallint0MI
                        {
                            Id = 101655635,
                            Value = 22277,
                            NullableValue = 29289
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int16)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Int16smallint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
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

                var expected = new Dictionary<System.Int32,Int16smallint0MI>(15);

                expected.Add(
                    101655635,
                    new Int16smallint0MI
                    {
                        Id = 101655635,
                        Value = 22277,
                        NullableValue = 29289
                    }
                );

                expected.Add(
                    1074252540,
                    new Int16smallint0MI
                    {
                        Id = 1074252540,
                        Value = 3710,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1114614418,
                    new Int16smallint0MI
                    {
                        Id = 1114614418,
                        Value = 15570,
                        NullableValue = 10936
                    }
                );

                expected.Add(
                    1144500183,
                    new Int16smallint0MI
                    {
                        Id = 1144500183,
                        Value = 25256,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1175260151,
                    new Int16smallint0MI
                    {
                        Id = 1175260151,
                        Value = 30357,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1265191147,
                    new Int16smallint0MI
                    {
                        Id = 1265191147,
                        Value = 26156,
                        NullableValue = 11195
                    }
                );

                expected.Add(
                    1315953990,
                    new Int16smallint0MI
                    {
                        Id = 1315953990,
                        Value = 19509,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1344863697,
                    new Int16smallint0MI
                    {
                        Id = 1344863697,
                        Value = 25253,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1410974813,
                    new Int16smallint0MI
                    {
                        Id = 1410974813,
                        Value = 30090,
                        NullableValue = 22560
                    }
                );

                expected.Add(
                    1464576410,
                    new Int16smallint0MI
                    {
                        Id = 1464576410,
                        Value = 24420,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1575272793,
                    new Int16smallint0MI
                    {
                        Id = 1575272793,
                        Value = 10733,
                        NullableValue = 29333
                    }
                );

                expected.Add(
                    1597822046,
                    new Int16smallint0MI
                    {
                        Id = 1597822046,
                        Value = 6269,
                        NullableValue = 22976
                    }
                );

                expected.Add(
                    1617788475,
                    new Int16smallint0MI
                    {
                        Id = 1617788475,
                        Value = 27893,
                        NullableValue = 31128
                    }
                );

                expected.Add(
                    1887755955,
                    new Int16smallint0MI
                    {
                        Id = 1887755955,
                        Value = 19584,
                        NullableValue = 9893
                    }
                );

                expected.Add(
                    2046085109,
                    new Int16smallint0MI
                    {
                        Id = 2046085109,
                        Value = 19974,
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

                var expected = new Dictionary<System.Int32,Int16smallint0MI>(15);

                expected.Add(
                    101655635,
                    new Int16smallint0MI
                    {
                        Id = 101655635,
                        Value = 22277,
                        NullableValue = 29289
                    }
                );

                expected.Add(
                    1074252540,
                    new Int16smallint0MI
                    {
                        Id = 1074252540,
                        Value = 3710,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1114614418,
                    new Int16smallint0MI
                    {
                        Id = 1114614418,
                        Value = 15570,
                        NullableValue = 10936
                    }
                );

                expected.Add(
                    1144500183,
                    new Int16smallint0MI
                    {
                        Id = 1144500183,
                        Value = 25256,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1175260151,
                    new Int16smallint0MI
                    {
                        Id = 1175260151,
                        Value = 30357,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1265191147,
                    new Int16smallint0MI
                    {
                        Id = 1265191147,
                        Value = 26156,
                        NullableValue = 11195
                    }
                );

                expected.Add(
                    1315953990,
                    new Int16smallint0MI
                    {
                        Id = 1315953990,
                        Value = 19509,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1344863697,
                    new Int16smallint0MI
                    {
                        Id = 1344863697,
                        Value = 25253,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1410974813,
                    new Int16smallint0MI
                    {
                        Id = 1410974813,
                        Value = 30090,
                        NullableValue = 22560
                    }
                );

                expected.Add(
                    1464576410,
                    new Int16smallint0MI
                    {
                        Id = 1464576410,
                        Value = 24420,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1575272793,
                    new Int16smallint0MI
                    {
                        Id = 1575272793,
                        Value = 10733,
                        NullableValue = 29333
                    }
                );

                expected.Add(
                    1597822046,
                    new Int16smallint0MI
                    {
                        Id = 1597822046,
                        Value = 6269,
                        NullableValue = 22976
                    }
                );

                expected.Add(
                    1617788475,
                    new Int16smallint0MI
                    {
                        Id = 1617788475,
                        Value = 27893,
                        NullableValue = 31128
                    }
                );

                expected.Add(
                    1887755955,
                    new Int16smallint0MI
                    {
                        Id = 1887755955,
                        Value = 19584,
                        NullableValue = 9893
                    }
                );

                expected.Add(
                    2046085109,
                    new Int16smallint0MI
                    {
                        Id = 2046085109,
                        Value = 19974,
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




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
    internal partial interface ISByteSingleTypesmallint
    {
    }
    
    internal partial class SByteSingleTypesmallint : ISByteSingleTypesmallint
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0mi(
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
            asPartInterface: typeof(ISByteSingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
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
INSERT INTO public.sbytesmallint0mi(
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
            queryMapType: typeof(SBytesmallint0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
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

                changedRows =  ((ISByteSingleTypesmallint)this).InsertModelInner(connection, 971967022, 33, 31);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteSingleTypesmallint)this).InsertModelInner(connection, 1265080379, 63, null);
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

                changedRows = await ((ISByteSingleTypesmallint)this).InsertModelInnerAsync(connection, 1835933357, -8, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).InsertModelInnerAsync(connection, 432979716, -81, null);
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

                id =  ((ISByteSingleTypesmallint)this).InsertModelInnerReturning(connection, 442236803, 86, null);
                Assert.That(id, Is.EqualTo(442236803));

                id =  ((ISByteSingleTypesmallint)this).InsertModelInnerReturning(connection, 127303628, 14, -17);
                Assert.That(id, Is.EqualTo(127303628));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ISByteSingleTypesmallint)this).InsertModelInnerReturningAsync(connection, 258819378, 124, null);
                Assert.That(id, Is.EqualTo(258819378));

                id = await ((ISByteSingleTypesmallint)this).InsertModelInnerReturningAsync(connection, 156344795, 20, -78);
                Assert.That(id, Is.EqualTo(156344795));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0mi(
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
            asPartInterface: typeof(ISByteSingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
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

                changedRows =  ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModel(connection, 2103764620, 73, -8);
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

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 974877637, 114, -2);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 2106414005, 11, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1937548498, -45, -65);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1774381389, 94, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1674725044, -29, 115);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1005760907, -54, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0m(
	id,
    value,
    nullablevalue,
    sbytesmallint0mi_id
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
            asPartInterface: typeof(ISByteSingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallint0mi_id", 
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

                changedRows =  ((ISByteSingleTypesmallint)this).InsertModel(connection, 1608605200, 41, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteSingleTypesmallint)this).InsertModel(connection, 140034262, -108, null, 971967022);
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

                changedRows = await ((ISByteSingleTypesmallint)this).InsertModelAsync(connection, 1442990201, 62, 19, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).InsertModelAsync(connection, 318502857, -91, null, 1265080379);
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
INSERT INTO public.sbytesmallint0m(
	id,
    value,
    nullablevalue,
    sbytesmallint0mi_id
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
    sbytesmallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(SBytesmallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallint0mi_id", 
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
                List<SBytesmallint0M> models = null;
                SBytesmallint0M model = null;

                models =  ((ISByteSingleTypesmallint)this).InsertModelReturning(connection, 1871367431, -66, 25, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ISByteSingleTypesmallint)this).InsertModelReturning(connection, 1726882567, -94, null, 1835933357).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.SByte)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ISByteSingleTypesmallint)this).InsertModelReturning(connection, 1022159419, 41, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ISByteSingleTypesmallint)this).InsertModelReturning(connection, 782930550, 106, 108, 432979716).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.SByte)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SBytesmallint0M> models = null;
                SBytesmallint0M model = null;

                models = await ((ISByteSingleTypesmallint)this).InsertModelReturningAsync(connection, 1417915646, 71, -70, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ISByteSingleTypesmallint)this).InsertModelReturningAsync(connection, 722124568, 61, null, 442236803).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722124568));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(442236803));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.SByte)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISByteSingleTypesmallint)this).InsertModelReturningAsync(connection, 1932838672, -23, -80, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ISByteSingleTypesmallint)this).InsertModelReturningAsync(connection, 2128616314, -94, null, 127303628).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.SByte)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0m(
	id,
    value,
    nullablevalue,
    sbytesmallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @sbytesmallint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.SByte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "sbytesmallint0mi_id", 
                methodParametrName: "sbytesmallint0mi_id", 
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

                changedRows =  ((ISByteSingleTypesmallint)this).DbConnectionInsertModel(connection, 1072539075, -90, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteSingleTypesmallint)this).DbConnectionInsertModel(connection, 1776220748, 75, null, 258819378);
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

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1436248052, 92, 82, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 721616991, -49, null, 156344795);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1503672069, 89, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 970203208, 71, -82, 2103764620);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 389228452, -11, 118, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 98367347, 49, null, 974877637);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 876037525, 101, 1, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 795468198, -26, null, 2106414005);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 64245469, 68, 119, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 157315968, -126, 22, 1937548498);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 915887454, 97, 107, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 825629070, -17, -71, 1774381389);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 661880103, 39, 79, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1598689388, 10, -41, 1674725044);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1051819503, -100, -75, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 329014458, -9, null, 1005760907);
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
FROM public.sbytesmallint0m m
LEFT JOIN public.sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(SBytesmallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)
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
                var models =  ((ISByteSingleTypesmallint)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(64245469));
                Assert.That(model.Value, Is.EqualTo(68));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(119));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98367347));
                Assert.That(model.Value, Is.EqualTo(49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(974877637));

                Assert.That(model.ModelInner.Value, Is.EqualTo(114));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-2));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140034262));
                Assert.That(model.Value, Is.EqualTo(-108));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(971967022));

                Assert.That(model.ModelInner.Value, Is.EqualTo(33));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(157315968));
                Assert.That(model.Value, Is.EqualTo(-126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(22));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937548498));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-45));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-65));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318502857));
                Assert.That(model.Value, Is.EqualTo(-91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265080379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(63));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329014458));
                Assert.That(model.Value, Is.EqualTo(-9));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005760907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-54));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389228452));
                Assert.That(model.Value, Is.EqualTo(-11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(118));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661880103));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616991));
                Assert.That(model.Value, Is.EqualTo(-49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(156344795));

                Assert.That(model.ModelInner.Value, Is.EqualTo(20));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-78));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722124568));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(442236803));

                Assert.That(model.ModelInner.Value, Is.EqualTo(86));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-81));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795468198));
                Assert.That(model.Value, Is.EqualTo(-26));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106414005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(11));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825629070));
                Assert.That(model.Value, Is.EqualTo(-17));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-71));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774381389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(94));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876037525));
                Assert.That(model.Value, Is.EqualTo(101));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915887454));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(107));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970203208));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-82));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2103764620));

                Assert.That(model.ModelInner.Value, Is.EqualTo(73));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-8));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteSingleTypesmallint)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(64245469));
                Assert.That(model.Value, Is.EqualTo(68));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(119));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98367347));
                Assert.That(model.Value, Is.EqualTo(49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(974877637));

                Assert.That(model.ModelInner.Value, Is.EqualTo(114));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-2));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140034262));
                Assert.That(model.Value, Is.EqualTo(-108));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(971967022));

                Assert.That(model.ModelInner.Value, Is.EqualTo(33));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(157315968));
                Assert.That(model.Value, Is.EqualTo(-126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(22));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937548498));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-45));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-65));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318502857));
                Assert.That(model.Value, Is.EqualTo(-91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265080379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(63));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329014458));
                Assert.That(model.Value, Is.EqualTo(-9));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005760907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-54));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389228452));
                Assert.That(model.Value, Is.EqualTo(-11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(118));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661880103));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616991));
                Assert.That(model.Value, Is.EqualTo(-49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(156344795));

                Assert.That(model.ModelInner.Value, Is.EqualTo(20));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-78));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722124568));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(442236803));

                Assert.That(model.ModelInner.Value, Is.EqualTo(86));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-81));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795468198));
                Assert.That(model.Value, Is.EqualTo(-26));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106414005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(11));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825629070));
                Assert.That(model.Value, Is.EqualTo(-17));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-71));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774381389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(94));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876037525));
                Assert.That(model.Value, Is.EqualTo(101));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915887454));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(107));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970203208));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-82));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2103764620));

                Assert.That(model.ModelInner.Value, Is.EqualTo(73));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-8));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

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
FROM public.sbytesmallint0m m
LEFT JOIN public.sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(SBytesmallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)
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
                var models =  ((ISByteSingleTypesmallint)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(64245469));
                Assert.That(model.Value, Is.EqualTo(68));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(119));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98367347));
                Assert.That(model.Value, Is.EqualTo(49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(974877637));

                Assert.That(model.ModelInner.Value, Is.EqualTo(114));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-2));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140034262));
                Assert.That(model.Value, Is.EqualTo(-108));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(971967022));

                Assert.That(model.ModelInner.Value, Is.EqualTo(33));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(157315968));
                Assert.That(model.Value, Is.EqualTo(-126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(22));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937548498));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-45));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-65));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318502857));
                Assert.That(model.Value, Is.EqualTo(-91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265080379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(63));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329014458));
                Assert.That(model.Value, Is.EqualTo(-9));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005760907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-54));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389228452));
                Assert.That(model.Value, Is.EqualTo(-11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(118));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661880103));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616991));
                Assert.That(model.Value, Is.EqualTo(-49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(156344795));

                Assert.That(model.ModelInner.Value, Is.EqualTo(20));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-78));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722124568));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(442236803));

                Assert.That(model.ModelInner.Value, Is.EqualTo(86));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-81));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795468198));
                Assert.That(model.Value, Is.EqualTo(-26));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106414005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(11));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825629070));
                Assert.That(model.Value, Is.EqualTo(-17));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-71));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774381389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(94));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876037525));
                Assert.That(model.Value, Is.EqualTo(101));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915887454));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(107));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970203208));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-82));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2103764620));

                Assert.That(model.ModelInner.Value, Is.EqualTo(73));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-8));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteSingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(64245469));
                Assert.That(model.Value, Is.EqualTo(68));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(119));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98367347));
                Assert.That(model.Value, Is.EqualTo(49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(974877637));

                Assert.That(model.ModelInner.Value, Is.EqualTo(114));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-2));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140034262));
                Assert.That(model.Value, Is.EqualTo(-108));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(971967022));

                Assert.That(model.ModelInner.Value, Is.EqualTo(33));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(157315968));
                Assert.That(model.Value, Is.EqualTo(-126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(22));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937548498));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-45));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-65));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318502857));
                Assert.That(model.Value, Is.EqualTo(-91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265080379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(63));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329014458));
                Assert.That(model.Value, Is.EqualTo(-9));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005760907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-54));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389228452));
                Assert.That(model.Value, Is.EqualTo(-11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(118));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661880103));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616991));
                Assert.That(model.Value, Is.EqualTo(-49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(156344795));

                Assert.That(model.ModelInner.Value, Is.EqualTo(20));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-78));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722124568));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(442236803));

                Assert.That(model.ModelInner.Value, Is.EqualTo(86));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-81));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795468198));
                Assert.That(model.Value, Is.EqualTo(-26));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106414005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(11));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825629070));
                Assert.That(model.Value, Is.EqualTo(-17));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-71));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774381389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(94));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876037525));
                Assert.That(model.Value, Is.EqualTo(101));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915887454));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(107));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970203208));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-82));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2103764620));

                Assert.That(model.ModelInner.Value, Is.EqualTo(73));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-8));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 1871367431);
                var models =  ((ISByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(2));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ISByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 1417915646);
                var models = await ((ISByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(10));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)
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
                 foreach(var batchResult in ((ISByteSingleTypesmallint)this).DbConnectionSelectModelBatch(connection, 1022159419, 722124568))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(13));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-81));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795468198));
                Assert.That(model.Value, Is.EqualTo(-26));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106414005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(11));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825629070));
                Assert.That(model.Value, Is.EqualTo(-17));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-71));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774381389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(94));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876037525));
                Assert.That(model.Value, Is.EqualTo(101));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915887454));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(107));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970203208));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-82));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2103764620));

                Assert.That(model.ModelInner.Value, Is.EqualTo(73));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-8));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

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
                await foreach(var batchResult in ((ISByteSingleTypesmallint)this).DbConnectionSelectModelBatchAsync(connection, 329014458, 915887454))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389228452));
                Assert.That(model.Value, Is.EqualTo(-11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(118));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661880103));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616991));
                Assert.That(model.Value, Is.EqualTo(-49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(156344795));

                Assert.That(model.ModelInner.Value, Is.EqualTo(20));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-78));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722124568));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(442236803));

                Assert.That(model.ModelInner.Value, Is.EqualTo(86));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-81));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795468198));
                Assert.That(model.Value, Is.EqualTo(-26));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106414005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(11));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825629070));
                Assert.That(model.Value, Is.EqualTo(-17));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-71));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774381389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(94));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876037525));
                Assert.That(model.Value, Is.EqualTo(101));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915887454));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(107));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970203208));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-82));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2103764620));

                Assert.That(model.ModelInner.Value, Is.EqualTo(73));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-8));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970203208));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-82));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2103764620));

                Assert.That(model.ModelInner.Value, Is.EqualTo(73));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-8));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));

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
FROM public.sbytesmallint0m m
LEFT JOIN public.sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
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
            asPartInterface: typeof(ISByteSingleTypesmallint)
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
                var models =  ((ISByteSingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64245469)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((68)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((119)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98367347)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((49)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((974877637)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((114)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-2)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140034262)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-108)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((971967022)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((33)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157315968)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-126)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1937548498)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-45)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-65)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((22)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((318502857)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1265080379)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((63)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((329014458)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-9)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1005760907)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-54)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((389228452)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-11)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((118)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((661880103)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((39)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((79)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((721616991)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-49)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((156344795)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((20)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-78)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((722124568)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((61)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((442236803)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((86)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((782930550)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((106)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((432979716)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-81)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((108)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((795468198)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-26)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2106414005)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((11)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((825629070)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-17)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1774381389)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((94)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((-71)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((876037525)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((101)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((915887454)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((97)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((107)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((970203208)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((71)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2103764620)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((73)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-8)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-82)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1022159419)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((41)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1051819503)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-100)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-75)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1072539075)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-90)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1417915646)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((71)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-70)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1436248052)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((92)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((82)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1442990201)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((62)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1503672069)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((89)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1598689388)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1674725044)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-29)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((115)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-41)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1608605200)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((41)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1726882567)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-94)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1835933357)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-8)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1776220748)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((75)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((258819378)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((124)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1871367431)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-66)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1932838672)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-23)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-80)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2128616314)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-94)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((127303628)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-17)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteSingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64245469)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((68)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((119)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98367347)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((49)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((974877637)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((114)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-2)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140034262)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-108)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((971967022)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((33)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157315968)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-126)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1937548498)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-45)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-65)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((22)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((318502857)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1265080379)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((63)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((329014458)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-9)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1005760907)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-54)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((389228452)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-11)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((118)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((661880103)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((39)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((79)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((721616991)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-49)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((156344795)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((20)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-78)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((722124568)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((61)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((442236803)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((86)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((782930550)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((106)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((432979716)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-81)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((108)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((795468198)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-26)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2106414005)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((11)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((825629070)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-17)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1774381389)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((94)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((-71)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((876037525)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((101)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((915887454)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((97)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((107)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((970203208)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((71)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2103764620)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((73)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-8)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-82)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1022159419)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((41)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1051819503)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-100)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-75)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1072539075)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-90)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1417915646)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((71)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-70)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1436248052)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((92)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((82)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1442990201)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((62)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1503672069)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((89)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1598689388)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1674725044)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-29)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((115)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-41)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1608605200)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((41)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1726882567)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-94)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1835933357)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-8)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1776220748)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((75)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((258819378)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((124)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1871367431)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-66)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1932838672)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-23)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-80)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2128616314)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-94)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((127303628)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-17)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SBytesmallint0MI),
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
FROM public.binary_sbytesmallint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(SBytesmallint0MI),
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

                var importCollection = new List<SBytesmallint0MI>(7);

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 127303628,
                    Value = 14,
                    NullableValue = -17
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 156344795,
                    Value = 20,
                    NullableValue = -78
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 258819378,
                    Value = 124,
                    NullableValue = null
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 432979716,
                    Value = -81,
                    NullableValue = null
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 442236803,
                    Value = 86,
                    NullableValue = null
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 971967022,
                    Value = 33,
                    NullableValue = 31
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 974877637,
                    Value = 114,
                    NullableValue = -2
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(127303628));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-17));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(156344795));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-78));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258819378));
                Assert.That(model.Value, Is.EqualTo(124));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432979716));
                Assert.That(model.Value, Is.EqualTo(-81));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(442236803));
                Assert.That(model.Value, Is.EqualTo(86));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971967022));
                Assert.That(model.Value, Is.EqualTo(33));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(31));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(974877637));
                Assert.That(model.Value, Is.EqualTo(114));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-2));

                importCollection.Clear();

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 1005760907,
                    Value = -54,
                    NullableValue = null
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 1265080379,
                    Value = 63,
                    NullableValue = null
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 1674725044,
                    Value = -29,
                    NullableValue = 115
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 1774381389,
                    Value = 94,
                    NullableValue = null
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 1835933357,
                    Value = -8,
                    NullableValue = null
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 1937548498,
                    Value = -45,
                    NullableValue = -65
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 2103764620,
                    Value = 73,
                    NullableValue = -8
                });

                importCollection.Add(
                new SBytesmallint0MI
                {
                    Id = 2106414005,
                    Value = 11,
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(127303628));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-17));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(156344795));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-78));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258819378));
                Assert.That(model.Value, Is.EqualTo(124));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(432979716));
                Assert.That(model.Value, Is.EqualTo(-81));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(442236803));
                Assert.That(model.Value, Is.EqualTo(86));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971967022));
                Assert.That(model.Value, Is.EqualTo(33));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(31));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(974877637));
                Assert.That(model.Value, Is.EqualTo(114));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-2));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1005760907));
                Assert.That(model.Value, Is.EqualTo(-54));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1265080379));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1674725044));
                Assert.That(model.Value, Is.EqualTo(-29));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(115));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1774381389));
                Assert.That(model.Value, Is.EqualTo(94));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1835933357));
                Assert.That(model.Value, Is.EqualTo(-8));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937548498));
                Assert.That(model.Value, Is.EqualTo(-45));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-65));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103764620));
                Assert.That(model.Value, Is.EqualTo(73));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-8));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2106414005));
                Assert.That(model.Value, Is.EqualTo(11));

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
sbytesmallint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SBytesmallint0M),
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
FROM public.binary_sbytesmallint0m m
LEFT JOIN public.binary_sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(SBytesmallint0M),
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

                var importCollection = new List<SBytesmallint0M>(15);

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 64245469,
                    Value = 68,
                    NullableValue = 119,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 98367347,
                    Value = 49,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 974877637
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 140034262,
                    Value = -108,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 971967022
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 157315968,
                    Value = -126,
                    NullableValue = 22,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 1937548498
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 318502857,
                    Value = -91,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 1265080379
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 329014458,
                    Value = -9,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 1005760907
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 389228452,
                    Value = -11,
                    NullableValue = 118,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 661880103,
                    Value = 39,
                    NullableValue = 79,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 721616991,
                    Value = -49,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 156344795
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 722124568,
                    Value = 61,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 442236803
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 782930550,
                    Value = 106,
                    NullableValue = 108,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 432979716
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 795468198,
                    Value = -26,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 2106414005
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 825629070,
                    Value = -17,
                    NullableValue = -71,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 1774381389
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 876037525,
                    Value = 101,
                    NullableValue = 1,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 915887454,
                    Value = 97,
                    NullableValue = 107,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(64245469));
                Assert.That(model.Value, Is.EqualTo(68));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(119));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98367347));
                Assert.That(model.Value, Is.EqualTo(49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(974877637));

                Assert.That(model.ModelInner.Value, Is.EqualTo(114));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-2));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140034262));
                Assert.That(model.Value, Is.EqualTo(-108));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(971967022));

                Assert.That(model.ModelInner.Value, Is.EqualTo(33));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(157315968));
                Assert.That(model.Value, Is.EqualTo(-126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(22));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937548498));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-45));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-65));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318502857));
                Assert.That(model.Value, Is.EqualTo(-91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265080379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(63));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329014458));
                Assert.That(model.Value, Is.EqualTo(-9));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005760907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-54));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389228452));
                Assert.That(model.Value, Is.EqualTo(-11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(118));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661880103));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616991));
                Assert.That(model.Value, Is.EqualTo(-49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(156344795));

                Assert.That(model.ModelInner.Value, Is.EqualTo(20));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-78));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722124568));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(442236803));

                Assert.That(model.ModelInner.Value, Is.EqualTo(86));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-81));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795468198));
                Assert.That(model.Value, Is.EqualTo(-26));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106414005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(11));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825629070));
                Assert.That(model.Value, Is.EqualTo(-17));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-71));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774381389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(94));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876037525));
                Assert.That(model.Value, Is.EqualTo(101));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915887454));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(107));

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 970203208,
                    Value = 71,
                    NullableValue = -82,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 2103764620
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1022159419,
                    Value = 41,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1051819503,
                    Value = -100,
                    NullableValue = -75,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1072539075,
                    Value = -90,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1417915646,
                    Value = 71,
                    NullableValue = -70,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1436248052,
                    Value = 92,
                    NullableValue = 82,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1442990201,
                    Value = 62,
                    NullableValue = 19,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1503672069,
                    Value = 89,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1598689388,
                    Value = 10,
                    NullableValue = -41,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 1674725044
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1608605200,
                    Value = 41,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1726882567,
                    Value = -94,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 1835933357
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1776220748,
                    Value = 75,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 258819378
                    }

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1871367431,
                    Value = -66,
                    NullableValue = 25,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 1932838672,
                    Value = -23,
                    NullableValue = -80,

                    ModelInner = null

                });

                importCollection.Add(
                new SBytesmallint0M
                {
                    Id = 2128616314,
                    Value = -94,
                    NullableValue = null,

                    ModelInner = new SBytesmallint0MI 
                    {
                        Id = 127303628
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(64245469));
                Assert.That(model.Value, Is.EqualTo(68));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(119));

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98367347));
                Assert.That(model.Value, Is.EqualTo(49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(974877637));

                Assert.That(model.ModelInner.Value, Is.EqualTo(114));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-2));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140034262));
                Assert.That(model.Value, Is.EqualTo(-108));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(971967022));

                Assert.That(model.ModelInner.Value, Is.EqualTo(33));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(31));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(157315968));
                Assert.That(model.Value, Is.EqualTo(-126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(22));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937548498));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-45));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-65));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318502857));
                Assert.That(model.Value, Is.EqualTo(-91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1265080379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(63));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329014458));
                Assert.That(model.Value, Is.EqualTo(-9));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005760907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-54));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389228452));
                Assert.That(model.Value, Is.EqualTo(-11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(118));

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661880103));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79));

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616991));
                Assert.That(model.Value, Is.EqualTo(-49));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(156344795));

                Assert.That(model.ModelInner.Value, Is.EqualTo(20));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-78));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(722124568));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(442236803));

                Assert.That(model.ModelInner.Value, Is.EqualTo(86));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(782930550));
                Assert.That(model.Value, Is.EqualTo(106));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(108));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(432979716));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-81));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795468198));
                Assert.That(model.Value, Is.EqualTo(-26));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106414005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(11));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825629070));
                Assert.That(model.Value, Is.EqualTo(-17));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-71));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774381389));

                Assert.That(model.ModelInner.Value, Is.EqualTo(94));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876037525));
                Assert.That(model.Value, Is.EqualTo(101));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1));

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915887454));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(107));

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970203208));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-82));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2103764620));

                Assert.That(model.ModelInner.Value, Is.EqualTo(73));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-8));


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022159419));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051819503));
                Assert.That(model.Value, Is.EqualTo(-100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-75));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1072539075));
                Assert.That(model.Value, Is.EqualTo(-90));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1417915646));
                Assert.That(model.Value, Is.EqualTo(71));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-70));

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436248052));
                Assert.That(model.Value, Is.EqualTo(92));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(82));

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1442990201));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(19));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503672069));
                Assert.That(model.Value, Is.EqualTo(89));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1598689388));
                Assert.That(model.Value, Is.EqualTo(10));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-41));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1674725044));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-29));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(115));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608605200));
                Assert.That(model.Value, Is.EqualTo(41));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1726882567));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1835933357));

                Assert.That(model.ModelInner.Value, Is.EqualTo(-8));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1776220748));
                Assert.That(model.Value, Is.EqualTo(75));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258819378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(124));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1871367431));
                Assert.That(model.Value, Is.EqualTo(-66));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(25));

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932838672));
                Assert.That(model.Value, Is.EqualTo(-23));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(-80));

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2128616314));
                Assert.That(model.Value, Is.EqualTo(-94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(127303628));

                Assert.That(model.ModelInner.Value, Is.EqualTo(14));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(-17));


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    sbytesmallint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(SBytesmallint0M),
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

                var expected = new Dictionary<System.Int32,SBytesmallint0M>(30);

                expected.Add(
                    64245469,
                    new SBytesmallint0M
                    {
                        Id = 64245469,
                        Value = 68,
                        NullableValue = 119,

                        ModelInner = null

                    }
                );

                expected.Add(
                    98367347,
                    new SBytesmallint0M
                    {
                        Id = 98367347,
                        Value = 49,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 974877637,
                            Value = 114,
                            NullableValue = -2
                        }

                    }
                );

                expected.Add(
                    140034262,
                    new SBytesmallint0M
                    {
                        Id = 140034262,
                        Value = -108,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 971967022,
                            Value = 33,
                            NullableValue = 31
                        }

                    }
                );

                expected.Add(
                    157315968,
                    new SBytesmallint0M
                    {
                        Id = 157315968,
                        Value = -126,
                        NullableValue = 22,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1937548498,
                            Value = -45,
                            NullableValue = -65
                        }

                    }
                );

                expected.Add(
                    318502857,
                    new SBytesmallint0M
                    {
                        Id = 318502857,
                        Value = -91,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1265080379,
                            Value = 63,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    329014458,
                    new SBytesmallint0M
                    {
                        Id = 329014458,
                        Value = -9,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1005760907,
                            Value = -54,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    389228452,
                    new SBytesmallint0M
                    {
                        Id = 389228452,
                        Value = -11,
                        NullableValue = 118,

                        ModelInner = null

                    }
                );

                expected.Add(
                    661880103,
                    new SBytesmallint0M
                    {
                        Id = 661880103,
                        Value = 39,
                        NullableValue = 79,

                        ModelInner = null

                    }
                );

                expected.Add(
                    721616991,
                    new SBytesmallint0M
                    {
                        Id = 721616991,
                        Value = -49,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 156344795,
                            Value = 20,
                            NullableValue = -78
                        }

                    }
                );

                expected.Add(
                    722124568,
                    new SBytesmallint0M
                    {
                        Id = 722124568,
                        Value = 61,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 442236803,
                            Value = 86,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    782930550,
                    new SBytesmallint0M
                    {
                        Id = 782930550,
                        Value = 106,
                        NullableValue = 108,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 432979716,
                            Value = -81,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    795468198,
                    new SBytesmallint0M
                    {
                        Id = 795468198,
                        Value = -26,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 2106414005,
                            Value = 11,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    825629070,
                    new SBytesmallint0M
                    {
                        Id = 825629070,
                        Value = -17,
                        NullableValue = -71,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1774381389,
                            Value = 94,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    876037525,
                    new SBytesmallint0M
                    {
                        Id = 876037525,
                        Value = 101,
                        NullableValue = 1,

                        ModelInner = null

                    }
                );

                expected.Add(
                    915887454,
                    new SBytesmallint0M
                    {
                        Id = 915887454,
                        Value = 97,
                        NullableValue = 107,

                        ModelInner = null

                    }
                );

                expected.Add(
                    970203208,
                    new SBytesmallint0M
                    {
                        Id = 970203208,
                        Value = 71,
                        NullableValue = -82,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 2103764620,
                            Value = 73,
                            NullableValue = -8
                        }

                    }
                );

                expected.Add(
                    1022159419,
                    new SBytesmallint0M
                    {
                        Id = 1022159419,
                        Value = 41,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1051819503,
                    new SBytesmallint0M
                    {
                        Id = 1051819503,
                        Value = -100,
                        NullableValue = -75,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1072539075,
                    new SBytesmallint0M
                    {
                        Id = 1072539075,
                        Value = -90,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1417915646,
                    new SBytesmallint0M
                    {
                        Id = 1417915646,
                        Value = 71,
                        NullableValue = -70,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1436248052,
                    new SBytesmallint0M
                    {
                        Id = 1436248052,
                        Value = 92,
                        NullableValue = 82,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1442990201,
                    new SBytesmallint0M
                    {
                        Id = 1442990201,
                        Value = 62,
                        NullableValue = 19,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1503672069,
                    new SBytesmallint0M
                    {
                        Id = 1503672069,
                        Value = 89,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1598689388,
                    new SBytesmallint0M
                    {
                        Id = 1598689388,
                        Value = 10,
                        NullableValue = -41,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1674725044,
                            Value = -29,
                            NullableValue = 115
                        }

                    }
                );

                expected.Add(
                    1608605200,
                    new SBytesmallint0M
                    {
                        Id = 1608605200,
                        Value = 41,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1726882567,
                    new SBytesmallint0M
                    {
                        Id = 1726882567,
                        Value = -94,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1835933357,
                            Value = -8,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1776220748,
                    new SBytesmallint0M
                    {
                        Id = 1776220748,
                        Value = 75,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 258819378,
                            Value = 124,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1871367431,
                    new SBytesmallint0M
                    {
                        Id = 1871367431,
                        Value = -66,
                        NullableValue = 25,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1932838672,
                    new SBytesmallint0M
                    {
                        Id = 1932838672,
                        Value = -23,
                        NullableValue = -80,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2128616314,
                    new SBytesmallint0M
                    {
                        Id = 2128616314,
                        Value = -94,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 127303628,
                            Value = 14,
                            NullableValue = -17
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.SByte)default));
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

                var expected = new Dictionary<System.Int32,SBytesmallint0M>(30);

                expected.Add(
                    64245469,
                    new SBytesmallint0M
                    {
                        Id = 64245469,
                        Value = 68,
                        NullableValue = 119,

                        ModelInner = null

                    }
                );

                expected.Add(
                    98367347,
                    new SBytesmallint0M
                    {
                        Id = 98367347,
                        Value = 49,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 974877637,
                            Value = 114,
                            NullableValue = -2
                        }

                    }
                );

                expected.Add(
                    140034262,
                    new SBytesmallint0M
                    {
                        Id = 140034262,
                        Value = -108,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 971967022,
                            Value = 33,
                            NullableValue = 31
                        }

                    }
                );

                expected.Add(
                    157315968,
                    new SBytesmallint0M
                    {
                        Id = 157315968,
                        Value = -126,
                        NullableValue = 22,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1937548498,
                            Value = -45,
                            NullableValue = -65
                        }

                    }
                );

                expected.Add(
                    318502857,
                    new SBytesmallint0M
                    {
                        Id = 318502857,
                        Value = -91,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1265080379,
                            Value = 63,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    329014458,
                    new SBytesmallint0M
                    {
                        Id = 329014458,
                        Value = -9,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1005760907,
                            Value = -54,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    389228452,
                    new SBytesmallint0M
                    {
                        Id = 389228452,
                        Value = -11,
                        NullableValue = 118,

                        ModelInner = null

                    }
                );

                expected.Add(
                    661880103,
                    new SBytesmallint0M
                    {
                        Id = 661880103,
                        Value = 39,
                        NullableValue = 79,

                        ModelInner = null

                    }
                );

                expected.Add(
                    721616991,
                    new SBytesmallint0M
                    {
                        Id = 721616991,
                        Value = -49,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 156344795,
                            Value = 20,
                            NullableValue = -78
                        }

                    }
                );

                expected.Add(
                    722124568,
                    new SBytesmallint0M
                    {
                        Id = 722124568,
                        Value = 61,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 442236803,
                            Value = 86,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    782930550,
                    new SBytesmallint0M
                    {
                        Id = 782930550,
                        Value = 106,
                        NullableValue = 108,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 432979716,
                            Value = -81,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    795468198,
                    new SBytesmallint0M
                    {
                        Id = 795468198,
                        Value = -26,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 2106414005,
                            Value = 11,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    825629070,
                    new SBytesmallint0M
                    {
                        Id = 825629070,
                        Value = -17,
                        NullableValue = -71,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1774381389,
                            Value = 94,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    876037525,
                    new SBytesmallint0M
                    {
                        Id = 876037525,
                        Value = 101,
                        NullableValue = 1,

                        ModelInner = null

                    }
                );

                expected.Add(
                    915887454,
                    new SBytesmallint0M
                    {
                        Id = 915887454,
                        Value = 97,
                        NullableValue = 107,

                        ModelInner = null

                    }
                );

                expected.Add(
                    970203208,
                    new SBytesmallint0M
                    {
                        Id = 970203208,
                        Value = 71,
                        NullableValue = -82,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 2103764620,
                            Value = 73,
                            NullableValue = -8
                        }

                    }
                );

                expected.Add(
                    1022159419,
                    new SBytesmallint0M
                    {
                        Id = 1022159419,
                        Value = 41,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1051819503,
                    new SBytesmallint0M
                    {
                        Id = 1051819503,
                        Value = -100,
                        NullableValue = -75,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1072539075,
                    new SBytesmallint0M
                    {
                        Id = 1072539075,
                        Value = -90,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1417915646,
                    new SBytesmallint0M
                    {
                        Id = 1417915646,
                        Value = 71,
                        NullableValue = -70,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1436248052,
                    new SBytesmallint0M
                    {
                        Id = 1436248052,
                        Value = 92,
                        NullableValue = 82,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1442990201,
                    new SBytesmallint0M
                    {
                        Id = 1442990201,
                        Value = 62,
                        NullableValue = 19,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1503672069,
                    new SBytesmallint0M
                    {
                        Id = 1503672069,
                        Value = 89,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1598689388,
                    new SBytesmallint0M
                    {
                        Id = 1598689388,
                        Value = 10,
                        NullableValue = -41,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1674725044,
                            Value = -29,
                            NullableValue = 115
                        }

                    }
                );

                expected.Add(
                    1608605200,
                    new SBytesmallint0M
                    {
                        Id = 1608605200,
                        Value = 41,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1726882567,
                    new SBytesmallint0M
                    {
                        Id = 1726882567,
                        Value = -94,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 1835933357,
                            Value = -8,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1776220748,
                    new SBytesmallint0M
                    {
                        Id = 1776220748,
                        Value = 75,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 258819378,
                            Value = 124,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1871367431,
                    new SBytesmallint0M
                    {
                        Id = 1871367431,
                        Value = -66,
                        NullableValue = 25,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1932838672,
                    new SBytesmallint0M
                    {
                        Id = 1932838672,
                        Value = -23,
                        NullableValue = -80,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2128616314,
                    new SBytesmallint0M
                    {
                        Id = 2128616314,
                        Value = -94,
                        NullableValue = null,

                        ModelInner = new SBytesmallint0MI
                        {
                            Id = 127303628,
                            Value = 14,
                            NullableValue = -17
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.SByte)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(SBytesmallint0MI),
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

                var expected = new Dictionary<System.Int32,SBytesmallint0MI>(15);

                expected.Add(
                    127303628,
                    new SBytesmallint0MI
                    {
                        Id = 127303628,
                        Value = 14,
                        NullableValue = -17
                    }
                );

                expected.Add(
                    156344795,
                    new SBytesmallint0MI
                    {
                        Id = 156344795,
                        Value = 20,
                        NullableValue = -78
                    }
                );

                expected.Add(
                    258819378,
                    new SBytesmallint0MI
                    {
                        Id = 258819378,
                        Value = 124,
                        NullableValue = null
                    }
                );

                expected.Add(
                    432979716,
                    new SBytesmallint0MI
                    {
                        Id = 432979716,
                        Value = -81,
                        NullableValue = null
                    }
                );

                expected.Add(
                    442236803,
                    new SBytesmallint0MI
                    {
                        Id = 442236803,
                        Value = 86,
                        NullableValue = null
                    }
                );

                expected.Add(
                    971967022,
                    new SBytesmallint0MI
                    {
                        Id = 971967022,
                        Value = 33,
                        NullableValue = 31
                    }
                );

                expected.Add(
                    974877637,
                    new SBytesmallint0MI
                    {
                        Id = 974877637,
                        Value = 114,
                        NullableValue = -2
                    }
                );

                expected.Add(
                    1005760907,
                    new SBytesmallint0MI
                    {
                        Id = 1005760907,
                        Value = -54,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1265080379,
                    new SBytesmallint0MI
                    {
                        Id = 1265080379,
                        Value = 63,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1674725044,
                    new SBytesmallint0MI
                    {
                        Id = 1674725044,
                        Value = -29,
                        NullableValue = 115
                    }
                );

                expected.Add(
                    1774381389,
                    new SBytesmallint0MI
                    {
                        Id = 1774381389,
                        Value = 94,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1835933357,
                    new SBytesmallint0MI
                    {
                        Id = 1835933357,
                        Value = -8,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1937548498,
                    new SBytesmallint0MI
                    {
                        Id = 1937548498,
                        Value = -45,
                        NullableValue = -65
                    }
                );

                expected.Add(
                    2103764620,
                    new SBytesmallint0MI
                    {
                        Id = 2103764620,
                        Value = 73,
                        NullableValue = -8
                    }
                );

                expected.Add(
                    2106414005,
                    new SBytesmallint0MI
                    {
                        Id = 2106414005,
                        Value = 11,
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

                var expected = new Dictionary<System.Int32,SBytesmallint0MI>(15);

                expected.Add(
                    127303628,
                    new SBytesmallint0MI
                    {
                        Id = 127303628,
                        Value = 14,
                        NullableValue = -17
                    }
                );

                expected.Add(
                    156344795,
                    new SBytesmallint0MI
                    {
                        Id = 156344795,
                        Value = 20,
                        NullableValue = -78
                    }
                );

                expected.Add(
                    258819378,
                    new SBytesmallint0MI
                    {
                        Id = 258819378,
                        Value = 124,
                        NullableValue = null
                    }
                );

                expected.Add(
                    432979716,
                    new SBytesmallint0MI
                    {
                        Id = 432979716,
                        Value = -81,
                        NullableValue = null
                    }
                );

                expected.Add(
                    442236803,
                    new SBytesmallint0MI
                    {
                        Id = 442236803,
                        Value = 86,
                        NullableValue = null
                    }
                );

                expected.Add(
                    971967022,
                    new SBytesmallint0MI
                    {
                        Id = 971967022,
                        Value = 33,
                        NullableValue = 31
                    }
                );

                expected.Add(
                    974877637,
                    new SBytesmallint0MI
                    {
                        Id = 974877637,
                        Value = 114,
                        NullableValue = -2
                    }
                );

                expected.Add(
                    1005760907,
                    new SBytesmallint0MI
                    {
                        Id = 1005760907,
                        Value = -54,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1265080379,
                    new SBytesmallint0MI
                    {
                        Id = 1265080379,
                        Value = 63,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1674725044,
                    new SBytesmallint0MI
                    {
                        Id = 1674725044,
                        Value = -29,
                        NullableValue = 115
                    }
                );

                expected.Add(
                    1774381389,
                    new SBytesmallint0MI
                    {
                        Id = 1774381389,
                        Value = 94,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1835933357,
                    new SBytesmallint0MI
                    {
                        Id = 1835933357,
                        Value = -8,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1937548498,
                    new SBytesmallint0MI
                    {
                        Id = 1937548498,
                        Value = -45,
                        NullableValue = -65
                    }
                );

                expected.Add(
                    2103764620,
                    new SBytesmallint0MI
                    {
                        Id = 2103764620,
                        Value = 73,
                        NullableValue = -8
                    }
                );

                expected.Add(
                    2106414005,
                    new SBytesmallint0MI
                    {
                        Id = 2106414005,
                        Value = 11,
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




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
    internal partial interface IBooleanSingleTypeboolean
    {
    }
    
    internal partial class BooleanSingleTypeboolean : IBooleanSingleTypeboolean
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0mi(
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0mi(
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
            queryMapType: typeof(Booleanboolean0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)
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

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModelInner(connection, 1785063903, false, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModelInner(connection, 2048982814, false, null);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelInnerAsync(connection, 749156347, false, false);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelInnerAsync(connection, 2032263312, false, false);
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

                id =  ((IBooleanSingleTypeboolean)this).InsertModelInnerReturning(connection, 1509192645, false, null);
                Assert.That(id, Is.EqualTo(1509192645));

                id =  ((IBooleanSingleTypeboolean)this).InsertModelInnerReturning(connection, 1464119546, false, null);
                Assert.That(id, Is.EqualTo(1464119546));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IBooleanSingleTypeboolean)this).InsertModelInnerReturningAsync(connection, 1456846383, false, false);
                Assert.That(id, Is.EqualTo(1456846383));

                id = await ((IBooleanSingleTypeboolean)this).InsertModelInnerReturningAsync(connection, 1428976502, false, false);
                Assert.That(id, Is.EqualTo(1428976502));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0mi(
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(3)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(3), 
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

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModel(connection, 561606843, false, null);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, 1051273225, false, false);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, 108742867, false, false);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, 1382023654, false, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, 158966920, false, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, 509945344, false, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, 2051323722, false, false);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "booleanboolean0mi_id", 
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

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModel(connection, 1100288035, false, false, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModel(connection, 1197605910, false, false, 1785063903);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelAsync(connection, 941672817, false, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelAsync(connection, 1605441941, false, false, 2048982814);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Boolean? nullable = null;

                nullable =  ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturning(connection, 790024887, false, false, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));

                nullable =  ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturning(connection, 1216775274, false, false, 749156347);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Boolean? nullable = null;

                nullable = await ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturningAsync(connection, 424175359, false, false, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));

                nullable = await ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturningAsync(connection, 1635444447, false, false, 2032263312);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
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
    booleanboolean0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Booleanboolean0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "booleanboolean0mi_id", 
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
                List<Booleanboolean0M> models = null;
                Booleanboolean0M model = null;

                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, 304808014, false, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304808014));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, 1469184192, false, null, 1509192645).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Boolean)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, 1981808879, false, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, 1639245493, false, null, 1464119546).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Boolean)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Booleanboolean0M> models = null;
                Booleanboolean0M model = null;

                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, 2145788868, false, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, 4269473, false, false, 1456846383).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4269473));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1456846383));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Boolean)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, 483080283, false, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, 2093412907, false, false, 1428976502).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Boolean)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanboolean0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Boolean), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(3)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(3),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "booleanboolean0mi_id", 
                methodParametrName: "booleanboolean0mi_id", 
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

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertModel(connection, 1011293394, false, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertModel(connection, 1677540404, false, null, 561606843);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 510509518, false, false, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 88745654, false, null, 1051273225);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 950203949, false, false, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 913015056, false, false, 108742867);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 1226751619, false, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 868701898, false, null, 1382023654);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 2946001, false, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 2115234451, false, false, 158966920);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 1434125865, false, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 902238291, false, false, 509945344);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 104290003, false, false, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, 1602315882, false, false, 2051323722);
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
FROM public.booleanboolean0m m
LEFT JOIN public.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Booleanboolean0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)
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
                var models =  ((IBooleanSingleTypeboolean)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2946001));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4269473));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1456846383));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88745654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1051273225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104290003));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304808014));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424175359));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510509518));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790024887));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868701898));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1382023654));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902238291));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509945344));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913015056));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108742867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941672817));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950203949));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1011293394));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100288035));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1197605910));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1785063903));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216775274));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749156347));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226751619));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434125865));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

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
                var models = await ((IBooleanSingleTypeboolean)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2946001));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4269473));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1456846383));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88745654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1051273225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104290003));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304808014));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424175359));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510509518));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790024887));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868701898));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1382023654));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902238291));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509945344));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913015056));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108742867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941672817));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950203949));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1011293394));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100288035));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1197605910));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1785063903));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216775274));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749156347));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226751619));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434125865));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

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
FROM public.booleanboolean0m m
LEFT JOIN public.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Booleanboolean0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)
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
                var models =  ((IBooleanSingleTypeboolean)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2946001));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4269473));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1456846383));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88745654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1051273225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104290003));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304808014));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424175359));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510509518));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790024887));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868701898));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1382023654));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902238291));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509945344));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913015056));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108742867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941672817));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950203949));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1011293394));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100288035));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1197605910));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1785063903));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216775274));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749156347));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226751619));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434125865));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

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
                var models = await ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2946001));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4269473));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1456846383));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88745654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1051273225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104290003));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304808014));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424175359));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510509518));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790024887));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868701898));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1382023654));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902238291));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509945344));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913015056));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108742867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941672817));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950203949));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1011293394));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100288035));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1197605910));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1785063903));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216775274));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749156347));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226751619));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434125865));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

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
                 using var cmd =  ((IBooleanSingleTypeboolean)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 424175359);
                var models =  ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(24));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510509518));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790024887));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868701898));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1382023654));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902238291));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509945344));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913015056));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108742867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941672817));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950203949));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1011293394));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100288035));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1197605910));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1785063903));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216775274));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749156347));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226751619));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434125865));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

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
                await using var cmd = await ((IBooleanSingleTypeboolean)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 2946001);
                var models = await ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(29));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4269473));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1456846383));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88745654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1051273225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104290003));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304808014));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424175359));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510509518));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790024887));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868701898));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1382023654));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902238291));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509945344));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913015056));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108742867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941672817));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950203949));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1011293394));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100288035));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1197605910));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1785063903));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216775274));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749156347));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226751619));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434125865));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)
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
                 foreach(var batchResult in ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelBatch(connection, 1197605910, 1677540404))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(13));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216775274));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749156347));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226751619));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434125865));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

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
                await foreach(var batchResult in ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelBatchAsync(connection, 1469184192, 1434125865))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(9));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

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
FROM public.booleanboolean0m m
LEFT JOIN public.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)
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
                var models =  ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2946001)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4269473)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1456846383)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88745654)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1051273225)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104290003)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((304808014)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((424175359)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((483080283)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((510509518)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((790024887)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((868701898)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1382023654)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((902238291)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((509945344)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((913015056)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((108742867)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((941672817)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((950203949)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1011293394)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1100288035)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1197605910)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1785063903)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1216775274)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((749156347)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1226751619)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1434125865)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1469184192)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1509192645)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1602315882)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2051323722)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1605441941)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2048982814)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1635444447)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2032263312)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1639245493)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1464119546)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1677540404)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((561606843)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1981808879)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2093412907)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1428976502)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2115234451)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((158966920)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2145788868)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

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
                var models = await ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2946001)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4269473)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1456846383)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88745654)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1051273225)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104290003)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((304808014)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((424175359)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((483080283)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((510509518)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((790024887)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((868701898)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1382023654)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((902238291)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((509945344)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((913015056)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((108742867)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((941672817)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((950203949)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1011293394)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1100288035)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1197605910)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1785063903)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1216775274)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((749156347)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1226751619)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1434125865)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1469184192)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1509192645)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1602315882)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2051323722)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1605441941)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2048982814)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1635444447)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2032263312)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1639245493)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1464119546)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1677540404)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((561606843)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1981808879)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2093412907)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1428976502)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2115234451)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((158966920)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2145788868)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

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
COPY public.binary_booleanboolean0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Booleanboolean0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
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
FROM public.binary_booleanboolean0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Booleanboolean0MI),
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

                var importCollection = new List<Booleanboolean0MI>(7);

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 108742867,
                    Value = false,
                    NullableValue = false
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 158966920,
                    Value = false,
                    NullableValue = null
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 509945344,
                    Value = false,
                    NullableValue = null
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 561606843,
                    Value = false,
                    NullableValue = null
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 749156347,
                    Value = false,
                    NullableValue = false
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 1051273225,
                    Value = false,
                    NullableValue = false
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 1382023654,
                    Value = false,
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108742867));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(158966920));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509945344));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561606843));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749156347));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051273225));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1382023654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 1428976502,
                    Value = false,
                    NullableValue = false
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 1456846383,
                    Value = false,
                    NullableValue = false
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 1464119546,
                    Value = false,
                    NullableValue = null
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 1509192645,
                    Value = false,
                    NullableValue = null
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 1785063903,
                    Value = false,
                    NullableValue = null
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 2032263312,
                    Value = false,
                    NullableValue = false
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 2048982814,
                    Value = false,
                    NullableValue = null
                });

                importCollection.Add(
                new Booleanboolean0MI
                {
                    Id = 2051323722,
                    Value = false,
                    NullableValue = false
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108742867));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(158966920));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509945344));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561606843));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(749156347));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1051273225));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1382023654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428976502));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456846383));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1464119546));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1509192645));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1785063903));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2032263312));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2048982814));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2051323722));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanboolean0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
booleanboolean0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Booleanboolean0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2)
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
FROM public.binary_booleanboolean0m m
LEFT JOIN public.binary_booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Booleanboolean0M),
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

                var importCollection = new List<Booleanboolean0M>(15);

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 2946001,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 4269473,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 1456846383
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 88745654,
                    Value = false,
                    NullableValue = null,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 1051273225
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 104290003,
                    Value = false,
                    NullableValue = false,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 304808014,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 424175359,
                    Value = false,
                    NullableValue = false,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 483080283,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 510509518,
                    Value = false,
                    NullableValue = false,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 790024887,
                    Value = false,
                    NullableValue = false,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 868701898,
                    Value = false,
                    NullableValue = null,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 1382023654
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 902238291,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 509945344
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 913015056,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 108742867
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 941672817,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 950203949,
                    Value = false,
                    NullableValue = false,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1011293394,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2946001));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4269473));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1456846383));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88745654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1051273225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104290003));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304808014));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424175359));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510509518));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790024887));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868701898));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1382023654));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902238291));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509945344));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913015056));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108742867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941672817));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950203949));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1011293394));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1100288035,
                    Value = false,
                    NullableValue = false,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1197605910,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 1785063903
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1216775274,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 749156347
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1226751619,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1434125865,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1469184192,
                    Value = false,
                    NullableValue = null,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 1509192645
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1602315882,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 2051323722
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1605441941,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 2048982814
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1635444447,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 2032263312
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1639245493,
                    Value = false,
                    NullableValue = null,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 1464119546
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1677540404,
                    Value = false,
                    NullableValue = null,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 561606843
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 1981808879,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 2093412907,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 1428976502
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 2115234451,
                    Value = false,
                    NullableValue = false,

                    ModelInner = new Booleanboolean0MI 
                    {
                        Id = 158966920
                    }

                });

                importCollection.Add(
                new Booleanboolean0M
                {
                    Id = 2145788868,
                    Value = false,
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2946001));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(4269473));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1456846383));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(88745654));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1051273225));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104290003));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(304808014));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424175359));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483080283));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510509518));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(790024887));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868701898));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1382023654));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(902238291));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509945344));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913015056));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108742867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941672817));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950203949));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1011293394));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1100288035));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1197605910));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1785063903));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1216775274));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(749156347));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226751619));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434125865));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469184192));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1509192645));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1602315882));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2051323722));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1605441941));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2048982814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1635444447));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032263312));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639245493));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1464119546));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1677540404));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(561606843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981808879));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093412907));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1428976502));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(false));


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115234451));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(false));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158966920));

                Assert.That(model.ModelInner.Value, Is.EqualTo(false));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2145788868));
                Assert.That(model.Value, Is.EqualTo(false));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanboolean0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    booleanboolean0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Booleanboolean0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2)
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

                var expected = new Dictionary<System.Int32,Booleanboolean0M>(30);

                expected.Add(
                    2946001,
                    new Booleanboolean0M
                    {
                        Id = 2946001,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    4269473,
                    new Booleanboolean0M
                    {
                        Id = 4269473,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1456846383,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    88745654,
                    new Booleanboolean0M
                    {
                        Id = 88745654,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1051273225,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    104290003,
                    new Booleanboolean0M
                    {
                        Id = 104290003,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    304808014,
                    new Booleanboolean0M
                    {
                        Id = 304808014,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    424175359,
                    new Booleanboolean0M
                    {
                        Id = 424175359,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    483080283,
                    new Booleanboolean0M
                    {
                        Id = 483080283,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    510509518,
                    new Booleanboolean0M
                    {
                        Id = 510509518,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    790024887,
                    new Booleanboolean0M
                    {
                        Id = 790024887,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    868701898,
                    new Booleanboolean0M
                    {
                        Id = 868701898,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1382023654,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    902238291,
                    new Booleanboolean0M
                    {
                        Id = 902238291,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 509945344,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    913015056,
                    new Booleanboolean0M
                    {
                        Id = 913015056,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 108742867,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    941672817,
                    new Booleanboolean0M
                    {
                        Id = 941672817,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    950203949,
                    new Booleanboolean0M
                    {
                        Id = 950203949,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1011293394,
                    new Booleanboolean0M
                    {
                        Id = 1011293394,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1100288035,
                    new Booleanboolean0M
                    {
                        Id = 1100288035,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1197605910,
                    new Booleanboolean0M
                    {
                        Id = 1197605910,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1785063903,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1216775274,
                    new Booleanboolean0M
                    {
                        Id = 1216775274,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 749156347,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    1226751619,
                    new Booleanboolean0M
                    {
                        Id = 1226751619,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1434125865,
                    new Booleanboolean0M
                    {
                        Id = 1434125865,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1469184192,
                    new Booleanboolean0M
                    {
                        Id = 1469184192,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1509192645,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1602315882,
                    new Booleanboolean0M
                    {
                        Id = 1602315882,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 2051323722,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    1605441941,
                    new Booleanboolean0M
                    {
                        Id = 1605441941,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 2048982814,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1635444447,
                    new Booleanboolean0M
                    {
                        Id = 1635444447,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 2032263312,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    1639245493,
                    new Booleanboolean0M
                    {
                        Id = 1639245493,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1464119546,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1677540404,
                    new Booleanboolean0M
                    {
                        Id = 1677540404,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 561606843,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1981808879,
                    new Booleanboolean0M
                    {
                        Id = 1981808879,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2093412907,
                    new Booleanboolean0M
                    {
                        Id = 2093412907,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1428976502,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    2115234451,
                    new Booleanboolean0M
                    {
                        Id = 2115234451,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 158966920,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2145788868,
                    new Booleanboolean0M
                    {
                        Id = 2145788868,
                        Value = false,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Boolean)default));
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

                var expected = new Dictionary<System.Int32,Booleanboolean0M>(30);

                expected.Add(
                    2946001,
                    new Booleanboolean0M
                    {
                        Id = 2946001,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    4269473,
                    new Booleanboolean0M
                    {
                        Id = 4269473,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1456846383,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    88745654,
                    new Booleanboolean0M
                    {
                        Id = 88745654,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1051273225,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    104290003,
                    new Booleanboolean0M
                    {
                        Id = 104290003,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    304808014,
                    new Booleanboolean0M
                    {
                        Id = 304808014,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    424175359,
                    new Booleanboolean0M
                    {
                        Id = 424175359,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    483080283,
                    new Booleanboolean0M
                    {
                        Id = 483080283,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    510509518,
                    new Booleanboolean0M
                    {
                        Id = 510509518,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    790024887,
                    new Booleanboolean0M
                    {
                        Id = 790024887,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    868701898,
                    new Booleanboolean0M
                    {
                        Id = 868701898,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1382023654,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    902238291,
                    new Booleanboolean0M
                    {
                        Id = 902238291,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 509945344,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    913015056,
                    new Booleanboolean0M
                    {
                        Id = 913015056,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 108742867,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    941672817,
                    new Booleanboolean0M
                    {
                        Id = 941672817,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    950203949,
                    new Booleanboolean0M
                    {
                        Id = 950203949,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1011293394,
                    new Booleanboolean0M
                    {
                        Id = 1011293394,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1100288035,
                    new Booleanboolean0M
                    {
                        Id = 1100288035,
                        Value = false,
                        NullableValue = false,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1197605910,
                    new Booleanboolean0M
                    {
                        Id = 1197605910,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1785063903,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1216775274,
                    new Booleanboolean0M
                    {
                        Id = 1216775274,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 749156347,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    1226751619,
                    new Booleanboolean0M
                    {
                        Id = 1226751619,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1434125865,
                    new Booleanboolean0M
                    {
                        Id = 1434125865,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1469184192,
                    new Booleanboolean0M
                    {
                        Id = 1469184192,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1509192645,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1602315882,
                    new Booleanboolean0M
                    {
                        Id = 1602315882,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 2051323722,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    1605441941,
                    new Booleanboolean0M
                    {
                        Id = 1605441941,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 2048982814,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1635444447,
                    new Booleanboolean0M
                    {
                        Id = 1635444447,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 2032263312,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    1639245493,
                    new Booleanboolean0M
                    {
                        Id = 1639245493,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1464119546,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1677540404,
                    new Booleanboolean0M
                    {
                        Id = 1677540404,
                        Value = false,
                        NullableValue = null,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 561606843,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1981808879,
                    new Booleanboolean0M
                    {
                        Id = 1981808879,
                        Value = false,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2093412907,
                    new Booleanboolean0M
                    {
                        Id = 2093412907,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 1428976502,
                            Value = false,
                            NullableValue = false
                        }

                    }
                );

                expected.Add(
                    2115234451,
                    new Booleanboolean0M
                    {
                        Id = 2115234451,
                        Value = false,
                        NullableValue = false,

                        ModelInner = new Booleanboolean0MI
                        {
                            Id = 158966920,
                            Value = false,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2145788868,
                    new Booleanboolean0M
                    {
                        Id = 2145788868,
                        Value = false,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Boolean)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanboolean0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Booleanboolean0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
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

                var expected = new Dictionary<System.Int32,Booleanboolean0MI>(15);

                expected.Add(
                    108742867,
                    new Booleanboolean0MI
                    {
                        Id = 108742867,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    158966920,
                    new Booleanboolean0MI
                    {
                        Id = 158966920,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    509945344,
                    new Booleanboolean0MI
                    {
                        Id = 509945344,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    561606843,
                    new Booleanboolean0MI
                    {
                        Id = 561606843,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    749156347,
                    new Booleanboolean0MI
                    {
                        Id = 749156347,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    1051273225,
                    new Booleanboolean0MI
                    {
                        Id = 1051273225,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    1382023654,
                    new Booleanboolean0MI
                    {
                        Id = 1382023654,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1428976502,
                    new Booleanboolean0MI
                    {
                        Id = 1428976502,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    1456846383,
                    new Booleanboolean0MI
                    {
                        Id = 1456846383,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    1464119546,
                    new Booleanboolean0MI
                    {
                        Id = 1464119546,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1509192645,
                    new Booleanboolean0MI
                    {
                        Id = 1509192645,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1785063903,
                    new Booleanboolean0MI
                    {
                        Id = 1785063903,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2032263312,
                    new Booleanboolean0MI
                    {
                        Id = 2032263312,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    2048982814,
                    new Booleanboolean0MI
                    {
                        Id = 2048982814,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2051323722,
                    new Booleanboolean0MI
                    {
                        Id = 2051323722,
                        Value = false,
                        NullableValue = false
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

                var expected = new Dictionary<System.Int32,Booleanboolean0MI>(15);

                expected.Add(
                    108742867,
                    new Booleanboolean0MI
                    {
                        Id = 108742867,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    158966920,
                    new Booleanboolean0MI
                    {
                        Id = 158966920,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    509945344,
                    new Booleanboolean0MI
                    {
                        Id = 509945344,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    561606843,
                    new Booleanboolean0MI
                    {
                        Id = 561606843,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    749156347,
                    new Booleanboolean0MI
                    {
                        Id = 749156347,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    1051273225,
                    new Booleanboolean0MI
                    {
                        Id = 1051273225,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    1382023654,
                    new Booleanboolean0MI
                    {
                        Id = 1382023654,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1428976502,
                    new Booleanboolean0MI
                    {
                        Id = 1428976502,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    1456846383,
                    new Booleanboolean0MI
                    {
                        Id = 1456846383,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    1464119546,
                    new Booleanboolean0MI
                    {
                        Id = 1464119546,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1509192645,
                    new Booleanboolean0MI
                    {
                        Id = 1509192645,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1785063903,
                    new Booleanboolean0MI
                    {
                        Id = 1785063903,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2032263312,
                    new Booleanboolean0MI
                    {
                        Id = 2032263312,
                        Value = false,
                        NullableValue = false
                    }
                );

                expected.Add(
                    2048982814,
                    new Booleanboolean0MI
                    {
                        Id = 2048982814,
                        Value = false,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2051323722,
                    new Booleanboolean0MI
                    {
                        Id = 2051323722,
                        Value = false,
                        NullableValue = false
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


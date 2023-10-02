

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
    internal partial interface IDoubleSingleTypedouble_precision
    {
    }
    
    internal partial class DoubleSingleTypedouble_precision : IDoubleSingleTypedouble_precision
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            queryMapType: typeof(Doubledouble_precision0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModelInner(connection, 101128843, 0.895507276742866d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModelInner(connection, 1505386118, 0.331773961003183d, null);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerAsync(connection, 1701186264, 0.8644401178147152d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerAsync(connection, 1919448895, 0.803782459233623d, 0.6144094238373782d);
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

                id =  ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturning(connection, 1396723598, 0.5029208786954745d, 0.07678035476716416d);
                Assert.That(id, Is.EqualTo(1396723598));

                id =  ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturning(connection, 2020717397, 0.7728176948476552d, null);
                Assert.That(id, Is.EqualTo(2020717397));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturningAsync(connection, 2120045675, 0.9297467226045654d, 0.15932063225654836d);
                Assert.That(id, Is.EqualTo(2120045675));

                id = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturningAsync(connection, 1886274083, 0.4687672600806446d, 0.2689428646364974d);
                Assert.That(id, Is.EqualTo(1886274083));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(8)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8), 
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModel(connection, 1862540428, 0.5628151146662022d, null);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, 370229005, 0.7098767168201114d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, 427566422, 0.36690202162239005d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, 1617676915, 0.6930287079883d, 0.5422834594705386d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, 1689937488, 0.012437546238532438d, 0.43799128405355237d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, 353098099, 0.834561495095017d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, 1888484694, 0.9219510264760119d, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precision0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModel(connection, 1749879361, 0.29020040312994666d, 0.161109632026617d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModel(connection, 744272174, 0.6304646197305961d, null, 101128843);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelAsync(connection, 1759645061, 0.21040810458118375d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelAsync(connection, 1721331328, 0.09402307003254706d, 0.6303235936643702d, 1505386118);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double? nullable = null;

                nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturning(connection, 1002891196, 0.7254449763202477d, null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturning(connection, 1045452228, 0.8854617876329905d, null, 1701186264);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double? nullable = null;

                nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturningAsync(connection, 1477288456, 0.7829346878351976d, 0.9619712010415746d, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.9619712010415746d));

                nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturningAsync(connection, 787339888, 0.45971309858595655d, null, 1919448895);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
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
    doubledouble_precision0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Doubledouble_precision0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precision0mi_id", 
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
                List<Doubledouble_precision0M> models = null;
                Doubledouble_precision0M model = null;

                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, 620532750, 0.12169631617980148d, 0.16408618351847637d, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620532750));
                Assert.That(model.Value, Is.EqualTo(0.12169631617980148d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16408618351847637d));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, 1462670214, 0.5395378741612812d, 0.4802291513111989d, 1396723598).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, 2127968390, 0.2481668860036209d, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, 2137190771, 0.5949572109072138d, null, 2020717397).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precision0M> models = null;
                Doubledouble_precision0M model = null;

                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, 1127489017, 0.0812300892360428d, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, 561370396, 0.484643872821074d, 0.06331555710734604d, 2120045675).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561370396));
                Assert.That(model.Value, Is.EqualTo(0.484643872821074d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06331555710734604d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120045675));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, 1315859399, 0.9421686487857089d, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, 531848849, 0.9783381044823473d, null, 1886274083).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(531848849));
                Assert.That(model.Value, Is.EqualTo(0.9783381044823473d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886274083));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble_precision0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble_precision0mi_id", 
                methodParametrName: "doubledouble_precision0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModel(connection, 1683552121, 0.9379179194696166d, 0.4144921648940172d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModel(connection, 1456251631, 0.6124673818119378d, null, 1862540428);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 1781571779, 0.16354406255023834d, 0.025366139664743548d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 291761000, 0.48653071062722186d, 0.3794046760513825d, 370229005);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 361833540, 0.07229862118189401d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 1062486727, 0.8967916836260516d, 0.10356313380360782d, 427566422);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 22767902, 0.14287255020755596d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 1250854930, 0.8987969547850551d, 0.06581168353556721d, 1617676915);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 943770341, 0.02143011847627041d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 1955905220, 0.9164368765285802d, 0.1480848937153313d, 1689937488);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 288991060, 0.45831698763136486d, 0.5619270928944542d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 907597691, 0.8442782366744982d, null, 353098099);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 730817214, 0.2916035748863832d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, 1943265978, 0.18479888812773437d, null, 1888484694);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Doubledouble_precision0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
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
                var models =  ((IDoubleSingleTypedouble_precision)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22767902));
                Assert.That(model.Value, Is.EqualTo(0.14287255020755596d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(288991060));
                Assert.That(model.Value, Is.EqualTo(0.45831698763136486d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5619270928944542d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291761000));
                Assert.That(model.Value, Is.EqualTo(0.48653071062722186d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3794046760513825d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(370229005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7098767168201114d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361833540));
                Assert.That(model.Value, Is.EqualTo(0.07229862118189401d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(531848849));
                Assert.That(model.Value, Is.EqualTo(0.9783381044823473d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886274083));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4687672600806446d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2689428646364974d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561370396));
                Assert.That(model.Value, Is.EqualTo(0.484643872821074d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06331555710734604d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120045675));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9297467226045654d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.15932063225654836d));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620532750));
                Assert.That(model.Value, Is.EqualTo(0.12169631617980148d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16408618351847637d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730817214));
                Assert.That(model.Value, Is.EqualTo(0.2916035748863832d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22767902));
                Assert.That(model.Value, Is.EqualTo(0.14287255020755596d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(288991060));
                Assert.That(model.Value, Is.EqualTo(0.45831698763136486d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5619270928944542d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291761000));
                Assert.That(model.Value, Is.EqualTo(0.48653071062722186d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3794046760513825d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(370229005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7098767168201114d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361833540));
                Assert.That(model.Value, Is.EqualTo(0.07229862118189401d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(531848849));
                Assert.That(model.Value, Is.EqualTo(0.9783381044823473d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886274083));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4687672600806446d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2689428646364974d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561370396));
                Assert.That(model.Value, Is.EqualTo(0.484643872821074d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06331555710734604d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120045675));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9297467226045654d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.15932063225654836d));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620532750));
                Assert.That(model.Value, Is.EqualTo(0.12169631617980148d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16408618351847637d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730817214));
                Assert.That(model.Value, Is.EqualTo(0.2916035748863832d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Doubledouble_precision0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
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
                var models =  ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22767902));
                Assert.That(model.Value, Is.EqualTo(0.14287255020755596d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(288991060));
                Assert.That(model.Value, Is.EqualTo(0.45831698763136486d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5619270928944542d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291761000));
                Assert.That(model.Value, Is.EqualTo(0.48653071062722186d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3794046760513825d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(370229005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7098767168201114d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361833540));
                Assert.That(model.Value, Is.EqualTo(0.07229862118189401d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(531848849));
                Assert.That(model.Value, Is.EqualTo(0.9783381044823473d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886274083));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4687672600806446d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2689428646364974d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561370396));
                Assert.That(model.Value, Is.EqualTo(0.484643872821074d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06331555710734604d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120045675));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9297467226045654d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.15932063225654836d));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620532750));
                Assert.That(model.Value, Is.EqualTo(0.12169631617980148d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16408618351847637d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730817214));
                Assert.That(model.Value, Is.EqualTo(0.2916035748863832d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22767902));
                Assert.That(model.Value, Is.EqualTo(0.14287255020755596d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(288991060));
                Assert.That(model.Value, Is.EqualTo(0.45831698763136486d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5619270928944542d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291761000));
                Assert.That(model.Value, Is.EqualTo(0.48653071062722186d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3794046760513825d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(370229005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7098767168201114d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361833540));
                Assert.That(model.Value, Is.EqualTo(0.07229862118189401d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(531848849));
                Assert.That(model.Value, Is.EqualTo(0.9783381044823473d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886274083));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4687672600806446d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2689428646364974d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561370396));
                Assert.That(model.Value, Is.EqualTo(0.484643872821074d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06331555710734604d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120045675));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9297467226045654d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.15932063225654836d));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620532750));
                Assert.That(model.Value, Is.EqualTo(0.12169631617980148d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16408618351847637d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730817214));
                Assert.That(model.Value, Is.EqualTo(0.2916035748863832d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble_precision)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble_precision)this).SetDbConnectionSelectModelParametrs(cmd, 1749879361);
                var models =  ((IDoubleSingleTypedouble_precision)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(6));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDoubleSingleTypedouble_precision)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypedouble_precision)this).SetDbConnectionSelectModelParametrs(cmd, 943770341);
                var models = await ((IDoubleSingleTypedouble_precision)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(18));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
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
                 foreach(var batchResult in ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelBatch(connection, 620532750, 730817214))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(23));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730817214));
                Assert.That(model.Value, Is.EqualTo(0.2916035748863832d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

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
                await foreach(var batchResult in ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelBatchAsync(connection, 730817214, 361833540))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(531848849));
                Assert.That(model.Value, Is.EqualTo(0.9783381044823473d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886274083));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4687672600806446d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2689428646364974d));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561370396));
                Assert.That(model.Value, Is.EqualTo(0.484643872821074d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06331555710734604d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120045675));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9297467226045654d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.15932063225654836d));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620532750));
                Assert.That(model.Value, Is.EqualTo(0.12169631617980148d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16408618351847637d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730817214));
                Assert.That(model.Value, Is.EqualTo(0.2916035748863832d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
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
                var models =  ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22767902)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14287255020755596d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((288991060)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45831698763136486d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5619270928944542d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((291761000)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.48653071062722186d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((370229005)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7098767168201114d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3794046760513825d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((361833540)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07229862118189401d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((531848849)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9783381044823473d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1886274083)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4687672600806446d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2689428646364974d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((561370396)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.484643872821074d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2120045675)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9297467226045654d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.15932063225654836d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06331555710734604d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((620532750)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.12169631617980148d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16408618351847637d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((730817214)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2916035748863832d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((744272174)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6304646197305961d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101128843)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.895507276742866d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((787339888)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45971309858595655d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1919448895)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.803782459233623d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6144094238373782d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((907597691)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8442782366744982d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((353098099)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.834561495095017d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((943770341)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.02143011847627041d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1002891196)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7254449763202477d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1045452228)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8854617876329905d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1701186264)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8644401178147152d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1062486727)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8967916836260516d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((427566422)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.36690202162239005d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.10356313380360782d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1127489017)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0812300892360428d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1250854930)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8987969547850551d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1617676915)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6930287079883d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5422834594705386d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06581168353556721d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1315859399)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9421686487857089d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1456251631)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6124673818119378d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1862540428)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5628151146662022d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1462670214)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5395378741612812d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1396723598)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5029208786954745d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.07678035476716416d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4802291513111989d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1477288456)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7829346878351976d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9619712010415746d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1683552121)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9379179194696166d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4144921648940172d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1721331328)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.09402307003254706d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1505386118)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.331773961003183d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6303235936643702d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1749879361)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29020040312994666d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.161109632026617d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1759645061)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21040810458118375d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1781571779)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16354406255023834d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.025366139664743548d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1943265978)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18479888812773437d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1888484694)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9219510264760119d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1955905220)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9164368765285802d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1689937488)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.012437546238532438d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.43799128405355237d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1480848937153313d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2127968390)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2481668860036209d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2137190771)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5949572109072138d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2020717397)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7728176948476552d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22767902)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14287255020755596d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((288991060)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45831698763136486d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5619270928944542d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((291761000)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.48653071062722186d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((370229005)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7098767168201114d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3794046760513825d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((361833540)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07229862118189401d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((531848849)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9783381044823473d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1886274083)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4687672600806446d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2689428646364974d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((561370396)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.484643872821074d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2120045675)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9297467226045654d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.15932063225654836d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06331555710734604d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((620532750)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.12169631617980148d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16408618351847637d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((730817214)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2916035748863832d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((744272174)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6304646197305961d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101128843)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.895507276742866d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((787339888)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45971309858595655d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1919448895)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.803782459233623d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6144094238373782d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((907597691)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8442782366744982d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((353098099)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.834561495095017d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((943770341)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.02143011847627041d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1002891196)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7254449763202477d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1045452228)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8854617876329905d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1701186264)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8644401178147152d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1062486727)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8967916836260516d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((427566422)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.36690202162239005d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.10356313380360782d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1127489017)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0812300892360428d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1250854930)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8987969547850551d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1617676915)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6930287079883d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5422834594705386d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06581168353556721d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1315859399)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9421686487857089d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1456251631)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6124673818119378d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1862540428)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5628151146662022d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1462670214)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5395378741612812d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1396723598)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5029208786954745d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.07678035476716416d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4802291513111989d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1477288456)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7829346878351976d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9619712010415746d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1683552121)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9379179194696166d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4144921648940172d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1721331328)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.09402307003254706d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1505386118)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.331773961003183d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6303235936643702d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1749879361)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29020040312994666d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.161109632026617d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1759645061)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21040810458118375d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1781571779)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16354406255023834d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.025366139664743548d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1943265978)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18479888812773437d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1888484694)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9219510264760119d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1955905220)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9164368765285802d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1689937488)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.012437546238532438d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.43799128405355237d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1480848937153313d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2127968390)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2481668860036209d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2137190771)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5949572109072138d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2020717397)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7728176948476552d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precision0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precision0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
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
FROM public.binary_doubledouble_precision0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Doubledouble_precision0MI),
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

                var importCollection = new List<Doubledouble_precision0MI>(7);

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 101128843,
                    Value = 0.895507276742866d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 353098099,
                    Value = 0.834561495095017d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 370229005,
                    Value = 0.7098767168201114d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 427566422,
                    Value = 0.36690202162239005d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1396723598,
                    Value = 0.5029208786954745d,
                    NullableValue = 0.07678035476716416d
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1505386118,
                    Value = 0.331773961003183d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1617676915,
                    Value = 0.6930287079883d,
                    NullableValue = 0.5422834594705386d
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101128843));
                Assert.That(model.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(353098099));
                Assert.That(model.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(370229005));
                Assert.That(model.Value, Is.EqualTo(0.7098767168201114d));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427566422));
                Assert.That(model.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1396723598));
                Assert.That(model.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.07678035476716416d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1505386118));
                Assert.That(model.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617676915));
                Assert.That(model.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5422834594705386d));

                importCollection.Clear();

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1689937488,
                    Value = 0.012437546238532438d,
                    NullableValue = 0.43799128405355237d
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1701186264,
                    Value = 0.8644401178147152d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1862540428,
                    Value = 0.5628151146662022d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1886274083,
                    Value = 0.4687672600806446d,
                    NullableValue = 0.2689428646364974d
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1888484694,
                    Value = 0.9219510264760119d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 1919448895,
                    Value = 0.803782459233623d,
                    NullableValue = 0.6144094238373782d
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 2020717397,
                    Value = 0.7728176948476552d,
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precision0MI
                {
                    Id = 2120045675,
                    Value = 0.9297467226045654d,
                    NullableValue = 0.15932063225654836d
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101128843));
                Assert.That(model.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(353098099));
                Assert.That(model.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(370229005));
                Assert.That(model.Value, Is.EqualTo(0.7098767168201114d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427566422));
                Assert.That(model.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1396723598));
                Assert.That(model.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.07678035476716416d));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1505386118));
                Assert.That(model.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617676915));
                Assert.That(model.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5422834594705386d));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1689937488));
                Assert.That(model.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43799128405355237d));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1701186264));
                Assert.That(model.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862540428));
                Assert.That(model.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1886274083));
                Assert.That(model.Value, Is.EqualTo(0.4687672600806446d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2689428646364974d));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1888484694));
                Assert.That(model.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1919448895));
                Assert.That(model.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6144094238373782d));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020717397));
                Assert.That(model.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2120045675));
                Assert.That(model.Value, Is.EqualTo(0.9297467226045654d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.15932063225654836d));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precision0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precision0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precision0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8)
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
FROM public.binary_doubledouble_precision0m m
LEFT JOIN public.binary_doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Doubledouble_precision0M),
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

                var importCollection = new List<Doubledouble_precision0M>(15);

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 22767902,
                    Value = 0.14287255020755596d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 288991060,
                    Value = 0.45831698763136486d,
                    NullableValue = 0.5619270928944542d,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 291761000,
                    Value = 0.48653071062722186d,
                    NullableValue = 0.3794046760513825d,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 370229005
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 361833540,
                    Value = 0.07229862118189401d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 531848849,
                    Value = 0.9783381044823473d,
                    NullableValue = null,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1886274083
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 561370396,
                    Value = 0.484643872821074d,
                    NullableValue = 0.06331555710734604d,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 2120045675
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 620532750,
                    Value = 0.12169631617980148d,
                    NullableValue = 0.16408618351847637d,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 730817214,
                    Value = 0.2916035748863832d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 744272174,
                    Value = 0.6304646197305961d,
                    NullableValue = null,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 101128843
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 787339888,
                    Value = 0.45971309858595655d,
                    NullableValue = null,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1919448895
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 907597691,
                    Value = 0.8442782366744982d,
                    NullableValue = null,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 353098099
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 943770341,
                    Value = 0.02143011847627041d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1002891196,
                    Value = 0.7254449763202477d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1045452228,
                    Value = 0.8854617876329905d,
                    NullableValue = null,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1701186264
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1062486727,
                    Value = 0.8967916836260516d,
                    NullableValue = 0.10356313380360782d,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 427566422
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22767902));
                Assert.That(model.Value, Is.EqualTo(0.14287255020755596d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(288991060));
                Assert.That(model.Value, Is.EqualTo(0.45831698763136486d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5619270928944542d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291761000));
                Assert.That(model.Value, Is.EqualTo(0.48653071062722186d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3794046760513825d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(370229005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7098767168201114d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361833540));
                Assert.That(model.Value, Is.EqualTo(0.07229862118189401d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(531848849));
                Assert.That(model.Value, Is.EqualTo(0.9783381044823473d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886274083));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4687672600806446d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2689428646364974d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561370396));
                Assert.That(model.Value, Is.EqualTo(0.484643872821074d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06331555710734604d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120045675));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9297467226045654d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.15932063225654836d));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620532750));
                Assert.That(model.Value, Is.EqualTo(0.12169631617980148d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16408618351847637d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730817214));
                Assert.That(model.Value, Is.EqualTo(0.2916035748863832d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1127489017,
                    Value = 0.0812300892360428d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1250854930,
                    Value = 0.8987969547850551d,
                    NullableValue = 0.06581168353556721d,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1617676915
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1315859399,
                    Value = 0.9421686487857089d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1456251631,
                    Value = 0.6124673818119378d,
                    NullableValue = null,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1862540428
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1462670214,
                    Value = 0.5395378741612812d,
                    NullableValue = 0.4802291513111989d,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1396723598
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1477288456,
                    Value = 0.7829346878351976d,
                    NullableValue = 0.9619712010415746d,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1683552121,
                    Value = 0.9379179194696166d,
                    NullableValue = 0.4144921648940172d,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1721331328,
                    Value = 0.09402307003254706d,
                    NullableValue = 0.6303235936643702d,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1505386118
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1749879361,
                    Value = 0.29020040312994666d,
                    NullableValue = 0.161109632026617d,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1759645061,
                    Value = 0.21040810458118375d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1781571779,
                    Value = 0.16354406255023834d,
                    NullableValue = 0.025366139664743548d,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1943265978,
                    Value = 0.18479888812773437d,
                    NullableValue = null,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1888484694
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 1955905220,
                    Value = 0.9164368765285802d,
                    NullableValue = 0.1480848937153313d,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 1689937488
                    }

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 2127968390,
                    Value = 0.2481668860036209d,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precision0M
                {
                    Id = 2137190771,
                    Value = 0.5949572109072138d,
                    NullableValue = null,

                    ModelInner = new Doubledouble_precision0MI 
                    {
                        Id = 2020717397
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22767902));
                Assert.That(model.Value, Is.EqualTo(0.14287255020755596d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(288991060));
                Assert.That(model.Value, Is.EqualTo(0.45831698763136486d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5619270928944542d));

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(291761000));
                Assert.That(model.Value, Is.EqualTo(0.48653071062722186d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3794046760513825d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(370229005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7098767168201114d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361833540));
                Assert.That(model.Value, Is.EqualTo(0.07229862118189401d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(531848849));
                Assert.That(model.Value, Is.EqualTo(0.9783381044823473d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1886274083));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4687672600806446d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2689428646364974d));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(561370396));
                Assert.That(model.Value, Is.EqualTo(0.484643872821074d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06331555710734604d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120045675));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9297467226045654d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.15932063225654836d));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620532750));
                Assert.That(model.Value, Is.EqualTo(0.12169631617980148d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16408618351847637d));

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730817214));
                Assert.That(model.Value, Is.EqualTo(0.2916035748863832d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744272174));
                Assert.That(model.Value, Is.EqualTo(0.6304646197305961d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(101128843));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.895507276742866d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787339888));
                Assert.That(model.Value, Is.EqualTo(0.45971309858595655d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1919448895));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.803782459233623d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6144094238373782d));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907597691));
                Assert.That(model.Value, Is.EqualTo(0.8442782366744982d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(353098099));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.834561495095017d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943770341));
                Assert.That(model.Value, Is.EqualTo(0.02143011847627041d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1002891196));
                Assert.That(model.Value, Is.EqualTo(0.7254449763202477d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045452228));
                Assert.That(model.Value, Is.EqualTo(0.8854617876329905d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1701186264));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8644401178147152d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1062486727));
                Assert.That(model.Value, Is.EqualTo(0.8967916836260516d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10356313380360782d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(427566422));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.36690202162239005d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1127489017));
                Assert.That(model.Value, Is.EqualTo(0.0812300892360428d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1250854930));
                Assert.That(model.Value, Is.EqualTo(0.8987969547850551d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.06581168353556721d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1617676915));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6930287079883d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5422834594705386d));


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315859399));
                Assert.That(model.Value, Is.EqualTo(0.9421686487857089d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456251631));
                Assert.That(model.Value, Is.EqualTo(0.6124673818119378d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1862540428));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5628151146662022d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1462670214));
                Assert.That(model.Value, Is.EqualTo(0.5395378741612812d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4802291513111989d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1396723598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5029208786954745d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.07678035476716416d));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477288456));
                Assert.That(model.Value, Is.EqualTo(0.7829346878351976d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9619712010415746d));

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683552121));
                Assert.That(model.Value, Is.EqualTo(0.9379179194696166d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144921648940172d));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721331328));
                Assert.That(model.Value, Is.EqualTo(0.09402307003254706d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6303235936643702d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505386118));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.331773961003183d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1749879361));
                Assert.That(model.Value, Is.EqualTo(0.29020040312994666d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.161109632026617d));

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759645061));
                Assert.That(model.Value, Is.EqualTo(0.21040810458118375d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781571779));
                Assert.That(model.Value, Is.EqualTo(0.16354406255023834d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.025366139664743548d));

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943265978));
                Assert.That(model.Value, Is.EqualTo(0.18479888812773437d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1888484694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9219510264760119d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1955905220));
                Assert.That(model.Value, Is.EqualTo(0.9164368765285802d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1480848937153313d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1689937488));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.012437546238532438d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.43799128405355237d));


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2127968390));
                Assert.That(model.Value, Is.EqualTo(0.2481668860036209d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2137190771));
                Assert.That(model.Value, Is.EqualTo(0.5949572109072138d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2020717397));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7728176948476552d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precision0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precision0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Doubledouble_precision0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8)
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

                var expected = new Dictionary<System.Int32,Doubledouble_precision0M>(30);

                expected.Add(
                    22767902,
                    new Doubledouble_precision0M
                    {
                        Id = 22767902,
                        Value = 0.14287255020755596d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    288991060,
                    new Doubledouble_precision0M
                    {
                        Id = 288991060,
                        Value = 0.45831698763136486d,
                        NullableValue = 0.5619270928944542d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    291761000,
                    new Doubledouble_precision0M
                    {
                        Id = 291761000,
                        Value = 0.48653071062722186d,
                        NullableValue = 0.3794046760513825d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 370229005,
                            Value = 0.7098767168201114d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    361833540,
                    new Doubledouble_precision0M
                    {
                        Id = 361833540,
                        Value = 0.07229862118189401d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    531848849,
                    new Doubledouble_precision0M
                    {
                        Id = 531848849,
                        Value = 0.9783381044823473d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1886274083,
                            Value = 0.4687672600806446d,
                            NullableValue = 0.2689428646364974d
                        }

                    }
                );

                expected.Add(
                    561370396,
                    new Doubledouble_precision0M
                    {
                        Id = 561370396,
                        Value = 0.484643872821074d,
                        NullableValue = 0.06331555710734604d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 2120045675,
                            Value = 0.9297467226045654d,
                            NullableValue = 0.15932063225654836d
                        }

                    }
                );

                expected.Add(
                    620532750,
                    new Doubledouble_precision0M
                    {
                        Id = 620532750,
                        Value = 0.12169631617980148d,
                        NullableValue = 0.16408618351847637d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    730817214,
                    new Doubledouble_precision0M
                    {
                        Id = 730817214,
                        Value = 0.2916035748863832d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    744272174,
                    new Doubledouble_precision0M
                    {
                        Id = 744272174,
                        Value = 0.6304646197305961d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 101128843,
                            Value = 0.895507276742866d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    787339888,
                    new Doubledouble_precision0M
                    {
                        Id = 787339888,
                        Value = 0.45971309858595655d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1919448895,
                            Value = 0.803782459233623d,
                            NullableValue = 0.6144094238373782d
                        }

                    }
                );

                expected.Add(
                    907597691,
                    new Doubledouble_precision0M
                    {
                        Id = 907597691,
                        Value = 0.8442782366744982d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 353098099,
                            Value = 0.834561495095017d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    943770341,
                    new Doubledouble_precision0M
                    {
                        Id = 943770341,
                        Value = 0.02143011847627041d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1002891196,
                    new Doubledouble_precision0M
                    {
                        Id = 1002891196,
                        Value = 0.7254449763202477d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1045452228,
                    new Doubledouble_precision0M
                    {
                        Id = 1045452228,
                        Value = 0.8854617876329905d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1701186264,
                            Value = 0.8644401178147152d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1062486727,
                    new Doubledouble_precision0M
                    {
                        Id = 1062486727,
                        Value = 0.8967916836260516d,
                        NullableValue = 0.10356313380360782d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 427566422,
                            Value = 0.36690202162239005d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1127489017,
                    new Doubledouble_precision0M
                    {
                        Id = 1127489017,
                        Value = 0.0812300892360428d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1250854930,
                    new Doubledouble_precision0M
                    {
                        Id = 1250854930,
                        Value = 0.8987969547850551d,
                        NullableValue = 0.06581168353556721d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1617676915,
                            Value = 0.6930287079883d,
                            NullableValue = 0.5422834594705386d
                        }

                    }
                );

                expected.Add(
                    1315859399,
                    new Doubledouble_precision0M
                    {
                        Id = 1315859399,
                        Value = 0.9421686487857089d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1456251631,
                    new Doubledouble_precision0M
                    {
                        Id = 1456251631,
                        Value = 0.6124673818119378d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1862540428,
                            Value = 0.5628151146662022d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1462670214,
                    new Doubledouble_precision0M
                    {
                        Id = 1462670214,
                        Value = 0.5395378741612812d,
                        NullableValue = 0.4802291513111989d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1396723598,
                            Value = 0.5029208786954745d,
                            NullableValue = 0.07678035476716416d
                        }

                    }
                );

                expected.Add(
                    1477288456,
                    new Doubledouble_precision0M
                    {
                        Id = 1477288456,
                        Value = 0.7829346878351976d,
                        NullableValue = 0.9619712010415746d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1683552121,
                    new Doubledouble_precision0M
                    {
                        Id = 1683552121,
                        Value = 0.9379179194696166d,
                        NullableValue = 0.4144921648940172d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1721331328,
                    new Doubledouble_precision0M
                    {
                        Id = 1721331328,
                        Value = 0.09402307003254706d,
                        NullableValue = 0.6303235936643702d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1505386118,
                            Value = 0.331773961003183d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1749879361,
                    new Doubledouble_precision0M
                    {
                        Id = 1749879361,
                        Value = 0.29020040312994666d,
                        NullableValue = 0.161109632026617d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1759645061,
                    new Doubledouble_precision0M
                    {
                        Id = 1759645061,
                        Value = 0.21040810458118375d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1781571779,
                    new Doubledouble_precision0M
                    {
                        Id = 1781571779,
                        Value = 0.16354406255023834d,
                        NullableValue = 0.025366139664743548d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1943265978,
                    new Doubledouble_precision0M
                    {
                        Id = 1943265978,
                        Value = 0.18479888812773437d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1888484694,
                            Value = 0.9219510264760119d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1955905220,
                    new Doubledouble_precision0M
                    {
                        Id = 1955905220,
                        Value = 0.9164368765285802d,
                        NullableValue = 0.1480848937153313d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1689937488,
                            Value = 0.012437546238532438d,
                            NullableValue = 0.43799128405355237d
                        }

                    }
                );

                expected.Add(
                    2127968390,
                    new Doubledouble_precision0M
                    {
                        Id = 2127968390,
                        Value = 0.2481668860036209d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2137190771,
                    new Doubledouble_precision0M
                    {
                        Id = 2137190771,
                        Value = 0.5949572109072138d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 2020717397,
                            Value = 0.7728176948476552d,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double)default));
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

                var expected = new Dictionary<System.Int32,Doubledouble_precision0M>(30);

                expected.Add(
                    22767902,
                    new Doubledouble_precision0M
                    {
                        Id = 22767902,
                        Value = 0.14287255020755596d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    288991060,
                    new Doubledouble_precision0M
                    {
                        Id = 288991060,
                        Value = 0.45831698763136486d,
                        NullableValue = 0.5619270928944542d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    291761000,
                    new Doubledouble_precision0M
                    {
                        Id = 291761000,
                        Value = 0.48653071062722186d,
                        NullableValue = 0.3794046760513825d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 370229005,
                            Value = 0.7098767168201114d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    361833540,
                    new Doubledouble_precision0M
                    {
                        Id = 361833540,
                        Value = 0.07229862118189401d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    531848849,
                    new Doubledouble_precision0M
                    {
                        Id = 531848849,
                        Value = 0.9783381044823473d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1886274083,
                            Value = 0.4687672600806446d,
                            NullableValue = 0.2689428646364974d
                        }

                    }
                );

                expected.Add(
                    561370396,
                    new Doubledouble_precision0M
                    {
                        Id = 561370396,
                        Value = 0.484643872821074d,
                        NullableValue = 0.06331555710734604d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 2120045675,
                            Value = 0.9297467226045654d,
                            NullableValue = 0.15932063225654836d
                        }

                    }
                );

                expected.Add(
                    620532750,
                    new Doubledouble_precision0M
                    {
                        Id = 620532750,
                        Value = 0.12169631617980148d,
                        NullableValue = 0.16408618351847637d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    730817214,
                    new Doubledouble_precision0M
                    {
                        Id = 730817214,
                        Value = 0.2916035748863832d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    744272174,
                    new Doubledouble_precision0M
                    {
                        Id = 744272174,
                        Value = 0.6304646197305961d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 101128843,
                            Value = 0.895507276742866d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    787339888,
                    new Doubledouble_precision0M
                    {
                        Id = 787339888,
                        Value = 0.45971309858595655d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1919448895,
                            Value = 0.803782459233623d,
                            NullableValue = 0.6144094238373782d
                        }

                    }
                );

                expected.Add(
                    907597691,
                    new Doubledouble_precision0M
                    {
                        Id = 907597691,
                        Value = 0.8442782366744982d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 353098099,
                            Value = 0.834561495095017d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    943770341,
                    new Doubledouble_precision0M
                    {
                        Id = 943770341,
                        Value = 0.02143011847627041d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1002891196,
                    new Doubledouble_precision0M
                    {
                        Id = 1002891196,
                        Value = 0.7254449763202477d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1045452228,
                    new Doubledouble_precision0M
                    {
                        Id = 1045452228,
                        Value = 0.8854617876329905d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1701186264,
                            Value = 0.8644401178147152d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1062486727,
                    new Doubledouble_precision0M
                    {
                        Id = 1062486727,
                        Value = 0.8967916836260516d,
                        NullableValue = 0.10356313380360782d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 427566422,
                            Value = 0.36690202162239005d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1127489017,
                    new Doubledouble_precision0M
                    {
                        Id = 1127489017,
                        Value = 0.0812300892360428d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1250854930,
                    new Doubledouble_precision0M
                    {
                        Id = 1250854930,
                        Value = 0.8987969547850551d,
                        NullableValue = 0.06581168353556721d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1617676915,
                            Value = 0.6930287079883d,
                            NullableValue = 0.5422834594705386d
                        }

                    }
                );

                expected.Add(
                    1315859399,
                    new Doubledouble_precision0M
                    {
                        Id = 1315859399,
                        Value = 0.9421686487857089d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1456251631,
                    new Doubledouble_precision0M
                    {
                        Id = 1456251631,
                        Value = 0.6124673818119378d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1862540428,
                            Value = 0.5628151146662022d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1462670214,
                    new Doubledouble_precision0M
                    {
                        Id = 1462670214,
                        Value = 0.5395378741612812d,
                        NullableValue = 0.4802291513111989d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1396723598,
                            Value = 0.5029208786954745d,
                            NullableValue = 0.07678035476716416d
                        }

                    }
                );

                expected.Add(
                    1477288456,
                    new Doubledouble_precision0M
                    {
                        Id = 1477288456,
                        Value = 0.7829346878351976d,
                        NullableValue = 0.9619712010415746d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1683552121,
                    new Doubledouble_precision0M
                    {
                        Id = 1683552121,
                        Value = 0.9379179194696166d,
                        NullableValue = 0.4144921648940172d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1721331328,
                    new Doubledouble_precision0M
                    {
                        Id = 1721331328,
                        Value = 0.09402307003254706d,
                        NullableValue = 0.6303235936643702d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1505386118,
                            Value = 0.331773961003183d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1749879361,
                    new Doubledouble_precision0M
                    {
                        Id = 1749879361,
                        Value = 0.29020040312994666d,
                        NullableValue = 0.161109632026617d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1759645061,
                    new Doubledouble_precision0M
                    {
                        Id = 1759645061,
                        Value = 0.21040810458118375d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1781571779,
                    new Doubledouble_precision0M
                    {
                        Id = 1781571779,
                        Value = 0.16354406255023834d,
                        NullableValue = 0.025366139664743548d,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1943265978,
                    new Doubledouble_precision0M
                    {
                        Id = 1943265978,
                        Value = 0.18479888812773437d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1888484694,
                            Value = 0.9219510264760119d,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1955905220,
                    new Doubledouble_precision0M
                    {
                        Id = 1955905220,
                        Value = 0.9164368765285802d,
                        NullableValue = 0.1480848937153313d,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 1689937488,
                            Value = 0.012437546238532438d,
                            NullableValue = 0.43799128405355237d
                        }

                    }
                );

                expected.Add(
                    2127968390,
                    new Doubledouble_precision0M
                    {
                        Id = 2127968390,
                        Value = 0.2481668860036209d,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2137190771,
                    new Doubledouble_precision0M
                    {
                        Id = 2137190771,
                        Value = 0.5949572109072138d,
                        NullableValue = null,

                        ModelInner = new Doubledouble_precision0MI
                        {
                            Id = 2020717397,
                            Value = 0.7728176948476552d,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Double)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precision0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Doubledouble_precision0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
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

                var expected = new Dictionary<System.Int32,Doubledouble_precision0MI>(15);

                expected.Add(
                    101128843,
                    new Doubledouble_precision0MI
                    {
                        Id = 101128843,
                        Value = 0.895507276742866d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    353098099,
                    new Doubledouble_precision0MI
                    {
                        Id = 353098099,
                        Value = 0.834561495095017d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    370229005,
                    new Doubledouble_precision0MI
                    {
                        Id = 370229005,
                        Value = 0.7098767168201114d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    427566422,
                    new Doubledouble_precision0MI
                    {
                        Id = 427566422,
                        Value = 0.36690202162239005d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1396723598,
                    new Doubledouble_precision0MI
                    {
                        Id = 1396723598,
                        Value = 0.5029208786954745d,
                        NullableValue = 0.07678035476716416d
                    }
                );

                expected.Add(
                    1505386118,
                    new Doubledouble_precision0MI
                    {
                        Id = 1505386118,
                        Value = 0.331773961003183d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1617676915,
                    new Doubledouble_precision0MI
                    {
                        Id = 1617676915,
                        Value = 0.6930287079883d,
                        NullableValue = 0.5422834594705386d
                    }
                );

                expected.Add(
                    1689937488,
                    new Doubledouble_precision0MI
                    {
                        Id = 1689937488,
                        Value = 0.012437546238532438d,
                        NullableValue = 0.43799128405355237d
                    }
                );

                expected.Add(
                    1701186264,
                    new Doubledouble_precision0MI
                    {
                        Id = 1701186264,
                        Value = 0.8644401178147152d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1862540428,
                    new Doubledouble_precision0MI
                    {
                        Id = 1862540428,
                        Value = 0.5628151146662022d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1886274083,
                    new Doubledouble_precision0MI
                    {
                        Id = 1886274083,
                        Value = 0.4687672600806446d,
                        NullableValue = 0.2689428646364974d
                    }
                );

                expected.Add(
                    1888484694,
                    new Doubledouble_precision0MI
                    {
                        Id = 1888484694,
                        Value = 0.9219510264760119d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1919448895,
                    new Doubledouble_precision0MI
                    {
                        Id = 1919448895,
                        Value = 0.803782459233623d,
                        NullableValue = 0.6144094238373782d
                    }
                );

                expected.Add(
                    2020717397,
                    new Doubledouble_precision0MI
                    {
                        Id = 2020717397,
                        Value = 0.7728176948476552d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2120045675,
                    new Doubledouble_precision0MI
                    {
                        Id = 2120045675,
                        Value = 0.9297467226045654d,
                        NullableValue = 0.15932063225654836d
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

                var expected = new Dictionary<System.Int32,Doubledouble_precision0MI>(15);

                expected.Add(
                    101128843,
                    new Doubledouble_precision0MI
                    {
                        Id = 101128843,
                        Value = 0.895507276742866d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    353098099,
                    new Doubledouble_precision0MI
                    {
                        Id = 353098099,
                        Value = 0.834561495095017d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    370229005,
                    new Doubledouble_precision0MI
                    {
                        Id = 370229005,
                        Value = 0.7098767168201114d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    427566422,
                    new Doubledouble_precision0MI
                    {
                        Id = 427566422,
                        Value = 0.36690202162239005d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1396723598,
                    new Doubledouble_precision0MI
                    {
                        Id = 1396723598,
                        Value = 0.5029208786954745d,
                        NullableValue = 0.07678035476716416d
                    }
                );

                expected.Add(
                    1505386118,
                    new Doubledouble_precision0MI
                    {
                        Id = 1505386118,
                        Value = 0.331773961003183d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1617676915,
                    new Doubledouble_precision0MI
                    {
                        Id = 1617676915,
                        Value = 0.6930287079883d,
                        NullableValue = 0.5422834594705386d
                    }
                );

                expected.Add(
                    1689937488,
                    new Doubledouble_precision0MI
                    {
                        Id = 1689937488,
                        Value = 0.012437546238532438d,
                        NullableValue = 0.43799128405355237d
                    }
                );

                expected.Add(
                    1701186264,
                    new Doubledouble_precision0MI
                    {
                        Id = 1701186264,
                        Value = 0.8644401178147152d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1862540428,
                    new Doubledouble_precision0MI
                    {
                        Id = 1862540428,
                        Value = 0.5628151146662022d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1886274083,
                    new Doubledouble_precision0MI
                    {
                        Id = 1886274083,
                        Value = 0.4687672600806446d,
                        NullableValue = 0.2689428646364974d
                    }
                );

                expected.Add(
                    1888484694,
                    new Doubledouble_precision0MI
                    {
                        Id = 1888484694,
                        Value = 0.9219510264760119d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1919448895,
                    new Doubledouble_precision0MI
                    {
                        Id = 1919448895,
                        Value = 0.803782459233623d,
                        NullableValue = 0.6144094238373782d
                    }
                );

                expected.Add(
                    2020717397,
                    new Doubledouble_precision0MI
                    {
                        Id = 2020717397,
                        Value = 0.7728176948476552d,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2120045675,
                    new Doubledouble_precision0MI
                    {
                        Id = 2120045675,
                        Value = 0.9297467226045654d,
                        NullableValue = 0.15932063225654836d
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




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
    internal partial interface IInt64SingleTypebigint
    {
    }
    
    internal partial class Int64SingleTypebigint : IInt64SingleTypebigint
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            queryMapType: typeof(Int64bigint0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)
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

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, 1741024606, 7723615588163314169L, 4261164882629897598L);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, 1907286071, 4769306616358592167L, 8499169772550170975L);
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

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, 71239909, 7469997296017959702L, 2974475222638579319L);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, 452642619, 3309039605195097946L, null);
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

                id =  ((IInt64SingleTypebigint)this).InsertModelInnerReturning(connection, 53877180, 1675518226363454246L, 7806675322051864360L);
                Assert.That(id, Is.EqualTo(53877180));

                id =  ((IInt64SingleTypebigint)this).InsertModelInnerReturning(connection, 1283348994, 1547659163322593916L, 34374717811084202L);
                Assert.That(id, Is.EqualTo(1283348994));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IInt64SingleTypebigint)this).InsertModelInnerReturningAsync(connection, 1763576046, 8990755333158151214L, 71082852900023843L);
                Assert.That(id, Is.EqualTo(1763576046));

                id = await ((IInt64SingleTypebigint)this).InsertModelInnerReturningAsync(connection, 1670444500, 8980241307684680696L, 5395251056627669665L);
                Assert.That(id, Is.EqualTo(1670444500));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(12)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12), 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModel(connection, 568029700, 1525925755039870897L, 5466596161507594298L);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, 1802563711, 8012973511574712635L, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, 1395500794, 7195828309788898505L, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, 1738488913, 1540048975307919625L, 1210448987025574995L);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, 600246041, 1233998034528324228L, 5491748076513616585L);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, 72738787, 8113773442562583836L, 7986089637726138320L);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, 1812187279, 5041894272929856923L, 6786805132985039265L);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
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
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigint0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, 968384382, 469711638159182142L, 1375976665820404121L, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, 306825477, 6508119393002423162L, null, 1741024606);
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

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, 1286860534, 1199734675443779979L, 35805234119486L, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, 1971170795, 2602524439826322743L, null, 1907286071);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64? nullable = null;

                nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelReturning(connection, 967749315, 1334930021986064782L, 9192549377260155403L, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(9192549377260155403L));

                nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelReturning(connection, 1148406366, 448405001497117968L, 3825625540757600893L, 71239909);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(3825625540757600893L));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64? nullable = null;

                nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelReturningAsync(connection, 1703193664, 6816157906395038550L, null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelReturningAsync(connection, 40344947, 2308649354598289424L, null, 452642619);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
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
    int64bigint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Int64bigint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigint0mi_id", 
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
                List<Int64bigint0M> models = null;
                Int64bigint0M model = null;

                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, 2015099342, 4294096057579522468L, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, 155589078, 4272632285301793569L, 1993035378299100570L, 53877180).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, 57942081, 5057429318764196582L, 5560037296144863927L, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57942081));
                Assert.That(model.Value, Is.EqualTo(5057429318764196582L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5560037296144863927L));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, 1411342379, 8655869207182053454L, 2524576254198191356L, 1283348994).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigint0M> models = null;
                Int64bigint0M model = null;

                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, 1422563537, 8218308016626513971L, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, 1962163988, 9061462882247397458L, null, 1763576046).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, 1508992424, 3107582922041641848L, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, 1859992527, 1108717524861283994L, 903352982503119017L, 1670444500).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64bigint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, 459807877, 6262509823475375859L, 724154078917944382L, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, 640469878, 5478041313605469419L, null, 568029700);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 1329062113, 6707486233634032075L, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 98559771, 9177585444665868190L, 8184094097582120545L, 1802563711);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 753633738, 1547643625909579943L, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 1576225478, 6326021262037004184L, null, 1395500794);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 1060673038, 4669572654284616323L, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 1253506816, 7388449971971869127L, null, 1738488913);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 382717534, 6486608014143976786L, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 1256347723, 464916229868684786L, null, 600246041);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 78785481, 1097419816669488219L, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 74189247, 3632362434960214533L, 8435725982454344810L, 72738787);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 818965374, 4795728400489215326L, 542002987634780134L, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, 59274655, 6547333567957915687L, 2599593301869826969L, 1812187279);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Int64bigint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
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
                var models =  ((IInt64SingleTypebigint)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40344947));
                Assert.That(model.Value, Is.EqualTo(2308649354598289424L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(452642619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3309039605195097946L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57942081));
                Assert.That(model.Value, Is.EqualTo(5057429318764196582L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5560037296144863927L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59274655));
                Assert.That(model.Value, Is.EqualTo(6547333567957915687L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2599593301869826969L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1812187279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(5041894272929856923L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(6786805132985039265L));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74189247));
                Assert.That(model.Value, Is.EqualTo(3632362434960214533L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8435725982454344810L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(72738787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7986089637726138320L));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78785481));
                Assert.That(model.Value, Is.EqualTo(1097419816669488219L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

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
                var models = await ((IInt64SingleTypebigint)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40344947));
                Assert.That(model.Value, Is.EqualTo(2308649354598289424L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(452642619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3309039605195097946L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57942081));
                Assert.That(model.Value, Is.EqualTo(5057429318764196582L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5560037296144863927L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59274655));
                Assert.That(model.Value, Is.EqualTo(6547333567957915687L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2599593301869826969L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1812187279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(5041894272929856923L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(6786805132985039265L));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74189247));
                Assert.That(model.Value, Is.EqualTo(3632362434960214533L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8435725982454344810L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(72738787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7986089637726138320L));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78785481));
                Assert.That(model.Value, Is.EqualTo(1097419816669488219L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Int64bigint0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
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
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40344947));
                Assert.That(model.Value, Is.EqualTo(2308649354598289424L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(452642619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3309039605195097946L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57942081));
                Assert.That(model.Value, Is.EqualTo(5057429318764196582L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5560037296144863927L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59274655));
                Assert.That(model.Value, Is.EqualTo(6547333567957915687L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2599593301869826969L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1812187279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(5041894272929856923L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(6786805132985039265L));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74189247));
                Assert.That(model.Value, Is.EqualTo(3632362434960214533L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8435725982454344810L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(72738787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7986089637726138320L));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78785481));
                Assert.That(model.Value, Is.EqualTo(1097419816669488219L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

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
                var models = await ((IInt64SingleTypebigint)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40344947));
                Assert.That(model.Value, Is.EqualTo(2308649354598289424L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(452642619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3309039605195097946L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57942081));
                Assert.That(model.Value, Is.EqualTo(5057429318764196582L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5560037296144863927L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59274655));
                Assert.That(model.Value, Is.EqualTo(6547333567957915687L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2599593301869826969L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1812187279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(5041894272929856923L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(6786805132985039265L));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74189247));
                Assert.That(model.Value, Is.EqualTo(3632362434960214533L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8435725982454344810L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(72738787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7986089637726138320L));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78785481));
                Assert.That(model.Value, Is.EqualTo(1097419816669488219L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

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
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 78785481);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

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
                await using var cmd = await ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 968384382);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(15));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
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
                 foreach(var batchResult in ((IInt64SingleTypebigint)this).DbConnectionSelectModelBatch(connection, 1508992424, 1060673038))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

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
                await foreach(var batchResult in ((IInt64SingleTypebigint)this).DbConnectionSelectModelBatchAsync(connection, 74189247, 59274655))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78785481));
                Assert.That(model.Value, Is.EqualTo(1097419816669488219L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74189247));
                Assert.That(model.Value, Is.EqualTo(3632362434960214533L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8435725982454344810L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(72738787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7986089637726138320L));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78785481));
                Assert.That(model.Value, Is.EqualTo(1097419816669488219L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
            asPartInterface: typeof(IInt64SingleTypebigint)
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
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40344947)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2308649354598289424L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((452642619)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3309039605195097946L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57942081)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5057429318764196582L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5560037296144863927L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59274655)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6547333567957915687L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1812187279)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5041894272929856923L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6786805132985039265L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2599593301869826969L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74189247)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3632362434960214533L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72738787)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8113773442562583836L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7986089637726138320L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8435725982454344810L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78785481)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1097419816669488219L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98559771)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9177585444665868190L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1802563711)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8012973511574712635L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8184094097582120545L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155589078)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4272632285301793569L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53877180)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1675518226363454246L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7806675322051864360L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1993035378299100570L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((306825477)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6508119393002423162L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1741024606)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7723615588163314169L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4261164882629897598L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((382717534)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6486608014143976786L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((459807877)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6262509823475375859L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((724154078917944382L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((640469878)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5478041313605469419L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((568029700)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1525925755039870897L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5466596161507594298L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((753633738)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1547643625909579943L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((818965374)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4795728400489215326L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((542002987634780134L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((967749315)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1334930021986064782L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9192549377260155403L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((968384382)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((469711638159182142L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1375976665820404121L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1060673038)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4669572654284616323L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1148406366)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((448405001497117968L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71239909)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7469997296017959702L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2974475222638579319L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3825625540757600893L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1253506816)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7388449971971869127L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1738488913)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1540048975307919625L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1210448987025574995L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1256347723)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((464916229868684786L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((600246041)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1233998034528324228L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5491748076513616585L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1286860534)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1199734675443779979L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((35805234119486L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1329062113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6707486233634032075L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1411342379)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8655869207182053454L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1283348994)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1547659163322593916L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((34374717811084202L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2524576254198191356L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1422563537)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8218308016626513971L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1508992424)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3107582922041641848L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1576225478)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6326021262037004184L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1395500794)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7195828309788898505L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1703193664)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6816157906395038550L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1859992527)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1108717524861283994L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1670444500)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8980241307684680696L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5395251056627669665L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((903352982503119017L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1962163988)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9061462882247397458L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1763576046)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8990755333158151214L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((71082852900023843L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1971170795)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2602524439826322743L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1907286071)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4769306616358592167L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8499169772550170975L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2015099342)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4294096057579522468L)));//Value

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
                var models = await ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40344947)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2308649354598289424L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((452642619)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3309039605195097946L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57942081)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5057429318764196582L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5560037296144863927L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59274655)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6547333567957915687L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1812187279)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5041894272929856923L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6786805132985039265L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2599593301869826969L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74189247)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3632362434960214533L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72738787)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8113773442562583836L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7986089637726138320L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8435725982454344810L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78785481)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1097419816669488219L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98559771)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9177585444665868190L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1802563711)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8012973511574712635L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8184094097582120545L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155589078)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4272632285301793569L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53877180)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1675518226363454246L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7806675322051864360L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1993035378299100570L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((306825477)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6508119393002423162L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1741024606)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7723615588163314169L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4261164882629897598L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((382717534)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6486608014143976786L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((459807877)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6262509823475375859L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((724154078917944382L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((640469878)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5478041313605469419L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((568029700)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1525925755039870897L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5466596161507594298L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((753633738)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1547643625909579943L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((818965374)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4795728400489215326L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((542002987634780134L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((967749315)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1334930021986064782L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9192549377260155403L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((968384382)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((469711638159182142L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1375976665820404121L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1060673038)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4669572654284616323L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1148406366)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((448405001497117968L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71239909)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7469997296017959702L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2974475222638579319L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3825625540757600893L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1253506816)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7388449971971869127L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1738488913)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1540048975307919625L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1210448987025574995L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1256347723)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((464916229868684786L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((600246041)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1233998034528324228L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5491748076513616585L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1286860534)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1199734675443779979L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((35805234119486L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1329062113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6707486233634032075L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1411342379)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8655869207182053454L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1283348994)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1547659163322593916L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((34374717811084202L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2524576254198191356L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1422563537)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8218308016626513971L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1508992424)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3107582922041641848L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1576225478)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6326021262037004184L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1395500794)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7195828309788898505L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1703193664)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6816157906395038550L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1859992527)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1108717524861283994L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1670444500)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8980241307684680696L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5395251056627669665L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((903352982503119017L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1962163988)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9061462882247397458L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1763576046)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8990755333158151214L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((71082852900023843L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1971170795)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2602524439826322743L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1907286071)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4769306616358592167L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8499169772550170975L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2015099342)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4294096057579522468L)));//Value

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
COPY public.binary_int64bigint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
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
FROM public.binary_int64bigint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Int64bigint0MI),
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

                var importCollection = new List<Int64bigint0MI>(7);

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 53877180,
                    Value = 1675518226363454246L,
                    NullableValue = 7806675322051864360L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 71239909,
                    Value = 7469997296017959702L,
                    NullableValue = 2974475222638579319L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 72738787,
                    Value = 8113773442562583836L,
                    NullableValue = 7986089637726138320L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 452642619,
                    Value = 3309039605195097946L,
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 568029700,
                    Value = 1525925755039870897L,
                    NullableValue = 5466596161507594298L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 600246041,
                    Value = 1233998034528324228L,
                    NullableValue = 5491748076513616585L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1283348994,
                    Value = 1547659163322593916L,
                    NullableValue = 34374717811084202L
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53877180));
                Assert.That(model.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(7806675322051864360L));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(71239909));
                Assert.That(model.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2974475222638579319L));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72738787));
                Assert.That(model.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(7986089637726138320L));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(452642619));
                Assert.That(model.Value, Is.EqualTo(3309039605195097946L));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(568029700));
                Assert.That(model.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5466596161507594298L));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(600246041));
                Assert.That(model.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5491748076513616585L));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1283348994));
                Assert.That(model.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(34374717811084202L));

                importCollection.Clear();

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1395500794,
                    Value = 7195828309788898505L,
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1670444500,
                    Value = 8980241307684680696L,
                    NullableValue = 5395251056627669665L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1738488913,
                    Value = 1540048975307919625L,
                    NullableValue = 1210448987025574995L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1741024606,
                    Value = 7723615588163314169L,
                    NullableValue = 4261164882629897598L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1763576046,
                    Value = 8990755333158151214L,
                    NullableValue = 71082852900023843L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1802563711,
                    Value = 8012973511574712635L,
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1812187279,
                    Value = 5041894272929856923L,
                    NullableValue = 6786805132985039265L
                });

                importCollection.Add(
                new Int64bigint0MI
                {
                    Id = 1907286071,
                    Value = 4769306616358592167L,
                    NullableValue = 8499169772550170975L
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53877180));
                Assert.That(model.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(7806675322051864360L));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(71239909));
                Assert.That(model.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2974475222638579319L));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(72738787));
                Assert.That(model.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(7986089637726138320L));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(452642619));
                Assert.That(model.Value, Is.EqualTo(3309039605195097946L));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(568029700));
                Assert.That(model.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5466596161507594298L));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(600246041));
                Assert.That(model.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5491748076513616585L));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1283348994));
                Assert.That(model.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(34374717811084202L));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1395500794));
                Assert.That(model.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1670444500));
                Assert.That(model.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5395251056627669665L));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1738488913));
                Assert.That(model.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1210448987025574995L));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1741024606));
                Assert.That(model.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(4261164882629897598L));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1763576046));
                Assert.That(model.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(71082852900023843L));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802563711));
                Assert.That(model.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1812187279));
                Assert.That(model.Value, Is.EqualTo(5041894272929856923L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(6786805132985039265L));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1907286071));
                Assert.That(model.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8499169772550170975L));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1)
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
FROM public.binary_int64bigint0m m
LEFT JOIN public.binary_int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Int64bigint0M),
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

                var importCollection = new List<Int64bigint0M>(15);

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 40344947,
                    Value = 2308649354598289424L,
                    NullableValue = null,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 452642619
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 57942081,
                    Value = 5057429318764196582L,
                    NullableValue = 5560037296144863927L,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 59274655,
                    Value = 6547333567957915687L,
                    NullableValue = 2599593301869826969L,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1812187279
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 74189247,
                    Value = 3632362434960214533L,
                    NullableValue = 8435725982454344810L,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 72738787
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 78785481,
                    Value = 1097419816669488219L,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 98559771,
                    Value = 9177585444665868190L,
                    NullableValue = 8184094097582120545L,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1802563711
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 155589078,
                    Value = 4272632285301793569L,
                    NullableValue = 1993035378299100570L,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 53877180
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 306825477,
                    Value = 6508119393002423162L,
                    NullableValue = null,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1741024606
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 382717534,
                    Value = 6486608014143976786L,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 459807877,
                    Value = 6262509823475375859L,
                    NullableValue = 724154078917944382L,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 640469878,
                    Value = 5478041313605469419L,
                    NullableValue = null,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 568029700
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 753633738,
                    Value = 1547643625909579943L,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 818965374,
                    Value = 4795728400489215326L,
                    NullableValue = 542002987634780134L,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 967749315,
                    Value = 1334930021986064782L,
                    NullableValue = 9192549377260155403L,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 968384382,
                    Value = 469711638159182142L,
                    NullableValue = 1375976665820404121L,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40344947));
                Assert.That(model.Value, Is.EqualTo(2308649354598289424L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(452642619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3309039605195097946L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57942081));
                Assert.That(model.Value, Is.EqualTo(5057429318764196582L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5560037296144863927L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59274655));
                Assert.That(model.Value, Is.EqualTo(6547333567957915687L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2599593301869826969L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1812187279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(5041894272929856923L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(6786805132985039265L));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74189247));
                Assert.That(model.Value, Is.EqualTo(3632362434960214533L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8435725982454344810L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(72738787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7986089637726138320L));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78785481));
                Assert.That(model.Value, Is.EqualTo(1097419816669488219L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1060673038,
                    Value = 4669572654284616323L,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1148406366,
                    Value = 448405001497117968L,
                    NullableValue = 3825625540757600893L,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 71239909
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1253506816,
                    Value = 7388449971971869127L,
                    NullableValue = null,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1738488913
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1256347723,
                    Value = 464916229868684786L,
                    NullableValue = null,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 600246041
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1286860534,
                    Value = 1199734675443779979L,
                    NullableValue = 35805234119486L,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1329062113,
                    Value = 6707486233634032075L,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1411342379,
                    Value = 8655869207182053454L,
                    NullableValue = 2524576254198191356L,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1283348994
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1422563537,
                    Value = 8218308016626513971L,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1508992424,
                    Value = 3107582922041641848L,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1576225478,
                    Value = 6326021262037004184L,
                    NullableValue = null,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1395500794
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1703193664,
                    Value = 6816157906395038550L,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1859992527,
                    Value = 1108717524861283994L,
                    NullableValue = 903352982503119017L,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1670444500
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1962163988,
                    Value = 9061462882247397458L,
                    NullableValue = null,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1763576046
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 1971170795,
                    Value = 2602524439826322743L,
                    NullableValue = null,

                    ModelInner = new Int64bigint0MI 
                    {
                        Id = 1907286071
                    }

                });

                importCollection.Add(
                new Int64bigint0M
                {
                    Id = 2015099342,
                    Value = 4294096057579522468L,
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40344947));
                Assert.That(model.Value, Is.EqualTo(2308649354598289424L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(452642619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(3309039605195097946L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57942081));
                Assert.That(model.Value, Is.EqualTo(5057429318764196582L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5560037296144863927L));

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59274655));
                Assert.That(model.Value, Is.EqualTo(6547333567957915687L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2599593301869826969L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1812187279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(5041894272929856923L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(6786805132985039265L));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(74189247));
                Assert.That(model.Value, Is.EqualTo(3632362434960214533L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8435725982454344810L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(72738787));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8113773442562583836L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7986089637726138320L));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78785481));
                Assert.That(model.Value, Is.EqualTo(1097419816669488219L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(98559771));
                Assert.That(model.Value, Is.EqualTo(9177585444665868190L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8184094097582120545L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1802563711));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8012973511574712635L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155589078));
                Assert.That(model.Value, Is.EqualTo(4272632285301793569L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1993035378299100570L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(53877180));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1675518226363454246L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7806675322051864360L));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(306825477));
                Assert.That(model.Value, Is.EqualTo(6508119393002423162L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741024606));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7723615588163314169L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(4261164882629897598L));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382717534));
                Assert.That(model.Value, Is.EqualTo(6486608014143976786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(459807877));
                Assert.That(model.Value, Is.EqualTo(6262509823475375859L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(724154078917944382L));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(640469878));
                Assert.That(model.Value, Is.EqualTo(5478041313605469419L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(568029700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1525925755039870897L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5466596161507594298L));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(753633738));
                Assert.That(model.Value, Is.EqualTo(1547643625909579943L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(818965374));
                Assert.That(model.Value, Is.EqualTo(4795728400489215326L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(542002987634780134L));

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(967749315));
                Assert.That(model.Value, Is.EqualTo(1334930021986064782L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(9192549377260155403L));

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(968384382));
                Assert.That(model.Value, Is.EqualTo(469711638159182142L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1375976665820404121L));

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060673038));
                Assert.That(model.Value, Is.EqualTo(4669572654284616323L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148406366));
                Assert.That(model.Value, Is.EqualTo(448405001497117968L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(3825625540757600893L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(71239909));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7469997296017959702L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2974475222638579319L));


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253506816));
                Assert.That(model.Value, Is.EqualTo(7388449971971869127L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738488913));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1540048975307919625L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210448987025574995L));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1256347723));
                Assert.That(model.Value, Is.EqualTo(464916229868684786L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(600246041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1233998034528324228L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5491748076513616585L));


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286860534));
                Assert.That(model.Value, Is.EqualTo(1199734675443779979L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(35805234119486L));

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329062113));
                Assert.That(model.Value, Is.EqualTo(6707486233634032075L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1411342379));
                Assert.That(model.Value, Is.EqualTo(8655869207182053454L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2524576254198191356L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283348994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1547659163322593916L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(34374717811084202L));


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422563537));
                Assert.That(model.Value, Is.EqualTo(8218308016626513971L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508992424));
                Assert.That(model.Value, Is.EqualTo(3107582922041641848L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576225478));
                Assert.That(model.Value, Is.EqualTo(6326021262037004184L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1395500794));

                Assert.That(model.ModelInner.Value, Is.EqualTo(7195828309788898505L));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1703193664));
                Assert.That(model.Value, Is.EqualTo(6816157906395038550L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859992527));
                Assert.That(model.Value, Is.EqualTo(1108717524861283994L));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(903352982503119017L));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1670444500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8980241307684680696L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(5395251056627669665L));


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962163988));
                Assert.That(model.Value, Is.EqualTo(9061462882247397458L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1763576046));

                Assert.That(model.ModelInner.Value, Is.EqualTo(8990755333158151214L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(71082852900023843L));


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1971170795));
                Assert.That(model.Value, Is.EqualTo(2602524439826322743L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1907286071));

                Assert.That(model.ModelInner.Value, Is.EqualTo(4769306616358592167L));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8499169772550170975L));


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2015099342));
                Assert.That(model.Value, Is.EqualTo(4294096057579522468L));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Int64bigint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1)
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

                var expected = new Dictionary<System.Int32,Int64bigint0M>(30);

                expected.Add(
                    40344947,
                    new Int64bigint0M
                    {
                        Id = 40344947,
                        Value = 2308649354598289424L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 452642619,
                            Value = 3309039605195097946L,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    57942081,
                    new Int64bigint0M
                    {
                        Id = 57942081,
                        Value = 5057429318764196582L,
                        NullableValue = 5560037296144863927L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    59274655,
                    new Int64bigint0M
                    {
                        Id = 59274655,
                        Value = 6547333567957915687L,
                        NullableValue = 2599593301869826969L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1812187279,
                            Value = 5041894272929856923L,
                            NullableValue = 6786805132985039265L
                        }

                    }
                );

                expected.Add(
                    74189247,
                    new Int64bigint0M
                    {
                        Id = 74189247,
                        Value = 3632362434960214533L,
                        NullableValue = 8435725982454344810L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 72738787,
                            Value = 8113773442562583836L,
                            NullableValue = 7986089637726138320L
                        }

                    }
                );

                expected.Add(
                    78785481,
                    new Int64bigint0M
                    {
                        Id = 78785481,
                        Value = 1097419816669488219L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    98559771,
                    new Int64bigint0M
                    {
                        Id = 98559771,
                        Value = 9177585444665868190L,
                        NullableValue = 8184094097582120545L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1802563711,
                            Value = 8012973511574712635L,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    155589078,
                    new Int64bigint0M
                    {
                        Id = 155589078,
                        Value = 4272632285301793569L,
                        NullableValue = 1993035378299100570L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 53877180,
                            Value = 1675518226363454246L,
                            NullableValue = 7806675322051864360L
                        }

                    }
                );

                expected.Add(
                    306825477,
                    new Int64bigint0M
                    {
                        Id = 306825477,
                        Value = 6508119393002423162L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1741024606,
                            Value = 7723615588163314169L,
                            NullableValue = 4261164882629897598L
                        }

                    }
                );

                expected.Add(
                    382717534,
                    new Int64bigint0M
                    {
                        Id = 382717534,
                        Value = 6486608014143976786L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    459807877,
                    new Int64bigint0M
                    {
                        Id = 459807877,
                        Value = 6262509823475375859L,
                        NullableValue = 724154078917944382L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    640469878,
                    new Int64bigint0M
                    {
                        Id = 640469878,
                        Value = 5478041313605469419L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 568029700,
                            Value = 1525925755039870897L,
                            NullableValue = 5466596161507594298L
                        }

                    }
                );

                expected.Add(
                    753633738,
                    new Int64bigint0M
                    {
                        Id = 753633738,
                        Value = 1547643625909579943L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    818965374,
                    new Int64bigint0M
                    {
                        Id = 818965374,
                        Value = 4795728400489215326L,
                        NullableValue = 542002987634780134L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    967749315,
                    new Int64bigint0M
                    {
                        Id = 967749315,
                        Value = 1334930021986064782L,
                        NullableValue = 9192549377260155403L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    968384382,
                    new Int64bigint0M
                    {
                        Id = 968384382,
                        Value = 469711638159182142L,
                        NullableValue = 1375976665820404121L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1060673038,
                    new Int64bigint0M
                    {
                        Id = 1060673038,
                        Value = 4669572654284616323L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1148406366,
                    new Int64bigint0M
                    {
                        Id = 1148406366,
                        Value = 448405001497117968L,
                        NullableValue = 3825625540757600893L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 71239909,
                            Value = 7469997296017959702L,
                            NullableValue = 2974475222638579319L
                        }

                    }
                );

                expected.Add(
                    1253506816,
                    new Int64bigint0M
                    {
                        Id = 1253506816,
                        Value = 7388449971971869127L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1738488913,
                            Value = 1540048975307919625L,
                            NullableValue = 1210448987025574995L
                        }

                    }
                );

                expected.Add(
                    1256347723,
                    new Int64bigint0M
                    {
                        Id = 1256347723,
                        Value = 464916229868684786L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 600246041,
                            Value = 1233998034528324228L,
                            NullableValue = 5491748076513616585L
                        }

                    }
                );

                expected.Add(
                    1286860534,
                    new Int64bigint0M
                    {
                        Id = 1286860534,
                        Value = 1199734675443779979L,
                        NullableValue = 35805234119486L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1329062113,
                    new Int64bigint0M
                    {
                        Id = 1329062113,
                        Value = 6707486233634032075L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1411342379,
                    new Int64bigint0M
                    {
                        Id = 1411342379,
                        Value = 8655869207182053454L,
                        NullableValue = 2524576254198191356L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1283348994,
                            Value = 1547659163322593916L,
                            NullableValue = 34374717811084202L
                        }

                    }
                );

                expected.Add(
                    1422563537,
                    new Int64bigint0M
                    {
                        Id = 1422563537,
                        Value = 8218308016626513971L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1508992424,
                    new Int64bigint0M
                    {
                        Id = 1508992424,
                        Value = 3107582922041641848L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1576225478,
                    new Int64bigint0M
                    {
                        Id = 1576225478,
                        Value = 6326021262037004184L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1395500794,
                            Value = 7195828309788898505L,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1703193664,
                    new Int64bigint0M
                    {
                        Id = 1703193664,
                        Value = 6816157906395038550L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1859992527,
                    new Int64bigint0M
                    {
                        Id = 1859992527,
                        Value = 1108717524861283994L,
                        NullableValue = 903352982503119017L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1670444500,
                            Value = 8980241307684680696L,
                            NullableValue = 5395251056627669665L
                        }

                    }
                );

                expected.Add(
                    1962163988,
                    new Int64bigint0M
                    {
                        Id = 1962163988,
                        Value = 9061462882247397458L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1763576046,
                            Value = 8990755333158151214L,
                            NullableValue = 71082852900023843L
                        }

                    }
                );

                expected.Add(
                    1971170795,
                    new Int64bigint0M
                    {
                        Id = 1971170795,
                        Value = 2602524439826322743L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1907286071,
                            Value = 4769306616358592167L,
                            NullableValue = 8499169772550170975L
                        }

                    }
                );

                expected.Add(
                    2015099342,
                    new Int64bigint0M
                    {
                        Id = 2015099342,
                        Value = 4294096057579522468L,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64)default));
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

                var expected = new Dictionary<System.Int32,Int64bigint0M>(30);

                expected.Add(
                    40344947,
                    new Int64bigint0M
                    {
                        Id = 40344947,
                        Value = 2308649354598289424L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 452642619,
                            Value = 3309039605195097946L,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    57942081,
                    new Int64bigint0M
                    {
                        Id = 57942081,
                        Value = 5057429318764196582L,
                        NullableValue = 5560037296144863927L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    59274655,
                    new Int64bigint0M
                    {
                        Id = 59274655,
                        Value = 6547333567957915687L,
                        NullableValue = 2599593301869826969L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1812187279,
                            Value = 5041894272929856923L,
                            NullableValue = 6786805132985039265L
                        }

                    }
                );

                expected.Add(
                    74189247,
                    new Int64bigint0M
                    {
                        Id = 74189247,
                        Value = 3632362434960214533L,
                        NullableValue = 8435725982454344810L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 72738787,
                            Value = 8113773442562583836L,
                            NullableValue = 7986089637726138320L
                        }

                    }
                );

                expected.Add(
                    78785481,
                    new Int64bigint0M
                    {
                        Id = 78785481,
                        Value = 1097419816669488219L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    98559771,
                    new Int64bigint0M
                    {
                        Id = 98559771,
                        Value = 9177585444665868190L,
                        NullableValue = 8184094097582120545L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1802563711,
                            Value = 8012973511574712635L,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    155589078,
                    new Int64bigint0M
                    {
                        Id = 155589078,
                        Value = 4272632285301793569L,
                        NullableValue = 1993035378299100570L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 53877180,
                            Value = 1675518226363454246L,
                            NullableValue = 7806675322051864360L
                        }

                    }
                );

                expected.Add(
                    306825477,
                    new Int64bigint0M
                    {
                        Id = 306825477,
                        Value = 6508119393002423162L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1741024606,
                            Value = 7723615588163314169L,
                            NullableValue = 4261164882629897598L
                        }

                    }
                );

                expected.Add(
                    382717534,
                    new Int64bigint0M
                    {
                        Id = 382717534,
                        Value = 6486608014143976786L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    459807877,
                    new Int64bigint0M
                    {
                        Id = 459807877,
                        Value = 6262509823475375859L,
                        NullableValue = 724154078917944382L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    640469878,
                    new Int64bigint0M
                    {
                        Id = 640469878,
                        Value = 5478041313605469419L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 568029700,
                            Value = 1525925755039870897L,
                            NullableValue = 5466596161507594298L
                        }

                    }
                );

                expected.Add(
                    753633738,
                    new Int64bigint0M
                    {
                        Id = 753633738,
                        Value = 1547643625909579943L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    818965374,
                    new Int64bigint0M
                    {
                        Id = 818965374,
                        Value = 4795728400489215326L,
                        NullableValue = 542002987634780134L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    967749315,
                    new Int64bigint0M
                    {
                        Id = 967749315,
                        Value = 1334930021986064782L,
                        NullableValue = 9192549377260155403L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    968384382,
                    new Int64bigint0M
                    {
                        Id = 968384382,
                        Value = 469711638159182142L,
                        NullableValue = 1375976665820404121L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1060673038,
                    new Int64bigint0M
                    {
                        Id = 1060673038,
                        Value = 4669572654284616323L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1148406366,
                    new Int64bigint0M
                    {
                        Id = 1148406366,
                        Value = 448405001497117968L,
                        NullableValue = 3825625540757600893L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 71239909,
                            Value = 7469997296017959702L,
                            NullableValue = 2974475222638579319L
                        }

                    }
                );

                expected.Add(
                    1253506816,
                    new Int64bigint0M
                    {
                        Id = 1253506816,
                        Value = 7388449971971869127L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1738488913,
                            Value = 1540048975307919625L,
                            NullableValue = 1210448987025574995L
                        }

                    }
                );

                expected.Add(
                    1256347723,
                    new Int64bigint0M
                    {
                        Id = 1256347723,
                        Value = 464916229868684786L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 600246041,
                            Value = 1233998034528324228L,
                            NullableValue = 5491748076513616585L
                        }

                    }
                );

                expected.Add(
                    1286860534,
                    new Int64bigint0M
                    {
                        Id = 1286860534,
                        Value = 1199734675443779979L,
                        NullableValue = 35805234119486L,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1329062113,
                    new Int64bigint0M
                    {
                        Id = 1329062113,
                        Value = 6707486233634032075L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1411342379,
                    new Int64bigint0M
                    {
                        Id = 1411342379,
                        Value = 8655869207182053454L,
                        NullableValue = 2524576254198191356L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1283348994,
                            Value = 1547659163322593916L,
                            NullableValue = 34374717811084202L
                        }

                    }
                );

                expected.Add(
                    1422563537,
                    new Int64bigint0M
                    {
                        Id = 1422563537,
                        Value = 8218308016626513971L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1508992424,
                    new Int64bigint0M
                    {
                        Id = 1508992424,
                        Value = 3107582922041641848L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1576225478,
                    new Int64bigint0M
                    {
                        Id = 1576225478,
                        Value = 6326021262037004184L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1395500794,
                            Value = 7195828309788898505L,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1703193664,
                    new Int64bigint0M
                    {
                        Id = 1703193664,
                        Value = 6816157906395038550L,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1859992527,
                    new Int64bigint0M
                    {
                        Id = 1859992527,
                        Value = 1108717524861283994L,
                        NullableValue = 903352982503119017L,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1670444500,
                            Value = 8980241307684680696L,
                            NullableValue = 5395251056627669665L
                        }

                    }
                );

                expected.Add(
                    1962163988,
                    new Int64bigint0M
                    {
                        Id = 1962163988,
                        Value = 9061462882247397458L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1763576046,
                            Value = 8990755333158151214L,
                            NullableValue = 71082852900023843L
                        }

                    }
                );

                expected.Add(
                    1971170795,
                    new Int64bigint0M
                    {
                        Id = 1971170795,
                        Value = 2602524439826322743L,
                        NullableValue = null,

                        ModelInner = new Int64bigint0MI
                        {
                            Id = 1907286071,
                            Value = 4769306616358592167L,
                            NullableValue = 8499169772550170975L
                        }

                    }
                );

                expected.Add(
                    2015099342,
                    new Int64bigint0M
                    {
                        Id = 2015099342,
                        Value = 4294096057579522468L,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Int64bigint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
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

                var expected = new Dictionary<System.Int32,Int64bigint0MI>(15);

                expected.Add(
                    53877180,
                    new Int64bigint0MI
                    {
                        Id = 53877180,
                        Value = 1675518226363454246L,
                        NullableValue = 7806675322051864360L
                    }
                );

                expected.Add(
                    71239909,
                    new Int64bigint0MI
                    {
                        Id = 71239909,
                        Value = 7469997296017959702L,
                        NullableValue = 2974475222638579319L
                    }
                );

                expected.Add(
                    72738787,
                    new Int64bigint0MI
                    {
                        Id = 72738787,
                        Value = 8113773442562583836L,
                        NullableValue = 7986089637726138320L
                    }
                );

                expected.Add(
                    452642619,
                    new Int64bigint0MI
                    {
                        Id = 452642619,
                        Value = 3309039605195097946L,
                        NullableValue = null
                    }
                );

                expected.Add(
                    568029700,
                    new Int64bigint0MI
                    {
                        Id = 568029700,
                        Value = 1525925755039870897L,
                        NullableValue = 5466596161507594298L
                    }
                );

                expected.Add(
                    600246041,
                    new Int64bigint0MI
                    {
                        Id = 600246041,
                        Value = 1233998034528324228L,
                        NullableValue = 5491748076513616585L
                    }
                );

                expected.Add(
                    1283348994,
                    new Int64bigint0MI
                    {
                        Id = 1283348994,
                        Value = 1547659163322593916L,
                        NullableValue = 34374717811084202L
                    }
                );

                expected.Add(
                    1395500794,
                    new Int64bigint0MI
                    {
                        Id = 1395500794,
                        Value = 7195828309788898505L,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1670444500,
                    new Int64bigint0MI
                    {
                        Id = 1670444500,
                        Value = 8980241307684680696L,
                        NullableValue = 5395251056627669665L
                    }
                );

                expected.Add(
                    1738488913,
                    new Int64bigint0MI
                    {
                        Id = 1738488913,
                        Value = 1540048975307919625L,
                        NullableValue = 1210448987025574995L
                    }
                );

                expected.Add(
                    1741024606,
                    new Int64bigint0MI
                    {
                        Id = 1741024606,
                        Value = 7723615588163314169L,
                        NullableValue = 4261164882629897598L
                    }
                );

                expected.Add(
                    1763576046,
                    new Int64bigint0MI
                    {
                        Id = 1763576046,
                        Value = 8990755333158151214L,
                        NullableValue = 71082852900023843L
                    }
                );

                expected.Add(
                    1802563711,
                    new Int64bigint0MI
                    {
                        Id = 1802563711,
                        Value = 8012973511574712635L,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1812187279,
                    new Int64bigint0MI
                    {
                        Id = 1812187279,
                        Value = 5041894272929856923L,
                        NullableValue = 6786805132985039265L
                    }
                );

                expected.Add(
                    1907286071,
                    new Int64bigint0MI
                    {
                        Id = 1907286071,
                        Value = 4769306616358592167L,
                        NullableValue = 8499169772550170975L
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

                var expected = new Dictionary<System.Int32,Int64bigint0MI>(15);

                expected.Add(
                    53877180,
                    new Int64bigint0MI
                    {
                        Id = 53877180,
                        Value = 1675518226363454246L,
                        NullableValue = 7806675322051864360L
                    }
                );

                expected.Add(
                    71239909,
                    new Int64bigint0MI
                    {
                        Id = 71239909,
                        Value = 7469997296017959702L,
                        NullableValue = 2974475222638579319L
                    }
                );

                expected.Add(
                    72738787,
                    new Int64bigint0MI
                    {
                        Id = 72738787,
                        Value = 8113773442562583836L,
                        NullableValue = 7986089637726138320L
                    }
                );

                expected.Add(
                    452642619,
                    new Int64bigint0MI
                    {
                        Id = 452642619,
                        Value = 3309039605195097946L,
                        NullableValue = null
                    }
                );

                expected.Add(
                    568029700,
                    new Int64bigint0MI
                    {
                        Id = 568029700,
                        Value = 1525925755039870897L,
                        NullableValue = 5466596161507594298L
                    }
                );

                expected.Add(
                    600246041,
                    new Int64bigint0MI
                    {
                        Id = 600246041,
                        Value = 1233998034528324228L,
                        NullableValue = 5491748076513616585L
                    }
                );

                expected.Add(
                    1283348994,
                    new Int64bigint0MI
                    {
                        Id = 1283348994,
                        Value = 1547659163322593916L,
                        NullableValue = 34374717811084202L
                    }
                );

                expected.Add(
                    1395500794,
                    new Int64bigint0MI
                    {
                        Id = 1395500794,
                        Value = 7195828309788898505L,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1670444500,
                    new Int64bigint0MI
                    {
                        Id = 1670444500,
                        Value = 8980241307684680696L,
                        NullableValue = 5395251056627669665L
                    }
                );

                expected.Add(
                    1738488913,
                    new Int64bigint0MI
                    {
                        Id = 1738488913,
                        Value = 1540048975307919625L,
                        NullableValue = 1210448987025574995L
                    }
                );

                expected.Add(
                    1741024606,
                    new Int64bigint0MI
                    {
                        Id = 1741024606,
                        Value = 7723615588163314169L,
                        NullableValue = 4261164882629897598L
                    }
                );

                expected.Add(
                    1763576046,
                    new Int64bigint0MI
                    {
                        Id = 1763576046,
                        Value = 8990755333158151214L,
                        NullableValue = 71082852900023843L
                    }
                );

                expected.Add(
                    1802563711,
                    new Int64bigint0MI
                    {
                        Id = 1802563711,
                        Value = 8012973511574712635L,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1812187279,
                    new Int64bigint0MI
                    {
                        Id = 1812187279,
                        Value = 5041894272929856923L,
                        NullableValue = 6786805132985039265L
                    }
                );

                expected.Add(
                    1907286071,
                    new Int64bigint0MI
                    {
                        Id = 1907286071,
                        Value = 4769306616358592167L,
                        NullableValue = 8499169772550170975L
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


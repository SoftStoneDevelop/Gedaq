

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
    internal partial interface IDecimalSingleTypemoney
    {
    }
    
    internal partial class DecimalSingleTypemoney : IDecimalSingleTypemoney
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoney0mi(
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
            asPartInterface: typeof(IDecimalSingleTypemoney)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoney0mi(
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
            queryMapType: typeof(Decimalmoney0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)
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

                changedRows =  ((IDecimalSingleTypemoney)this).InsertModelInner(connection, 401674982, 0.86m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypemoney)this).InsertModelInner(connection, 2038415176, 0.74m, null);
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

                changedRows = await ((IDecimalSingleTypemoney)this).InsertModelInnerAsync(connection, 1084772830, 0.05m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).InsertModelInnerAsync(connection, 1338765106, 0.57m, null);
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

                id =  ((IDecimalSingleTypemoney)this).InsertModelInnerReturning(connection, 783615338, 0.87m, null);
                Assert.That(id, Is.EqualTo(783615338));

                id =  ((IDecimalSingleTypemoney)this).InsertModelInnerReturning(connection, 1522480127, 0.89m, 0.80m);
                Assert.That(id, Is.EqualTo(1522480127));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDecimalSingleTypemoney)this).InsertModelInnerReturningAsync(connection, 1355797907, 0.63m, null);
                Assert.That(id, Is.EqualTo(1355797907));

                id = await ((IDecimalSingleTypemoney)this).InsertModelInnerReturningAsync(connection, 1686700011, 0.30m, 0.88m);
                Assert.That(id, Is.EqualTo(1686700011));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoney0mi(
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
            asPartInterface: typeof(IDecimalSingleTypemoney)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(4)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(4), 
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

                changedRows =  ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModel(connection, 548264416, 0.37m, 0.56m);
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

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, 869949868, 0.24m, 0.22m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, 121334405, 0.55m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, 1767098856, 0.67m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, 285086449, 0.43m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, 638577460, 0.90m, 0.18m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, 1311918657, 0.80m, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoney0m(
	id,
    value,
    nullablevalue,
    decimalmoney0mi_id
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
            asPartInterface: typeof(IDecimalSingleTypemoney)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoney0mi_id", 
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

                changedRows =  ((IDecimalSingleTypemoney)this).InsertModel(connection, 1334457063, 0.62m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypemoney)this).InsertModel(connection, 1048528305, 0.67m, 0.43m, 401674982);
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

                changedRows = await ((IDecimalSingleTypemoney)this).InsertModelAsync(connection, 355077570, 0.66m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).InsertModelAsync(connection, 1014891415, 0.15m, 0.70m, 2038415176);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;

                nullable =  ((IDecimalSingleTypemoney)this).ScalarInsertModelReturning(connection, 1282690059, 0.19m, null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IDecimalSingleTypemoney)this).ScalarInsertModelReturning(connection, 37958078, 0.43m, 0.62m, 1084772830);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.62m));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;

                nullable = await ((IDecimalSingleTypemoney)this).ScalarInsertModelReturningAsync(connection, 777202605, 0.68m, null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((IDecimalSingleTypemoney)this).ScalarInsertModelReturningAsync(connection, 624060420, 0.01m, null, 1338765106);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoney0m(
	id,
    value,
    nullablevalue,
    decimalmoney0mi_id
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
    decimalmoney0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Decimalmoney0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoney0mi_id", 
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
                List<Decimalmoney0M> models = null;
                Decimalmoney0M model = null;

                models =  ((IDecimalSingleTypemoney)this).InsertModelReturning(connection, 771541715, 0.62m, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDecimalSingleTypemoney)this).InsertModelReturning(connection, 1076832531, 0.66m, 0.27m, 783615338).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDecimalSingleTypemoney)this).InsertModelReturning(connection, 226924479, 0.64m, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226924479));
                Assert.That(model.Value, Is.EqualTo(0.64m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDecimalSingleTypemoney)this).InsertModelReturning(connection, 1652183958, 0.89m, null, 1522480127).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Decimalmoney0M> models = null;
                Decimalmoney0M model = null;

                models = await ((IDecimalSingleTypemoney)this).InsertModelReturningAsync(connection, 2018724342, 0.44m, 0.72m, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalSingleTypemoney)this).InsertModelReturningAsync(connection, 1224742969, 0.39m, null, 1355797907).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalSingleTypemoney)this).InsertModelReturningAsync(connection, 1312582003, 0.47m, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalSingleTypemoney)this).InsertModelReturningAsync(connection, 1257636378, 0.14m, null, 1686700011).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoney0m(
	id,
    value,
    nullablevalue,
    decimalmoney0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimalmoney0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Decimal), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(4)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(4),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimalmoney0mi_id", 
                methodParametrName: "decimalmoney0mi_id", 
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

                changedRows =  ((IDecimalSingleTypemoney)this).DbConnectionInsertModel(connection, 2008072505, 0.69m, 0.21m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypemoney)this).DbConnectionInsertModel(connection, 418756824, 0.00m, 0.29m, 548264416);
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

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 187322361, 0.27m, 0.17m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 954511594, 0.49m, null, 869949868);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 676265474, 0.93m, 0.95m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 204491834, 0.11m, null, 121334405);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 581423007, 0.15m, 0.21m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 797829862, 0.98m, 0.60m, 1767098856);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 57761786, 0.71m, 0.80m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 1813613197, 0.69m, null, 285086449);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 1311630577, 0.08m, 0.41m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 53227402, 0.02m, null, 638577460);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 741111582, 0.95m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, 1227274583, 0.49m, null, 1311918657);
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
FROM public.decimalmoney0m m
LEFT JOIN public.decimalmoney0mi mi ON mi.id = m.decimalmoney0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Decimalmoney0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)
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
                var models =  ((IDecimalSingleTypemoney)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37958078));
                Assert.That(model.Value, Is.EqualTo(0.43m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.62m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084772830));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53227402));
                Assert.That(model.Value, Is.EqualTo(0.02m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(638577460));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.90m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.18m));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57761786));
                Assert.That(model.Value, Is.EqualTo(0.71m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187322361));
                Assert.That(model.Value, Is.EqualTo(0.27m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.17m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204491834));
                Assert.That(model.Value, Is.EqualTo(0.11m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(121334405));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.55m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226924479));
                Assert.That(model.Value, Is.EqualTo(0.64m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355077570));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(418756824));
                Assert.That(model.Value, Is.EqualTo(0.00m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.29m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(548264416));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581423007));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624060420));
                Assert.That(model.Value, Is.EqualTo(0.01m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1338765106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.57m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(676265474));
                Assert.That(model.Value, Is.EqualTo(0.93m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(741111582));
                Assert.That(model.Value, Is.EqualTo(0.95m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777202605));
                Assert.That(model.Value, Is.EqualTo(0.68m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797829862));
                Assert.That(model.Value, Is.EqualTo(0.98m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.60m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767098856));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.67m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954511594));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(869949868));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.24m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22m));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014891415));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.70m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038415176));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.74m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1048528305));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401674982));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.86m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.87m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.63m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypemoney)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37958078));
                Assert.That(model.Value, Is.EqualTo(0.43m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.62m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084772830));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53227402));
                Assert.That(model.Value, Is.EqualTo(0.02m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(638577460));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.90m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.18m));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57761786));
                Assert.That(model.Value, Is.EqualTo(0.71m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187322361));
                Assert.That(model.Value, Is.EqualTo(0.27m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.17m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204491834));
                Assert.That(model.Value, Is.EqualTo(0.11m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(121334405));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.55m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226924479));
                Assert.That(model.Value, Is.EqualTo(0.64m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355077570));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(418756824));
                Assert.That(model.Value, Is.EqualTo(0.00m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.29m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(548264416));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581423007));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624060420));
                Assert.That(model.Value, Is.EqualTo(0.01m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1338765106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.57m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(676265474));
                Assert.That(model.Value, Is.EqualTo(0.93m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(741111582));
                Assert.That(model.Value, Is.EqualTo(0.95m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777202605));
                Assert.That(model.Value, Is.EqualTo(0.68m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797829862));
                Assert.That(model.Value, Is.EqualTo(0.98m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.60m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767098856));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.67m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954511594));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(869949868));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.24m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22m));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014891415));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.70m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038415176));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.74m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1048528305));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401674982));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.86m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.87m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.63m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

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
FROM public.decimalmoney0m m
LEFT JOIN public.decimalmoney0mi mi ON mi.id = m.decimalmoney0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Decimalmoney0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)
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
                var models =  ((IDecimalSingleTypemoney)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37958078));
                Assert.That(model.Value, Is.EqualTo(0.43m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.62m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084772830));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53227402));
                Assert.That(model.Value, Is.EqualTo(0.02m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(638577460));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.90m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.18m));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57761786));
                Assert.That(model.Value, Is.EqualTo(0.71m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187322361));
                Assert.That(model.Value, Is.EqualTo(0.27m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.17m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204491834));
                Assert.That(model.Value, Is.EqualTo(0.11m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(121334405));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.55m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226924479));
                Assert.That(model.Value, Is.EqualTo(0.64m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355077570));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(418756824));
                Assert.That(model.Value, Is.EqualTo(0.00m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.29m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(548264416));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581423007));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624060420));
                Assert.That(model.Value, Is.EqualTo(0.01m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1338765106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.57m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(676265474));
                Assert.That(model.Value, Is.EqualTo(0.93m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(741111582));
                Assert.That(model.Value, Is.EqualTo(0.95m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777202605));
                Assert.That(model.Value, Is.EqualTo(0.68m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797829862));
                Assert.That(model.Value, Is.EqualTo(0.98m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.60m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767098856));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.67m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954511594));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(869949868));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.24m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22m));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014891415));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.70m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038415176));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.74m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1048528305));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401674982));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.86m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.87m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.63m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypemoney)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37958078));
                Assert.That(model.Value, Is.EqualTo(0.43m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.62m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084772830));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53227402));
                Assert.That(model.Value, Is.EqualTo(0.02m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(638577460));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.90m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.18m));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57761786));
                Assert.That(model.Value, Is.EqualTo(0.71m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187322361));
                Assert.That(model.Value, Is.EqualTo(0.27m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.17m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204491834));
                Assert.That(model.Value, Is.EqualTo(0.11m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(121334405));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.55m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226924479));
                Assert.That(model.Value, Is.EqualTo(0.64m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355077570));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(418756824));
                Assert.That(model.Value, Is.EqualTo(0.00m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.29m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(548264416));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581423007));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624060420));
                Assert.That(model.Value, Is.EqualTo(0.01m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1338765106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.57m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(676265474));
                Assert.That(model.Value, Is.EqualTo(0.93m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(741111582));
                Assert.That(model.Value, Is.EqualTo(0.95m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777202605));
                Assert.That(model.Value, Is.EqualTo(0.68m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797829862));
                Assert.That(model.Value, Is.EqualTo(0.98m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.60m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767098856));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.67m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954511594));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(869949868));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.24m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22m));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014891415));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.70m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038415176));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.74m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1048528305));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401674982));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.86m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.87m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.63m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypemoney)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypemoney)this).SetDbConnectionSelectModelParametrs(cmd, 581423007);
                var models =  ((IDecimalSingleTypemoney)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(21));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624060420));
                Assert.That(model.Value, Is.EqualTo(0.01m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1338765106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.57m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(676265474));
                Assert.That(model.Value, Is.EqualTo(0.93m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(741111582));
                Assert.That(model.Value, Is.EqualTo(0.95m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777202605));
                Assert.That(model.Value, Is.EqualTo(0.68m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797829862));
                Assert.That(model.Value, Is.EqualTo(0.98m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.60m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767098856));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.67m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954511594));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(869949868));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.24m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22m));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014891415));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.70m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038415176));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.74m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1048528305));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401674982));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.86m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.87m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.63m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDecimalSingleTypemoney)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalSingleTypemoney)this).SetDbConnectionSelectModelParametrs(cmd, 1257636378);
                var models = await ((IDecimalSingleTypemoney)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(8));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)
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
                 foreach(var batchResult in ((IDecimalSingleTypemoney)this).DbConnectionSelectModelBatch(connection, 1311630577, 581423007))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(21));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624060420));
                Assert.That(model.Value, Is.EqualTo(0.01m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1338765106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.57m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(676265474));
                Assert.That(model.Value, Is.EqualTo(0.93m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(741111582));
                Assert.That(model.Value, Is.EqualTo(0.95m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777202605));
                Assert.That(model.Value, Is.EqualTo(0.68m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797829862));
                Assert.That(model.Value, Is.EqualTo(0.98m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.60m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767098856));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.67m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954511594));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(869949868));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.24m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22m));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014891415));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.70m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038415176));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.74m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1048528305));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401674982));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.86m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.87m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.63m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

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
                await foreach(var batchResult in ((IDecimalSingleTypemoney)this).DbConnectionSelectModelBatchAsync(connection, 797829862, 1224742969))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954511594));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(869949868));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.24m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22m));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014891415));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.70m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038415176));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.74m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1048528305));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401674982));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.86m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.87m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.63m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

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
FROM public.decimalmoney0m m
LEFT JOIN public.decimalmoney0mi mi ON mi.id = m.decimalmoney0mi_id
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
            asPartInterface: typeof(IDecimalSingleTypemoney)
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
                var models =  ((IDecimalSingleTypemoney)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37958078)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.43m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1084772830)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.05m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.62m)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53227402)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.02m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((638577460)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.90m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.18m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57761786)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.71m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.80m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187322361)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.27m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.17m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((204491834)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.11m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((121334405)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.55m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((226924479)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.64m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((355077570)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.66m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((418756824)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((548264416)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.37m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.56m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.29m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((581423007)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.15m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.21m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((624060420)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.01m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1338765106)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.57m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((676265474)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.93m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.95m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((741111582)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.95m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((771541715)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.62m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((777202605)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.68m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((797829862)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.98m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1767098856)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.67m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.60m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((954511594)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.49m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((869949868)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.24m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.22m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1014891415)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.15m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2038415176)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.74m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.70m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1048528305)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.67m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((401674982)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.86m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.43m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1076832531)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.66m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((783615338)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.87m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.27m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1224742969)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.39m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1355797907)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.63m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1227274583)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.49m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1311918657)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.80m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1257636378)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.14m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1686700011)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.30m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.88m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1282690059)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.19m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1311630577)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.08m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.41m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1312582003)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.47m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1334457063)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.62m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1652183958)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.89m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1522480127)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.89m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.80m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1813613197)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.69m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((285086449)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.43m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2008072505)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.69m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.21m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2018724342)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.44m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.72m)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypemoney)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37958078)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.43m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1084772830)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.05m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.62m)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53227402)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.02m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((638577460)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.90m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.18m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57761786)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.71m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.80m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187322361)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.27m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.17m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((204491834)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.11m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((121334405)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.55m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((226924479)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.64m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((355077570)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.66m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((418756824)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((548264416)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.37m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.56m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.29m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((581423007)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.15m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.21m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((624060420)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.01m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1338765106)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.57m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((676265474)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.93m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.95m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((741111582)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.95m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((771541715)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.62m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((777202605)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.68m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((797829862)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.98m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1767098856)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.67m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.60m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((954511594)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.49m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((869949868)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.24m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.22m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1014891415)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.15m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2038415176)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.74m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.70m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1048528305)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.67m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((401674982)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.86m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.43m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1076832531)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.66m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((783615338)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.87m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.27m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1224742969)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.39m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1355797907)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.63m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1227274583)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.49m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1311918657)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.80m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1257636378)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.14m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1686700011)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.30m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.88m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1282690059)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.19m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1311630577)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.08m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.41m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1312582003)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.47m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1334457063)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.62m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1652183958)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.89m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1522480127)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.89m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.80m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1813613197)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.69m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((285086449)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.43m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2008072505)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.69m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.21m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2018724342)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.44m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.72m)));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoney0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Decimalmoney0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
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
FROM public.binary_decimalmoney0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Decimalmoney0MI),
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

                var importCollection = new List<Decimalmoney0MI>(7);

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 121334405,
                    Value = 0.55m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 285086449,
                    Value = 0.43m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 401674982,
                    Value = 0.86m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 548264416,
                    Value = 0.37m,
                    NullableValue = 0.56m
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 638577460,
                    Value = 0.90m,
                    NullableValue = 0.18m
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 783615338,
                    Value = 0.87m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 869949868,
                    Value = 0.24m,
                    NullableValue = 0.22m
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(121334405));
                Assert.That(model.Value, Is.EqualTo(0.55m));

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(285086449));
                Assert.That(model.Value, Is.EqualTo(0.43m));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401674982));
                Assert.That(model.Value, Is.EqualTo(0.86m));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548264416));
                Assert.That(model.Value, Is.EqualTo(0.37m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.56m));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(638577460));
                Assert.That(model.Value, Is.EqualTo(0.90m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.18m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(783615338));
                Assert.That(model.Value, Is.EqualTo(0.87m));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869949868));
                Assert.That(model.Value, Is.EqualTo(0.24m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.22m));

                importCollection.Clear();

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 1084772830,
                    Value = 0.05m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 1311918657,
                    Value = 0.80m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 1338765106,
                    Value = 0.57m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 1355797907,
                    Value = 0.63m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 1522480127,
                    Value = 0.89m,
                    NullableValue = 0.80m
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 1686700011,
                    Value = 0.30m,
                    NullableValue = 0.88m
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 1767098856,
                    Value = 0.67m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalmoney0MI
                {
                    Id = 2038415176,
                    Value = 0.74m,
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(121334405));
                Assert.That(model.Value, Is.EqualTo(0.55m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(285086449));
                Assert.That(model.Value, Is.EqualTo(0.43m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401674982));
                Assert.That(model.Value, Is.EqualTo(0.86m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(548264416));
                Assert.That(model.Value, Is.EqualTo(0.37m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.56m));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(638577460));
                Assert.That(model.Value, Is.EqualTo(0.90m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.18m));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(783615338));
                Assert.That(model.Value, Is.EqualTo(0.87m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869949868));
                Assert.That(model.Value, Is.EqualTo(0.24m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.22m));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1084772830));
                Assert.That(model.Value, Is.EqualTo(0.05m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311918657));
                Assert.That(model.Value, Is.EqualTo(0.80m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1338765106));
                Assert.That(model.Value, Is.EqualTo(0.57m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355797907));
                Assert.That(model.Value, Is.EqualTo(0.63m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1522480127));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.80m));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1686700011));
                Assert.That(model.Value, Is.EqualTo(0.30m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.88m));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767098856));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2038415176));
                Assert.That(model.Value, Is.EqualTo(0.74m));

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoney0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalmoney0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Decimalmoney0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12)
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
FROM public.binary_decimalmoney0m m
LEFT JOIN public.binary_decimalmoney0mi mi ON mi.id = m.decimalmoney0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Decimalmoney0M),
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

                var importCollection = new List<Decimalmoney0M>(15);

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 37958078,
                    Value = 0.43m,
                    NullableValue = 0.62m,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 1084772830
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 53227402,
                    Value = 0.02m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 638577460
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 57761786,
                    Value = 0.71m,
                    NullableValue = 0.80m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 187322361,
                    Value = 0.27m,
                    NullableValue = 0.17m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 204491834,
                    Value = 0.11m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 121334405
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 226924479,
                    Value = 0.64m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 355077570,
                    Value = 0.66m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 418756824,
                    Value = 0.00m,
                    NullableValue = 0.29m,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 548264416
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 581423007,
                    Value = 0.15m,
                    NullableValue = 0.21m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 624060420,
                    Value = 0.01m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 1338765106
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 676265474,
                    Value = 0.93m,
                    NullableValue = 0.95m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 741111582,
                    Value = 0.95m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 771541715,
                    Value = 0.62m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 777202605,
                    Value = 0.68m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 797829862,
                    Value = 0.98m,
                    NullableValue = 0.60m,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 1767098856
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37958078));
                Assert.That(model.Value, Is.EqualTo(0.43m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.62m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084772830));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53227402));
                Assert.That(model.Value, Is.EqualTo(0.02m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(638577460));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.90m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.18m));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57761786));
                Assert.That(model.Value, Is.EqualTo(0.71m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187322361));
                Assert.That(model.Value, Is.EqualTo(0.27m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.17m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204491834));
                Assert.That(model.Value, Is.EqualTo(0.11m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(121334405));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.55m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226924479));
                Assert.That(model.Value, Is.EqualTo(0.64m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355077570));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(418756824));
                Assert.That(model.Value, Is.EqualTo(0.00m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.29m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(548264416));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581423007));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624060420));
                Assert.That(model.Value, Is.EqualTo(0.01m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1338765106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.57m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(676265474));
                Assert.That(model.Value, Is.EqualTo(0.93m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(741111582));
                Assert.That(model.Value, Is.EqualTo(0.95m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777202605));
                Assert.That(model.Value, Is.EqualTo(0.68m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797829862));
                Assert.That(model.Value, Is.EqualTo(0.98m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.60m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767098856));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.67m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 954511594,
                    Value = 0.49m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 869949868
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1014891415,
                    Value = 0.15m,
                    NullableValue = 0.70m,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 2038415176
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1048528305,
                    Value = 0.67m,
                    NullableValue = 0.43m,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 401674982
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1076832531,
                    Value = 0.66m,
                    NullableValue = 0.27m,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 783615338
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1224742969,
                    Value = 0.39m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 1355797907
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1227274583,
                    Value = 0.49m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 1311918657
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1257636378,
                    Value = 0.14m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 1686700011
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1282690059,
                    Value = 0.19m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1311630577,
                    Value = 0.08m,
                    NullableValue = 0.41m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1312582003,
                    Value = 0.47m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1334457063,
                    Value = 0.62m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1652183958,
                    Value = 0.89m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 1522480127
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 1813613197,
                    Value = 0.69m,
                    NullableValue = null,

                    ModelInner = new Decimalmoney0MI 
                    {
                        Id = 285086449
                    }

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 2008072505,
                    Value = 0.69m,
                    NullableValue = 0.21m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalmoney0M
                {
                    Id = 2018724342,
                    Value = 0.44m,
                    NullableValue = 0.72m,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37958078));
                Assert.That(model.Value, Is.EqualTo(0.43m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.62m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084772830));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53227402));
                Assert.That(model.Value, Is.EqualTo(0.02m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(638577460));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.90m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.18m));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57761786));
                Assert.That(model.Value, Is.EqualTo(0.71m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187322361));
                Assert.That(model.Value, Is.EqualTo(0.27m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.17m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204491834));
                Assert.That(model.Value, Is.EqualTo(0.11m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(121334405));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.55m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226924479));
                Assert.That(model.Value, Is.EqualTo(0.64m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355077570));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(418756824));
                Assert.That(model.Value, Is.EqualTo(0.00m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.29m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(548264416));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56m));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581423007));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624060420));
                Assert.That(model.Value, Is.EqualTo(0.01m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1338765106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.57m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(676265474));
                Assert.That(model.Value, Is.EqualTo(0.93m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(741111582));
                Assert.That(model.Value, Is.EqualTo(0.95m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(771541715));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777202605));
                Assert.That(model.Value, Is.EqualTo(0.68m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797829862));
                Assert.That(model.Value, Is.EqualTo(0.98m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.60m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767098856));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.67m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954511594));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(869949868));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.24m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22m));


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1014891415));
                Assert.That(model.Value, Is.EqualTo(0.15m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.70m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2038415176));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.74m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1048528305));
                Assert.That(model.Value, Is.EqualTo(0.67m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401674982));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.86m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076832531));
                Assert.That(model.Value, Is.EqualTo(0.66m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.27m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(783615338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.87m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1224742969));
                Assert.That(model.Value, Is.EqualTo(0.39m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1355797907));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.63m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1227274583));
                Assert.That(model.Value, Is.EqualTo(0.49m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1311918657));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1257636378));
                Assert.That(model.Value, Is.EqualTo(0.14m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686700011));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.30m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.88m));


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1282690059));
                Assert.That(model.Value, Is.EqualTo(0.19m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311630577));
                Assert.That(model.Value, Is.EqualTo(0.08m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312582003));
                Assert.That(model.Value, Is.EqualTo(0.47m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1334457063));
                Assert.That(model.Value, Is.EqualTo(0.62m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652183958));
                Assert.That(model.Value, Is.EqualTo(0.89m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522480127));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.89m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.80m));


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813613197));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(285086449));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.43m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2008072505));
                Assert.That(model.Value, Is.EqualTo(0.69m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.21m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2018724342));
                Assert.That(model.Value, Is.EqualTo(0.44m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.72m));

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoney0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalmoney0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Decimalmoney0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12)
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

                var expected = new Dictionary<System.Int32,Decimalmoney0M>(30);

                expected.Add(
                    37958078,
                    new Decimalmoney0M
                    {
                        Id = 37958078,
                        Value = 0.43m,
                        NullableValue = 0.62m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1084772830,
                            Value = 0.05m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    53227402,
                    new Decimalmoney0M
                    {
                        Id = 53227402,
                        Value = 0.02m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 638577460,
                            Value = 0.90m,
                            NullableValue = 0.18m
                        }

                    }
                );

                expected.Add(
                    57761786,
                    new Decimalmoney0M
                    {
                        Id = 57761786,
                        Value = 0.71m,
                        NullableValue = 0.80m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    187322361,
                    new Decimalmoney0M
                    {
                        Id = 187322361,
                        Value = 0.27m,
                        NullableValue = 0.17m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    204491834,
                    new Decimalmoney0M
                    {
                        Id = 204491834,
                        Value = 0.11m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 121334405,
                            Value = 0.55m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    226924479,
                    new Decimalmoney0M
                    {
                        Id = 226924479,
                        Value = 0.64m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    355077570,
                    new Decimalmoney0M
                    {
                        Id = 355077570,
                        Value = 0.66m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    418756824,
                    new Decimalmoney0M
                    {
                        Id = 418756824,
                        Value = 0.00m,
                        NullableValue = 0.29m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 548264416,
                            Value = 0.37m,
                            NullableValue = 0.56m
                        }

                    }
                );

                expected.Add(
                    581423007,
                    new Decimalmoney0M
                    {
                        Id = 581423007,
                        Value = 0.15m,
                        NullableValue = 0.21m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    624060420,
                    new Decimalmoney0M
                    {
                        Id = 624060420,
                        Value = 0.01m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1338765106,
                            Value = 0.57m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    676265474,
                    new Decimalmoney0M
                    {
                        Id = 676265474,
                        Value = 0.93m,
                        NullableValue = 0.95m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    741111582,
                    new Decimalmoney0M
                    {
                        Id = 741111582,
                        Value = 0.95m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    771541715,
                    new Decimalmoney0M
                    {
                        Id = 771541715,
                        Value = 0.62m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    777202605,
                    new Decimalmoney0M
                    {
                        Id = 777202605,
                        Value = 0.68m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    797829862,
                    new Decimalmoney0M
                    {
                        Id = 797829862,
                        Value = 0.98m,
                        NullableValue = 0.60m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1767098856,
                            Value = 0.67m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    954511594,
                    new Decimalmoney0M
                    {
                        Id = 954511594,
                        Value = 0.49m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 869949868,
                            Value = 0.24m,
                            NullableValue = 0.22m
                        }

                    }
                );

                expected.Add(
                    1014891415,
                    new Decimalmoney0M
                    {
                        Id = 1014891415,
                        Value = 0.15m,
                        NullableValue = 0.70m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 2038415176,
                            Value = 0.74m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1048528305,
                    new Decimalmoney0M
                    {
                        Id = 1048528305,
                        Value = 0.67m,
                        NullableValue = 0.43m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 401674982,
                            Value = 0.86m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1076832531,
                    new Decimalmoney0M
                    {
                        Id = 1076832531,
                        Value = 0.66m,
                        NullableValue = 0.27m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 783615338,
                            Value = 0.87m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1224742969,
                    new Decimalmoney0M
                    {
                        Id = 1224742969,
                        Value = 0.39m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1355797907,
                            Value = 0.63m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1227274583,
                    new Decimalmoney0M
                    {
                        Id = 1227274583,
                        Value = 0.49m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1311918657,
                            Value = 0.80m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1257636378,
                    new Decimalmoney0M
                    {
                        Id = 1257636378,
                        Value = 0.14m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1686700011,
                            Value = 0.30m,
                            NullableValue = 0.88m
                        }

                    }
                );

                expected.Add(
                    1282690059,
                    new Decimalmoney0M
                    {
                        Id = 1282690059,
                        Value = 0.19m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1311630577,
                    new Decimalmoney0M
                    {
                        Id = 1311630577,
                        Value = 0.08m,
                        NullableValue = 0.41m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1312582003,
                    new Decimalmoney0M
                    {
                        Id = 1312582003,
                        Value = 0.47m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1334457063,
                    new Decimalmoney0M
                    {
                        Id = 1334457063,
                        Value = 0.62m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1652183958,
                    new Decimalmoney0M
                    {
                        Id = 1652183958,
                        Value = 0.89m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1522480127,
                            Value = 0.89m,
                            NullableValue = 0.80m
                        }

                    }
                );

                expected.Add(
                    1813613197,
                    new Decimalmoney0M
                    {
                        Id = 1813613197,
                        Value = 0.69m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 285086449,
                            Value = 0.43m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2008072505,
                    new Decimalmoney0M
                    {
                        Id = 2008072505,
                        Value = 0.69m,
                        NullableValue = 0.21m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2018724342,
                    new Decimalmoney0M
                    {
                        Id = 2018724342,
                        Value = 0.44m,
                        NullableValue = 0.72m,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
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

                var expected = new Dictionary<System.Int32,Decimalmoney0M>(30);

                expected.Add(
                    37958078,
                    new Decimalmoney0M
                    {
                        Id = 37958078,
                        Value = 0.43m,
                        NullableValue = 0.62m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1084772830,
                            Value = 0.05m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    53227402,
                    new Decimalmoney0M
                    {
                        Id = 53227402,
                        Value = 0.02m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 638577460,
                            Value = 0.90m,
                            NullableValue = 0.18m
                        }

                    }
                );

                expected.Add(
                    57761786,
                    new Decimalmoney0M
                    {
                        Id = 57761786,
                        Value = 0.71m,
                        NullableValue = 0.80m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    187322361,
                    new Decimalmoney0M
                    {
                        Id = 187322361,
                        Value = 0.27m,
                        NullableValue = 0.17m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    204491834,
                    new Decimalmoney0M
                    {
                        Id = 204491834,
                        Value = 0.11m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 121334405,
                            Value = 0.55m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    226924479,
                    new Decimalmoney0M
                    {
                        Id = 226924479,
                        Value = 0.64m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    355077570,
                    new Decimalmoney0M
                    {
                        Id = 355077570,
                        Value = 0.66m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    418756824,
                    new Decimalmoney0M
                    {
                        Id = 418756824,
                        Value = 0.00m,
                        NullableValue = 0.29m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 548264416,
                            Value = 0.37m,
                            NullableValue = 0.56m
                        }

                    }
                );

                expected.Add(
                    581423007,
                    new Decimalmoney0M
                    {
                        Id = 581423007,
                        Value = 0.15m,
                        NullableValue = 0.21m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    624060420,
                    new Decimalmoney0M
                    {
                        Id = 624060420,
                        Value = 0.01m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1338765106,
                            Value = 0.57m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    676265474,
                    new Decimalmoney0M
                    {
                        Id = 676265474,
                        Value = 0.93m,
                        NullableValue = 0.95m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    741111582,
                    new Decimalmoney0M
                    {
                        Id = 741111582,
                        Value = 0.95m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    771541715,
                    new Decimalmoney0M
                    {
                        Id = 771541715,
                        Value = 0.62m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    777202605,
                    new Decimalmoney0M
                    {
                        Id = 777202605,
                        Value = 0.68m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    797829862,
                    new Decimalmoney0M
                    {
                        Id = 797829862,
                        Value = 0.98m,
                        NullableValue = 0.60m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1767098856,
                            Value = 0.67m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    954511594,
                    new Decimalmoney0M
                    {
                        Id = 954511594,
                        Value = 0.49m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 869949868,
                            Value = 0.24m,
                            NullableValue = 0.22m
                        }

                    }
                );

                expected.Add(
                    1014891415,
                    new Decimalmoney0M
                    {
                        Id = 1014891415,
                        Value = 0.15m,
                        NullableValue = 0.70m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 2038415176,
                            Value = 0.74m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1048528305,
                    new Decimalmoney0M
                    {
                        Id = 1048528305,
                        Value = 0.67m,
                        NullableValue = 0.43m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 401674982,
                            Value = 0.86m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1076832531,
                    new Decimalmoney0M
                    {
                        Id = 1076832531,
                        Value = 0.66m,
                        NullableValue = 0.27m,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 783615338,
                            Value = 0.87m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1224742969,
                    new Decimalmoney0M
                    {
                        Id = 1224742969,
                        Value = 0.39m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1355797907,
                            Value = 0.63m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1227274583,
                    new Decimalmoney0M
                    {
                        Id = 1227274583,
                        Value = 0.49m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1311918657,
                            Value = 0.80m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1257636378,
                    new Decimalmoney0M
                    {
                        Id = 1257636378,
                        Value = 0.14m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1686700011,
                            Value = 0.30m,
                            NullableValue = 0.88m
                        }

                    }
                );

                expected.Add(
                    1282690059,
                    new Decimalmoney0M
                    {
                        Id = 1282690059,
                        Value = 0.19m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1311630577,
                    new Decimalmoney0M
                    {
                        Id = 1311630577,
                        Value = 0.08m,
                        NullableValue = 0.41m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1312582003,
                    new Decimalmoney0M
                    {
                        Id = 1312582003,
                        Value = 0.47m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1334457063,
                    new Decimalmoney0M
                    {
                        Id = 1334457063,
                        Value = 0.62m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1652183958,
                    new Decimalmoney0M
                    {
                        Id = 1652183958,
                        Value = 0.89m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 1522480127,
                            Value = 0.89m,
                            NullableValue = 0.80m
                        }

                    }
                );

                expected.Add(
                    1813613197,
                    new Decimalmoney0M
                    {
                        Id = 1813613197,
                        Value = 0.69m,
                        NullableValue = null,

                        ModelInner = new Decimalmoney0MI
                        {
                            Id = 285086449,
                            Value = 0.43m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2008072505,
                    new Decimalmoney0M
                    {
                        Id = 2008072505,
                        Value = 0.69m,
                        NullableValue = 0.21m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2018724342,
                    new Decimalmoney0M
                    {
                        Id = 2018724342,
                        Value = 0.44m,
                        NullableValue = 0.72m,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoney0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Decimalmoney0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
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

                var expected = new Dictionary<System.Int32,Decimalmoney0MI>(15);

                expected.Add(
                    121334405,
                    new Decimalmoney0MI
                    {
                        Id = 121334405,
                        Value = 0.55m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    285086449,
                    new Decimalmoney0MI
                    {
                        Id = 285086449,
                        Value = 0.43m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    401674982,
                    new Decimalmoney0MI
                    {
                        Id = 401674982,
                        Value = 0.86m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    548264416,
                    new Decimalmoney0MI
                    {
                        Id = 548264416,
                        Value = 0.37m,
                        NullableValue = 0.56m
                    }
                );

                expected.Add(
                    638577460,
                    new Decimalmoney0MI
                    {
                        Id = 638577460,
                        Value = 0.90m,
                        NullableValue = 0.18m
                    }
                );

                expected.Add(
                    783615338,
                    new Decimalmoney0MI
                    {
                        Id = 783615338,
                        Value = 0.87m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    869949868,
                    new Decimalmoney0MI
                    {
                        Id = 869949868,
                        Value = 0.24m,
                        NullableValue = 0.22m
                    }
                );

                expected.Add(
                    1084772830,
                    new Decimalmoney0MI
                    {
                        Id = 1084772830,
                        Value = 0.05m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1311918657,
                    new Decimalmoney0MI
                    {
                        Id = 1311918657,
                        Value = 0.80m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1338765106,
                    new Decimalmoney0MI
                    {
                        Id = 1338765106,
                        Value = 0.57m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1355797907,
                    new Decimalmoney0MI
                    {
                        Id = 1355797907,
                        Value = 0.63m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1522480127,
                    new Decimalmoney0MI
                    {
                        Id = 1522480127,
                        Value = 0.89m,
                        NullableValue = 0.80m
                    }
                );

                expected.Add(
                    1686700011,
                    new Decimalmoney0MI
                    {
                        Id = 1686700011,
                        Value = 0.30m,
                        NullableValue = 0.88m
                    }
                );

                expected.Add(
                    1767098856,
                    new Decimalmoney0MI
                    {
                        Id = 1767098856,
                        Value = 0.67m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2038415176,
                    new Decimalmoney0MI
                    {
                        Id = 2038415176,
                        Value = 0.74m,
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

                var expected = new Dictionary<System.Int32,Decimalmoney0MI>(15);

                expected.Add(
                    121334405,
                    new Decimalmoney0MI
                    {
                        Id = 121334405,
                        Value = 0.55m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    285086449,
                    new Decimalmoney0MI
                    {
                        Id = 285086449,
                        Value = 0.43m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    401674982,
                    new Decimalmoney0MI
                    {
                        Id = 401674982,
                        Value = 0.86m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    548264416,
                    new Decimalmoney0MI
                    {
                        Id = 548264416,
                        Value = 0.37m,
                        NullableValue = 0.56m
                    }
                );

                expected.Add(
                    638577460,
                    new Decimalmoney0MI
                    {
                        Id = 638577460,
                        Value = 0.90m,
                        NullableValue = 0.18m
                    }
                );

                expected.Add(
                    783615338,
                    new Decimalmoney0MI
                    {
                        Id = 783615338,
                        Value = 0.87m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    869949868,
                    new Decimalmoney0MI
                    {
                        Id = 869949868,
                        Value = 0.24m,
                        NullableValue = 0.22m
                    }
                );

                expected.Add(
                    1084772830,
                    new Decimalmoney0MI
                    {
                        Id = 1084772830,
                        Value = 0.05m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1311918657,
                    new Decimalmoney0MI
                    {
                        Id = 1311918657,
                        Value = 0.80m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1338765106,
                    new Decimalmoney0MI
                    {
                        Id = 1338765106,
                        Value = 0.57m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1355797907,
                    new Decimalmoney0MI
                    {
                        Id = 1355797907,
                        Value = 0.63m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1522480127,
                    new Decimalmoney0MI
                    {
                        Id = 1522480127,
                        Value = 0.89m,
                        NullableValue = 0.80m
                    }
                );

                expected.Add(
                    1686700011,
                    new Decimalmoney0MI
                    {
                        Id = 1686700011,
                        Value = 0.30m,
                        NullableValue = 0.88m
                    }
                );

                expected.Add(
                    1767098856,
                    new Decimalmoney0MI
                    {
                        Id = 1767098856,
                        Value = 0.67m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2038415176,
                    new Decimalmoney0MI
                    {
                        Id = 2038415176,
                        Value = 0.74m,
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


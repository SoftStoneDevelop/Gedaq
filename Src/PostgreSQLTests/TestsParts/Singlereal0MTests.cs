

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
    internal partial interface ISingleSingleTypereal
    {
    }
    
    internal partial class SingleSingleTypereal : ISingleSingleTypereal
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
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
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
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
            queryMapType: typeof(Singlereal0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)
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

                changedRows =  ((ISingleSingleTypereal)this).InsertModelInner(connection, 444130267, 0.22179699f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).InsertModelInner(connection, 941183784, 0.7394327f, 0.85619265f);
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

                changedRows = await ((ISingleSingleTypereal)this).InsertModelInnerAsync(connection, 880424600, 0.82158685f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).InsertModelInnerAsync(connection, 855031977, 0.42661774f, 0.22363573f);
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

                id =  ((ISingleSingleTypereal)this).InsertModelInnerReturning(connection, 1363408512, 0.28387344f, null);
                Assert.That(id, Is.EqualTo(1363408512));

                id =  ((ISingleSingleTypereal)this).InsertModelInnerReturning(connection, 258343686, 0.52568686f, null);
                Assert.That(id, Is.EqualTo(258343686));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ISingleSingleTypereal)this).InsertModelInnerReturningAsync(connection, 1573279409, 0.16799343f, null);
                Assert.That(id, Is.EqualTo(1573279409));

                id = await ((ISingleSingleTypereal)this).InsertModelInnerReturningAsync(connection, 900116817, 0.6969675f, null);
                Assert.That(id, Is.EqualTo(900116817));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
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
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(15)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(15), 
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertInnerModel(connection, 744915701, 0.45324236f, null);
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

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 1154318714, 0.33804446f, 0.7739341f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 225285565, 0.83642846f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 693841495, 0.440592f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 1520241351, 0.11006516f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 2032270901, 0.85620975f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 187172792, 0.93308544f, 0.2559983f);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
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
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlereal0mi_id", 
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

                changedRows =  ((ISingleSingleTypereal)this).InsertModel(connection, 1940933616, 0.37824112f, 0.25345862f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).InsertModel(connection, 1751299843, 0.06408596f, null, 444130267);
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

                changedRows = await ((ISingleSingleTypereal)this).InsertModelAsync(connection, 1850512439, 0.49589676f, 0.0022997856f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).InsertModelAsync(connection, 33579241, 0.23475415f, null, 941183784);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single? nullable = null;

                nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelReturning(connection, 252397386, 0.8892234f, 0.3841812f, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.3841812f));

                nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelReturning(connection, 1337482433, 0.9394202f, null, 880424600);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single? nullable = null;

                nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelReturningAsync(connection, 1617648718, 0.99975663f, 0.8687623f, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.8687623f));

                nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelReturningAsync(connection, 1948662719, 0.22378248f, 0.8790199f, 855031977);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.8790199f));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
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
    singlereal0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Singlereal0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlereal0mi_id", 
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
                List<Singlereal0M> models = null;
                Singlereal0M model = null;

                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, 1445750321, 0.18814582f, 0.20484817f, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, 1649503096, 0.6189302f, 0.12557167f, 1363408512).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Single)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, 1379320472, 0.15972108f, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1379320472));
                Assert.That(model.Value, Is.EqualTo(0.15972108f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, 554356758, 0.01084286f, 0.91019773f, 258343686).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(554356758));
                Assert.That(model.Value, Is.EqualTo(0.01084286f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.91019773f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258343686));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Single)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Singlereal0M> models = null;
                Singlereal0M model = null;

                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, 491610027, 0.3262034f, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491610027));
                Assert.That(model.Value, Is.EqualTo(0.3262034f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, 220928350, 0.8067524f, 0.16410595f, 1573279409).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220928350));
                Assert.That(model.Value, Is.EqualTo(0.8067524f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16410595f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573279409));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Single)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, 776449888, 0.18636149f, 0.36836064f, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(776449888));
                Assert.That(model.Value, Is.EqualTo(0.18636149f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36836064f));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, 1876854329, 0.17542613f, 0.4929176f, 900116817).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Single)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlereal0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Single), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(15)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(15),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlereal0mi_id", 
                methodParametrName: "singlereal0mi_id", 
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, 1198767283, 0.0841105f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, 67214089, 0.08883351f, 0.5411467f, 744915701);
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

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1767722064, 0.6821648f, 0.37242252f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1767736253, 0.2964877f, 0.09382343f, 1154318714);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 2003040297, 0.4495312f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1975226329, 0.7611394f, null, 225285565);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1065681174, 0.79030675f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 313947794, 0.24475878f, null, 693841495);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1315620466, 0.064368725f, 0.48372734f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 489269944, 0.45959014f, 0.721491f, 1520241351);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1836505913, 0.59813863f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1074641173, 0.87730414f, 0.9015118f, 2032270901);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 677047688, 0.36513495f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 715771611, 0.74869865f, null, 187172792);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Singlereal0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
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
                var models =  ((ISingleSingleTypereal)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33579241));
                Assert.That(model.Value, Is.EqualTo(0.23475415f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(941183784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7394327f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.85619265f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67214089));
                Assert.That(model.Value, Is.EqualTo(0.08883351f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5411467f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(744915701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45324236f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220928350));
                Assert.That(model.Value, Is.EqualTo(0.8067524f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16410595f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573279409));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16799343f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252397386));
                Assert.That(model.Value, Is.EqualTo(0.8892234f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3841812f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313947794));
                Assert.That(model.Value, Is.EqualTo(0.24475878f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693841495));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.440592f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489269944));
                Assert.That(model.Value, Is.EqualTo(0.45959014f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.721491f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1520241351));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11006516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491610027));
                Assert.That(model.Value, Is.EqualTo(0.3262034f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(554356758));
                Assert.That(model.Value, Is.EqualTo(0.01084286f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.91019773f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258343686));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.52568686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677047688));
                Assert.That(model.Value, Is.EqualTo(0.36513495f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(715771611));
                Assert.That(model.Value, Is.EqualTo(0.74869865f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(187172792));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.93308544f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2559983f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(776449888));
                Assert.That(model.Value, Is.EqualTo(0.18636149f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36836064f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065681174));
                Assert.That(model.Value, Is.EqualTo(0.79030675f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074641173));
                Assert.That(model.Value, Is.EqualTo(0.87730414f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9015118f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032270901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.85620975f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198767283));
                Assert.That(model.Value, Is.EqualTo(0.0841105f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315620466));
                Assert.That(model.Value, Is.EqualTo(0.064368725f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.48372734f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337482433));
                Assert.That(model.Value, Is.EqualTo(0.9394202f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(880424600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82158685f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1379320472));
                Assert.That(model.Value, Is.EqualTo(0.15972108f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617648718));
                Assert.That(model.Value, Is.EqualTo(0.99975663f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8687623f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751299843));
                Assert.That(model.Value, Is.EqualTo(0.06408596f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(444130267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767722064));
                Assert.That(model.Value, Is.EqualTo(0.6821648f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.37242252f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767736253));
                Assert.That(model.Value, Is.EqualTo(0.2964877f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.09382343f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1154318714));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7739341f));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836505913));
                Assert.That(model.Value, Is.EqualTo(0.59813863f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

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
                var models = await ((ISingleSingleTypereal)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33579241));
                Assert.That(model.Value, Is.EqualTo(0.23475415f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(941183784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7394327f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.85619265f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67214089));
                Assert.That(model.Value, Is.EqualTo(0.08883351f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5411467f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(744915701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45324236f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220928350));
                Assert.That(model.Value, Is.EqualTo(0.8067524f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16410595f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573279409));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16799343f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252397386));
                Assert.That(model.Value, Is.EqualTo(0.8892234f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3841812f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313947794));
                Assert.That(model.Value, Is.EqualTo(0.24475878f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693841495));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.440592f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489269944));
                Assert.That(model.Value, Is.EqualTo(0.45959014f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.721491f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1520241351));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11006516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491610027));
                Assert.That(model.Value, Is.EqualTo(0.3262034f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(554356758));
                Assert.That(model.Value, Is.EqualTo(0.01084286f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.91019773f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258343686));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.52568686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677047688));
                Assert.That(model.Value, Is.EqualTo(0.36513495f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(715771611));
                Assert.That(model.Value, Is.EqualTo(0.74869865f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(187172792));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.93308544f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2559983f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(776449888));
                Assert.That(model.Value, Is.EqualTo(0.18636149f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36836064f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065681174));
                Assert.That(model.Value, Is.EqualTo(0.79030675f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074641173));
                Assert.That(model.Value, Is.EqualTo(0.87730414f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9015118f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032270901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.85620975f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198767283));
                Assert.That(model.Value, Is.EqualTo(0.0841105f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315620466));
                Assert.That(model.Value, Is.EqualTo(0.064368725f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.48372734f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337482433));
                Assert.That(model.Value, Is.EqualTo(0.9394202f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(880424600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82158685f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1379320472));
                Assert.That(model.Value, Is.EqualTo(0.15972108f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617648718));
                Assert.That(model.Value, Is.EqualTo(0.99975663f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8687623f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751299843));
                Assert.That(model.Value, Is.EqualTo(0.06408596f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(444130267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767722064));
                Assert.That(model.Value, Is.EqualTo(0.6821648f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.37242252f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767736253));
                Assert.That(model.Value, Is.EqualTo(0.2964877f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.09382343f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1154318714));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7739341f));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836505913));
                Assert.That(model.Value, Is.EqualTo(0.59813863f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Singlereal0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
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
                var models =  ((ISingleSingleTypereal)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33579241));
                Assert.That(model.Value, Is.EqualTo(0.23475415f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(941183784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7394327f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.85619265f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67214089));
                Assert.That(model.Value, Is.EqualTo(0.08883351f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5411467f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(744915701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45324236f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220928350));
                Assert.That(model.Value, Is.EqualTo(0.8067524f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16410595f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573279409));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16799343f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252397386));
                Assert.That(model.Value, Is.EqualTo(0.8892234f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3841812f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313947794));
                Assert.That(model.Value, Is.EqualTo(0.24475878f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693841495));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.440592f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489269944));
                Assert.That(model.Value, Is.EqualTo(0.45959014f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.721491f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1520241351));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11006516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491610027));
                Assert.That(model.Value, Is.EqualTo(0.3262034f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(554356758));
                Assert.That(model.Value, Is.EqualTo(0.01084286f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.91019773f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258343686));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.52568686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677047688));
                Assert.That(model.Value, Is.EqualTo(0.36513495f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(715771611));
                Assert.That(model.Value, Is.EqualTo(0.74869865f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(187172792));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.93308544f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2559983f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(776449888));
                Assert.That(model.Value, Is.EqualTo(0.18636149f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36836064f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065681174));
                Assert.That(model.Value, Is.EqualTo(0.79030675f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074641173));
                Assert.That(model.Value, Is.EqualTo(0.87730414f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9015118f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032270901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.85620975f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198767283));
                Assert.That(model.Value, Is.EqualTo(0.0841105f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315620466));
                Assert.That(model.Value, Is.EqualTo(0.064368725f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.48372734f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337482433));
                Assert.That(model.Value, Is.EqualTo(0.9394202f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(880424600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82158685f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1379320472));
                Assert.That(model.Value, Is.EqualTo(0.15972108f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617648718));
                Assert.That(model.Value, Is.EqualTo(0.99975663f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8687623f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751299843));
                Assert.That(model.Value, Is.EqualTo(0.06408596f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(444130267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767722064));
                Assert.That(model.Value, Is.EqualTo(0.6821648f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.37242252f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767736253));
                Assert.That(model.Value, Is.EqualTo(0.2964877f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.09382343f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1154318714));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7739341f));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836505913));
                Assert.That(model.Value, Is.EqualTo(0.59813863f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

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
                var models = await ((ISingleSingleTypereal)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33579241));
                Assert.That(model.Value, Is.EqualTo(0.23475415f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(941183784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7394327f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.85619265f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67214089));
                Assert.That(model.Value, Is.EqualTo(0.08883351f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5411467f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(744915701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45324236f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220928350));
                Assert.That(model.Value, Is.EqualTo(0.8067524f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16410595f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573279409));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16799343f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252397386));
                Assert.That(model.Value, Is.EqualTo(0.8892234f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3841812f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313947794));
                Assert.That(model.Value, Is.EqualTo(0.24475878f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693841495));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.440592f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489269944));
                Assert.That(model.Value, Is.EqualTo(0.45959014f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.721491f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1520241351));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11006516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491610027));
                Assert.That(model.Value, Is.EqualTo(0.3262034f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(554356758));
                Assert.That(model.Value, Is.EqualTo(0.01084286f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.91019773f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258343686));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.52568686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677047688));
                Assert.That(model.Value, Is.EqualTo(0.36513495f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(715771611));
                Assert.That(model.Value, Is.EqualTo(0.74869865f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(187172792));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.93308544f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2559983f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(776449888));
                Assert.That(model.Value, Is.EqualTo(0.18636149f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36836064f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065681174));
                Assert.That(model.Value, Is.EqualTo(0.79030675f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074641173));
                Assert.That(model.Value, Is.EqualTo(0.87730414f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9015118f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032270901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.85620975f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198767283));
                Assert.That(model.Value, Is.EqualTo(0.0841105f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315620466));
                Assert.That(model.Value, Is.EqualTo(0.064368725f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.48372734f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337482433));
                Assert.That(model.Value, Is.EqualTo(0.9394202f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(880424600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82158685f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1379320472));
                Assert.That(model.Value, Is.EqualTo(0.15972108f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617648718));
                Assert.That(model.Value, Is.EqualTo(0.99975663f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8687623f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751299843));
                Assert.That(model.Value, Is.EqualTo(0.06408596f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(444130267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767722064));
                Assert.That(model.Value, Is.EqualTo(0.6821648f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.37242252f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767736253));
                Assert.That(model.Value, Is.EqualTo(0.2964877f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.09382343f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1154318714));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7739341f));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836505913));
                Assert.That(model.Value, Is.EqualTo(0.59813863f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

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
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 1836505913);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(6));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

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
                await using var cmd = await ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 1379320472);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617648718));
                Assert.That(model.Value, Is.EqualTo(0.99975663f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8687623f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751299843));
                Assert.That(model.Value, Is.EqualTo(0.06408596f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(444130267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767722064));
                Assert.That(model.Value, Is.EqualTo(0.6821648f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.37242252f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767736253));
                Assert.That(model.Value, Is.EqualTo(0.2964877f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.09382343f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1154318714));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7739341f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836505913));
                Assert.That(model.Value, Is.EqualTo(0.59813863f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
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
                 foreach(var batchResult in ((ISingleSingleTypereal)this).DbConnectionSelectModelBatch(connection, 1198767283, 1876854329))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315620466));
                Assert.That(model.Value, Is.EqualTo(0.064368725f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.48372734f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337482433));
                Assert.That(model.Value, Is.EqualTo(0.9394202f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(880424600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82158685f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1379320472));
                Assert.That(model.Value, Is.EqualTo(0.15972108f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617648718));
                Assert.That(model.Value, Is.EqualTo(0.99975663f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8687623f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751299843));
                Assert.That(model.Value, Is.EqualTo(0.06408596f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(444130267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767722064));
                Assert.That(model.Value, Is.EqualTo(0.6821648f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.37242252f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767736253));
                Assert.That(model.Value, Is.EqualTo(0.2964877f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.09382343f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1154318714));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7739341f));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836505913));
                Assert.That(model.Value, Is.EqualTo(0.59813863f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

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
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

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
                await foreach(var batchResult in ((ISingleSingleTypereal)this).DbConnectionSelectModelBatchAsync(connection, 1850512439, 776449888))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065681174));
                Assert.That(model.Value, Is.EqualTo(0.79030675f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074641173));
                Assert.That(model.Value, Is.EqualTo(0.87730414f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9015118f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032270901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.85620975f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198767283));
                Assert.That(model.Value, Is.EqualTo(0.0841105f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315620466));
                Assert.That(model.Value, Is.EqualTo(0.064368725f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.48372734f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337482433));
                Assert.That(model.Value, Is.EqualTo(0.9394202f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(880424600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82158685f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1379320472));
                Assert.That(model.Value, Is.EqualTo(0.15972108f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617648718));
                Assert.That(model.Value, Is.EqualTo(0.99975663f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8687623f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751299843));
                Assert.That(model.Value, Is.EqualTo(0.06408596f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(444130267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767722064));
                Assert.That(model.Value, Is.EqualTo(0.6821648f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.37242252f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767736253));
                Assert.That(model.Value, Is.EqualTo(0.2964877f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.09382343f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1154318714));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7739341f));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836505913));
                Assert.That(model.Value, Is.EqualTo(0.59813863f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
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
            asPartInterface: typeof(ISingleSingleTypereal)
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
                var models =  ((ISingleSingleTypereal)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33579241)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23475415f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((941183784)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7394327f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.85619265f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67214089)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08883351f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((744915701)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.45324236f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5411467f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((220928350)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8067524f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1573279409)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.16799343f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.16410595f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((252397386)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8892234f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3841812f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((313947794)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.24475878f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((693841495)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.440592f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((489269944)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.45959014f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1520241351)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.11006516f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.721491f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((491610027)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3262034f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((554356758)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.01084286f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((258343686)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.52568686f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.91019773f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((677047688)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.36513495f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((715771611)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74869865f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((187172792)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.93308544f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.2559983f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((776449888)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18636149f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.36836064f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1065681174)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.79030675f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1074641173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.87730414f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2032270901)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.85620975f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9015118f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1198767283)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.0841105f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1315620466)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.064368725f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48372734f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1337482433)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9394202f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((880424600)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.82158685f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1379320472)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15972108f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1445750321)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18814582f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.20484817f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1617648718)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.99975663f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8687623f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1649503096)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6189302f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1363408512)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.28387344f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12557167f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1751299843)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06408596f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((444130267)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.22179699f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1767722064)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6821648f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.37242252f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1767736253)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2964877f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1154318714)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.33804446f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7739341f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.09382343f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1836505913)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59813863f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1850512439)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.49589676f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.0022997856f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1876854329)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.17542613f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((900116817)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6969675f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4929176f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1940933616)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.37824112f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.25345862f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1948662719)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22378248f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((855031977)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42661774f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.22363573f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8790199f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1975226329)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7611394f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((225285565)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.83642846f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2003040297)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4495312f)));//Value

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
                var models = await ((ISingleSingleTypereal)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33579241)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23475415f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((941183784)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7394327f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.85619265f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67214089)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08883351f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((744915701)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.45324236f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5411467f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((220928350)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8067524f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1573279409)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.16799343f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.16410595f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((252397386)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8892234f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3841812f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((313947794)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.24475878f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((693841495)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.440592f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((489269944)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.45959014f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1520241351)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.11006516f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.721491f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((491610027)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3262034f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((554356758)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.01084286f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((258343686)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.52568686f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.91019773f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((677047688)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.36513495f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((715771611)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74869865f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((187172792)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.93308544f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.2559983f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((776449888)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18636149f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.36836064f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1065681174)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.79030675f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1074641173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.87730414f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2032270901)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.85620975f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9015118f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1198767283)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.0841105f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1315620466)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.064368725f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48372734f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1337482433)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9394202f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((880424600)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.82158685f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1379320472)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15972108f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1445750321)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18814582f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.20484817f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1617648718)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.99975663f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8687623f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1649503096)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6189302f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1363408512)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.28387344f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12557167f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1751299843)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06408596f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((444130267)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.22179699f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1767722064)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6821648f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.37242252f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1767736253)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2964877f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1154318714)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.33804446f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7739341f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.09382343f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1836505913)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59813863f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1850512439)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.49589676f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.0022997856f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1876854329)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.17542613f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((900116817)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6969675f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4929176f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1940933616)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.37824112f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.25345862f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1948662719)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22378248f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((855031977)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42661774f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.22363573f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8790199f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1975226329)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7611394f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((225285565)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.83642846f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2003040297)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4495312f)));//Value

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
COPY public.binary_singlereal0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Singlereal0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
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
FROM public.binary_singlereal0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Singlereal0MI),
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

                var importCollection = new List<Singlereal0MI>(7);

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 187172792,
                    Value = 0.93308544f,
                    NullableValue = 0.2559983f
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 225285565,
                    Value = 0.83642846f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 258343686,
                    Value = 0.52568686f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 444130267,
                    Value = 0.22179699f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 693841495,
                    Value = 0.440592f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 744915701,
                    Value = 0.45324236f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 855031977,
                    Value = 0.42661774f,
                    NullableValue = 0.22363573f
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187172792));
                Assert.That(model.Value, Is.EqualTo(0.93308544f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2559983f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(225285565));
                Assert.That(model.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258343686));
                Assert.That(model.Value, Is.EqualTo(0.52568686f));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(444130267));
                Assert.That(model.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693841495));
                Assert.That(model.Value, Is.EqualTo(0.440592f));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744915701));
                Assert.That(model.Value, Is.EqualTo(0.45324236f));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(855031977));
                Assert.That(model.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.22363573f));

                importCollection.Clear();

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 880424600,
                    Value = 0.82158685f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 900116817,
                    Value = 0.6969675f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 941183784,
                    Value = 0.7394327f,
                    NullableValue = 0.85619265f
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 1154318714,
                    Value = 0.33804446f,
                    NullableValue = 0.7739341f
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 1363408512,
                    Value = 0.28387344f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 1520241351,
                    Value = 0.11006516f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 1573279409,
                    Value = 0.16799343f,
                    NullableValue = null
                });

                importCollection.Add(
                new Singlereal0MI
                {
                    Id = 2032270901,
                    Value = 0.85620975f,
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187172792));
                Assert.That(model.Value, Is.EqualTo(0.93308544f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2559983f));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(225285565));
                Assert.That(model.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258343686));
                Assert.That(model.Value, Is.EqualTo(0.52568686f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(444130267));
                Assert.That(model.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(693841495));
                Assert.That(model.Value, Is.EqualTo(0.440592f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(744915701));
                Assert.That(model.Value, Is.EqualTo(0.45324236f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(855031977));
                Assert.That(model.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.22363573f));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(880424600));
                Assert.That(model.Value, Is.EqualTo(0.82158685f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(900116817));
                Assert.That(model.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(941183784));
                Assert.That(model.Value, Is.EqualTo(0.7394327f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.85619265f));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154318714));
                Assert.That(model.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7739341f));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1363408512));
                Assert.That(model.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520241351));
                Assert.That(model.Value, Is.EqualTo(0.11006516f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573279409));
                Assert.That(model.Value, Is.EqualTo(0.16799343f));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2032270901));
                Assert.That(model.Value, Is.EqualTo(0.85620975f));

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereal0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlereal0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Singlereal0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17)
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
FROM public.binary_singlereal0m m
LEFT JOIN public.binary_singlereal0mi mi ON mi.id = m.singlereal0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Singlereal0M),
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

                var importCollection = new List<Singlereal0M>(15);

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 33579241,
                    Value = 0.23475415f,
                    NullableValue = null,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 941183784
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 67214089,
                    Value = 0.08883351f,
                    NullableValue = 0.5411467f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 744915701
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 220928350,
                    Value = 0.8067524f,
                    NullableValue = 0.16410595f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 1573279409
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 252397386,
                    Value = 0.8892234f,
                    NullableValue = 0.3841812f,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 313947794,
                    Value = 0.24475878f,
                    NullableValue = null,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 693841495
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 489269944,
                    Value = 0.45959014f,
                    NullableValue = 0.721491f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 1520241351
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 491610027,
                    Value = 0.3262034f,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 554356758,
                    Value = 0.01084286f,
                    NullableValue = 0.91019773f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 258343686
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 677047688,
                    Value = 0.36513495f,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 715771611,
                    Value = 0.74869865f,
                    NullableValue = null,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 187172792
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 776449888,
                    Value = 0.18636149f,
                    NullableValue = 0.36836064f,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1065681174,
                    Value = 0.79030675f,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1074641173,
                    Value = 0.87730414f,
                    NullableValue = 0.9015118f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 2032270901
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1198767283,
                    Value = 0.0841105f,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1315620466,
                    Value = 0.064368725f,
                    NullableValue = 0.48372734f,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33579241));
                Assert.That(model.Value, Is.EqualTo(0.23475415f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(941183784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7394327f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.85619265f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67214089));
                Assert.That(model.Value, Is.EqualTo(0.08883351f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5411467f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(744915701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45324236f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220928350));
                Assert.That(model.Value, Is.EqualTo(0.8067524f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16410595f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573279409));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16799343f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252397386));
                Assert.That(model.Value, Is.EqualTo(0.8892234f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3841812f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313947794));
                Assert.That(model.Value, Is.EqualTo(0.24475878f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693841495));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.440592f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489269944));
                Assert.That(model.Value, Is.EqualTo(0.45959014f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.721491f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1520241351));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11006516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491610027));
                Assert.That(model.Value, Is.EqualTo(0.3262034f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(554356758));
                Assert.That(model.Value, Is.EqualTo(0.01084286f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.91019773f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258343686));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.52568686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677047688));
                Assert.That(model.Value, Is.EqualTo(0.36513495f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(715771611));
                Assert.That(model.Value, Is.EqualTo(0.74869865f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(187172792));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.93308544f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2559983f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(776449888));
                Assert.That(model.Value, Is.EqualTo(0.18636149f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36836064f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065681174));
                Assert.That(model.Value, Is.EqualTo(0.79030675f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074641173));
                Assert.That(model.Value, Is.EqualTo(0.87730414f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9015118f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032270901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.85620975f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198767283));
                Assert.That(model.Value, Is.EqualTo(0.0841105f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315620466));
                Assert.That(model.Value, Is.EqualTo(0.064368725f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.48372734f));

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1337482433,
                    Value = 0.9394202f,
                    NullableValue = null,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 880424600
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1379320472,
                    Value = 0.15972108f,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1445750321,
                    Value = 0.18814582f,
                    NullableValue = 0.20484817f,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1617648718,
                    Value = 0.99975663f,
                    NullableValue = 0.8687623f,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1649503096,
                    Value = 0.6189302f,
                    NullableValue = 0.12557167f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 1363408512
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1751299843,
                    Value = 0.06408596f,
                    NullableValue = null,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 444130267
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1767722064,
                    Value = 0.6821648f,
                    NullableValue = 0.37242252f,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1767736253,
                    Value = 0.2964877f,
                    NullableValue = 0.09382343f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 1154318714
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1836505913,
                    Value = 0.59813863f,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1850512439,
                    Value = 0.49589676f,
                    NullableValue = 0.0022997856f,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1876854329,
                    Value = 0.17542613f,
                    NullableValue = 0.4929176f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 900116817
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1940933616,
                    Value = 0.37824112f,
                    NullableValue = 0.25345862f,

                    ModelInner = null

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1948662719,
                    Value = 0.22378248f,
                    NullableValue = 0.8790199f,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 855031977
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 1975226329,
                    Value = 0.7611394f,
                    NullableValue = null,

                    ModelInner = new Singlereal0MI 
                    {
                        Id = 225285565
                    }

                });

                importCollection.Add(
                new Singlereal0M
                {
                    Id = 2003040297,
                    Value = 0.4495312f,
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33579241));
                Assert.That(model.Value, Is.EqualTo(0.23475415f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(941183784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7394327f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.85619265f));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67214089));
                Assert.That(model.Value, Is.EqualTo(0.08883351f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5411467f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(744915701));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45324236f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220928350));
                Assert.That(model.Value, Is.EqualTo(0.8067524f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.16410595f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573279409));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16799343f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252397386));
                Assert.That(model.Value, Is.EqualTo(0.8892234f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3841812f));

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313947794));
                Assert.That(model.Value, Is.EqualTo(0.24475878f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693841495));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.440592f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489269944));
                Assert.That(model.Value, Is.EqualTo(0.45959014f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.721491f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1520241351));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11006516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491610027));
                Assert.That(model.Value, Is.EqualTo(0.3262034f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(554356758));
                Assert.That(model.Value, Is.EqualTo(0.01084286f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.91019773f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258343686));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.52568686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677047688));
                Assert.That(model.Value, Is.EqualTo(0.36513495f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(715771611));
                Assert.That(model.Value, Is.EqualTo(0.74869865f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(187172792));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.93308544f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2559983f));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(776449888));
                Assert.That(model.Value, Is.EqualTo(0.18636149f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36836064f));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065681174));
                Assert.That(model.Value, Is.EqualTo(0.79030675f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074641173));
                Assert.That(model.Value, Is.EqualTo(0.87730414f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9015118f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032270901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.85620975f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198767283));
                Assert.That(model.Value, Is.EqualTo(0.0841105f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1315620466));
                Assert.That(model.Value, Is.EqualTo(0.064368725f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.48372734f));

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337482433));
                Assert.That(model.Value, Is.EqualTo(0.9394202f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(880424600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82158685f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1379320472));
                Assert.That(model.Value, Is.EqualTo(0.15972108f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1445750321));
                Assert.That(model.Value, Is.EqualTo(0.18814582f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.20484817f));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1617648718));
                Assert.That(model.Value, Is.EqualTo(0.99975663f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8687623f));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649503096));
                Assert.That(model.Value, Is.EqualTo(0.6189302f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.12557167f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363408512));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.28387344f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751299843));
                Assert.That(model.Value, Is.EqualTo(0.06408596f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(444130267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22179699f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767722064));
                Assert.That(model.Value, Is.EqualTo(0.6821648f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.37242252f));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1767736253));
                Assert.That(model.Value, Is.EqualTo(0.2964877f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.09382343f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1154318714));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.33804446f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7739341f));


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1836505913));
                Assert.That(model.Value, Is.EqualTo(0.59813863f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1850512439));
                Assert.That(model.Value, Is.EqualTo(0.49589676f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0022997856f));

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876854329));
                Assert.That(model.Value, Is.EqualTo(0.17542613f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4929176f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(900116817));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6969675f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940933616));
                Assert.That(model.Value, Is.EqualTo(0.37824112f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25345862f));

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948662719));
                Assert.That(model.Value, Is.EqualTo(0.22378248f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8790199f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855031977));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42661774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22363573f));


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1975226329));
                Assert.That(model.Value, Is.EqualTo(0.7611394f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(225285565));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83642846f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003040297));
                Assert.That(model.Value, Is.EqualTo(0.4495312f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereal0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlereal0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Singlereal0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17)
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

                var expected = new Dictionary<System.Int32,Singlereal0M>(30);

                expected.Add(
                    33579241,
                    new Singlereal0M
                    {
                        Id = 33579241,
                        Value = 0.23475415f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 941183784,
                            Value = 0.7394327f,
                            NullableValue = 0.85619265f
                        }

                    }
                );

                expected.Add(
                    67214089,
                    new Singlereal0M
                    {
                        Id = 67214089,
                        Value = 0.08883351f,
                        NullableValue = 0.5411467f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 744915701,
                            Value = 0.45324236f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    220928350,
                    new Singlereal0M
                    {
                        Id = 220928350,
                        Value = 0.8067524f,
                        NullableValue = 0.16410595f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 1573279409,
                            Value = 0.16799343f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    252397386,
                    new Singlereal0M
                    {
                        Id = 252397386,
                        Value = 0.8892234f,
                        NullableValue = 0.3841812f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    313947794,
                    new Singlereal0M
                    {
                        Id = 313947794,
                        Value = 0.24475878f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 693841495,
                            Value = 0.440592f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    489269944,
                    new Singlereal0M
                    {
                        Id = 489269944,
                        Value = 0.45959014f,
                        NullableValue = 0.721491f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 1520241351,
                            Value = 0.11006516f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    491610027,
                    new Singlereal0M
                    {
                        Id = 491610027,
                        Value = 0.3262034f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    554356758,
                    new Singlereal0M
                    {
                        Id = 554356758,
                        Value = 0.01084286f,
                        NullableValue = 0.91019773f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 258343686,
                            Value = 0.52568686f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    677047688,
                    new Singlereal0M
                    {
                        Id = 677047688,
                        Value = 0.36513495f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    715771611,
                    new Singlereal0M
                    {
                        Id = 715771611,
                        Value = 0.74869865f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 187172792,
                            Value = 0.93308544f,
                            NullableValue = 0.2559983f
                        }

                    }
                );

                expected.Add(
                    776449888,
                    new Singlereal0M
                    {
                        Id = 776449888,
                        Value = 0.18636149f,
                        NullableValue = 0.36836064f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1065681174,
                    new Singlereal0M
                    {
                        Id = 1065681174,
                        Value = 0.79030675f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1074641173,
                    new Singlereal0M
                    {
                        Id = 1074641173,
                        Value = 0.87730414f,
                        NullableValue = 0.9015118f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 2032270901,
                            Value = 0.85620975f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1198767283,
                    new Singlereal0M
                    {
                        Id = 1198767283,
                        Value = 0.0841105f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1315620466,
                    new Singlereal0M
                    {
                        Id = 1315620466,
                        Value = 0.064368725f,
                        NullableValue = 0.48372734f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1337482433,
                    new Singlereal0M
                    {
                        Id = 1337482433,
                        Value = 0.9394202f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 880424600,
                            Value = 0.82158685f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1379320472,
                    new Singlereal0M
                    {
                        Id = 1379320472,
                        Value = 0.15972108f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1445750321,
                    new Singlereal0M
                    {
                        Id = 1445750321,
                        Value = 0.18814582f,
                        NullableValue = 0.20484817f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1617648718,
                    new Singlereal0M
                    {
                        Id = 1617648718,
                        Value = 0.99975663f,
                        NullableValue = 0.8687623f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1649503096,
                    new Singlereal0M
                    {
                        Id = 1649503096,
                        Value = 0.6189302f,
                        NullableValue = 0.12557167f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 1363408512,
                            Value = 0.28387344f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1751299843,
                    new Singlereal0M
                    {
                        Id = 1751299843,
                        Value = 0.06408596f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 444130267,
                            Value = 0.22179699f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1767722064,
                    new Singlereal0M
                    {
                        Id = 1767722064,
                        Value = 0.6821648f,
                        NullableValue = 0.37242252f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1767736253,
                    new Singlereal0M
                    {
                        Id = 1767736253,
                        Value = 0.2964877f,
                        NullableValue = 0.09382343f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 1154318714,
                            Value = 0.33804446f,
                            NullableValue = 0.7739341f
                        }

                    }
                );

                expected.Add(
                    1836505913,
                    new Singlereal0M
                    {
                        Id = 1836505913,
                        Value = 0.59813863f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1850512439,
                    new Singlereal0M
                    {
                        Id = 1850512439,
                        Value = 0.49589676f,
                        NullableValue = 0.0022997856f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1876854329,
                    new Singlereal0M
                    {
                        Id = 1876854329,
                        Value = 0.17542613f,
                        NullableValue = 0.4929176f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 900116817,
                            Value = 0.6969675f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1940933616,
                    new Singlereal0M
                    {
                        Id = 1940933616,
                        Value = 0.37824112f,
                        NullableValue = 0.25345862f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1948662719,
                    new Singlereal0M
                    {
                        Id = 1948662719,
                        Value = 0.22378248f,
                        NullableValue = 0.8790199f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 855031977,
                            Value = 0.42661774f,
                            NullableValue = 0.22363573f
                        }

                    }
                );

                expected.Add(
                    1975226329,
                    new Singlereal0M
                    {
                        Id = 1975226329,
                        Value = 0.7611394f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 225285565,
                            Value = 0.83642846f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2003040297,
                    new Singlereal0M
                    {
                        Id = 2003040297,
                        Value = 0.4495312f,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Single)default));
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

                var expected = new Dictionary<System.Int32,Singlereal0M>(30);

                expected.Add(
                    33579241,
                    new Singlereal0M
                    {
                        Id = 33579241,
                        Value = 0.23475415f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 941183784,
                            Value = 0.7394327f,
                            NullableValue = 0.85619265f
                        }

                    }
                );

                expected.Add(
                    67214089,
                    new Singlereal0M
                    {
                        Id = 67214089,
                        Value = 0.08883351f,
                        NullableValue = 0.5411467f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 744915701,
                            Value = 0.45324236f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    220928350,
                    new Singlereal0M
                    {
                        Id = 220928350,
                        Value = 0.8067524f,
                        NullableValue = 0.16410595f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 1573279409,
                            Value = 0.16799343f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    252397386,
                    new Singlereal0M
                    {
                        Id = 252397386,
                        Value = 0.8892234f,
                        NullableValue = 0.3841812f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    313947794,
                    new Singlereal0M
                    {
                        Id = 313947794,
                        Value = 0.24475878f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 693841495,
                            Value = 0.440592f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    489269944,
                    new Singlereal0M
                    {
                        Id = 489269944,
                        Value = 0.45959014f,
                        NullableValue = 0.721491f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 1520241351,
                            Value = 0.11006516f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    491610027,
                    new Singlereal0M
                    {
                        Id = 491610027,
                        Value = 0.3262034f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    554356758,
                    new Singlereal0M
                    {
                        Id = 554356758,
                        Value = 0.01084286f,
                        NullableValue = 0.91019773f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 258343686,
                            Value = 0.52568686f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    677047688,
                    new Singlereal0M
                    {
                        Id = 677047688,
                        Value = 0.36513495f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    715771611,
                    new Singlereal0M
                    {
                        Id = 715771611,
                        Value = 0.74869865f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 187172792,
                            Value = 0.93308544f,
                            NullableValue = 0.2559983f
                        }

                    }
                );

                expected.Add(
                    776449888,
                    new Singlereal0M
                    {
                        Id = 776449888,
                        Value = 0.18636149f,
                        NullableValue = 0.36836064f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1065681174,
                    new Singlereal0M
                    {
                        Id = 1065681174,
                        Value = 0.79030675f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1074641173,
                    new Singlereal0M
                    {
                        Id = 1074641173,
                        Value = 0.87730414f,
                        NullableValue = 0.9015118f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 2032270901,
                            Value = 0.85620975f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1198767283,
                    new Singlereal0M
                    {
                        Id = 1198767283,
                        Value = 0.0841105f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1315620466,
                    new Singlereal0M
                    {
                        Id = 1315620466,
                        Value = 0.064368725f,
                        NullableValue = 0.48372734f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1337482433,
                    new Singlereal0M
                    {
                        Id = 1337482433,
                        Value = 0.9394202f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 880424600,
                            Value = 0.82158685f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1379320472,
                    new Singlereal0M
                    {
                        Id = 1379320472,
                        Value = 0.15972108f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1445750321,
                    new Singlereal0M
                    {
                        Id = 1445750321,
                        Value = 0.18814582f,
                        NullableValue = 0.20484817f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1617648718,
                    new Singlereal0M
                    {
                        Id = 1617648718,
                        Value = 0.99975663f,
                        NullableValue = 0.8687623f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1649503096,
                    new Singlereal0M
                    {
                        Id = 1649503096,
                        Value = 0.6189302f,
                        NullableValue = 0.12557167f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 1363408512,
                            Value = 0.28387344f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1751299843,
                    new Singlereal0M
                    {
                        Id = 1751299843,
                        Value = 0.06408596f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 444130267,
                            Value = 0.22179699f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1767722064,
                    new Singlereal0M
                    {
                        Id = 1767722064,
                        Value = 0.6821648f,
                        NullableValue = 0.37242252f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1767736253,
                    new Singlereal0M
                    {
                        Id = 1767736253,
                        Value = 0.2964877f,
                        NullableValue = 0.09382343f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 1154318714,
                            Value = 0.33804446f,
                            NullableValue = 0.7739341f
                        }

                    }
                );

                expected.Add(
                    1836505913,
                    new Singlereal0M
                    {
                        Id = 1836505913,
                        Value = 0.59813863f,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1850512439,
                    new Singlereal0M
                    {
                        Id = 1850512439,
                        Value = 0.49589676f,
                        NullableValue = 0.0022997856f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1876854329,
                    new Singlereal0M
                    {
                        Id = 1876854329,
                        Value = 0.17542613f,
                        NullableValue = 0.4929176f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 900116817,
                            Value = 0.6969675f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1940933616,
                    new Singlereal0M
                    {
                        Id = 1940933616,
                        Value = 0.37824112f,
                        NullableValue = 0.25345862f,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1948662719,
                    new Singlereal0M
                    {
                        Id = 1948662719,
                        Value = 0.22378248f,
                        NullableValue = 0.8790199f,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 855031977,
                            Value = 0.42661774f,
                            NullableValue = 0.22363573f
                        }

                    }
                );

                expected.Add(
                    1975226329,
                    new Singlereal0M
                    {
                        Id = 1975226329,
                        Value = 0.7611394f,
                        NullableValue = null,

                        ModelInner = new Singlereal0MI
                        {
                            Id = 225285565,
                            Value = 0.83642846f,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2003040297,
                    new Singlereal0M
                    {
                        Id = 2003040297,
                        Value = 0.4495312f,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Single)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereal0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Singlereal0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
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

                var expected = new Dictionary<System.Int32,Singlereal0MI>(15);

                expected.Add(
                    187172792,
                    new Singlereal0MI
                    {
                        Id = 187172792,
                        Value = 0.93308544f,
                        NullableValue = 0.2559983f
                    }
                );

                expected.Add(
                    225285565,
                    new Singlereal0MI
                    {
                        Id = 225285565,
                        Value = 0.83642846f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    258343686,
                    new Singlereal0MI
                    {
                        Id = 258343686,
                        Value = 0.52568686f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    444130267,
                    new Singlereal0MI
                    {
                        Id = 444130267,
                        Value = 0.22179699f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    693841495,
                    new Singlereal0MI
                    {
                        Id = 693841495,
                        Value = 0.440592f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    744915701,
                    new Singlereal0MI
                    {
                        Id = 744915701,
                        Value = 0.45324236f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    855031977,
                    new Singlereal0MI
                    {
                        Id = 855031977,
                        Value = 0.42661774f,
                        NullableValue = 0.22363573f
                    }
                );

                expected.Add(
                    880424600,
                    new Singlereal0MI
                    {
                        Id = 880424600,
                        Value = 0.82158685f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    900116817,
                    new Singlereal0MI
                    {
                        Id = 900116817,
                        Value = 0.6969675f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    941183784,
                    new Singlereal0MI
                    {
                        Id = 941183784,
                        Value = 0.7394327f,
                        NullableValue = 0.85619265f
                    }
                );

                expected.Add(
                    1154318714,
                    new Singlereal0MI
                    {
                        Id = 1154318714,
                        Value = 0.33804446f,
                        NullableValue = 0.7739341f
                    }
                );

                expected.Add(
                    1363408512,
                    new Singlereal0MI
                    {
                        Id = 1363408512,
                        Value = 0.28387344f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1520241351,
                    new Singlereal0MI
                    {
                        Id = 1520241351,
                        Value = 0.11006516f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1573279409,
                    new Singlereal0MI
                    {
                        Id = 1573279409,
                        Value = 0.16799343f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2032270901,
                    new Singlereal0MI
                    {
                        Id = 2032270901,
                        Value = 0.85620975f,
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

                var expected = new Dictionary<System.Int32,Singlereal0MI>(15);

                expected.Add(
                    187172792,
                    new Singlereal0MI
                    {
                        Id = 187172792,
                        Value = 0.93308544f,
                        NullableValue = 0.2559983f
                    }
                );

                expected.Add(
                    225285565,
                    new Singlereal0MI
                    {
                        Id = 225285565,
                        Value = 0.83642846f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    258343686,
                    new Singlereal0MI
                    {
                        Id = 258343686,
                        Value = 0.52568686f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    444130267,
                    new Singlereal0MI
                    {
                        Id = 444130267,
                        Value = 0.22179699f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    693841495,
                    new Singlereal0MI
                    {
                        Id = 693841495,
                        Value = 0.440592f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    744915701,
                    new Singlereal0MI
                    {
                        Id = 744915701,
                        Value = 0.45324236f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    855031977,
                    new Singlereal0MI
                    {
                        Id = 855031977,
                        Value = 0.42661774f,
                        NullableValue = 0.22363573f
                    }
                );

                expected.Add(
                    880424600,
                    new Singlereal0MI
                    {
                        Id = 880424600,
                        Value = 0.82158685f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    900116817,
                    new Singlereal0MI
                    {
                        Id = 900116817,
                        Value = 0.6969675f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    941183784,
                    new Singlereal0MI
                    {
                        Id = 941183784,
                        Value = 0.7394327f,
                        NullableValue = 0.85619265f
                    }
                );

                expected.Add(
                    1154318714,
                    new Singlereal0MI
                    {
                        Id = 1154318714,
                        Value = 0.33804446f,
                        NullableValue = 0.7739341f
                    }
                );

                expected.Add(
                    1363408512,
                    new Singlereal0MI
                    {
                        Id = 1363408512,
                        Value = 0.28387344f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1520241351,
                    new Singlereal0MI
                    {
                        Id = 1520241351,
                        Value = 0.11006516f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1573279409,
                    new Singlereal0MI
                    {
                        Id = 1573279409,
                        Value = 0.16799343f,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2032270901,
                    new Singlereal0MI
                    {
                        Id = 2032270901,
                        Value = 0.85620975f,
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


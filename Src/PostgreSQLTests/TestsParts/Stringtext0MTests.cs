

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
    internal partial interface IStringSingleTypetext
    {
    }
    
    internal partial class StringSingleTypetext : IStringSingleTypetext
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0mi(
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
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0mi(
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
            queryMapType: typeof(Stringtext0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)
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

                changedRows =  ((IStringSingleTypetext)this).InsertModelInner(connection, 1160515916, "clyjaq", "nryfcprmrcglwoiewtnmgfrpbqtdg");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).InsertModelInner(connection, 1188857112, "elqbmugvsj", null);
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

                changedRows = await ((IStringSingleTypetext)this).InsertModelInnerAsync(connection, 1219469829, "txkikg", "pbcsiyyqfdfcexjyldnsvahf");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).InsertModelInnerAsync(connection, 502310185, "brbjmjp", null);
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

                id =  ((IStringSingleTypetext)this).InsertModelInnerReturning(connection, 1429601770, "seqrlkjaqwbiln", "qoitovxvfhgfq");
                Assert.That(id, Is.EqualTo(1429601770));

                id =  ((IStringSingleTypetext)this).InsertModelInnerReturning(connection, 483849738, "yewgudpphmqmq", null);
                Assert.That(id, Is.EqualTo(483849738));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IStringSingleTypetext)this).InsertModelInnerReturningAsync(connection, 893884247, "ckgdofghrcubjgf", null);
                Assert.That(id, Is.EqualTo(893884247));

                id = await ((IStringSingleTypetext)this).InsertModelInnerReturningAsync(connection, 1495227642, "ksmlsriyhtdjyxvhedjclykw", "fncnoontkagrnkfodsuannccod");
                Assert.That(id, Is.EqualTo(1495227642));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0mi(
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
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(16)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(16), 
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertInnerModel(connection, 1527379371, "aycdhiv", "hfjsfnywbkdr");
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 495493992, "kucnfjojvgxgrnporfisrfomsd", "itkyekvsaukqjkljmnt");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1218603036, "iirikeehflbjgke", "p");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 358179516, "ueefibdqnenfencgxekxdtyjihf", "xhamubxg");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1504668538, "wcmnetvxbhpkqxtmkwtf", "uoy");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1373265565, "imcop", "ltvutlxslsjuxasf");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 591543207, "jsulhkqaxdvvetourqhlt", null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0m(
	id,
    value,
    nullablevalue,
    stringtext0mi_id
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
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtext0mi_id", 
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

                changedRows =  ((IStringSingleTypetext)this).InsertModel(connection, 2020520348, "clbvwmhfdhfhjsxe", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).InsertModel(connection, 1031880821, "hpubtcsle", "jlnbsovdhawcjugvhbo", 1160515916);
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

                changedRows = await ((IStringSingleTypetext)this).InsertModelAsync(connection, 297848082, "dgkafodshsarrnuxq", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).InsertModelAsync(connection, 1842603815, "kntwsqntnxassbopdnbtxomjel", null, 1188857112);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String nullable = null;

                nullable =  ((IStringSingleTypetext)this).ScalarInsertModelReturning(connection, 1581781443, "oigfvwxvrhbptkblfwfpgceln", "qnee", null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo("qnee"));

                nullable =  ((IStringSingleTypetext)this).ScalarInsertModelReturning(connection, 1134703117, "xudqveydn", null, 1219469829);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String nullable = null;

                nullable = await ((IStringSingleTypetext)this).ScalarInsertModelReturningAsync(connection, 729248297, "hhimksvmxcik", null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((IStringSingleTypetext)this).ScalarInsertModelReturningAsync(connection, 1972391361, "hyubpxxdp", "la", 502310185);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo("la"));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0m(
	id,
    value,
    nullablevalue,
    stringtext0mi_id
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
    stringtext0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Stringtext0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtext0mi_id", 
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
                List<Stringtext0M> models = null;
                Stringtext0M model = null;

                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, 2102589040, "wuinnvtsg", "wvmmnfwcecncuvlxdlvqipdh", null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, 894502594, "ojngxqshlxifgwqwrdqhlmorw", "qkniraflqxtvgweqqe", 1429601770).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, 620211437, "hyqjrfioxfrlvgwnxtfumvkjwfdli", null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620211437));
                Assert.That(model.Value, Is.EqualTo("hyqjrfioxfrlvgwnxtfumvkjwfdli"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, 924524750, "qrqteicrrshedvtmyqxpotmcy", null, 483849738).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Stringtext0M> models = null;
                Stringtext0M model = null;

                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, 631313641, "xgawqfboilxxphrpjtc", null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(631313641));
                Assert.That(model.Value, Is.EqualTo("xgawqfboilxxphrpjtc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, 1187359701, "wlnjkhyabomgmpxpukchyd", null, 893884247).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, 337120212, "mvafvdtupjiymcdssumkos", "ajqbhsnowedshlyxqst", null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(337120212));
                Assert.That(model.Value, Is.EqualTo("mvafvdtupjiymcdssumkos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ajqbhsnowedshlyxqst"));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, 690457296, "jmolggxfhy", "ivqflirnxbkkaoldlwkyyydqfga", 1495227642).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690457296));
                Assert.That(model.Value, Is.EqualTo("jmolggxfhy"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ivqflirnxbkkaoldlwkyyydqfga"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1495227642));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0m(
	id,
    value,
    nullablevalue,
    stringtext0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @stringtext0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.String), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(16),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, 1926580000, "cybfaljnplivcnqkhjvcelsbuaj", "psov", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, 132386070, "xsmqflaeymtmssateegjm", null, 1527379371);
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 266447007, "jmgbfuscvvwelbkkqruidcjbb", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 220454105, "ngehffo", null, 495493992);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1931136219, "bchth", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1652465762, "cupmvpdvbkcpyybmk", null, 1218603036);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1017541666, "joit", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 33857238, "", null, 358179516);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 853944735, "lswgeelpdatdpfjdgnlflikxaalrv", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1664762696, "rlcjxgailtkrdyl", null, 1504668538);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 581208365, "qgi", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 265270038, "lwotnndimftwd", null, 1373265565);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 995050294, "qlv", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 457983608, "rmskvd", null, 591543207);
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
FROM public.stringtext0m m
LEFT JOIN public.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Stringtext0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
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
                var models =  ((IStringSingleTypetext)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33857238));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(358179516));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ueefibdqnenfencgxekxdtyjihf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("xhamubxg"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(132386070));
                Assert.That(model.Value, Is.EqualTo("xsmqflaeymtmssateegjm"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527379371));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aycdhiv"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hfjsfnywbkdr"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220454105));
                Assert.That(model.Value, Is.EqualTo("ngehffo"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495493992));

                Assert.That(model.ModelInner.Value, Is.EqualTo("kucnfjojvgxgrnporfisrfomsd"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("itkyekvsaukqjkljmnt"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(265270038));
                Assert.That(model.Value, Is.EqualTo("lwotnndimftwd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1373265565));

                Assert.That(model.ModelInner.Value, Is.EqualTo("imcop"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ltvutlxslsjuxasf"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266447007));
                Assert.That(model.Value, Is.EqualTo("jmgbfuscvvwelbkkqruidcjbb"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297848082));
                Assert.That(model.Value, Is.EqualTo("dgkafodshsarrnuxq"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(337120212));
                Assert.That(model.Value, Is.EqualTo("mvafvdtupjiymcdssumkos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ajqbhsnowedshlyxqst"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457983608));
                Assert.That(model.Value, Is.EqualTo("rmskvd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591543207));

                Assert.That(model.ModelInner.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581208365));
                Assert.That(model.Value, Is.EqualTo("qgi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620211437));
                Assert.That(model.Value, Is.EqualTo("hyqjrfioxfrlvgwnxtfumvkjwfdli"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(631313641));
                Assert.That(model.Value, Is.EqualTo("xgawqfboilxxphrpjtc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690457296));
                Assert.That(model.Value, Is.EqualTo("jmolggxfhy"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ivqflirnxbkkaoldlwkyyydqfga"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1495227642));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ksmlsriyhtdjyxvhedjclykw"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("fncnoontkagrnkfodsuannccod"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729248297));
                Assert.That(model.Value, Is.EqualTo("hhimksvmxcik"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(853944735));
                Assert.That(model.Value, Is.EqualTo("lswgeelpdatdpfjdgnlflikxaalrv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995050294));
                Assert.That(model.Value, Is.EqualTo("qlv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017541666));
                Assert.That(model.Value, Is.EqualTo("joit"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031880821));
                Assert.That(model.Value, Is.EqualTo("hpubtcsle"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jlnbsovdhawcjugvhbo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160515916));

                Assert.That(model.ModelInner.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33857238));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(358179516));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ueefibdqnenfencgxekxdtyjihf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("xhamubxg"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(132386070));
                Assert.That(model.Value, Is.EqualTo("xsmqflaeymtmssateegjm"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527379371));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aycdhiv"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hfjsfnywbkdr"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220454105));
                Assert.That(model.Value, Is.EqualTo("ngehffo"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495493992));

                Assert.That(model.ModelInner.Value, Is.EqualTo("kucnfjojvgxgrnporfisrfomsd"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("itkyekvsaukqjkljmnt"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(265270038));
                Assert.That(model.Value, Is.EqualTo("lwotnndimftwd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1373265565));

                Assert.That(model.ModelInner.Value, Is.EqualTo("imcop"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ltvutlxslsjuxasf"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266447007));
                Assert.That(model.Value, Is.EqualTo("jmgbfuscvvwelbkkqruidcjbb"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297848082));
                Assert.That(model.Value, Is.EqualTo("dgkafodshsarrnuxq"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(337120212));
                Assert.That(model.Value, Is.EqualTo("mvafvdtupjiymcdssumkos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ajqbhsnowedshlyxqst"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457983608));
                Assert.That(model.Value, Is.EqualTo("rmskvd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591543207));

                Assert.That(model.ModelInner.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581208365));
                Assert.That(model.Value, Is.EqualTo("qgi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620211437));
                Assert.That(model.Value, Is.EqualTo("hyqjrfioxfrlvgwnxtfumvkjwfdli"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(631313641));
                Assert.That(model.Value, Is.EqualTo("xgawqfboilxxphrpjtc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690457296));
                Assert.That(model.Value, Is.EqualTo("jmolggxfhy"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ivqflirnxbkkaoldlwkyyydqfga"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1495227642));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ksmlsriyhtdjyxvhedjclykw"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("fncnoontkagrnkfodsuannccod"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729248297));
                Assert.That(model.Value, Is.EqualTo("hhimksvmxcik"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(853944735));
                Assert.That(model.Value, Is.EqualTo("lswgeelpdatdpfjdgnlflikxaalrv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995050294));
                Assert.That(model.Value, Is.EqualTo("qlv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017541666));
                Assert.That(model.Value, Is.EqualTo("joit"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031880821));
                Assert.That(model.Value, Is.EqualTo("hpubtcsle"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jlnbsovdhawcjugvhbo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160515916));

                Assert.That(model.ModelInner.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

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
FROM public.stringtext0m m
LEFT JOIN public.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Stringtext0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
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
                var models =  ((IStringSingleTypetext)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33857238));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(358179516));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ueefibdqnenfencgxekxdtyjihf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("xhamubxg"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(132386070));
                Assert.That(model.Value, Is.EqualTo("xsmqflaeymtmssateegjm"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527379371));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aycdhiv"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hfjsfnywbkdr"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220454105));
                Assert.That(model.Value, Is.EqualTo("ngehffo"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495493992));

                Assert.That(model.ModelInner.Value, Is.EqualTo("kucnfjojvgxgrnporfisrfomsd"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("itkyekvsaukqjkljmnt"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(265270038));
                Assert.That(model.Value, Is.EqualTo("lwotnndimftwd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1373265565));

                Assert.That(model.ModelInner.Value, Is.EqualTo("imcop"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ltvutlxslsjuxasf"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266447007));
                Assert.That(model.Value, Is.EqualTo("jmgbfuscvvwelbkkqruidcjbb"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297848082));
                Assert.That(model.Value, Is.EqualTo("dgkafodshsarrnuxq"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(337120212));
                Assert.That(model.Value, Is.EqualTo("mvafvdtupjiymcdssumkos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ajqbhsnowedshlyxqst"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457983608));
                Assert.That(model.Value, Is.EqualTo("rmskvd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591543207));

                Assert.That(model.ModelInner.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581208365));
                Assert.That(model.Value, Is.EqualTo("qgi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620211437));
                Assert.That(model.Value, Is.EqualTo("hyqjrfioxfrlvgwnxtfumvkjwfdli"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(631313641));
                Assert.That(model.Value, Is.EqualTo("xgawqfboilxxphrpjtc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690457296));
                Assert.That(model.Value, Is.EqualTo("jmolggxfhy"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ivqflirnxbkkaoldlwkyyydqfga"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1495227642));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ksmlsriyhtdjyxvhedjclykw"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("fncnoontkagrnkfodsuannccod"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729248297));
                Assert.That(model.Value, Is.EqualTo("hhimksvmxcik"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(853944735));
                Assert.That(model.Value, Is.EqualTo("lswgeelpdatdpfjdgnlflikxaalrv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995050294));
                Assert.That(model.Value, Is.EqualTo("qlv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017541666));
                Assert.That(model.Value, Is.EqualTo("joit"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031880821));
                Assert.That(model.Value, Is.EqualTo("hpubtcsle"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jlnbsovdhawcjugvhbo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160515916));

                Assert.That(model.ModelInner.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33857238));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(358179516));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ueefibdqnenfencgxekxdtyjihf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("xhamubxg"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(132386070));
                Assert.That(model.Value, Is.EqualTo("xsmqflaeymtmssateegjm"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527379371));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aycdhiv"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hfjsfnywbkdr"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220454105));
                Assert.That(model.Value, Is.EqualTo("ngehffo"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495493992));

                Assert.That(model.ModelInner.Value, Is.EqualTo("kucnfjojvgxgrnporfisrfomsd"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("itkyekvsaukqjkljmnt"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(265270038));
                Assert.That(model.Value, Is.EqualTo("lwotnndimftwd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1373265565));

                Assert.That(model.ModelInner.Value, Is.EqualTo("imcop"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ltvutlxslsjuxasf"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266447007));
                Assert.That(model.Value, Is.EqualTo("jmgbfuscvvwelbkkqruidcjbb"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297848082));
                Assert.That(model.Value, Is.EqualTo("dgkafodshsarrnuxq"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(337120212));
                Assert.That(model.Value, Is.EqualTo("mvafvdtupjiymcdssumkos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ajqbhsnowedshlyxqst"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457983608));
                Assert.That(model.Value, Is.EqualTo("rmskvd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591543207));

                Assert.That(model.ModelInner.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581208365));
                Assert.That(model.Value, Is.EqualTo("qgi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620211437));
                Assert.That(model.Value, Is.EqualTo("hyqjrfioxfrlvgwnxtfumvkjwfdli"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(631313641));
                Assert.That(model.Value, Is.EqualTo("xgawqfboilxxphrpjtc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690457296));
                Assert.That(model.Value, Is.EqualTo("jmolggxfhy"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ivqflirnxbkkaoldlwkyyydqfga"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1495227642));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ksmlsriyhtdjyxvhedjclykw"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("fncnoontkagrnkfodsuannccod"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729248297));
                Assert.That(model.Value, Is.EqualTo("hhimksvmxcik"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(853944735));
                Assert.That(model.Value, Is.EqualTo("lswgeelpdatdpfjdgnlflikxaalrv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995050294));
                Assert.That(model.Value, Is.EqualTo("qlv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017541666));
                Assert.That(model.Value, Is.EqualTo("joit"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031880821));
                Assert.That(model.Value, Is.EqualTo("hpubtcsle"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jlnbsovdhawcjugvhbo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160515916));

                Assert.That(model.ModelInner.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 266447007);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297848082));
                Assert.That(model.Value, Is.EqualTo("dgkafodshsarrnuxq"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(337120212));
                Assert.That(model.Value, Is.EqualTo("mvafvdtupjiymcdssumkos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ajqbhsnowedshlyxqst"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457983608));
                Assert.That(model.Value, Is.EqualTo("rmskvd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591543207));

                Assert.That(model.ModelInner.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581208365));
                Assert.That(model.Value, Is.EqualTo("qgi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620211437));
                Assert.That(model.Value, Is.EqualTo("hyqjrfioxfrlvgwnxtfumvkjwfdli"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(631313641));
                Assert.That(model.Value, Is.EqualTo("xgawqfboilxxphrpjtc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690457296));
                Assert.That(model.Value, Is.EqualTo("jmolggxfhy"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ivqflirnxbkkaoldlwkyyydqfga"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1495227642));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ksmlsriyhtdjyxvhedjclykw"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("fncnoontkagrnkfodsuannccod"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729248297));
                Assert.That(model.Value, Is.EqualTo("hhimksvmxcik"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(853944735));
                Assert.That(model.Value, Is.EqualTo("lswgeelpdatdpfjdgnlflikxaalrv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995050294));
                Assert.That(model.Value, Is.EqualTo("qlv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017541666));
                Assert.That(model.Value, Is.EqualTo("joit"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031880821));
                Assert.That(model.Value, Is.EqualTo("hpubtcsle"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jlnbsovdhawcjugvhbo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160515916));

                Assert.That(model.ModelInner.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 690457296);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(18));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729248297));
                Assert.That(model.Value, Is.EqualTo("hhimksvmxcik"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(853944735));
                Assert.That(model.Value, Is.EqualTo("lswgeelpdatdpfjdgnlflikxaalrv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995050294));
                Assert.That(model.Value, Is.EqualTo("qlv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017541666));
                Assert.That(model.Value, Is.EqualTo("joit"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031880821));
                Assert.That(model.Value, Is.EqualTo("hpubtcsle"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jlnbsovdhawcjugvhbo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160515916));

                Assert.That(model.ModelInner.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
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
                 foreach(var batchResult in ((IStringSingleTypetext)this).DbConnectionSelectModelBatch(connection, 1187359701, 1031880821))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(9));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

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
                await foreach(var batchResult in ((IStringSingleTypetext)this).DbConnectionSelectModelBatchAsync(connection, 1031880821, 853944735))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995050294));
                Assert.That(model.Value, Is.EqualTo("qlv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017541666));
                Assert.That(model.Value, Is.EqualTo("joit"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031880821));
                Assert.That(model.Value, Is.EqualTo("hpubtcsle"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jlnbsovdhawcjugvhbo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160515916));

                Assert.That(model.ModelInner.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

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
FROM public.stringtext0m m
LEFT JOIN public.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
            asPartInterface: typeof(IStringSingleTypetext)
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
                var models =  ((IStringSingleTypetext)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33857238)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((358179516)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ueefibdqnenfencgxekxdtyjihf")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("xhamubxg")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132386070)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xsmqflaeymtmssateegjm")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1527379371)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("aycdhiv")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hfjsfnywbkdr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((220454105)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ngehffo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((495493992)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("kucnfjojvgxgrnporfisrfomsd")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("itkyekvsaukqjkljmnt")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((265270038)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lwotnndimftwd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1373265565)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("imcop")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ltvutlxslsjuxasf")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((266447007)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jmgbfuscvvwelbkkqruidcjbb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((297848082)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dgkafodshsarrnuxq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((337120212)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mvafvdtupjiymcdssumkos")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ajqbhsnowedshlyxqst")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((457983608)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rmskvd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((591543207)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jsulhkqaxdvvetourqhlt")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((581208365)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qgi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((620211437)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hyqjrfioxfrlvgwnxtfumvkjwfdli")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((631313641)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xgawqfboilxxphrpjtc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((690457296)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jmolggxfhy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1495227642)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ksmlsriyhtdjyxvhedjclykw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fncnoontkagrnkfodsuannccod")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ivqflirnxbkkaoldlwkyyydqfga")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((729248297)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hhimksvmxcik")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((853944735)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lswgeelpdatdpfjdgnlflikxaalrv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((894502594)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ojngxqshlxifgwqwrdqhlmorw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1429601770)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("seqrlkjaqwbiln")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("qoitovxvfhgfq")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qkniraflqxtvgweqqe")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((924524750)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qrqteicrrshedvtmyqxpotmcy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((483849738)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yewgudpphmqmq")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((995050294)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qlv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1017541666)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("joit")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1031880821)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hpubtcsle")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1160515916)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("clyjaq")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nryfcprmrcglwoiewtnmgfrpbqtdg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jlnbsovdhawcjugvhbo")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1134703117)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xudqveydn")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1219469829)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("txkikg")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("pbcsiyyqfdfcexjyldnsvahf")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1187359701)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlnjkhyabomgmpxpukchyd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((893884247)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ckgdofghrcubjgf")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1581781443)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oigfvwxvrhbptkblfwfpgceln")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qnee")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1652465762)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cupmvpdvbkcpyybmk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1218603036)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("iirikeehflbjgke")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("p")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1664762696)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rlcjxgailtkrdyl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1504668538)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wcmnetvxbhpkqxtmkwtf")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uoy")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1842603815)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kntwsqntnxassbopdnbtxomjel")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1188857112)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("elqbmugvsj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1926580000)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cybfaljnplivcnqkhjvcelsbuaj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("psov")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1931136219)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bchth")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1972391361)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hyubpxxdp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((502310185)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("brbjmjp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("la")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2020520348)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("clbvwmhfdhfhjsxe")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2102589040)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wuinnvtsg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wvmmnfwcecncuvlxdlvqipdh")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33857238)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((358179516)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ueefibdqnenfencgxekxdtyjihf")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("xhamubxg")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132386070)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xsmqflaeymtmssateegjm")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1527379371)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("aycdhiv")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hfjsfnywbkdr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((220454105)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ngehffo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((495493992)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("kucnfjojvgxgrnporfisrfomsd")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("itkyekvsaukqjkljmnt")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((265270038)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lwotnndimftwd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1373265565)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("imcop")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ltvutlxslsjuxasf")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((266447007)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jmgbfuscvvwelbkkqruidcjbb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((297848082)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dgkafodshsarrnuxq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((337120212)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mvafvdtupjiymcdssumkos")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ajqbhsnowedshlyxqst")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((457983608)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rmskvd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((591543207)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jsulhkqaxdvvetourqhlt")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((581208365)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qgi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((620211437)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hyqjrfioxfrlvgwnxtfumvkjwfdli")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((631313641)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xgawqfboilxxphrpjtc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((690457296)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jmolggxfhy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1495227642)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ksmlsriyhtdjyxvhedjclykw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fncnoontkagrnkfodsuannccod")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ivqflirnxbkkaoldlwkyyydqfga")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((729248297)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hhimksvmxcik")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((853944735)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lswgeelpdatdpfjdgnlflikxaalrv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((894502594)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ojngxqshlxifgwqwrdqhlmorw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1429601770)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("seqrlkjaqwbiln")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("qoitovxvfhgfq")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qkniraflqxtvgweqqe")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((924524750)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qrqteicrrshedvtmyqxpotmcy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((483849738)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yewgudpphmqmq")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((995050294)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qlv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1017541666)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("joit")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1031880821)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hpubtcsle")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1160515916)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("clyjaq")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nryfcprmrcglwoiewtnmgfrpbqtdg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jlnbsovdhawcjugvhbo")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1134703117)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xudqveydn")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1219469829)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("txkikg")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("pbcsiyyqfdfcexjyldnsvahf")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1187359701)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlnjkhyabomgmpxpukchyd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((893884247)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ckgdofghrcubjgf")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1581781443)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oigfvwxvrhbptkblfwfpgceln")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qnee")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1652465762)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cupmvpdvbkcpyybmk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1218603036)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("iirikeehflbjgke")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("p")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1664762696)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rlcjxgailtkrdyl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1504668538)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wcmnetvxbhpkqxtmkwtf")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uoy")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1842603815)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kntwsqntnxassbopdnbtxomjel")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1188857112)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("elqbmugvsj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1926580000)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cybfaljnplivcnqkhjvcelsbuaj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("psov")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1931136219)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bchth")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1972391361)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hyubpxxdp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((502310185)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("brbjmjp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("la")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2020520348)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("clbvwmhfdhfhjsxe")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2102589040)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wuinnvtsg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wvmmnfwcecncuvlxdlvqipdh")));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtext0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Stringtext0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
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
FROM public.binary_stringtext0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Stringtext0MI),
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

                var importCollection = new List<Stringtext0MI>(7);

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 358179516,
                    Value = "ueefibdqnenfencgxekxdtyjihf",
                    NullableValue = "xhamubxg"
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 483849738,
                    Value = "yewgudpphmqmq",
                    NullableValue = null
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 495493992,
                    Value = "kucnfjojvgxgrnporfisrfomsd",
                    NullableValue = "itkyekvsaukqjkljmnt"
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 502310185,
                    Value = "brbjmjp",
                    NullableValue = null
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 591543207,
                    Value = "jsulhkqaxdvvetourqhlt",
                    NullableValue = null
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 893884247,
                    Value = "ckgdofghrcubjgf",
                    NullableValue = null
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1160515916,
                    Value = "clyjaq",
                    NullableValue = "nryfcprmrcglwoiewtnmgfrpbqtdg"
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(358179516));
                Assert.That(model.Value, Is.EqualTo("ueefibdqnenfencgxekxdtyjihf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("xhamubxg"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483849738));
                Assert.That(model.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495493992));
                Assert.That(model.Value, Is.EqualTo("kucnfjojvgxgrnporfisrfomsd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("itkyekvsaukqjkljmnt"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502310185));
                Assert.That(model.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(591543207));
                Assert.That(model.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893884247));
                Assert.That(model.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1160515916));
                Assert.That(model.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));

                importCollection.Clear();

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1188857112,
                    Value = "elqbmugvsj",
                    NullableValue = null
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1218603036,
                    Value = "iirikeehflbjgke",
                    NullableValue = "p"
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1219469829,
                    Value = "txkikg",
                    NullableValue = "pbcsiyyqfdfcexjyldnsvahf"
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1373265565,
                    Value = "imcop",
                    NullableValue = "ltvutlxslsjuxasf"
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1429601770,
                    Value = "seqrlkjaqwbiln",
                    NullableValue = "qoitovxvfhgfq"
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1495227642,
                    Value = "ksmlsriyhtdjyxvhedjclykw",
                    NullableValue = "fncnoontkagrnkfodsuannccod"
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1504668538,
                    Value = "wcmnetvxbhpkqxtmkwtf",
                    NullableValue = "uoy"
                });

                importCollection.Add(
                new Stringtext0MI
                {
                    Id = 1527379371,
                    Value = "aycdhiv",
                    NullableValue = "hfjsfnywbkdr"
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(358179516));
                Assert.That(model.Value, Is.EqualTo("ueefibdqnenfencgxekxdtyjihf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("xhamubxg"));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(483849738));
                Assert.That(model.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495493992));
                Assert.That(model.Value, Is.EqualTo("kucnfjojvgxgrnporfisrfomsd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("itkyekvsaukqjkljmnt"));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502310185));
                Assert.That(model.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(591543207));
                Assert.That(model.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893884247));
                Assert.That(model.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1160515916));
                Assert.That(model.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1188857112));
                Assert.That(model.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1218603036));
                Assert.That(model.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("p"));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1219469829));
                Assert.That(model.Value, Is.EqualTo("txkikg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1373265565));
                Assert.That(model.Value, Is.EqualTo("imcop"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ltvutlxslsjuxasf"));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429601770));
                Assert.That(model.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qoitovxvfhgfq"));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1495227642));
                Assert.That(model.Value, Is.EqualTo("ksmlsriyhtdjyxvhedjclykw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fncnoontkagrnkfodsuannccod"));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1504668538));
                Assert.That(model.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("uoy"));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1527379371));
                Assert.That(model.Value, Is.EqualTo("aycdhiv"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("hfjsfnywbkdr"));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtext0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtext0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Stringtext0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19)
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
FROM public.binary_stringtext0m m
LEFT JOIN public.binary_stringtext0mi mi ON mi.id = m.stringtext0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Stringtext0M),
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

                var importCollection = new List<Stringtext0M>(15);

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 33857238,
                    Value = "",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 358179516
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 132386070,
                    Value = "xsmqflaeymtmssateegjm",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1527379371
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 220454105,
                    Value = "ngehffo",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 495493992
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 265270038,
                    Value = "lwotnndimftwd",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1373265565
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 266447007,
                    Value = "jmgbfuscvvwelbkkqruidcjbb",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 297848082,
                    Value = "dgkafodshsarrnuxq",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 337120212,
                    Value = "mvafvdtupjiymcdssumkos",
                    NullableValue = "ajqbhsnowedshlyxqst",

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 457983608,
                    Value = "rmskvd",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 591543207
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 581208365,
                    Value = "qgi",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 620211437,
                    Value = "hyqjrfioxfrlvgwnxtfumvkjwfdli",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 631313641,
                    Value = "xgawqfboilxxphrpjtc",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 690457296,
                    Value = "jmolggxfhy",
                    NullableValue = "ivqflirnxbkkaoldlwkyyydqfga",

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1495227642
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 729248297,
                    Value = "hhimksvmxcik",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 853944735,
                    Value = "lswgeelpdatdpfjdgnlflikxaalrv",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 894502594,
                    Value = "ojngxqshlxifgwqwrdqhlmorw",
                    NullableValue = "qkniraflqxtvgweqqe",

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1429601770
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33857238));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(358179516));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ueefibdqnenfencgxekxdtyjihf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("xhamubxg"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(132386070));
                Assert.That(model.Value, Is.EqualTo("xsmqflaeymtmssateegjm"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527379371));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aycdhiv"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hfjsfnywbkdr"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220454105));
                Assert.That(model.Value, Is.EqualTo("ngehffo"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495493992));

                Assert.That(model.ModelInner.Value, Is.EqualTo("kucnfjojvgxgrnporfisrfomsd"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("itkyekvsaukqjkljmnt"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(265270038));
                Assert.That(model.Value, Is.EqualTo("lwotnndimftwd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1373265565));

                Assert.That(model.ModelInner.Value, Is.EqualTo("imcop"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ltvutlxslsjuxasf"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266447007));
                Assert.That(model.Value, Is.EqualTo("jmgbfuscvvwelbkkqruidcjbb"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297848082));
                Assert.That(model.Value, Is.EqualTo("dgkafodshsarrnuxq"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(337120212));
                Assert.That(model.Value, Is.EqualTo("mvafvdtupjiymcdssumkos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ajqbhsnowedshlyxqst"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457983608));
                Assert.That(model.Value, Is.EqualTo("rmskvd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591543207));

                Assert.That(model.ModelInner.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581208365));
                Assert.That(model.Value, Is.EqualTo("qgi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620211437));
                Assert.That(model.Value, Is.EqualTo("hyqjrfioxfrlvgwnxtfumvkjwfdli"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(631313641));
                Assert.That(model.Value, Is.EqualTo("xgawqfboilxxphrpjtc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690457296));
                Assert.That(model.Value, Is.EqualTo("jmolggxfhy"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ivqflirnxbkkaoldlwkyyydqfga"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1495227642));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ksmlsriyhtdjyxvhedjclykw"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("fncnoontkagrnkfodsuannccod"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729248297));
                Assert.That(model.Value, Is.EqualTo("hhimksvmxcik"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(853944735));
                Assert.That(model.Value, Is.EqualTo("lswgeelpdatdpfjdgnlflikxaalrv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));

                importCollection.Clear();

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 924524750,
                    Value = "qrqteicrrshedvtmyqxpotmcy",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 483849738
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 995050294,
                    Value = "qlv",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1017541666,
                    Value = "joit",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1031880821,
                    Value = "hpubtcsle",
                    NullableValue = "jlnbsovdhawcjugvhbo",

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1160515916
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1134703117,
                    Value = "xudqveydn",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1219469829
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1187359701,
                    Value = "wlnjkhyabomgmpxpukchyd",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 893884247
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1581781443,
                    Value = "oigfvwxvrhbptkblfwfpgceln",
                    NullableValue = "qnee",

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1652465762,
                    Value = "cupmvpdvbkcpyybmk",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1218603036
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1664762696,
                    Value = "rlcjxgailtkrdyl",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1504668538
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1842603815,
                    Value = "kntwsqntnxassbopdnbtxomjel",
                    NullableValue = null,

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 1188857112
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1926580000,
                    Value = "cybfaljnplivcnqkhjvcelsbuaj",
                    NullableValue = "psov",

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1931136219,
                    Value = "bchth",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 1972391361,
                    Value = "hyubpxxdp",
                    NullableValue = "la",

                    ModelInner = new Stringtext0MI 
                    {
                        Id = 502310185
                    }

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 2020520348,
                    Value = "clbvwmhfdhfhjsxe",
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Stringtext0M
                {
                    Id = 2102589040,
                    Value = "wuinnvtsg",
                    NullableValue = "wvmmnfwcecncuvlxdlvqipdh",

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(33857238));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(358179516));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ueefibdqnenfencgxekxdtyjihf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("xhamubxg"));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(132386070));
                Assert.That(model.Value, Is.EqualTo("xsmqflaeymtmssateegjm"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527379371));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aycdhiv"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hfjsfnywbkdr"));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220454105));
                Assert.That(model.Value, Is.EqualTo("ngehffo"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495493992));

                Assert.That(model.ModelInner.Value, Is.EqualTo("kucnfjojvgxgrnporfisrfomsd"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("itkyekvsaukqjkljmnt"));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(265270038));
                Assert.That(model.Value, Is.EqualTo("lwotnndimftwd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1373265565));

                Assert.That(model.ModelInner.Value, Is.EqualTo("imcop"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ltvutlxslsjuxasf"));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266447007));
                Assert.That(model.Value, Is.EqualTo("jmgbfuscvvwelbkkqruidcjbb"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297848082));
                Assert.That(model.Value, Is.EqualTo("dgkafodshsarrnuxq"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(337120212));
                Assert.That(model.Value, Is.EqualTo("mvafvdtupjiymcdssumkos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ajqbhsnowedshlyxqst"));

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457983608));
                Assert.That(model.Value, Is.EqualTo("rmskvd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591543207));

                Assert.That(model.ModelInner.Value, Is.EqualTo("jsulhkqaxdvvetourqhlt"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581208365));
                Assert.That(model.Value, Is.EqualTo("qgi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(620211437));
                Assert.That(model.Value, Is.EqualTo("hyqjrfioxfrlvgwnxtfumvkjwfdli"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(631313641));
                Assert.That(model.Value, Is.EqualTo("xgawqfboilxxphrpjtc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(690457296));
                Assert.That(model.Value, Is.EqualTo("jmolggxfhy"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ivqflirnxbkkaoldlwkyyydqfga"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1495227642));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ksmlsriyhtdjyxvhedjclykw"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("fncnoontkagrnkfodsuannccod"));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(729248297));
                Assert.That(model.Value, Is.EqualTo("hhimksvmxcik"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(853944735));
                Assert.That(model.Value, Is.EqualTo("lswgeelpdatdpfjdgnlflikxaalrv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(894502594));
                Assert.That(model.Value, Is.EqualTo("ojngxqshlxifgwqwrdqhlmorw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qkniraflqxtvgweqqe"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1429601770));

                Assert.That(model.ModelInner.Value, Is.EqualTo("seqrlkjaqwbiln"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qoitovxvfhgfq"));


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(924524750));
                Assert.That(model.Value, Is.EqualTo("qrqteicrrshedvtmyqxpotmcy"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483849738));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yewgudpphmqmq"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995050294));
                Assert.That(model.Value, Is.EqualTo("qlv"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017541666));
                Assert.That(model.Value, Is.EqualTo("joit"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031880821));
                Assert.That(model.Value, Is.EqualTo("hpubtcsle"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jlnbsovdhawcjugvhbo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160515916));

                Assert.That(model.ModelInner.Value, Is.EqualTo("clyjaq"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("nryfcprmrcglwoiewtnmgfrpbqtdg"));


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134703117));
                Assert.That(model.Value, Is.EqualTo("xudqveydn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1219469829));

                Assert.That(model.ModelInner.Value, Is.EqualTo("txkikg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pbcsiyyqfdfcexjyldnsvahf"));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187359701));
                Assert.That(model.Value, Is.EqualTo("wlnjkhyabomgmpxpukchyd"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(893884247));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ckgdofghrcubjgf"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1581781443));
                Assert.That(model.Value, Is.EqualTo("oigfvwxvrhbptkblfwfpgceln"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qnee"));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652465762));
                Assert.That(model.Value, Is.EqualTo("cupmvpdvbkcpyybmk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218603036));

                Assert.That(model.ModelInner.Value, Is.EqualTo("iirikeehflbjgke"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("p"));


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664762696));
                Assert.That(model.Value, Is.EqualTo("rlcjxgailtkrdyl"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504668538));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wcmnetvxbhpkqxtmkwtf"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("uoy"));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1842603815));
                Assert.That(model.Value, Is.EqualTo("kntwsqntnxassbopdnbtxomjel"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1188857112));

                Assert.That(model.ModelInner.Value, Is.EqualTo("elqbmugvsj"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1926580000));
                Assert.That(model.Value, Is.EqualTo("cybfaljnplivcnqkhjvcelsbuaj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("psov"));

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931136219));
                Assert.That(model.Value, Is.EqualTo("bchth"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972391361));
                Assert.That(model.Value, Is.EqualTo("hyubpxxdp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("la"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(502310185));

                Assert.That(model.ModelInner.Value, Is.EqualTo("brbjmjp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020520348));
                Assert.That(model.Value, Is.EqualTo("clbvwmhfdhfhjsxe"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2102589040));
                Assert.That(model.Value, Is.EqualTo("wuinnvtsg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wvmmnfwcecncuvlxdlvqipdh"));

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtext0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtext0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Stringtext0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19)
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

                var expected = new Dictionary<System.Int32,Stringtext0M>(30);

                expected.Add(
                    33857238,
                    new Stringtext0M
                    {
                        Id = 33857238,
                        Value = "",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 358179516,
                            Value = "ueefibdqnenfencgxekxdtyjihf",
                            NullableValue = "xhamubxg"
                        }

                    }
                );

                expected.Add(
                    132386070,
                    new Stringtext0M
                    {
                        Id = 132386070,
                        Value = "xsmqflaeymtmssateegjm",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1527379371,
                            Value = "aycdhiv",
                            NullableValue = "hfjsfnywbkdr"
                        }

                    }
                );

                expected.Add(
                    220454105,
                    new Stringtext0M
                    {
                        Id = 220454105,
                        Value = "ngehffo",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 495493992,
                            Value = "kucnfjojvgxgrnporfisrfomsd",
                            NullableValue = "itkyekvsaukqjkljmnt"
                        }

                    }
                );

                expected.Add(
                    265270038,
                    new Stringtext0M
                    {
                        Id = 265270038,
                        Value = "lwotnndimftwd",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1373265565,
                            Value = "imcop",
                            NullableValue = "ltvutlxslsjuxasf"
                        }

                    }
                );

                expected.Add(
                    266447007,
                    new Stringtext0M
                    {
                        Id = 266447007,
                        Value = "jmgbfuscvvwelbkkqruidcjbb",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    297848082,
                    new Stringtext0M
                    {
                        Id = 297848082,
                        Value = "dgkafodshsarrnuxq",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    337120212,
                    new Stringtext0M
                    {
                        Id = 337120212,
                        Value = "mvafvdtupjiymcdssumkos",
                        NullableValue = "ajqbhsnowedshlyxqst",

                        ModelInner = null

                    }
                );

                expected.Add(
                    457983608,
                    new Stringtext0M
                    {
                        Id = 457983608,
                        Value = "rmskvd",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 591543207,
                            Value = "jsulhkqaxdvvetourqhlt",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    581208365,
                    new Stringtext0M
                    {
                        Id = 581208365,
                        Value = "qgi",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    620211437,
                    new Stringtext0M
                    {
                        Id = 620211437,
                        Value = "hyqjrfioxfrlvgwnxtfumvkjwfdli",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    631313641,
                    new Stringtext0M
                    {
                        Id = 631313641,
                        Value = "xgawqfboilxxphrpjtc",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    690457296,
                    new Stringtext0M
                    {
                        Id = 690457296,
                        Value = "jmolggxfhy",
                        NullableValue = "ivqflirnxbkkaoldlwkyyydqfga",

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1495227642,
                            Value = "ksmlsriyhtdjyxvhedjclykw",
                            NullableValue = "fncnoontkagrnkfodsuannccod"
                        }

                    }
                );

                expected.Add(
                    729248297,
                    new Stringtext0M
                    {
                        Id = 729248297,
                        Value = "hhimksvmxcik",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    853944735,
                    new Stringtext0M
                    {
                        Id = 853944735,
                        Value = "lswgeelpdatdpfjdgnlflikxaalrv",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    894502594,
                    new Stringtext0M
                    {
                        Id = 894502594,
                        Value = "ojngxqshlxifgwqwrdqhlmorw",
                        NullableValue = "qkniraflqxtvgweqqe",

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1429601770,
                            Value = "seqrlkjaqwbiln",
                            NullableValue = "qoitovxvfhgfq"
                        }

                    }
                );

                expected.Add(
                    924524750,
                    new Stringtext0M
                    {
                        Id = 924524750,
                        Value = "qrqteicrrshedvtmyqxpotmcy",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 483849738,
                            Value = "yewgudpphmqmq",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    995050294,
                    new Stringtext0M
                    {
                        Id = 995050294,
                        Value = "qlv",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1017541666,
                    new Stringtext0M
                    {
                        Id = 1017541666,
                        Value = "joit",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1031880821,
                    new Stringtext0M
                    {
                        Id = 1031880821,
                        Value = "hpubtcsle",
                        NullableValue = "jlnbsovdhawcjugvhbo",

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1160515916,
                            Value = "clyjaq",
                            NullableValue = "nryfcprmrcglwoiewtnmgfrpbqtdg"
                        }

                    }
                );

                expected.Add(
                    1134703117,
                    new Stringtext0M
                    {
                        Id = 1134703117,
                        Value = "xudqveydn",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1219469829,
                            Value = "txkikg",
                            NullableValue = "pbcsiyyqfdfcexjyldnsvahf"
                        }

                    }
                );

                expected.Add(
                    1187359701,
                    new Stringtext0M
                    {
                        Id = 1187359701,
                        Value = "wlnjkhyabomgmpxpukchyd",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 893884247,
                            Value = "ckgdofghrcubjgf",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1581781443,
                    new Stringtext0M
                    {
                        Id = 1581781443,
                        Value = "oigfvwxvrhbptkblfwfpgceln",
                        NullableValue = "qnee",

                        ModelInner = null

                    }
                );

                expected.Add(
                    1652465762,
                    new Stringtext0M
                    {
                        Id = 1652465762,
                        Value = "cupmvpdvbkcpyybmk",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1218603036,
                            Value = "iirikeehflbjgke",
                            NullableValue = "p"
                        }

                    }
                );

                expected.Add(
                    1664762696,
                    new Stringtext0M
                    {
                        Id = 1664762696,
                        Value = "rlcjxgailtkrdyl",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1504668538,
                            Value = "wcmnetvxbhpkqxtmkwtf",
                            NullableValue = "uoy"
                        }

                    }
                );

                expected.Add(
                    1842603815,
                    new Stringtext0M
                    {
                        Id = 1842603815,
                        Value = "kntwsqntnxassbopdnbtxomjel",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1188857112,
                            Value = "elqbmugvsj",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1926580000,
                    new Stringtext0M
                    {
                        Id = 1926580000,
                        Value = "cybfaljnplivcnqkhjvcelsbuaj",
                        NullableValue = "psov",

                        ModelInner = null

                    }
                );

                expected.Add(
                    1931136219,
                    new Stringtext0M
                    {
                        Id = 1931136219,
                        Value = "bchth",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1972391361,
                    new Stringtext0M
                    {
                        Id = 1972391361,
                        Value = "hyubpxxdp",
                        NullableValue = "la",

                        ModelInner = new Stringtext0MI
                        {
                            Id = 502310185,
                            Value = "brbjmjp",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2020520348,
                    new Stringtext0M
                    {
                        Id = 2020520348,
                        Value = "clbvwmhfdhfhjsxe",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2102589040,
                    new Stringtext0M
                    {
                        Id = 2102589040,
                        Value = "wuinnvtsg",
                        NullableValue = "wvmmnfwcecncuvlxdlvqipdh",

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.String)default));
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

                var expected = new Dictionary<System.Int32,Stringtext0M>(30);

                expected.Add(
                    33857238,
                    new Stringtext0M
                    {
                        Id = 33857238,
                        Value = "",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 358179516,
                            Value = "ueefibdqnenfencgxekxdtyjihf",
                            NullableValue = "xhamubxg"
                        }

                    }
                );

                expected.Add(
                    132386070,
                    new Stringtext0M
                    {
                        Id = 132386070,
                        Value = "xsmqflaeymtmssateegjm",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1527379371,
                            Value = "aycdhiv",
                            NullableValue = "hfjsfnywbkdr"
                        }

                    }
                );

                expected.Add(
                    220454105,
                    new Stringtext0M
                    {
                        Id = 220454105,
                        Value = "ngehffo",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 495493992,
                            Value = "kucnfjojvgxgrnporfisrfomsd",
                            NullableValue = "itkyekvsaukqjkljmnt"
                        }

                    }
                );

                expected.Add(
                    265270038,
                    new Stringtext0M
                    {
                        Id = 265270038,
                        Value = "lwotnndimftwd",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1373265565,
                            Value = "imcop",
                            NullableValue = "ltvutlxslsjuxasf"
                        }

                    }
                );

                expected.Add(
                    266447007,
                    new Stringtext0M
                    {
                        Id = 266447007,
                        Value = "jmgbfuscvvwelbkkqruidcjbb",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    297848082,
                    new Stringtext0M
                    {
                        Id = 297848082,
                        Value = "dgkafodshsarrnuxq",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    337120212,
                    new Stringtext0M
                    {
                        Id = 337120212,
                        Value = "mvafvdtupjiymcdssumkos",
                        NullableValue = "ajqbhsnowedshlyxqst",

                        ModelInner = null

                    }
                );

                expected.Add(
                    457983608,
                    new Stringtext0M
                    {
                        Id = 457983608,
                        Value = "rmskvd",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 591543207,
                            Value = "jsulhkqaxdvvetourqhlt",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    581208365,
                    new Stringtext0M
                    {
                        Id = 581208365,
                        Value = "qgi",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    620211437,
                    new Stringtext0M
                    {
                        Id = 620211437,
                        Value = "hyqjrfioxfrlvgwnxtfumvkjwfdli",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    631313641,
                    new Stringtext0M
                    {
                        Id = 631313641,
                        Value = "xgawqfboilxxphrpjtc",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    690457296,
                    new Stringtext0M
                    {
                        Id = 690457296,
                        Value = "jmolggxfhy",
                        NullableValue = "ivqflirnxbkkaoldlwkyyydqfga",

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1495227642,
                            Value = "ksmlsriyhtdjyxvhedjclykw",
                            NullableValue = "fncnoontkagrnkfodsuannccod"
                        }

                    }
                );

                expected.Add(
                    729248297,
                    new Stringtext0M
                    {
                        Id = 729248297,
                        Value = "hhimksvmxcik",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    853944735,
                    new Stringtext0M
                    {
                        Id = 853944735,
                        Value = "lswgeelpdatdpfjdgnlflikxaalrv",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    894502594,
                    new Stringtext0M
                    {
                        Id = 894502594,
                        Value = "ojngxqshlxifgwqwrdqhlmorw",
                        NullableValue = "qkniraflqxtvgweqqe",

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1429601770,
                            Value = "seqrlkjaqwbiln",
                            NullableValue = "qoitovxvfhgfq"
                        }

                    }
                );

                expected.Add(
                    924524750,
                    new Stringtext0M
                    {
                        Id = 924524750,
                        Value = "qrqteicrrshedvtmyqxpotmcy",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 483849738,
                            Value = "yewgudpphmqmq",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    995050294,
                    new Stringtext0M
                    {
                        Id = 995050294,
                        Value = "qlv",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1017541666,
                    new Stringtext0M
                    {
                        Id = 1017541666,
                        Value = "joit",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1031880821,
                    new Stringtext0M
                    {
                        Id = 1031880821,
                        Value = "hpubtcsle",
                        NullableValue = "jlnbsovdhawcjugvhbo",

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1160515916,
                            Value = "clyjaq",
                            NullableValue = "nryfcprmrcglwoiewtnmgfrpbqtdg"
                        }

                    }
                );

                expected.Add(
                    1134703117,
                    new Stringtext0M
                    {
                        Id = 1134703117,
                        Value = "xudqveydn",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1219469829,
                            Value = "txkikg",
                            NullableValue = "pbcsiyyqfdfcexjyldnsvahf"
                        }

                    }
                );

                expected.Add(
                    1187359701,
                    new Stringtext0M
                    {
                        Id = 1187359701,
                        Value = "wlnjkhyabomgmpxpukchyd",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 893884247,
                            Value = "ckgdofghrcubjgf",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1581781443,
                    new Stringtext0M
                    {
                        Id = 1581781443,
                        Value = "oigfvwxvrhbptkblfwfpgceln",
                        NullableValue = "qnee",

                        ModelInner = null

                    }
                );

                expected.Add(
                    1652465762,
                    new Stringtext0M
                    {
                        Id = 1652465762,
                        Value = "cupmvpdvbkcpyybmk",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1218603036,
                            Value = "iirikeehflbjgke",
                            NullableValue = "p"
                        }

                    }
                );

                expected.Add(
                    1664762696,
                    new Stringtext0M
                    {
                        Id = 1664762696,
                        Value = "rlcjxgailtkrdyl",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1504668538,
                            Value = "wcmnetvxbhpkqxtmkwtf",
                            NullableValue = "uoy"
                        }

                    }
                );

                expected.Add(
                    1842603815,
                    new Stringtext0M
                    {
                        Id = 1842603815,
                        Value = "kntwsqntnxassbopdnbtxomjel",
                        NullableValue = null,

                        ModelInner = new Stringtext0MI
                        {
                            Id = 1188857112,
                            Value = "elqbmugvsj",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1926580000,
                    new Stringtext0M
                    {
                        Id = 1926580000,
                        Value = "cybfaljnplivcnqkhjvcelsbuaj",
                        NullableValue = "psov",

                        ModelInner = null

                    }
                );

                expected.Add(
                    1931136219,
                    new Stringtext0M
                    {
                        Id = 1931136219,
                        Value = "bchth",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1972391361,
                    new Stringtext0M
                    {
                        Id = 1972391361,
                        Value = "hyubpxxdp",
                        NullableValue = "la",

                        ModelInner = new Stringtext0MI
                        {
                            Id = 502310185,
                            Value = "brbjmjp",
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2020520348,
                    new Stringtext0M
                    {
                        Id = 2020520348,
                        Value = "clbvwmhfdhfhjsxe",
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2102589040,
                    new Stringtext0M
                    {
                        Id = 2102589040,
                        Value = "wuinnvtsg",
                        NullableValue = "wvmmnfwcecncuvlxdlvqipdh",

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.String)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtext0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Stringtext0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
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

                var expected = new Dictionary<System.Int32,Stringtext0MI>(15);

                expected.Add(
                    358179516,
                    new Stringtext0MI
                    {
                        Id = 358179516,
                        Value = "ueefibdqnenfencgxekxdtyjihf",
                        NullableValue = "xhamubxg"
                    }
                );

                expected.Add(
                    483849738,
                    new Stringtext0MI
                    {
                        Id = 483849738,
                        Value = "yewgudpphmqmq",
                        NullableValue = null
                    }
                );

                expected.Add(
                    495493992,
                    new Stringtext0MI
                    {
                        Id = 495493992,
                        Value = "kucnfjojvgxgrnporfisrfomsd",
                        NullableValue = "itkyekvsaukqjkljmnt"
                    }
                );

                expected.Add(
                    502310185,
                    new Stringtext0MI
                    {
                        Id = 502310185,
                        Value = "brbjmjp",
                        NullableValue = null
                    }
                );

                expected.Add(
                    591543207,
                    new Stringtext0MI
                    {
                        Id = 591543207,
                        Value = "jsulhkqaxdvvetourqhlt",
                        NullableValue = null
                    }
                );

                expected.Add(
                    893884247,
                    new Stringtext0MI
                    {
                        Id = 893884247,
                        Value = "ckgdofghrcubjgf",
                        NullableValue = null
                    }
                );

                expected.Add(
                    1160515916,
                    new Stringtext0MI
                    {
                        Id = 1160515916,
                        Value = "clyjaq",
                        NullableValue = "nryfcprmrcglwoiewtnmgfrpbqtdg"
                    }
                );

                expected.Add(
                    1188857112,
                    new Stringtext0MI
                    {
                        Id = 1188857112,
                        Value = "elqbmugvsj",
                        NullableValue = null
                    }
                );

                expected.Add(
                    1218603036,
                    new Stringtext0MI
                    {
                        Id = 1218603036,
                        Value = "iirikeehflbjgke",
                        NullableValue = "p"
                    }
                );

                expected.Add(
                    1219469829,
                    new Stringtext0MI
                    {
                        Id = 1219469829,
                        Value = "txkikg",
                        NullableValue = "pbcsiyyqfdfcexjyldnsvahf"
                    }
                );

                expected.Add(
                    1373265565,
                    new Stringtext0MI
                    {
                        Id = 1373265565,
                        Value = "imcop",
                        NullableValue = "ltvutlxslsjuxasf"
                    }
                );

                expected.Add(
                    1429601770,
                    new Stringtext0MI
                    {
                        Id = 1429601770,
                        Value = "seqrlkjaqwbiln",
                        NullableValue = "qoitovxvfhgfq"
                    }
                );

                expected.Add(
                    1495227642,
                    new Stringtext0MI
                    {
                        Id = 1495227642,
                        Value = "ksmlsriyhtdjyxvhedjclykw",
                        NullableValue = "fncnoontkagrnkfodsuannccod"
                    }
                );

                expected.Add(
                    1504668538,
                    new Stringtext0MI
                    {
                        Id = 1504668538,
                        Value = "wcmnetvxbhpkqxtmkwtf",
                        NullableValue = "uoy"
                    }
                );

                expected.Add(
                    1527379371,
                    new Stringtext0MI
                    {
                        Id = 1527379371,
                        Value = "aycdhiv",
                        NullableValue = "hfjsfnywbkdr"
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

                var expected = new Dictionary<System.Int32,Stringtext0MI>(15);

                expected.Add(
                    358179516,
                    new Stringtext0MI
                    {
                        Id = 358179516,
                        Value = "ueefibdqnenfencgxekxdtyjihf",
                        NullableValue = "xhamubxg"
                    }
                );

                expected.Add(
                    483849738,
                    new Stringtext0MI
                    {
                        Id = 483849738,
                        Value = "yewgudpphmqmq",
                        NullableValue = null
                    }
                );

                expected.Add(
                    495493992,
                    new Stringtext0MI
                    {
                        Id = 495493992,
                        Value = "kucnfjojvgxgrnporfisrfomsd",
                        NullableValue = "itkyekvsaukqjkljmnt"
                    }
                );

                expected.Add(
                    502310185,
                    new Stringtext0MI
                    {
                        Id = 502310185,
                        Value = "brbjmjp",
                        NullableValue = null
                    }
                );

                expected.Add(
                    591543207,
                    new Stringtext0MI
                    {
                        Id = 591543207,
                        Value = "jsulhkqaxdvvetourqhlt",
                        NullableValue = null
                    }
                );

                expected.Add(
                    893884247,
                    new Stringtext0MI
                    {
                        Id = 893884247,
                        Value = "ckgdofghrcubjgf",
                        NullableValue = null
                    }
                );

                expected.Add(
                    1160515916,
                    new Stringtext0MI
                    {
                        Id = 1160515916,
                        Value = "clyjaq",
                        NullableValue = "nryfcprmrcglwoiewtnmgfrpbqtdg"
                    }
                );

                expected.Add(
                    1188857112,
                    new Stringtext0MI
                    {
                        Id = 1188857112,
                        Value = "elqbmugvsj",
                        NullableValue = null
                    }
                );

                expected.Add(
                    1218603036,
                    new Stringtext0MI
                    {
                        Id = 1218603036,
                        Value = "iirikeehflbjgke",
                        NullableValue = "p"
                    }
                );

                expected.Add(
                    1219469829,
                    new Stringtext0MI
                    {
                        Id = 1219469829,
                        Value = "txkikg",
                        NullableValue = "pbcsiyyqfdfcexjyldnsvahf"
                    }
                );

                expected.Add(
                    1373265565,
                    new Stringtext0MI
                    {
                        Id = 1373265565,
                        Value = "imcop",
                        NullableValue = "ltvutlxslsjuxasf"
                    }
                );

                expected.Add(
                    1429601770,
                    new Stringtext0MI
                    {
                        Id = 1429601770,
                        Value = "seqrlkjaqwbiln",
                        NullableValue = "qoitovxvfhgfq"
                    }
                );

                expected.Add(
                    1495227642,
                    new Stringtext0MI
                    {
                        Id = 1495227642,
                        Value = "ksmlsriyhtdjyxvhedjclykw",
                        NullableValue = "fncnoontkagrnkfodsuannccod"
                    }
                );

                expected.Add(
                    1504668538,
                    new Stringtext0MI
                    {
                        Id = 1504668538,
                        Value = "wcmnetvxbhpkqxtmkwtf",
                        NullableValue = "uoy"
                    }
                );

                expected.Add(
                    1527379371,
                    new Stringtext0MI
                    {
                        Id = 1527379371,
                        Value = "aycdhiv",
                        NullableValue = "hfjsfnywbkdr"
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




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
    internal partial interface IGuidSingleTypeuuid
    {
    }
    
    internal partial class GuidSingleTypeuuid : IGuidSingleTypeuuid
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
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
            asPartInterface: typeof(IGuidSingleTypeuuid)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
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
            queryMapType: typeof(Guiduuid0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)
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

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModelInner(connection, 1669515366, Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551"), Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModelInner(connection, 333349314, Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25"), null);
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

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelInnerAsync(connection, 1067045906, Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelInnerAsync(connection, 1004462342, Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52"), Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c"));
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

                id =  ((IGuidSingleTypeuuid)this).InsertModelInnerReturning(connection, 1999892513, Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481"), Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61"));
                Assert.That(id, Is.EqualTo(1999892513));

                id =  ((IGuidSingleTypeuuid)this).InsertModelInnerReturning(connection, 129904778, Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543"), Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77"));
                Assert.That(id, Is.EqualTo(129904778));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IGuidSingleTypeuuid)this).InsertModelInnerReturningAsync(connection, 662901024, Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b"), Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c"));
                Assert.That(id, Is.EqualTo(662901024));

                id = await ((IGuidSingleTypeuuid)this).InsertModelInnerReturningAsync(connection, 1136518499, Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2"), Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef"));
                Assert.That(id, Is.EqualTo(1136518499));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
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
            asPartInterface: typeof(IGuidSingleTypeuuid)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(9)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(9), 
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

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModel(connection, 405175442, Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd"), Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1"));
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, 929173163, Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697"), Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, 964128946, Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401"), Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, 1286787104, Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee"), Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, 846028277, Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, 2082755993, Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc"), Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, 1220524810, Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5"), Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9"));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
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
            asPartInterface: typeof(IGuidSingleTypeuuid)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuid0mi_id", 
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

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModel(connection, 1388117398, Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738"), Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModel(connection, 1735275542, Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562"), Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e"), 1669515366);
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

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelAsync(connection, 817526809, Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelAsync(connection, 1770719850, Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66"), null, 333349314);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;

                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, 264481987, Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef"), null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, 174298103, Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683"), Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79"), 1067045906);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79")));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;

                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, 795284594, Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2"), Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894"), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, 2103818091, Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066"), null, 1004462342);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
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
    guiduuid0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Guiduuid0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuid0mi_id", 
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
                List<Guiduuid0M> models = null;
                Guiduuid0M model = null;

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, 692292510, Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2"), Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d"), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, 52596164, Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf"), Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958"), 1999892513).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(52596164));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1999892513));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, 1252963844, Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7"), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, 867462402, Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170"), Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668"), 129904778).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guiduuid0M> models = null;
                Guiduuid0M model = null;

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, 1804345238, Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275"), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, 111581562, Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223"), null, 662901024).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111581562));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(662901024));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, 1573076059, Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02"), Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad"), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, 797073791, Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795"), null, 1136518499).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduuid0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Guid), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(9)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(9),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduuid0mi_id", 
                methodParametrName: "guiduuid0mi_id", 
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

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertModel(connection, 40553378, Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38"), Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertModel(connection, 324930262, Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687"), Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949"), 405175442);
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 1428405456, Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68"), Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 1020155809, Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a"), null, 929173163);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 887739705, Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0"), Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 1377150186, Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f"), Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a"), 964128946);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 361524382, Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b"), Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 305149200, Guid.Parse("64403fc6-546d-46db-a252-c1020726acef"), Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a"), 1286787104);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 1204207357, Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f"), Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 1001526135, Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e"), Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d"), 846028277);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 266065193, Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 1266871280, Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e"), null, 2082755993);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 402196323, Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3"), Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, 1612498498, Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929"), Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d"), 1220524810);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Guiduuid0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)
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
                var models =  ((IGuidSingleTypeuuid)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40553378));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(52596164));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1999892513));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111581562));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(662901024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174298103));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1067045906));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264481987));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266065193));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(305149200));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64403fc6-546d-46db-a252-c1020726acef")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1286787104));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324930262));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405175442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361524382));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402196323));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795284594));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817526809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(887739705));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1001526135));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(846028277));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020155809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(929173163));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204207357));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40553378));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(52596164));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1999892513));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111581562));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(662901024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174298103));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1067045906));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264481987));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266065193));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(305149200));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64403fc6-546d-46db-a252-c1020726acef")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1286787104));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324930262));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405175442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361524382));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402196323));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795284594));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817526809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(887739705));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1001526135));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(846028277));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020155809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(929173163));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204207357));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Guiduuid0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)
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
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40553378));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(52596164));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1999892513));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111581562));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(662901024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174298103));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1067045906));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264481987));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266065193));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(305149200));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64403fc6-546d-46db-a252-c1020726acef")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1286787104));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324930262));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405175442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361524382));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402196323));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795284594));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817526809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(887739705));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1001526135));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(846028277));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020155809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(929173163));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204207357));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40553378));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(52596164));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1999892513));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111581562));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(662901024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174298103));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1067045906));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264481987));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266065193));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(305149200));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64403fc6-546d-46db-a252-c1020726acef")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1286787104));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324930262));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405175442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361524382));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402196323));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795284594));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817526809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(887739705));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1001526135));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(846028277));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020155809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(929173163));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204207357));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 1735275542);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(3));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 305149200);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(23));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324930262));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405175442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361524382));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402196323));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795284594));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817526809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(887739705));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1001526135));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(846028277));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020155809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(929173163));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204207357));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)
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
                 foreach(var batchResult in ((IGuidSingleTypeuuid)this).DbConnectionSelectModelBatch(connection, 887739705, 1252963844))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1001526135));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(846028277));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020155809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(929173163));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204207357));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

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
                await foreach(var batchResult in ((IGuidSingleTypeuuid)this).DbConnectionSelectModelBatchAsync(connection, 266065193, 1204207357))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(305149200));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64403fc6-546d-46db-a252-c1020726acef")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1286787104));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324930262));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405175442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361524382));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402196323));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795284594));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817526809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(887739705));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1001526135));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(846028277));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020155809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(929173163));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204207357));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));

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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
            asPartInterface: typeof(IGuidSingleTypeuuid)
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
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40553378)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52596164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1999892513)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111581562)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((662901024)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174298103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1067045906)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((264481987)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((266065193)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((305149200)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("64403fc6-546d-46db-a252-c1020726acef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1286787104)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((324930262)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((405175442)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((361524382)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((402196323)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((692292510)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((795284594)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((797073791)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1136518499)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((817526809)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((867462402)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((129904778)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((887739705)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1001526135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((846028277)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1020155809)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((929173163)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1204207357)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1252963844)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1266871280)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2082755993)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1377150186)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((964128946)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1388117398)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1428405456)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1573076059)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1612498498)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1220524810)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1735275542)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1669515366)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1770719850)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((333349314)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1804345238)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2103818091)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1004462342)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40553378)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52596164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1999892513)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111581562)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((662901024)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174298103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1067045906)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((264481987)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((266065193)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((305149200)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("64403fc6-546d-46db-a252-c1020726acef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1286787104)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((324930262)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((405175442)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((361524382)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((402196323)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((692292510)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((795284594)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((797073791)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1136518499)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((817526809)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((867462402)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((129904778)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((887739705)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1001526135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((846028277)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1020155809)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((929173163)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1204207357)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1252963844)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1266871280)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2082755993)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1377150186)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((964128946)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1388117398)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1428405456)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1573076059)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1612498498)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1220524810)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1735275542)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1669515366)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1770719850)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((333349314)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1804345238)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2103818091)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1004462342)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuid0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Guiduuid0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Guiduuid0MI),
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

                var importCollection = new List<Guiduuid0MI>(7);

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 129904778,
                    Value = Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543"),
                    NullableValue = Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 333349314,
                    Value = Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25"),
                    NullableValue = null
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 405175442,
                    Value = Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd"),
                    NullableValue = Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 662901024,
                    Value = Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b"),
                    NullableValue = Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 846028277,
                    Value = Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57"),
                    NullableValue = null
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 929173163,
                    Value = Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697"),
                    NullableValue = Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 964128946,
                    Value = Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401"),
                    NullableValue = Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(129904778));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(333349314));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(405175442));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(662901024));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(846028277));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(929173163));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964128946));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));

                importCollection.Clear();

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 1004462342,
                    Value = Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52"),
                    NullableValue = Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 1067045906,
                    Value = Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649"),
                    NullableValue = null
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 1136518499,
                    Value = Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2"),
                    NullableValue = Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 1220524810,
                    Value = Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5"),
                    NullableValue = Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 1286787104,
                    Value = Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee"),
                    NullableValue = Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 1669515366,
                    Value = Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551"),
                    NullableValue = Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 1999892513,
                    Value = Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481"),
                    NullableValue = Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")
                });

                importCollection.Add(
                new Guiduuid0MI
                {
                    Id = 2082755993,
                    Value = Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc"),
                    NullableValue = Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(129904778));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(333349314));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(405175442));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(662901024));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(846028277));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(929173163));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(964128946));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004462342));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1067045906));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649")));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136518499));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1220524810));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1286787104));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1669515366));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1999892513));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2082755993));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuid0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuid0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Guiduuid0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27)
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
FROM public.binary_guiduuid0m m
LEFT JOIN public.binary_guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Guiduuid0M),
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

                var importCollection = new List<Guiduuid0M>(15);

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 40553378,
                    Value = Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38"),
                    NullableValue = Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 52596164,
                    Value = Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf"),
                    NullableValue = Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 1999892513
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 111581562,
                    Value = Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223"),
                    NullableValue = null,

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 662901024
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 174298103,
                    Value = Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683"),
                    NullableValue = Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 1067045906
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 264481987,
                    Value = Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 266065193,
                    Value = Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 305149200,
                    Value = Guid.Parse("64403fc6-546d-46db-a252-c1020726acef"),
                    NullableValue = Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 1286787104
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 324930262,
                    Value = Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687"),
                    NullableValue = Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 405175442
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 361524382,
                    Value = Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b"),
                    NullableValue = Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 402196323,
                    Value = Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3"),
                    NullableValue = Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 692292510,
                    Value = Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2"),
                    NullableValue = Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 795284594,
                    Value = Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2"),
                    NullableValue = Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 797073791,
                    Value = Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795"),
                    NullableValue = null,

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 1136518499
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 817526809,
                    Value = Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 867462402,
                    Value = Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170"),
                    NullableValue = Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 129904778
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40553378));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(52596164));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1999892513));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111581562));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(662901024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174298103));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1067045906));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264481987));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266065193));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(305149200));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64403fc6-546d-46db-a252-c1020726acef")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1286787104));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324930262));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405175442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361524382));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402196323));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795284594));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817526809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));

                importCollection.Clear();

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 887739705,
                    Value = Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0"),
                    NullableValue = Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1001526135,
                    Value = Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e"),
                    NullableValue = Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 846028277
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1020155809,
                    Value = Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a"),
                    NullableValue = null,

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 929173163
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1204207357,
                    Value = Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f"),
                    NullableValue = Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1252963844,
                    Value = Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1266871280,
                    Value = Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e"),
                    NullableValue = null,

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 2082755993
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1377150186,
                    Value = Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f"),
                    NullableValue = Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 964128946
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1388117398,
                    Value = Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738"),
                    NullableValue = Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1428405456,
                    Value = Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68"),
                    NullableValue = Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1573076059,
                    Value = Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02"),
                    NullableValue = Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad"),

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1612498498,
                    Value = Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929"),
                    NullableValue = Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 1220524810
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1735275542,
                    Value = Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562"),
                    NullableValue = Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e"),

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 1669515366
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1770719850,
                    Value = Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66"),
                    NullableValue = null,

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 333349314
                    }

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 1804345238,
                    Value = Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275"),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Guiduuid0M
                {
                    Id = 2103818091,
                    Value = Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066"),
                    NullableValue = null,

                    ModelInner = new Guiduuid0MI 
                    {
                        Id = 1004462342
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(40553378));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(52596164));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1999892513));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(111581562));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(662901024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174298103));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1067045906));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264481987));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266065193));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(305149200));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64403fc6-546d-46db-a252-c1020726acef")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1286787104));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324930262));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(405175442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361524382));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402196323));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692292510));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(795284594));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797073791));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1136518499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817526809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867462402));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129904778));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")));


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(887739705));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1001526135));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(846028277));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020155809));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(929173163));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1204207357));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1252963844));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1266871280));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2082755993));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")));


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1377150186));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(964128946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")));


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1388117398));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428405456));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573076059));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad")));

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1612498498));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220524810));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")));


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735275542));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1669515366));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")));


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1770719850));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(333349314));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1804345238));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2103818091));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1004462342));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")));


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuid0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuid0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Guiduuid0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27)
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

                var expected = new Dictionary<System.Int32,Guiduuid0M>(30);

                expected.Add(
                    40553378,
                    new Guiduuid0M
                    {
                        Id = 40553378,
                        Value = Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38"),
                        NullableValue = Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    52596164,
                    new Guiduuid0M
                    {
                        Id = 52596164,
                        Value = Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf"),
                        NullableValue = Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1999892513,
                            Value = Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481"),
                            NullableValue = Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")
                        }

                    }
                );

                expected.Add(
                    111581562,
                    new Guiduuid0M
                    {
                        Id = 111581562,
                        Value = Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 662901024,
                            Value = Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b"),
                            NullableValue = Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")
                        }

                    }
                );

                expected.Add(
                    174298103,
                    new Guiduuid0M
                    {
                        Id = 174298103,
                        Value = Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683"),
                        NullableValue = Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1067045906,
                            Value = Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    264481987,
                    new Guiduuid0M
                    {
                        Id = 264481987,
                        Value = Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    266065193,
                    new Guiduuid0M
                    {
                        Id = 266065193,
                        Value = Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    305149200,
                    new Guiduuid0M
                    {
                        Id = 305149200,
                        Value = Guid.Parse("64403fc6-546d-46db-a252-c1020726acef"),
                        NullableValue = Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1286787104,
                            Value = Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee"),
                            NullableValue = Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")
                        }

                    }
                );

                expected.Add(
                    324930262,
                    new Guiduuid0M
                    {
                        Id = 324930262,
                        Value = Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687"),
                        NullableValue = Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 405175442,
                            Value = Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd"),
                            NullableValue = Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")
                        }

                    }
                );

                expected.Add(
                    361524382,
                    new Guiduuid0M
                    {
                        Id = 361524382,
                        Value = Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b"),
                        NullableValue = Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    402196323,
                    new Guiduuid0M
                    {
                        Id = 402196323,
                        Value = Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3"),
                        NullableValue = Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    692292510,
                    new Guiduuid0M
                    {
                        Id = 692292510,
                        Value = Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2"),
                        NullableValue = Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    795284594,
                    new Guiduuid0M
                    {
                        Id = 795284594,
                        Value = Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2"),
                        NullableValue = Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    797073791,
                    new Guiduuid0M
                    {
                        Id = 797073791,
                        Value = Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1136518499,
                            Value = Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2"),
                            NullableValue = Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")
                        }

                    }
                );

                expected.Add(
                    817526809,
                    new Guiduuid0M
                    {
                        Id = 817526809,
                        Value = Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    867462402,
                    new Guiduuid0M
                    {
                        Id = 867462402,
                        Value = Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170"),
                        NullableValue = Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 129904778,
                            Value = Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543"),
                            NullableValue = Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")
                        }

                    }
                );

                expected.Add(
                    887739705,
                    new Guiduuid0M
                    {
                        Id = 887739705,
                        Value = Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0"),
                        NullableValue = Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1001526135,
                    new Guiduuid0M
                    {
                        Id = 1001526135,
                        Value = Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e"),
                        NullableValue = Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 846028277,
                            Value = Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1020155809,
                    new Guiduuid0M
                    {
                        Id = 1020155809,
                        Value = Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 929173163,
                            Value = Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697"),
                            NullableValue = Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")
                        }

                    }
                );

                expected.Add(
                    1204207357,
                    new Guiduuid0M
                    {
                        Id = 1204207357,
                        Value = Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f"),
                        NullableValue = Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1252963844,
                    new Guiduuid0M
                    {
                        Id = 1252963844,
                        Value = Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1266871280,
                    new Guiduuid0M
                    {
                        Id = 1266871280,
                        Value = Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 2082755993,
                            Value = Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc"),
                            NullableValue = Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")
                        }

                    }
                );

                expected.Add(
                    1377150186,
                    new Guiduuid0M
                    {
                        Id = 1377150186,
                        Value = Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f"),
                        NullableValue = Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 964128946,
                            Value = Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401"),
                            NullableValue = Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")
                        }

                    }
                );

                expected.Add(
                    1388117398,
                    new Guiduuid0M
                    {
                        Id = 1388117398,
                        Value = Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738"),
                        NullableValue = Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1428405456,
                    new Guiduuid0M
                    {
                        Id = 1428405456,
                        Value = Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68"),
                        NullableValue = Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1573076059,
                    new Guiduuid0M
                    {
                        Id = 1573076059,
                        Value = Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02"),
                        NullableValue = Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1612498498,
                    new Guiduuid0M
                    {
                        Id = 1612498498,
                        Value = Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929"),
                        NullableValue = Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1220524810,
                            Value = Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5"),
                            NullableValue = Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")
                        }

                    }
                );

                expected.Add(
                    1735275542,
                    new Guiduuid0M
                    {
                        Id = 1735275542,
                        Value = Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562"),
                        NullableValue = Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1669515366,
                            Value = Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551"),
                            NullableValue = Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")
                        }

                    }
                );

                expected.Add(
                    1770719850,
                    new Guiduuid0M
                    {
                        Id = 1770719850,
                        Value = Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 333349314,
                            Value = Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1804345238,
                    new Guiduuid0M
                    {
                        Id = 1804345238,
                        Value = Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2103818091,
                    new Guiduuid0M
                    {
                        Id = 2103818091,
                        Value = Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1004462342,
                            Value = Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52"),
                            NullableValue = Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid)default));
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

                var expected = new Dictionary<System.Int32,Guiduuid0M>(30);

                expected.Add(
                    40553378,
                    new Guiduuid0M
                    {
                        Id = 40553378,
                        Value = Guid.Parse("cefd1762-14e3-4016-9e66-ecb5af339b38"),
                        NullableValue = Guid.Parse("2b226ea9-382d-4f56-a536-aa7d9d91edb3"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    52596164,
                    new Guiduuid0M
                    {
                        Id = 52596164,
                        Value = Guid.Parse("6da3027d-d53d-4640-a36c-dc769e84f1cf"),
                        NullableValue = Guid.Parse("5e90be75-1707-4cfd-825c-8ccac6072958"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1999892513,
                            Value = Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481"),
                            NullableValue = Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")
                        }

                    }
                );

                expected.Add(
                    111581562,
                    new Guiduuid0M
                    {
                        Id = 111581562,
                        Value = Guid.Parse("eecf6578-2901-4728-8401-a643ff4a1223"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 662901024,
                            Value = Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b"),
                            NullableValue = Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")
                        }

                    }
                );

                expected.Add(
                    174298103,
                    new Guiduuid0M
                    {
                        Id = 174298103,
                        Value = Guid.Parse("dbc893b7-af62-445b-ad44-c3c5165ba683"),
                        NullableValue = Guid.Parse("f50065d4-84c3-44d1-80fd-6ac5865f7c79"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1067045906,
                            Value = Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    264481987,
                    new Guiduuid0M
                    {
                        Id = 264481987,
                        Value = Guid.Parse("d67cae38-7630-4fc9-aab3-b746b00bcbef"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    266065193,
                    new Guiduuid0M
                    {
                        Id = 266065193,
                        Value = Guid.Parse("9b240240-f62b-481b-a07d-ef29bc10027b"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    305149200,
                    new Guiduuid0M
                    {
                        Id = 305149200,
                        Value = Guid.Parse("64403fc6-546d-46db-a252-c1020726acef"),
                        NullableValue = Guid.Parse("27b735b8-ce8d-4f7e-afcf-0ceab736cb1a"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1286787104,
                            Value = Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee"),
                            NullableValue = Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")
                        }

                    }
                );

                expected.Add(
                    324930262,
                    new Guiduuid0M
                    {
                        Id = 324930262,
                        Value = Guid.Parse("e5346cc4-a7cf-4446-a2b3-984f59e7c687"),
                        NullableValue = Guid.Parse("53f948ef-b3ed-407e-87ee-ac34517d3949"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 405175442,
                            Value = Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd"),
                            NullableValue = Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")
                        }

                    }
                );

                expected.Add(
                    361524382,
                    new Guiduuid0M
                    {
                        Id = 361524382,
                        Value = Guid.Parse("d29467da-ae1b-4350-a823-04827d07372b"),
                        NullableValue = Guid.Parse("b57ed5ab-a7b3-4f44-8d87-d542c97af6f6"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    402196323,
                    new Guiduuid0M
                    {
                        Id = 402196323,
                        Value = Guid.Parse("ebeec430-636f-4741-bcff-4fa939859ed3"),
                        NullableValue = Guid.Parse("e714663b-feab-47e8-941e-23bb5ee27280"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    692292510,
                    new Guiduuid0M
                    {
                        Id = 692292510,
                        Value = Guid.Parse("9980af1d-5efe-49a2-be5b-c710ec9cb5f2"),
                        NullableValue = Guid.Parse("278ca47d-e863-4be1-8f7b-123381344e3d"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    795284594,
                    new Guiduuid0M
                    {
                        Id = 795284594,
                        Value = Guid.Parse("49a9ca13-407d-4744-8d05-5010dd94cae2"),
                        NullableValue = Guid.Parse("8f8d2d86-8914-478d-a803-94ae448b5894"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    797073791,
                    new Guiduuid0M
                    {
                        Id = 797073791,
                        Value = Guid.Parse("8287494a-7d30-47f7-b3b1-b6e13a762795"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1136518499,
                            Value = Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2"),
                            NullableValue = Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")
                        }

                    }
                );

                expected.Add(
                    817526809,
                    new Guiduuid0M
                    {
                        Id = 817526809,
                        Value = Guid.Parse("0b14a854-cc11-497c-8ec7-943e5e327d3c"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    867462402,
                    new Guiduuid0M
                    {
                        Id = 867462402,
                        Value = Guid.Parse("d0abf3bc-fb14-4675-98db-a79b8ffa9170"),
                        NullableValue = Guid.Parse("5b0836c7-69eb-4255-beba-ee8a337f8668"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 129904778,
                            Value = Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543"),
                            NullableValue = Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")
                        }

                    }
                );

                expected.Add(
                    887739705,
                    new Guiduuid0M
                    {
                        Id = 887739705,
                        Value = Guid.Parse("1a5f662d-15e0-4052-b92a-2d34923ae2d0"),
                        NullableValue = Guid.Parse("2db415e9-2651-4581-a43d-5d3eb7fbcaaf"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1001526135,
                    new Guiduuid0M
                    {
                        Id = 1001526135,
                        Value = Guid.Parse("3bb6ea78-88ce-4528-8636-5725ebfa782e"),
                        NullableValue = Guid.Parse("af497060-e4d7-43a7-a93e-42a0ae73093d"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 846028277,
                            Value = Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1020155809,
                    new Guiduuid0M
                    {
                        Id = 1020155809,
                        Value = Guid.Parse("604aa5ec-f58e-4b21-a135-0e00465f239a"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 929173163,
                            Value = Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697"),
                            NullableValue = Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")
                        }

                    }
                );

                expected.Add(
                    1204207357,
                    new Guiduuid0M
                    {
                        Id = 1204207357,
                        Value = Guid.Parse("87949d63-48ef-4225-bcc6-af1bfe49bd3f"),
                        NullableValue = Guid.Parse("5fea8e00-62da-4336-bd15-02e23fee5cb0"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1252963844,
                    new Guiduuid0M
                    {
                        Id = 1252963844,
                        Value = Guid.Parse("3c623652-4404-412c-8b7d-2247b73ec3f7"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1266871280,
                    new Guiduuid0M
                    {
                        Id = 1266871280,
                        Value = Guid.Parse("64db805b-1e89-48c5-aec5-75ce07fa6b0e"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 2082755993,
                            Value = Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc"),
                            NullableValue = Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")
                        }

                    }
                );

                expected.Add(
                    1377150186,
                    new Guiduuid0M
                    {
                        Id = 1377150186,
                        Value = Guid.Parse("3c40c223-99db-4faf-911e-53701ae4bc2f"),
                        NullableValue = Guid.Parse("b24b6fa2-96f6-4602-b8d1-7951397bd61a"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 964128946,
                            Value = Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401"),
                            NullableValue = Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")
                        }

                    }
                );

                expected.Add(
                    1388117398,
                    new Guiduuid0M
                    {
                        Id = 1388117398,
                        Value = Guid.Parse("3ec7e1d5-d45e-49cf-8949-3e5766775738"),
                        NullableValue = Guid.Parse("156e03c9-1f38-4a99-9521-a2332722005d"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1428405456,
                    new Guiduuid0M
                    {
                        Id = 1428405456,
                        Value = Guid.Parse("00690a23-0297-466c-9c4a-5a5bee862a68"),
                        NullableValue = Guid.Parse("ca9f26a4-ca60-4d38-a67b-c0b0a4fa4d5f"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1573076059,
                    new Guiduuid0M
                    {
                        Id = 1573076059,
                        Value = Guid.Parse("ece6875b-68a9-4598-944c-56734f001b02"),
                        NullableValue = Guid.Parse("51d87b71-c670-44ac-96c5-993d0bd490ad"),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1612498498,
                    new Guiduuid0M
                    {
                        Id = 1612498498,
                        Value = Guid.Parse("be053612-6ebe-4c2b-baeb-d911b4038929"),
                        NullableValue = Guid.Parse("42396dc1-2549-4a79-9821-6e0679463c7d"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1220524810,
                            Value = Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5"),
                            NullableValue = Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")
                        }

                    }
                );

                expected.Add(
                    1735275542,
                    new Guiduuid0M
                    {
                        Id = 1735275542,
                        Value = Guid.Parse("25de76e2-1e42-4b37-b811-585ea630e562"),
                        NullableValue = Guid.Parse("255667ea-ad75-42f7-8755-2003abb5852e"),

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1669515366,
                            Value = Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551"),
                            NullableValue = Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")
                        }

                    }
                );

                expected.Add(
                    1770719850,
                    new Guiduuid0M
                    {
                        Id = 1770719850,
                        Value = Guid.Parse("ac30e737-ef7f-4958-a2a4-9723ba0f0d66"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 333349314,
                            Value = Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25"),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1804345238,
                    new Guiduuid0M
                    {
                        Id = 1804345238,
                        Value = Guid.Parse("87c2fe33-c640-4f7a-aea8-c03029d10275"),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2103818091,
                    new Guiduuid0M
                    {
                        Id = 2103818091,
                        Value = Guid.Parse("b7cfa995-f82f-4630-86c6-211fa536c066"),
                        NullableValue = null,

                        ModelInner = new Guiduuid0MI
                        {
                            Id = 1004462342,
                            Value = Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52"),
                            NullableValue = Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuid0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Guiduuid0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
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

                var expected = new Dictionary<System.Int32,Guiduuid0MI>(15);

                expected.Add(
                    129904778,
                    new Guiduuid0MI
                    {
                        Id = 129904778,
                        Value = Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543"),
                        NullableValue = Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")
                    }
                );

                expected.Add(
                    333349314,
                    new Guiduuid0MI
                    {
                        Id = 333349314,
                        Value = Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    405175442,
                    new Guiduuid0MI
                    {
                        Id = 405175442,
                        Value = Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd"),
                        NullableValue = Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")
                    }
                );

                expected.Add(
                    662901024,
                    new Guiduuid0MI
                    {
                        Id = 662901024,
                        Value = Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b"),
                        NullableValue = Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")
                    }
                );

                expected.Add(
                    846028277,
                    new Guiduuid0MI
                    {
                        Id = 846028277,
                        Value = Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    929173163,
                    new Guiduuid0MI
                    {
                        Id = 929173163,
                        Value = Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697"),
                        NullableValue = Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")
                    }
                );

                expected.Add(
                    964128946,
                    new Guiduuid0MI
                    {
                        Id = 964128946,
                        Value = Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401"),
                        NullableValue = Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")
                    }
                );

                expected.Add(
                    1004462342,
                    new Guiduuid0MI
                    {
                        Id = 1004462342,
                        Value = Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52"),
                        NullableValue = Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")
                    }
                );

                expected.Add(
                    1067045906,
                    new Guiduuid0MI
                    {
                        Id = 1067045906,
                        Value = Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1136518499,
                    new Guiduuid0MI
                    {
                        Id = 1136518499,
                        Value = Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2"),
                        NullableValue = Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")
                    }
                );

                expected.Add(
                    1220524810,
                    new Guiduuid0MI
                    {
                        Id = 1220524810,
                        Value = Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5"),
                        NullableValue = Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")
                    }
                );

                expected.Add(
                    1286787104,
                    new Guiduuid0MI
                    {
                        Id = 1286787104,
                        Value = Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee"),
                        NullableValue = Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")
                    }
                );

                expected.Add(
                    1669515366,
                    new Guiduuid0MI
                    {
                        Id = 1669515366,
                        Value = Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551"),
                        NullableValue = Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")
                    }
                );

                expected.Add(
                    1999892513,
                    new Guiduuid0MI
                    {
                        Id = 1999892513,
                        Value = Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481"),
                        NullableValue = Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")
                    }
                );

                expected.Add(
                    2082755993,
                    new Guiduuid0MI
                    {
                        Id = 2082755993,
                        Value = Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc"),
                        NullableValue = Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")
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

                var expected = new Dictionary<System.Int32,Guiduuid0MI>(15);

                expected.Add(
                    129904778,
                    new Guiduuid0MI
                    {
                        Id = 129904778,
                        Value = Guid.Parse("a1a0b998-1492-47f9-bb33-fe615570f543"),
                        NullableValue = Guid.Parse("63421a63-ba62-41f6-90f9-c60888ac7b77")
                    }
                );

                expected.Add(
                    333349314,
                    new Guiduuid0MI
                    {
                        Id = 333349314,
                        Value = Guid.Parse("be333153-e91e-4c33-8991-f2d64e42df25"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    405175442,
                    new Guiduuid0MI
                    {
                        Id = 405175442,
                        Value = Guid.Parse("5eaddc76-b039-46c9-af3a-7c38edd194cd"),
                        NullableValue = Guid.Parse("a9bac01d-f536-4816-8297-b968a6ad0fc1")
                    }
                );

                expected.Add(
                    662901024,
                    new Guiduuid0MI
                    {
                        Id = 662901024,
                        Value = Guid.Parse("19276ca7-1692-4507-94f6-ff28a342632b"),
                        NullableValue = Guid.Parse("a2bf16fd-361d-47e9-9cfd-6adffe91438c")
                    }
                );

                expected.Add(
                    846028277,
                    new Guiduuid0MI
                    {
                        Id = 846028277,
                        Value = Guid.Parse("0d1ef85b-6f7f-4575-b3a9-1e9926307b57"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    929173163,
                    new Guiduuid0MI
                    {
                        Id = 929173163,
                        Value = Guid.Parse("a2d20cf2-0ec4-46e8-9a69-570912fbf697"),
                        NullableValue = Guid.Parse("be02f6c4-71ea-4d9f-865e-09b674ede6dd")
                    }
                );

                expected.Add(
                    964128946,
                    new Guiduuid0MI
                    {
                        Id = 964128946,
                        Value = Guid.Parse("c711913a-e57f-43fe-84f0-b19568cea401"),
                        NullableValue = Guid.Parse("7ba62170-961e-458a-a1f9-d464268775fb")
                    }
                );

                expected.Add(
                    1004462342,
                    new Guiduuid0MI
                    {
                        Id = 1004462342,
                        Value = Guid.Parse("1d76df17-f7da-49de-9442-9b4b5ed3ba52"),
                        NullableValue = Guid.Parse("b06f574d-83ec-482f-a149-4f1bad0c447c")
                    }
                );

                expected.Add(
                    1067045906,
                    new Guiduuid0MI
                    {
                        Id = 1067045906,
                        Value = Guid.Parse("35532719-f5bf-4a93-9106-20c711b49649"),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1136518499,
                    new Guiduuid0MI
                    {
                        Id = 1136518499,
                        Value = Guid.Parse("16175ba5-7556-4f86-b235-40be2086aea2"),
                        NullableValue = Guid.Parse("f6e894ee-9051-41ac-bb32-0230731c39ef")
                    }
                );

                expected.Add(
                    1220524810,
                    new Guiduuid0MI
                    {
                        Id = 1220524810,
                        Value = Guid.Parse("3984d8f3-b5d5-4961-acd9-a9c5deec7da5"),
                        NullableValue = Guid.Parse("7805a062-7558-47bb-bcc9-c847fdd389c9")
                    }
                );

                expected.Add(
                    1286787104,
                    new Guiduuid0MI
                    {
                        Id = 1286787104,
                        Value = Guid.Parse("f5392bcd-f5f4-477a-94a3-4ac2191ac4ee"),
                        NullableValue = Guid.Parse("4e778f4f-7dfa-45ea-a4c2-91e7f22eb85b")
                    }
                );

                expected.Add(
                    1669515366,
                    new Guiduuid0MI
                    {
                        Id = 1669515366,
                        Value = Guid.Parse("6e8c7293-e1b8-46b6-b691-551b8f2bb551"),
                        NullableValue = Guid.Parse("caee80de-8b55-4624-a5cd-64b196047886")
                    }
                );

                expected.Add(
                    1999892513,
                    new Guiduuid0MI
                    {
                        Id = 1999892513,
                        Value = Guid.Parse("65a1666d-42e7-43fd-b7f0-696225a09481"),
                        NullableValue = Guid.Parse("bf97e8b0-7b02-49a6-b509-997be4e88e61")
                    }
                );

                expected.Add(
                    2082755993,
                    new Guiduuid0MI
                    {
                        Id = 2082755993,
                        Value = Guid.Parse("36c96698-1c3a-4253-aae3-459e0fb976dc"),
                        NullableValue = Guid.Parse("3388c9a3-f32a-4bf4-9c5c-306f0c3f60b2")
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


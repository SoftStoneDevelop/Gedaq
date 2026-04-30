

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


#region TestData

        private readonly Guiduuid0M[] _testData = new Guiduuid0M[]
        {
            new Guiduuid0M
{
    Id = 7,
    Value = Guid.Parse("6007e02c-8aa7-4e8b-9aa7-d14fcbd37abc"),
    ModelInner = null,
    NullableValue = Guid.Parse("16a08d52-deae-4362-b0ae-4d24e541f03a"),
},
            new Guiduuid0M
{
    Id = 8,
    Value = Guid.Parse("c9e2c00b-6a5a-44a8-9a02-1378c002fbc6"),
    ModelInner = new Guiduuid0MI
{
    Id = 6,
    Value = Guid.Parse("6380ea45-abf0-40fc-a9d5-cf404dac9fb2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 14,
    Value = Guid.Parse("8b66ce34-f245-4afe-a6f3-039eaab4c444"),
    ModelInner = null,
    NullableValue = Guid.Parse("1755a3b1-e017-477a-a0a9-80fa202f9361"),
},
            new Guiduuid0M
{
    Id = 22,
    Value = Guid.Parse("9132b283-ec0b-4050-a13e-33f7f0b8f779"),
    ModelInner = new Guiduuid0MI
{
    Id = 10,
    Value = Guid.Parse("c3cecf55-157a-4bc5-a9bd-857e2b57c983"),
    NullableValue = Guid.Parse("d18906cd-38c8-418f-920f-d48aa15ed9b1"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 27,
    Value = Guid.Parse("9d66e399-ac49-4016-8f93-fd41ec2866fb"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 30,
    Value = Guid.Parse("53470c70-72dd-4a4f-aa7d-a758f9462e1b"),
    ModelInner = new Guiduuid0MI
{
    Id = 14,
    Value = Guid.Parse("b7c496fa-96af-4dd0-bc31-0f9321e5eeab"),
    NullableValue = Guid.Parse("9eb18f96-9946-4ca9-8773-4b9b0c2badfc"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 35,
    Value = Guid.Parse("b416cf24-fe38-4408-a229-4ecca34bdec1"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 37,
    Value = Guid.Parse("f8a53dd0-e735-4fbd-bda5-f20f8cfc79a7"),
    ModelInner = new Guiduuid0MI
{
    Id = 19,
    Value = Guid.Parse("63117235-0429-47cf-871e-4e9d9f6b916d"),
    NullableValue = Guid.Parse("f1ee687e-7751-4319-90c8-331a14c5aae1"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 43,
    Value = Guid.Parse("b1171c4d-3af7-4aaa-a8fa-8a80cb10938b"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 51,
    Value = Guid.Parse("d1212f70-ca62-4a35-820c-ba11f3b0f38f"),
    ModelInner = new Guiduuid0MI
{
    Id = 27,
    Value = Guid.Parse("3d362d52-e1aa-4cb7-93a8-79d515e7354d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 53,
    Value = Guid.Parse("a514295e-b3a7-40f1-ac5a-cc1b3775292c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 58,
    Value = Guid.Parse("6254dada-ffe1-4fe3-bcbb-0e0a6c5a6a72"),
    ModelInner = new Guiduuid0MI
{
    Id = 34,
    Value = Guid.Parse("afd9f683-7f15-4a88-8ae1-fe49ab244dbe"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 61,
    Value = Guid.Parse("8345a384-5862-428e-a4dc-c2bbfd6cb012"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 64,
    Value = Guid.Parse("05c1a333-03b4-4cbc-a266-959917388309"),
    ModelInner = new Guiduuid0MI
{
    Id = 40,
    Value = Guid.Parse("572d54d4-1efc-40ba-b494-b50566b70179"),
    NullableValue = Guid.Parse("04c532aa-46d4-4ec2-9e3f-506a1eb1d082"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 73,
    Value = Guid.Parse("80f20f9a-e15d-414f-8248-6cc4645de0f4"),
    ModelInner = null,
    NullableValue = Guid.Parse("37eb16aa-9141-48d6-9a38-60bb97c0ea89"),
},
            new Guiduuid0M
{
    Id = 76,
    Value = Guid.Parse("521e2921-89a6-44e3-9a3f-af950052ce00"),
    ModelInner = new Guiduuid0MI
{
    Id = 45,
    Value = Guid.Parse("9730c6af-893f-4a0e-9307-3b4aca163027"),
    NullableValue = Guid.Parse("96e63fc3-f41b-4120-8e42-da20fae628d5"),
},
    NullableValue = Guid.Parse("a59867aa-02ca-4e8a-b8e8-0343d079302c"),
},
            new Guiduuid0M
{
    Id = 79,
    Value = Guid.Parse("ccbd15db-2755-4955-9feb-4ae9088eeadc"),
    ModelInner = null,
    NullableValue = Guid.Parse("0fca0af7-68b3-4752-a0e8-89037f382655"),
},
            new Guiduuid0M
{
    Id = 87,
    Value = Guid.Parse("89308d42-fa35-428d-a73d-c543aad81cac"),
    ModelInner = new Guiduuid0MI
{
    Id = 54,
    Value = Guid.Parse("71ee4a36-d25f-44f5-886d-fc7b56e7c52c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d615e624-14c5-47cc-9e7f-7facd6052a52"),
},
            new Guiduuid0M
{
    Id = 88,
    Value = Guid.Parse("52f54ff7-0908-42e9-8b50-c8e46b3f6ee6"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 91,
    Value = Guid.Parse("057c8828-714e-4ee1-a3f8-6cc59ed1c27c"),
    ModelInner = new Guiduuid0MI
{
    Id = 57,
    Value = Guid.Parse("6a4eb1a2-48e3-47ce-ae52-41c6ac5798a4"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("48697911-de45-4e8b-83ef-24990f4cb154"),
},
            new Guiduuid0M
{
    Id = 93,
    Value = Guid.Parse("844b03b7-a6db-4ccb-87a4-f5c67149ee85"),
    ModelInner = null,
    NullableValue = Guid.Parse("b7bd2e23-0507-431c-a293-1d737c686c95"),
},
            new Guiduuid0M
{
    Id = 101,
    Value = Guid.Parse("a73b15a0-3fee-4ab8-8140-db2d8b258cb9"),
    ModelInner = new Guiduuid0MI
{
    Id = 66,
    Value = Guid.Parse("13975ade-4e75-4ae1-a1de-7bd9ae059760"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 105,
    Value = Guid.Parse("e177fd3b-bfbf-4bf9-b370-2eae0f0b3f0b"),
    ModelInner = null,
    NullableValue = Guid.Parse("c47e5204-392e-4c0e-9cc9-89208ccb3b5f"),
},
            new Guiduuid0M
{
    Id = 108,
    Value = Guid.Parse("2df2ce86-e3e1-4da9-b7af-6f593ca02da8"),
    ModelInner = new Guiduuid0MI
{
    Id = 75,
    Value = Guid.Parse("d2e1f98c-064f-4a3e-95d3-96417b699cb9"),
    NullableValue = Guid.Parse("84add18e-01ad-42d9-8080-14bc807d33c5"),
},
    NullableValue = Guid.Parse("787bd064-474e-433d-ab38-98b567a89e3a"),
},
            new Guiduuid0M
{
    Id = 110,
    Value = Guid.Parse("937f8d43-0d27-449a-96fd-287ce20d2c25"),
    ModelInner = null,
    NullableValue = Guid.Parse("a85f7e33-5230-4b74-bfe9-c52e5c3f3042"),
},
            new Guiduuid0M
{
    Id = 117,
    Value = Guid.Parse("7ff07fe6-7bfb-4507-9a58-cc2d6c147d17"),
    ModelInner = new Guiduuid0MI
{
    Id = 76,
    Value = Guid.Parse("fda56517-81f1-4518-94b7-1ec6cae29607"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 121,
    Value = Guid.Parse("b1313807-6eff-47d5-ac21-7fd5932d66f6"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 128,
    Value = Guid.Parse("4c8f09a7-5de8-4850-9166-d81409f413ea"),
    ModelInner = new Guiduuid0MI
{
    Id = 84,
    Value = Guid.Parse("1b39296d-f38f-4cde-8b7c-85b3a851398a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b128a2ef-2cb3-4c37-8b26-e6a84657bf45"),
},
            new Guiduuid0M
{
    Id = 135,
    Value = Guid.Parse("cde98b5f-0455-4682-87ea-4ebb08685adf"),
    ModelInner = null,
    NullableValue = Guid.Parse("ac282c3b-6e43-4949-acde-abad5b2f0d5d"),
},
            new Guiduuid0M
{
    Id = 137,
    Value = Guid.Parse("2948b7e8-5206-41ab-af0d-98910ead8e6b"),
    ModelInner = new Guiduuid0MI
{
    Id = 91,
    Value = Guid.Parse("c9c10853-6f73-401a-b504-b4a18deda3cf"),
    NullableValue = Guid.Parse("d867d775-7911-4b07-9b3c-97133eb20cec"),
},
    NullableValue = null,
},
        };

#endregion

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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27))]
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
            queryMapTypes: [typeof(Guiduuid0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27))]
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

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IGuidSingleTypeuuid)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidSingleTypeuuid)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IGuidSingleTypeuuid)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidSingleTypeuuid)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(9)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(9), 
                nullable: true)]
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

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuid0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
                changedRows =  ((IGuidSingleTypeuuid)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidSingleTypeuuid)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
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
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
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
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuid0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guiduuid0M> models = null;

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guiduuid0M> models = null;

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[19], true);
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
            queryMapTypes: null,
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
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduuid0mi_id", 
                methodParametrName: "guiduuid0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
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

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

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
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidSingleTypeuuid)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidSingleTypeuuid)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

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
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidSingleTypeuuid)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[29], false);
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
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Guiduuid0M.AssertModel(models[0],_testData[28], false);
                        Guiduuid0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Guiduuid0M.AssertModel(models[0],_testData[10], false);
                        Guiduuid0M.AssertModel(models[1],_testData[11], false);
                        Guiduuid0M.AssertModel(models[2],_testData[12], false);
                        Guiduuid0M.AssertModel(models[3],_testData[13], false);
                        Guiduuid0M.AssertModel(models[4],_testData[14], false);
                        Guiduuid0M.AssertModel(models[5],_testData[15], false);
                        Guiduuid0M.AssertModel(models[6],_testData[16], false);
                        Guiduuid0M.AssertModel(models[7],_testData[17], false);
                        Guiduuid0M.AssertModel(models[8],_testData[18], false);
                        Guiduuid0M.AssertModel(models[9],_testData[19], false);
                        Guiduuid0M.AssertModel(models[10],_testData[20], false);
                        Guiduuid0M.AssertModel(models[11],_testData[21], false);
                        Guiduuid0M.AssertModel(models[12],_testData[22], false);
                        Guiduuid0M.AssertModel(models[13],_testData[23], false);
                        Guiduuid0M.AssertModel(models[14],_testData[24], false);
                        Guiduuid0M.AssertModel(models[15],_testData[25], false);
                        Guiduuid0M.AssertModel(models[16],_testData[26], false);
                        Guiduuid0M.AssertModel(models[17],_testData[27], false);
                        Guiduuid0M.AssertModel(models[18],_testData[28], false);
                        Guiduuid0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Guiduuid0M.AssertModel(models[0],_testData[20], false);
                        Guiduuid0M.AssertModel(models[1],_testData[21], false);
                        Guiduuid0M.AssertModel(models[2],_testData[22], false);
                        Guiduuid0M.AssertModel(models[3],_testData[23], false);
                        Guiduuid0M.AssertModel(models[4],_testData[24], false);
                        Guiduuid0M.AssertModel(models[5],_testData[25], false);
                        Guiduuid0M.AssertModel(models[6],_testData[26], false);
                        Guiduuid0M.AssertModel(models[7],_testData[27], false);
                        Guiduuid0M.AssertModel(models[8],_testData[28], false);
                        Guiduuid0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Guiduuid0M.AssertModel(models[0],_testData[9], false);
                        Guiduuid0M.AssertModel(models[1],_testData[10], false);
                        Guiduuid0M.AssertModel(models[2],_testData[11], false);
                        Guiduuid0M.AssertModel(models[3],_testData[12], false);
                        Guiduuid0M.AssertModel(models[4],_testData[13], false);
                        Guiduuid0M.AssertModel(models[5],_testData[14], false);
                        Guiduuid0M.AssertModel(models[6],_testData[15], false);
                        Guiduuid0M.AssertModel(models[7],_testData[16], false);
                        Guiduuid0M.AssertModel(models[8],_testData[17], false);
                        Guiduuid0M.AssertModel(models[9],_testData[18], false);
                        Guiduuid0M.AssertModel(models[10],_testData[19], false);
                        Guiduuid0M.AssertModel(models[11],_testData[20], false);
                        Guiduuid0M.AssertModel(models[12],_testData[21], false);
                        Guiduuid0M.AssertModel(models[13],_testData[22], false);
                        Guiduuid0M.AssertModel(models[14],_testData[23], false);
                        Guiduuid0M.AssertModel(models[15],_testData[24], false);
                        Guiduuid0M.AssertModel(models[16],_testData[25], false);
                        Guiduuid0M.AssertModel(models[17],_testData[26], false);
                        Guiduuid0M.AssertModel(models[18],_testData[27], false);
                        Guiduuid0M.AssertModel(models[19],_testData[28], false);
                        Guiduuid0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 88, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 58, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 93, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 101, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[29], false);
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
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IGuidSingleTypeuuid)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 93, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Guiduuid0M.AssertModel(models[0],_testData[21], false);
                        Guiduuid0M.AssertModel(models[1],_testData[22], false);
                        Guiduuid0M.AssertModel(models[2],_testData[23], false);
                        Guiduuid0M.AssertModel(models[3],_testData[24], false);
                        Guiduuid0M.AssertModel(models[4],_testData[25], false);
                        Guiduuid0M.AssertModel(models[5],_testData[26], false);
                        Guiduuid0M.AssertModel(models[6],_testData[27], false);
                        Guiduuid0M.AssertModel(models[7],_testData[28], false);
                        Guiduuid0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Guiduuid0M.AssertModel(models[0],_testData[3], false);
                        Guiduuid0M.AssertModel(models[1],_testData[4], false);
                        Guiduuid0M.AssertModel(models[2],_testData[5], false);
                        Guiduuid0M.AssertModel(models[3],_testData[6], false);
                        Guiduuid0M.AssertModel(models[4],_testData[7], false);
                        Guiduuid0M.AssertModel(models[5],_testData[8], false);
                        Guiduuid0M.AssertModel(models[6],_testData[9], false);
                        Guiduuid0M.AssertModel(models[7],_testData[10], false);
                        Guiduuid0M.AssertModel(models[8],_testData[11], false);
                        Guiduuid0M.AssertModel(models[9],_testData[12], false);
                        Guiduuid0M.AssertModel(models[10],_testData[13], false);
                        Guiduuid0M.AssertModel(models[11],_testData[14], false);
                        Guiduuid0M.AssertModel(models[12],_testData[15], false);
                        Guiduuid0M.AssertModel(models[13],_testData[16], false);
                        Guiduuid0M.AssertModel(models[14],_testData[17], false);
                        Guiduuid0M.AssertModel(models[15],_testData[18], false);
                        Guiduuid0M.AssertModel(models[16],_testData[19], false);
                        Guiduuid0M.AssertModel(models[17],_testData[20], false);
                        Guiduuid0M.AssertModel(models[18],_testData[21], false);
                        Guiduuid0M.AssertModel(models[19],_testData[22], false);
                        Guiduuid0M.AssertModel(models[20],_testData[23], false);
                        Guiduuid0M.AssertModel(models[21],_testData[24], false);
                        Guiduuid0M.AssertModel(models[22],_testData[25], false);
                        Guiduuid0M.AssertModel(models[23],_testData[26], false);
                        Guiduuid0M.AssertModel(models[24],_testData[27], false);
                        Guiduuid0M.AssertModel(models[25],_testData[28], false);
                        Guiduuid0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidSingleTypeuuid)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 53, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Guiduuid0M.AssertModel(models[0],_testData[11], false);
                        Guiduuid0M.AssertModel(models[1],_testData[12], false);
                        Guiduuid0M.AssertModel(models[2],_testData[13], false);
                        Guiduuid0M.AssertModel(models[3],_testData[14], false);
                        Guiduuid0M.AssertModel(models[4],_testData[15], false);
                        Guiduuid0M.AssertModel(models[5],_testData[16], false);
                        Guiduuid0M.AssertModel(models[6],_testData[17], false);
                        Guiduuid0M.AssertModel(models[7],_testData[18], false);
                        Guiduuid0M.AssertModel(models[8],_testData[19], false);
                        Guiduuid0M.AssertModel(models[9],_testData[20], false);
                        Guiduuid0M.AssertModel(models[10],_testData[21], false);
                        Guiduuid0M.AssertModel(models[11],_testData[22], false);
                        Guiduuid0M.AssertModel(models[12],_testData[23], false);
                        Guiduuid0M.AssertModel(models[13],_testData[24], false);
                        Guiduuid0M.AssertModel(models[14],_testData[25], false);
                        Guiduuid0M.AssertModel(models[15],_testData[26], false);
                        Guiduuid0M.AssertModel(models[16],_testData[27], false);
                        Guiduuid0M.AssertModel(models[17],_testData[28], false);
                        Guiduuid0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Guiduuid0M.AssertModel(models[0],_testData[4], false);
                        Guiduuid0M.AssertModel(models[1],_testData[5], false);
                        Guiduuid0M.AssertModel(models[2],_testData[6], false);
                        Guiduuid0M.AssertModel(models[3],_testData[7], false);
                        Guiduuid0M.AssertModel(models[4],_testData[8], false);
                        Guiduuid0M.AssertModel(models[5],_testData[9], false);
                        Guiduuid0M.AssertModel(models[6],_testData[10], false);
                        Guiduuid0M.AssertModel(models[7],_testData[11], false);
                        Guiduuid0M.AssertModel(models[8],_testData[12], false);
                        Guiduuid0M.AssertModel(models[9],_testData[13], false);
                        Guiduuid0M.AssertModel(models[10],_testData[14], false);
                        Guiduuid0M.AssertModel(models[11],_testData[15], false);
                        Guiduuid0M.AssertModel(models[12],_testData[16], false);
                        Guiduuid0M.AssertModel(models[13],_testData[17], false);
                        Guiduuid0M.AssertModel(models[14],_testData[18], false);
                        Guiduuid0M.AssertModel(models[15],_testData[19], false);
                        Guiduuid0M.AssertModel(models[16],_testData[20], false);
                        Guiduuid0M.AssertModel(models[17],_testData[21], false);
                        Guiduuid0M.AssertModel(models[18],_testData[22], false);
                        Guiduuid0M.AssertModel(models[19],_testData[23], false);
                        Guiduuid0M.AssertModel(models[20],_testData[24], false);
                        Guiduuid0M.AssertModel(models[21],_testData[25], false);
                        Guiduuid0M.AssertModel(models[22],_testData[26], false);
                        Guiduuid0M.AssertModel(models[23],_testData[27], false);
                        Guiduuid0M.AssertModel(models[24],_testData[28], false);
                        Guiduuid0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Guiduuid0M.AssertModel(models[0],_testData[18], false);Guiduuid0M.AssertModel(models[1],_testData[19], false);Guiduuid0M.AssertModel(models[2],_testData[20], false);Guiduuid0M.AssertModel(models[3],_testData[21], false);Guiduuid0M.AssertModel(models[4],_testData[22], false);Guiduuid0M.AssertModel(models[5],_testData[23], false);Guiduuid0M.AssertModel(models[6],_testData[24], false);Guiduuid0M.AssertModel(models[7],_testData[25], false);Guiduuid0M.AssertModel(models[8],_testData[26], false);Guiduuid0M.AssertModel(models[9],_testData[27], false);Guiduuid0M.AssertModel(models[10],_testData[28], false);Guiduuid0M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Guiduuid0M.AssertModel(models[0],_testData[21], false);Guiduuid0M.AssertModel(models[1],_testData[22], false);Guiduuid0M.AssertModel(models[2],_testData[23], false);Guiduuid0M.AssertModel(models[3],_testData[24], false);Guiduuid0M.AssertModel(models[4],_testData[25], false);Guiduuid0M.AssertModel(models[5],_testData[26], false);Guiduuid0M.AssertModel(models[6],_testData[27], false);Guiduuid0M.AssertModel(models[7],_testData[28], false);Guiduuid0M.AssertModel(models[8],_testData[29], false);
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
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6007e02c-8aa7-4e8b-9aa7-d14fcbd37abc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("16a08d52-deae-4362-b0ae-4d24e541f03a"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9e2c00b-6a5a-44a8-9a02-1378c002fbc6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6380ea45-abf0-40fc-a9d5-cf404dac9fb2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b66ce34-f245-4afe-a6f3-039eaab4c444"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1755a3b1-e017-477a-a0a9-80fa202f9361"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9132b283-ec0b-4050-a13e-33f7f0b8f779"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c3cecf55-157a-4bc5-a9bd-857e2b57c983"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d18906cd-38c8-418f-920f-d48aa15ed9b1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9d66e399-ac49-4016-8f93-fd41ec2866fb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("53470c70-72dd-4a4f-aa7d-a758f9462e1b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b7c496fa-96af-4dd0-bc31-0f9321e5eeab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9eb18f96-9946-4ca9-8773-4b9b0c2badfc"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b416cf24-fe38-4408-a229-4ecca34bdec1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8a53dd0-e735-4fbd-bda5-f20f8cfc79a7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("63117235-0429-47cf-871e-4e9d9f6b916d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f1ee687e-7751-4319-90c8-331a14c5aae1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b1171c4d-3af7-4aaa-a8fa-8a80cb10938b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d1212f70-ca62-4a35-820c-ba11f3b0f38f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3d362d52-e1aa-4cb7-93a8-79d515e7354d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a514295e-b3a7-40f1-ac5a-cc1b3775292c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6254dada-ffe1-4fe3-bcbb-0e0a6c5a6a72"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("afd9f683-7f15-4a88-8ae1-fe49ab244dbe"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8345a384-5862-428e-a4dc-c2bbfd6cb012"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("05c1a333-03b4-4cbc-a266-959917388309"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("572d54d4-1efc-40ba-b494-b50566b70179"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("04c532aa-46d4-4ec2-9e3f-506a1eb1d082"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80f20f9a-e15d-414f-8248-6cc4645de0f4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37eb16aa-9141-48d6-9a38-60bb97c0ea89"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("521e2921-89a6-44e3-9a3f-af950052ce00"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9730c6af-893f-4a0e-9307-3b4aca163027"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("96e63fc3-f41b-4120-8e42-da20fae628d5"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a59867aa-02ca-4e8a-b8e8-0343d079302c"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ccbd15db-2755-4955-9feb-4ae9088eeadc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0fca0af7-68b3-4752-a0e8-89037f382655"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("89308d42-fa35-428d-a73d-c543aad81cac"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("71ee4a36-d25f-44f5-886d-fc7b56e7c52c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d615e624-14c5-47cc-9e7f-7facd6052a52"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("52f54ff7-0908-42e9-8b50-c8e46b3f6ee6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("057c8828-714e-4ee1-a3f8-6cc59ed1c27c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6a4eb1a2-48e3-47ce-ae52-41c6ac5798a4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("48697911-de45-4e8b-83ef-24990f4cb154"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("844b03b7-a6db-4ccb-87a4-f5c67149ee85"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b7bd2e23-0507-431c-a293-1d737c686c95"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a73b15a0-3fee-4ab8-8140-db2d8b258cb9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("13975ade-4e75-4ae1-a1de-7bd9ae059760"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e177fd3b-bfbf-4bf9-b370-2eae0f0b3f0b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c47e5204-392e-4c0e-9cc9-89208ccb3b5f"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2df2ce86-e3e1-4da9-b7af-6f593ca02da8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d2e1f98c-064f-4a3e-95d3-96417b699cb9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("84add18e-01ad-42d9-8080-14bc807d33c5"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("787bd064-474e-433d-ab38-98b567a89e3a"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("937f8d43-0d27-449a-96fd-287ce20d2c25"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a85f7e33-5230-4b74-bfe9-c52e5c3f3042"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ff07fe6-7bfb-4507-9a58-cc2d6c147d17"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fda56517-81f1-4518-94b7-1ec6cae29607"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b1313807-6eff-47d5-ac21-7fd5932d66f6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c8f09a7-5de8-4850-9166-d81409f413ea"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1b39296d-f38f-4cde-8b7c-85b3a851398a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b128a2ef-2cb3-4c37-8b26-e6a84657bf45"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cde98b5f-0455-4682-87ea-4ebb08685adf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ac282c3b-6e43-4949-acde-abad5b2f0d5d"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2948b7e8-5206-41ab-af0d-98910ead8e6b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c9c10853-6f73-401a-b504-b4a18deda3cf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d867d775-7911-4b07-9b3c-97133eb20cec"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6007e02c-8aa7-4e8b-9aa7-d14fcbd37abc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("16a08d52-deae-4362-b0ae-4d24e541f03a"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9e2c00b-6a5a-44a8-9a02-1378c002fbc6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6380ea45-abf0-40fc-a9d5-cf404dac9fb2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b66ce34-f245-4afe-a6f3-039eaab4c444"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1755a3b1-e017-477a-a0a9-80fa202f9361"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9132b283-ec0b-4050-a13e-33f7f0b8f779"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c3cecf55-157a-4bc5-a9bd-857e2b57c983"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d18906cd-38c8-418f-920f-d48aa15ed9b1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9d66e399-ac49-4016-8f93-fd41ec2866fb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("53470c70-72dd-4a4f-aa7d-a758f9462e1b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b7c496fa-96af-4dd0-bc31-0f9321e5eeab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9eb18f96-9946-4ca9-8773-4b9b0c2badfc"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b416cf24-fe38-4408-a229-4ecca34bdec1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8a53dd0-e735-4fbd-bda5-f20f8cfc79a7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("63117235-0429-47cf-871e-4e9d9f6b916d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f1ee687e-7751-4319-90c8-331a14c5aae1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b1171c4d-3af7-4aaa-a8fa-8a80cb10938b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d1212f70-ca62-4a35-820c-ba11f3b0f38f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3d362d52-e1aa-4cb7-93a8-79d515e7354d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a514295e-b3a7-40f1-ac5a-cc1b3775292c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6254dada-ffe1-4fe3-bcbb-0e0a6c5a6a72"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("afd9f683-7f15-4a88-8ae1-fe49ab244dbe"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8345a384-5862-428e-a4dc-c2bbfd6cb012"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("05c1a333-03b4-4cbc-a266-959917388309"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("572d54d4-1efc-40ba-b494-b50566b70179"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("04c532aa-46d4-4ec2-9e3f-506a1eb1d082"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80f20f9a-e15d-414f-8248-6cc4645de0f4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37eb16aa-9141-48d6-9a38-60bb97c0ea89"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("521e2921-89a6-44e3-9a3f-af950052ce00"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9730c6af-893f-4a0e-9307-3b4aca163027"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("96e63fc3-f41b-4120-8e42-da20fae628d5"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a59867aa-02ca-4e8a-b8e8-0343d079302c"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ccbd15db-2755-4955-9feb-4ae9088eeadc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0fca0af7-68b3-4752-a0e8-89037f382655"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("89308d42-fa35-428d-a73d-c543aad81cac"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("71ee4a36-d25f-44f5-886d-fc7b56e7c52c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d615e624-14c5-47cc-9e7f-7facd6052a52"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("52f54ff7-0908-42e9-8b50-c8e46b3f6ee6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("057c8828-714e-4ee1-a3f8-6cc59ed1c27c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6a4eb1a2-48e3-47ce-ae52-41c6ac5798a4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("48697911-de45-4e8b-83ef-24990f4cb154"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("844b03b7-a6db-4ccb-87a4-f5c67149ee85"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b7bd2e23-0507-431c-a293-1d737c686c95"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a73b15a0-3fee-4ab8-8140-db2d8b258cb9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("13975ade-4e75-4ae1-a1de-7bd9ae059760"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e177fd3b-bfbf-4bf9-b370-2eae0f0b3f0b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c47e5204-392e-4c0e-9cc9-89208ccb3b5f"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2df2ce86-e3e1-4da9-b7af-6f593ca02da8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d2e1f98c-064f-4a3e-95d3-96417b699cb9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("84add18e-01ad-42d9-8080-14bc807d33c5"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("787bd064-474e-433d-ab38-98b567a89e3a"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("937f8d43-0d27-449a-96fd-287ce20d2c25"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a85f7e33-5230-4b74-bfe9-c52e5c3f3042"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ff07fe6-7bfb-4507-9a58-cc2d6c147d17"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fda56517-81f1-4518-94b7-1ec6cae29607"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b1313807-6eff-47d5-ac21-7fd5932d66f6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c8f09a7-5de8-4850-9166-d81409f413ea"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1b39296d-f38f-4cde-8b7c-85b3a851398a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b128a2ef-2cb3-4c37-8b26-e6a84657bf45"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cde98b5f-0455-4682-87ea-4ebb08685adf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ac282c3b-6e43-4949-acde-abad5b2f0d5d"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2948b7e8-5206-41ab-af0d-98910ead8e6b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c9c10853-6f73-401a-b504-b4a18deda3cf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d867d775-7911-4b07-9b3c-97133eb20cec"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Guiduuid0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuid0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuid0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
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
            queryMapTypes: [typeof(Guiduuid0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelInnerConfig()
        {
        }

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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidSingleTypeuuid)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Guiduuid0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidSingleTypeuuid)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IGuidSingleTypeuuid)this).ImportModel(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Guiduuid0M.AssertModel(models[0],_testData[0], false);
                Guiduuid0M.AssertModel(models[1],_testData[1], false);
                Guiduuid0M.AssertModel(models[2],_testData[2], false);
                Guiduuid0M.AssertModel(models[3],_testData[3], false);
                Guiduuid0M.AssertModel(models[4],_testData[4], false);
                Guiduuid0M.AssertModel(models[5],_testData[5], false);
                Guiduuid0M.AssertModel(models[6],_testData[6], false);
                Guiduuid0M.AssertModel(models[7],_testData[7], false);
                Guiduuid0M.AssertModel(models[8],_testData[8], false);
                Guiduuid0M.AssertModel(models[9],_testData[9], false);
                Guiduuid0M.AssertModel(models[10],_testData[10], false);
                Guiduuid0M.AssertModel(models[11],_testData[11], false);
                Guiduuid0M.AssertModel(models[12],_testData[12], false);
                Guiduuid0M.AssertModel(models[13],_testData[13], false);
                Guiduuid0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IGuidSingleTypeuuid)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidSingleTypeuuid)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Guiduuid0M.AssertModel(models[0],_testData[0], false);
                Guiduuid0M.AssertModel(models[1],_testData[1], false);
                Guiduuid0M.AssertModel(models[2],_testData[2], false);
                Guiduuid0M.AssertModel(models[3],_testData[3], false);
                Guiduuid0M.AssertModel(models[4],_testData[4], false);
                Guiduuid0M.AssertModel(models[5],_testData[5], false);
                Guiduuid0M.AssertModel(models[6],_testData[6], false);
                Guiduuid0M.AssertModel(models[7],_testData[7], false);
                Guiduuid0M.AssertModel(models[8],_testData[8], false);
                Guiduuid0M.AssertModel(models[9],_testData[9], false);
                Guiduuid0M.AssertModel(models[10],_testData[10], false);
                Guiduuid0M.AssertModel(models[11],_testData[11], false);
                Guiduuid0M.AssertModel(models[12],_testData[12], false);
                Guiduuid0M.AssertModel(models[13],_testData[13], false);
                Guiduuid0M.AssertModel(models[14],_testData[14], false);
                Guiduuid0M.AssertModel(models[15],_testData[15], false);
                Guiduuid0M.AssertModel(models[16],_testData[16], false);
                Guiduuid0M.AssertModel(models[17],_testData[17], false);
                Guiduuid0M.AssertModel(models[18],_testData[18], false);
                Guiduuid0M.AssertModel(models[19],_testData[19], false);
                Guiduuid0M.AssertModel(models[20],_testData[20], false);
                Guiduuid0M.AssertModel(models[21],_testData[21], false);
                Guiduuid0M.AssertModel(models[22],_testData[22], false);
                Guiduuid0M.AssertModel(models[23],_testData[23], false);
                Guiduuid0M.AssertModel(models[24],_testData[24], false);
                Guiduuid0M.AssertModel(models[25],_testData[25], false);
                Guiduuid0M.AssertModel(models[26],_testData[26], false);
                Guiduuid0M.AssertModel(models[27],_testData[27], false);
                Guiduuid0M.AssertModel(models[28],_testData[28], false);
                Guiduuid0M.AssertModel(models[29],_testData[29], false);
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
            queryMapTypes: [typeof(Guiduuid0M)],
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guiduuid0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guiduuid0M.AssertModel(model, expectedModel, true);
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
            queryMapTypes: [typeof(Guiduuid0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


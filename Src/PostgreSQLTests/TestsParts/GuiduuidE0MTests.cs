

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

        private readonly GuiduuidE0M[] _testData = new GuiduuidE0M[]
        {
            new GuiduuidE0M
{
    Id = 8,
    Value = Guid.Parse("7008fe27-ca8e-4f11-9b1d-bb78c5ab6421"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 9,
    Value = Guid.Parse("e610ca5c-293e-42f8-9f06-67de3fdf1def"),
    ModelInner = new GuiduuidE0MI
{
    Id = 9,
    Value = Guid.Parse("e8a0d3d8-54ee-4a9e-92d1-69b28722882b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 14,
    Value = Guid.Parse("9baf192e-5472-442c-8672-0ec4d0715d1f"),
    ModelInner = null,
    NullableValue = Guid.Parse("c09a52e0-e5a1-4bac-978a-fd52c0159734"),
},
            new GuiduuidE0M
{
    Id = 18,
    Value = Guid.Parse("bec4f937-a727-4cf7-b6eb-956455fe89b8"),
    ModelInner = new GuiduuidE0MI
{
    Id = 13,
    Value = Guid.Parse("fc95194c-20a0-45a3-8f25-076f87aae810"),
    NullableValue = Guid.Parse("77a4de56-7d0a-471c-843b-7cc0be132b81"),
},
    NullableValue = Guid.Parse("61cc007c-2117-44b5-9c1a-ea9b915bd4f6"),
},
            new GuiduuidE0M
{
    Id = 27,
    Value = Guid.Parse("e7fa7fc9-e6dc-4fb0-9b09-6d3931f30157"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 31,
    Value = Guid.Parse("9243add5-619b-445f-a06a-7c17fc3b0fbd"),
    ModelInner = new GuiduuidE0MI
{
    Id = 20,
    Value = Guid.Parse("d20c49a7-7ced-4b61-8993-1169548e92e0"),
    NullableValue = Guid.Parse("308829b7-4991-498b-aefd-70a6afb7dd99"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 33,
    Value = Guid.Parse("ceab2d88-2c73-4d73-8a78-2657b0f5d9ec"),
    ModelInner = null,
    NullableValue = Guid.Parse("6d960bcf-20be-46f1-86cd-06fdf21d13c8"),
},
            new GuiduuidE0M
{
    Id = 40,
    Value = Guid.Parse("bebf1767-3367-49d3-b332-c9277aae51e1"),
    ModelInner = new GuiduuidE0MI
{
    Id = 21,
    Value = Guid.Parse("c1b150fe-a558-42ee-ba53-8a6f7189ffa8"),
    NullableValue = Guid.Parse("8a5b26d3-da20-46fc-85da-1be48d30a4ad"),
},
    NullableValue = Guid.Parse("c2e8a368-dbf0-4745-b14d-b07bd895b00c"),
},
            new GuiduuidE0M
{
    Id = 48,
    Value = Guid.Parse("c8c4f81d-6968-4e94-8dd0-f612675eeebe"),
    ModelInner = null,
    NullableValue = Guid.Parse("20ecdc03-fcd8-45fa-88c7-6530a61c7b49"),
},
            new GuiduuidE0M
{
    Id = 57,
    Value = Guid.Parse("363f445b-2f4a-496f-b430-764e2fae5683"),
    ModelInner = new GuiduuidE0MI
{
    Id = 30,
    Value = Guid.Parse("19812249-1f83-4095-a478-fdca3d8b7aa0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 60,
    Value = Guid.Parse("d21bb232-375f-4404-9936-fc2c1cf9a71e"),
    ModelInner = null,
    NullableValue = Guid.Parse("37dc3d4c-6204-49a1-970c-d8748cc0443d"),
},
            new GuiduuidE0M
{
    Id = 68,
    Value = Guid.Parse("d2d1fa70-b1f7-4c6e-93ed-d4d85c49dd57"),
    ModelInner = new GuiduuidE0MI
{
    Id = 38,
    Value = Guid.Parse("0b7c9f56-58ba-491e-bac3-865e4d5ba7c7"),
    NullableValue = Guid.Parse("88d4cd46-82b1-4c50-9f90-3a97a6f50a97"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 71,
    Value = Guid.Parse("9afc4607-0b5c-421a-bf80-9185173ee397"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 80,
    Value = Guid.Parse("afaf3be1-baff-495b-a3af-0b0af94d8d90"),
    ModelInner = new GuiduuidE0MI
{
    Id = 45,
    Value = Guid.Parse("1b0a514f-7fa6-48ff-8902-a5a45d1fbe0a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("929caf73-a89f-46e4-957b-8241af20b795"),
},
            new GuiduuidE0M
{
    Id = 86,
    Value = Guid.Parse("9fdce184-520f-4a1d-ad0e-b69115c8cf5c"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 94,
    Value = Guid.Parse("cf8b0ef2-fb3d-48ce-aecc-189eccc80a23"),
    ModelInner = new GuiduuidE0MI
{
    Id = 48,
    Value = Guid.Parse("43ad4f00-46bc-4beb-b321-3c0c261e113d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 100,
    Value = Guid.Parse("e099ccdd-cd54-428f-90aa-5dff689ded78"),
    ModelInner = null,
    NullableValue = Guid.Parse("d1b2fb8a-51c1-420e-9403-368c45a9cbe4"),
},
            new GuiduuidE0M
{
    Id = 103,
    Value = Guid.Parse("b2701d45-29ea-46b8-bb19-efcb22a1bef8"),
    ModelInner = new GuiduuidE0MI
{
    Id = 52,
    Value = Guid.Parse("c74d7b89-e124-4b5e-b395-2720658ff538"),
    NullableValue = Guid.Parse("17ecdfde-02ac-484d-a24c-af985e26fdb4"),
},
    NullableValue = Guid.Parse("925a9b42-ee71-43e0-8029-19816812bba6"),
},
            new GuiduuidE0M
{
    Id = 112,
    Value = Guid.Parse("b5cbe689-13d8-4101-9533-9fc7da36e58a"),
    ModelInner = null,
    NullableValue = Guid.Parse("cbb2bb60-5139-4da0-a548-6bdff20b6be4"),
},
            new GuiduuidE0M
{
    Id = 120,
    Value = Guid.Parse("7921cc6e-858d-4259-9fb0-6ea0ccbddbe4"),
    ModelInner = new GuiduuidE0MI
{
    Id = 55,
    Value = Guid.Parse("0fd9ecf8-477a-4b0b-bca4-3a33faf21c97"),
    NullableValue = Guid.Parse("185d0c6d-6090-47ca-9717-cb869aa81e89"),
},
    NullableValue = Guid.Parse("982aaad6-4c26-4a70-95dc-36a818831e06"),
},
            new GuiduuidE0M
{
    Id = 121,
    Value = Guid.Parse("05fe5c00-8781-4d11-a3c5-4c8023ebde40"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 128,
    Value = Guid.Parse("f8795f6d-525b-4818-9220-014bdfda4536"),
    ModelInner = new GuiduuidE0MI
{
    Id = 64,
    Value = Guid.Parse("e1402ecc-5fff-45b3-b2cd-5e27126b01fe"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 137,
    Value = Guid.Parse("17ee9417-e299-4739-8da3-4fe690b93681"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 144,
    Value = Guid.Parse("5a15a96a-7635-4b3f-b33e-10f7bdfc209b"),
    ModelInner = new GuiduuidE0MI
{
    Id = 71,
    Value = Guid.Parse("2c177530-9b9f-4621-b2e3-48260bfe5e2d"),
    NullableValue = Guid.Parse("a6e2231f-7fe4-4ae3-bf00-ef021c86da7a"),
},
    NullableValue = Guid.Parse("3ac16d0c-ab04-491f-bc41-289b81940ee1"),
},
            new GuiduuidE0M
{
    Id = 152,
    Value = Guid.Parse("84ebc73c-e108-445d-ad9b-644cc6da7817"),
    ModelInner = null,
    NullableValue = Guid.Parse("70796ef4-67f1-402a-b66d-2dfbebeceb67"),
},
            new GuiduuidE0M
{
    Id = 154,
    Value = Guid.Parse("e768e7f1-bfc2-464e-80c7-d3d9f3b71c22"),
    ModelInner = new GuiduuidE0MI
{
    Id = 72,
    Value = Guid.Parse("b2879755-030f-4d9f-91e6-0ff69b2af46c"),
    NullableValue = Guid.Parse("590f3010-8c6d-470b-8841-0f5874367ed1"),
},
    NullableValue = Guid.Parse("40f46b8a-73df-44a0-9c21-024d80a3594e"),
},
            new GuiduuidE0M
{
    Id = 156,
    Value = Guid.Parse("9ee94f41-0279-4458-803a-c820f0295815"),
    ModelInner = null,
    NullableValue = Guid.Parse("00941df9-a54f-4bb9-aaf7-f4f2ff146a60"),
},
            new GuiduuidE0M
{
    Id = 163,
    Value = Guid.Parse("ce263a04-2d11-4293-93e4-f0d3daec7227"),
    ModelInner = new GuiduuidE0MI
{
    Id = 80,
    Value = Guid.Parse("41647938-d873-4d6f-9a90-4b667997e842"),
    NullableValue = Guid.Parse("68c23d85-ffc1-47b9-84cc-d5b7b6f47001"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 169,
    Value = Guid.Parse("7b235c5a-067c-469a-b072-d3913f1771e5"),
    ModelInner = null,
    NullableValue = Guid.Parse("ddf613f8-1e00-49d8-a3d7-12bbd208af4d"),
},
            new GuiduuidE0M
{
    Id = 171,
    Value = Guid.Parse("a51374f9-5dbc-4b41-93e6-62ac9737c5d4"),
    ModelInner = new GuiduuidE0MI
{
    Id = 86,
    Value = Guid.Parse("e9b44d5b-67d5-40f0-b186-73960efaf839"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 172,
    Value = Guid.Parse("8b3c3001-ea9b-45eb-a728-04ce0e138ebc"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 177,
    Value = Guid.Parse("ad7181a0-59df-4b0a-b4a9-6f1e6b4732ed"),
    ModelInner = new GuiduuidE0MI
{
    Id = 95,
    Value = Guid.Parse("4672d3f4-d855-4404-9674-f773e576421b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("fb4cf7fd-6b1b-43ff-9613-9c96916e472f"),
},
            new GuiduuidE0M
{
    Id = 185,
    Value = Guid.Parse("1ddb2498-e72f-4c80-a62e-94a3bdbd6722"),
    ModelInner = null,
    NullableValue = Guid.Parse("80d9004d-8bf1-425c-9bff-8af741ae570f"),
},
            new GuiduuidE0M
{
    Id = 187,
    Value = Guid.Parse("65cab2e2-39fc-44b2-9402-ac170268d36c"),
    ModelInner = new GuiduuidE0MI
{
    Id = 96,
    Value = Guid.Parse("de2ac923-36b5-49e9-9b3f-c6ab95d78f8d"),
    NullableValue = Guid.Parse("c76f8aa5-7a92-488c-bb53-be27e8b3bfc9"),
},
    NullableValue = Guid.Parse("d735d83a-86a3-4ee8-93dd-97a81b42065b"),
},
            new GuiduuidE0M
{
    Id = 192,
    Value = Guid.Parse("df1d499e-a3ee-4574-a7f9-dc7d2049ce72"),
    ModelInner = null,
    NullableValue = Guid.Parse("3c6f43d6-92eb-4379-b4c2-029aa42addfb"),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0mi(
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
INSERT INTO public.guiduuide0mi(
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
            queryMapTypes: [typeof(GuiduuidE0MI)],
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
INSERT INTO public.guiduuide0mi(
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
                methodParametrName: "guiduuide0mi_id", 
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
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
    guiduuide0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("6d960bcf-20be-46f1-86cd-06fdf21d13c8")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("c2e8a368-dbf0-4745-b14d-b07bd895b00c")));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
    guiduuide0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                methodParametrName: "guiduuide0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("20ecdc03-fcd8-45fa-88c7-6530a61c7b49")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("37dc3d4c-6204-49a1-970c-d8748cc0443d")));
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
                List<GuiduuidE0M> models = null;

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidE0M> models = null;

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduuide0mi_id
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
                parametrName: "guiduuide0mi_id", 
                methodParametrName: "guiduuide0mi_id", 
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 185;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.guiduuide0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidE0M.AssertModel(models[0],_testData[8], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidE0M.AssertModel(models[0],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidE0M.AssertModel(models[0],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidE0M.AssertModel(models[0],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 169, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 152, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 185, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 94, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 171, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 100, query1, 169, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 172, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidE0M.AssertModel(models[0],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidE0M.AssertModel(models[0],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 154, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidE0M.AssertModel(models[0],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidE0M.AssertModel(models[0],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidE0M.AssertModel(models[0],_testData[20], false);
                GuiduuidE0M.AssertModel(models[1],_testData[21], false);
                GuiduuidE0M.AssertModel(models[2],_testData[22], false);
                GuiduuidE0M.AssertModel(models[3],_testData[23], false);
                GuiduuidE0M.AssertModel(models[4],_testData[24], false);
                GuiduuidE0M.AssertModel(models[5],_testData[25], false);
                GuiduuidE0M.AssertModel(models[6],_testData[26], false);
                GuiduuidE0M.AssertModel(models[7],_testData[27], false);
                GuiduuidE0M.AssertModel(models[8],_testData[28], false);
                GuiduuidE0M.AssertModel(models[9],_testData[29], false);
                GuiduuidE0M.AssertModel(models[10],_testData[30], false);
                GuiduuidE0M.AssertModel(models[11],_testData[31], false);
                GuiduuidE0M.AssertModel(models[12],_testData[32], false);
                GuiduuidE0M.AssertModel(models[13],_testData[33], false);
                GuiduuidE0M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                GuiduuidE0M.AssertModel(models[0],_testData[14], false);
                GuiduuidE0M.AssertModel(models[1],_testData[15], false);
                GuiduuidE0M.AssertModel(models[2],_testData[16], false);
                GuiduuidE0M.AssertModel(models[3],_testData[17], false);
                GuiduuidE0M.AssertModel(models[4],_testData[18], false);
                GuiduuidE0M.AssertModel(models[5],_testData[19], false);
                GuiduuidE0M.AssertModel(models[6],_testData[20], false);
                GuiduuidE0M.AssertModel(models[7],_testData[21], false);
                GuiduuidE0M.AssertModel(models[8],_testData[22], false);
                GuiduuidE0M.AssertModel(models[9],_testData[23], false);
                GuiduuidE0M.AssertModel(models[10],_testData[24], false);
                GuiduuidE0M.AssertModel(models[11],_testData[25], false);
                GuiduuidE0M.AssertModel(models[12],_testData[26], false);
                GuiduuidE0M.AssertModel(models[13],_testData[27], false);
                GuiduuidE0M.AssertModel(models[14],_testData[28], false);
                GuiduuidE0M.AssertModel(models[15],_testData[29], false);
                GuiduuidE0M.AssertModel(models[16],_testData[30], false);
                GuiduuidE0M.AssertModel(models[17],_testData[31], false);
                GuiduuidE0M.AssertModel(models[18],_testData[32], false);
                GuiduuidE0M.AssertModel(models[19],_testData[33], false);
                GuiduuidE0M.AssertModel(models[20],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7008fe27-ca8e-4f11-9b1d-bb78c5ab6421"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e610ca5c-293e-42f8-9f06-67de3fdf1def"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e8a0d3d8-54ee-4a9e-92d1-69b28722882b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9baf192e-5472-442c-8672-0ec4d0715d1f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c09a52e0-e5a1-4bac-978a-fd52c0159734"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bec4f937-a727-4cf7-b6eb-956455fe89b8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fc95194c-20a0-45a3-8f25-076f87aae810"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("77a4de56-7d0a-471c-843b-7cc0be132b81"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("61cc007c-2117-44b5-9c1a-ea9b915bd4f6"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e7fa7fc9-e6dc-4fb0-9b09-6d3931f30157"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9243add5-619b-445f-a06a-7c17fc3b0fbd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d20c49a7-7ced-4b61-8993-1169548e92e0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("308829b7-4991-498b-aefd-70a6afb7dd99"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ceab2d88-2c73-4d73-8a78-2657b0f5d9ec"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6d960bcf-20be-46f1-86cd-06fdf21d13c8"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bebf1767-3367-49d3-b332-c9277aae51e1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c1b150fe-a558-42ee-ba53-8a6f7189ffa8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("8a5b26d3-da20-46fc-85da-1be48d30a4ad"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c2e8a368-dbf0-4745-b14d-b07bd895b00c"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c8c4f81d-6968-4e94-8dd0-f612675eeebe"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("20ecdc03-fcd8-45fa-88c7-6530a61c7b49"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("363f445b-2f4a-496f-b430-764e2fae5683"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("19812249-1f83-4095-a478-fdca3d8b7aa0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d21bb232-375f-4404-9936-fc2c1cf9a71e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37dc3d4c-6204-49a1-970c-d8748cc0443d"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d2d1fa70-b1f7-4c6e-93ed-d4d85c49dd57"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0b7c9f56-58ba-491e-bac3-865e4d5ba7c7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("88d4cd46-82b1-4c50-9f90-3a97a6f50a97"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9afc4607-0b5c-421a-bf80-9185173ee397"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("afaf3be1-baff-495b-a3af-0b0af94d8d90"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1b0a514f-7fa6-48ff-8902-a5a45d1fbe0a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("929caf73-a89f-46e4-957b-8241af20b795"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9fdce184-520f-4a1d-ad0e-b69115c8cf5c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cf8b0ef2-fb3d-48ce-aecc-189eccc80a23"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("43ad4f00-46bc-4beb-b321-3c0c261e113d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e099ccdd-cd54-428f-90aa-5dff689ded78"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d1b2fb8a-51c1-420e-9403-368c45a9cbe4"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b2701d45-29ea-46b8-bb19-efcb22a1bef8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c74d7b89-e124-4b5e-b395-2720658ff538"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("17ecdfde-02ac-484d-a24c-af985e26fdb4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("925a9b42-ee71-43e0-8029-19816812bba6"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b5cbe689-13d8-4101-9533-9fc7da36e58a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cbb2bb60-5139-4da0-a548-6bdff20b6be4"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7921cc6e-858d-4259-9fb0-6ea0ccbddbe4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0fd9ecf8-477a-4b0b-bca4-3a33faf21c97"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("185d0c6d-6090-47ca-9717-cb869aa81e89"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("982aaad6-4c26-4a70-95dc-36a818831e06"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("05fe5c00-8781-4d11-a3c5-4c8023ebde40"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8795f6d-525b-4818-9220-014bdfda4536"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e1402ecc-5fff-45b3-b2cd-5e27126b01fe"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("17ee9417-e299-4739-8da3-4fe690b93681"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5a15a96a-7635-4b3f-b33e-10f7bdfc209b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2c177530-9b9f-4621-b2e3-48260bfe5e2d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a6e2231f-7fe4-4ae3-bf00-ef021c86da7a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3ac16d0c-ab04-491f-bc41-289b81940ee1"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("84ebc73c-e108-445d-ad9b-644cc6da7817"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("70796ef4-67f1-402a-b66d-2dfbebeceb67"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e768e7f1-bfc2-464e-80c7-d3d9f3b71c22"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b2879755-030f-4d9f-91e6-0ff69b2af46c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("590f3010-8c6d-470b-8841-0f5874367ed1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("40f46b8a-73df-44a0-9c21-024d80a3594e"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9ee94f41-0279-4458-803a-c820f0295815"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("00941df9-a54f-4bb9-aaf7-f4f2ff146a60"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ce263a04-2d11-4293-93e4-f0d3daec7227"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("41647938-d873-4d6f-9a90-4b667997e842"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("68c23d85-ffc1-47b9-84cc-d5b7b6f47001"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7b235c5a-067c-469a-b072-d3913f1771e5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ddf613f8-1e00-49d8-a3d7-12bbd208af4d"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a51374f9-5dbc-4b41-93e6-62ac9737c5d4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e9b44d5b-67d5-40f0-b186-73960efaf839"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b3c3001-ea9b-45eb-a728-04ce0e138ebc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad7181a0-59df-4b0a-b4a9-6f1e6b4732ed"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4672d3f4-d855-4404-9674-f773e576421b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fb4cf7fd-6b1b-43ff-9613-9c96916e472f"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1ddb2498-e72f-4c80-a62e-94a3bdbd6722"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("80d9004d-8bf1-425c-9bff-8af741ae570f"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("65cab2e2-39fc-44b2-9402-ac170268d36c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("de2ac923-36b5-49e9-9b3f-c6ab95d78f8d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c76f8aa5-7a92-488c-bb53-be27e8b3bfc9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d735d83a-86a3-4ee8-93dd-97a81b42065b"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("df1d499e-a3ee-4574-a7f9-dc7d2049ce72"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c6f43d6-92eb-4379-b4c2-029aa42addfb"))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7008fe27-ca8e-4f11-9b1d-bb78c5ab6421"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e610ca5c-293e-42f8-9f06-67de3fdf1def"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e8a0d3d8-54ee-4a9e-92d1-69b28722882b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9baf192e-5472-442c-8672-0ec4d0715d1f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c09a52e0-e5a1-4bac-978a-fd52c0159734"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bec4f937-a727-4cf7-b6eb-956455fe89b8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fc95194c-20a0-45a3-8f25-076f87aae810"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("77a4de56-7d0a-471c-843b-7cc0be132b81"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("61cc007c-2117-44b5-9c1a-ea9b915bd4f6"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e7fa7fc9-e6dc-4fb0-9b09-6d3931f30157"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9243add5-619b-445f-a06a-7c17fc3b0fbd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d20c49a7-7ced-4b61-8993-1169548e92e0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("308829b7-4991-498b-aefd-70a6afb7dd99"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ceab2d88-2c73-4d73-8a78-2657b0f5d9ec"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6d960bcf-20be-46f1-86cd-06fdf21d13c8"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bebf1767-3367-49d3-b332-c9277aae51e1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c1b150fe-a558-42ee-ba53-8a6f7189ffa8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("8a5b26d3-da20-46fc-85da-1be48d30a4ad"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c2e8a368-dbf0-4745-b14d-b07bd895b00c"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c8c4f81d-6968-4e94-8dd0-f612675eeebe"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("20ecdc03-fcd8-45fa-88c7-6530a61c7b49"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("363f445b-2f4a-496f-b430-764e2fae5683"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("19812249-1f83-4095-a478-fdca3d8b7aa0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d21bb232-375f-4404-9936-fc2c1cf9a71e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37dc3d4c-6204-49a1-970c-d8748cc0443d"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d2d1fa70-b1f7-4c6e-93ed-d4d85c49dd57"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0b7c9f56-58ba-491e-bac3-865e4d5ba7c7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("88d4cd46-82b1-4c50-9f90-3a97a6f50a97"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9afc4607-0b5c-421a-bf80-9185173ee397"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("afaf3be1-baff-495b-a3af-0b0af94d8d90"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1b0a514f-7fa6-48ff-8902-a5a45d1fbe0a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("929caf73-a89f-46e4-957b-8241af20b795"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9fdce184-520f-4a1d-ad0e-b69115c8cf5c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cf8b0ef2-fb3d-48ce-aecc-189eccc80a23"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("43ad4f00-46bc-4beb-b321-3c0c261e113d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e099ccdd-cd54-428f-90aa-5dff689ded78"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d1b2fb8a-51c1-420e-9403-368c45a9cbe4"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b2701d45-29ea-46b8-bb19-efcb22a1bef8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c74d7b89-e124-4b5e-b395-2720658ff538"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("17ecdfde-02ac-484d-a24c-af985e26fdb4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("925a9b42-ee71-43e0-8029-19816812bba6"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b5cbe689-13d8-4101-9533-9fc7da36e58a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cbb2bb60-5139-4da0-a548-6bdff20b6be4"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7921cc6e-858d-4259-9fb0-6ea0ccbddbe4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0fd9ecf8-477a-4b0b-bca4-3a33faf21c97"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("185d0c6d-6090-47ca-9717-cb869aa81e89"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("982aaad6-4c26-4a70-95dc-36a818831e06"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("05fe5c00-8781-4d11-a3c5-4c8023ebde40"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8795f6d-525b-4818-9220-014bdfda4536"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e1402ecc-5fff-45b3-b2cd-5e27126b01fe"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("17ee9417-e299-4739-8da3-4fe690b93681"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5a15a96a-7635-4b3f-b33e-10f7bdfc209b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2c177530-9b9f-4621-b2e3-48260bfe5e2d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a6e2231f-7fe4-4ae3-bf00-ef021c86da7a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3ac16d0c-ab04-491f-bc41-289b81940ee1"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("84ebc73c-e108-445d-ad9b-644cc6da7817"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("70796ef4-67f1-402a-b66d-2dfbebeceb67"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e768e7f1-bfc2-464e-80c7-d3d9f3b71c22"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b2879755-030f-4d9f-91e6-0ff69b2af46c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("590f3010-8c6d-470b-8841-0f5874367ed1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("40f46b8a-73df-44a0-9c21-024d80a3594e"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9ee94f41-0279-4458-803a-c820f0295815"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("00941df9-a54f-4bb9-aaf7-f4f2ff146a60"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ce263a04-2d11-4293-93e4-f0d3daec7227"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("41647938-d873-4d6f-9a90-4b667997e842"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("68c23d85-ffc1-47b9-84cc-d5b7b6f47001"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7b235c5a-067c-469a-b072-d3913f1771e5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ddf613f8-1e00-49d8-a3d7-12bbd208af4d"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a51374f9-5dbc-4b41-93e6-62ac9737c5d4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e9b44d5b-67d5-40f0-b186-73960efaf839"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b3c3001-ea9b-45eb-a728-04ce0e138ebc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad7181a0-59df-4b0a-b4a9-6f1e6b4732ed"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4672d3f4-d855-4404-9674-f773e576421b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fb4cf7fd-6b1b-43ff-9613-9c96916e472f"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1ddb2498-e72f-4c80-a62e-94a3bdbd6722"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("80d9004d-8bf1-425c-9bff-8af741ae570f"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("65cab2e2-39fc-44b2-9402-ac170268d36c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("de2ac923-36b5-49e9-9b3f-c6ab95d78f8d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c76f8aa5-7a92-488c-bb53-be27e8b3bfc9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d735d83a-86a3-4ee8-93dd-97a81b42065b"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("df1d499e-a3ee-4574-a7f9-dc7d2049ce72"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c6f43d6-92eb-4379-b4c2-029aa42addfb"))));

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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidE0MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidSingleTypeuuid)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidSingleTypeuuid)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
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
            queryMapType: typeof(GuiduuidE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuide0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidE0MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidSingleTypeuuid)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidSingleTypeuuid)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
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
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuide0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuide0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidE0M),
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
FROM public.binary_guiduuide0m m
LEFT JOIN public.binary_guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidSingleTypeuuid)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidSingleTypeuuid)this).ImportModel(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuide0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
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
                    GuiduuidE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
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
                    GuiduuidE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                await ((IGuidSingleTypeuuid)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                ((IGuidSingleTypeuuid)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidSingleTypeuuid)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuide0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidSingleTypeuuid)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuide0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                await ((IGuidSingleTypeuuid)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                ((IGuidSingleTypeuuid)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidSingleTypeuuid)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuide0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidSingleTypeuuid)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuide0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI), typeof(GuiduuidE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidE0MI>();
                var models2 = new List<GuiduuidE0MI>();
                await ((IGuidSingleTypeuuid)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidE0MI>();
                var models2 = new List<GuiduuidE0MI>();
                ((IGuidSingleTypeuuid)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidSingleTypeuuid)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidSingleTypeuuid)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                await ((IGuidSingleTypeuuid)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                ((IGuidSingleTypeuuid)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidSingleTypeuuid)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidSingleTypeuuid)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


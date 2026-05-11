

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
    Value = Guid.Parse("69356f7e-1f5f-4f99-9187-a6fd640e902c"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 16,
    Value = Guid.Parse("c5b16870-e712-4e95-a077-9275dbe5a27a"),
    ModelInner = new GuiduuidE0MI
{
    Id = 4,
    Value = Guid.Parse("0993df34-8ddb-4ae6-ab19-9c0fad0354fa"),
    NullableValue = Guid.Parse("f8ee67a4-d700-47fd-bcbb-363602f1dcd0"),
},
    NullableValue = Guid.Parse("47fdd417-52a1-444c-8f86-1891ad1c20ff"),
},
            new GuiduuidE0M
{
    Id = 20,
    Value = Guid.Parse("61554f09-18f1-437f-bcf5-0babef81fa27"),
    ModelInner = null,
    NullableValue = Guid.Parse("927fa571-2180-46e5-a110-8537afad6652"),
},
            new GuiduuidE0M
{
    Id = 27,
    Value = Guid.Parse("36665941-5a40-439c-bf79-83dc6269a789"),
    ModelInner = new GuiduuidE0MI
{
    Id = 10,
    Value = Guid.Parse("cf0aeba6-34b5-44ab-9d00-a25f365d6726"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 35,
    Value = Guid.Parse("a8729a9d-6af5-4956-8013-ecc39efb282d"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 41,
    Value = Guid.Parse("5b17234f-c987-421e-87a8-0edad2f0666a"),
    ModelInner = new GuiduuidE0MI
{
    Id = 14,
    Value = Guid.Parse("46f16770-c959-46d2-97fc-3debdb58fc09"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 44,
    Value = Guid.Parse("28d633ff-6488-463f-8599-54e8c8f2bb7c"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 45,
    Value = Guid.Parse("8079e29f-bff0-4ad6-b403-d6554328fe59"),
    ModelInner = new GuiduuidE0MI
{
    Id = 21,
    Value = Guid.Parse("248618a6-d9f0-4bc6-83f2-6d04c1081f28"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("37d35a2e-b733-4abb-8d87-ab18b1afdc8f"),
},
            new GuiduuidE0M
{
    Id = 50,
    Value = Guid.Parse("0fb520ea-5c3d-4361-bcfd-2447336f5cfe"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 54,
    Value = Guid.Parse("7f67a3c6-f4c5-483e-b477-cf716e91023a"),
    ModelInner = new GuiduuidE0MI
{
    Id = 27,
    Value = Guid.Parse("091325bf-32f0-4807-a726-83bfce513526"),
    NullableValue = Guid.Parse("c4b86c24-972f-44a2-8ccc-7eb388e28678"),
},
    NullableValue = Guid.Parse("2c2adf27-1e4d-43a4-8ea1-65dea0aecf25"),
},
            new GuiduuidE0M
{
    Id = 63,
    Value = Guid.Parse("b0294484-f0fc-4456-b9a7-05b538a11a5d"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 69,
    Value = Guid.Parse("01787ad6-37f9-46ee-91a3-0006be130855"),
    ModelInner = new GuiduuidE0MI
{
    Id = 29,
    Value = Guid.Parse("9a6ab1ff-52ae-4648-bd6e-7be169a7b932"),
    NullableValue = Guid.Parse("2821dbdd-4ba9-4d9f-8562-efe065d0000c"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 75,
    Value = Guid.Parse("f2bc7d4b-1f53-4fd2-b166-9e4995d52560"),
    ModelInner = null,
    NullableValue = Guid.Parse("bc3198d0-f528-40e7-9959-99454b75f29b"),
},
            new GuiduuidE0M
{
    Id = 82,
    Value = Guid.Parse("bd90dfad-4ab9-4ba4-b5b4-00dc15cf5a18"),
    ModelInner = new GuiduuidE0MI
{
    Id = 36,
    Value = Guid.Parse("a4169360-7597-4e69-938f-ec067a644204"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("8654421c-2923-4c78-8762-7868e0e19ec8"),
},
            new GuiduuidE0M
{
    Id = 89,
    Value = Guid.Parse("b960ce70-3ac6-49d6-838e-e3ff902e220f"),
    ModelInner = null,
    NullableValue = Guid.Parse("6370e8ec-933b-4529-90fe-101ee3be3849"),
},
            new GuiduuidE0M
{
    Id = 97,
    Value = Guid.Parse("62ac087b-ee0d-4da6-b254-254c6518cfc0"),
    ModelInner = new GuiduuidE0MI
{
    Id = 37,
    Value = Guid.Parse("731dceab-f8d2-4082-a1fd-bac162439f73"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 101,
    Value = Guid.Parse("b5779d26-7d78-484f-adbc-943e265c159b"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 102,
    Value = Guid.Parse("8e853353-a3ba-4ea6-acbf-83b4c7c44f11"),
    ModelInner = new GuiduuidE0MI
{
    Id = 46,
    Value = Guid.Parse("82d61344-0164-4bfe-aa6d-503d671231a0"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d565981a-cd7f-4ef6-982c-33afcfb614a6"),
},
            new GuiduuidE0M
{
    Id = 106,
    Value = Guid.Parse("9c841802-cddd-487b-b99e-92644d396492"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 114,
    Value = Guid.Parse("d7e4cbe3-0076-4c3d-b78a-265c5446a21a"),
    ModelInner = new GuiduuidE0MI
{
    Id = 48,
    Value = Guid.Parse("85895f00-5f0e-46bb-9062-39d0e19d4fec"),
    NullableValue = Guid.Parse("b8497517-0187-40b9-af24-f308a2526259"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 121,
    Value = Guid.Parse("cfe67479-61e0-4c10-a1cf-21a33b2eb39c"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 130,
    Value = Guid.Parse("400557e4-c019-4646-92d3-32521750727f"),
    ModelInner = new GuiduuidE0MI
{
    Id = 51,
    Value = Guid.Parse("f7f54a2e-e937-41e9-9c3a-315817e85073"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("3821a2e7-7730-4295-8d81-609482a7e6bf"),
},
            new GuiduuidE0M
{
    Id = 133,
    Value = Guid.Parse("af09433f-b106-4369-be46-37af549b1fc6"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 134,
    Value = Guid.Parse("4c6adc28-b9ac-4ccd-a7d1-7bded3099200"),
    ModelInner = new GuiduuidE0MI
{
    Id = 56,
    Value = Guid.Parse("3e5349c9-0df7-4b88-b255-9c576850ac4f"),
    NullableValue = Guid.Parse("5fad1874-27eb-464f-86c7-f0404c748645"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 141,
    Value = Guid.Parse("e3297280-eea3-4127-bfc4-7d8439c72818"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 148,
    Value = Guid.Parse("98f2b713-0a64-4652-acc5-256700ae15cb"),
    ModelInner = new GuiduuidE0MI
{
    Id = 64,
    Value = Guid.Parse("462d5b4e-b510-4a62-8224-f7bea3a0634d"),
    NullableValue = Guid.Parse("04732e96-b24c-4924-b06e-1b635174c97d"),
},
    NullableValue = Guid.Parse("fe7b10dc-4a95-4293-bfa1-022888bf230b"),
},
            new GuiduuidE0M
{
    Id = 154,
    Value = Guid.Parse("f27223bc-5341-4775-995b-c3fde6373bfc"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 162,
    Value = Guid.Parse("c55bb2a3-2e72-49ca-b5ad-554be3d0db9b"),
    ModelInner = new GuiduuidE0MI
{
    Id = 72,
    Value = Guid.Parse("b811eb69-4c05-4726-ae28-37e9a8dc8af5"),
    NullableValue = Guid.Parse("c44ba21b-53e7-44f0-bea5-2cff86400669"),
},
    NullableValue = Guid.Parse("b126be8c-a85f-4328-bd57-e849217c7d4f"),
},
            new GuiduuidE0M
{
    Id = 164,
    Value = Guid.Parse("a747d0a7-71b6-4801-b408-2df759718daf"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 169,
    Value = Guid.Parse("68b1f27f-3cfb-435e-b7da-5dc9267ccbe8"),
    ModelInner = new GuiduuidE0MI
{
    Id = 77,
    Value = Guid.Parse("f57f330f-ad0c-4b95-8ff2-38d209cff60c"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 175,
    Value = Guid.Parse("1f1b7a2a-1fc1-4fde-9584-44a3585479c7"),
    ModelInner = null,
    NullableValue = Guid.Parse("309e1c6b-b456-4c01-9041-9e45bc30b1ca"),
},
            new GuiduuidE0M
{
    Id = 176,
    Value = Guid.Parse("eb1c987a-3245-4467-bbfc-2558aff07732"),
    ModelInner = new GuiduuidE0MI
{
    Id = 85,
    Value = Guid.Parse("bead2085-818f-494d-b671-c5ed9b94281c"),
    NullableValue = Guid.Parse("109909e6-8c5b-4ef6-8f16-502d5f438ebb"),
},
    NullableValue = Guid.Parse("1d5ab65f-eb9f-4298-b42a-ac287e87fefd"),
},
            new GuiduuidE0M
{
    Id = 179,
    Value = Guid.Parse("d4ab3c3d-2af3-4d7f-a789-a17e56a32f7c"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 184,
    Value = Guid.Parse("72a4175b-be5c-4c28-b49a-b0579a464eb6"),
    ModelInner = new GuiduuidE0MI
{
    Id = 94,
    Value = Guid.Parse("6d557e36-f9fa-4225-97ce-b91b6030a7ea"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 186,
    Value = Guid.Parse("78310bf2-0f7a-4b6a-aaa9-8b06354f7582"),
    ModelInner = null,
    NullableValue = Guid.Parse("bf9046ec-a896-4f8b-8ffd-4f6a7aee13c0"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("37d35a2e-b733-4abb-8d87-ab18b1afdc8f")));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("2c2adf27-1e4d-43a4-8ea1-65dea0aecf25")));
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[32],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[34], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidE0M.AssertModel(models[0],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidE0M.AssertModel(models[0],_testData[3], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[4], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[5], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[6], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[7], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[8], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[26],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[27],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[28],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[29],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[30],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[31],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 63, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 176, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 176, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[31],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 169, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 164, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 50, query1, 141, query2))
                {
                    if(++resultIndex == 1)
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 175, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 169, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidE0M.AssertModel(models[0],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidE0M.AssertModel(models[0],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 69, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidE0M.AssertModel(models[0],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                GuiduuidE0M.AssertModel(models[0],_testData[22], false);
                GuiduuidE0M.AssertModel(models[1],_testData[23], false);
                GuiduuidE0M.AssertModel(models[2],_testData[24], false);
                GuiduuidE0M.AssertModel(models[3],_testData[25], false);
                GuiduuidE0M.AssertModel(models[4],_testData[26], false);
                GuiduuidE0M.AssertModel(models[5],_testData[27], false);
                GuiduuidE0M.AssertModel(models[6],_testData[28], false);
                GuiduuidE0M.AssertModel(models[7],_testData[29], false);
                GuiduuidE0M.AssertModel(models[8],_testData[30], false);
                GuiduuidE0M.AssertModel(models[9],_testData[31], false);
                GuiduuidE0M.AssertModel(models[10],_testData[32], false);
                GuiduuidE0M.AssertModel(models[11],_testData[33], false);
                GuiduuidE0M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                GuiduuidE0M.AssertModel(models[0],_testData[25], false);
                GuiduuidE0M.AssertModel(models[1],_testData[26], false);
                GuiduuidE0M.AssertModel(models[2],_testData[27], false);
                GuiduuidE0M.AssertModel(models[3],_testData[28], false);
                GuiduuidE0M.AssertModel(models[4],_testData[29], false);
                GuiduuidE0M.AssertModel(models[5],_testData[30], false);
                GuiduuidE0M.AssertModel(models[6],_testData[31], false);
                GuiduuidE0M.AssertModel(models[7],_testData[32], false);
                GuiduuidE0M.AssertModel(models[8],_testData[33], false);
                GuiduuidE0M.AssertModel(models[9],_testData[34], false);
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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("69356f7e-1f5f-4f99-9187-a6fd640e902c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c5b16870-e712-4e95-a077-9275dbe5a27a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0993df34-8ddb-4ae6-ab19-9c0fad0354fa"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f8ee67a4-d700-47fd-bcbb-363602f1dcd0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("47fdd417-52a1-444c-8f86-1891ad1c20ff"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("61554f09-18f1-437f-bcf5-0babef81fa27"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("927fa571-2180-46e5-a110-8537afad6652"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("36665941-5a40-439c-bf79-83dc6269a789"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cf0aeba6-34b5-44ab-9d00-a25f365d6726"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8729a9d-6af5-4956-8013-ecc39efb282d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5b17234f-c987-421e-87a8-0edad2f0666a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("46f16770-c959-46d2-97fc-3debdb58fc09"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("28d633ff-6488-463f-8599-54e8c8f2bb7c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8079e29f-bff0-4ad6-b403-d6554328fe59"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("248618a6-d9f0-4bc6-83f2-6d04c1081f28"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37d35a2e-b733-4abb-8d87-ab18b1afdc8f"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0fb520ea-5c3d-4361-bcfd-2447336f5cfe"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f67a3c6-f4c5-483e-b477-cf716e91023a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("091325bf-32f0-4807-a726-83bfce513526"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c4b86c24-972f-44a2-8ccc-7eb388e28678"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2c2adf27-1e4d-43a4-8ea1-65dea0aecf25"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b0294484-f0fc-4456-b9a7-05b538a11a5d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01787ad6-37f9-46ee-91a3-0006be130855"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9a6ab1ff-52ae-4648-bd6e-7be169a7b932"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2821dbdd-4ba9-4d9f-8562-efe065d0000c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2bc7d4b-1f53-4fd2-b166-9e4995d52560"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bc3198d0-f528-40e7-9959-99454b75f29b"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bd90dfad-4ab9-4ba4-b5b4-00dc15cf5a18"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a4169360-7597-4e69-938f-ec067a644204"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8654421c-2923-4c78-8762-7868e0e19ec8"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b960ce70-3ac6-49d6-838e-e3ff902e220f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6370e8ec-933b-4529-90fe-101ee3be3849"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62ac087b-ee0d-4da6-b254-254c6518cfc0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("731dceab-f8d2-4082-a1fd-bac162439f73"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b5779d26-7d78-484f-adbc-943e265c159b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8e853353-a3ba-4ea6-acbf-83b4c7c44f11"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("82d61344-0164-4bfe-aa6d-503d671231a0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d565981a-cd7f-4ef6-982c-33afcfb614a6"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c841802-cddd-487b-b99e-92644d396492"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d7e4cbe3-0076-4c3d-b78a-265c5446a21a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("85895f00-5f0e-46bb-9062-39d0e19d4fec"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b8497517-0187-40b9-af24-f308a2526259"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cfe67479-61e0-4c10-a1cf-21a33b2eb39c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("400557e4-c019-4646-92d3-32521750727f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f7f54a2e-e937-41e9-9c3a-315817e85073"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3821a2e7-7730-4295-8d81-609482a7e6bf"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af09433f-b106-4369-be46-37af549b1fc6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c6adc28-b9ac-4ccd-a7d1-7bded3099200"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3e5349c9-0df7-4b88-b255-9c576850ac4f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5fad1874-27eb-464f-86c7-f0404c748645"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e3297280-eea3-4127-bfc4-7d8439c72818"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98f2b713-0a64-4652-acc5-256700ae15cb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("462d5b4e-b510-4a62-8224-f7bea3a0634d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("04732e96-b24c-4924-b06e-1b635174c97d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fe7b10dc-4a95-4293-bfa1-022888bf230b"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f27223bc-5341-4775-995b-c3fde6373bfc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c55bb2a3-2e72-49ca-b5ad-554be3d0db9b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b811eb69-4c05-4726-ae28-37e9a8dc8af5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c44ba21b-53e7-44f0-bea5-2cff86400669"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b126be8c-a85f-4328-bd57-e849217c7d4f"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a747d0a7-71b6-4801-b408-2df759718daf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("68b1f27f-3cfb-435e-b7da-5dc9267ccbe8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f57f330f-ad0c-4b95-8ff2-38d209cff60c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1f1b7a2a-1fc1-4fde-9584-44a3585479c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("309e1c6b-b456-4c01-9041-9e45bc30b1ca"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eb1c987a-3245-4467-bbfc-2558aff07732"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bead2085-818f-494d-b671-c5ed9b94281c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("109909e6-8c5b-4ef6-8f16-502d5f438ebb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d5ab65f-eb9f-4298-b42a-ac287e87fefd"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d4ab3c3d-2af3-4d7f-a789-a17e56a32f7c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72a4175b-be5c-4c28-b49a-b0579a464eb6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6d557e36-f9fa-4225-97ce-b91b6030a7ea"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78310bf2-0f7a-4b6a-aaa9-8b06354f7582"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bf9046ec-a896-4f8b-8ffd-4f6a7aee13c0"))));

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("69356f7e-1f5f-4f99-9187-a6fd640e902c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c5b16870-e712-4e95-a077-9275dbe5a27a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0993df34-8ddb-4ae6-ab19-9c0fad0354fa"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f8ee67a4-d700-47fd-bcbb-363602f1dcd0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("47fdd417-52a1-444c-8f86-1891ad1c20ff"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("61554f09-18f1-437f-bcf5-0babef81fa27"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("927fa571-2180-46e5-a110-8537afad6652"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("36665941-5a40-439c-bf79-83dc6269a789"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cf0aeba6-34b5-44ab-9d00-a25f365d6726"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8729a9d-6af5-4956-8013-ecc39efb282d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5b17234f-c987-421e-87a8-0edad2f0666a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("46f16770-c959-46d2-97fc-3debdb58fc09"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("28d633ff-6488-463f-8599-54e8c8f2bb7c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8079e29f-bff0-4ad6-b403-d6554328fe59"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("248618a6-d9f0-4bc6-83f2-6d04c1081f28"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37d35a2e-b733-4abb-8d87-ab18b1afdc8f"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0fb520ea-5c3d-4361-bcfd-2447336f5cfe"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f67a3c6-f4c5-483e-b477-cf716e91023a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("091325bf-32f0-4807-a726-83bfce513526"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c4b86c24-972f-44a2-8ccc-7eb388e28678"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2c2adf27-1e4d-43a4-8ea1-65dea0aecf25"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b0294484-f0fc-4456-b9a7-05b538a11a5d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01787ad6-37f9-46ee-91a3-0006be130855"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9a6ab1ff-52ae-4648-bd6e-7be169a7b932"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2821dbdd-4ba9-4d9f-8562-efe065d0000c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2bc7d4b-1f53-4fd2-b166-9e4995d52560"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bc3198d0-f528-40e7-9959-99454b75f29b"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bd90dfad-4ab9-4ba4-b5b4-00dc15cf5a18"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a4169360-7597-4e69-938f-ec067a644204"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8654421c-2923-4c78-8762-7868e0e19ec8"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b960ce70-3ac6-49d6-838e-e3ff902e220f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6370e8ec-933b-4529-90fe-101ee3be3849"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62ac087b-ee0d-4da6-b254-254c6518cfc0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("731dceab-f8d2-4082-a1fd-bac162439f73"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b5779d26-7d78-484f-adbc-943e265c159b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8e853353-a3ba-4ea6-acbf-83b4c7c44f11"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("82d61344-0164-4bfe-aa6d-503d671231a0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d565981a-cd7f-4ef6-982c-33afcfb614a6"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c841802-cddd-487b-b99e-92644d396492"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d7e4cbe3-0076-4c3d-b78a-265c5446a21a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("85895f00-5f0e-46bb-9062-39d0e19d4fec"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b8497517-0187-40b9-af24-f308a2526259"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cfe67479-61e0-4c10-a1cf-21a33b2eb39c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("400557e4-c019-4646-92d3-32521750727f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f7f54a2e-e937-41e9-9c3a-315817e85073"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3821a2e7-7730-4295-8d81-609482a7e6bf"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af09433f-b106-4369-be46-37af549b1fc6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c6adc28-b9ac-4ccd-a7d1-7bded3099200"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3e5349c9-0df7-4b88-b255-9c576850ac4f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5fad1874-27eb-464f-86c7-f0404c748645"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e3297280-eea3-4127-bfc4-7d8439c72818"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98f2b713-0a64-4652-acc5-256700ae15cb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("462d5b4e-b510-4a62-8224-f7bea3a0634d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("04732e96-b24c-4924-b06e-1b635174c97d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fe7b10dc-4a95-4293-bfa1-022888bf230b"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f27223bc-5341-4775-995b-c3fde6373bfc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c55bb2a3-2e72-49ca-b5ad-554be3d0db9b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b811eb69-4c05-4726-ae28-37e9a8dc8af5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c44ba21b-53e7-44f0-bea5-2cff86400669"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b126be8c-a85f-4328-bd57-e849217c7d4f"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a747d0a7-71b6-4801-b408-2df759718daf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("68b1f27f-3cfb-435e-b7da-5dc9267ccbe8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f57f330f-ad0c-4b95-8ff2-38d209cff60c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1f1b7a2a-1fc1-4fde-9584-44a3585479c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("309e1c6b-b456-4c01-9041-9e45bc30b1ca"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eb1c987a-3245-4467-bbfc-2558aff07732"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bead2085-818f-494d-b671-c5ed9b94281c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("109909e6-8c5b-4ef6-8f16-502d5f438ebb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d5ab65f-eb9f-4298-b42a-ac287e87fefd"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d4ab3c3d-2af3-4d7f-a789-a17e56a32f7c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72a4175b-be5c-4c28-b49a-b0579a464eb6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6d557e36-f9fa-4225-97ce-b91b6030a7ea"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78310bf2-0f7a-4b6a-aaa9-8b06354f7582"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bf9046ec-a896-4f8b-8ffd-4f6a7aee13c0"))));

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


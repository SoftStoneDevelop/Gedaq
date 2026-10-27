

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidSingleTypeuniqueidentifier
    {
    }
    
    internal partial class GuidSingleTypeuniqueidentifier : IGuidSingleTypeuniqueidentifier
    {


#region TestData

        private readonly GuiduniqueidentifierE0M[] _testData = new GuiduniqueidentifierE0M[]
        {
            new GuiduniqueidentifierE0M
{
    Id = 1,
    Value = Guid.Parse("a1a2a917-dd8c-4b64-b758-35af8de7dad4"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 2,
    Value = Guid.Parse("e329928a-9be3-4c99-b7e5-590542e4ae48"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 9,
    Value = Guid.Parse("e51ac135-4e67-410e-9567-eab3005aa6b0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 5,
    Value = Guid.Parse("9c0da585-d5e4-4f5e-b9f9-0a675f32c8f9"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 12,
    Value = Guid.Parse("1095f09a-2441-4df3-bd01-99ad54a505dc"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 13,
    Value = Guid.Parse("5e297de7-6945-406d-b805-a97f6f834e0d"),
    NullableValue = Guid.Parse("dc4ec3e8-4de0-4c30-8304-ad9527bb0887"),
},
    NullableValue = Guid.Parse("e72f1df0-07d3-4de1-a035-9e1854c1a1cf"),
},
            new GuiduniqueidentifierE0M
{
    Id = 20,
    Value = Guid.Parse("ebd5aaa6-8c1d-488d-8971-fab9bc7d8a38"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 26,
    Value = Guid.Parse("fe99aeed-4881-4d3d-9472-d8f151a6a30d"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 16,
    Value = Guid.Parse("ed56fa8b-5149-4daa-a3c6-740ffedeabac"),
    NullableValue = Guid.Parse("1eec4e57-8ce1-4f93-b176-e4514ac98bc0"),
},
    NullableValue = Guid.Parse("a90b3cd6-9f10-44fa-b8be-c51469add645"),
},
            new GuiduniqueidentifierE0M
{
    Id = 31,
    Value = Guid.Parse("490ce7a5-aefe-41af-b066-68a49357eb65"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 36,
    Value = Guid.Parse("40b1bb1b-447f-431c-ba3f-03b0f59351d7"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 23,
    Value = Guid.Parse("347cb2b3-ae1a-486b-8448-fe216b797b30"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 43,
    Value = Guid.Parse("ed9f07d9-0a9d-4de5-9a52-68f0ff309193"),
    ModelInner = null,
    NullableValue = Guid.Parse("afd2b8fb-f0f4-483b-998e-25b5373b9e00"),
},
            new GuiduniqueidentifierE0M
{
    Id = 46,
    Value = Guid.Parse("e60bc055-f4ba-4be2-bdcb-ed8923ae0ea9"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 27,
    Value = Guid.Parse("9a0a8d1b-93c2-431f-8a2b-6ff4a1edcdbf"),
    NullableValue = Guid.Parse("4208d7e8-f27f-455d-888d-d280c080f4cb"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 50,
    Value = Guid.Parse("fd3a94cb-d649-46ac-9b59-2a3b969ac371"),
    ModelInner = null,
    NullableValue = Guid.Parse("e94f8f04-cea9-42ae-9ced-76868ceb9de0"),
},
            new GuiduniqueidentifierE0M
{
    Id = 53,
    Value = Guid.Parse("d96acf23-df16-41f6-ae42-cb42c55c9fbf"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 33,
    Value = Guid.Parse("7b7d5fc5-945d-41c2-bcad-53b83100b6ea"),
    NullableValue = Guid.Parse("8b0e5c4b-c31c-4a8c-91f0-448e0bd506b9"),
},
    NullableValue = Guid.Parse("2c6af7e0-d233-47f1-a8db-6f46a48aca31"),
},
            new GuiduniqueidentifierE0M
{
    Id = 56,
    Value = Guid.Parse("ce074c98-1a86-4e9e-b801-af8add93a5c7"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 57,
    Value = Guid.Parse("b075e7f3-1c93-4270-adcb-58b18e47993c"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 39,
    Value = Guid.Parse("3200843f-86a0-4367-bd34-ce834ce40a88"),
    NullableValue = Guid.Parse("6a0b747e-f0d1-4108-93f4-5790c2813ad8"),
},
    NullableValue = Guid.Parse("ff1f8405-b0ea-4624-a352-dc2c90ae3af2"),
},
            new GuiduniqueidentifierE0M
{
    Id = 59,
    Value = Guid.Parse("4f33f334-91be-40b0-958a-d3f28d39a115"),
    ModelInner = null,
    NullableValue = Guid.Parse("4c977981-758e-41ec-b170-e99a76538705"),
},
            new GuiduniqueidentifierE0M
{
    Id = 67,
    Value = Guid.Parse("73251874-7b2a-4cd3-991b-014e7fce3c51"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 45,
    Value = Guid.Parse("a08f3258-b92f-4e92-98b7-13f995a32415"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("9e2e3d3e-0ad4-4cef-b9b5-d796eeaf3549"),
},
            new GuiduniqueidentifierE0M
{
    Id = 72,
    Value = Guid.Parse("e8a74759-73b0-41b1-9016-cb77d7e89091"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 75,
    Value = Guid.Parse("7ad295ae-cf7c-447d-b3b3-83eceae0e7ee"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 52,
    Value = Guid.Parse("9b37868a-aa29-40cd-9a9b-da21582c8322"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b0eeb6ed-5f38-469d-a00b-651ff9261618"),
},
            new GuiduniqueidentifierE0M
{
    Id = 78,
    Value = Guid.Parse("db6ca9e1-1a8f-44fc-867a-2ecd6ce5797f"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 82,
    Value = Guid.Parse("cce88fa4-0e79-4aa3-aa7a-6b1b4a4daadf"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 53,
    Value = Guid.Parse("28aca625-8a8e-4d17-95ba-0a33522f7ecb"),
    NullableValue = Guid.Parse("0c1229e1-ea48-47fe-bda4-7e2564c54fc8"),
},
    NullableValue = Guid.Parse("431d7b2a-9d20-4862-aac9-969a3d4980b8"),
},
            new GuiduniqueidentifierE0M
{
    Id = 85,
    Value = Guid.Parse("c55292dd-50f3-4063-98ab-8d71b46fed98"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 91,
    Value = Guid.Parse("0de8c991-7abc-4b2a-ab78-99ede73b3ebf"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 58,
    Value = Guid.Parse("fedaa793-403f-4314-a8ae-39e7726505ca"),
    NullableValue = Guid.Parse("dc3fa27c-8d8f-4539-b466-0873d9533e18"),
},
    NullableValue = Guid.Parse("72dc5aff-dec8-40cc-a776-6ef678822d78"),
},
            new GuiduniqueidentifierE0M
{
    Id = 92,
    Value = Guid.Parse("dceac060-9dfd-467f-85d8-1e7cfc363e6f"),
    ModelInner = null,
    NullableValue = Guid.Parse("cb96e2f6-7374-4896-87de-911e875c698d"),
},
            new GuiduniqueidentifierE0M
{
    Id = 93,
    Value = Guid.Parse("1c3cdd60-31a2-45b4-ab66-5a49e6d31e7a"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 62,
    Value = Guid.Parse("66bb7d91-79c3-47bc-8e74-e9cc47f70c0e"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("215d1083-c4d5-419f-8805-42ab11296d2f"),
},
            new GuiduniqueidentifierE0M
{
    Id = 100,
    Value = Guid.Parse("67718c7d-3b1e-41cd-8b8c-9a282dd54669"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 103,
    Value = Guid.Parse("155ee34d-f940-4016-b698-4c991dc51da2"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 63,
    Value = Guid.Parse("217e9ed2-4992-464c-a2f6-eb3fe97236d9"),
    NullableValue = Guid.Parse("aabd6375-7ee1-40bf-9284-869416aadcf9"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 109,
    Value = Guid.Parse("139707c2-2de0-482e-a0dd-5d18984277c7"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 117,
    Value = Guid.Parse("d5e01af4-eed6-4b79-9b27-6e9df545d4f9"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 70,
    Value = Guid.Parse("00befb33-9002-45bf-96fc-6353e8f2011a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("1a879c46-fdf8-49dd-9703-7b310a08a86e"),
},
            new GuiduniqueidentifierE0M
{
    Id = 121,
    Value = Guid.Parse("c64afa24-429f-4bc5-add8-5b8525350f17"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 124,
    Value = Guid.Parse("7082bd9e-9754-4f9e-a434-da74d5c8dcc2"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 71,
    Value = Guid.Parse("546e15ae-1f81-4cad-b5fa-5be4d71ac051"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 126,
    Value = Guid.Parse("88d206d6-6b4d-46c8-95a6-e14f2ecf38c8"),
    ModelInner = null,
    NullableValue = Guid.Parse("764f0462-c0a5-490f-a9ef-1cffa4e8cf85"),
},
            new GuiduniqueidentifierE0M
{
    Id = 133,
    Value = Guid.Parse("f56653eb-4092-49ae-aaa5-cb59731c0fd1"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 76,
    Value = Guid.Parse("526715cd-32a5-4eb4-9ab8-0749c0751ab5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("5c4e7e9f-c831-4bc6-b061-a6e3da8caad5"),
},
            new GuiduniqueidentifierE0M
{
    Id = 135,
    Value = Guid.Parse("dede2bef-20c7-4112-8597-5121f02ab466"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 143,
    Value = Guid.Parse("366714d3-6eb9-40bc-89e7-2288b3dd6002"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 82,
    Value = Guid.Parse("d93d0e6e-12a5-453c-b30e-c9a07240dfcd"),
    NullableValue = Guid.Parse("c8dab376-c070-43c0-b8f6-d7197a5fe49b"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 150,
    Value = Guid.Parse("e490bfc9-4d74-4067-a2f7-c8dffca99cdf"),
    ModelInner = null,
    NullableValue = Guid.Parse("99dc14c7-546c-41a6-bced-de5b60be5792"),
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifiere0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id, 
    @value, 
    @nullablevalue
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(14)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(14))
            ]
        public void InsertModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifiere0mi(
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)9),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)9, 
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifiere0m(
	id,
    value,
    nullablevalue,
    guiduniqueidentifiere0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduniqueidentifiere0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(14)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(14),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduniqueidentifiere0mi_id", 
                methodParametrName: "guiduniqueidentifiere0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
                nullable: true)]
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifiere0m(
	id,
    value,
    nullablevalue,
    guiduniqueidentifiere0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduniqueidentifiere0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Guid), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)9),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)9,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduniqueidentifiere0mi_id", 
                methodParametrName: "guiduniqueidentifiere0mi_id", 
                dbType: (System.Data.DbType)11,
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M), typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                await((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                ((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuniqueidentifier)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuniqueidentifier)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M), typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                await((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                ((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IGuidSingleTypeuniqueidentifier)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidSingleTypeuniqueidentifier)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M), typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                await((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[1], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[2], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[3], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[4], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[5], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[6], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[28],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[29],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[30],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[31],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[32],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[2], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[3], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[4], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[5], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[6], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[28],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[29],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[30],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[31],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M), typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                await((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 82, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 67, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 5, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 121, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 57, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 2, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 85, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 53, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 75, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[28], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[16], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[17], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[18], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[19], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[20], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[21], false);
                GuiduniqueidentifierE0M.AssertModel(models[6],_testData[22], false);
                GuiduniqueidentifierE0M.AssertModel(models[7],_testData[23], false);
                GuiduniqueidentifierE0M.AssertModel(models[8],_testData[24], false);
                GuiduniqueidentifierE0M.AssertModel(models[9],_testData[25], false);
                GuiduniqueidentifierE0M.AssertModel(models[10],_testData[26], false);
                GuiduniqueidentifierE0M.AssertModel(models[11],_testData[27], false);
                GuiduniqueidentifierE0M.AssertModel(models[12],_testData[28], false);
                GuiduniqueidentifierE0M.AssertModel(models[13],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[14],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[15],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[16],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[17],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[18],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a1a2a917-dd8c-4b64-b758-35af8de7dad4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e329928a-9be3-4c99-b7e5-590542e4ae48"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e51ac135-4e67-410e-9567-eab3005aa6b0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c0da585-d5e4-4f5e-b9f9-0a675f32c8f9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1095f09a-2441-4df3-bd01-99ad54a505dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5e297de7-6945-406d-b805-a97f6f834e0d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dc4ec3e8-4de0-4c30-8304-ad9527bb0887"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e72f1df0-07d3-4de1-a035-9e1854c1a1cf"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ebd5aaa6-8c1d-488d-8971-fab9bc7d8a38"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe99aeed-4881-4d3d-9472-d8f151a6a30d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ed56fa8b-5149-4daa-a3c6-740ffedeabac"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1eec4e57-8ce1-4f93-b176-e4514ac98bc0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a90b3cd6-9f10-44fa-b8be-c51469add645"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("490ce7a5-aefe-41af-b066-68a49357eb65"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40b1bb1b-447f-431c-ba3f-03b0f59351d7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("347cb2b3-ae1a-486b-8448-fe216b797b30"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ed9f07d9-0a9d-4de5-9a52-68f0ff309193"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("afd2b8fb-f0f4-483b-998e-25b5373b9e00"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e60bc055-f4ba-4be2-bdcb-ed8923ae0ea9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9a0a8d1b-93c2-431f-8a2b-6ff4a1edcdbf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4208d7e8-f27f-455d-888d-d280c080f4cb"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd3a94cb-d649-46ac-9b59-2a3b969ac371"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e94f8f04-cea9-42ae-9ced-76868ceb9de0"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d96acf23-df16-41f6-ae42-cb42c55c9fbf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7b7d5fc5-945d-41c2-bcad-53b83100b6ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("8b0e5c4b-c31c-4a8c-91f0-448e0bd506b9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2c6af7e0-d233-47f1-a8db-6f46a48aca31"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ce074c98-1a86-4e9e-b801-af8add93a5c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b075e7f3-1c93-4270-adcb-58b18e47993c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3200843f-86a0-4367-bd34-ce834ce40a88"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6a0b747e-f0d1-4108-93f4-5790c2813ad8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ff1f8405-b0ea-4624-a352-dc2c90ae3af2"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f33f334-91be-40b0-958a-d3f28d39a115"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c977981-758e-41ec-b170-e99a76538705"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("73251874-7b2a-4cd3-991b-014e7fce3c51"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a08f3258-b92f-4e92-98b7-13f995a32415"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9e2e3d3e-0ad4-4cef-b9b5-d796eeaf3549"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e8a74759-73b0-41b1-9016-cb77d7e89091"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ad295ae-cf7c-447d-b3b3-83eceae0e7ee"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9b37868a-aa29-40cd-9a9b-da21582c8322"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b0eeb6ed-5f38-469d-a00b-651ff9261618"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db6ca9e1-1a8f-44fc-867a-2ecd6ce5797f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cce88fa4-0e79-4aa3-aa7a-6b1b4a4daadf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("28aca625-8a8e-4d17-95ba-0a33522f7ecb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0c1229e1-ea48-47fe-bda4-7e2564c54fc8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("431d7b2a-9d20-4862-aac9-969a3d4980b8"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c55292dd-50f3-4063-98ab-8d71b46fed98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0de8c991-7abc-4b2a-ab78-99ede73b3ebf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fedaa793-403f-4314-a8ae-39e7726505ca"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dc3fa27c-8d8f-4539-b466-0873d9533e18"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("72dc5aff-dec8-40cc-a776-6ef678822d78"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dceac060-9dfd-467f-85d8-1e7cfc363e6f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cb96e2f6-7374-4896-87de-911e875c698d"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1c3cdd60-31a2-45b4-ab66-5a49e6d31e7a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("66bb7d91-79c3-47bc-8e74-e9cc47f70c0e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("215d1083-c4d5-419f-8805-42ab11296d2f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67718c7d-3b1e-41cd-8b8c-9a282dd54669"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("155ee34d-f940-4016-b698-4c991dc51da2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("217e9ed2-4992-464c-a2f6-eb3fe97236d9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("aabd6375-7ee1-40bf-9284-869416aadcf9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("139707c2-2de0-482e-a0dd-5d18984277c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d5e01af4-eed6-4b79-9b27-6e9df545d4f9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("00befb33-9002-45bf-96fc-6353e8f2011a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1a879c46-fdf8-49dd-9703-7b310a08a86e"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c64afa24-429f-4bc5-add8-5b8525350f17"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7082bd9e-9754-4f9e-a434-da74d5c8dcc2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("546e15ae-1f81-4cad-b5fa-5be4d71ac051"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("88d206d6-6b4d-46c8-95a6-e14f2ecf38c8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("764f0462-c0a5-490f-a9ef-1cffa4e8cf85"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f56653eb-4092-49ae-aaa5-cb59731c0fd1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("526715cd-32a5-4eb4-9ab8-0749c0751ab5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5c4e7e9f-c831-4bc6-b061-a6e3da8caad5"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dede2bef-20c7-4112-8597-5121f02ab466"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("366714d3-6eb9-40bc-89e7-2288b3dd6002"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d93d0e6e-12a5-453c-b30e-c9a07240dfcd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c8dab376-c070-43c0-b8f6-d7197a5fe49b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e490bfc9-4d74-4067-a2f7-c8dffca99cdf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99dc14c7-546c-41a6-bced-de5b60be5792"))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a1a2a917-dd8c-4b64-b758-35af8de7dad4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e329928a-9be3-4c99-b7e5-590542e4ae48"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e51ac135-4e67-410e-9567-eab3005aa6b0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c0da585-d5e4-4f5e-b9f9-0a675f32c8f9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1095f09a-2441-4df3-bd01-99ad54a505dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5e297de7-6945-406d-b805-a97f6f834e0d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dc4ec3e8-4de0-4c30-8304-ad9527bb0887"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e72f1df0-07d3-4de1-a035-9e1854c1a1cf"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ebd5aaa6-8c1d-488d-8971-fab9bc7d8a38"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe99aeed-4881-4d3d-9472-d8f151a6a30d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ed56fa8b-5149-4daa-a3c6-740ffedeabac"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1eec4e57-8ce1-4f93-b176-e4514ac98bc0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a90b3cd6-9f10-44fa-b8be-c51469add645"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("490ce7a5-aefe-41af-b066-68a49357eb65"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40b1bb1b-447f-431c-ba3f-03b0f59351d7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("347cb2b3-ae1a-486b-8448-fe216b797b30"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ed9f07d9-0a9d-4de5-9a52-68f0ff309193"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("afd2b8fb-f0f4-483b-998e-25b5373b9e00"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e60bc055-f4ba-4be2-bdcb-ed8923ae0ea9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9a0a8d1b-93c2-431f-8a2b-6ff4a1edcdbf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4208d7e8-f27f-455d-888d-d280c080f4cb"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd3a94cb-d649-46ac-9b59-2a3b969ac371"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e94f8f04-cea9-42ae-9ced-76868ceb9de0"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d96acf23-df16-41f6-ae42-cb42c55c9fbf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7b7d5fc5-945d-41c2-bcad-53b83100b6ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("8b0e5c4b-c31c-4a8c-91f0-448e0bd506b9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2c6af7e0-d233-47f1-a8db-6f46a48aca31"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ce074c98-1a86-4e9e-b801-af8add93a5c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b075e7f3-1c93-4270-adcb-58b18e47993c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3200843f-86a0-4367-bd34-ce834ce40a88"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6a0b747e-f0d1-4108-93f4-5790c2813ad8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ff1f8405-b0ea-4624-a352-dc2c90ae3af2"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f33f334-91be-40b0-958a-d3f28d39a115"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c977981-758e-41ec-b170-e99a76538705"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("73251874-7b2a-4cd3-991b-014e7fce3c51"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a08f3258-b92f-4e92-98b7-13f995a32415"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9e2e3d3e-0ad4-4cef-b9b5-d796eeaf3549"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e8a74759-73b0-41b1-9016-cb77d7e89091"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ad295ae-cf7c-447d-b3b3-83eceae0e7ee"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9b37868a-aa29-40cd-9a9b-da21582c8322"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b0eeb6ed-5f38-469d-a00b-651ff9261618"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db6ca9e1-1a8f-44fc-867a-2ecd6ce5797f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cce88fa4-0e79-4aa3-aa7a-6b1b4a4daadf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("28aca625-8a8e-4d17-95ba-0a33522f7ecb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0c1229e1-ea48-47fe-bda4-7e2564c54fc8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("431d7b2a-9d20-4862-aac9-969a3d4980b8"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c55292dd-50f3-4063-98ab-8d71b46fed98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0de8c991-7abc-4b2a-ab78-99ede73b3ebf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fedaa793-403f-4314-a8ae-39e7726505ca"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dc3fa27c-8d8f-4539-b466-0873d9533e18"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("72dc5aff-dec8-40cc-a776-6ef678822d78"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dceac060-9dfd-467f-85d8-1e7cfc363e6f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cb96e2f6-7374-4896-87de-911e875c698d"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1c3cdd60-31a2-45b4-ab66-5a49e6d31e7a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("66bb7d91-79c3-47bc-8e74-e9cc47f70c0e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("215d1083-c4d5-419f-8805-42ab11296d2f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67718c7d-3b1e-41cd-8b8c-9a282dd54669"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("155ee34d-f940-4016-b698-4c991dc51da2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("217e9ed2-4992-464c-a2f6-eb3fe97236d9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("aabd6375-7ee1-40bf-9284-869416aadcf9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("139707c2-2de0-482e-a0dd-5d18984277c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d5e01af4-eed6-4b79-9b27-6e9df545d4f9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("00befb33-9002-45bf-96fc-6353e8f2011a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1a879c46-fdf8-49dd-9703-7b310a08a86e"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c64afa24-429f-4bc5-add8-5b8525350f17"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7082bd9e-9754-4f9e-a434-da74d5c8dcc2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("546e15ae-1f81-4cad-b5fa-5be4d71ac051"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("88d206d6-6b4d-46c8-95a6-e14f2ecf38c8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("764f0462-c0a5-490f-a9ef-1cffa4e8cf85"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f56653eb-4092-49ae-aaa5-cb59731c0fd1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("526715cd-32a5-4eb4-9ab8-0749c0751ab5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5c4e7e9f-c831-4bc6-b061-a6e3da8caad5"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dede2bef-20c7-4112-8597-5121f02ab466"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("366714d3-6eb9-40bc-89e7-2288b3dd6002"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d93d0e6e-12a5-453c-b30e-c9a07240dfcd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c8dab376-c070-43c0-b8f6-d7197a5fe49b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e490bfc9-4d74-4067-a2f7-c8dffca99cdf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99dc14c7-546c-41a6-bced-de5b60be5792"))));

            }
        }

#endregion

    }
}


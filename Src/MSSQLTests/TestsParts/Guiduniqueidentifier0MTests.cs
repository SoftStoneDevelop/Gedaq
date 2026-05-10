

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

        private readonly Guiduniqueidentifier0M[] _testData = new Guiduniqueidentifier0M[]
        {
            new Guiduniqueidentifier0M
{
    Id = 4,
    Value = Guid.Parse("e1a99508-16ed-4b99-8304-45d9abe8ffdd"),
    ModelInner = null,
    NullableValue = Guid.Parse("1f456171-3588-4122-96a6-dbe4090c5098"),
},
            new Guiduniqueidentifier0M
{
    Id = 12,
    Value = Guid.Parse("64739fdf-0020-4b30-8355-2f94bd2b6726"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 1,
    Value = Guid.Parse("b365295e-d2b0-4d2c-ad12-afaf3f45f7c0"),
    NullableValue = Guid.Parse("e8110054-bd16-4e9b-940b-62b103dde32f"),
},
    NullableValue = Guid.Parse("1ebc04a5-6132-4210-9aa0-4a07b9fa7fe9"),
},
            new Guiduniqueidentifier0M
{
    Id = 17,
    Value = Guid.Parse("5c04e3ec-e1f4-4ce1-9d7a-a8d92d50d791"),
    ModelInner = null,
    NullableValue = Guid.Parse("10855d22-79fa-4f98-a656-3d01d2c7a94b"),
},
            new Guiduniqueidentifier0M
{
    Id = 20,
    Value = Guid.Parse("7bc0ad09-8077-4a8f-adac-a6dc0e25a204"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 9,
    Value = Guid.Parse("85bb702c-6692-4b2d-a4e3-83f7fadafa8e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 28,
    Value = Guid.Parse("247e7ef7-09fb-49ca-8501-a5dac7e684b9"),
    ModelInner = null,
    NullableValue = Guid.Parse("c22a6335-42ad-48d6-beb5-400f894f2370"),
},
            new Guiduniqueidentifier0M
{
    Id = 36,
    Value = Guid.Parse("07b96637-4f25-4e14-af81-0cda6ee450ca"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 13,
    Value = Guid.Parse("357b87ce-cfb5-4238-b002-d295a7cfc77a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("50ceb8dc-ddb4-4efb-b258-b726fc9aa3e2"),
},
            new Guiduniqueidentifier0M
{
    Id = 38,
    Value = Guid.Parse("8ecdccee-c359-48b0-8723-771177c41d2c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 43,
    Value = Guid.Parse("13900d8a-9bb9-41b3-bca9-8c1051a71975"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 15,
    Value = Guid.Parse("c46d0850-3e69-40c4-9afa-cfce87d7b709"),
    NullableValue = Guid.Parse("75923ff7-5b85-4432-9b50-a4de5c04987e"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 45,
    Value = Guid.Parse("38eb0536-7f1a-45f5-b8ec-bd49a05bf9e9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 50,
    Value = Guid.Parse("7918d71e-c156-49cd-b788-94ea6b14df8c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 20,
    Value = Guid.Parse("d4460030-1757-4525-80dd-ad7f9ede2f1a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 54,
    Value = Guid.Parse("03492f90-695c-4e69-900f-30655a0d645b"),
    ModelInner = null,
    NullableValue = Guid.Parse("43cadd5b-21ba-424e-ac29-7e5a00ad51bc"),
},
            new Guiduniqueidentifier0M
{
    Id = 56,
    Value = Guid.Parse("5b7057c7-13f3-435a-87f7-ff61cc89ed8f"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 22,
    Value = Guid.Parse("ae8e8e4e-f384-4b42-8071-a7962b467a02"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 59,
    Value = Guid.Parse("22c82241-2fa4-4209-b368-e1f35395384d"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 68,
    Value = Guid.Parse("3dd20fdb-db46-4481-8358-7fbe39affde1"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 26,
    Value = Guid.Parse("2262175f-4b0e-49a4-a921-e30315fa1906"),
    NullableValue = Guid.Parse("0d71d40c-8d3d-4857-907e-b9e47de920ef"),
},
    NullableValue = Guid.Parse("9325185c-3c57-4f61-8f80-c3ea5115d470"),
},
            new Guiduniqueidentifier0M
{
    Id = 70,
    Value = Guid.Parse("a82befa4-603c-4efb-ba4b-ef8ec98582be"),
    ModelInner = null,
    NullableValue = Guid.Parse("4ccc2f6b-b509-46e4-999f-3fbcd8692952"),
},
            new Guiduniqueidentifier0M
{
    Id = 71,
    Value = Guid.Parse("f2cdc8e8-55c1-4392-9355-5789edfb5b71"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 27,
    Value = Guid.Parse("def9b1fc-e0e5-4e03-8f6d-296e6e705ebc"),
    NullableValue = Guid.Parse("f32fc3d4-8b12-4b8c-b3e3-01f12d52f053"),
},
    NullableValue = Guid.Parse("caa5852b-4596-4fd2-9a2d-60263741b74f"),
},
            new Guiduniqueidentifier0M
{
    Id = 79,
    Value = Guid.Parse("4087d86c-68b0-4bb7-a4d3-e996a6ca9856"),
    ModelInner = null,
    NullableValue = Guid.Parse("0afc06d6-e58c-4729-bc95-d2e1f5a2820f"),
},
            new Guiduniqueidentifier0M
{
    Id = 87,
    Value = Guid.Parse("82046d05-43d7-48f9-a707-ddaf29539833"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 34,
    Value = Guid.Parse("b109bb70-1b80-4820-96d5-dfeda411477a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 95,
    Value = Guid.Parse("401fe3d3-e89a-42b9-845d-a67ef68f5657"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 100,
    Value = Guid.Parse("b832c6d3-3fec-44c3-94ff-3d7b464bb19c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 35,
    Value = Guid.Parse("3662adff-b469-4f0a-afab-d68188763239"),
    NullableValue = Guid.Parse("cfc90c7c-d44c-414b-871f-66e24d89ea55"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 106,
    Value = Guid.Parse("ad2e822c-814d-436c-9626-9bcf03ccd992"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 107,
    Value = Guid.Parse("d6dd7d28-32d9-49ea-9e48-e9c197324c4a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 40,
    Value = Guid.Parse("a9bb7d18-1bd9-4ea8-87ef-92ace9c030b9"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("81d48678-798f-4fea-855c-8af9b4efe6b0"),
},
            new Guiduniqueidentifier0M
{
    Id = 110,
    Value = Guid.Parse("5f93d491-19e3-41a1-957d-0ca40f57f073"),
    ModelInner = null,
    NullableValue = Guid.Parse("305354c8-a2c2-4265-8d5f-2edff0fb243c"),
},
            new Guiduniqueidentifier0M
{
    Id = 116,
    Value = Guid.Parse("415d8769-1c8c-4149-8f1e-6d0fc3e4afdd"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 49,
    Value = Guid.Parse("2e74ffac-3cd5-465b-9562-999bf0320f2a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 122,
    Value = Guid.Parse("c9de0bb5-dbd0-4dfc-96df-582055716d05"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 125,
    Value = Guid.Parse("55f93c5c-a880-4fac-bef0-cb4ad8a91c21"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 52,
    Value = Guid.Parse("8df0530c-0a51-4710-b12b-fb1b55adc64d"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("59c43a95-5a64-4608-9aaf-b8187447c64b"),
},
            new Guiduniqueidentifier0M
{
    Id = 130,
    Value = Guid.Parse("8a1a0d82-82d1-49d6-b9f0-08e90de9eac5"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 137,
    Value = Guid.Parse("117fdc16-396a-4073-a916-b048332c4ae3"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 53,
    Value = Guid.Parse("90b910a9-3d3f-434a-b163-68abec6f2687"),
    NullableValue = Guid.Parse("3d577af0-98b5-4282-a171-25430fabeb67"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 140,
    Value = Guid.Parse("ceb0a0d9-c0d7-4b98-b939-ab6445b7e344"),
    ModelInner = null,
    NullableValue = Guid.Parse("debd252f-1216-4029-b60a-a3aa1cbce5a5"),
},
            new Guiduniqueidentifier0M
{
    Id = 146,
    Value = Guid.Parse("d3cb9cf8-6758-4251-a49e-05f07ea0e134"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 55,
    Value = Guid.Parse("86680c92-10ba-49ed-a622-11e33d94b45a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 153,
    Value = Guid.Parse("bd49cd33-e0dd-4942-8f07-4b8358396b3f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 159,
    Value = Guid.Parse("74bed0ef-6841-406b-9d27-2386d5ee6232"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 62,
    Value = Guid.Parse("031db654-a8e9-4f27-bbf1-470e77f6a726"),
    NullableValue = Guid.Parse("869c68a2-ce23-44ec-a16a-8405fb954a43"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 163,
    Value = Guid.Parse("8d15c95c-e29d-4a0e-a4c3-f08f1f989be2"),
    ModelInner = null,
    NullableValue = Guid.Parse("3d3cbb70-a6da-4a9f-bd91-b1f1956a42ed"),
},
            new Guiduniqueidentifier0M
{
    Id = 172,
    Value = Guid.Parse("5b404ad7-6c84-4620-97a8-55eca0f2faa4"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 64,
    Value = Guid.Parse("db043c6d-3c05-4fc4-a35f-54f0d6d0808c"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 179,
    Value = Guid.Parse("fff7c53a-66f4-4119-bdc0-00f5a3d45986"),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifier0mi(
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
INSERT INTO dbo.guiduniqueidentifier0mi(
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
INSERT INTO dbo.guiduniqueidentifier0m(
	id,
    value,
    nullablevalue,
    guiduniqueidentifier0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduniqueidentifier0mi_id
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
                parametrName: "guiduniqueidentifier0mi_id", 
                methodParametrName: "guiduniqueidentifier0mi_id", 
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
INSERT INTO dbo.guiduniqueidentifier0m(
	id,
    value,
    nullablevalue,
    guiduniqueidentifier0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduniqueidentifier0mi_id
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
                parametrName: "guiduniqueidentifier0mi_id", 
                methodParametrName: "guiduniqueidentifier0mi_id", 
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
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M), typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                await((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                ((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
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
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guiduniqueidentifier0M)],
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
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M), typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                await((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                ((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guiduniqueidentifier0M)],
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
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M), typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                await((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
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
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 106;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
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
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guiduniqueidentifier0M)],
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
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[34], false);
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
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M), typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                await((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 28, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 140, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 87, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 163, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 4, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 130, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guiduniqueidentifier0M)],
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
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 50, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[34], false);
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
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 38, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[34], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Guiduniqueidentifier0M.AssertModel(models[0],_testData[14], false);
                Guiduniqueidentifier0M.AssertModel(models[1],_testData[15], false);
                Guiduniqueidentifier0M.AssertModel(models[2],_testData[16], false);
                Guiduniqueidentifier0M.AssertModel(models[3],_testData[17], false);
                Guiduniqueidentifier0M.AssertModel(models[4],_testData[18], false);
                Guiduniqueidentifier0M.AssertModel(models[5],_testData[19], false);
                Guiduniqueidentifier0M.AssertModel(models[6],_testData[20], false);
                Guiduniqueidentifier0M.AssertModel(models[7],_testData[21], false);
                Guiduniqueidentifier0M.AssertModel(models[8],_testData[22], false);
                Guiduniqueidentifier0M.AssertModel(models[9],_testData[23], false);
                Guiduniqueidentifier0M.AssertModel(models[10],_testData[24], false);
                Guiduniqueidentifier0M.AssertModel(models[11],_testData[25], false);
                Guiduniqueidentifier0M.AssertModel(models[12],_testData[26], false);
                Guiduniqueidentifier0M.AssertModel(models[13],_testData[27], false);
                Guiduniqueidentifier0M.AssertModel(models[14],_testData[28], false);
                Guiduniqueidentifier0M.AssertModel(models[15],_testData[29], false);
                Guiduniqueidentifier0M.AssertModel(models[16],_testData[30], false);
                Guiduniqueidentifier0M.AssertModel(models[17],_testData[31], false);
                Guiduniqueidentifier0M.AssertModel(models[18],_testData[32], false);
                Guiduniqueidentifier0M.AssertModel(models[19],_testData[33], false);
                Guiduniqueidentifier0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                Guiduniqueidentifier0M.AssertModel(models[0],_testData[18], false);
                Guiduniqueidentifier0M.AssertModel(models[1],_testData[19], false);
                Guiduniqueidentifier0M.AssertModel(models[2],_testData[20], false);
                Guiduniqueidentifier0M.AssertModel(models[3],_testData[21], false);
                Guiduniqueidentifier0M.AssertModel(models[4],_testData[22], false);
                Guiduniqueidentifier0M.AssertModel(models[5],_testData[23], false);
                Guiduniqueidentifier0M.AssertModel(models[6],_testData[24], false);
                Guiduniqueidentifier0M.AssertModel(models[7],_testData[25], false);
                Guiduniqueidentifier0M.AssertModel(models[8],_testData[26], false);
                Guiduniqueidentifier0M.AssertModel(models[9],_testData[27], false);
                Guiduniqueidentifier0M.AssertModel(models[10],_testData[28], false);
                Guiduniqueidentifier0M.AssertModel(models[11],_testData[29], false);
                Guiduniqueidentifier0M.AssertModel(models[12],_testData[30], false);
                Guiduniqueidentifier0M.AssertModel(models[13],_testData[31], false);
                Guiduniqueidentifier0M.AssertModel(models[14],_testData[32], false);
                Guiduniqueidentifier0M.AssertModel(models[15],_testData[33], false);
                Guiduniqueidentifier0M.AssertModel(models[16],_testData[34], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e1a99508-16ed-4b99-8304-45d9abe8ffdd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1f456171-3588-4122-96a6-dbe4090c5098"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("64739fdf-0020-4b30-8355-2f94bd2b6726"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b365295e-d2b0-4d2c-ad12-afaf3f45f7c0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e8110054-bd16-4e9b-940b-62b103dde32f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1ebc04a5-6132-4210-9aa0-4a07b9fa7fe9"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5c04e3ec-e1f4-4ce1-9d7a-a8d92d50d791"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("10855d22-79fa-4f98-a656-3d01d2c7a94b"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7bc0ad09-8077-4a8f-adac-a6dc0e25a204"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("85bb702c-6692-4b2d-a4e3-83f7fadafa8e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("247e7ef7-09fb-49ca-8501-a5dac7e684b9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c22a6335-42ad-48d6-beb5-400f894f2370"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("07b96637-4f25-4e14-af81-0cda6ee450ca"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("357b87ce-cfb5-4238-b002-d295a7cfc77a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("50ceb8dc-ddb4-4efb-b258-b726fc9aa3e2"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ecdccee-c359-48b0-8723-771177c41d2c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("13900d8a-9bb9-41b3-bca9-8c1051a71975"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c46d0850-3e69-40c4-9afa-cfce87d7b709"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("75923ff7-5b85-4432-9b50-a4de5c04987e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("38eb0536-7f1a-45f5-b8ec-bd49a05bf9e9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7918d71e-c156-49cd-b788-94ea6b14df8c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d4460030-1757-4525-80dd-ad7f9ede2f1a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03492f90-695c-4e69-900f-30655a0d645b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("43cadd5b-21ba-424e-ac29-7e5a00ad51bc"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5b7057c7-13f3-435a-87f7-ff61cc89ed8f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ae8e8e4e-f384-4b42-8071-a7962b467a02"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("22c82241-2fa4-4209-b368-e1f35395384d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3dd20fdb-db46-4481-8358-7fbe39affde1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2262175f-4b0e-49a4-a921-e30315fa1906"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0d71d40c-8d3d-4857-907e-b9e47de920ef"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9325185c-3c57-4f61-8f80-c3ea5115d470"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a82befa4-603c-4efb-ba4b-ef8ec98582be"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4ccc2f6b-b509-46e4-999f-3fbcd8692952"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2cdc8e8-55c1-4392-9355-5789edfb5b71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("def9b1fc-e0e5-4e03-8f6d-296e6e705ebc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f32fc3d4-8b12-4b8c-b3e3-01f12d52f053"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("caa5852b-4596-4fd2-9a2d-60263741b74f"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4087d86c-68b0-4bb7-a4d3-e996a6ca9856"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0afc06d6-e58c-4729-bc95-d2e1f5a2820f"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("82046d05-43d7-48f9-a707-ddaf29539833"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b109bb70-1b80-4820-96d5-dfeda411477a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("401fe3d3-e89a-42b9-845d-a67ef68f5657"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b832c6d3-3fec-44c3-94ff-3d7b464bb19c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3662adff-b469-4f0a-afab-d68188763239"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cfc90c7c-d44c-414b-871f-66e24d89ea55"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad2e822c-814d-436c-9626-9bcf03ccd992"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6dd7d28-32d9-49ea-9e48-e9c197324c4a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a9bb7d18-1bd9-4ea8-87ef-92ace9c030b9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("81d48678-798f-4fea-855c-8af9b4efe6b0"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5f93d491-19e3-41a1-957d-0ca40f57f073"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("305354c8-a2c2-4265-8d5f-2edff0fb243c"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("415d8769-1c8c-4149-8f1e-6d0fc3e4afdd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2e74ffac-3cd5-465b-9562-999bf0320f2a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9de0bb5-dbd0-4dfc-96df-582055716d05"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("55f93c5c-a880-4fac-bef0-cb4ad8a91c21"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8df0530c-0a51-4710-b12b-fb1b55adc64d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("59c43a95-5a64-4608-9aaf-b8187447c64b"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a1a0d82-82d1-49d6-b9f0-08e90de9eac5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("117fdc16-396a-4073-a916-b048332c4ae3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("90b910a9-3d3f-434a-b163-68abec6f2687"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3d577af0-98b5-4282-a171-25430fabeb67"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ceb0a0d9-c0d7-4b98-b939-ab6445b7e344"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("debd252f-1216-4029-b60a-a3aa1cbce5a5"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d3cb9cf8-6758-4251-a49e-05f07ea0e134"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("86680c92-10ba-49ed-a622-11e33d94b45a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bd49cd33-e0dd-4942-8f07-4b8358396b3f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("74bed0ef-6841-406b-9d27-2386d5ee6232"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("031db654-a8e9-4f27-bbf1-470e77f6a726"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("869c68a2-ce23-44ec-a16a-8405fb954a43"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8d15c95c-e29d-4a0e-a4c3-f08f1f989be2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3d3cbb70-a6da-4a9f-bd91-b1f1956a42ed"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5b404ad7-6c84-4620-97a8-55eca0f2faa4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("db043c6d-3c05-4fc4-a35f-54f0d6d0808c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fff7c53a-66f4-4119-bdc0-00f5a3d45986"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e1a99508-16ed-4b99-8304-45d9abe8ffdd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1f456171-3588-4122-96a6-dbe4090c5098"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("64739fdf-0020-4b30-8355-2f94bd2b6726"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b365295e-d2b0-4d2c-ad12-afaf3f45f7c0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e8110054-bd16-4e9b-940b-62b103dde32f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1ebc04a5-6132-4210-9aa0-4a07b9fa7fe9"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5c04e3ec-e1f4-4ce1-9d7a-a8d92d50d791"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("10855d22-79fa-4f98-a656-3d01d2c7a94b"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7bc0ad09-8077-4a8f-adac-a6dc0e25a204"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("85bb702c-6692-4b2d-a4e3-83f7fadafa8e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("247e7ef7-09fb-49ca-8501-a5dac7e684b9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c22a6335-42ad-48d6-beb5-400f894f2370"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("07b96637-4f25-4e14-af81-0cda6ee450ca"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("357b87ce-cfb5-4238-b002-d295a7cfc77a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("50ceb8dc-ddb4-4efb-b258-b726fc9aa3e2"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ecdccee-c359-48b0-8723-771177c41d2c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("13900d8a-9bb9-41b3-bca9-8c1051a71975"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c46d0850-3e69-40c4-9afa-cfce87d7b709"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("75923ff7-5b85-4432-9b50-a4de5c04987e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("38eb0536-7f1a-45f5-b8ec-bd49a05bf9e9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7918d71e-c156-49cd-b788-94ea6b14df8c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d4460030-1757-4525-80dd-ad7f9ede2f1a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03492f90-695c-4e69-900f-30655a0d645b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("43cadd5b-21ba-424e-ac29-7e5a00ad51bc"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5b7057c7-13f3-435a-87f7-ff61cc89ed8f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ae8e8e4e-f384-4b42-8071-a7962b467a02"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("22c82241-2fa4-4209-b368-e1f35395384d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3dd20fdb-db46-4481-8358-7fbe39affde1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2262175f-4b0e-49a4-a921-e30315fa1906"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0d71d40c-8d3d-4857-907e-b9e47de920ef"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9325185c-3c57-4f61-8f80-c3ea5115d470"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a82befa4-603c-4efb-ba4b-ef8ec98582be"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4ccc2f6b-b509-46e4-999f-3fbcd8692952"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2cdc8e8-55c1-4392-9355-5789edfb5b71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("def9b1fc-e0e5-4e03-8f6d-296e6e705ebc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f32fc3d4-8b12-4b8c-b3e3-01f12d52f053"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("caa5852b-4596-4fd2-9a2d-60263741b74f"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4087d86c-68b0-4bb7-a4d3-e996a6ca9856"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0afc06d6-e58c-4729-bc95-d2e1f5a2820f"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("82046d05-43d7-48f9-a707-ddaf29539833"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b109bb70-1b80-4820-96d5-dfeda411477a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("401fe3d3-e89a-42b9-845d-a67ef68f5657"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b832c6d3-3fec-44c3-94ff-3d7b464bb19c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3662adff-b469-4f0a-afab-d68188763239"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cfc90c7c-d44c-414b-871f-66e24d89ea55"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad2e822c-814d-436c-9626-9bcf03ccd992"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6dd7d28-32d9-49ea-9e48-e9c197324c4a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a9bb7d18-1bd9-4ea8-87ef-92ace9c030b9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("81d48678-798f-4fea-855c-8af9b4efe6b0"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5f93d491-19e3-41a1-957d-0ca40f57f073"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("305354c8-a2c2-4265-8d5f-2edff0fb243c"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("415d8769-1c8c-4149-8f1e-6d0fc3e4afdd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2e74ffac-3cd5-465b-9562-999bf0320f2a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9de0bb5-dbd0-4dfc-96df-582055716d05"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("55f93c5c-a880-4fac-bef0-cb4ad8a91c21"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8df0530c-0a51-4710-b12b-fb1b55adc64d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("59c43a95-5a64-4608-9aaf-b8187447c64b"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a1a0d82-82d1-49d6-b9f0-08e90de9eac5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("117fdc16-396a-4073-a916-b048332c4ae3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("90b910a9-3d3f-434a-b163-68abec6f2687"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3d577af0-98b5-4282-a171-25430fabeb67"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ceb0a0d9-c0d7-4b98-b939-ab6445b7e344"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("debd252f-1216-4029-b60a-a3aa1cbce5a5"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d3cb9cf8-6758-4251-a49e-05f07ea0e134"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("86680c92-10ba-49ed-a622-11e33d94b45a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bd49cd33-e0dd-4942-8f07-4b8358396b3f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("74bed0ef-6841-406b-9d27-2386d5ee6232"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("031db654-a8e9-4f27-bbf1-470e77f6a726"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("869c68a2-ce23-44ec-a16a-8405fb954a43"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8d15c95c-e29d-4a0e-a4c3-f08f1f989be2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3d3cbb70-a6da-4a9f-bd91-b1f1956a42ed"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5b404ad7-6c84-4620-97a8-55eca0f2faa4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("db043c6d-3c05-4fc4-a35f-54f0d6d0808c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fff7c53a-66f4-4119-bdc0-00f5a3d45986"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


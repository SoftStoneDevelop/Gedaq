

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
    Id = 6,
    Value = Guid.Parse("954877ec-401f-41a1-b0e5-3f7cfb490acf"),
    ModelInner = null,
    NullableValue = Guid.Parse("5d1a2a99-544b-4116-a093-26110cc4b377"),
},
            new GuiduniqueidentifierE0M
{
    Id = 15,
    Value = Guid.Parse("5ee0ef17-6bf7-4b5b-aab9-18661fc72c03"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 6,
    Value = Guid.Parse("d65d6f3e-a479-4536-a19f-7559a5be4c1b"),
    NullableValue = Guid.Parse("b73e8760-1c2b-4510-b046-ed4810977063"),
},
    NullableValue = Guid.Parse("823cf116-2cc2-4ee4-ab5a-1407cd91b8ef"),
},
            new GuiduniqueidentifierE0M
{
    Id = 22,
    Value = Guid.Parse("5510c147-1e8d-428e-8fb4-03dbaee21679"),
    ModelInner = null,
    NullableValue = Guid.Parse("2641b719-4540-4443-a914-93d3fc71e098"),
},
            new GuiduniqueidentifierE0M
{
    Id = 27,
    Value = Guid.Parse("6ba7259d-4ac5-409f-91c4-3f9ead1bc62a"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 15,
    Value = Guid.Parse("058f2444-504e-4f6c-8430-6f589d4ce29a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2264c8cb-4588-4d77-841e-78fb79d1f3ba"),
},
            new GuiduniqueidentifierE0M
{
    Id = 30,
    Value = Guid.Parse("2044e59d-2552-43da-9858-7ac2c18d8892"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 34,
    Value = Guid.Parse("142a4c1e-0161-48b8-806b-c8fa3de87d18"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 19,
    Value = Guid.Parse("7cd96685-d699-4132-9528-4976759c6833"),
    NullableValue = Guid.Parse("61b8554e-2e0a-4ef7-86fa-7b590a5f2664"),
},
    NullableValue = Guid.Parse("a2ae244e-d6f7-4456-8764-7f8054a9d292"),
},
            new GuiduniqueidentifierE0M
{
    Id = 42,
    Value = Guid.Parse("2da32aa6-7d12-44dd-9ecb-e60ac8add57b"),
    ModelInner = null,
    NullableValue = Guid.Parse("ba19b77d-5802-43c6-bcb5-7fe17eee5e1d"),
},
            new GuiduniqueidentifierE0M
{
    Id = 50,
    Value = Guid.Parse("a449a865-8f1e-4cd1-b46e-a09814c0d4b3"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 27,
    Value = Guid.Parse("7f5a1e14-4d90-437c-be53-2dd33c1f5025"),
    NullableValue = Guid.Parse("844260cd-2814-4bcb-86e3-0d903ce4ce1d"),
},
    NullableValue = Guid.Parse("2c1e52ce-e603-49f7-a606-ec56452e22b9"),
},
            new GuiduniqueidentifierE0M
{
    Id = 59,
    Value = Guid.Parse("8b43b71c-b9d8-47a7-86b2-b3d9c014052a"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 67,
    Value = Guid.Parse("bad3fc28-2355-423f-9740-447ec554c845"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 28,
    Value = Guid.Parse("d1405ef2-daf5-41fc-ae34-878f1b9065c6"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f86557f4-8496-4d4f-a0a7-7bbad22f3d31"),
},
            new GuiduniqueidentifierE0M
{
    Id = 73,
    Value = Guid.Parse("e422c91c-d7c1-4cad-9d12-2d2fe2fabd75"),
    ModelInner = null,
    NullableValue = Guid.Parse("7ac14ea0-d82d-48c2-9b6c-329a09d9bfc0"),
},
            new GuiduniqueidentifierE0M
{
    Id = 76,
    Value = Guid.Parse("d5cb2e64-4539-4f1b-bfe5-ed1993246e6d"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 29,
    Value = Guid.Parse("2a6906be-6fd5-4ae6-9546-64e366332fae"),
    NullableValue = Guid.Parse("67431b52-f152-4e61-b9bd-18a9b300ff84"),
},
    NullableValue = Guid.Parse("53505b9b-4b13-4b3e-84c6-ce3c12453f09"),
},
            new GuiduniqueidentifierE0M
{
    Id = 77,
    Value = Guid.Parse("7d691e19-626a-4740-bed0-9568ef0bc8a8"),
    ModelInner = null,
    NullableValue = Guid.Parse("4c16b7d9-5d87-4b89-8f17-638705b5a1af"),
},
            new GuiduniqueidentifierE0M
{
    Id = 80,
    Value = Guid.Parse("5be5261e-b2c3-49f2-a98b-00cb68303042"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 34,
    Value = Guid.Parse("78908b35-01eb-418a-9959-6093b5b65c4a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 83,
    Value = Guid.Parse("89c4b888-b6f6-4daf-b5e6-a0de34eb9ea2"),
    ModelInner = null,
    NullableValue = Guid.Parse("c18512ad-62a9-4bf1-ac8f-6e0a59ef0247"),
},
            new GuiduniqueidentifierE0M
{
    Id = 89,
    Value = Guid.Parse("04b988ac-19cd-442c-b6dc-4abf0dc8ec85"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 43,
    Value = Guid.Parse("dcd6ec08-7163-474d-93e4-96ab7db3ef24"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("47fd8701-907c-4ced-a8ef-9471fe81c880"),
},
            new GuiduniqueidentifierE0M
{
    Id = 90,
    Value = Guid.Parse("c9b9a8cc-3f41-4071-aed1-09e8f15e148c"),
    ModelInner = null,
    NullableValue = Guid.Parse("4d4c07b9-86e4-4bcc-8765-0ea60048a980"),
},
            new GuiduniqueidentifierE0M
{
    Id = 96,
    Value = Guid.Parse("bbef46a2-19a1-4f69-bbc1-f304c81e69fb"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 45,
    Value = Guid.Parse("6bd2a6d5-737a-4a88-b350-da24b0507e18"),
    NullableValue = Guid.Parse("5e7908c2-f3ee-42d0-9109-88cb2f552605"),
},
    NullableValue = Guid.Parse("318df49a-ce56-4ae6-a2cd-d7384fee420e"),
},
            new GuiduniqueidentifierE0M
{
    Id = 105,
    Value = Guid.Parse("c3557e8a-f885-406f-ba8f-791f1de3ab1d"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 107,
    Value = Guid.Parse("09216daa-b91b-4682-9cbc-c79ed4d2df60"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 54,
    Value = Guid.Parse("431fa9a5-4104-4027-996c-b0230a452659"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("3fb5236b-8996-4806-843a-ee539b3869cc"),
},
            new GuiduniqueidentifierE0M
{
    Id = 109,
    Value = Guid.Parse("71102c4c-d91e-4961-bc6f-84f74e7c2e84"),
    ModelInner = null,
    NullableValue = Guid.Parse("5aa37069-b9cf-4210-a06b-04efa74f436b"),
},
            new GuiduniqueidentifierE0M
{
    Id = 117,
    Value = Guid.Parse("859c8b36-3dcb-43ab-a5d3-f6d9d052a43d"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 62,
    Value = Guid.Parse("ce18dd92-7231-4bfd-8211-08c9f9bf93d8"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 126,
    Value = Guid.Parse("7f42566c-35d6-4b0b-86a1-a3d71d810239"),
    ModelInner = null,
    NullableValue = Guid.Parse("3f3b8fea-c03a-4257-9715-3bacdae4f904"),
},
            new GuiduniqueidentifierE0M
{
    Id = 127,
    Value = Guid.Parse("174f8581-5c6e-4f02-9841-710cb5fbb4f6"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 70,
    Value = Guid.Parse("b97e92fb-eee7-4f0b-85db-30778f674ed2"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("23da1200-3301-40e4-bec6-8913e4e69e66"),
},
            new GuiduniqueidentifierE0M
{
    Id = 136,
    Value = Guid.Parse("fe7eeabb-b54f-4186-8f00-c58580f4182b"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 139,
    Value = Guid.Parse("b3554d8d-9afe-476c-b1fd-4ca0e38c8318"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 78,
    Value = Guid.Parse("aa979220-61fc-4050-959e-dd94364e8a6b"),
    NullableValue = Guid.Parse("95f2686d-4748-4df2-b729-e0c4048ee796"),
},
    NullableValue = Guid.Parse("beb3022d-2438-42d2-b03b-2d4dced272a6"),
},
            new GuiduniqueidentifierE0M
{
    Id = 143,
    Value = Guid.Parse("ad891fb5-730b-4985-a4e0-af90bb517061"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 146,
    Value = Guid.Parse("c0a4eb00-67c2-458e-88a6-2212cb7297a0"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 83,
    Value = Guid.Parse("1a252139-bf2b-4f44-af14-1281a9d331d0"),
    NullableValue = Guid.Parse("6db06cab-12bf-4899-9751-002c2ef82d98"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 155,
    Value = Guid.Parse("a03d33c0-8c3a-475f-8e44-eac529864955"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 163,
    Value = Guid.Parse("22105b5e-9417-4c39-9431-6ea850e83ef6"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 85,
    Value = Guid.Parse("9817700b-2ede-41ba-804f-ecab43240c1c"),
    NullableValue = Guid.Parse("fa10f148-b0fc-4fc1-9384-25617243be68"),
},
    NullableValue = Guid.Parse("e05af626-3a56-4110-b3a5-1a8d137e65f1"),
},
            new GuiduniqueidentifierE0M
{
    Id = 172,
    Value = Guid.Parse("fa0d8de8-d0df-44c6-9684-5afc147f748b"),
    ModelInner = null,
    NullableValue = Guid.Parse("5aba75d7-c727-4d90-b8cb-4661a76cec89"),
},
            new GuiduniqueidentifierE0M
{
    Id = 178,
    Value = Guid.Parse("c10f3ae4-18e7-4948-9e22-17db8cc04eaf"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 90,
    Value = Guid.Parse("a91f2cf8-5711-4154-9ea0-ddbfc7601410"),
    NullableValue = Guid.Parse("333e14e9-4c08-4576-9a19-5fff3d2c6a04"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 184,
    Value = Guid.Parse("4690e282-ff68-414c-addf-37bf6526e341"),
    ModelInner = null,
    NullableValue = Guid.Parse("4a26c51e-3894-4f83-ac42-4b77a679e38c"),
},
            new GuiduniqueidentifierE0M
{
    Id = 187,
    Value = Guid.Parse("5bf44205-4407-4e8a-b823-5d849f12224a"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 99,
    Value = Guid.Parse("0ff0646b-e7fd-422a-9b92-99b5013fd2cc"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e533ee74-d5a9-4ff2-98cc-b7f147f6b1f2"),
},
            new GuiduniqueidentifierE0M
{
    Id = 190,
    Value = Guid.Parse("54980021-adcc-46f2-8fb8-d779509b2ee6"),
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 184;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 107, query1, 178, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 30, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[32],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 184, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 83, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[32],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 22, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 76, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 107, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 146, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[5], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[6], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[28],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[29],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 83, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[6], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[28],_testData[34], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 143);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[27], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[28], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[6],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("954877ec-401f-41a1-b0e5-3f7cfb490acf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5d1a2a99-544b-4116-a093-26110cc4b377"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5ee0ef17-6bf7-4b5b-aab9-18661fc72c03"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d65d6f3e-a479-4536-a19f-7559a5be4c1b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b73e8760-1c2b-4510-b046-ed4810977063"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("823cf116-2cc2-4ee4-ab5a-1407cd91b8ef"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5510c147-1e8d-428e-8fb4-03dbaee21679"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2641b719-4540-4443-a914-93d3fc71e098"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6ba7259d-4ac5-409f-91c4-3f9ead1bc62a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("058f2444-504e-4f6c-8430-6f589d4ce29a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2264c8cb-4588-4d77-841e-78fb79d1f3ba"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2044e59d-2552-43da-9858-7ac2c18d8892"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("142a4c1e-0161-48b8-806b-c8fa3de87d18"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7cd96685-d699-4132-9528-4976759c6833"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("61b8554e-2e0a-4ef7-86fa-7b590a5f2664"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a2ae244e-d6f7-4456-8764-7f8054a9d292"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2da32aa6-7d12-44dd-9ecb-e60ac8add57b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ba19b77d-5802-43c6-bcb5-7fe17eee5e1d"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a449a865-8f1e-4cd1-b46e-a09814c0d4b3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7f5a1e14-4d90-437c-be53-2dd33c1f5025"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("844260cd-2814-4bcb-86e3-0d903ce4ce1d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2c1e52ce-e603-49f7-a606-ec56452e22b9"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b43b71c-b9d8-47a7-86b2-b3d9c014052a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bad3fc28-2355-423f-9740-447ec554c845"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d1405ef2-daf5-41fc-ae34-878f1b9065c6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f86557f4-8496-4d4f-a0a7-7bbad22f3d31"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e422c91c-d7c1-4cad-9d12-2d2fe2fabd75"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7ac14ea0-d82d-48c2-9b6c-329a09d9bfc0"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d5cb2e64-4539-4f1b-bfe5-ed1993246e6d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2a6906be-6fd5-4ae6-9546-64e366332fae"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("67431b52-f152-4e61-b9bd-18a9b300ff84"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("53505b9b-4b13-4b3e-84c6-ce3c12453f09"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7d691e19-626a-4740-bed0-9568ef0bc8a8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c16b7d9-5d87-4b89-8f17-638705b5a1af"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5be5261e-b2c3-49f2-a98b-00cb68303042"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("78908b35-01eb-418a-9959-6093b5b65c4a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("89c4b888-b6f6-4daf-b5e6-a0de34eb9ea2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c18512ad-62a9-4bf1-ac8f-6e0a59ef0247"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("04b988ac-19cd-442c-b6dc-4abf0dc8ec85"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dcd6ec08-7163-474d-93e4-96ab7db3ef24"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("47fd8701-907c-4ced-a8ef-9471fe81c880"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9b9a8cc-3f41-4071-aed1-09e8f15e148c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4d4c07b9-86e4-4bcc-8765-0ea60048a980"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bbef46a2-19a1-4f69-bbc1-f304c81e69fb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6bd2a6d5-737a-4a88-b350-da24b0507e18"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5e7908c2-f3ee-42d0-9109-88cb2f552605"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("318df49a-ce56-4ae6-a2cd-d7384fee420e"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c3557e8a-f885-406f-ba8f-791f1de3ab1d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("09216daa-b91b-4682-9cbc-c79ed4d2df60"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("431fa9a5-4104-4027-996c-b0230a452659"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3fb5236b-8996-4806-843a-ee539b3869cc"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("71102c4c-d91e-4961-bc6f-84f74e7c2e84"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5aa37069-b9cf-4210-a06b-04efa74f436b"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("859c8b36-3dcb-43ab-a5d3-f6d9d052a43d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ce18dd92-7231-4bfd-8211-08c9f9bf93d8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f42566c-35d6-4b0b-86a1-a3d71d810239"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3f3b8fea-c03a-4257-9715-3bacdae4f904"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("174f8581-5c6e-4f02-9841-710cb5fbb4f6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b97e92fb-eee7-4f0b-85db-30778f674ed2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("23da1200-3301-40e4-bec6-8913e4e69e66"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe7eeabb-b54f-4186-8f00-c58580f4182b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b3554d8d-9afe-476c-b1fd-4ca0e38c8318"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("aa979220-61fc-4050-959e-dd94364e8a6b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("95f2686d-4748-4df2-b729-e0c4048ee796"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("beb3022d-2438-42d2-b03b-2d4dced272a6"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad891fb5-730b-4985-a4e0-af90bb517061"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c0a4eb00-67c2-458e-88a6-2212cb7297a0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1a252139-bf2b-4f44-af14-1281a9d331d0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6db06cab-12bf-4899-9751-002c2ef82d98"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a03d33c0-8c3a-475f-8e44-eac529864955"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("22105b5e-9417-4c39-9431-6ea850e83ef6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9817700b-2ede-41ba-804f-ecab43240c1c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fa10f148-b0fc-4fc1-9384-25617243be68"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e05af626-3a56-4110-b3a5-1a8d137e65f1"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fa0d8de8-d0df-44c6-9684-5afc147f748b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5aba75d7-c727-4d90-b8cb-4661a76cec89"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c10f3ae4-18e7-4948-9e22-17db8cc04eaf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a91f2cf8-5711-4154-9ea0-ddbfc7601410"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("333e14e9-4c08-4576-9a19-5fff3d2c6a04"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4690e282-ff68-414c-addf-37bf6526e341"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4a26c51e-3894-4f83-ac42-4b77a679e38c"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5bf44205-4407-4e8a-b823-5d849f12224a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0ff0646b-e7fd-422a-9b92-99b5013fd2cc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e533ee74-d5a9-4ff2-98cc-b7f147f6b1f2"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("54980021-adcc-46f2-8fb8-d779509b2ee6"))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("954877ec-401f-41a1-b0e5-3f7cfb490acf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5d1a2a99-544b-4116-a093-26110cc4b377"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5ee0ef17-6bf7-4b5b-aab9-18661fc72c03"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d65d6f3e-a479-4536-a19f-7559a5be4c1b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b73e8760-1c2b-4510-b046-ed4810977063"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("823cf116-2cc2-4ee4-ab5a-1407cd91b8ef"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5510c147-1e8d-428e-8fb4-03dbaee21679"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2641b719-4540-4443-a914-93d3fc71e098"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6ba7259d-4ac5-409f-91c4-3f9ead1bc62a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("058f2444-504e-4f6c-8430-6f589d4ce29a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2264c8cb-4588-4d77-841e-78fb79d1f3ba"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2044e59d-2552-43da-9858-7ac2c18d8892"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("142a4c1e-0161-48b8-806b-c8fa3de87d18"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7cd96685-d699-4132-9528-4976759c6833"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("61b8554e-2e0a-4ef7-86fa-7b590a5f2664"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a2ae244e-d6f7-4456-8764-7f8054a9d292"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2da32aa6-7d12-44dd-9ecb-e60ac8add57b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ba19b77d-5802-43c6-bcb5-7fe17eee5e1d"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a449a865-8f1e-4cd1-b46e-a09814c0d4b3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7f5a1e14-4d90-437c-be53-2dd33c1f5025"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("844260cd-2814-4bcb-86e3-0d903ce4ce1d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2c1e52ce-e603-49f7-a606-ec56452e22b9"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b43b71c-b9d8-47a7-86b2-b3d9c014052a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bad3fc28-2355-423f-9740-447ec554c845"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d1405ef2-daf5-41fc-ae34-878f1b9065c6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f86557f4-8496-4d4f-a0a7-7bbad22f3d31"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e422c91c-d7c1-4cad-9d12-2d2fe2fabd75"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7ac14ea0-d82d-48c2-9b6c-329a09d9bfc0"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d5cb2e64-4539-4f1b-bfe5-ed1993246e6d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2a6906be-6fd5-4ae6-9546-64e366332fae"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("67431b52-f152-4e61-b9bd-18a9b300ff84"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("53505b9b-4b13-4b3e-84c6-ce3c12453f09"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7d691e19-626a-4740-bed0-9568ef0bc8a8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c16b7d9-5d87-4b89-8f17-638705b5a1af"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5be5261e-b2c3-49f2-a98b-00cb68303042"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("78908b35-01eb-418a-9959-6093b5b65c4a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("89c4b888-b6f6-4daf-b5e6-a0de34eb9ea2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c18512ad-62a9-4bf1-ac8f-6e0a59ef0247"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("04b988ac-19cd-442c-b6dc-4abf0dc8ec85"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dcd6ec08-7163-474d-93e4-96ab7db3ef24"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("47fd8701-907c-4ced-a8ef-9471fe81c880"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9b9a8cc-3f41-4071-aed1-09e8f15e148c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4d4c07b9-86e4-4bcc-8765-0ea60048a980"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bbef46a2-19a1-4f69-bbc1-f304c81e69fb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6bd2a6d5-737a-4a88-b350-da24b0507e18"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5e7908c2-f3ee-42d0-9109-88cb2f552605"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("318df49a-ce56-4ae6-a2cd-d7384fee420e"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c3557e8a-f885-406f-ba8f-791f1de3ab1d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("09216daa-b91b-4682-9cbc-c79ed4d2df60"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("431fa9a5-4104-4027-996c-b0230a452659"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3fb5236b-8996-4806-843a-ee539b3869cc"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("71102c4c-d91e-4961-bc6f-84f74e7c2e84"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5aa37069-b9cf-4210-a06b-04efa74f436b"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("859c8b36-3dcb-43ab-a5d3-f6d9d052a43d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ce18dd92-7231-4bfd-8211-08c9f9bf93d8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f42566c-35d6-4b0b-86a1-a3d71d810239"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3f3b8fea-c03a-4257-9715-3bacdae4f904"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("174f8581-5c6e-4f02-9841-710cb5fbb4f6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b97e92fb-eee7-4f0b-85db-30778f674ed2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("23da1200-3301-40e4-bec6-8913e4e69e66"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe7eeabb-b54f-4186-8f00-c58580f4182b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b3554d8d-9afe-476c-b1fd-4ca0e38c8318"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("aa979220-61fc-4050-959e-dd94364e8a6b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("95f2686d-4748-4df2-b729-e0c4048ee796"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("beb3022d-2438-42d2-b03b-2d4dced272a6"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad891fb5-730b-4985-a4e0-af90bb517061"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c0a4eb00-67c2-458e-88a6-2212cb7297a0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1a252139-bf2b-4f44-af14-1281a9d331d0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6db06cab-12bf-4899-9751-002c2ef82d98"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a03d33c0-8c3a-475f-8e44-eac529864955"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("22105b5e-9417-4c39-9431-6ea850e83ef6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9817700b-2ede-41ba-804f-ecab43240c1c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fa10f148-b0fc-4fc1-9384-25617243be68"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e05af626-3a56-4110-b3a5-1a8d137e65f1"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fa0d8de8-d0df-44c6-9684-5afc147f748b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5aba75d7-c727-4d90-b8cb-4661a76cec89"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c10f3ae4-18e7-4948-9e22-17db8cc04eaf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a91f2cf8-5711-4154-9ea0-ddbfc7601410"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("333e14e9-4c08-4576-9a19-5fff3d2c6a04"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4690e282-ff68-414c-addf-37bf6526e341"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4a26c51e-3894-4f83-ac42-4b77a679e38c"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5bf44205-4407-4e8a-b823-5d849f12224a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0ff0646b-e7fd-422a-9b92-99b5013fd2cc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e533ee74-d5a9-4ff2-98cc-b7f147f6b1f2"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("54980021-adcc-46f2-8fb8-d779509b2ee6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}




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
    Id = 3,
    Value = Guid.Parse("4b9edb12-168b-4728-a35e-a42dbc668eeb"),
    ModelInner = null,
    NullableValue = Guid.Parse("ebb5a20e-b242-473b-9feb-4386031b20cf"),
},
            new Guiduniqueidentifier0M
{
    Id = 11,
    Value = Guid.Parse("79a7b445-5db1-430c-8731-4872926c19aa"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 6,
    Value = Guid.Parse("68cd8887-ed9d-46c5-8cfc-6cd0d4571bcc"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 13,
    Value = Guid.Parse("fc9e2c91-19a4-4cb7-a189-7c08e9ca6859"),
    ModelInner = null,
    NullableValue = Guid.Parse("2b2087f0-45a1-4174-83b6-3849f0a902c9"),
},
            new Guiduniqueidentifier0M
{
    Id = 20,
    Value = Guid.Parse("068945a5-76b3-4b65-a3b7-b90b9e82d6b5"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 9,
    Value = Guid.Parse("d2b61f25-e678-4374-bb5e-82c37515bd20"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("26113735-06f7-4f01-b276-01265683a275"),
},
            new Guiduniqueidentifier0M
{
    Id = 24,
    Value = Guid.Parse("2ff58f03-74eb-4187-b747-6676781e7a7b"),
    ModelInner = null,
    NullableValue = Guid.Parse("7340cc65-7a8f-4023-8a91-45c8eab95cb8"),
},
            new Guiduniqueidentifier0M
{
    Id = 27,
    Value = Guid.Parse("4a55e4b8-878d-4b97-88e5-5f059837a174"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 14,
    Value = Guid.Parse("acd4947a-ab5b-44a9-ac89-f823f09aa14c"),
    NullableValue = Guid.Parse("98a8aef4-743f-4b74-a332-25b8346727e0"),
},
    NullableValue = Guid.Parse("e6da7cef-97c8-4af6-8b1d-33b4cd407fb6"),
},
            new Guiduniqueidentifier0M
{
    Id = 30,
    Value = Guid.Parse("224cd865-83af-464a-86a6-ea4d2db5cd96"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 33,
    Value = Guid.Parse("07c5323b-754a-4d3b-8e80-104287af75de"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 21,
    Value = Guid.Parse("8c0352cf-e793-4509-ab87-97c2d1e29251"),
    NullableValue = Guid.Parse("361b7356-41a5-43c9-9879-3197c00d82f7"),
},
    NullableValue = Guid.Parse("c5c3e017-3180-4b82-9585-f540e6c3954d"),
},
            new Guiduniqueidentifier0M
{
    Id = 38,
    Value = Guid.Parse("c82630f5-84ba-4973-8baf-adb323b04428"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 41,
    Value = Guid.Parse("811cb725-4abc-4f2d-a2c9-7bc23752dd3c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 29,
    Value = Guid.Parse("98b1bc4e-2fc4-4a3c-8710-62f4e77fd62b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ff818956-d51e-4319-b9cb-17043301e28e"),
},
            new Guiduniqueidentifier0M
{
    Id = 48,
    Value = Guid.Parse("4c139670-6c3a-4378-8db1-2f508f7943b9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 52,
    Value = Guid.Parse("186a8606-b4b7-44bb-9b65-5f7ea3f3bdea"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 30,
    Value = Guid.Parse("8bb6e280-7cf8-4525-82ad-36b332516d86"),
    NullableValue = Guid.Parse("f868507f-1642-412e-8ecc-92ba0f3cc155"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 58,
    Value = Guid.Parse("e59a3927-e35e-4492-965a-aa9e52fbc9ad"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 62,
    Value = Guid.Parse("7381febe-f77e-4d6b-8621-86c25b9fa9b9"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 32,
    Value = Guid.Parse("1de8573f-2e76-4a44-9d0f-2003823bb5c2"),
    NullableValue = Guid.Parse("113dbcbf-4319-45e9-9698-934ed5365ac9"),
},
    NullableValue = Guid.Parse("b58dabbd-4b6d-442c-8d71-833b021d9422"),
},
            new Guiduniqueidentifier0M
{
    Id = 64,
    Value = Guid.Parse("bd2ae728-ac4d-487f-88ba-4d024696f37e"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 72,
    Value = Guid.Parse("c10c2f96-05d8-46a8-8485-3f76ef799118"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 41,
    Value = Guid.Parse("7883d178-34f1-4259-8b25-ee6dfc1c03e8"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f64859da-5347-4efc-9ac4-80bd1925f2bd"),
},
            new Guiduniqueidentifier0M
{
    Id = 78,
    Value = Guid.Parse("9f275f9f-f2a3-4cb1-a614-7f4baff5bccf"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 82,
    Value = Guid.Parse("f89705a3-d948-48ba-b140-409b20a2efc1"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 43,
    Value = Guid.Parse("0d8766d6-ae79-42fa-bae2-c32b1d12fe8f"),
    NullableValue = Guid.Parse("953c277d-190c-4fd8-ac15-4bcb7e06aa6b"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 89,
    Value = Guid.Parse("37d046c5-7054-4f28-8afc-aa10fd82e2ce"),
    ModelInner = null,
    NullableValue = Guid.Parse("e3fd0bec-24a2-4307-b94e-be87e9c1cf64"),
},
            new Guiduniqueidentifier0M
{
    Id = 91,
    Value = Guid.Parse("dd583748-3e62-4009-a578-e7e5f0418865"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 44,
    Value = Guid.Parse("688e1381-dd14-4fda-b067-acf5ff9e618e"),
    NullableValue = Guid.Parse("87bb185b-0c16-4fdd-8216-2778387f7756"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 93,
    Value = Guid.Parse("83bbebea-862e-4467-80e0-50826199dc68"),
    ModelInner = null,
    NullableValue = Guid.Parse("d0a8a34f-083e-417c-994f-d5161e5a3f02"),
},
            new Guiduniqueidentifier0M
{
    Id = 95,
    Value = Guid.Parse("cac617a8-b4ad-487e-aa52-06a88d5063ad"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 49,
    Value = Guid.Parse("a1765fa7-2104-4c5b-be6c-71845d264542"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("9860df5a-2044-42cc-8604-44d698b1dff2"),
},
            new Guiduniqueidentifier0M
{
    Id = 98,
    Value = Guid.Parse("73ac2693-9c8b-4ad5-b517-7c88667f8817"),
    ModelInner = null,
    NullableValue = Guid.Parse("072e32f0-cbb9-4da4-a650-aaada765d723"),
},
            new Guiduniqueidentifier0M
{
    Id = 105,
    Value = Guid.Parse("f42512e8-ea15-4c2b-bbef-7888c7e5acb6"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 50,
    Value = Guid.Parse("e4dcce5e-8c1b-4979-9016-bf15be654ea5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2282523e-dab7-4321-96d5-9f9e2609f64d"),
},
            new Guiduniqueidentifier0M
{
    Id = 109,
    Value = Guid.Parse("c24cb6c5-f322-400c-a2d3-49ab38e5e523"),
    ModelInner = null,
    NullableValue = Guid.Parse("5bb5885b-b825-4586-9c9a-8201499cd723"),
},
            new Guiduniqueidentifier0M
{
    Id = 118,
    Value = Guid.Parse("26eeeffd-c6d9-45b1-a089-0ce7992a8890"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 59,
    Value = Guid.Parse("c4512959-f8aa-472b-8f6f-a6a555055516"),
    NullableValue = Guid.Parse("0badbe10-5b8a-4ca4-a4b8-ff714f4fbc6e"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 124,
    Value = Guid.Parse("3260be0b-4f39-4574-8d02-af43f63e2233"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 131,
    Value = Guid.Parse("b50c0f6b-9078-47db-98e4-2b6233cc125c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 64,
    Value = Guid.Parse("f632690c-a3b5-4917-a3dc-4fc12c1ec5d0"),
    NullableValue = Guid.Parse("cbb54061-35d7-44ea-9199-1fee8b23efc3"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 138,
    Value = Guid.Parse("a661d602-b8c2-4d78-b671-0d28690493fb"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 143,
    Value = Guid.Parse("077ddbd4-46b4-40dc-aac2-324cc4d00cf6"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 67,
    Value = Guid.Parse("852541d5-284b-4498-aecf-e2b9579ef394"),
    NullableValue = Guid.Parse("9c4ad271-a4a6-4416-bdfd-e44d8ed20db5"),
},
    NullableValue = Guid.Parse("773048e9-5907-49be-96ff-2619e5c66ae8"),
},
            new Guiduniqueidentifier0M
{
    Id = 145,
    Value = Guid.Parse("6bcd8c1f-61e9-44ed-80ab-762e0deb4629"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 151,
    Value = Guid.Parse("b3f2b8ae-7784-4383-b562-c658eddcaa4c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 68,
    Value = Guid.Parse("ee4d83ea-227a-4425-9cfa-bc8dcdf147ca"),
    NullableValue = Guid.Parse("7d3192bc-9b73-4f0d-a219-3f200533bccc"),
},
    NullableValue = Guid.Parse("948247df-662d-43fd-b02e-758e2c97752a"),
},
            new Guiduniqueidentifier0M
{
    Id = 155,
    Value = Guid.Parse("4591aa15-b8e5-412c-aa20-a4e7568694bf"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 160,
    Value = Guid.Parse("01aa8ef6-449a-4a2e-bb4e-5947f46664d2"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 77,
    Value = Guid.Parse("da356f42-a735-401d-8437-0835f71e6b61"),
    NullableValue = Guid.Parse("376b7ea8-18dd-4180-b0db-e6d631559c34"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 168,
    Value = Guid.Parse("defbfb64-abd6-4a20-9b0b-20bbea623b89"),
    ModelInner = null,
    NullableValue = Guid.Parse("73692209-dcbf-44b3-9c61-1f8259982d70"),
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[28],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[3], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[4], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[28],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[29],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[30],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 145, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 155, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 124, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 91, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 64, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 58, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 20, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 41, 145))
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 33, 52))
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[34], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[29], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[30], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[31], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[32], false);Guiduniqueidentifier0M.AssertModel(models[24],_testData[33], false);Guiduniqueidentifier0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[29], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[30], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[31], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[32], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[33], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4b9edb12-168b-4728-a35e-a42dbc668eeb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ebb5a20e-b242-473b-9feb-4386031b20cf"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("79a7b445-5db1-430c-8731-4872926c19aa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("68cd8887-ed9d-46c5-8cfc-6cd0d4571bcc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fc9e2c91-19a4-4cb7-a189-7c08e9ca6859"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2b2087f0-45a1-4174-83b6-3849f0a902c9"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("068945a5-76b3-4b65-a3b7-b90b9e82d6b5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d2b61f25-e678-4374-bb5e-82c37515bd20"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("26113735-06f7-4f01-b276-01265683a275"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2ff58f03-74eb-4187-b747-6676781e7a7b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7340cc65-7a8f-4023-8a91-45c8eab95cb8"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4a55e4b8-878d-4b97-88e5-5f059837a174"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("acd4947a-ab5b-44a9-ac89-f823f09aa14c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("98a8aef4-743f-4b74-a332-25b8346727e0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e6da7cef-97c8-4af6-8b1d-33b4cd407fb6"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("224cd865-83af-464a-86a6-ea4d2db5cd96"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("07c5323b-754a-4d3b-8e80-104287af75de"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8c0352cf-e793-4509-ab87-97c2d1e29251"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("361b7356-41a5-43c9-9879-3197c00d82f7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c5c3e017-3180-4b82-9585-f540e6c3954d"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c82630f5-84ba-4973-8baf-adb323b04428"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("811cb725-4abc-4f2d-a2c9-7bc23752dd3c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("98b1bc4e-2fc4-4a3c-8710-62f4e77fd62b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ff818956-d51e-4319-b9cb-17043301e28e"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c139670-6c3a-4378-8db1-2f508f7943b9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("186a8606-b4b7-44bb-9b65-5f7ea3f3bdea"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8bb6e280-7cf8-4525-82ad-36b332516d86"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f868507f-1642-412e-8ecc-92ba0f3cc155"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e59a3927-e35e-4492-965a-aa9e52fbc9ad"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7381febe-f77e-4d6b-8621-86c25b9fa9b9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1de8573f-2e76-4a44-9d0f-2003823bb5c2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("113dbcbf-4319-45e9-9698-934ed5365ac9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b58dabbd-4b6d-442c-8d71-833b021d9422"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bd2ae728-ac4d-487f-88ba-4d024696f37e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c10c2f96-05d8-46a8-8485-3f76ef799118"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7883d178-34f1-4259-8b25-ee6dfc1c03e8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f64859da-5347-4efc-9ac4-80bd1925f2bd"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9f275f9f-f2a3-4cb1-a614-7f4baff5bccf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f89705a3-d948-48ba-b140-409b20a2efc1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d8766d6-ae79-42fa-bae2-c32b1d12fe8f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("953c277d-190c-4fd8-ac15-4bcb7e06aa6b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("37d046c5-7054-4f28-8afc-aa10fd82e2ce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e3fd0bec-24a2-4307-b94e-be87e9c1cf64"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dd583748-3e62-4009-a578-e7e5f0418865"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("688e1381-dd14-4fda-b067-acf5ff9e618e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("87bb185b-0c16-4fdd-8216-2778387f7756"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("83bbebea-862e-4467-80e0-50826199dc68"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d0a8a34f-083e-417c-994f-d5161e5a3f02"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cac617a8-b4ad-487e-aa52-06a88d5063ad"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1765fa7-2104-4c5b-be6c-71845d264542"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9860df5a-2044-42cc-8604-44d698b1dff2"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("73ac2693-9c8b-4ad5-b517-7c88667f8817"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("072e32f0-cbb9-4da4-a650-aaada765d723"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f42512e8-ea15-4c2b-bbef-7888c7e5acb6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e4dcce5e-8c1b-4979-9016-bf15be654ea5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2282523e-dab7-4321-96d5-9f9e2609f64d"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c24cb6c5-f322-400c-a2d3-49ab38e5e523"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5bb5885b-b825-4586-9c9a-8201499cd723"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("26eeeffd-c6d9-45b1-a089-0ce7992a8890"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c4512959-f8aa-472b-8f6f-a6a555055516"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0badbe10-5b8a-4ca4-a4b8-ff714f4fbc6e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3260be0b-4f39-4574-8d02-af43f63e2233"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b50c0f6b-9078-47db-98e4-2b6233cc125c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f632690c-a3b5-4917-a3dc-4fc12c1ec5d0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cbb54061-35d7-44ea-9199-1fee8b23efc3"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a661d602-b8c2-4d78-b671-0d28690493fb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("077ddbd4-46b4-40dc-aac2-324cc4d00cf6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("852541d5-284b-4498-aecf-e2b9579ef394"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9c4ad271-a4a6-4416-bdfd-e44d8ed20db5"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("773048e9-5907-49be-96ff-2619e5c66ae8"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6bcd8c1f-61e9-44ed-80ab-762e0deb4629"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b3f2b8ae-7784-4383-b562-c658eddcaa4c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ee4d83ea-227a-4425-9cfa-bc8dcdf147ca"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d3192bc-9b73-4f0d-a219-3f200533bccc"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("948247df-662d-43fd-b02e-758e2c97752a"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4591aa15-b8e5-412c-aa20-a4e7568694bf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01aa8ef6-449a-4a2e-bb4e-5947f46664d2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("da356f42-a735-401d-8437-0835f71e6b61"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("376b7ea8-18dd-4180-b0db-e6d631559c34"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("defbfb64-abd6-4a20-9b0b-20bbea623b89"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("73692209-dcbf-44b3-9c61-1f8259982d70"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4b9edb12-168b-4728-a35e-a42dbc668eeb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ebb5a20e-b242-473b-9feb-4386031b20cf"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("79a7b445-5db1-430c-8731-4872926c19aa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("68cd8887-ed9d-46c5-8cfc-6cd0d4571bcc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fc9e2c91-19a4-4cb7-a189-7c08e9ca6859"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2b2087f0-45a1-4174-83b6-3849f0a902c9"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("068945a5-76b3-4b65-a3b7-b90b9e82d6b5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d2b61f25-e678-4374-bb5e-82c37515bd20"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("26113735-06f7-4f01-b276-01265683a275"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2ff58f03-74eb-4187-b747-6676781e7a7b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7340cc65-7a8f-4023-8a91-45c8eab95cb8"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4a55e4b8-878d-4b97-88e5-5f059837a174"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("acd4947a-ab5b-44a9-ac89-f823f09aa14c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("98a8aef4-743f-4b74-a332-25b8346727e0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e6da7cef-97c8-4af6-8b1d-33b4cd407fb6"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("224cd865-83af-464a-86a6-ea4d2db5cd96"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("07c5323b-754a-4d3b-8e80-104287af75de"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8c0352cf-e793-4509-ab87-97c2d1e29251"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("361b7356-41a5-43c9-9879-3197c00d82f7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c5c3e017-3180-4b82-9585-f540e6c3954d"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c82630f5-84ba-4973-8baf-adb323b04428"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("811cb725-4abc-4f2d-a2c9-7bc23752dd3c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("98b1bc4e-2fc4-4a3c-8710-62f4e77fd62b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ff818956-d51e-4319-b9cb-17043301e28e"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c139670-6c3a-4378-8db1-2f508f7943b9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("186a8606-b4b7-44bb-9b65-5f7ea3f3bdea"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8bb6e280-7cf8-4525-82ad-36b332516d86"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f868507f-1642-412e-8ecc-92ba0f3cc155"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e59a3927-e35e-4492-965a-aa9e52fbc9ad"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7381febe-f77e-4d6b-8621-86c25b9fa9b9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1de8573f-2e76-4a44-9d0f-2003823bb5c2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("113dbcbf-4319-45e9-9698-934ed5365ac9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b58dabbd-4b6d-442c-8d71-833b021d9422"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bd2ae728-ac4d-487f-88ba-4d024696f37e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c10c2f96-05d8-46a8-8485-3f76ef799118"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7883d178-34f1-4259-8b25-ee6dfc1c03e8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f64859da-5347-4efc-9ac4-80bd1925f2bd"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9f275f9f-f2a3-4cb1-a614-7f4baff5bccf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f89705a3-d948-48ba-b140-409b20a2efc1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d8766d6-ae79-42fa-bae2-c32b1d12fe8f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("953c277d-190c-4fd8-ac15-4bcb7e06aa6b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("37d046c5-7054-4f28-8afc-aa10fd82e2ce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e3fd0bec-24a2-4307-b94e-be87e9c1cf64"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dd583748-3e62-4009-a578-e7e5f0418865"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("688e1381-dd14-4fda-b067-acf5ff9e618e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("87bb185b-0c16-4fdd-8216-2778387f7756"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("83bbebea-862e-4467-80e0-50826199dc68"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d0a8a34f-083e-417c-994f-d5161e5a3f02"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cac617a8-b4ad-487e-aa52-06a88d5063ad"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1765fa7-2104-4c5b-be6c-71845d264542"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9860df5a-2044-42cc-8604-44d698b1dff2"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("73ac2693-9c8b-4ad5-b517-7c88667f8817"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("072e32f0-cbb9-4da4-a650-aaada765d723"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f42512e8-ea15-4c2b-bbef-7888c7e5acb6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e4dcce5e-8c1b-4979-9016-bf15be654ea5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2282523e-dab7-4321-96d5-9f9e2609f64d"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c24cb6c5-f322-400c-a2d3-49ab38e5e523"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5bb5885b-b825-4586-9c9a-8201499cd723"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("26eeeffd-c6d9-45b1-a089-0ce7992a8890"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c4512959-f8aa-472b-8f6f-a6a555055516"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0badbe10-5b8a-4ca4-a4b8-ff714f4fbc6e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3260be0b-4f39-4574-8d02-af43f63e2233"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b50c0f6b-9078-47db-98e4-2b6233cc125c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f632690c-a3b5-4917-a3dc-4fc12c1ec5d0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cbb54061-35d7-44ea-9199-1fee8b23efc3"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a661d602-b8c2-4d78-b671-0d28690493fb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("077ddbd4-46b4-40dc-aac2-324cc4d00cf6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("852541d5-284b-4498-aecf-e2b9579ef394"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9c4ad271-a4a6-4416-bdfd-e44d8ed20db5"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("773048e9-5907-49be-96ff-2619e5c66ae8"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6bcd8c1f-61e9-44ed-80ab-762e0deb4629"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b3f2b8ae-7784-4383-b562-c658eddcaa4c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ee4d83ea-227a-4425-9cfa-bc8dcdf147ca"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d3192bc-9b73-4f0d-a219-3f200533bccc"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("948247df-662d-43fd-b02e-758e2c97752a"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4591aa15-b8e5-412c-aa20-a4e7568694bf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01aa8ef6-449a-4a2e-bb4e-5947f46664d2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("da356f42-a735-401d-8437-0835f71e6b61"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("376b7ea8-18dd-4180-b0db-e6d631559c34"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("defbfb64-abd6-4a20-9b0b-20bbea623b89"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("73692209-dcbf-44b3-9c61-1f8259982d70"))));

            }
        }

#endregion

    }
}




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
    Id = 9,
    Value = Guid.Parse("54bb34ed-29f0-41e4-b78d-705bec080cda"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 17,
    Value = Guid.Parse("c79f44f9-c463-4dbd-bd22-867ed0fadfc6"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 8,
    Value = Guid.Parse("664f8723-49b9-4971-ba30-71a3d3405904"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a9e2d454-5cba-4dda-be07-c36044947be7"),
},
            new Guiduniqueidentifier0M
{
    Id = 20,
    Value = Guid.Parse("24b7a957-1be0-4233-8fad-174fcd72c7c7"),
    ModelInner = null,
    NullableValue = Guid.Parse("128cbae1-996d-49a3-9d0d-c57158703608"),
},
            new Guiduniqueidentifier0M
{
    Id = 26,
    Value = Guid.Parse("603e5043-1bfb-40e6-a347-1df95412d434"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 10,
    Value = Guid.Parse("09cdc850-367c-440a-9779-1d0af9277884"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c3fd95be-276b-40fc-9c38-1bcb13dc31ba"),
},
            new Guiduniqueidentifier0M
{
    Id = 31,
    Value = Guid.Parse("785cb136-6a86-4209-b17f-0857530ccce6"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 34,
    Value = Guid.Parse("ef3d620c-53c0-4999-b9ed-9f231e8f5dc0"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 13,
    Value = Guid.Parse("a2db80fd-01aa-460e-95be-6e5e6520d916"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01aa537f-cf18-42cd-9e34-4ede15e42813"),
},
            new Guiduniqueidentifier0M
{
    Id = 37,
    Value = Guid.Parse("345edf7b-1b99-42db-a89d-421f0ce9b97a"),
    ModelInner = null,
    NullableValue = Guid.Parse("d30bf23d-12e4-4e42-9bbc-de0793fa9bbc"),
},
            new Guiduniqueidentifier0M
{
    Id = 40,
    Value = Guid.Parse("943b1547-b4bb-494f-8c20-adff3f6bf185"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 18,
    Value = Guid.Parse("a66c6ef5-3c81-4574-947f-ce437008bcdb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("4f8ece96-f955-4835-be60-f70f5f8a91f8"),
},
            new Guiduniqueidentifier0M
{
    Id = 49,
    Value = Guid.Parse("0d6fc59e-c4ee-40f5-9087-56c0c3c5e601"),
    ModelInner = null,
    NullableValue = Guid.Parse("72aa5ef6-c3c6-4415-964f-9c7b001c49b7"),
},
            new Guiduniqueidentifier0M
{
    Id = 58,
    Value = Guid.Parse("548595bd-39f4-45b4-8fbf-d34efed5c430"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 20,
    Value = Guid.Parse("f06cb6f5-af8c-404c-b73c-bfc024bccb00"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b689f859-ec7f-45b0-9e13-02b907eb692f"),
},
            new Guiduniqueidentifier0M
{
    Id = 62,
    Value = Guid.Parse("85cee5e4-4fbd-4a2f-9862-a0c86af0f281"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 70,
    Value = Guid.Parse("e758d4d4-bb41-4365-a784-62c0eaf2ed4d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 27,
    Value = Guid.Parse("60a40a71-4dcf-42db-ae43-2e1b4c7b5517"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("7dbe137e-420f-40b7-a3dc-2b8e3c6acef6"),
},
            new Guiduniqueidentifier0M
{
    Id = 77,
    Value = Guid.Parse("65df42be-c9ad-4fbe-8093-826ec3775a9d"),
    ModelInner = null,
    NullableValue = Guid.Parse("21642c49-a823-4814-be2c-0dcc92ed1718"),
},
            new Guiduniqueidentifier0M
{
    Id = 80,
    Value = Guid.Parse("98c5abe1-9eeb-4367-a2f0-ae9e1ea24c4c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 35,
    Value = Guid.Parse("dc7718f8-4f81-4b79-bca5-bfc785326440"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("6d508848-f29b-491e-b401-abbd8cb5bb26"),
},
            new Guiduniqueidentifier0M
{
    Id = 88,
    Value = Guid.Parse("b98ed820-808c-4af5-9444-8a64fff3aa23"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 97,
    Value = Guid.Parse("8f29efb8-bc9c-4c85-8020-98e02b64b148"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 39,
    Value = Guid.Parse("c7e79b39-1d48-4f6f-b2c5-f96cf58a23f4"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("9c1f8a1e-fdaf-48f8-b890-eb0de9692c49"),
},
            new Guiduniqueidentifier0M
{
    Id = 99,
    Value = Guid.Parse("e0586afa-f2dc-4a1a-9caa-d5ece35a117c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 106,
    Value = Guid.Parse("c580935c-0b3f-41b5-94e5-33eaa87be323"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 42,
    Value = Guid.Parse("ac7230a6-eaab-4e8b-bcba-a9b1a4fb7061"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("49995724-fbfb-4e34-b087-2367a03ca48e"),
},
            new Guiduniqueidentifier0M
{
    Id = 109,
    Value = Guid.Parse("44c797e9-2c6c-4c95-9442-f210c92c5a73"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 113,
    Value = Guid.Parse("426a2e66-3a0a-43bc-9000-4f817f57ffa8"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 49,
    Value = Guid.Parse("d9aea45f-49a3-479f-b62b-9c41fce08bfb"),
    NullableValue = Guid.Parse("c73231d0-39cf-4272-b172-a35e92ecbe4e"),
},
    NullableValue = Guid.Parse("ab579922-0d8a-4803-a605-d216dcba515b"),
},
            new Guiduniqueidentifier0M
{
    Id = 116,
    Value = Guid.Parse("9bf1a1d1-cb9e-47d6-9dcd-6db3a60efbc5"),
    ModelInner = null,
    NullableValue = Guid.Parse("209184f6-5520-48f3-8a4e-8ef57116f86e"),
},
            new Guiduniqueidentifier0M
{
    Id = 122,
    Value = Guid.Parse("4067ac76-e242-435a-8e70-de20659c4bfb"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 52,
    Value = Guid.Parse("dbf9e138-33e7-467e-993d-268610f53046"),
    NullableValue = Guid.Parse("23be396f-7944-428e-b430-7beb5ff52e7d"),
},
    NullableValue = Guid.Parse("17a578d4-9b6f-4215-9ef3-1776f231a5a0"),
},
            new Guiduniqueidentifier0M
{
    Id = 125,
    Value = Guid.Parse("7af25a9f-7de1-4576-837e-97789324d3cb"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 129,
    Value = Guid.Parse("da3c60c8-9549-41bd-84b4-95e9b7fd6655"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 61,
    Value = Guid.Parse("f7d39db9-e93a-4376-8e11-e33dd8d3a4e1"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("5ab28494-602b-4f0c-b3de-31e6ac7f901f"),
},
            new Guiduniqueidentifier0M
{
    Id = 132,
    Value = Guid.Parse("9e74d780-539a-4b71-9c1d-f6adf10f77cd"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 137,
    Value = Guid.Parse("cd65c087-7392-4a6c-b9bf-7a003c6d7418"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 64,
    Value = Guid.Parse("ba0c189f-fd50-480d-8fda-609bdc40b4b9"),
    NullableValue = Guid.Parse("2cf63188-2d78-4f08-b6e3-159ea37e2d59"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 142,
    Value = Guid.Parse("6360ad6b-c3f8-45a4-bbb0-e6f2631ca466"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 149,
    Value = Guid.Parse("5fdc5448-dad0-4d93-a02f-5f0ec387a650"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 72,
    Value = Guid.Parse("b02e526c-d165-415c-a7ce-b2d1a52e18cf"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 150,
    Value = Guid.Parse("42af3e3f-b330-42ae-91ec-fc0365ee3269"),
    ModelInner = null,
    NullableValue = Guid.Parse("ce33aa90-c106-4368-8322-57d580147b6b"),
},
            new Guiduniqueidentifier0M
{
    Id = 153,
    Value = Guid.Parse("7c54838b-d609-476d-a441-26b9a9534f54"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 79,
    Value = Guid.Parse("47bc45d1-34cf-4fee-968a-31ad991ae591"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("bcd7959a-a3b2-4e72-ab88-a25b3baf018d"),
},
            new Guiduniqueidentifier0M
{
    Id = 162,
    Value = Guid.Parse("3530d2ac-85a6-4ee7-b823-6c3597ce1e98"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 164,
    Value = Guid.Parse("62b9d239-ff0d-4a1f-b2f0-a2553f794e4e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 87,
    Value = Guid.Parse("7b8ce867-405b-4b51-83e0-d9fb883c5d77"),
    NullableValue = Guid.Parse("7d3419c6-6092-4526-aae2-f1915fc68726"),
},
    NullableValue = Guid.Parse("bca98a40-7bee-478f-af02-8e167fff4e95"),
},
            new Guiduniqueidentifier0M
{
    Id = 173,
    Value = Guid.Parse("f54c8512-5449-4691-9921-be7726071cde"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 174,
    Value = Guid.Parse("6dfd1d06-7afb-4fc9-9d84-b75b38c5d782"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 91,
    Value = Guid.Parse("bd14aab5-fa7d-4e15-bcc9-9cdbc99ff833"),
    NullableValue = Guid.Parse("e9c8dea1-6532-4715-9585-70d686866fe9"),
},
    NullableValue = Guid.Parse("efdaee7f-014e-42d4-a5af-5e891f9eb358"),
},
            new Guiduniqueidentifier0M
{
    Id = 179,
    Value = Guid.Parse("4bd4464c-bb83-4824-8558-b979e7b6b9c5"),
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[1], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[2], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[3], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[4], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[28],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[29],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[30],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[31],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[32],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[33],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 149, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 34, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 88, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 142, query1, 164, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 99, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 58, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 62, 164))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 62, 62))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[34], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 164);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Guiduniqueidentifier0M.AssertModel(models[0],_testData[32], false);
                Guiduniqueidentifier0M.AssertModel(models[1],_testData[33], false);
                Guiduniqueidentifier0M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("54bb34ed-29f0-41e4-b78d-705bec080cda"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c79f44f9-c463-4dbd-bd22-867ed0fadfc6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("664f8723-49b9-4971-ba30-71a3d3405904"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a9e2d454-5cba-4dda-be07-c36044947be7"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("24b7a957-1be0-4233-8fad-174fcd72c7c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("128cbae1-996d-49a3-9d0d-c57158703608"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("603e5043-1bfb-40e6-a347-1df95412d434"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("09cdc850-367c-440a-9779-1d0af9277884"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c3fd95be-276b-40fc-9c38-1bcb13dc31ba"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("785cb136-6a86-4209-b17f-0857530ccce6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ef3d620c-53c0-4999-b9ed-9f231e8f5dc0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a2db80fd-01aa-460e-95be-6e5e6520d916"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("01aa537f-cf18-42cd-9e34-4ede15e42813"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("345edf7b-1b99-42db-a89d-421f0ce9b97a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d30bf23d-12e4-4e42-9bbc-de0793fa9bbc"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("943b1547-b4bb-494f-8c20-adff3f6bf185"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a66c6ef5-3c81-4574-947f-ce437008bcdb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4f8ece96-f955-4835-be60-f70f5f8a91f8"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0d6fc59e-c4ee-40f5-9087-56c0c3c5e601"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("72aa5ef6-c3c6-4415-964f-9c7b001c49b7"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("548595bd-39f4-45b4-8fbf-d34efed5c430"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f06cb6f5-af8c-404c-b73c-bfc024bccb00"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b689f859-ec7f-45b0-9e13-02b907eb692f"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("85cee5e4-4fbd-4a2f-9862-a0c86af0f281"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e758d4d4-bb41-4365-a784-62c0eaf2ed4d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("60a40a71-4dcf-42db-ae43-2e1b4c7b5517"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7dbe137e-420f-40b7-a3dc-2b8e3c6acef6"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("65df42be-c9ad-4fbe-8093-826ec3775a9d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("21642c49-a823-4814-be2c-0dcc92ed1718"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98c5abe1-9eeb-4367-a2f0-ae9e1ea24c4c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dc7718f8-4f81-4b79-bca5-bfc785326440"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6d508848-f29b-491e-b401-abbd8cb5bb26"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b98ed820-808c-4af5-9444-8a64fff3aa23"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8f29efb8-bc9c-4c85-8020-98e02b64b148"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c7e79b39-1d48-4f6f-b2c5-f96cf58a23f4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9c1f8a1e-fdaf-48f8-b890-eb0de9692c49"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e0586afa-f2dc-4a1a-9caa-d5ece35a117c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c580935c-0b3f-41b5-94e5-33eaa87be323"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ac7230a6-eaab-4e8b-bcba-a9b1a4fb7061"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("49995724-fbfb-4e34-b087-2367a03ca48e"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("44c797e9-2c6c-4c95-9442-f210c92c5a73"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("426a2e66-3a0a-43bc-9000-4f817f57ffa8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d9aea45f-49a3-479f-b62b-9c41fce08bfb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c73231d0-39cf-4272-b172-a35e92ecbe4e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab579922-0d8a-4803-a605-d216dcba515b"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9bf1a1d1-cb9e-47d6-9dcd-6db3a60efbc5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("209184f6-5520-48f3-8a4e-8ef57116f86e"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4067ac76-e242-435a-8e70-de20659c4bfb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dbf9e138-33e7-467e-993d-268610f53046"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("23be396f-7944-428e-b430-7beb5ff52e7d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("17a578d4-9b6f-4215-9ef3-1776f231a5a0"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7af25a9f-7de1-4576-837e-97789324d3cb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("da3c60c8-9549-41bd-84b4-95e9b7fd6655"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f7d39db9-e93a-4376-8e11-e33dd8d3a4e1"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5ab28494-602b-4f0c-b3de-31e6ac7f901f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e74d780-539a-4b71-9c1d-f6adf10f77cd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd65c087-7392-4a6c-b9bf-7a003c6d7418"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ba0c189f-fd50-480d-8fda-609bdc40b4b9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2cf63188-2d78-4f08-b6e3-159ea37e2d59"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6360ad6b-c3f8-45a4-bbb0-e6f2631ca466"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5fdc5448-dad0-4d93-a02f-5f0ec387a650"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b02e526c-d165-415c-a7ce-b2d1a52e18cf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42af3e3f-b330-42ae-91ec-fc0365ee3269"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ce33aa90-c106-4368-8322-57d580147b6b"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7c54838b-d609-476d-a441-26b9a9534f54"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("47bc45d1-34cf-4fee-968a-31ad991ae591"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bcd7959a-a3b2-4e72-ab88-a25b3baf018d"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3530d2ac-85a6-4ee7-b823-6c3597ce1e98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62b9d239-ff0d-4a1f-b2f0-a2553f794e4e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7b8ce867-405b-4b51-83e0-d9fb883c5d77"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d3419c6-6092-4526-aae2-f1915fc68726"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bca98a40-7bee-478f-af02-8e167fff4e95"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f54c8512-5449-4691-9921-be7726071cde"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6dfd1d06-7afb-4fc9-9d84-b75b38c5d782"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bd14aab5-fa7d-4e15-bcc9-9cdbc99ff833"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e9c8dea1-6532-4715-9585-70d686866fe9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("efdaee7f-014e-42d4-a5af-5e891f9eb358"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4bd4464c-bb83-4824-8558-b979e7b6b9c5"))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("54bb34ed-29f0-41e4-b78d-705bec080cda"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c79f44f9-c463-4dbd-bd22-867ed0fadfc6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("664f8723-49b9-4971-ba30-71a3d3405904"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a9e2d454-5cba-4dda-be07-c36044947be7"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("24b7a957-1be0-4233-8fad-174fcd72c7c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("128cbae1-996d-49a3-9d0d-c57158703608"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("603e5043-1bfb-40e6-a347-1df95412d434"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("09cdc850-367c-440a-9779-1d0af9277884"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c3fd95be-276b-40fc-9c38-1bcb13dc31ba"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("785cb136-6a86-4209-b17f-0857530ccce6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ef3d620c-53c0-4999-b9ed-9f231e8f5dc0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a2db80fd-01aa-460e-95be-6e5e6520d916"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("01aa537f-cf18-42cd-9e34-4ede15e42813"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("345edf7b-1b99-42db-a89d-421f0ce9b97a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d30bf23d-12e4-4e42-9bbc-de0793fa9bbc"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("943b1547-b4bb-494f-8c20-adff3f6bf185"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a66c6ef5-3c81-4574-947f-ce437008bcdb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4f8ece96-f955-4835-be60-f70f5f8a91f8"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0d6fc59e-c4ee-40f5-9087-56c0c3c5e601"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("72aa5ef6-c3c6-4415-964f-9c7b001c49b7"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("548595bd-39f4-45b4-8fbf-d34efed5c430"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f06cb6f5-af8c-404c-b73c-bfc024bccb00"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b689f859-ec7f-45b0-9e13-02b907eb692f"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("85cee5e4-4fbd-4a2f-9862-a0c86af0f281"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e758d4d4-bb41-4365-a784-62c0eaf2ed4d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("60a40a71-4dcf-42db-ae43-2e1b4c7b5517"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7dbe137e-420f-40b7-a3dc-2b8e3c6acef6"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("65df42be-c9ad-4fbe-8093-826ec3775a9d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("21642c49-a823-4814-be2c-0dcc92ed1718"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98c5abe1-9eeb-4367-a2f0-ae9e1ea24c4c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dc7718f8-4f81-4b79-bca5-bfc785326440"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6d508848-f29b-491e-b401-abbd8cb5bb26"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b98ed820-808c-4af5-9444-8a64fff3aa23"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8f29efb8-bc9c-4c85-8020-98e02b64b148"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c7e79b39-1d48-4f6f-b2c5-f96cf58a23f4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9c1f8a1e-fdaf-48f8-b890-eb0de9692c49"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e0586afa-f2dc-4a1a-9caa-d5ece35a117c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c580935c-0b3f-41b5-94e5-33eaa87be323"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ac7230a6-eaab-4e8b-bcba-a9b1a4fb7061"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("49995724-fbfb-4e34-b087-2367a03ca48e"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("44c797e9-2c6c-4c95-9442-f210c92c5a73"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("426a2e66-3a0a-43bc-9000-4f817f57ffa8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d9aea45f-49a3-479f-b62b-9c41fce08bfb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c73231d0-39cf-4272-b172-a35e92ecbe4e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab579922-0d8a-4803-a605-d216dcba515b"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9bf1a1d1-cb9e-47d6-9dcd-6db3a60efbc5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("209184f6-5520-48f3-8a4e-8ef57116f86e"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4067ac76-e242-435a-8e70-de20659c4bfb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dbf9e138-33e7-467e-993d-268610f53046"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("23be396f-7944-428e-b430-7beb5ff52e7d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("17a578d4-9b6f-4215-9ef3-1776f231a5a0"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7af25a9f-7de1-4576-837e-97789324d3cb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("da3c60c8-9549-41bd-84b4-95e9b7fd6655"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f7d39db9-e93a-4376-8e11-e33dd8d3a4e1"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5ab28494-602b-4f0c-b3de-31e6ac7f901f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e74d780-539a-4b71-9c1d-f6adf10f77cd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd65c087-7392-4a6c-b9bf-7a003c6d7418"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ba0c189f-fd50-480d-8fda-609bdc40b4b9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2cf63188-2d78-4f08-b6e3-159ea37e2d59"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6360ad6b-c3f8-45a4-bbb0-e6f2631ca466"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5fdc5448-dad0-4d93-a02f-5f0ec387a650"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b02e526c-d165-415c-a7ce-b2d1a52e18cf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42af3e3f-b330-42ae-91ec-fc0365ee3269"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ce33aa90-c106-4368-8322-57d580147b6b"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7c54838b-d609-476d-a441-26b9a9534f54"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("47bc45d1-34cf-4fee-968a-31ad991ae591"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bcd7959a-a3b2-4e72-ab88-a25b3baf018d"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3530d2ac-85a6-4ee7-b823-6c3597ce1e98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62b9d239-ff0d-4a1f-b2f0-a2553f794e4e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7b8ce867-405b-4b51-83e0-d9fb883c5d77"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d3419c6-6092-4526-aae2-f1915fc68726"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bca98a40-7bee-478f-af02-8e167fff4e95"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f54c8512-5449-4691-9921-be7726071cde"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6dfd1d06-7afb-4fc9-9d84-b75b38c5d782"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bd14aab5-fa7d-4e15-bcc9-9cdbc99ff833"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e9c8dea1-6532-4715-9585-70d686866fe9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("efdaee7f-014e-42d4-a5af-5e891f9eb358"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4bd4464c-bb83-4824-8558-b979e7b6b9c5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


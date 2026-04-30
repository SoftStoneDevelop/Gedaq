

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
    Value = Guid.Parse("a5b4fc90-827f-4d95-a24f-0a900c37be1c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 9,
    Value = Guid.Parse("016dbf57-1704-4845-919c-9902880454f6"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 6,
    Value = Guid.Parse("a66dd6df-2979-49be-a573-0ed7d5d2c3c1"),
    NullableValue = Guid.Parse("28a835a7-4f1e-4a92-82ae-307c494171a9"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 15,
    Value = Guid.Parse("88ca2acb-2c42-43dd-83c8-c76e49fd8a26"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 16,
    Value = Guid.Parse("e6f0edf4-b6e3-4f6c-be89-f65e06abef7e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 10,
    Value = Guid.Parse("c9a9ff74-4fc2-4f65-8517-d059b26acffb"),
    NullableValue = Guid.Parse("68e34f86-8b54-4e73-acb5-7280348d32ff"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 23,
    Value = Guid.Parse("e04b995a-5e37-472e-a574-f0722dc2f3b9"),
    ModelInner = null,
    NullableValue = Guid.Parse("cf256a1f-2e21-4303-b268-337dde459532"),
},
            new Guiduniqueidentifier0M
{
    Id = 29,
    Value = Guid.Parse("63c543f5-44ed-4735-86b3-816f630eb366"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 12,
    Value = Guid.Parse("5b60571d-0a59-4792-895b-349f63c33e83"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2866670f-8550-4159-a99e-a51ebf5e1607"),
},
            new Guiduniqueidentifier0M
{
    Id = 33,
    Value = Guid.Parse("967350d5-8f62-4121-a6ae-6274bff150f7"),
    ModelInner = null,
    NullableValue = Guid.Parse("f6db506c-3c6e-407d-a805-4f494854dc9d"),
},
            new Guiduniqueidentifier0M
{
    Id = 39,
    Value = Guid.Parse("f0737788-05d8-47bd-9b79-52da8f2d42ff"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 20,
    Value = Guid.Parse("d3347859-1011-4093-af3d-848705d35737"),
    NullableValue = Guid.Parse("23a876a6-d0a4-4627-9151-f35977ecc6cb"),
},
    NullableValue = Guid.Parse("a71cdfcf-b5cd-4700-afa6-f7e70731273d"),
},
            new Guiduniqueidentifier0M
{
    Id = 46,
    Value = Guid.Parse("d836c42f-c584-4313-8a27-b6ae02a761a2"),
    ModelInner = null,
    NullableValue = Guid.Parse("8395c5e0-a580-44b1-8901-b4ca18031c33"),
},
            new Guiduniqueidentifier0M
{
    Id = 47,
    Value = Guid.Parse("14c6ff90-5943-4874-bb64-d2497a3fc48c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 22,
    Value = Guid.Parse("1b782de3-fe49-44cd-ac32-15e662a4e6c6"),
    NullableValue = Guid.Parse("d128a3cb-83bf-417d-bfae-2adb0999c949"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 51,
    Value = Guid.Parse("3b097d62-3c0a-4c22-8607-3d3db8a5765e"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 58,
    Value = Guid.Parse("c8499ad5-c4aa-40be-8772-51208e4ebb92"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 26,
    Value = Guid.Parse("a00bde78-29aa-43f6-a58e-0fb2b546fc51"),
    NullableValue = Guid.Parse("fe4118e1-09a0-4780-9f75-59f5211a4ff0"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 60,
    Value = Guid.Parse("9a455734-e12b-4ea2-9cd8-2d9448dfa661"),
    ModelInner = null,
    NullableValue = Guid.Parse("fb653430-ad1e-4d37-aac7-e6ccb7f329b4"),
},
            new Guiduniqueidentifier0M
{
    Id = 65,
    Value = Guid.Parse("e3af0789-4152-4a27-b16d-aa94ea246cf8"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 35,
    Value = Guid.Parse("9e74ffe0-e0cc-49fc-a68d-0ba63e055cdc"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 72,
    Value = Guid.Parse("db9ae703-7bbd-4317-ace2-6999b564e024"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 74,
    Value = Guid.Parse("611f5a8b-28a7-458b-af3b-abf7ef60ebd2"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 36,
    Value = Guid.Parse("e7c69fff-d098-408c-89ec-d101546c807c"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 82,
    Value = Guid.Parse("f4ea3b58-53b0-4b9f-87d3-add38c94efa5"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 89,
    Value = Guid.Parse("250e60de-180a-4902-9ae2-3ba37791ab23"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 43,
    Value = Guid.Parse("98037f7b-6dea-4ba5-b221-7cd2bfc0a497"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 94,
    Value = Guid.Parse("b35dc87d-6b52-4256-99cd-ad82032e0453"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 98,
    Value = Guid.Parse("e4bf69a5-ebb7-4cd2-8c05-268ed84d4fd8"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 48,
    Value = Guid.Parse("5d8408a7-55ce-4dc0-8e4e-dff44d52f43a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("7175795f-435a-4086-b60c-4f47509686b2"),
},
            new Guiduniqueidentifier0M
{
    Id = 102,
    Value = Guid.Parse("0868d05a-d55e-4f1d-bc5e-bdc47abbf8c2"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 105,
    Value = Guid.Parse("de3b2497-1f40-41ac-b058-6ac6ab5789cc"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 57,
    Value = Guid.Parse("7a02a275-d070-4326-ab21-4aff95dda9ec"),
    NullableValue = Guid.Parse("eee9dbcd-0b67-4a69-875d-dd21c5b901ea"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 114,
    Value = Guid.Parse("1da49507-7ee3-4273-9c65-7ed176985d00"),
    ModelInner = null,
    NullableValue = Guid.Parse("913c32f4-0ed4-4905-bde6-afcc578d5014"),
},
            new Guiduniqueidentifier0M
{
    Id = 118,
    Value = Guid.Parse("9c5e1d3c-5403-4a11-9355-b34a697822ae"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 66,
    Value = Guid.Parse("e1204ca7-ba41-416c-8743-025bc2a8c0b2"),
    NullableValue = Guid.Parse("d44c534c-963e-4405-a417-9e5139021f32"),
},
    NullableValue = Guid.Parse("eb624334-67fe-41b0-9def-22fcad1aa51f"),
},
            new Guiduniqueidentifier0M
{
    Id = 125,
    Value = Guid.Parse("acd78db5-5ffb-4dcf-bebb-e9c88c39d009"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 131,
    Value = Guid.Parse("5eeb6edc-9021-42d0-ade7-75ba68bb15d2"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 72,
    Value = Guid.Parse("cee7aed2-965a-4f21-944f-779d777f73ab"),
    NullableValue = Guid.Parse("beb42d33-61fb-4678-b967-977c172eb4ca"),
},
    NullableValue = Guid.Parse("69146c3c-7444-49ad-8549-fc5c072ced0b"),
},
            new Guiduniqueidentifier0M
{
    Id = 138,
    Value = Guid.Parse("b52c76c2-5ca8-41e4-b3e9-bf9de3985bf6"),
    ModelInner = null,
    NullableValue = Guid.Parse("6aa9a281-9139-4cb6-be78-47a349a77506"),
},
            new Guiduniqueidentifier0M
{
    Id = 144,
    Value = Guid.Parse("77551d24-5667-4d92-8855-26338b999211"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 73,
    Value = Guid.Parse("b5e5c99b-fc40-40bf-904c-7b2c6b4034ab"),
    NullableValue = Guid.Parse("05cfbe3c-c3b0-4eda-b8eb-63c5e9bdadbd"),
},
    NullableValue = Guid.Parse("a685057c-d3ee-4775-b3a2-3e17c066e852"),
},
            new Guiduniqueidentifier0M
{
    Id = 147,
    Value = Guid.Parse("355e2fb9-59a1-4ae3-b753-9b0a8565e0cc"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 152,
    Value = Guid.Parse("63fb84b2-3d48-4886-a969-bcd5acfaa03d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 75,
    Value = Guid.Parse("3413de80-5ab2-4445-a1d0-dce196b3d5c6"),
    NullableValue = Guid.Parse("d458376f-fa28-470d-ab4a-b3b93f38a38f"),
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[2], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[3], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[4], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 138;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[2], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[3], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[4], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[29], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 9, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 29, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[29], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 39, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 60, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[29], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 114, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 58, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[29], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 72, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 29, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 144, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a5b4fc90-827f-4d95-a24f-0a900c37be1c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("016dbf57-1704-4845-919c-9902880454f6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a66dd6df-2979-49be-a573-0ed7d5d2c3c1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("28a835a7-4f1e-4a92-82ae-307c494171a9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("88ca2acb-2c42-43dd-83c8-c76e49fd8a26"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e6f0edf4-b6e3-4f6c-be89-f65e06abef7e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c9a9ff74-4fc2-4f65-8517-d059b26acffb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("68e34f86-8b54-4e73-acb5-7280348d32ff"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e04b995a-5e37-472e-a574-f0722dc2f3b9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cf256a1f-2e21-4303-b268-337dde459532"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63c543f5-44ed-4735-86b3-816f630eb366"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5b60571d-0a59-4792-895b-349f63c33e83"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2866670f-8550-4159-a99e-a51ebf5e1607"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("967350d5-8f62-4121-a6ae-6274bff150f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f6db506c-3c6e-407d-a805-4f494854dc9d"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f0737788-05d8-47bd-9b79-52da8f2d42ff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3347859-1011-4093-af3d-848705d35737"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("23a876a6-d0a4-4627-9151-f35977ecc6cb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a71cdfcf-b5cd-4700-afa6-f7e70731273d"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d836c42f-c584-4313-8a27-b6ae02a761a2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8395c5e0-a580-44b1-8901-b4ca18031c33"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14c6ff90-5943-4874-bb64-d2497a3fc48c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1b782de3-fe49-44cd-ac32-15e662a4e6c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d128a3cb-83bf-417d-bfae-2adb0999c949"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b097d62-3c0a-4c22-8607-3d3db8a5765e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c8499ad5-c4aa-40be-8772-51208e4ebb92"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a00bde78-29aa-43f6-a58e-0fb2b546fc51"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fe4118e1-09a0-4780-9f75-59f5211a4ff0"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9a455734-e12b-4ea2-9cd8-2d9448dfa661"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fb653430-ad1e-4d37-aac7-e6ccb7f329b4"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e3af0789-4152-4a27-b16d-aa94ea246cf8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e74ffe0-e0cc-49fc-a68d-0ba63e055cdc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db9ae703-7bbd-4317-ace2-6999b564e024"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("611f5a8b-28a7-458b-af3b-abf7ef60ebd2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e7c69fff-d098-408c-89ec-d101546c807c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4ea3b58-53b0-4b9f-87d3-add38c94efa5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("250e60de-180a-4902-9ae2-3ba37791ab23"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("98037f7b-6dea-4ba5-b221-7cd2bfc0a497"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b35dc87d-6b52-4256-99cd-ad82032e0453"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e4bf69a5-ebb7-4cd2-8c05-268ed84d4fd8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5d8408a7-55ce-4dc0-8e4e-dff44d52f43a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7175795f-435a-4086-b60c-4f47509686b2"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0868d05a-d55e-4f1d-bc5e-bdc47abbf8c2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("de3b2497-1f40-41ac-b058-6ac6ab5789cc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7a02a275-d070-4326-ab21-4aff95dda9ec"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("eee9dbcd-0b67-4a69-875d-dd21c5b901ea"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1da49507-7ee3-4273-9c65-7ed176985d00"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("913c32f4-0ed4-4905-bde6-afcc578d5014"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c5e1d3c-5403-4a11-9355-b34a697822ae"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e1204ca7-ba41-416c-8743-025bc2a8c0b2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d44c534c-963e-4405-a417-9e5139021f32"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("eb624334-67fe-41b0-9def-22fcad1aa51f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("acd78db5-5ffb-4dcf-bebb-e9c88c39d009"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5eeb6edc-9021-42d0-ade7-75ba68bb15d2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cee7aed2-965a-4f21-944f-779d777f73ab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("beb42d33-61fb-4678-b967-977c172eb4ca"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("69146c3c-7444-49ad-8549-fc5c072ced0b"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b52c76c2-5ca8-41e4-b3e9-bf9de3985bf6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6aa9a281-9139-4cb6-be78-47a349a77506"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77551d24-5667-4d92-8855-26338b999211"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b5e5c99b-fc40-40bf-904c-7b2c6b4034ab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("05cfbe3c-c3b0-4eda-b8eb-63c5e9bdadbd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a685057c-d3ee-4775-b3a2-3e17c066e852"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("355e2fb9-59a1-4ae3-b753-9b0a8565e0cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63fb84b2-3d48-4886-a969-bcd5acfaa03d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3413de80-5ab2-4445-a1d0-dce196b3d5c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d458376f-fa28-470d-ab4a-b3b93f38a38f"))));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a5b4fc90-827f-4d95-a24f-0a900c37be1c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("016dbf57-1704-4845-919c-9902880454f6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a66dd6df-2979-49be-a573-0ed7d5d2c3c1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("28a835a7-4f1e-4a92-82ae-307c494171a9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("88ca2acb-2c42-43dd-83c8-c76e49fd8a26"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e6f0edf4-b6e3-4f6c-be89-f65e06abef7e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c9a9ff74-4fc2-4f65-8517-d059b26acffb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("68e34f86-8b54-4e73-acb5-7280348d32ff"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e04b995a-5e37-472e-a574-f0722dc2f3b9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cf256a1f-2e21-4303-b268-337dde459532"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63c543f5-44ed-4735-86b3-816f630eb366"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5b60571d-0a59-4792-895b-349f63c33e83"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2866670f-8550-4159-a99e-a51ebf5e1607"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("967350d5-8f62-4121-a6ae-6274bff150f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f6db506c-3c6e-407d-a805-4f494854dc9d"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f0737788-05d8-47bd-9b79-52da8f2d42ff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3347859-1011-4093-af3d-848705d35737"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("23a876a6-d0a4-4627-9151-f35977ecc6cb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a71cdfcf-b5cd-4700-afa6-f7e70731273d"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d836c42f-c584-4313-8a27-b6ae02a761a2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8395c5e0-a580-44b1-8901-b4ca18031c33"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14c6ff90-5943-4874-bb64-d2497a3fc48c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1b782de3-fe49-44cd-ac32-15e662a4e6c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d128a3cb-83bf-417d-bfae-2adb0999c949"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b097d62-3c0a-4c22-8607-3d3db8a5765e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c8499ad5-c4aa-40be-8772-51208e4ebb92"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a00bde78-29aa-43f6-a58e-0fb2b546fc51"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fe4118e1-09a0-4780-9f75-59f5211a4ff0"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9a455734-e12b-4ea2-9cd8-2d9448dfa661"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fb653430-ad1e-4d37-aac7-e6ccb7f329b4"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e3af0789-4152-4a27-b16d-aa94ea246cf8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e74ffe0-e0cc-49fc-a68d-0ba63e055cdc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db9ae703-7bbd-4317-ace2-6999b564e024"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("611f5a8b-28a7-458b-af3b-abf7ef60ebd2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e7c69fff-d098-408c-89ec-d101546c807c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4ea3b58-53b0-4b9f-87d3-add38c94efa5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("250e60de-180a-4902-9ae2-3ba37791ab23"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("98037f7b-6dea-4ba5-b221-7cd2bfc0a497"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b35dc87d-6b52-4256-99cd-ad82032e0453"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e4bf69a5-ebb7-4cd2-8c05-268ed84d4fd8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5d8408a7-55ce-4dc0-8e4e-dff44d52f43a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7175795f-435a-4086-b60c-4f47509686b2"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0868d05a-d55e-4f1d-bc5e-bdc47abbf8c2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("de3b2497-1f40-41ac-b058-6ac6ab5789cc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7a02a275-d070-4326-ab21-4aff95dda9ec"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("eee9dbcd-0b67-4a69-875d-dd21c5b901ea"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1da49507-7ee3-4273-9c65-7ed176985d00"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("913c32f4-0ed4-4905-bde6-afcc578d5014"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c5e1d3c-5403-4a11-9355-b34a697822ae"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e1204ca7-ba41-416c-8743-025bc2a8c0b2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d44c534c-963e-4405-a417-9e5139021f32"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("eb624334-67fe-41b0-9def-22fcad1aa51f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("acd78db5-5ffb-4dcf-bebb-e9c88c39d009"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5eeb6edc-9021-42d0-ade7-75ba68bb15d2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cee7aed2-965a-4f21-944f-779d777f73ab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("beb42d33-61fb-4678-b967-977c172eb4ca"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("69146c3c-7444-49ad-8549-fc5c072ced0b"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b52c76c2-5ca8-41e4-b3e9-bf9de3985bf6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6aa9a281-9139-4cb6-be78-47a349a77506"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77551d24-5667-4d92-8855-26338b999211"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b5e5c99b-fc40-40bf-904c-7b2c6b4034ab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("05cfbe3c-c3b0-4eda-b8eb-63c5e9bdadbd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a685057c-d3ee-4775-b3a2-3e17c066e852"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("355e2fb9-59a1-4ae3-b753-9b0a8565e0cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63fb84b2-3d48-4886-a969-bcd5acfaa03d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3413de80-5ab2-4445-a1d0-dce196b3d5c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d458376f-fa28-470d-ab4a-b3b93f38a38f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


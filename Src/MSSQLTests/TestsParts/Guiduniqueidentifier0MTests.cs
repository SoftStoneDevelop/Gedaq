

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
    Id = 6,
    Value = Guid.Parse("3851a190-a781-465a-855e-ea347674fd6b"),
    ModelInner = null,
    NullableValue = Guid.Parse("c689a914-29ed-459f-a69d-f85a8597f447"),
},
            new Guiduniqueidentifier0M
{
    Id = 8,
    Value = Guid.Parse("03edcfa5-f6a8-4521-8706-4edf69c6774a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 7,
    Value = Guid.Parse("b2a90867-849b-4961-bc9b-0d212e3292e4"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 10,
    Value = Guid.Parse("00f33f91-dfaa-46b1-b559-e3bb54e78dc5"),
    ModelInner = null,
    NullableValue = Guid.Parse("e1716405-64b5-4fbc-ac85-366e660648f6"),
},
            new Guiduniqueidentifier0M
{
    Id = 17,
    Value = Guid.Parse("bc02dd2f-b606-4dce-a352-8d6241853024"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 15,
    Value = Guid.Parse("85f4cfe5-6e34-455f-a79a-421b153ca452"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a1b61e8f-3fe7-4c6e-b6a1-2357116e85ff"),
},
            new Guiduniqueidentifier0M
{
    Id = 18,
    Value = Guid.Parse("8a13d5ff-9f28-4f3f-9c29-384bfde5ff15"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 22,
    Value = Guid.Parse("fedf2341-d2b4-43c6-ae94-35eccc78719b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 18,
    Value = Guid.Parse("25c2b164-31ce-4de4-adfd-52a9b0dfd7ab"),
    NullableValue = Guid.Parse("d8fc38bf-f38c-44c8-8bf7-f093fee42221"),
},
    NullableValue = Guid.Parse("8d96408c-2ec0-429a-b093-aa545201d412"),
},
            new Guiduniqueidentifier0M
{
    Id = 28,
    Value = Guid.Parse("72f72d61-7698-4019-bbab-415a6efaa1f7"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 36,
    Value = Guid.Parse("92b36491-8007-491f-a1cf-5c6b6bd94d4f"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 27,
    Value = Guid.Parse("21dc1ac1-0daa-4648-bb15-04bc7ce8b107"),
    NullableValue = Guid.Parse("b1dbc53b-a4be-4056-845f-1505751626c7"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 37,
    Value = Guid.Parse("4e1a9d86-9174-4d0e-8143-b0a565aa204d"),
    ModelInner = null,
    NullableValue = Guid.Parse("a6f5b553-082f-43dc-8e65-5aa769c1ff2c"),
},
            new Guiduniqueidentifier0M
{
    Id = 42,
    Value = Guid.Parse("873c78b3-a76b-4ba6-93b0-070dec018431"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 30,
    Value = Guid.Parse("32ac65c5-b2a6-4eb6-b694-0f230446a60d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 44,
    Value = Guid.Parse("391dd40f-9743-4e69-b160-ac1d55bf24dd"),
    ModelInner = null,
    NullableValue = Guid.Parse("c7805860-3c4b-43b6-b743-921c476ac517"),
},
            new Guiduniqueidentifier0M
{
    Id = 51,
    Value = Guid.Parse("4e1f87f7-fea3-4dd9-ae75-933d19fe9e64"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 39,
    Value = Guid.Parse("9fa8f415-b122-4754-9493-f4ec0ed17469"),
    NullableValue = Guid.Parse("294c770c-ad6c-4fc1-9755-e076627fc074"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 52,
    Value = Guid.Parse("4242738c-fe38-4e9b-b0fe-34307922c2f2"),
    ModelInner = null,
    NullableValue = Guid.Parse("74f12b36-932a-4169-9665-c69c984155b3"),
},
            new Guiduniqueidentifier0M
{
    Id = 55,
    Value = Guid.Parse("2eef7f98-e1d7-45a6-91b2-9be781796bb8"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 40,
    Value = Guid.Parse("14554c5e-49e2-448a-81f4-0562b3836520"),
    NullableValue = Guid.Parse("271084c7-7fd1-43a3-adbd-6d0a69f9f835"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 57,
    Value = Guid.Parse("a78cc635-b2bb-4960-bc83-ba1b1792c9d6"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 58,
    Value = Guid.Parse("0e533d92-ef98-425e-87ff-3b499cb6dd3b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 42,
    Value = Guid.Parse("2bb3b577-c7c7-4b6e-8148-63895cc4ac07"),
    NullableValue = Guid.Parse("31b921b5-1257-468f-b5cf-410a63560b27"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 64,
    Value = Guid.Parse("5aed6cc1-27a8-49b1-85e6-301c07fe01fb"),
    ModelInner = null,
    NullableValue = Guid.Parse("0a72b5b2-3e98-455b-88ae-72f686a7ffa1"),
},
            new Guiduniqueidentifier0M
{
    Id = 73,
    Value = Guid.Parse("2f4494af-c727-409f-bdf8-bfabb9d77111"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 49,
    Value = Guid.Parse("36a95d39-43b3-4feb-bedf-837ae9cf2245"),
    NullableValue = Guid.Parse("b46f6dc3-1803-4519-9a36-3c41d0e3b7c9"),
},
    NullableValue = Guid.Parse("db0cd5a7-c40c-4506-9fee-5e38a6972969"),
},
            new Guiduniqueidentifier0M
{
    Id = 81,
    Value = Guid.Parse("811d5403-b6f1-4f76-bd24-d881c22f3297"),
    ModelInner = null,
    NullableValue = Guid.Parse("147694e2-6729-450e-869b-47c6961566cd"),
},
            new Guiduniqueidentifier0M
{
    Id = 85,
    Value = Guid.Parse("8d41ad81-153f-4f7d-a0b1-f2f2f691d02a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 52,
    Value = Guid.Parse("6e868b50-df8f-4bb7-8428-791e36cda58b"),
    NullableValue = Guid.Parse("6727a246-7b4d-46f9-b474-cb2ac08f4fdd"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 93,
    Value = Guid.Parse("77994345-1f12-49a3-97b7-52ceeb23d4b8"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 97,
    Value = Guid.Parse("d6d8249e-21ea-4b94-a880-59eac00cde24"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 58,
    Value = Guid.Parse("b500f322-5957-4677-8d81-4809c94a443d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 99,
    Value = Guid.Parse("01862161-b3f1-48bd-ad46-103b75d46e37"),
    ModelInner = null,
    NullableValue = Guid.Parse("f1b3cd01-60a0-4610-8236-a08ff5a829bc"),
},
            new Guiduniqueidentifier0M
{
    Id = 100,
    Value = Guid.Parse("2d659911-4c19-42c0-8339-cf9e5ae97d0d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 62,
    Value = Guid.Parse("b78c87d2-5f82-4359-8dc9-b91537bee665"),
    NullableValue = Guid.Parse("ac0724e6-dae8-4b11-a305-a9203dbe65c4"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 101,
    Value = Guid.Parse("4acf65eb-b3c9-4919-b455-4236eb4c700f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 108,
    Value = Guid.Parse("939c1f4d-88bf-4806-86b6-e6bf0e16616e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 69,
    Value = Guid.Parse("1d2e163d-2e20-445f-849d-a929bb73ad80"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 115,
    Value = Guid.Parse("77c1a500-65e3-4e52-8deb-a8addfb3a797"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 120,
    Value = Guid.Parse("c59ff83d-4c44-4841-acfa-c090511f19f8"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 72,
    Value = Guid.Parse("08d8661f-a6b7-4610-b8da-dce40d2b435c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f74f19d8-d566-405a-b80b-422fc7bc77d4"),
},
            new Guiduniqueidentifier0M
{
    Id = 128,
    Value = Guid.Parse("3389819f-884b-40cb-8643-8822eb07089a"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 132,
    Value = Guid.Parse("6f6d8c7f-3886-4aae-98a8-885b43449500"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 80,
    Value = Guid.Parse("d1fa2e89-7dd8-4202-b401-db0fbe62e5d3"),
    NullableValue = Guid.Parse("7df0cc56-1ba6-470a-9e2e-e8c2ff9bae8b"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 136,
    Value = Guid.Parse("5797d12b-88d5-4823-97fb-9ea506124aec"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 139,
    Value = Guid.Parse("ce8a6282-3e7c-47ef-bef4-d92e8b6e0600"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 85,
    Value = Guid.Parse("464d7d45-eb00-4faa-963d-c391f2757492"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 144,
    Value = Guid.Parse("80ee8966-0955-42bd-b63a-e4856b712170"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 150,
    Value = Guid.Parse("d50c6c02-ad35-47bc-8c0f-de3a38538574"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 90,
    Value = Guid.Parse("c59ccd16-ac73-42cb-8bbb-09b3401b5baa"),
    NullableValue = Guid.Parse("cfa58737-f56c-46d2-85db-79fecf543957"),
},
    NullableValue = Guid.Parse("1f6a0436-be40-405c-8abd-a9f95c1fed39"),
},
            new Guiduniqueidentifier0M
{
    Id = 156,
    Value = Guid.Parse("db0e3d7c-fead-4c6d-9ca2-d2827f2e8dc8"),
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 55, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 51, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 93, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 139, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 57, query1, 6, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[33],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 99, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 10, query1, 144, query2))
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 115, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 128, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 132, 36))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 139);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                Guiduniqueidentifier0M.AssertModel(models[0],_testData[20], false);
                Guiduniqueidentifier0M.AssertModel(models[1],_testData[21], false);
                Guiduniqueidentifier0M.AssertModel(models[2],_testData[22], false);
                Guiduniqueidentifier0M.AssertModel(models[3],_testData[23], false);
                Guiduniqueidentifier0M.AssertModel(models[4],_testData[24], false);
                Guiduniqueidentifier0M.AssertModel(models[5],_testData[25], false);
                Guiduniqueidentifier0M.AssertModel(models[6],_testData[26], false);
                Guiduniqueidentifier0M.AssertModel(models[7],_testData[27], false);
                Guiduniqueidentifier0M.AssertModel(models[8],_testData[28], false);
                Guiduniqueidentifier0M.AssertModel(models[9],_testData[29], false);
                Guiduniqueidentifier0M.AssertModel(models[10],_testData[30], false);
                Guiduniqueidentifier0M.AssertModel(models[11],_testData[31], false);
                Guiduniqueidentifier0M.AssertModel(models[12],_testData[32], false);
                Guiduniqueidentifier0M.AssertModel(models[13],_testData[33], false);
                Guiduniqueidentifier0M.AssertModel(models[14],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3851a190-a781-465a-855e-ea347674fd6b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c689a914-29ed-459f-a69d-f85a8597f447"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03edcfa5-f6a8-4521-8706-4edf69c6774a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b2a90867-849b-4961-bc9b-0d212e3292e4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00f33f91-dfaa-46b1-b559-e3bb54e78dc5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e1716405-64b5-4fbc-ac85-366e660648f6"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc02dd2f-b606-4dce-a352-8d6241853024"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("85f4cfe5-6e34-455f-a79a-421b153ca452"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a1b61e8f-3fe7-4c6e-b6a1-2357116e85ff"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a13d5ff-9f28-4f3f-9c29-384bfde5ff15"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fedf2341-d2b4-43c6-ae94-35eccc78719b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("25c2b164-31ce-4de4-adfd-52a9b0dfd7ab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d8fc38bf-f38c-44c8-8bf7-f093fee42221"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8d96408c-2ec0-429a-b093-aa545201d412"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72f72d61-7698-4019-bbab-415a6efaa1f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("92b36491-8007-491f-a1cf-5c6b6bd94d4f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("21dc1ac1-0daa-4648-bb15-04bc7ce8b107"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b1dbc53b-a4be-4056-845f-1505751626c7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4e1a9d86-9174-4d0e-8143-b0a565aa204d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a6f5b553-082f-43dc-8e65-5aa769c1ff2c"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("873c78b3-a76b-4ba6-93b0-070dec018431"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("32ac65c5-b2a6-4eb6-b694-0f230446a60d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("391dd40f-9743-4e69-b160-ac1d55bf24dd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c7805860-3c4b-43b6-b743-921c476ac517"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4e1f87f7-fea3-4dd9-ae75-933d19fe9e64"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9fa8f415-b122-4754-9493-f4ec0ed17469"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("294c770c-ad6c-4fc1-9755-e076627fc074"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4242738c-fe38-4e9b-b0fe-34307922c2f2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("74f12b36-932a-4169-9665-c69c984155b3"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2eef7f98-e1d7-45a6-91b2-9be781796bb8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("14554c5e-49e2-448a-81f4-0562b3836520"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("271084c7-7fd1-43a3-adbd-6d0a69f9f835"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a78cc635-b2bb-4960-bc83-ba1b1792c9d6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e533d92-ef98-425e-87ff-3b499cb6dd3b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2bb3b577-c7c7-4b6e-8148-63895cc4ac07"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("31b921b5-1257-468f-b5cf-410a63560b27"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5aed6cc1-27a8-49b1-85e6-301c07fe01fb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0a72b5b2-3e98-455b-88ae-72f686a7ffa1"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f4494af-c727-409f-bdf8-bfabb9d77111"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("36a95d39-43b3-4feb-bedf-837ae9cf2245"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b46f6dc3-1803-4519-9a36-3c41d0e3b7c9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("db0cd5a7-c40c-4506-9fee-5e38a6972969"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("811d5403-b6f1-4f76-bd24-d881c22f3297"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("147694e2-6729-450e-869b-47c6961566cd"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8d41ad81-153f-4f7d-a0b1-f2f2f691d02a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6e868b50-df8f-4bb7-8428-791e36cda58b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6727a246-7b4d-46f9-b474-cb2ac08f4fdd"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77994345-1f12-49a3-97b7-52ceeb23d4b8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6d8249e-21ea-4b94-a880-59eac00cde24"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b500f322-5957-4677-8d81-4809c94a443d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01862161-b3f1-48bd-ad46-103b75d46e37"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f1b3cd01-60a0-4610-8236-a08ff5a829bc"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d659911-4c19-42c0-8339-cf9e5ae97d0d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b78c87d2-5f82-4359-8dc9-b91537bee665"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ac0724e6-dae8-4b11-a305-a9203dbe65c4"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4acf65eb-b3c9-4919-b455-4236eb4c700f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("939c1f4d-88bf-4806-86b6-e6bf0e16616e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1d2e163d-2e20-445f-849d-a929bb73ad80"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77c1a500-65e3-4e52-8deb-a8addfb3a797"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c59ff83d-4c44-4841-acfa-c090511f19f8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("08d8661f-a6b7-4610-b8da-dce40d2b435c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f74f19d8-d566-405a-b80b-422fc7bc77d4"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3389819f-884b-40cb-8643-8822eb07089a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6f6d8c7f-3886-4aae-98a8-885b43449500"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d1fa2e89-7dd8-4202-b401-db0fbe62e5d3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7df0cc56-1ba6-470a-9e2e-e8c2ff9bae8b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5797d12b-88d5-4823-97fb-9ea506124aec"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ce8a6282-3e7c-47ef-bef4-d92e8b6e0600"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("464d7d45-eb00-4faa-963d-c391f2757492"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80ee8966-0955-42bd-b63a-e4856b712170"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d50c6c02-ad35-47bc-8c0f-de3a38538574"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c59ccd16-ac73-42cb-8bbb-09b3401b5baa"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cfa58737-f56c-46d2-85db-79fecf543957"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1f6a0436-be40-405c-8abd-a9f95c1fed39"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db0e3d7c-fead-4c6d-9ca2-d2827f2e8dc8"))));//Value

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3851a190-a781-465a-855e-ea347674fd6b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c689a914-29ed-459f-a69d-f85a8597f447"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03edcfa5-f6a8-4521-8706-4edf69c6774a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b2a90867-849b-4961-bc9b-0d212e3292e4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00f33f91-dfaa-46b1-b559-e3bb54e78dc5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e1716405-64b5-4fbc-ac85-366e660648f6"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc02dd2f-b606-4dce-a352-8d6241853024"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("85f4cfe5-6e34-455f-a79a-421b153ca452"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a1b61e8f-3fe7-4c6e-b6a1-2357116e85ff"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a13d5ff-9f28-4f3f-9c29-384bfde5ff15"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fedf2341-d2b4-43c6-ae94-35eccc78719b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("25c2b164-31ce-4de4-adfd-52a9b0dfd7ab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d8fc38bf-f38c-44c8-8bf7-f093fee42221"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8d96408c-2ec0-429a-b093-aa545201d412"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72f72d61-7698-4019-bbab-415a6efaa1f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("92b36491-8007-491f-a1cf-5c6b6bd94d4f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("21dc1ac1-0daa-4648-bb15-04bc7ce8b107"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b1dbc53b-a4be-4056-845f-1505751626c7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4e1a9d86-9174-4d0e-8143-b0a565aa204d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a6f5b553-082f-43dc-8e65-5aa769c1ff2c"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("873c78b3-a76b-4ba6-93b0-070dec018431"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("32ac65c5-b2a6-4eb6-b694-0f230446a60d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("391dd40f-9743-4e69-b160-ac1d55bf24dd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c7805860-3c4b-43b6-b743-921c476ac517"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4e1f87f7-fea3-4dd9-ae75-933d19fe9e64"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9fa8f415-b122-4754-9493-f4ec0ed17469"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("294c770c-ad6c-4fc1-9755-e076627fc074"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4242738c-fe38-4e9b-b0fe-34307922c2f2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("74f12b36-932a-4169-9665-c69c984155b3"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2eef7f98-e1d7-45a6-91b2-9be781796bb8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("14554c5e-49e2-448a-81f4-0562b3836520"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("271084c7-7fd1-43a3-adbd-6d0a69f9f835"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a78cc635-b2bb-4960-bc83-ba1b1792c9d6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e533d92-ef98-425e-87ff-3b499cb6dd3b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2bb3b577-c7c7-4b6e-8148-63895cc4ac07"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("31b921b5-1257-468f-b5cf-410a63560b27"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5aed6cc1-27a8-49b1-85e6-301c07fe01fb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0a72b5b2-3e98-455b-88ae-72f686a7ffa1"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f4494af-c727-409f-bdf8-bfabb9d77111"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("36a95d39-43b3-4feb-bedf-837ae9cf2245"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b46f6dc3-1803-4519-9a36-3c41d0e3b7c9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("db0cd5a7-c40c-4506-9fee-5e38a6972969"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("811d5403-b6f1-4f76-bd24-d881c22f3297"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("147694e2-6729-450e-869b-47c6961566cd"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8d41ad81-153f-4f7d-a0b1-f2f2f691d02a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6e868b50-df8f-4bb7-8428-791e36cda58b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6727a246-7b4d-46f9-b474-cb2ac08f4fdd"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77994345-1f12-49a3-97b7-52ceeb23d4b8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6d8249e-21ea-4b94-a880-59eac00cde24"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b500f322-5957-4677-8d81-4809c94a443d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01862161-b3f1-48bd-ad46-103b75d46e37"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f1b3cd01-60a0-4610-8236-a08ff5a829bc"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d659911-4c19-42c0-8339-cf9e5ae97d0d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b78c87d2-5f82-4359-8dc9-b91537bee665"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ac0724e6-dae8-4b11-a305-a9203dbe65c4"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4acf65eb-b3c9-4919-b455-4236eb4c700f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("939c1f4d-88bf-4806-86b6-e6bf0e16616e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1d2e163d-2e20-445f-849d-a929bb73ad80"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77c1a500-65e3-4e52-8deb-a8addfb3a797"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c59ff83d-4c44-4841-acfa-c090511f19f8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("08d8661f-a6b7-4610-b8da-dce40d2b435c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f74f19d8-d566-405a-b80b-422fc7bc77d4"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3389819f-884b-40cb-8643-8822eb07089a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6f6d8c7f-3886-4aae-98a8-885b43449500"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d1fa2e89-7dd8-4202-b401-db0fbe62e5d3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7df0cc56-1ba6-470a-9e2e-e8c2ff9bae8b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5797d12b-88d5-4823-97fb-9ea506124aec"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ce8a6282-3e7c-47ef-bef4-d92e8b6e0600"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("464d7d45-eb00-4faa-963d-c391f2757492"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80ee8966-0955-42bd-b63a-e4856b712170"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d50c6c02-ad35-47bc-8c0f-de3a38538574"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c59ccd16-ac73-42cb-8bbb-09b3401b5baa"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cfa58737-f56c-46d2-85db-79fecf543957"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1f6a0436-be40-405c-8abd-a9f95c1fed39"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db0e3d7c-fead-4c6d-9ca2-d2827f2e8dc8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


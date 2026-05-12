

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
    Id = 9,
    Value = Guid.Parse("bfffa0d3-1338-4bda-a78d-1d022de84767"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 16,
    Value = Guid.Parse("e5f90a48-609a-4fbb-b1b5-1104148d2e6d"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 2,
    Value = Guid.Parse("749b91dc-3896-4e91-a006-5fe248a312c2"),
    NullableValue = Guid.Parse("275b9a54-aaa8-4365-a7d2-b7871b163aac"),
},
    NullableValue = Guid.Parse("8e5392d9-c60b-429c-bf39-05a8b6470295"),
},
            new GuiduniqueidentifierE0M
{
    Id = 25,
    Value = Guid.Parse("11a9e09a-e267-42d7-bf28-9bacd94adc9b"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 26,
    Value = Guid.Parse("65326118-ef77-40f7-8ea9-b9d08477de27"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 4,
    Value = Guid.Parse("fe811fb9-9245-4430-aa40-8cc8eca3380e"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("1d841bcf-a529-45e0-8e7f-4d9b6997c501"),
},
            new GuiduniqueidentifierE0M
{
    Id = 30,
    Value = Guid.Parse("710616f6-e4bd-4691-ad4b-32d322830fa2"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 37,
    Value = Guid.Parse("2b48e601-f216-43d5-973b-f0c59491e8c9"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 13,
    Value = Guid.Parse("fdc1db88-8404-40e0-b026-203e030a5f43"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("81619f00-c4d8-4b4a-8e68-202e1004f005"),
},
            new GuiduniqueidentifierE0M
{
    Id = 38,
    Value = Guid.Parse("f154c354-b3c9-485f-860a-278ff0f2f2f7"),
    ModelInner = null,
    NullableValue = Guid.Parse("d494c46f-6be3-4b52-a8ae-7b9cd6c0ed07"),
},
            new GuiduniqueidentifierE0M
{
    Id = 47,
    Value = Guid.Parse("a55e198f-ed5b-49fe-99d3-9b383cd85a89"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 18,
    Value = Guid.Parse("19bca652-c87f-453c-8e5a-3c1527905cbf"),
    NullableValue = Guid.Parse("f8b09850-6d4f-4af5-a980-87d136362303"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 53,
    Value = Guid.Parse("4126ae74-106e-41d8-b409-2e05e0f92d17"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 56,
    Value = Guid.Parse("61411909-db8a-48a8-8be0-97078059c5d9"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 27,
    Value = Guid.Parse("1389929b-ab7d-40fe-8917-ca7fd7f0fb6a"),
    NullableValue = Guid.Parse("1e041d16-c9c6-4903-9893-97f27bcebc5b"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 57,
    Value = Guid.Parse("c63e701e-169d-4ab8-89df-ddc87728fa7e"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 66,
    Value = Guid.Parse("2ba003a8-d7ac-43fb-aef9-61d7a4f28d4d"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 30,
    Value = Guid.Parse("d52f0edf-e6e0-463e-bcd2-6e5b18581d4e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 75,
    Value = Guid.Parse("16bcee00-4580-42c0-a572-cf64a7a3f0ca"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 83,
    Value = Guid.Parse("49df9cb0-07e4-4420-8a8f-f9a3bfc1fc63"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 34,
    Value = Guid.Parse("a339e6b7-d727-4f0d-be95-56ff536970ed"),
    NullableValue = Guid.Parse("e477cac4-1e73-4764-bbed-54d4a9ec7bb4"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 85,
    Value = Guid.Parse("c6c04335-bdf2-4441-999c-451ed184aadd"),
    ModelInner = null,
    NullableValue = Guid.Parse("373f6dce-5fbe-4af9-a193-b990745014fb"),
},
            new GuiduniqueidentifierE0M
{
    Id = 91,
    Value = Guid.Parse("4fee22b5-2a15-460d-adbc-ddf629ce5fe9"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 43,
    Value = Guid.Parse("3c3cd2dd-1784-45fa-9590-19e065488f08"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 93,
    Value = Guid.Parse("31d8e352-b0b0-49fe-b87f-8e08faf40457"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 101,
    Value = Guid.Parse("41103be4-7189-445f-b1e6-67d94f5fe2dd"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 49,
    Value = Guid.Parse("e3b5ae6c-7f7d-487f-acac-68461b580e9e"),
    NullableValue = Guid.Parse("5bcd77c0-56b0-426c-9eba-0efe5d430654"),
},
    NullableValue = Guid.Parse("e16b9e43-439c-4cee-8dd1-66c5753da987"),
},
            new GuiduniqueidentifierE0M
{
    Id = 109,
    Value = Guid.Parse("5971cc13-0f24-4bd9-a35a-63fc9a5ea8cc"),
    ModelInner = null,
    NullableValue = Guid.Parse("70453568-a428-40fa-9e1e-5c20ac4b83c5"),
},
            new GuiduniqueidentifierE0M
{
    Id = 116,
    Value = Guid.Parse("0798cece-b386-436f-acfa-4e28fec67934"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 58,
    Value = Guid.Parse("245451ee-352b-4ffc-8bd7-c7679658d739"),
    NullableValue = Guid.Parse("bc6bd1ed-30c2-429d-be89-9fe7d78a868a"),
},
    NullableValue = Guid.Parse("deecdcfe-d509-4b85-aa19-d362b3d61e5a"),
},
            new GuiduniqueidentifierE0M
{
    Id = 119,
    Value = Guid.Parse("b7ff3262-6a8e-443b-88a2-141a0080e74a"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 120,
    Value = Guid.Parse("c1725d3a-5923-466f-ae8e-85504a6b51b0"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 64,
    Value = Guid.Parse("38f18697-26af-488c-ae1a-0d8a7469c39f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0dc47c69-94a9-405b-89be-b37387e747a5"),
},
            new GuiduniqueidentifierE0M
{
    Id = 129,
    Value = Guid.Parse("708ed539-5b6d-4ae4-be39-02c43d6df077"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 136,
    Value = Guid.Parse("79323229-326e-48f7-97a6-efb7e4660cff"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 69,
    Value = Guid.Parse("16d52b98-9f06-46fb-b603-56773317907a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 141,
    Value = Guid.Parse("20da8fee-762b-4778-8823-13fee7d75c66"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 150,
    Value = Guid.Parse("7f363b2a-59e7-44a6-9a3e-03e4c33cc9cc"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 73,
    Value = Guid.Parse("9272b507-04b9-4e9e-94b0-71931f7adad6"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e369fa55-9e08-447a-8cae-81041e45dc15"),
},
            new GuiduniqueidentifierE0M
{
    Id = 156,
    Value = Guid.Parse("42e9ead9-3084-4dbe-95b7-f24072fc88de"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 163,
    Value = Guid.Parse("2440363c-910c-4dfc-b52f-48564aaa574d"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 75,
    Value = Guid.Parse("22cfc4f9-b619-4324-89fe-201b3bd4a64c"),
    NullableValue = Guid.Parse("7277d3d8-01b3-4254-a465-e60b7000f828"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 172,
    Value = Guid.Parse("2ece3fec-2485-4a7e-b42c-c006e770c2f3"),
    ModelInner = null,
    NullableValue = Guid.Parse("a7c6dbcf-e503-44c4-86e2-deeab6423c06"),
},
            new GuiduniqueidentifierE0M
{
    Id = 177,
    Value = Guid.Parse("adb59d21-1f91-4114-ba46-53a9529cf665"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 76,
    Value = Guid.Parse("2c6af18e-7f9f-42da-a895-9c14f7977913"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ea46615f-db8f-4164-b92a-f775136cd5d6"),
},
            new GuiduniqueidentifierE0M
{
    Id = 184,
    Value = Guid.Parse("8b7dd2f4-7254-4da4-9d42-65326d3c1fec"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 192,
    Value = Guid.Parse("eace15ad-5adc-4d6b-9757-dea1db25b25b"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 80,
    Value = Guid.Parse("79569be2-b4aa-4598-b1e8-a11ba4da761d"),
    NullableValue = Guid.Parse("6990bdaa-b3e9-4a90-837d-f8f4dd14baff"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 199,
    Value = Guid.Parse("a0affa52-306d-4e31-bd53-5b18c8ab5b4a"),
    ModelInner = null,
    NullableValue = Guid.Parse("105ba568-652c-44d2-a24e-9ebd0601d7d4"),
},
            new GuiduniqueidentifierE0M
{
    Id = 204,
    Value = Guid.Parse("16051226-1e10-4f27-9a37-5aa2aea1e630"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 87,
    Value = Guid.Parse("5bfc2f0e-8330-4559-8a7e-c5d0e734facc"),
    NullableValue = Guid.Parse("2a04d6a6-b843-4ee1-b537-495edb10ff17"),
},
    NullableValue = Guid.Parse("019fcd5b-d108-450a-bcf8-69ad123243d7"),
},
            new GuiduniqueidentifierE0M
{
    Id = 213,
    Value = Guid.Parse("94b98a09-d84b-4159-a2c6-19f66e095a5a"),
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 9;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[4], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[5], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[6], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[28],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[29],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[30],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[30],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 26, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[30],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 56, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[31],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 129, query1, 163, query2))
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 116, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 75, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 163, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 66, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 199, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[24], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[25], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[26], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[27], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[28], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[6],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[7],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[8],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[9],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[10],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bfffa0d3-1338-4bda-a78d-1d022de84767"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e5f90a48-609a-4fbb-b1b5-1104148d2e6d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("749b91dc-3896-4e91-a006-5fe248a312c2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("275b9a54-aaa8-4365-a7d2-b7871b163aac"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8e5392d9-c60b-429c-bf39-05a8b6470295"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("11a9e09a-e267-42d7-bf28-9bacd94adc9b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("65326118-ef77-40f7-8ea9-b9d08477de27"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fe811fb9-9245-4430-aa40-8cc8eca3380e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d841bcf-a529-45e0-8e7f-4d9b6997c501"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("710616f6-e4bd-4691-ad4b-32d322830fa2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2b48e601-f216-43d5-973b-f0c59491e8c9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fdc1db88-8404-40e0-b026-203e030a5f43"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("81619f00-c4d8-4b4a-8e68-202e1004f005"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f154c354-b3c9-485f-860a-278ff0f2f2f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d494c46f-6be3-4b52-a8ae-7b9cd6c0ed07"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a55e198f-ed5b-49fe-99d3-9b383cd85a89"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("19bca652-c87f-453c-8e5a-3c1527905cbf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f8b09850-6d4f-4af5-a980-87d136362303"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4126ae74-106e-41d8-b409-2e05e0f92d17"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("61411909-db8a-48a8-8be0-97078059c5d9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1389929b-ab7d-40fe-8917-ca7fd7f0fb6a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1e041d16-c9c6-4903-9893-97f27bcebc5b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c63e701e-169d-4ab8-89df-ddc87728fa7e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2ba003a8-d7ac-43fb-aef9-61d7a4f28d4d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d52f0edf-e6e0-463e-bcd2-6e5b18581d4e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("16bcee00-4580-42c0-a572-cf64a7a3f0ca"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("49df9cb0-07e4-4420-8a8f-f9a3bfc1fc63"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a339e6b7-d727-4f0d-be95-56ff536970ed"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e477cac4-1e73-4764-bbed-54d4a9ec7bb4"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c6c04335-bdf2-4441-999c-451ed184aadd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("373f6dce-5fbe-4af9-a193-b990745014fb"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4fee22b5-2a15-460d-adbc-ddf629ce5fe9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3c3cd2dd-1784-45fa-9590-19e065488f08"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("31d8e352-b0b0-49fe-b87f-8e08faf40457"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("41103be4-7189-445f-b1e6-67d94f5fe2dd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e3b5ae6c-7f7d-487f-acac-68461b580e9e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5bcd77c0-56b0-426c-9eba-0efe5d430654"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e16b9e43-439c-4cee-8dd1-66c5753da987"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5971cc13-0f24-4bd9-a35a-63fc9a5ea8cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("70453568-a428-40fa-9e1e-5c20ac4b83c5"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0798cece-b386-436f-acfa-4e28fec67934"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("245451ee-352b-4ffc-8bd7-c7679658d739"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bc6bd1ed-30c2-429d-be89-9fe7d78a868a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("deecdcfe-d509-4b85-aa19-d362b3d61e5a"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7ff3262-6a8e-443b-88a2-141a0080e74a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c1725d3a-5923-466f-ae8e-85504a6b51b0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("38f18697-26af-488c-ae1a-0d8a7469c39f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0dc47c69-94a9-405b-89be-b37387e747a5"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("708ed539-5b6d-4ae4-be39-02c43d6df077"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("79323229-326e-48f7-97a6-efb7e4660cff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("16d52b98-9f06-46fb-b603-56773317907a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("20da8fee-762b-4778-8823-13fee7d75c66"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f363b2a-59e7-44a6-9a3e-03e4c33cc9cc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9272b507-04b9-4e9e-94b0-71931f7adad6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e369fa55-9e08-447a-8cae-81041e45dc15"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42e9ead9-3084-4dbe-95b7-f24072fc88de"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2440363c-910c-4dfc-b52f-48564aaa574d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("22cfc4f9-b619-4324-89fe-201b3bd4a64c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7277d3d8-01b3-4254-a465-e60b7000f828"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2ece3fec-2485-4a7e-b42c-c006e770c2f3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a7c6dbcf-e503-44c4-86e2-deeab6423c06"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("adb59d21-1f91-4114-ba46-53a9529cf665"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2c6af18e-7f9f-42da-a895-9c14f7977913"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ea46615f-db8f-4164-b92a-f775136cd5d6"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b7dd2f4-7254-4da4-9d42-65326d3c1fec"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eace15ad-5adc-4d6b-9757-dea1db25b25b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("79569be2-b4aa-4598-b1e8-a11ba4da761d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6990bdaa-b3e9-4a90-837d-f8f4dd14baff"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a0affa52-306d-4e31-bd53-5b18c8ab5b4a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("105ba568-652c-44d2-a24e-9ebd0601d7d4"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((204)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("16051226-1e10-4f27-9a37-5aa2aea1e630"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5bfc2f0e-8330-4559-8a7e-c5d0e734facc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2a04d6a6-b843-4ee1-b537-495edb10ff17"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019fcd5b-d108-450a-bcf8-69ad123243d7"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((213)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("94b98a09-d84b-4159-a2c6-19f66e095a5a"))));//Value

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bfffa0d3-1338-4bda-a78d-1d022de84767"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e5f90a48-609a-4fbb-b1b5-1104148d2e6d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("749b91dc-3896-4e91-a006-5fe248a312c2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("275b9a54-aaa8-4365-a7d2-b7871b163aac"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8e5392d9-c60b-429c-bf39-05a8b6470295"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("11a9e09a-e267-42d7-bf28-9bacd94adc9b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("65326118-ef77-40f7-8ea9-b9d08477de27"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fe811fb9-9245-4430-aa40-8cc8eca3380e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d841bcf-a529-45e0-8e7f-4d9b6997c501"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("710616f6-e4bd-4691-ad4b-32d322830fa2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2b48e601-f216-43d5-973b-f0c59491e8c9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fdc1db88-8404-40e0-b026-203e030a5f43"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("81619f00-c4d8-4b4a-8e68-202e1004f005"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f154c354-b3c9-485f-860a-278ff0f2f2f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d494c46f-6be3-4b52-a8ae-7b9cd6c0ed07"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a55e198f-ed5b-49fe-99d3-9b383cd85a89"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("19bca652-c87f-453c-8e5a-3c1527905cbf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f8b09850-6d4f-4af5-a980-87d136362303"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4126ae74-106e-41d8-b409-2e05e0f92d17"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("61411909-db8a-48a8-8be0-97078059c5d9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1389929b-ab7d-40fe-8917-ca7fd7f0fb6a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1e041d16-c9c6-4903-9893-97f27bcebc5b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c63e701e-169d-4ab8-89df-ddc87728fa7e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2ba003a8-d7ac-43fb-aef9-61d7a4f28d4d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d52f0edf-e6e0-463e-bcd2-6e5b18581d4e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("16bcee00-4580-42c0-a572-cf64a7a3f0ca"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("49df9cb0-07e4-4420-8a8f-f9a3bfc1fc63"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a339e6b7-d727-4f0d-be95-56ff536970ed"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e477cac4-1e73-4764-bbed-54d4a9ec7bb4"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c6c04335-bdf2-4441-999c-451ed184aadd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("373f6dce-5fbe-4af9-a193-b990745014fb"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4fee22b5-2a15-460d-adbc-ddf629ce5fe9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3c3cd2dd-1784-45fa-9590-19e065488f08"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("31d8e352-b0b0-49fe-b87f-8e08faf40457"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("41103be4-7189-445f-b1e6-67d94f5fe2dd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e3b5ae6c-7f7d-487f-acac-68461b580e9e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5bcd77c0-56b0-426c-9eba-0efe5d430654"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e16b9e43-439c-4cee-8dd1-66c5753da987"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5971cc13-0f24-4bd9-a35a-63fc9a5ea8cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("70453568-a428-40fa-9e1e-5c20ac4b83c5"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0798cece-b386-436f-acfa-4e28fec67934"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("245451ee-352b-4ffc-8bd7-c7679658d739"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bc6bd1ed-30c2-429d-be89-9fe7d78a868a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("deecdcfe-d509-4b85-aa19-d362b3d61e5a"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7ff3262-6a8e-443b-88a2-141a0080e74a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c1725d3a-5923-466f-ae8e-85504a6b51b0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("38f18697-26af-488c-ae1a-0d8a7469c39f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0dc47c69-94a9-405b-89be-b37387e747a5"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("708ed539-5b6d-4ae4-be39-02c43d6df077"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("79323229-326e-48f7-97a6-efb7e4660cff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("16d52b98-9f06-46fb-b603-56773317907a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("20da8fee-762b-4778-8823-13fee7d75c66"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f363b2a-59e7-44a6-9a3e-03e4c33cc9cc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9272b507-04b9-4e9e-94b0-71931f7adad6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e369fa55-9e08-447a-8cae-81041e45dc15"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42e9ead9-3084-4dbe-95b7-f24072fc88de"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2440363c-910c-4dfc-b52f-48564aaa574d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("22cfc4f9-b619-4324-89fe-201b3bd4a64c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7277d3d8-01b3-4254-a465-e60b7000f828"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2ece3fec-2485-4a7e-b42c-c006e770c2f3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a7c6dbcf-e503-44c4-86e2-deeab6423c06"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("adb59d21-1f91-4114-ba46-53a9529cf665"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2c6af18e-7f9f-42da-a895-9c14f7977913"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ea46615f-db8f-4164-b92a-f775136cd5d6"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b7dd2f4-7254-4da4-9d42-65326d3c1fec"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eace15ad-5adc-4d6b-9757-dea1db25b25b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("79569be2-b4aa-4598-b1e8-a11ba4da761d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6990bdaa-b3e9-4a90-837d-f8f4dd14baff"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a0affa52-306d-4e31-bd53-5b18c8ab5b4a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("105ba568-652c-44d2-a24e-9ebd0601d7d4"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((204)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("16051226-1e10-4f27-9a37-5aa2aea1e630"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5bfc2f0e-8330-4559-8a7e-c5d0e734facc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2a04d6a6-b843-4ee1-b537-495edb10ff17"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019fcd5b-d108-450a-bcf8-69ad123243d7"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((213)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("94b98a09-d84b-4159-a2c6-19f66e095a5a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


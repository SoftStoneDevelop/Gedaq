

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
    Id = 3,
    Value = Guid.Parse("2d425e21-17fb-4f4b-8160-482797c043a1"),
    ModelInner = null,
    NullableValue = Guid.Parse("243c6e2b-1ea9-4347-bbdd-2c59d4d5088a"),
},
            new GuiduniqueidentifierE0M
{
    Id = 6,
    Value = Guid.Parse("b219f8ec-3068-428d-9e2b-58bd1962d77b"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 1,
    Value = Guid.Parse("d03d0889-bad3-424c-a67a-4b05ac708bf5"),
    NullableValue = Guid.Parse("6177039c-b29e-4e80-b4d9-f261d1074c1c"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 14,
    Value = Guid.Parse("134836db-8ec1-4e43-9c27-70783a23dde3"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 20,
    Value = Guid.Parse("d03ce773-814d-4f52-8f66-e0faaadc12d9"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 2,
    Value = Guid.Parse("fcd8be41-fde0-4afa-b581-747a8d9dde00"),
    NullableValue = Guid.Parse("cbd1b599-7143-4fde-93ec-eb20ad6c70ea"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 25,
    Value = Guid.Parse("e26a50e8-66ff-40e5-81e0-f44f8f9e7bb1"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 28,
    Value = Guid.Parse("9bd45b86-7450-4333-89be-537d2dc41031"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 8,
    Value = Guid.Parse("6b63109a-114a-4a5f-8cde-777013b4e227"),
    NullableValue = Guid.Parse("0a0d9d94-668d-4aa2-8e91-eee4d7f38237"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 33,
    Value = Guid.Parse("35d88e2c-1bc8-4f58-925e-229537f4213d"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 42,
    Value = Guid.Parse("37ff53de-b2e6-4bbf-9433-cad5db7123d3"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 17,
    Value = Guid.Parse("ff7968ff-42ea-47a8-83de-f0608743b7de"),
    NullableValue = Guid.Parse("1b7ec523-4e81-4949-8782-9d779b88592a"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 47,
    Value = Guid.Parse("2d3dd46f-42b4-4d17-9afb-c8e7dbcb849b"),
    ModelInner = null,
    NullableValue = Guid.Parse("306b728a-5f54-460e-a973-3aec2a0edf39"),
},
            new GuiduniqueidentifierE0M
{
    Id = 56,
    Value = Guid.Parse("cd473fe2-dd9c-47c4-9f28-e84bbf81b3a3"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 25,
    Value = Guid.Parse("ae3bcc29-57ae-4c39-a885-d91055ef6bca"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 61,
    Value = Guid.Parse("135277e0-75b9-4693-b3cd-8d1b7cd849b3"),
    ModelInner = null,
    NullableValue = Guid.Parse("8d21e508-c127-4a03-8587-72e3c67b875a"),
},
            new GuiduniqueidentifierE0M
{
    Id = 65,
    Value = Guid.Parse("d34fe772-69ac-4288-81f0-ef3b3d160404"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 31,
    Value = Guid.Parse("fba8a427-23de-4d11-b5e4-435b26b96647"),
    NullableValue = Guid.Parse("60f571dc-2e90-4c98-8783-6a3701707b63"),
},
    NullableValue = Guid.Parse("93fb0fda-248d-45df-91ea-b473d6cb7856"),
},
            new GuiduniqueidentifierE0M
{
    Id = 73,
    Value = Guid.Parse("7ec6954e-0049-483a-87a7-6d6f40e870ed"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 82,
    Value = Guid.Parse("4b01dd37-6545-4ebb-a144-13bffcb84117"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 40,
    Value = Guid.Parse("9058b715-88c9-49c4-8e8f-bf9c9fd12cec"),
    NullableValue = Guid.Parse("a6bc63ff-8642-4878-afb7-9e55f634bb24"),
},
    NullableValue = Guid.Parse("752f59db-759b-4dcf-ae87-bd7a38702a9a"),
},
            new GuiduniqueidentifierE0M
{
    Id = 84,
    Value = Guid.Parse("0131bc13-8a3c-4729-b63e-4cd41599e891"),
    ModelInner = null,
    NullableValue = Guid.Parse("e6217b89-660b-433d-9194-93fbcccb8a74"),
},
            new GuiduniqueidentifierE0M
{
    Id = 89,
    Value = Guid.Parse("dc952ee9-7c70-4864-aeb2-602c0bec6344"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 48,
    Value = Guid.Parse("71b0c1d3-c528-4457-bad7-9a864ac4e536"),
    NullableValue = Guid.Parse("c444de41-e4be-43a4-a261-e12c09c21e38"),
},
    NullableValue = Guid.Parse("2c413ded-aae1-4605-b438-08b7e9adcc62"),
},
            new GuiduniqueidentifierE0M
{
    Id = 91,
    Value = Guid.Parse("e89f6338-81ae-4892-84f3-209c2f370c27"),
    ModelInner = null,
    NullableValue = Guid.Parse("1502903b-f73d-4bdc-81fd-5a05b10f9af6"),
},
            new GuiduniqueidentifierE0M
{
    Id = 92,
    Value = Guid.Parse("d67d74b1-35e6-44df-90b7-5907a0cbeaa7"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 57,
    Value = Guid.Parse("9bca5376-1522-4616-8651-57404a79e4d0"),
    NullableValue = Guid.Parse("6983b0c7-da47-4eb8-8f53-faf997f7a51f"),
},
    NullableValue = Guid.Parse("8fe62d11-d7f6-46c0-a043-177d3f81f0dd"),
},
            new GuiduniqueidentifierE0M
{
    Id = 94,
    Value = Guid.Parse("277acbf0-377a-40b5-8b18-534f0d63d6c2"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 102,
    Value = Guid.Parse("3c49dba8-2db0-4501-ab56-77262b9a4b20"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 65,
    Value = Guid.Parse("f10f5be2-88aa-492f-888f-b4c722be4a9c"),
    NullableValue = Guid.Parse("af3782a6-c80c-45dc-b02b-caef0b7ccc8b"),
},
    NullableValue = Guid.Parse("7a1a14b8-801b-45c1-be4f-cfd05afdb7ab"),
},
            new GuiduniqueidentifierE0M
{
    Id = 104,
    Value = Guid.Parse("83b4ab70-e806-4b00-b5ff-18edb9070497"),
    ModelInner = null,
    NullableValue = Guid.Parse("539b67fd-b3f2-410e-a723-64b8fbdbb193"),
},
            new GuiduniqueidentifierE0M
{
    Id = 111,
    Value = Guid.Parse("160b4049-18be-4564-87c9-6261fed7fdb6"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 72,
    Value = Guid.Parse("798b4d22-c7d3-4e51-8977-838766ecba30"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 117,
    Value = Guid.Parse("b93e9af7-88d9-414b-a812-e59efd9f36c6"),
    ModelInner = null,
    NullableValue = Guid.Parse("35a9586a-c24e-41ff-bb6c-c502a9860c15"),
},
            new GuiduniqueidentifierE0M
{
    Id = 124,
    Value = Guid.Parse("8cea2ff5-0e38-4ab7-9e9e-d6bd236a8e85"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 81,
    Value = Guid.Parse("9bcc64f5-eb01-4fdc-a8b9-e604e8406da0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 125,
    Value = Guid.Parse("b6e16549-ff11-42c9-b132-e517654afdf7"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 127,
    Value = Guid.Parse("da65960f-665d-498c-abda-4a06fe714304"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 87,
    Value = Guid.Parse("5341fb66-b948-4fff-8445-939bf047fb47"),
    NullableValue = Guid.Parse("af68c441-72af-4505-8327-10a31be2e980"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 129,
    Value = Guid.Parse("4e342b35-7358-4cfa-ac5c-c9d2527683ac"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 133,
    Value = Guid.Parse("aee7a22d-7e44-4690-a902-827b5ff8287f"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 90,
    Value = Guid.Parse("b3af4f68-404b-400e-a5bc-c101f231dde7"),
    NullableValue = Guid.Parse("cc3e4ecb-89ec-4fef-b5af-954c16b514fd"),
},
    NullableValue = Guid.Parse("94fed4e8-8d41-4160-badb-2d9067f17f34"),
},
            new GuiduniqueidentifierE0M
{
    Id = 140,
    Value = Guid.Parse("21dca268-abd8-4f96-92e6-10958cea1a17"),
    ModelInner = null,
    NullableValue = Guid.Parse("faa39a90-7115-4771-abd6-f34836a8eca9"),
},
            new GuiduniqueidentifierE0M
{
    Id = 148,
    Value = Guid.Parse("7ad885a2-d9b9-4496-8cf1-a6ed4e6529e8"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 99,
    Value = Guid.Parse("7cbdef01-82f4-4014-941f-5c11f28fc7b2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 154,
    Value = Guid.Parse("af6c404e-e882-4a36-8e0a-d8b2ec88c781"),
    ModelInner = null,
    NullableValue = Guid.Parse("b284c22f-8234-400d-b77c-1e61e1129fcf"),
},
            new GuiduniqueidentifierE0M
{
    Id = 158,
    Value = Guid.Parse("0885f268-4835-4679-a64b-0f6dde690d49"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 101,
    Value = Guid.Parse("0b17b850-207d-4dde-803d-099466c2186f"),
    NullableValue = Guid.Parse("74bda38b-27c8-4e92-8933-4e01149390c8"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 160,
    Value = Guid.Parse("07f258e1-67f0-422c-83fc-722458d868a4"),
    ModelInner = null,
    NullableValue = Guid.Parse("5f445660-e8b2-41dc-9d24-70da2f6f33f8"),
},
            new GuiduniqueidentifierE0M
{
    Id = 164,
    Value = Guid.Parse("4e864513-ad60-4a6e-be85-bbd403b81574"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 103,
    Value = Guid.Parse("deb2c9f4-b8fa-485b-bfab-ba7bd2660272"),
    NullableValue = Guid.Parse("f603f99a-11ca-4cc7-ba4d-b2ce387c3746"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 167,
    Value = Guid.Parse("fb6cad60-625f-4721-a3f5-9500b4fea5d2"),
    ModelInner = null,
    NullableValue = Guid.Parse("6e8588a6-1929-48cb-8ee5-402083b35731"),
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 28;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 3;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[33],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 42, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 94, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 117, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 133, query1, 73, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 154, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 154, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 94, 158))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 102, 56))
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[34], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[23], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[24], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[25], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[26], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[27], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[28], false);
                GuiduniqueidentifierE0M.AssertModel(models[6],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[7],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[8],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[9],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[10],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[11],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d425e21-17fb-4f4b-8160-482797c043a1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("243c6e2b-1ea9-4347-bbdd-2c59d4d5088a"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b219f8ec-3068-428d-9e2b-58bd1962d77b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d03d0889-bad3-424c-a67a-4b05ac708bf5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6177039c-b29e-4e80-b4d9-f261d1074c1c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("134836db-8ec1-4e43-9c27-70783a23dde3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d03ce773-814d-4f52-8f66-e0faaadc12d9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fcd8be41-fde0-4afa-b581-747a8d9dde00"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cbd1b599-7143-4fde-93ec-eb20ad6c70ea"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e26a50e8-66ff-40e5-81e0-f44f8f9e7bb1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9bd45b86-7450-4333-89be-537d2dc41031"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6b63109a-114a-4a5f-8cde-777013b4e227"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0a0d9d94-668d-4aa2-8e91-eee4d7f38237"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35d88e2c-1bc8-4f58-925e-229537f4213d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("37ff53de-b2e6-4bbf-9433-cad5db7123d3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ff7968ff-42ea-47a8-83de-f0608743b7de"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1b7ec523-4e81-4949-8782-9d779b88592a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d3dd46f-42b4-4d17-9afb-c8e7dbcb849b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("306b728a-5f54-460e-a973-3aec2a0edf39"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd473fe2-dd9c-47c4-9f28-e84bbf81b3a3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ae3bcc29-57ae-4c39-a885-d91055ef6bca"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("135277e0-75b9-4693-b3cd-8d1b7cd849b3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8d21e508-c127-4a03-8587-72e3c67b875a"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d34fe772-69ac-4288-81f0-ef3b3d160404"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fba8a427-23de-4d11-b5e4-435b26b96647"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("60f571dc-2e90-4c98-8783-6a3701707b63"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("93fb0fda-248d-45df-91ea-b473d6cb7856"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ec6954e-0049-483a-87a7-6d6f40e870ed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4b01dd37-6545-4ebb-a144-13bffcb84117"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9058b715-88c9-49c4-8e8f-bf9c9fd12cec"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a6bc63ff-8642-4878-afb7-9e55f634bb24"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("752f59db-759b-4dcf-ae87-bd7a38702a9a"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0131bc13-8a3c-4729-b63e-4cd41599e891"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e6217b89-660b-433d-9194-93fbcccb8a74"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dc952ee9-7c70-4864-aeb2-602c0bec6344"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("71b0c1d3-c528-4457-bad7-9a864ac4e536"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c444de41-e4be-43a4-a261-e12c09c21e38"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2c413ded-aae1-4605-b438-08b7e9adcc62"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e89f6338-81ae-4892-84f3-209c2f370c27"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1502903b-f73d-4bdc-81fd-5a05b10f9af6"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d67d74b1-35e6-44df-90b7-5907a0cbeaa7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9bca5376-1522-4616-8651-57404a79e4d0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6983b0c7-da47-4eb8-8f53-faf997f7a51f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8fe62d11-d7f6-46c0-a043-177d3f81f0dd"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("277acbf0-377a-40b5-8b18-534f0d63d6c2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c49dba8-2db0-4501-ab56-77262b9a4b20"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f10f5be2-88aa-492f-888f-b4c722be4a9c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("af3782a6-c80c-45dc-b02b-caef0b7ccc8b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7a1a14b8-801b-45c1-be4f-cfd05afdb7ab"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("83b4ab70-e806-4b00-b5ff-18edb9070497"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("539b67fd-b3f2-410e-a723-64b8fbdbb193"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("160b4049-18be-4564-87c9-6261fed7fdb6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("798b4d22-c7d3-4e51-8977-838766ecba30"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b93e9af7-88d9-414b-a812-e59efd9f36c6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("35a9586a-c24e-41ff-bb6c-c502a9860c15"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8cea2ff5-0e38-4ab7-9e9e-d6bd236a8e85"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9bcc64f5-eb01-4fdc-a8b9-e604e8406da0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6e16549-ff11-42c9-b132-e517654afdf7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("da65960f-665d-498c-abda-4a06fe714304"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5341fb66-b948-4fff-8445-939bf047fb47"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("af68c441-72af-4505-8327-10a31be2e980"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4e342b35-7358-4cfa-ac5c-c9d2527683ac"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aee7a22d-7e44-4690-a902-827b5ff8287f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b3af4f68-404b-400e-a5bc-c101f231dde7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cc3e4ecb-89ec-4fef-b5af-954c16b514fd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("94fed4e8-8d41-4160-badb-2d9067f17f34"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("21dca268-abd8-4f96-92e6-10958cea1a17"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("faa39a90-7115-4771-abd6-f34836a8eca9"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ad885a2-d9b9-4496-8cf1-a6ed4e6529e8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7cbdef01-82f4-4014-941f-5c11f28fc7b2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af6c404e-e882-4a36-8e0a-d8b2ec88c781"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b284c22f-8234-400d-b77c-1e61e1129fcf"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0885f268-4835-4679-a64b-0f6dde690d49"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0b17b850-207d-4dde-803d-099466c2186f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("74bda38b-27c8-4e92-8933-4e01149390c8"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("07f258e1-67f0-422c-83fc-722458d868a4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5f445660-e8b2-41dc-9d24-70da2f6f33f8"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4e864513-ad60-4a6e-be85-bbd403b81574"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((103)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("deb2c9f4-b8fa-485b-bfab-ba7bd2660272"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f603f99a-11ca-4cc7-ba4d-b2ce387c3746"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb6cad60-625f-4721-a3f5-9500b4fea5d2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6e8588a6-1929-48cb-8ee5-402083b35731"))));

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d425e21-17fb-4f4b-8160-482797c043a1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("243c6e2b-1ea9-4347-bbdd-2c59d4d5088a"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b219f8ec-3068-428d-9e2b-58bd1962d77b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d03d0889-bad3-424c-a67a-4b05ac708bf5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6177039c-b29e-4e80-b4d9-f261d1074c1c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("134836db-8ec1-4e43-9c27-70783a23dde3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d03ce773-814d-4f52-8f66-e0faaadc12d9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fcd8be41-fde0-4afa-b581-747a8d9dde00"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cbd1b599-7143-4fde-93ec-eb20ad6c70ea"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e26a50e8-66ff-40e5-81e0-f44f8f9e7bb1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9bd45b86-7450-4333-89be-537d2dc41031"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6b63109a-114a-4a5f-8cde-777013b4e227"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0a0d9d94-668d-4aa2-8e91-eee4d7f38237"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35d88e2c-1bc8-4f58-925e-229537f4213d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("37ff53de-b2e6-4bbf-9433-cad5db7123d3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ff7968ff-42ea-47a8-83de-f0608743b7de"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1b7ec523-4e81-4949-8782-9d779b88592a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d3dd46f-42b4-4d17-9afb-c8e7dbcb849b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("306b728a-5f54-460e-a973-3aec2a0edf39"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd473fe2-dd9c-47c4-9f28-e84bbf81b3a3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ae3bcc29-57ae-4c39-a885-d91055ef6bca"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("135277e0-75b9-4693-b3cd-8d1b7cd849b3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8d21e508-c127-4a03-8587-72e3c67b875a"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d34fe772-69ac-4288-81f0-ef3b3d160404"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fba8a427-23de-4d11-b5e4-435b26b96647"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("60f571dc-2e90-4c98-8783-6a3701707b63"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("93fb0fda-248d-45df-91ea-b473d6cb7856"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ec6954e-0049-483a-87a7-6d6f40e870ed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4b01dd37-6545-4ebb-a144-13bffcb84117"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9058b715-88c9-49c4-8e8f-bf9c9fd12cec"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a6bc63ff-8642-4878-afb7-9e55f634bb24"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("752f59db-759b-4dcf-ae87-bd7a38702a9a"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0131bc13-8a3c-4729-b63e-4cd41599e891"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e6217b89-660b-433d-9194-93fbcccb8a74"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dc952ee9-7c70-4864-aeb2-602c0bec6344"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("71b0c1d3-c528-4457-bad7-9a864ac4e536"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c444de41-e4be-43a4-a261-e12c09c21e38"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2c413ded-aae1-4605-b438-08b7e9adcc62"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e89f6338-81ae-4892-84f3-209c2f370c27"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1502903b-f73d-4bdc-81fd-5a05b10f9af6"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d67d74b1-35e6-44df-90b7-5907a0cbeaa7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9bca5376-1522-4616-8651-57404a79e4d0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6983b0c7-da47-4eb8-8f53-faf997f7a51f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8fe62d11-d7f6-46c0-a043-177d3f81f0dd"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("277acbf0-377a-40b5-8b18-534f0d63d6c2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c49dba8-2db0-4501-ab56-77262b9a4b20"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f10f5be2-88aa-492f-888f-b4c722be4a9c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("af3782a6-c80c-45dc-b02b-caef0b7ccc8b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7a1a14b8-801b-45c1-be4f-cfd05afdb7ab"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("83b4ab70-e806-4b00-b5ff-18edb9070497"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("539b67fd-b3f2-410e-a723-64b8fbdbb193"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("160b4049-18be-4564-87c9-6261fed7fdb6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("798b4d22-c7d3-4e51-8977-838766ecba30"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b93e9af7-88d9-414b-a812-e59efd9f36c6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("35a9586a-c24e-41ff-bb6c-c502a9860c15"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8cea2ff5-0e38-4ab7-9e9e-d6bd236a8e85"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9bcc64f5-eb01-4fdc-a8b9-e604e8406da0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6e16549-ff11-42c9-b132-e517654afdf7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("da65960f-665d-498c-abda-4a06fe714304"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5341fb66-b948-4fff-8445-939bf047fb47"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("af68c441-72af-4505-8327-10a31be2e980"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4e342b35-7358-4cfa-ac5c-c9d2527683ac"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aee7a22d-7e44-4690-a902-827b5ff8287f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b3af4f68-404b-400e-a5bc-c101f231dde7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cc3e4ecb-89ec-4fef-b5af-954c16b514fd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("94fed4e8-8d41-4160-badb-2d9067f17f34"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("21dca268-abd8-4f96-92e6-10958cea1a17"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("faa39a90-7115-4771-abd6-f34836a8eca9"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ad885a2-d9b9-4496-8cf1-a6ed4e6529e8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7cbdef01-82f4-4014-941f-5c11f28fc7b2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af6c404e-e882-4a36-8e0a-d8b2ec88c781"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b284c22f-8234-400d-b77c-1e61e1129fcf"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0885f268-4835-4679-a64b-0f6dde690d49"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0b17b850-207d-4dde-803d-099466c2186f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("74bda38b-27c8-4e92-8933-4e01149390c8"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("07f258e1-67f0-422c-83fc-722458d868a4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5f445660-e8b2-41dc-9d24-70da2f6f33f8"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4e864513-ad60-4a6e-be85-bbd403b81574"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((103)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("deb2c9f4-b8fa-485b-bfab-ba7bd2660272"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f603f99a-11ca-4cc7-ba4d-b2ce387c3746"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb6cad60-625f-4721-a3f5-9500b4fea5d2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6e8588a6-1929-48cb-8ee5-402083b35731"))));

            }
        }

#endregion

    }
}


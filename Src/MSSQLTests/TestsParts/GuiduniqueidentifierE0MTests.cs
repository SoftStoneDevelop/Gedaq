

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
    Value = Guid.Parse("07336793-8103-48ca-8673-7b548cf27740"),
    ModelInner = null,
    NullableValue = Guid.Parse("702b9c9e-4b67-42b6-bd32-2664b20af845"),
},
            new GuiduniqueidentifierE0M
{
    Id = 6,
    Value = Guid.Parse("f3d7bf07-114d-4d0f-b28a-fc3c092f3ecc"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 8,
    Value = Guid.Parse("ab9e21fe-6f27-4c17-a819-036bd46c89cb"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 14,
    Value = Guid.Parse("fc88ca97-0e7c-4ac3-9fda-9a7f3856506d"),
    ModelInner = null,
    NullableValue = Guid.Parse("4812e802-d0c0-407a-8c58-c10f2ad0da50"),
},
            new GuiduniqueidentifierE0M
{
    Id = 17,
    Value = Guid.Parse("2012d969-f0e6-45a7-b8a2-b48a8b081418"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 15,
    Value = Guid.Parse("4cc81598-b06d-4380-a368-d62e2b8c7abc"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 23,
    Value = Guid.Parse("e6ab8d79-07cd-4149-8c4f-8fd42ede8a8c"),
    ModelInner = null,
    NullableValue = Guid.Parse("4ae015ca-1c30-4baf-9c9f-5f316b02301d"),
},
            new GuiduniqueidentifierE0M
{
    Id = 29,
    Value = Guid.Parse("e54a3c49-fbfe-4508-8195-d5429cc7398f"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 18,
    Value = Guid.Parse("e336a389-d284-4af2-971d-19d3e5eae182"),
    NullableValue = Guid.Parse("65a1a1bc-6199-4996-9ae2-682533b55505"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 34,
    Value = Guid.Parse("a283f5d1-bb55-46f5-a842-5b9e2863dc68"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 38,
    Value = Guid.Parse("9e298fb0-bc95-4b6b-a949-66cdd990a95d"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 27,
    Value = Guid.Parse("22be23bd-9ef0-4857-a8d2-9e826c24f172"),
    NullableValue = Guid.Parse("584fc2ea-6330-4dc1-a8df-53f6a5f1458d"),
},
    NullableValue = Guid.Parse("8efe270c-11c8-4e39-9496-4f646ed3a6b5"),
},
            new GuiduniqueidentifierE0M
{
    Id = 42,
    Value = Guid.Parse("2fb13764-a30a-4ac9-86c7-45cf43ec8c63"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 51,
    Value = Guid.Parse("fd8a9489-8b12-4f6c-a069-37e79e802812"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 34,
    Value = Guid.Parse("2d5b3ccb-478f-4cc1-8c37-cc13e0873d95"),
    NullableValue = Guid.Parse("445567ad-53f3-4275-8959-a1454e535fa7"),
},
    NullableValue = Guid.Parse("9f4c5e1a-5245-45cf-af10-544c352ac509"),
},
            new GuiduniqueidentifierE0M
{
    Id = 57,
    Value = Guid.Parse("6352f603-0e2c-4ce5-b618-53502fb6c835"),
    ModelInner = null,
    NullableValue = Guid.Parse("74709e65-95dd-4d9c-a9a9-6ccba63d8083"),
},
            new GuiduniqueidentifierE0M
{
    Id = 60,
    Value = Guid.Parse("c62e7843-0ad0-4ed4-88f4-6c55689101f3"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 43,
    Value = Guid.Parse("28d4eba7-ad7a-4977-a1cf-8ba1a3c01461"),
    NullableValue = Guid.Parse("bab45fbd-5ab6-48d5-8b89-fc0edc085e59"),
},
    NullableValue = Guid.Parse("0980840e-698e-436c-8792-d59be7c62174"),
},
            new GuiduniqueidentifierE0M
{
    Id = 64,
    Value = Guid.Parse("56a1b8fe-758e-4d29-bc97-feffe9194b44"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 65,
    Value = Guid.Parse("ededecfd-5fa9-4612-ad80-03191e7cd0be"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 44,
    Value = Guid.Parse("ab5628a6-26bc-4974-af50-6828faf839c4"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 72,
    Value = Guid.Parse("ece4caf1-16d5-4faf-acbd-668e76f799b3"),
    ModelInner = null,
    NullableValue = Guid.Parse("bfa8a7a6-24e2-455c-8690-bd697b30f018"),
},
            new GuiduniqueidentifierE0M
{
    Id = 74,
    Value = Guid.Parse("58a716cf-7545-40a6-84de-dbf2e82601dc"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 50,
    Value = Guid.Parse("7c70bfe4-f6a1-4948-ae86-7cc369ec5dc6"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("87337ff1-a5e1-4c62-887c-444ca338f8ad"),
},
            new GuiduniqueidentifierE0M
{
    Id = 81,
    Value = Guid.Parse("b090e3fd-de56-470f-b24a-47b243d30d2c"),
    ModelInner = null,
    NullableValue = Guid.Parse("99b2ed74-4720-4d60-9586-e8c2ec527728"),
},
            new GuiduniqueidentifierE0M
{
    Id = 89,
    Value = Guid.Parse("3aaa1bc6-d8ee-4f41-b66b-82d1e68b2e9c"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 58,
    Value = Guid.Parse("b75777ca-78e0-4fce-9f02-74bea8067f2b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f49d136b-b483-4d28-b1a3-d77530b2df31"),
},
            new GuiduniqueidentifierE0M
{
    Id = 90,
    Value = Guid.Parse("09657142-f107-4191-a6d8-8dfc93ae0fb8"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 91,
    Value = Guid.Parse("e8ce89d1-629b-4cf3-a9b0-65aee59645a3"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 67,
    Value = Guid.Parse("6e5a4640-d1ea-40d3-8014-2ed9c29648fe"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 100,
    Value = Guid.Parse("d35f0cc3-91c9-43be-8dfe-df2baa3a7742"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 101,
    Value = Guid.Parse("3633047a-945f-43dc-8794-d9dccada5ffa"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 75,
    Value = Guid.Parse("7fa3bc98-8d19-407a-a599-0678e6258c53"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("53186b92-4a17-45ed-a625-c97c61a5bb3a"),
},
            new GuiduniqueidentifierE0M
{
    Id = 103,
    Value = Guid.Parse("6287c06f-a3bd-4a95-b471-40f86e418b04"),
    ModelInner = null,
    NullableValue = Guid.Parse("21f5f917-2efb-4bd9-a07c-e091917375e6"),
},
            new GuiduniqueidentifierE0M
{
    Id = 104,
    Value = Guid.Parse("2899c2bb-5302-44ae-af13-6b46547f0ec5"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 78,
    Value = Guid.Parse("776ba501-8842-4238-abb0-2dbda7789762"),
    NullableValue = Guid.Parse("1a302c9b-2190-45e9-a5ad-6b23a720fe5d"),
},
    NullableValue = Guid.Parse("e4d49a41-c4a3-41ca-8693-55fb4fd8319d"),
},
            new GuiduniqueidentifierE0M
{
    Id = 105,
    Value = Guid.Parse("802b7070-f083-4aa4-97cb-24f8449b65b7"),
    ModelInner = null,
    NullableValue = Guid.Parse("e5779933-dfb7-4fbb-8f3b-63d1105312f1"),
},
            new GuiduniqueidentifierE0M
{
    Id = 114,
    Value = Guid.Parse("516ea1d3-4eca-4e04-b052-6b633cbb4d02"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 81,
    Value = Guid.Parse("e6617f12-a2d6-4104-a62f-6fb3772430e5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("eba4df4c-e081-4c53-b9e8-6a0b480f901d"),
},
            new GuiduniqueidentifierE0M
{
    Id = 120,
    Value = Guid.Parse("00ce16bf-7431-458b-9b2f-7d8e883325af"),
    ModelInner = null,
    NullableValue = Guid.Parse("d4ee5f81-124b-4f18-b758-700b0d8ffffc"),
},
            new GuiduniqueidentifierE0M
{
    Id = 126,
    Value = Guid.Parse("daa534e4-0185-4369-89f8-a047adaef7dc"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 83,
    Value = Guid.Parse("1f2e3cc9-1850-48b3-94f2-b8b68ea021ac"),
    NullableValue = Guid.Parse("a2593b29-490a-4179-8a83-318ffa31e718"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 131,
    Value = Guid.Parse("c92ba4ec-a595-4e3b-8e6f-b1ebfdadca1a"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 138,
    Value = Guid.Parse("6ea551ae-69dd-4e78-a6e8-9fa83390a5fa"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 87,
    Value = Guid.Parse("b51c1cc8-c123-49ca-9474-d708173a24cc"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 146,
    Value = Guid.Parse("7e19cb51-5812-43cc-af7d-8cd79c434687"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 147,
    Value = Guid.Parse("9d888604-126a-4639-8977-0e9f4f823e35"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 93,
    Value = Guid.Parse("7e659868-61c9-489e-80ad-90b6c57b29d5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d0901a1e-c2c8-41ab-8658-4b9e3efffb8e"),
},
            new GuiduniqueidentifierE0M
{
    Id = 154,
    Value = Guid.Parse("bb82526e-ff58-4345-944c-a089d9c06ec9"),
    ModelInner = null,
    NullableValue = Guid.Parse("b29ded94-6d4a-43b7-83c4-b0f735c9c3eb"),
},
            new GuiduniqueidentifierE0M
{
    Id = 157,
    Value = Guid.Parse("92185fdf-6e0e-4c01-987b-6fc8d201a031"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 97,
    Value = Guid.Parse("54efce7f-6a3c-495d-bb0f-76118fa6a7ef"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("87efa34d-5440-4168-8a09-b0661a4240b3"),
},
            new GuiduniqueidentifierE0M
{
    Id = 166,
    Value = Guid.Parse("c50b6446-09d1-42e3-a709-6d4e7ecfc9c2"),
    ModelInner = null,
    NullableValue = Guid.Parse("25694813-6242-4709-a65e-d703193f33e2"),
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 146;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[3], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[4], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[5], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[6], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[28],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[29],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[30],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 42, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 72, query1, 6, query2))
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 154, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 103, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 114, query1, 29, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 126))
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 29, 74))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("07336793-8103-48ca-8673-7b548cf27740"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("702b9c9e-4b67-42b6-bd32-2664b20af845"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f3d7bf07-114d-4d0f-b28a-fc3c092f3ecc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ab9e21fe-6f27-4c17-a819-036bd46c89cb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fc88ca97-0e7c-4ac3-9fda-9a7f3856506d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4812e802-d0c0-407a-8c58-c10f2ad0da50"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2012d969-f0e6-45a7-b8a2-b48a8b081418"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4cc81598-b06d-4380-a368-d62e2b8c7abc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e6ab8d79-07cd-4149-8c4f-8fd42ede8a8c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4ae015ca-1c30-4baf-9c9f-5f316b02301d"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e54a3c49-fbfe-4508-8195-d5429cc7398f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e336a389-d284-4af2-971d-19d3e5eae182"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("65a1a1bc-6199-4996-9ae2-682533b55505"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a283f5d1-bb55-46f5-a842-5b9e2863dc68"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e298fb0-bc95-4b6b-a949-66cdd990a95d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("22be23bd-9ef0-4857-a8d2-9e826c24f172"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("584fc2ea-6330-4dc1-a8df-53f6a5f1458d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8efe270c-11c8-4e39-9496-4f646ed3a6b5"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2fb13764-a30a-4ac9-86c7-45cf43ec8c63"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd8a9489-8b12-4f6c-a069-37e79e802812"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2d5b3ccb-478f-4cc1-8c37-cc13e0873d95"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("445567ad-53f3-4275-8959-a1454e535fa7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9f4c5e1a-5245-45cf-af10-544c352ac509"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6352f603-0e2c-4ce5-b618-53502fb6c835"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("74709e65-95dd-4d9c-a9a9-6ccba63d8083"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c62e7843-0ad0-4ed4-88f4-6c55689101f3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("28d4eba7-ad7a-4977-a1cf-8ba1a3c01461"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bab45fbd-5ab6-48d5-8b89-fc0edc085e59"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0980840e-698e-436c-8792-d59be7c62174"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("56a1b8fe-758e-4d29-bc97-feffe9194b44"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ededecfd-5fa9-4612-ad80-03191e7cd0be"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ab5628a6-26bc-4974-af50-6828faf839c4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ece4caf1-16d5-4faf-acbd-668e76f799b3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bfa8a7a6-24e2-455c-8690-bd697b30f018"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("58a716cf-7545-40a6-84de-dbf2e82601dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7c70bfe4-f6a1-4948-ae86-7cc369ec5dc6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("87337ff1-a5e1-4c62-887c-444ca338f8ad"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b090e3fd-de56-470f-b24a-47b243d30d2c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99b2ed74-4720-4d60-9586-e8c2ec527728"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3aaa1bc6-d8ee-4f41-b66b-82d1e68b2e9c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b75777ca-78e0-4fce-9f02-74bea8067f2b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f49d136b-b483-4d28-b1a3-d77530b2df31"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("09657142-f107-4191-a6d8-8dfc93ae0fb8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e8ce89d1-629b-4cf3-a9b0-65aee59645a3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6e5a4640-d1ea-40d3-8014-2ed9c29648fe"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d35f0cc3-91c9-43be-8dfe-df2baa3a7742"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3633047a-945f-43dc-8794-d9dccada5ffa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7fa3bc98-8d19-407a-a599-0678e6258c53"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("53186b92-4a17-45ed-a625-c97c61a5bb3a"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6287c06f-a3bd-4a95-b471-40f86e418b04"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("21f5f917-2efb-4bd9-a07c-e091917375e6"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2899c2bb-5302-44ae-af13-6b46547f0ec5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("776ba501-8842-4238-abb0-2dbda7789762"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1a302c9b-2190-45e9-a5ad-6b23a720fe5d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e4d49a41-c4a3-41ca-8693-55fb4fd8319d"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("802b7070-f083-4aa4-97cb-24f8449b65b7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e5779933-dfb7-4fbb-8f3b-63d1105312f1"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("516ea1d3-4eca-4e04-b052-6b633cbb4d02"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e6617f12-a2d6-4104-a62f-6fb3772430e5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("eba4df4c-e081-4c53-b9e8-6a0b480f901d"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00ce16bf-7431-458b-9b2f-7d8e883325af"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d4ee5f81-124b-4f18-b758-700b0d8ffffc"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("daa534e4-0185-4369-89f8-a047adaef7dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1f2e3cc9-1850-48b3-94f2-b8b68ea021ac"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a2593b29-490a-4179-8a83-318ffa31e718"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c92ba4ec-a595-4e3b-8e6f-b1ebfdadca1a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6ea551ae-69dd-4e78-a6e8-9fa83390a5fa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b51c1cc8-c123-49ca-9474-d708173a24cc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e19cb51-5812-43cc-af7d-8cd79c434687"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9d888604-126a-4639-8977-0e9f4f823e35"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7e659868-61c9-489e-80ad-90b6c57b29d5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d0901a1e-c2c8-41ab-8658-4b9e3efffb8e"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb82526e-ff58-4345-944c-a089d9c06ec9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b29ded94-6d4a-43b7-83c4-b0f735c9c3eb"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("92185fdf-6e0e-4c01-987b-6fc8d201a031"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("54efce7f-6a3c-495d-bb0f-76118fa6a7ef"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("87efa34d-5440-4168-8a09-b0661a4240b3"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c50b6446-09d1-42e3-a709-6d4e7ecfc9c2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("25694813-6242-4709-a65e-d703193f33e2"))));

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("07336793-8103-48ca-8673-7b548cf27740"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("702b9c9e-4b67-42b6-bd32-2664b20af845"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f3d7bf07-114d-4d0f-b28a-fc3c092f3ecc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ab9e21fe-6f27-4c17-a819-036bd46c89cb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fc88ca97-0e7c-4ac3-9fda-9a7f3856506d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4812e802-d0c0-407a-8c58-c10f2ad0da50"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2012d969-f0e6-45a7-b8a2-b48a8b081418"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4cc81598-b06d-4380-a368-d62e2b8c7abc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e6ab8d79-07cd-4149-8c4f-8fd42ede8a8c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4ae015ca-1c30-4baf-9c9f-5f316b02301d"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e54a3c49-fbfe-4508-8195-d5429cc7398f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e336a389-d284-4af2-971d-19d3e5eae182"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("65a1a1bc-6199-4996-9ae2-682533b55505"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a283f5d1-bb55-46f5-a842-5b9e2863dc68"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e298fb0-bc95-4b6b-a949-66cdd990a95d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("22be23bd-9ef0-4857-a8d2-9e826c24f172"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("584fc2ea-6330-4dc1-a8df-53f6a5f1458d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8efe270c-11c8-4e39-9496-4f646ed3a6b5"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2fb13764-a30a-4ac9-86c7-45cf43ec8c63"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd8a9489-8b12-4f6c-a069-37e79e802812"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2d5b3ccb-478f-4cc1-8c37-cc13e0873d95"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("445567ad-53f3-4275-8959-a1454e535fa7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9f4c5e1a-5245-45cf-af10-544c352ac509"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6352f603-0e2c-4ce5-b618-53502fb6c835"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("74709e65-95dd-4d9c-a9a9-6ccba63d8083"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c62e7843-0ad0-4ed4-88f4-6c55689101f3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("28d4eba7-ad7a-4977-a1cf-8ba1a3c01461"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bab45fbd-5ab6-48d5-8b89-fc0edc085e59"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0980840e-698e-436c-8792-d59be7c62174"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("56a1b8fe-758e-4d29-bc97-feffe9194b44"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ededecfd-5fa9-4612-ad80-03191e7cd0be"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ab5628a6-26bc-4974-af50-6828faf839c4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ece4caf1-16d5-4faf-acbd-668e76f799b3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bfa8a7a6-24e2-455c-8690-bd697b30f018"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("58a716cf-7545-40a6-84de-dbf2e82601dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7c70bfe4-f6a1-4948-ae86-7cc369ec5dc6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("87337ff1-a5e1-4c62-887c-444ca338f8ad"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b090e3fd-de56-470f-b24a-47b243d30d2c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99b2ed74-4720-4d60-9586-e8c2ec527728"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3aaa1bc6-d8ee-4f41-b66b-82d1e68b2e9c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b75777ca-78e0-4fce-9f02-74bea8067f2b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f49d136b-b483-4d28-b1a3-d77530b2df31"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("09657142-f107-4191-a6d8-8dfc93ae0fb8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e8ce89d1-629b-4cf3-a9b0-65aee59645a3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6e5a4640-d1ea-40d3-8014-2ed9c29648fe"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d35f0cc3-91c9-43be-8dfe-df2baa3a7742"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3633047a-945f-43dc-8794-d9dccada5ffa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7fa3bc98-8d19-407a-a599-0678e6258c53"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("53186b92-4a17-45ed-a625-c97c61a5bb3a"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6287c06f-a3bd-4a95-b471-40f86e418b04"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("21f5f917-2efb-4bd9-a07c-e091917375e6"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2899c2bb-5302-44ae-af13-6b46547f0ec5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("776ba501-8842-4238-abb0-2dbda7789762"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1a302c9b-2190-45e9-a5ad-6b23a720fe5d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e4d49a41-c4a3-41ca-8693-55fb4fd8319d"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("802b7070-f083-4aa4-97cb-24f8449b65b7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e5779933-dfb7-4fbb-8f3b-63d1105312f1"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("516ea1d3-4eca-4e04-b052-6b633cbb4d02"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e6617f12-a2d6-4104-a62f-6fb3772430e5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("eba4df4c-e081-4c53-b9e8-6a0b480f901d"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00ce16bf-7431-458b-9b2f-7d8e883325af"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d4ee5f81-124b-4f18-b758-700b0d8ffffc"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("daa534e4-0185-4369-89f8-a047adaef7dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1f2e3cc9-1850-48b3-94f2-b8b68ea021ac"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a2593b29-490a-4179-8a83-318ffa31e718"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c92ba4ec-a595-4e3b-8e6f-b1ebfdadca1a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6ea551ae-69dd-4e78-a6e8-9fa83390a5fa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b51c1cc8-c123-49ca-9474-d708173a24cc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e19cb51-5812-43cc-af7d-8cd79c434687"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9d888604-126a-4639-8977-0e9f4f823e35"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7e659868-61c9-489e-80ad-90b6c57b29d5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d0901a1e-c2c8-41ab-8658-4b9e3efffb8e"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb82526e-ff58-4345-944c-a089d9c06ec9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b29ded94-6d4a-43b7-83c4-b0f735c9c3eb"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("92185fdf-6e0e-4c01-987b-6fc8d201a031"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("54efce7f-6a3c-495d-bb0f-76118fa6a7ef"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("87efa34d-5440-4168-8a09-b0661a4240b3"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c50b6446-09d1-42e3-a709-6d4e7ecfc9c2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("25694813-6242-4709-a65e-d703193f33e2"))));

            }
        }

#endregion

    }
}


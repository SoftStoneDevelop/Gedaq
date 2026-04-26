

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
    Id = 2,
    Value = Guid.Parse("539cc371-4f6b-47f2-a010-d06b16d45f96"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 9,
    Value = Guid.Parse("98992f21-fcf9-4762-8041-05a4843653ac"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 5,
    Value = Guid.Parse("e02d95e4-195b-4173-8fd7-3ff3eaa1359b"),
    NullableValue = Guid.Parse("19bd4a1f-bc60-41f6-b42c-8d9c836edcf0"),
},
    NullableValue = Guid.Parse("513548a7-b4eb-4509-88f5-da56d915ff41"),
},
            new Guiduniqueidentifier0M
{
    Id = 16,
    Value = Guid.Parse("b5b012bf-e6f3-467a-8bc2-4345feadfdae"),
    ModelInner = null,
    NullableValue = Guid.Parse("787b6def-4051-46f9-a045-e5d74761eda1"),
},
            new Guiduniqueidentifier0M
{
    Id = 22,
    Value = Guid.Parse("f93e34ae-cc10-4900-bc54-3f07700522ef"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 8,
    Value = Guid.Parse("a86a45a2-842b-426c-b7e9-e14221fd3cba"),
    NullableValue = Guid.Parse("956a7df6-4296-41bf-9632-700e17d0dda2"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 30,
    Value = Guid.Parse("35c91523-5ebc-4ea6-bb44-0697cf8da14b"),
    ModelInner = null,
    NullableValue = Guid.Parse("1efd6463-9fec-4563-8cbe-412f9621cd4e"),
},
            new Guiduniqueidentifier0M
{
    Id = 39,
    Value = Guid.Parse("41709361-9816-435a-be90-287195e98d82"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 12,
    Value = Guid.Parse("a0bf375a-a03d-4960-b868-f30faa110145"),
    NullableValue = Guid.Parse("0f5bf52c-65c5-45e2-8d39-bc39512b4cc9"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 43,
    Value = Guid.Parse("02b32497-3062-4c58-a56d-e64ef673e015"),
    ModelInner = null,
    NullableValue = Guid.Parse("1298f001-fd4d-4032-8654-b803c86449b4"),
},
            new Guiduniqueidentifier0M
{
    Id = 51,
    Value = Guid.Parse("be5b95ba-cedc-4d2a-bc22-d117e04b9b50"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 17,
    Value = Guid.Parse("23896d90-9608-4e51-9460-b43a3549beda"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e76e0688-3af3-46ce-970e-858372397aa6"),
},
            new Guiduniqueidentifier0M
{
    Id = 58,
    Value = Guid.Parse("4d3a9c0d-ee05-40f2-834c-385209721175"),
    ModelInner = null,
    NullableValue = Guid.Parse("dec8131b-cf98-4ead-9128-04f901959e3b"),
},
            new Guiduniqueidentifier0M
{
    Id = 61,
    Value = Guid.Parse("744de9b4-49ad-4338-8f6d-d9253c76161b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 24,
    Value = Guid.Parse("2f356004-76ba-4262-b83b-a0d87149aa78"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0c2fa7c6-f9e6-4e67-b5f1-0c614e839e7e"),
},
            new Guiduniqueidentifier0M
{
    Id = 64,
    Value = Guid.Parse("e9dc2b7e-44f0-477e-9f4f-d8180c808565"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 66,
    Value = Guid.Parse("26ab2341-4092-4559-865f-de629c0a22bd"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 25,
    Value = Guid.Parse("58b33a8b-cdbf-4b4e-a903-69bc5e66b5c6"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 67,
    Value = Guid.Parse("5a0ede58-0bf4-4633-b292-105d9b986ff4"),
    ModelInner = null,
    NullableValue = Guid.Parse("022d69cc-c409-4d03-a2f2-f6e2c7b93b1a"),
},
            new Guiduniqueidentifier0M
{
    Id = 72,
    Value = Guid.Parse("14a9143e-96d7-4f26-8e64-2e95efaf1b19"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 29,
    Value = Guid.Parse("65f5696b-6c61-41f0-bc41-ef2c60438154"),
    NullableValue = Guid.Parse("a9ac39dd-e6a3-4dbd-9f3f-2e558bcdb6d3"),
},
    NullableValue = Guid.Parse("a6d9299a-12dd-49e0-8839-2150d091f255"),
},
            new Guiduniqueidentifier0M
{
    Id = 74,
    Value = Guid.Parse("93f00221-0f49-44b0-a362-dd5bfee0aa06"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 78,
    Value = Guid.Parse("3c3f1726-5a91-4713-b007-1390b0d0a8b4"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 32,
    Value = Guid.Parse("d3bb53d2-9a90-42d8-ad06-7e09d3f1739c"),
    NullableValue = Guid.Parse("7eaa2eab-c0b6-4a20-88c4-a180da7a1eac"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 79,
    Value = Guid.Parse("6c5d3e2d-284b-4c52-8151-cf280c569771"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 88,
    Value = Guid.Parse("1e72ba27-87c2-46f0-8de5-bc40fc85ecad"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 39,
    Value = Guid.Parse("5f4bd374-a71c-4158-bef2-6b8f8e46b447"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 96,
    Value = Guid.Parse("236549e5-bf6c-4cd4-998d-4d96351724b7"),
    ModelInner = null,
    NullableValue = Guid.Parse("7bf11855-b5ae-40c4-8440-7fa4742e3562"),
},
            new Guiduniqueidentifier0M
{
    Id = 99,
    Value = Guid.Parse("aef0c786-54da-4a1a-b04b-34c6a38c634d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 47,
    Value = Guid.Parse("e39d9986-640c-4da8-9dbb-6dd38f7f5e16"),
    NullableValue = Guid.Parse("c8373e87-9750-46c6-88de-37c67394b751"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 102,
    Value = Guid.Parse("c33473ad-67fd-4e09-8904-18459c1e8ef4"),
    ModelInner = null,
    NullableValue = Guid.Parse("44685001-f2d2-4b2d-9532-3e8c74d028b9"),
},
            new Guiduniqueidentifier0M
{
    Id = 104,
    Value = Guid.Parse("10e4727a-e6c6-4124-ac38-c4683548ac50"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 54,
    Value = Guid.Parse("26028a04-20f0-4e10-b010-92b667ba52ed"),
    NullableValue = Guid.Parse("b6f3b3e4-a93e-48f2-90a7-1fdb949e594d"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 110,
    Value = Guid.Parse("5d7284a5-8f8a-4a97-8d55-e4d5ca2f06bf"),
    ModelInner = null,
    NullableValue = Guid.Parse("99ffaa0a-993d-4f75-90f4-a2d4eb4a6f02"),
},
            new Guiduniqueidentifier0M
{
    Id = 113,
    Value = Guid.Parse("f11e7452-a012-484c-8b84-54cbd038acfd"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 57,
    Value = Guid.Parse("a46b1837-89b1-4155-826a-9e9d52c2afad"),
    NullableValue = Guid.Parse("c7767c83-e288-4146-bd19-37704bafdd63"),
},
    NullableValue = Guid.Parse("928e8988-cab3-4a00-9d07-4e50c1943baa"),
},
            new Guiduniqueidentifier0M
{
    Id = 120,
    Value = Guid.Parse("f5abf40d-b596-4479-a5e2-de00ed1a4e36"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 126,
    Value = Guid.Parse("3bf7fc99-88c5-46ab-8662-83e61b6ae90c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 64,
    Value = Guid.Parse("a397e582-b2fd-4e3d-a992-76fe6912afca"),
    NullableValue = Guid.Parse("9cd80ed6-d457-46c7-9283-ef6e130401de"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 135,
    Value = Guid.Parse("bb45915a-993d-43c6-878c-3beef070a080"),
    ModelInner = null,
    NullableValue = Guid.Parse("472ad760-80d5-4e14-823d-e17fab0b1cfc"),
},
            new Guiduniqueidentifier0M
{
    Id = 136,
    Value = Guid.Parse("00dd0e08-986e-43e3-a47d-8d25c9b8816e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 65,
    Value = Guid.Parse("73b63e70-0a79-4750-80f5-84438025100d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 144,
    Value = Guid.Parse("ee87d270-203f-48f8-9cf9-d50664298de6"),
    ModelInner = null,
    NullableValue = Guid.Parse("4e5b81c3-ac8f-4e93-9306-a39261ad9914"),
},
            new Guiduniqueidentifier0M
{
    Id = 149,
    Value = Guid.Parse("a5a85311-1c76-490f-8fa9-affc908202a5"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 68,
    Value = Guid.Parse("431bb5bc-38a4-4b0b-9b15-f40bece663cb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("468ea2a8-5f1b-4a04-b591-03b1ca8d2c3f"),
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(14)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(14))
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(14)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(14),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduniqueidentifier0mi_id", 
                methodParametrName: "guiduniqueidentifier0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models = await ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models =  ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models = await ((IGuidSingleTypeuniqueidentifier)this).SelectModelDynParAsync(connection, [parametr1]);
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

                var models =  ((IGuidSingleTypeuniqueidentifier)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelAsync(connection,  query, 0);
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModel(connection,  query, 0);
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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).SelectModelAsync(connection, 0);
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
                var models =  ((IGuidSingleTypeuniqueidentifier)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[9], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[10], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[11], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[12], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[13], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[14], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[15], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[14], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[15], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[29], false);
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

                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 110, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[14], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[15], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[4], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[5], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[6], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[7], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[8], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[9], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[10], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[11], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[12], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[13], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[14], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[15], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelBatchAsync(connection, 43, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[5], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[6], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[24],_testData[29], false);
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
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelBatch(connection, 51, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[2], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[3], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[4], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[5], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[6], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[24],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[25],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[26],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[27],_testData[29], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[5], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[6], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[24],_testData[29], false);
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

                Assert.That(models, Has.Count.EqualTo(21));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("539cc371-4f6b-47f2-a010-d06b16d45f96"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98992f21-fcf9-4762-8041-05a4843653ac"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e02d95e4-195b-4173-8fd7-3ff3eaa1359b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("19bd4a1f-bc60-41f6-b42c-8d9c836edcf0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("513548a7-b4eb-4509-88f5-da56d915ff41"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b5b012bf-e6f3-467a-8bc2-4345feadfdae"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("787b6def-4051-46f9-a045-e5d74761eda1"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f93e34ae-cc10-4900-bc54-3f07700522ef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a86a45a2-842b-426c-b7e9-e14221fd3cba"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("956a7df6-4296-41bf-9632-700e17d0dda2"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35c91523-5ebc-4ea6-bb44-0697cf8da14b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1efd6463-9fec-4563-8cbe-412f9621cd4e"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("41709361-9816-435a-be90-287195e98d82"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a0bf375a-a03d-4960-b868-f30faa110145"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0f5bf52c-65c5-45e2-8d39-bc39512b4cc9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("02b32497-3062-4c58-a56d-e64ef673e015"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1298f001-fd4d-4032-8654-b803c86449b4"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("be5b95ba-cedc-4d2a-bc22-d117e04b9b50"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("23896d90-9608-4e51-9460-b43a3549beda"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e76e0688-3af3-46ce-970e-858372397aa6"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4d3a9c0d-ee05-40f2-834c-385209721175"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dec8131b-cf98-4ead-9128-04f901959e3b"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("744de9b4-49ad-4338-8f6d-d9253c76161b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2f356004-76ba-4262-b83b-a0d87149aa78"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0c2fa7c6-f9e6-4e67-b5f1-0c614e839e7e"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e9dc2b7e-44f0-477e-9f4f-d8180c808565"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("26ab2341-4092-4559-865f-de629c0a22bd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("58b33a8b-cdbf-4b4e-a903-69bc5e66b5c6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5a0ede58-0bf4-4633-b292-105d9b986ff4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("022d69cc-c409-4d03-a2f2-f6e2c7b93b1a"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14a9143e-96d7-4f26-8e64-2e95efaf1b19"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("65f5696b-6c61-41f0-bc41-ef2c60438154"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a9ac39dd-e6a3-4dbd-9f3f-2e558bcdb6d3"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a6d9299a-12dd-49e0-8839-2150d091f255"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("93f00221-0f49-44b0-a362-dd5bfee0aa06"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c3f1726-5a91-4713-b007-1390b0d0a8b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3bb53d2-9a90-42d8-ad06-7e09d3f1739c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7eaa2eab-c0b6-4a20-88c4-a180da7a1eac"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6c5d3e2d-284b-4c52-8151-cf280c569771"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1e72ba27-87c2-46f0-8de5-bc40fc85ecad"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5f4bd374-a71c-4158-bef2-6b8f8e46b447"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("236549e5-bf6c-4cd4-998d-4d96351724b7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7bf11855-b5ae-40c4-8440-7fa4742e3562"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aef0c786-54da-4a1a-b04b-34c6a38c634d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e39d9986-640c-4da8-9dbb-6dd38f7f5e16"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c8373e87-9750-46c6-88de-37c67394b751"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c33473ad-67fd-4e09-8904-18459c1e8ef4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("44685001-f2d2-4b2d-9532-3e8c74d028b9"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("10e4727a-e6c6-4124-ac38-c4683548ac50"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("26028a04-20f0-4e10-b010-92b667ba52ed"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b6f3b3e4-a93e-48f2-90a7-1fdb949e594d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5d7284a5-8f8a-4a97-8d55-e4d5ca2f06bf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99ffaa0a-993d-4f75-90f4-a2d4eb4a6f02"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f11e7452-a012-484c-8b84-54cbd038acfd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a46b1837-89b1-4155-826a-9e9d52c2afad"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c7767c83-e288-4146-bd19-37704bafdd63"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("928e8988-cab3-4a00-9d07-4e50c1943baa"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f5abf40d-b596-4479-a5e2-de00ed1a4e36"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bf7fc99-88c5-46ab-8662-83e61b6ae90c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a397e582-b2fd-4e3d-a992-76fe6912afca"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9cd80ed6-d457-46c7-9283-ef6e130401de"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb45915a-993d-43c6-878c-3beef070a080"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("472ad760-80d5-4e14-823d-e17fab0b1cfc"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00dd0e08-986e-43e3-a47d-8d25c9b8816e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("73b63e70-0a79-4750-80f5-84438025100d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ee87d270-203f-48f8-9cf9-d50664298de6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4e5b81c3-ac8f-4e93-9306-a39261ad9914"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a5a85311-1c76-490f-8fa9-affc908202a5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("431bb5bc-38a4-4b0b-9b15-f40bece663cb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("468ea2a8-5f1b-4a04-b591-03b1ca8d2c3f"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("539cc371-4f6b-47f2-a010-d06b16d45f96"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98992f21-fcf9-4762-8041-05a4843653ac"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e02d95e4-195b-4173-8fd7-3ff3eaa1359b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("19bd4a1f-bc60-41f6-b42c-8d9c836edcf0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("513548a7-b4eb-4509-88f5-da56d915ff41"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b5b012bf-e6f3-467a-8bc2-4345feadfdae"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("787b6def-4051-46f9-a045-e5d74761eda1"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f93e34ae-cc10-4900-bc54-3f07700522ef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a86a45a2-842b-426c-b7e9-e14221fd3cba"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("956a7df6-4296-41bf-9632-700e17d0dda2"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35c91523-5ebc-4ea6-bb44-0697cf8da14b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1efd6463-9fec-4563-8cbe-412f9621cd4e"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("41709361-9816-435a-be90-287195e98d82"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a0bf375a-a03d-4960-b868-f30faa110145"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0f5bf52c-65c5-45e2-8d39-bc39512b4cc9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("02b32497-3062-4c58-a56d-e64ef673e015"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1298f001-fd4d-4032-8654-b803c86449b4"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("be5b95ba-cedc-4d2a-bc22-d117e04b9b50"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("23896d90-9608-4e51-9460-b43a3549beda"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e76e0688-3af3-46ce-970e-858372397aa6"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4d3a9c0d-ee05-40f2-834c-385209721175"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dec8131b-cf98-4ead-9128-04f901959e3b"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("744de9b4-49ad-4338-8f6d-d9253c76161b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2f356004-76ba-4262-b83b-a0d87149aa78"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0c2fa7c6-f9e6-4e67-b5f1-0c614e839e7e"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e9dc2b7e-44f0-477e-9f4f-d8180c808565"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("26ab2341-4092-4559-865f-de629c0a22bd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("58b33a8b-cdbf-4b4e-a903-69bc5e66b5c6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5a0ede58-0bf4-4633-b292-105d9b986ff4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("022d69cc-c409-4d03-a2f2-f6e2c7b93b1a"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14a9143e-96d7-4f26-8e64-2e95efaf1b19"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("65f5696b-6c61-41f0-bc41-ef2c60438154"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a9ac39dd-e6a3-4dbd-9f3f-2e558bcdb6d3"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a6d9299a-12dd-49e0-8839-2150d091f255"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("93f00221-0f49-44b0-a362-dd5bfee0aa06"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c3f1726-5a91-4713-b007-1390b0d0a8b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3bb53d2-9a90-42d8-ad06-7e09d3f1739c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7eaa2eab-c0b6-4a20-88c4-a180da7a1eac"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6c5d3e2d-284b-4c52-8151-cf280c569771"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1e72ba27-87c2-46f0-8de5-bc40fc85ecad"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5f4bd374-a71c-4158-bef2-6b8f8e46b447"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("236549e5-bf6c-4cd4-998d-4d96351724b7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7bf11855-b5ae-40c4-8440-7fa4742e3562"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aef0c786-54da-4a1a-b04b-34c6a38c634d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e39d9986-640c-4da8-9dbb-6dd38f7f5e16"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c8373e87-9750-46c6-88de-37c67394b751"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c33473ad-67fd-4e09-8904-18459c1e8ef4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("44685001-f2d2-4b2d-9532-3e8c74d028b9"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("10e4727a-e6c6-4124-ac38-c4683548ac50"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("26028a04-20f0-4e10-b010-92b667ba52ed"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b6f3b3e4-a93e-48f2-90a7-1fdb949e594d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5d7284a5-8f8a-4a97-8d55-e4d5ca2f06bf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99ffaa0a-993d-4f75-90f4-a2d4eb4a6f02"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f11e7452-a012-484c-8b84-54cbd038acfd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a46b1837-89b1-4155-826a-9e9d52c2afad"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c7767c83-e288-4146-bd19-37704bafdd63"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("928e8988-cab3-4a00-9d07-4e50c1943baa"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f5abf40d-b596-4479-a5e2-de00ed1a4e36"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bf7fc99-88c5-46ab-8662-83e61b6ae90c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a397e582-b2fd-4e3d-a992-76fe6912afca"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9cd80ed6-d457-46c7-9283-ef6e130401de"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb45915a-993d-43c6-878c-3beef070a080"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("472ad760-80d5-4e14-823d-e17fab0b1cfc"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00dd0e08-986e-43e3-a47d-8d25c9b8816e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("73b63e70-0a79-4750-80f5-84438025100d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ee87d270-203f-48f8-9cf9-d50664298de6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4e5b81c3-ac8f-4e93-9306-a39261ad9914"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a5a85311-1c76-490f-8fa9-affc908202a5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("431bb5bc-38a4-4b0b-9b15-f40bece663cb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("468ea2a8-5f1b-4a04-b591-03b1ca8d2c3f"))));

            }
        }

#endregion

    }
}


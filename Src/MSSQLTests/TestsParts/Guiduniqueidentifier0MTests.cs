

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
    Value = Guid.Parse("195a1949-508f-413d-8f6e-1791ad6a5d98"),
    ModelInner = null,
    NullableValue = Guid.Parse("0d3f6029-de23-45d5-8bb3-453d041981a2"),
},
            new Guiduniqueidentifier0M
{
    Id = 18,
    Value = Guid.Parse("b3f3ddf8-782b-4018-b2e0-2d53b9acce32"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 8,
    Value = Guid.Parse("0ecbf714-a623-4dd8-af01-78246a3802fb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("146a3a6e-ee19-46fa-a97a-06c600a5734f"),
},
            new Guiduniqueidentifier0M
{
    Id = 23,
    Value = Guid.Parse("7524ca4e-a51d-46a1-bc97-4abc2c677c8b"),
    ModelInner = null,
    NullableValue = Guid.Parse("01c713b7-b7f6-4c85-b643-3323e6da435c"),
},
            new Guiduniqueidentifier0M
{
    Id = 29,
    Value = Guid.Parse("9c7b8b50-8bba-4a5d-8de7-c97b74ce5d99"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 17,
    Value = Guid.Parse("649bc124-2986-4662-b4c9-24bbc46fac99"),
    NullableValue = Guid.Parse("12842dc9-b090-482b-9e53-70f13b7d3b4d"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 37,
    Value = Guid.Parse("205df8c4-b51b-4b56-8bcc-a1096b477d37"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 46,
    Value = Guid.Parse("b29e7c5f-c2a4-4eea-9cd4-8ab5086e9e47"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 26,
    Value = Guid.Parse("ef08c637-1ecb-4d49-8800-680e1fa0b4a0"),
    NullableValue = Guid.Parse("31e8b956-d799-429a-bae6-195a397901b4"),
},
    NullableValue = Guid.Parse("a10dcf41-44e9-498b-8200-03082a25a75b"),
},
            new Guiduniqueidentifier0M
{
    Id = 48,
    Value = Guid.Parse("f3bc99e1-86ab-4ef7-8fc5-fb7409efda3b"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 54,
    Value = Guid.Parse("652c31d8-dd24-435e-a3f2-094877a4b21e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 34,
    Value = Guid.Parse("918961fa-bffd-4404-8585-b520821fb24a"),
    NullableValue = Guid.Parse("f6d93f00-76b9-480e-ac2a-eca99d848c0a"),
},
    NullableValue = Guid.Parse("72a4a389-8831-4ccd-9654-0ddd245fb825"),
},
            new Guiduniqueidentifier0M
{
    Id = 62,
    Value = Guid.Parse("d1ae8000-0194-45e1-9a87-b702b2f974bb"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 67,
    Value = Guid.Parse("cdbeefee-d88e-42d5-98fb-fb56ee875882"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 42,
    Value = Guid.Parse("598fcfa5-a216-4eb5-834f-e96d46548609"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 72,
    Value = Guid.Parse("5e7bfdc3-ee38-4257-a809-38e70d0ad9ba"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 74,
    Value = Guid.Parse("3c519dd6-1841-482b-9235-5448c78b4dfb"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 44,
    Value = Guid.Parse("3a07572f-061e-44d1-b2c1-246dd7f9d09a"),
    NullableValue = Guid.Parse("65b9b92f-3b26-4a7e-8062-1631a4dd6481"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 76,
    Value = Guid.Parse("b52f0022-f79b-4e75-9798-4fd118dcf5cd"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 82,
    Value = Guid.Parse("b7914d1b-7523-4932-af54-a5eeb975d281"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 50,
    Value = Guid.Parse("817986f6-3641-4046-81e2-e4aef04d6701"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("6ba9ab9b-6556-4e22-8c8a-3048915867ae"),
},
            new Guiduniqueidentifier0M
{
    Id = 87,
    Value = Guid.Parse("c489725c-290f-4658-a68a-63158e917cc8"),
    ModelInner = null,
    NullableValue = Guid.Parse("9b626843-a6a4-4fd9-a51b-2236d8ee77d4"),
},
            new Guiduniqueidentifier0M
{
    Id = 88,
    Value = Guid.Parse("94e3c169-e8a2-47db-b9d9-579501ebbe64"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 58,
    Value = Guid.Parse("0d91a009-040e-4c62-96a9-8b9a7911a0ab"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("6d6127ac-5c01-4539-a1f5-1e0410124488"),
},
            new Guiduniqueidentifier0M
{
    Id = 89,
    Value = Guid.Parse("515fa8ab-3ace-47b7-a274-ef56f4d24175"),
    ModelInner = null,
    NullableValue = Guid.Parse("5fd6cfc1-559f-4e60-b4ab-ffba93874aab"),
},
            new Guiduniqueidentifier0M
{
    Id = 98,
    Value = Guid.Parse("39fd31fa-7b9e-4bfd-b662-ebf4b60c45da"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 64,
    Value = Guid.Parse("228911a8-869a-4f62-906d-831d145ddafc"),
    NullableValue = Guid.Parse("c3a7a69b-5039-434f-90c8-8eff8a7cd5cd"),
},
    NullableValue = Guid.Parse("bdc35e70-4875-49a6-9259-f7150278e99a"),
},
            new Guiduniqueidentifier0M
{
    Id = 105,
    Value = Guid.Parse("f8f8b55d-c634-4fad-a0bb-db9e7b5e67f5"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 110,
    Value = Guid.Parse("d809cc21-cfc4-4ccd-96ce-b0162b5ced0a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 71,
    Value = Guid.Parse("4936f1e6-4a46-46fd-97d4-f2ec91e4c36f"),
    NullableValue = Guid.Parse("610db67a-0baf-4f5b-a471-7047bfee293a"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 117,
    Value = Guid.Parse("6f35834b-2a13-4f5b-a714-cba6be46d72a"),
    ModelInner = null,
    NullableValue = Guid.Parse("aa49943c-b2b7-4ed0-8a0f-b675cf460187"),
},
            new Guiduniqueidentifier0M
{
    Id = 123,
    Value = Guid.Parse("e090b287-23c3-4661-8b91-d5e37390d0d7"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 79,
    Value = Guid.Parse("13b90648-7c0a-4056-a477-0425f86299c6"),
    NullableValue = Guid.Parse("863b29a4-4f34-4f4d-a9fd-ebb9ce200321"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 129,
    Value = Guid.Parse("736d28d4-a0e6-46c2-9bae-77dde86473d7"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 133,
    Value = Guid.Parse("39f5d028-8a05-43d6-94d2-33469a492df0"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 85,
    Value = Guid.Parse("aa7fd100-a9cf-40a9-b581-4c3b9b948fde"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 134,
    Value = Guid.Parse("52dbd5e2-81c3-4bce-8699-d936b4796bb4"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 143,
    Value = Guid.Parse("5338de4d-b921-42a4-ad28-4fa485c6d6a3"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 93,
    Value = Guid.Parse("35be3d93-5de4-4a68-8074-51bdcd09fbb8"),
    NullableValue = Guid.Parse("a87000d3-790b-40e4-aaac-8243c485887f"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 145,
    Value = Guid.Parse("64d441e4-27f3-4bf1-8c3c-70b67e23f343"),
    ModelInner = null,
    NullableValue = Guid.Parse("4a516cc6-a0e3-414e-b8fa-6547f698e3f1"),
},
            new Guiduniqueidentifier0M
{
    Id = 146,
    Value = Guid.Parse("4a3b0cca-3e6c-4c6a-a13a-e8d98ffeee20"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 99,
    Value = Guid.Parse("e194571e-ff17-48b5-9e0f-49e3f550fc75"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("48fb5589-89f5-4a97-8b77-a98863e91891"),
},
            new Guiduniqueidentifier0M
{
    Id = 155,
    Value = Guid.Parse("8a1d46e8-68f8-4dd1-a3aa-1625857d020f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 159,
    Value = Guid.Parse("08d02a86-f69a-45fa-b34d-23a20be59c7c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 107,
    Value = Guid.Parse("619a8f17-4a78-4309-a4f3-e69676c4e503"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("3e841938-a3ac-49ea-a22a-9f954cc6ed83"),
},
            new Guiduniqueidentifier0M
{
    Id = 167,
    Value = Guid.Parse("320e6ed1-21e2-4c92-a727-014eae69b741"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 174,
    Value = Guid.Parse("04612e76-91de-4cc5-ad42-9ff973b5d762"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 113,
    Value = Guid.Parse("4b69acee-3c8d-4676-aa2d-f1b87da4fef2"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("936085e5-716f-4420-ba08-13a8fd858dab"),
},
            new Guiduniqueidentifier0M
{
    Id = 183,
    Value = Guid.Parse("14998582-ffb6-46da-b089-0221d54605ae"),
    ModelInner = null,
    NullableValue = Guid.Parse("8e3234d4-4861-4db8-9646-f7242249c58e"),
},
            new Guiduniqueidentifier0M
{
    Id = 191,
    Value = Guid.Parse("9209d1c0-9a9a-4090-aed8-2dbbcf525d09"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 122,
    Value = Guid.Parse("682bbe1d-58e9-43e4-a0d6-e3c97dd9966f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 192,
    Value = Guid.Parse("b9f9fd44-65a3-4585-8779-ff2f49117a23"),
    ModelInner = null,
    NullableValue = Guid.Parse("b01c10e3-4315-4e22-8bc0-ca995015efa1"),
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
                parametr1.Value = 87;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
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
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[34], false);
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
                parametr1.Value = 110;
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 123;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 110, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 67, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 134, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[31],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 74, query2))
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
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 37, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 110, query1, 123, query2))
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 88, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 145, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[34], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                Guiduniqueidentifier0M.AssertModel(models[0],_testData[15], false);
                Guiduniqueidentifier0M.AssertModel(models[1],_testData[16], false);
                Guiduniqueidentifier0M.AssertModel(models[2],_testData[17], false);
                Guiduniqueidentifier0M.AssertModel(models[3],_testData[18], false);
                Guiduniqueidentifier0M.AssertModel(models[4],_testData[19], false);
                Guiduniqueidentifier0M.AssertModel(models[5],_testData[20], false);
                Guiduniqueidentifier0M.AssertModel(models[6],_testData[21], false);
                Guiduniqueidentifier0M.AssertModel(models[7],_testData[22], false);
                Guiduniqueidentifier0M.AssertModel(models[8],_testData[23], false);
                Guiduniqueidentifier0M.AssertModel(models[9],_testData[24], false);
                Guiduniqueidentifier0M.AssertModel(models[10],_testData[25], false);
                Guiduniqueidentifier0M.AssertModel(models[11],_testData[26], false);
                Guiduniqueidentifier0M.AssertModel(models[12],_testData[27], false);
                Guiduniqueidentifier0M.AssertModel(models[13],_testData[28], false);
                Guiduniqueidentifier0M.AssertModel(models[14],_testData[29], false);
                Guiduniqueidentifier0M.AssertModel(models[15],_testData[30], false);
                Guiduniqueidentifier0M.AssertModel(models[16],_testData[31], false);
                Guiduniqueidentifier0M.AssertModel(models[17],_testData[32], false);
                Guiduniqueidentifier0M.AssertModel(models[18],_testData[33], false);
                Guiduniqueidentifier0M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("195a1949-508f-413d-8f6e-1791ad6a5d98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0d3f6029-de23-45d5-8bb3-453d041981a2"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b3f3ddf8-782b-4018-b2e0-2d53b9acce32"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0ecbf714-a623-4dd8-af01-78246a3802fb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("146a3a6e-ee19-46fa-a97a-06c600a5734f"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7524ca4e-a51d-46a1-bc97-4abc2c677c8b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("01c713b7-b7f6-4c85-b643-3323e6da435c"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c7b8b50-8bba-4a5d-8de7-c97b74ce5d99"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("649bc124-2986-4662-b4c9-24bbc46fac99"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("12842dc9-b090-482b-9e53-70f13b7d3b4d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("205df8c4-b51b-4b56-8bcc-a1096b477d37"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b29e7c5f-c2a4-4eea-9cd4-8ab5086e9e47"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ef08c637-1ecb-4d49-8800-680e1fa0b4a0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("31e8b956-d799-429a-bae6-195a397901b4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a10dcf41-44e9-498b-8200-03082a25a75b"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f3bc99e1-86ab-4ef7-8fc5-fb7409efda3b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("652c31d8-dd24-435e-a3f2-094877a4b21e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("918961fa-bffd-4404-8585-b520821fb24a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f6d93f00-76b9-480e-ac2a-eca99d848c0a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("72a4a389-8831-4ccd-9654-0ddd245fb825"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d1ae8000-0194-45e1-9a87-b702b2f974bb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cdbeefee-d88e-42d5-98fb-fb56ee875882"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("598fcfa5-a216-4eb5-834f-e96d46548609"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5e7bfdc3-ee38-4257-a809-38e70d0ad9ba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c519dd6-1841-482b-9235-5448c78b4dfb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3a07572f-061e-44d1-b2c1-246dd7f9d09a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("65b9b92f-3b26-4a7e-8062-1631a4dd6481"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b52f0022-f79b-4e75-9798-4fd118dcf5cd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7914d1b-7523-4932-af54-a5eeb975d281"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("817986f6-3641-4046-81e2-e4aef04d6701"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6ba9ab9b-6556-4e22-8c8a-3048915867ae"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c489725c-290f-4658-a68a-63158e917cc8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9b626843-a6a4-4fd9-a51b-2236d8ee77d4"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("94e3c169-e8a2-47db-b9d9-579501ebbe64"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d91a009-040e-4c62-96a9-8b9a7911a0ab"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6d6127ac-5c01-4539-a1f5-1e0410124488"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("515fa8ab-3ace-47b7-a274-ef56f4d24175"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5fd6cfc1-559f-4e60-b4ab-ffba93874aab"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("39fd31fa-7b9e-4bfd-b662-ebf4b60c45da"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("228911a8-869a-4f62-906d-831d145ddafc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c3a7a69b-5039-434f-90c8-8eff8a7cd5cd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bdc35e70-4875-49a6-9259-f7150278e99a"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8f8b55d-c634-4fad-a0bb-db9e7b5e67f5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d809cc21-cfc4-4ccd-96ce-b0162b5ced0a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4936f1e6-4a46-46fd-97d4-f2ec91e4c36f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("610db67a-0baf-4f5b-a471-7047bfee293a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6f35834b-2a13-4f5b-a714-cba6be46d72a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("aa49943c-b2b7-4ed0-8a0f-b675cf460187"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e090b287-23c3-4661-8b91-d5e37390d0d7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("13b90648-7c0a-4056-a477-0425f86299c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("863b29a4-4f34-4f4d-a9fd-ebb9ce200321"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("736d28d4-a0e6-46c2-9bae-77dde86473d7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("39f5d028-8a05-43d6-94d2-33469a492df0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("aa7fd100-a9cf-40a9-b581-4c3b9b948fde"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("52dbd5e2-81c3-4bce-8699-d936b4796bb4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5338de4d-b921-42a4-ad28-4fa485c6d6a3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35be3d93-5de4-4a68-8074-51bdcd09fbb8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a87000d3-790b-40e4-aaac-8243c485887f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("64d441e4-27f3-4bf1-8c3c-70b67e23f343"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4a516cc6-a0e3-414e-b8fa-6547f698e3f1"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4a3b0cca-3e6c-4c6a-a13a-e8d98ffeee20"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e194571e-ff17-48b5-9e0f-49e3f550fc75"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("48fb5589-89f5-4a97-8b77-a98863e91891"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a1d46e8-68f8-4dd1-a3aa-1625857d020f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("08d02a86-f69a-45fa-b34d-23a20be59c7c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((107)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("619a8f17-4a78-4309-a4f3-e69676c4e503"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3e841938-a3ac-49ea-a22a-9f954cc6ed83"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("320e6ed1-21e2-4c92-a727-014eae69b741"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("04612e76-91de-4cc5-ad42-9ff973b5d762"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((113)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4b69acee-3c8d-4676-aa2d-f1b87da4fef2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("936085e5-716f-4420-ba08-13a8fd858dab"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14998582-ffb6-46da-b089-0221d54605ae"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8e3234d4-4861-4db8-9646-f7242249c58e"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9209d1c0-9a9a-4090-aed8-2dbbcf525d09"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((122)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("682bbe1d-58e9-43e4-a0d6-e3c97dd9966f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b9f9fd44-65a3-4585-8779-ff2f49117a23"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b01c10e3-4315-4e22-8bc0-ca995015efa1"))));

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("195a1949-508f-413d-8f6e-1791ad6a5d98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0d3f6029-de23-45d5-8bb3-453d041981a2"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b3f3ddf8-782b-4018-b2e0-2d53b9acce32"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0ecbf714-a623-4dd8-af01-78246a3802fb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("146a3a6e-ee19-46fa-a97a-06c600a5734f"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7524ca4e-a51d-46a1-bc97-4abc2c677c8b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("01c713b7-b7f6-4c85-b643-3323e6da435c"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c7b8b50-8bba-4a5d-8de7-c97b74ce5d99"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("649bc124-2986-4662-b4c9-24bbc46fac99"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("12842dc9-b090-482b-9e53-70f13b7d3b4d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("205df8c4-b51b-4b56-8bcc-a1096b477d37"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b29e7c5f-c2a4-4eea-9cd4-8ab5086e9e47"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ef08c637-1ecb-4d49-8800-680e1fa0b4a0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("31e8b956-d799-429a-bae6-195a397901b4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a10dcf41-44e9-498b-8200-03082a25a75b"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f3bc99e1-86ab-4ef7-8fc5-fb7409efda3b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("652c31d8-dd24-435e-a3f2-094877a4b21e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("918961fa-bffd-4404-8585-b520821fb24a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f6d93f00-76b9-480e-ac2a-eca99d848c0a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("72a4a389-8831-4ccd-9654-0ddd245fb825"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d1ae8000-0194-45e1-9a87-b702b2f974bb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cdbeefee-d88e-42d5-98fb-fb56ee875882"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("598fcfa5-a216-4eb5-834f-e96d46548609"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5e7bfdc3-ee38-4257-a809-38e70d0ad9ba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c519dd6-1841-482b-9235-5448c78b4dfb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3a07572f-061e-44d1-b2c1-246dd7f9d09a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("65b9b92f-3b26-4a7e-8062-1631a4dd6481"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b52f0022-f79b-4e75-9798-4fd118dcf5cd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7914d1b-7523-4932-af54-a5eeb975d281"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("817986f6-3641-4046-81e2-e4aef04d6701"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6ba9ab9b-6556-4e22-8c8a-3048915867ae"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c489725c-290f-4658-a68a-63158e917cc8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9b626843-a6a4-4fd9-a51b-2236d8ee77d4"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("94e3c169-e8a2-47db-b9d9-579501ebbe64"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d91a009-040e-4c62-96a9-8b9a7911a0ab"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6d6127ac-5c01-4539-a1f5-1e0410124488"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("515fa8ab-3ace-47b7-a274-ef56f4d24175"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5fd6cfc1-559f-4e60-b4ab-ffba93874aab"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("39fd31fa-7b9e-4bfd-b662-ebf4b60c45da"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("228911a8-869a-4f62-906d-831d145ddafc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c3a7a69b-5039-434f-90c8-8eff8a7cd5cd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bdc35e70-4875-49a6-9259-f7150278e99a"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8f8b55d-c634-4fad-a0bb-db9e7b5e67f5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d809cc21-cfc4-4ccd-96ce-b0162b5ced0a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4936f1e6-4a46-46fd-97d4-f2ec91e4c36f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("610db67a-0baf-4f5b-a471-7047bfee293a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6f35834b-2a13-4f5b-a714-cba6be46d72a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("aa49943c-b2b7-4ed0-8a0f-b675cf460187"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e090b287-23c3-4661-8b91-d5e37390d0d7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("13b90648-7c0a-4056-a477-0425f86299c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("863b29a4-4f34-4f4d-a9fd-ebb9ce200321"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("736d28d4-a0e6-46c2-9bae-77dde86473d7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("39f5d028-8a05-43d6-94d2-33469a492df0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("aa7fd100-a9cf-40a9-b581-4c3b9b948fde"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("52dbd5e2-81c3-4bce-8699-d936b4796bb4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5338de4d-b921-42a4-ad28-4fa485c6d6a3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35be3d93-5de4-4a68-8074-51bdcd09fbb8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a87000d3-790b-40e4-aaac-8243c485887f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("64d441e4-27f3-4bf1-8c3c-70b67e23f343"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4a516cc6-a0e3-414e-b8fa-6547f698e3f1"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4a3b0cca-3e6c-4c6a-a13a-e8d98ffeee20"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e194571e-ff17-48b5-9e0f-49e3f550fc75"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("48fb5589-89f5-4a97-8b77-a98863e91891"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a1d46e8-68f8-4dd1-a3aa-1625857d020f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("08d02a86-f69a-45fa-b34d-23a20be59c7c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((107)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("619a8f17-4a78-4309-a4f3-e69676c4e503"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3e841938-a3ac-49ea-a22a-9f954cc6ed83"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("320e6ed1-21e2-4c92-a727-014eae69b741"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("04612e76-91de-4cc5-ad42-9ff973b5d762"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((113)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4b69acee-3c8d-4676-aa2d-f1b87da4fef2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("936085e5-716f-4420-ba08-13a8fd858dab"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14998582-ffb6-46da-b089-0221d54605ae"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8e3234d4-4861-4db8-9646-f7242249c58e"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9209d1c0-9a9a-4090-aed8-2dbbcf525d09"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((122)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("682bbe1d-58e9-43e4-a0d6-e3c97dd9966f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b9f9fd44-65a3-4585-8779-ff2f49117a23"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b01c10e3-4315-4e22-8bc0-ca995015efa1"))));

            }
        }

#endregion

    }
}


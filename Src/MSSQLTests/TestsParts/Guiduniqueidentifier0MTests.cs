

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
    Id = 7,
    Value = Guid.Parse("59fef12b-85ae-4e01-9980-b49dae5abf7d"),
    ModelInner = null,
    NullableValue = Guid.Parse("10e16588-a96e-45cf-8453-c771f0ac071c"),
},
            new Guiduniqueidentifier0M
{
    Id = 14,
    Value = Guid.Parse("cc0abde6-ae8d-462f-8caf-93bdede335ec"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 4,
    Value = Guid.Parse("180cdb6c-adbd-4dce-aa58-3e6285eca744"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 16,
    Value = Guid.Parse("7d56eb47-9b64-4490-a619-61bab374d3f1"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 19,
    Value = Guid.Parse("3798fb63-e8ce-46fb-a967-45fbdb842bcb"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 8,
    Value = Guid.Parse("c995b5e0-b983-4580-aaac-45cf63e654c0"),
    NullableValue = Guid.Parse("bdf5c830-41ae-49af-8d56-53f6709a3bf9"),
},
    NullableValue = Guid.Parse("b198d2a4-8294-464f-ae7b-8a2bf8b7a5bf"),
},
            new Guiduniqueidentifier0M
{
    Id = 25,
    Value = Guid.Parse("5799fa48-4576-4026-b496-b320f61918d2"),
    ModelInner = null,
    NullableValue = Guid.Parse("dd19d2c6-185a-4e5e-b457-076e318338fc"),
},
            new Guiduniqueidentifier0M
{
    Id = 33,
    Value = Guid.Parse("8311bed4-5293-4e19-a6f0-a82f77159ed6"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 13,
    Value = Guid.Parse("1927a422-1757-416d-801d-0f073472413b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("20aa6168-4391-4d8b-a726-0153636e4115"),
},
            new Guiduniqueidentifier0M
{
    Id = 36,
    Value = Guid.Parse("61d8f9a4-4660-49a5-b0f0-42a1988d7b72"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 40,
    Value = Guid.Parse("e56606a6-8ec3-4ae7-8c5c-eab6f0de890f"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 15,
    Value = Guid.Parse("f735a525-82f6-4095-82a6-f62de2e140d4"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("1324bf54-e41f-479e-a362-fd752e384183"),
},
            new Guiduniqueidentifier0M
{
    Id = 41,
    Value = Guid.Parse("019090e1-b328-45db-bc14-0a0b6882f7c8"),
    ModelInner = null,
    NullableValue = Guid.Parse("981ef9e4-3c26-4045-bdb8-8641849da393"),
},
            new Guiduniqueidentifier0M
{
    Id = 49,
    Value = Guid.Parse("0e4ec748-8dd3-4fad-b49b-cb0c432e5536"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 21,
    Value = Guid.Parse("98eca535-70d4-4cce-95e5-052bf36fe8e4"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 51,
    Value = Guid.Parse("b26b54f9-1bb9-4ee3-8c0b-c1d73982968c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 57,
    Value = Guid.Parse("7423ff8c-4954-435e-9651-4e7c3a0e46bb"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 27,
    Value = Guid.Parse("bcfe6253-658d-44ba-8c8e-28a0a18a0bc5"),
    NullableValue = Guid.Parse("d0cbf926-083a-41ca-9906-a28a331716fc"),
},
    NullableValue = Guid.Parse("c30c8dfd-fbc2-4aad-8758-d7d0b32e80a6"),
},
            new Guiduniqueidentifier0M
{
    Id = 60,
    Value = Guid.Parse("bab29b6f-5f07-47fa-a009-ce030157560c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 65,
    Value = Guid.Parse("8fbe3509-d758-44c5-9b5c-21a69b8103bd"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 31,
    Value = Guid.Parse("8358708e-7456-4ffd-8657-da534a277f5e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 69,
    Value = Guid.Parse("12e57e97-2f5b-4d82-be8c-5c094b5377b9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 72,
    Value = Guid.Parse("0cb7f061-5212-4151-ab64-13e548b45307"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 35,
    Value = Guid.Parse("be73b18a-2ed1-4b70-8ef2-5f857ce30f35"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 77,
    Value = Guid.Parse("1aea0116-c0bb-4116-b723-7b85aa349879"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 79,
    Value = Guid.Parse("4ed17e93-4cc3-455e-a61a-533f2051226e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 44,
    Value = Guid.Parse("9587af70-0fde-48fa-8d32-78f973801329"),
    NullableValue = Guid.Parse("b6c37c37-bdbe-4bcf-89eb-90341430adbb"),
},
    NullableValue = Guid.Parse("c4f43742-4210-4878-91be-f0b9e96a0822"),
},
            new Guiduniqueidentifier0M
{
    Id = 80,
    Value = Guid.Parse("7af019fd-c2cd-4e88-b2af-ce90f558e320"),
    ModelInner = null,
    NullableValue = Guid.Parse("4dd5afd3-8556-4d1d-83bc-66b36f2f2595"),
},
            new Guiduniqueidentifier0M
{
    Id = 84,
    Value = Guid.Parse("551f4082-d61d-4dcd-adee-99fb2c5c7b8a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 48,
    Value = Guid.Parse("07bd7642-7812-48db-bb81-35fff79bf235"),
    NullableValue = Guid.Parse("3a955627-1f91-4bfb-8b2c-e8a7686c9bda"),
},
    NullableValue = Guid.Parse("56e177bc-6064-4c6a-82a5-9c0c825a71a8"),
},
            new Guiduniqueidentifier0M
{
    Id = 92,
    Value = Guid.Parse("0e69f30f-23b0-4c26-b2ea-c49b9b1deb05"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 95,
    Value = Guid.Parse("4cfee554-5418-4f84-9d1b-03fb2a949a1d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 55,
    Value = Guid.Parse("4756c188-ea79-4262-ba5a-4a03abe595b5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("37855207-f652-4c09-835c-a7fd15b86187"),
},
            new Guiduniqueidentifier0M
{
    Id = 103,
    Value = Guid.Parse("065a342e-ea6a-4704-94c3-2be430fc8182"),
    ModelInner = null,
    NullableValue = Guid.Parse("0595202b-14ca-4a36-9187-3ae3ff3c0004"),
},
            new Guiduniqueidentifier0M
{
    Id = 107,
    Value = Guid.Parse("744402d5-493b-4f0d-8497-d738f469da88"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 57,
    Value = Guid.Parse("9bb1020c-57c0-48e6-9e9f-58d52a8ca073"),
    NullableValue = Guid.Parse("3ea3970c-2474-4fa5-82b6-a6d9c202032d"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 115,
    Value = Guid.Parse("22405744-ad97-4743-a8b2-7f75225e71d8"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 123,
    Value = Guid.Parse("a018c1a0-e17a-44d5-9557-3d07f7ec5b42"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 62,
    Value = Guid.Parse("e1339be4-e067-49ac-b331-f164b3e18f83"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("637bc853-f741-4479-b453-ef5a39252dbe"),
},
            new Guiduniqueidentifier0M
{
    Id = 127,
    Value = Guid.Parse("66ce446f-728f-49f3-9a3d-cb76abe0ec98"),
    ModelInner = null,
    NullableValue = Guid.Parse("b8bb4c1c-7c0a-411b-8e53-d796b66ecebc"),
},
            new Guiduniqueidentifier0M
{
    Id = 133,
    Value = Guid.Parse("a98569fa-d0d0-4da0-b0b3-221f64cbb3f1"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 68,
    Value = Guid.Parse("865331fd-1799-444a-b4c8-47a52ae82d8d"),
    NullableValue = Guid.Parse("9f5ef1df-4b41-411f-a308-fe2303a8715d"),
},
    NullableValue = Guid.Parse("c1ac78b3-c0d1-413a-9154-945daac911c8"),
},
            new Guiduniqueidentifier0M
{
    Id = 140,
    Value = Guid.Parse("a6b02c14-8acf-413e-bac8-1060b7555330"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 143,
    Value = Guid.Parse("7e5dd1fc-d30d-49e9-9107-27454fbef122"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 74,
    Value = Guid.Parse("5ef2c40c-0f10-4734-a2fe-abb3861966e4"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("22571db9-9754-4809-b930-d2e00e963c38"),
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[29], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[29], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                        Assert.That(models, Has.Count.EqualTo(15));

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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 33, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[29], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 19, query1, 80, query2))
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[29], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 40, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 36, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 51, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 65, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 25, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[6], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("59fef12b-85ae-4e01-9980-b49dae5abf7d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("10e16588-a96e-45cf-8453-c771f0ac071c"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cc0abde6-ae8d-462f-8caf-93bdede335ec"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("180cdb6c-adbd-4dce-aa58-3e6285eca744"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7d56eb47-9b64-4490-a619-61bab374d3f1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3798fb63-e8ce-46fb-a967-45fbdb842bcb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c995b5e0-b983-4580-aaac-45cf63e654c0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bdf5c830-41ae-49af-8d56-53f6709a3bf9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b198d2a4-8294-464f-ae7b-8a2bf8b7a5bf"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5799fa48-4576-4026-b496-b320f61918d2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dd19d2c6-185a-4e5e-b457-076e318338fc"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8311bed4-5293-4e19-a6f0-a82f77159ed6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1927a422-1757-416d-801d-0f073472413b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("20aa6168-4391-4d8b-a726-0153636e4115"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("61d8f9a4-4660-49a5-b0f0-42a1988d7b72"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e56606a6-8ec3-4ae7-8c5c-eab6f0de890f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f735a525-82f6-4095-82a6-f62de2e140d4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1324bf54-e41f-479e-a362-fd752e384183"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019090e1-b328-45db-bc14-0a0b6882f7c8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("981ef9e4-3c26-4045-bdb8-8641849da393"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e4ec748-8dd3-4fad-b49b-cb0c432e5536"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("98eca535-70d4-4cce-95e5-052bf36fe8e4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b26b54f9-1bb9-4ee3-8c0b-c1d73982968c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7423ff8c-4954-435e-9651-4e7c3a0e46bb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bcfe6253-658d-44ba-8c8e-28a0a18a0bc5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d0cbf926-083a-41ca-9906-a28a331716fc"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c30c8dfd-fbc2-4aad-8758-d7d0b32e80a6"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bab29b6f-5f07-47fa-a009-ce030157560c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8fbe3509-d758-44c5-9b5c-21a69b8103bd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8358708e-7456-4ffd-8657-da534a277f5e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("12e57e97-2f5b-4d82-be8c-5c094b5377b9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0cb7f061-5212-4151-ab64-13e548b45307"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("be73b18a-2ed1-4b70-8ef2-5f857ce30f35"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1aea0116-c0bb-4116-b723-7b85aa349879"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4ed17e93-4cc3-455e-a61a-533f2051226e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9587af70-0fde-48fa-8d32-78f973801329"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b6c37c37-bdbe-4bcf-89eb-90341430adbb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c4f43742-4210-4878-91be-f0b9e96a0822"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7af019fd-c2cd-4e88-b2af-ce90f558e320"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4dd5afd3-8556-4d1d-83bc-66b36f2f2595"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("551f4082-d61d-4dcd-adee-99fb2c5c7b8a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("07bd7642-7812-48db-bb81-35fff79bf235"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3a955627-1f91-4bfb-8b2c-e8a7686c9bda"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("56e177bc-6064-4c6a-82a5-9c0c825a71a8"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e69f30f-23b0-4c26-b2ea-c49b9b1deb05"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4cfee554-5418-4f84-9d1b-03fb2a949a1d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4756c188-ea79-4262-ba5a-4a03abe595b5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37855207-f652-4c09-835c-a7fd15b86187"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("065a342e-ea6a-4704-94c3-2be430fc8182"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0595202b-14ca-4a36-9187-3ae3ff3c0004"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("744402d5-493b-4f0d-8497-d738f469da88"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9bb1020c-57c0-48e6-9e9f-58d52a8ca073"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3ea3970c-2474-4fa5-82b6-a6d9c202032d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("22405744-ad97-4743-a8b2-7f75225e71d8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a018c1a0-e17a-44d5-9557-3d07f7ec5b42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e1339be4-e067-49ac-b331-f164b3e18f83"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("637bc853-f741-4479-b453-ef5a39252dbe"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("66ce446f-728f-49f3-9a3d-cb76abe0ec98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b8bb4c1c-7c0a-411b-8e53-d796b66ecebc"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a98569fa-d0d0-4da0-b0b3-221f64cbb3f1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("865331fd-1799-444a-b4c8-47a52ae82d8d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9f5ef1df-4b41-411f-a308-fe2303a8715d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c1ac78b3-c0d1-413a-9154-945daac911c8"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6b02c14-8acf-413e-bac8-1060b7555330"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e5dd1fc-d30d-49e9-9107-27454fbef122"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5ef2c40c-0f10-4734-a2fe-abb3861966e4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("22571db9-9754-4809-b930-d2e00e963c38"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("59fef12b-85ae-4e01-9980-b49dae5abf7d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("10e16588-a96e-45cf-8453-c771f0ac071c"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cc0abde6-ae8d-462f-8caf-93bdede335ec"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("180cdb6c-adbd-4dce-aa58-3e6285eca744"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7d56eb47-9b64-4490-a619-61bab374d3f1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3798fb63-e8ce-46fb-a967-45fbdb842bcb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c995b5e0-b983-4580-aaac-45cf63e654c0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bdf5c830-41ae-49af-8d56-53f6709a3bf9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b198d2a4-8294-464f-ae7b-8a2bf8b7a5bf"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5799fa48-4576-4026-b496-b320f61918d2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dd19d2c6-185a-4e5e-b457-076e318338fc"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8311bed4-5293-4e19-a6f0-a82f77159ed6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1927a422-1757-416d-801d-0f073472413b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("20aa6168-4391-4d8b-a726-0153636e4115"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("61d8f9a4-4660-49a5-b0f0-42a1988d7b72"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e56606a6-8ec3-4ae7-8c5c-eab6f0de890f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f735a525-82f6-4095-82a6-f62de2e140d4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1324bf54-e41f-479e-a362-fd752e384183"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019090e1-b328-45db-bc14-0a0b6882f7c8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("981ef9e4-3c26-4045-bdb8-8641849da393"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e4ec748-8dd3-4fad-b49b-cb0c432e5536"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("98eca535-70d4-4cce-95e5-052bf36fe8e4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b26b54f9-1bb9-4ee3-8c0b-c1d73982968c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7423ff8c-4954-435e-9651-4e7c3a0e46bb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bcfe6253-658d-44ba-8c8e-28a0a18a0bc5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d0cbf926-083a-41ca-9906-a28a331716fc"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c30c8dfd-fbc2-4aad-8758-d7d0b32e80a6"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bab29b6f-5f07-47fa-a009-ce030157560c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8fbe3509-d758-44c5-9b5c-21a69b8103bd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8358708e-7456-4ffd-8657-da534a277f5e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("12e57e97-2f5b-4d82-be8c-5c094b5377b9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0cb7f061-5212-4151-ab64-13e548b45307"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("be73b18a-2ed1-4b70-8ef2-5f857ce30f35"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1aea0116-c0bb-4116-b723-7b85aa349879"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4ed17e93-4cc3-455e-a61a-533f2051226e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9587af70-0fde-48fa-8d32-78f973801329"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b6c37c37-bdbe-4bcf-89eb-90341430adbb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c4f43742-4210-4878-91be-f0b9e96a0822"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7af019fd-c2cd-4e88-b2af-ce90f558e320"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4dd5afd3-8556-4d1d-83bc-66b36f2f2595"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("551f4082-d61d-4dcd-adee-99fb2c5c7b8a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("07bd7642-7812-48db-bb81-35fff79bf235"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3a955627-1f91-4bfb-8b2c-e8a7686c9bda"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("56e177bc-6064-4c6a-82a5-9c0c825a71a8"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e69f30f-23b0-4c26-b2ea-c49b9b1deb05"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4cfee554-5418-4f84-9d1b-03fb2a949a1d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4756c188-ea79-4262-ba5a-4a03abe595b5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37855207-f652-4c09-835c-a7fd15b86187"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("065a342e-ea6a-4704-94c3-2be430fc8182"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0595202b-14ca-4a36-9187-3ae3ff3c0004"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("744402d5-493b-4f0d-8497-d738f469da88"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9bb1020c-57c0-48e6-9e9f-58d52a8ca073"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3ea3970c-2474-4fa5-82b6-a6d9c202032d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("22405744-ad97-4743-a8b2-7f75225e71d8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a018c1a0-e17a-44d5-9557-3d07f7ec5b42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e1339be4-e067-49ac-b331-f164b3e18f83"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("637bc853-f741-4479-b453-ef5a39252dbe"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("66ce446f-728f-49f3-9a3d-cb76abe0ec98"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b8bb4c1c-7c0a-411b-8e53-d796b66ecebc"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a98569fa-d0d0-4da0-b0b3-221f64cbb3f1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("865331fd-1799-444a-b4c8-47a52ae82d8d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9f5ef1df-4b41-411f-a308-fe2303a8715d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c1ac78b3-c0d1-413a-9154-945daac911c8"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6b02c14-8acf-413e-bac8-1060b7555330"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e5dd1fc-d30d-49e9-9107-27454fbef122"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5ef2c40c-0f10-4734-a2fe-abb3861966e4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("22571db9-9754-4809-b930-d2e00e963c38"))));

            }
        }

#endregion

    }
}


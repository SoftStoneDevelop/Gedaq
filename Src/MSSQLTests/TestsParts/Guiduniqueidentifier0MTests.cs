

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
    Value = Guid.Parse("56de4ad8-0660-45ac-a126-b8c982bb3bb8"),
    ModelInner = null,
    NullableValue = Guid.Parse("420f3c79-0ea9-4334-8175-4a378f42387d"),
},
            new Guiduniqueidentifier0M
{
    Id = 11,
    Value = Guid.Parse("60853462-1ee6-4478-86f3-7ff754fb798f"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 2,
    Value = Guid.Parse("2c4ba6de-5507-4cb7-a289-5dec8f08c80f"),
    NullableValue = Guid.Parse("171025a5-a7a2-4062-80a8-dfb41a79823b"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 12,
    Value = Guid.Parse("01dc6007-dfb3-4b92-8f6d-fada271a8ec2"),
    ModelInner = null,
    NullableValue = Guid.Parse("8b430a01-d778-4388-85c5-124c5e23f0df"),
},
            new Guiduniqueidentifier0M
{
    Id = 14,
    Value = Guid.Parse("4109af01-15cb-4855-bf05-48a3d86dbaee"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 10,
    Value = Guid.Parse("29f95ea2-50fe-4317-842c-0f7158fd5602"),
    NullableValue = Guid.Parse("e72401ce-4fc6-4bda-a01e-9cbc4923829a"),
},
    NullableValue = Guid.Parse("49db26bc-ec81-4a9d-b746-48816d46f59f"),
},
            new Guiduniqueidentifier0M
{
    Id = 19,
    Value = Guid.Parse("68fefa17-64d4-431d-afa3-198404592f26"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 21,
    Value = Guid.Parse("78d51964-3bd0-4af4-9712-27936c504340"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 16,
    Value = Guid.Parse("82eb8042-4a99-41f1-80ec-18b83cddb22b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 30,
    Value = Guid.Parse("18943cf9-ec21-4cce-87ed-52542751c480"),
    ModelInner = null,
    NullableValue = Guid.Parse("3c39237b-bd56-4d34-8608-11620a0d3120"),
},
            new Guiduniqueidentifier0M
{
    Id = 39,
    Value = Guid.Parse("f7e35a9f-e50e-4a2e-a0f8-b6cd004120bf"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 20,
    Value = Guid.Parse("4aeaf585-53e3-41c4-93ca-0df51a46ee81"),
    NullableValue = Guid.Parse("562f8341-a0b0-4667-b007-401300692d09"),
},
    NullableValue = Guid.Parse("e4aeadc2-076a-4687-b8a1-7dbbb5ab02d1"),
},
            new Guiduniqueidentifier0M
{
    Id = 43,
    Value = Guid.Parse("7227f241-080a-4410-ad02-2e7c5db06270"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 49,
    Value = Guid.Parse("eaad4f91-1823-4954-94db-88f792eccdc7"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 23,
    Value = Guid.Parse("af237bbf-f998-43bd-b521-13cb378f2dc7"),
    NullableValue = Guid.Parse("6689626b-8394-45d7-a154-31e1f04ecf9a"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 55,
    Value = Guid.Parse("57e42902-f6c5-447e-8c40-8604c56d50d2"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 56,
    Value = Guid.Parse("95d5cbfc-29fc-458f-86d5-131f1bcc2376"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 26,
    Value = Guid.Parse("64729c6e-b8e9-4a24-81f8-08d5a72c261d"),
    NullableValue = Guid.Parse("2015956e-b6b6-4b37-ad74-c622526facf6"),
},
    NullableValue = Guid.Parse("3f59e1ad-a91f-469e-97ed-78b3a5ae7264"),
},
            new Guiduniqueidentifier0M
{
    Id = 57,
    Value = Guid.Parse("9fd4ea30-c121-4008-b36e-3a8971d14e4c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 59,
    Value = Guid.Parse("54a567f3-5cac-41ff-a0d4-e7abf6ec0945"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 29,
    Value = Guid.Parse("166f18fd-0102-48eb-8649-c539a20927bd"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 61,
    Value = Guid.Parse("c1037b74-554f-4a1e-8f74-f6e8e2c45ee4"),
    ModelInner = null,
    NullableValue = Guid.Parse("800116ac-b5b0-4d4c-aebc-555082a904ec"),
},
            new Guiduniqueidentifier0M
{
    Id = 68,
    Value = Guid.Parse("f6a08689-91a9-483d-afb0-674a170d8fde"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 31,
    Value = Guid.Parse("60cb245e-d971-4336-b247-bdc7c3592247"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d8218ac4-39d7-4054-a929-941f63e552df"),
},
            new Guiduniqueidentifier0M
{
    Id = 73,
    Value = Guid.Parse("a7b89035-5b21-4033-b2e2-58a50a98cb69"),
    ModelInner = null,
    NullableValue = Guid.Parse("0db12212-6328-4b96-a1f9-99c17017b9be"),
},
            new Guiduniqueidentifier0M
{
    Id = 77,
    Value = Guid.Parse("af80415a-2bc1-4b59-9c3b-0bdce7234a15"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 33,
    Value = Guid.Parse("8d86f4b8-98d5-4799-86e3-b68a732f7881"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 79,
    Value = Guid.Parse("ca382d98-bdbd-4ce2-bb16-7b93525378ee"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 87,
    Value = Guid.Parse("db869aa1-7cce-48b6-a02b-865aac0f0e2b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 40,
    Value = Guid.Parse("53487ec3-1e65-4aea-a73f-124041885162"),
    NullableValue = Guid.Parse("5bd794a9-5ea0-4056-8511-f891b6f5dad6"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 94,
    Value = Guid.Parse("03d995a1-1a1a-474b-83c4-f336514d7a9b"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 102,
    Value = Guid.Parse("e71acfd6-095e-420b-96c9-440dbc349e11"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 45,
    Value = Guid.Parse("e9794263-ce35-4936-8153-b0c5e2b932b8"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 103,
    Value = Guid.Parse("003cc716-57bd-4e27-b9e4-39359ac977d3"),
    ModelInner = null,
    NullableValue = Guid.Parse("37c18fea-1536-4471-9b83-f95fc854fcc2"),
},
            new Guiduniqueidentifier0M
{
    Id = 109,
    Value = Guid.Parse("b7000688-2949-4fde-996a-97a7eb3381ea"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 48,
    Value = Guid.Parse("ecd02d9f-a383-4c56-b2ea-3784cbe7ad6e"),
    NullableValue = Guid.Parse("dbecc29e-5d9b-4949-8613-a26426352343"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 114,
    Value = Guid.Parse("f6bb5484-0a30-44f8-8fb6-268e6aca3887"),
    ModelInner = null,
    NullableValue = Guid.Parse("57c172f5-c453-4b8c-8d32-9940e66fcf1a"),
},
            new Guiduniqueidentifier0M
{
    Id = 118,
    Value = Guid.Parse("3f9b113f-5a45-4d99-8ea9-e77443481b71"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 55,
    Value = Guid.Parse("b92f739e-7d5a-447e-8f8c-bc512e193bb9"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 125,
    Value = Guid.Parse("7e5ccce1-a2f8-44d4-a7b0-85575550932f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 127,
    Value = Guid.Parse("aa9f814f-430d-4155-9ae4-417c5ad4ce19"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 57,
    Value = Guid.Parse("c54139d6-f883-4e1c-b2f2-780ebe6492c1"),
    NullableValue = Guid.Parse("a2973eb4-93fe-4093-8331-cdab73af093a"),
},
    NullableValue = Guid.Parse("a52de5da-0fd3-4af8-9b31-54f291dd61e3"),
},
            new Guiduniqueidentifier0M
{
    Id = 131,
    Value = Guid.Parse("715141c3-c1ce-44df-87cb-8545c848dc67"),
    ModelInner = null,
    NullableValue = Guid.Parse("f5afc5f3-12ff-41f7-8d82-70d80ffe077c"),
},
            new Guiduniqueidentifier0M
{
    Id = 135,
    Value = Guid.Parse("f8c48736-f1b7-4ffa-9447-0057d6e4db8a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 66,
    Value = Guid.Parse("82a07803-4a82-4b23-bf54-6a17dbc83f04"),
    NullableValue = Guid.Parse("d90ac4b0-7aed-46b9-8f34-b9590ecc96cf"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 136,
    Value = Guid.Parse("3d53a3ed-9464-4995-938f-7b4ac6b72d5d"),
    ModelInner = null,
    NullableValue = Guid.Parse("c6f142e8-9a30-4976-a8a8-ed04fa9fd270"),
},
            new Guiduniqueidentifier0M
{
    Id = 144,
    Value = Guid.Parse("227c09ec-49de-4e5c-83b2-8f79a38ec45f"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 72,
    Value = Guid.Parse("52693333-cd08-4dd6-a09f-8441013b1f2d"),
    NullableValue = Guid.Parse("a8b7f2e6-4f56-4f18-a8b2-9ba6136f8478"),
},
    NullableValue = Guid.Parse("a286207e-c496-496f-b267-3c7f543e4fed"),
},
            new Guiduniqueidentifier0M
{
    Id = 147,
    Value = Guid.Parse("45c511a7-4a1b-4fe0-9bb9-0013af0000c7"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 153,
    Value = Guid.Parse("0678c193-b96b-4dba-8666-2acbbcdf2158"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 74,
    Value = Guid.Parse("160fa3cf-8a09-4e3d-af05-6fb58cfcbd78"),
    NullableValue = Guid.Parse("80f16101-5933-4196-bb2d-ef094163e371"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 161,
    Value = Guid.Parse("4c7fca3d-f287-4c3b-a2e5-c1977a08668d"),
    ModelInner = null,
    NullableValue = Guid.Parse("b2a595b8-6cbd-482c-aa76-0a7fc9a11698"),
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
                parametr1.Value = 73;
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr2.Value = 94;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 77;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 77, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 144, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 3, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 94, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 135, query1, 49, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 49, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 114, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 147, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[34], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[29], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[30], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[31], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[32], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[33], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 57);
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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("56de4ad8-0660-45ac-a126-b8c982bb3bb8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("420f3c79-0ea9-4334-8175-4a378f42387d"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("60853462-1ee6-4478-86f3-7ff754fb798f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2c4ba6de-5507-4cb7-a289-5dec8f08c80f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("171025a5-a7a2-4062-80a8-dfb41a79823b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01dc6007-dfb3-4b92-8f6d-fada271a8ec2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8b430a01-d778-4388-85c5-124c5e23f0df"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4109af01-15cb-4855-bf05-48a3d86dbaee"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("29f95ea2-50fe-4317-842c-0f7158fd5602"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e72401ce-4fc6-4bda-a01e-9cbc4923829a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("49db26bc-ec81-4a9d-b746-48816d46f59f"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("68fefa17-64d4-431d-afa3-198404592f26"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78d51964-3bd0-4af4-9712-27936c504340"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("82eb8042-4a99-41f1-80ec-18b83cddb22b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("18943cf9-ec21-4cce-87ed-52542751c480"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c39237b-bd56-4d34-8608-11620a0d3120"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f7e35a9f-e50e-4a2e-a0f8-b6cd004120bf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4aeaf585-53e3-41c4-93ca-0df51a46ee81"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("562f8341-a0b0-4667-b007-401300692d09"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e4aeadc2-076a-4687-b8a1-7dbbb5ab02d1"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7227f241-080a-4410-ad02-2e7c5db06270"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eaad4f91-1823-4954-94db-88f792eccdc7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("af237bbf-f998-43bd-b521-13cb378f2dc7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6689626b-8394-45d7-a154-31e1f04ecf9a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("57e42902-f6c5-447e-8c40-8604c56d50d2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("95d5cbfc-29fc-458f-86d5-131f1bcc2376"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("64729c6e-b8e9-4a24-81f8-08d5a72c261d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2015956e-b6b6-4b37-ad74-c622526facf6"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3f59e1ad-a91f-469e-97ed-78b3a5ae7264"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9fd4ea30-c121-4008-b36e-3a8971d14e4c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("54a567f3-5cac-41ff-a0d4-e7abf6ec0945"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("166f18fd-0102-48eb-8649-c539a20927bd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c1037b74-554f-4a1e-8f74-f6e8e2c45ee4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("800116ac-b5b0-4d4c-aebc-555082a904ec"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f6a08689-91a9-483d-afb0-674a170d8fde"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("60cb245e-d971-4336-b247-bdc7c3592247"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d8218ac4-39d7-4054-a929-941f63e552df"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a7b89035-5b21-4033-b2e2-58a50a98cb69"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0db12212-6328-4b96-a1f9-99c17017b9be"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af80415a-2bc1-4b59-9c3b-0bdce7234a15"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8d86f4b8-98d5-4799-86e3-b68a732f7881"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ca382d98-bdbd-4ce2-bb16-7b93525378ee"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db869aa1-7cce-48b6-a02b-865aac0f0e2b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("53487ec3-1e65-4aea-a73f-124041885162"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5bd794a9-5ea0-4056-8511-f891b6f5dad6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03d995a1-1a1a-474b-83c4-f336514d7a9b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e71acfd6-095e-420b-96c9-440dbc349e11"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e9794263-ce35-4936-8153-b0c5e2b932b8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("003cc716-57bd-4e27-b9e4-39359ac977d3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37c18fea-1536-4471-9b83-f95fc854fcc2"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7000688-2949-4fde-996a-97a7eb3381ea"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ecd02d9f-a383-4c56-b2ea-3784cbe7ad6e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dbecc29e-5d9b-4949-8613-a26426352343"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f6bb5484-0a30-44f8-8fb6-268e6aca3887"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("57c172f5-c453-4b8c-8d32-9940e66fcf1a"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3f9b113f-5a45-4d99-8ea9-e77443481b71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b92f739e-7d5a-447e-8f8c-bc512e193bb9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e5ccce1-a2f8-44d4-a7b0-85575550932f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aa9f814f-430d-4155-9ae4-417c5ad4ce19"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c54139d6-f883-4e1c-b2f2-780ebe6492c1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a2973eb4-93fe-4093-8331-cdab73af093a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a52de5da-0fd3-4af8-9b31-54f291dd61e3"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("715141c3-c1ce-44df-87cb-8545c848dc67"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f5afc5f3-12ff-41f7-8d82-70d80ffe077c"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8c48736-f1b7-4ffa-9447-0057d6e4db8a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("82a07803-4a82-4b23-bf54-6a17dbc83f04"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d90ac4b0-7aed-46b9-8f34-b9590ecc96cf"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3d53a3ed-9464-4995-938f-7b4ac6b72d5d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c6f142e8-9a30-4976-a8a8-ed04fa9fd270"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("227c09ec-49de-4e5c-83b2-8f79a38ec45f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("52693333-cd08-4dd6-a09f-8441013b1f2d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a8b7f2e6-4f56-4f18-a8b2-9ba6136f8478"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a286207e-c496-496f-b267-3c7f543e4fed"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("45c511a7-4a1b-4fe0-9bb9-0013af0000c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0678c193-b96b-4dba-8666-2acbbcdf2158"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("160fa3cf-8a09-4e3d-af05-6fb58cfcbd78"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("80f16101-5933-4196-bb2d-ef094163e371"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c7fca3d-f287-4c3b-a2e5-c1977a08668d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b2a595b8-6cbd-482c-aa76-0a7fc9a11698"))));

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("56de4ad8-0660-45ac-a126-b8c982bb3bb8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("420f3c79-0ea9-4334-8175-4a378f42387d"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("60853462-1ee6-4478-86f3-7ff754fb798f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2c4ba6de-5507-4cb7-a289-5dec8f08c80f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("171025a5-a7a2-4062-80a8-dfb41a79823b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01dc6007-dfb3-4b92-8f6d-fada271a8ec2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8b430a01-d778-4388-85c5-124c5e23f0df"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4109af01-15cb-4855-bf05-48a3d86dbaee"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("29f95ea2-50fe-4317-842c-0f7158fd5602"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e72401ce-4fc6-4bda-a01e-9cbc4923829a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("49db26bc-ec81-4a9d-b746-48816d46f59f"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("68fefa17-64d4-431d-afa3-198404592f26"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78d51964-3bd0-4af4-9712-27936c504340"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("82eb8042-4a99-41f1-80ec-18b83cddb22b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("18943cf9-ec21-4cce-87ed-52542751c480"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c39237b-bd56-4d34-8608-11620a0d3120"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f7e35a9f-e50e-4a2e-a0f8-b6cd004120bf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4aeaf585-53e3-41c4-93ca-0df51a46ee81"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("562f8341-a0b0-4667-b007-401300692d09"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e4aeadc2-076a-4687-b8a1-7dbbb5ab02d1"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7227f241-080a-4410-ad02-2e7c5db06270"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eaad4f91-1823-4954-94db-88f792eccdc7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("af237bbf-f998-43bd-b521-13cb378f2dc7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6689626b-8394-45d7-a154-31e1f04ecf9a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("57e42902-f6c5-447e-8c40-8604c56d50d2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("95d5cbfc-29fc-458f-86d5-131f1bcc2376"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("64729c6e-b8e9-4a24-81f8-08d5a72c261d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2015956e-b6b6-4b37-ad74-c622526facf6"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3f59e1ad-a91f-469e-97ed-78b3a5ae7264"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9fd4ea30-c121-4008-b36e-3a8971d14e4c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("54a567f3-5cac-41ff-a0d4-e7abf6ec0945"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("166f18fd-0102-48eb-8649-c539a20927bd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c1037b74-554f-4a1e-8f74-f6e8e2c45ee4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("800116ac-b5b0-4d4c-aebc-555082a904ec"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f6a08689-91a9-483d-afb0-674a170d8fde"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("60cb245e-d971-4336-b247-bdc7c3592247"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d8218ac4-39d7-4054-a929-941f63e552df"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a7b89035-5b21-4033-b2e2-58a50a98cb69"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0db12212-6328-4b96-a1f9-99c17017b9be"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af80415a-2bc1-4b59-9c3b-0bdce7234a15"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8d86f4b8-98d5-4799-86e3-b68a732f7881"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ca382d98-bdbd-4ce2-bb16-7b93525378ee"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db869aa1-7cce-48b6-a02b-865aac0f0e2b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("53487ec3-1e65-4aea-a73f-124041885162"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5bd794a9-5ea0-4056-8511-f891b6f5dad6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03d995a1-1a1a-474b-83c4-f336514d7a9b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e71acfd6-095e-420b-96c9-440dbc349e11"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e9794263-ce35-4936-8153-b0c5e2b932b8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("003cc716-57bd-4e27-b9e4-39359ac977d3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("37c18fea-1536-4471-9b83-f95fc854fcc2"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7000688-2949-4fde-996a-97a7eb3381ea"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ecd02d9f-a383-4c56-b2ea-3784cbe7ad6e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dbecc29e-5d9b-4949-8613-a26426352343"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f6bb5484-0a30-44f8-8fb6-268e6aca3887"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("57c172f5-c453-4b8c-8d32-9940e66fcf1a"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3f9b113f-5a45-4d99-8ea9-e77443481b71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b92f739e-7d5a-447e-8f8c-bc512e193bb9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e5ccce1-a2f8-44d4-a7b0-85575550932f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aa9f814f-430d-4155-9ae4-417c5ad4ce19"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c54139d6-f883-4e1c-b2f2-780ebe6492c1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a2973eb4-93fe-4093-8331-cdab73af093a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a52de5da-0fd3-4af8-9b31-54f291dd61e3"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("715141c3-c1ce-44df-87cb-8545c848dc67"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f5afc5f3-12ff-41f7-8d82-70d80ffe077c"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8c48736-f1b7-4ffa-9447-0057d6e4db8a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("82a07803-4a82-4b23-bf54-6a17dbc83f04"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d90ac4b0-7aed-46b9-8f34-b9590ecc96cf"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3d53a3ed-9464-4995-938f-7b4ac6b72d5d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c6f142e8-9a30-4976-a8a8-ed04fa9fd270"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("227c09ec-49de-4e5c-83b2-8f79a38ec45f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("52693333-cd08-4dd6-a09f-8441013b1f2d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a8b7f2e6-4f56-4f18-a8b2-9ba6136f8478"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a286207e-c496-496f-b267-3c7f543e4fed"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("45c511a7-4a1b-4fe0-9bb9-0013af0000c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0678c193-b96b-4dba-8666-2acbbcdf2158"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("160fa3cf-8a09-4e3d-af05-6fb58cfcbd78"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("80f16101-5933-4196-bb2d-ef094163e371"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c7fca3d-f287-4c3b-a2e5-c1977a08668d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b2a595b8-6cbd-482c-aa76-0a7fc9a11698"))));

            }
        }

#endregion

    }
}


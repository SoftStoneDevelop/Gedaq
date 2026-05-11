

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
    Id = 7,
    Value = Guid.Parse("09869de5-5b2f-4a3d-a2ac-2c5123596fba"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 9,
    Value = Guid.Parse("35fa043c-11db-4bfb-b9bb-95b32f1db96b"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 4,
    Value = Guid.Parse("d8f073bb-b643-482b-b50d-69671743b7b3"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 18,
    Value = Guid.Parse("295cb907-e1cd-461f-9d91-78b2056925ba"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 27,
    Value = Guid.Parse("67fa6878-cb07-44c5-a9b0-500cd13bcb07"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 7,
    Value = Guid.Parse("e74eadb0-4417-4bc2-8059-60ab2552efa4"),
    NullableValue = Guid.Parse("a295c571-187b-4000-aadb-cf610558386f"),
},
    NullableValue = Guid.Parse("612e3942-b89d-4257-8f21-234074c23b46"),
},
            new GuiduniqueidentifierE0M
{
    Id = 28,
    Value = Guid.Parse("5cbfbbe4-0806-4c83-b3c4-30853da534ea"),
    ModelInner = null,
    NullableValue = Guid.Parse("d3fe36d9-3ff1-421e-8bcb-ba635cc107f0"),
},
            new GuiduniqueidentifierE0M
{
    Id = 30,
    Value = Guid.Parse("fe1c9ede-4098-429a-9fbb-c98af22f52bd"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 14,
    Value = Guid.Parse("6fa444a7-bbde-47c6-9726-aece011e94b3"),
    NullableValue = Guid.Parse("47f77909-6c1c-4661-95ee-d90d8ddbe7eb"),
},
    NullableValue = Guid.Parse("443329e5-ee14-4a26-9fee-17019c4dd919"),
},
            new GuiduniqueidentifierE0M
{
    Id = 36,
    Value = Guid.Parse("d16dfe84-41ef-4249-a801-b1f8ef552f32"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 45,
    Value = Guid.Parse("a7e8e0e2-7206-48f3-80e5-1637806e0343"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 18,
    Value = Guid.Parse("676d1e64-bccf-42d6-becb-ccfa8c1d92c5"),
    NullableValue = Guid.Parse("1dc9cf36-d353-4e38-8c78-c1dcd2f2722d"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 52,
    Value = Guid.Parse("3b8db4e8-4b1b-47e3-b62b-dd2011df36df"),
    ModelInner = null,
    NullableValue = Guid.Parse("5c8d7de3-7650-46da-a2d6-f89ec5f302c6"),
},
            new GuiduniqueidentifierE0M
{
    Id = 59,
    Value = Guid.Parse("0983ff03-8e0b-4e1a-aa8d-fcda96078ac8"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 19,
    Value = Guid.Parse("fecb8a19-59f7-4791-acde-11e1440ce8ea"),
    NullableValue = Guid.Parse("108177cb-418a-45ee-9351-3f49eb18a2f5"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 64,
    Value = Guid.Parse("ff8e0514-5ce5-40d7-b305-a16273d131e2"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 69,
    Value = Guid.Parse("e1bdd551-6b24-4bb9-b06c-deab99b9819f"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 25,
    Value = Guid.Parse("30a8651d-765a-4020-92cc-48ea8dfb3026"),
    NullableValue = Guid.Parse("ce6133dc-c47d-4e98-959d-3c1e4fa1cc24"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 76,
    Value = Guid.Parse("9479f8b6-4e84-42c4-8767-c033803a600f"),
    ModelInner = null,
    NullableValue = Guid.Parse("acb81b97-4ef8-4a1f-a160-8c831720bfbf"),
},
            new GuiduniqueidentifierE0M
{
    Id = 79,
    Value = Guid.Parse("2aa5b8da-43d8-4202-96fe-be4073593645"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 30,
    Value = Guid.Parse("75e78f67-499d-454b-823a-0b438f6d3a84"),
    NullableValue = Guid.Parse("df735bc9-fd30-4f9e-b767-5f38e5e2afb7"),
},
    NullableValue = Guid.Parse("5d851b3d-817d-4fda-8d36-8b91bcc48fd4"),
},
            new GuiduniqueidentifierE0M
{
    Id = 86,
    Value = Guid.Parse("e6af6dcb-3fbd-46de-89ba-509b1da7ad0e"),
    ModelInner = null,
    NullableValue = Guid.Parse("0b57fbac-80d5-4b2b-802b-267c401e4608"),
},
            new GuiduniqueidentifierE0M
{
    Id = 90,
    Value = Guid.Parse("7a2f4858-24a4-41cf-8d98-ce4d799b9a69"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 36,
    Value = Guid.Parse("83317ac1-bd02-418e-a347-57e047189776"),
    NullableValue = Guid.Parse("905db28b-e7a9-4905-a15d-73b9fc5e8f7e"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 98,
    Value = Guid.Parse("aa17eced-08d3-46d0-b4bb-c6dad91b6fb8"),
    ModelInner = null,
    NullableValue = Guid.Parse("0f8a7ca8-4bc3-4b92-a95e-e9b1435aed99"),
},
            new GuiduniqueidentifierE0M
{
    Id = 106,
    Value = Guid.Parse("cad3a344-ba34-4394-be15-f94ffcc99c75"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 38,
    Value = Guid.Parse("da3bf90c-82c8-4bbb-b89c-722cef2611bd"),
    NullableValue = Guid.Parse("163eacbb-fc86-453d-be20-b0066cacd672"),
},
    NullableValue = Guid.Parse("8f9ddb76-f61b-4d31-a93c-0c4ac4c204e8"),
},
            new GuiduniqueidentifierE0M
{
    Id = 112,
    Value = Guid.Parse("92e15669-b136-4f54-b23a-41ee7ea4666f"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 115,
    Value = Guid.Parse("f763e7d1-e823-4d85-b88f-088b8d697b1c"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 39,
    Value = Guid.Parse("5b0fb6f1-d44a-429a-a4f7-7f4ec99f8f44"),
    NullableValue = Guid.Parse("ca750ed0-c8f4-4298-9b85-6d003a610d8e"),
},
    NullableValue = Guid.Parse("c26cdfb4-1548-4ad7-bfb0-bbd56fda29af"),
},
            new GuiduniqueidentifierE0M
{
    Id = 121,
    Value = Guid.Parse("add38620-6b64-4b7c-8074-f4dd8b57b0f8"),
    ModelInner = null,
    NullableValue = Guid.Parse("f5ae36ac-785e-4b0e-9316-840dfc364fbc"),
},
            new GuiduniqueidentifierE0M
{
    Id = 129,
    Value = Guid.Parse("87a415ef-1eb1-4b16-9a23-5f984b34ff28"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 45,
    Value = Guid.Parse("210d05f4-23a2-4152-b358-53fe4d1616bf"),
    NullableValue = Guid.Parse("6c8d07c7-e73f-4265-9b9f-a112d7a3bd83"),
},
    NullableValue = Guid.Parse("45b2e274-4b5b-4b91-a072-d84e6554c331"),
},
            new GuiduniqueidentifierE0M
{
    Id = 130,
    Value = Guid.Parse("e30cecdb-d3d8-445e-98e1-72f161317a65"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 136,
    Value = Guid.Parse("f1465c7f-605b-40ac-8890-c5174915d325"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 54,
    Value = Guid.Parse("9190a47e-0e1f-4e74-9c8a-b2718c6ce647"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("fb2e2d82-4bcf-40e6-beb8-4459b4366f5f"),
},
            new GuiduniqueidentifierE0M
{
    Id = 139,
    Value = Guid.Parse("79c9487c-f3aa-42f6-9014-c1d4b32439b6"),
    ModelInner = null,
    NullableValue = Guid.Parse("49d36fbb-334a-4250-afec-896c1db93152"),
},
            new GuiduniqueidentifierE0M
{
    Id = 144,
    Value = Guid.Parse("3f2b4f12-96f1-4224-9119-ead316fbd86f"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 61,
    Value = Guid.Parse("0432ae4c-be0a-4435-83a9-5b900a86bf84"),
    NullableValue = Guid.Parse("9e1528dc-1d12-4ecb-b9dc-36dc8e0f05b5"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 146,
    Value = Guid.Parse("3ba895c6-b2ec-47f0-b4ee-b1c434a9f472"),
    ModelInner = null,
    NullableValue = Guid.Parse("bd6b407b-4d59-4fd9-a3e3-63e8384bd3cd"),
},
            new GuiduniqueidentifierE0M
{
    Id = 154,
    Value = Guid.Parse("c4d06948-5cfa-41d2-8ceb-20c57b39e432"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 63,
    Value = Guid.Parse("d7d11ba1-65c3-4ac0-a177-68211e138128"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 159,
    Value = Guid.Parse("78fac632-d1a2-4806-9902-8e96f77c2638"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 164,
    Value = Guid.Parse("00f8d594-42e3-4b2d-99f3-2af18f63d3ac"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 71,
    Value = Guid.Parse("424e4063-7d22-4f79-9c86-65c5d0446a89"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d3e0677e-258d-48cd-addb-d0bf2cdd4720"),
},
            new GuiduniqueidentifierE0M
{
    Id = 168,
    Value = Guid.Parse("581aa728-3181-47fc-821b-9f4e53668b26"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 169,
    Value = Guid.Parse("ba2025d5-7c0e-44dc-ab24-53b4943b9cf5"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 74,
    Value = Guid.Parse("03d007c9-f9bf-47ee-9b26-82f5c48afc7f"),
    NullableValue = Guid.Parse("f2ce4a9d-0fbf-4cbc-aacb-094b4a4e1de8"),
},
    NullableValue = Guid.Parse("8cd61a80-0e02-4d13-ad2b-2b28eaa53704"),
},
            new GuiduniqueidentifierE0M
{
    Id = 172,
    Value = Guid.Parse("741fd802-a7e4-474e-adb5-b6245d0b5908"),
    ModelInner = null,
    NullableValue = Guid.Parse("812fefcd-3e6d-4f26-9870-c44a8039d083"),
},
            new GuiduniqueidentifierE0M
{
    Id = 181,
    Value = Guid.Parse("d790d563-7b91-46a2-834e-85d993ae8f3b"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 76,
    Value = Guid.Parse("be23cad0-a9d5-4cef-a23b-e743edda084a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 189,
    Value = Guid.Parse("9e16bbf6-47ff-4970-9296-ebc323b8336d"),
    ModelInner = null,
    NullableValue = Guid.Parse("d5eea2cc-bf8a-455a-ab24-96e2f328bc98"),
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 164;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[5], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[6], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[28],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 28, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 90, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 159, query1, 144, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 64, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 86, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 121))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 18, 76))
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[17], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[18], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[19], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[20], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[21], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[22], false);
                GuiduniqueidentifierE0M.AssertModel(models[6],_testData[23], false);
                GuiduniqueidentifierE0M.AssertModel(models[7],_testData[24], false);
                GuiduniqueidentifierE0M.AssertModel(models[8],_testData[25], false);
                GuiduniqueidentifierE0M.AssertModel(models[9],_testData[26], false);
                GuiduniqueidentifierE0M.AssertModel(models[10],_testData[27], false);
                GuiduniqueidentifierE0M.AssertModel(models[11],_testData[28], false);
                GuiduniqueidentifierE0M.AssertModel(models[12],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[13],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[14],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[15],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[16],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[17],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("09869de5-5b2f-4a3d-a2ac-2c5123596fba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35fa043c-11db-4bfb-b9bb-95b32f1db96b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d8f073bb-b643-482b-b50d-69671743b7b3"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("295cb907-e1cd-461f-9d91-78b2056925ba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67fa6878-cb07-44c5-a9b0-500cd13bcb07"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e74eadb0-4417-4bc2-8059-60ab2552efa4"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a295c571-187b-4000-aadb-cf610558386f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("612e3942-b89d-4257-8f21-234074c23b46"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5cbfbbe4-0806-4c83-b3c4-30853da534ea"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d3fe36d9-3ff1-421e-8bcb-ba635cc107f0"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe1c9ede-4098-429a-9fbb-c98af22f52bd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6fa444a7-bbde-47c6-9726-aece011e94b3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("47f77909-6c1c-4661-95ee-d90d8ddbe7eb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("443329e5-ee14-4a26-9fee-17019c4dd919"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d16dfe84-41ef-4249-a801-b1f8ef552f32"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a7e8e0e2-7206-48f3-80e5-1637806e0343"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("676d1e64-bccf-42d6-becb-ccfa8c1d92c5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1dc9cf36-d353-4e38-8c78-c1dcd2f2722d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b8db4e8-4b1b-47e3-b62b-dd2011df36df"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5c8d7de3-7650-46da-a2d6-f89ec5f302c6"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0983ff03-8e0b-4e1a-aa8d-fcda96078ac8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fecb8a19-59f7-4791-acde-11e1440ce8ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("108177cb-418a-45ee-9351-3f49eb18a2f5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ff8e0514-5ce5-40d7-b305-a16273d131e2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e1bdd551-6b24-4bb9-b06c-deab99b9819f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("30a8651d-765a-4020-92cc-48ea8dfb3026"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ce6133dc-c47d-4e98-959d-3c1e4fa1cc24"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9479f8b6-4e84-42c4-8767-c033803a600f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("acb81b97-4ef8-4a1f-a160-8c831720bfbf"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2aa5b8da-43d8-4202-96fe-be4073593645"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("75e78f67-499d-454b-823a-0b438f6d3a84"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("df735bc9-fd30-4f9e-b767-5f38e5e2afb7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5d851b3d-817d-4fda-8d36-8b91bcc48fd4"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e6af6dcb-3fbd-46de-89ba-509b1da7ad0e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0b57fbac-80d5-4b2b-802b-267c401e4608"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a2f4858-24a4-41cf-8d98-ce4d799b9a69"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("83317ac1-bd02-418e-a347-57e047189776"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("905db28b-e7a9-4905-a15d-73b9fc5e8f7e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aa17eced-08d3-46d0-b4bb-c6dad91b6fb8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0f8a7ca8-4bc3-4b92-a95e-e9b1435aed99"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cad3a344-ba34-4394-be15-f94ffcc99c75"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("da3bf90c-82c8-4bbb-b89c-722cef2611bd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("163eacbb-fc86-453d-be20-b0066cacd672"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8f9ddb76-f61b-4d31-a93c-0c4ac4c204e8"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("92e15669-b136-4f54-b23a-41ee7ea4666f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f763e7d1-e823-4d85-b88f-088b8d697b1c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5b0fb6f1-d44a-429a-a4f7-7f4ec99f8f44"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ca750ed0-c8f4-4298-9b85-6d003a610d8e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c26cdfb4-1548-4ad7-bfb0-bbd56fda29af"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("add38620-6b64-4b7c-8074-f4dd8b57b0f8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f5ae36ac-785e-4b0e-9316-840dfc364fbc"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87a415ef-1eb1-4b16-9a23-5f984b34ff28"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("210d05f4-23a2-4152-b358-53fe4d1616bf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6c8d07c7-e73f-4265-9b9f-a112d7a3bd83"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("45b2e274-4b5b-4b91-a072-d84e6554c331"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e30cecdb-d3d8-445e-98e1-72f161317a65"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f1465c7f-605b-40ac-8890-c5174915d325"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9190a47e-0e1f-4e74-9c8a-b2718c6ce647"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fb2e2d82-4bcf-40e6-beb8-4459b4366f5f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("79c9487c-f3aa-42f6-9014-c1d4b32439b6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("49d36fbb-334a-4250-afec-896c1db93152"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3f2b4f12-96f1-4224-9119-ead316fbd86f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0432ae4c-be0a-4435-83a9-5b900a86bf84"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9e1528dc-1d12-4ecb-b9dc-36dc8e0f05b5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ba895c6-b2ec-47f0-b4ee-b1c434a9f472"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bd6b407b-4d59-4fd9-a3e3-63e8384bd3cd"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c4d06948-5cfa-41d2-8ceb-20c57b39e432"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d7d11ba1-65c3-4ac0-a177-68211e138128"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78fac632-d1a2-4806-9902-8e96f77c2638"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00f8d594-42e3-4b2d-99f3-2af18f63d3ac"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("424e4063-7d22-4f79-9c86-65c5d0446a89"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d3e0677e-258d-48cd-addb-d0bf2cdd4720"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("581aa728-3181-47fc-821b-9f4e53668b26"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ba2025d5-7c0e-44dc-ab24-53b4943b9cf5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("03d007c9-f9bf-47ee-9b26-82f5c48afc7f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f2ce4a9d-0fbf-4cbc-aacb-094b4a4e1de8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8cd61a80-0e02-4d13-ad2b-2b28eaa53704"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("741fd802-a7e4-474e-adb5-b6245d0b5908"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("812fefcd-3e6d-4f26-9870-c44a8039d083"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d790d563-7b91-46a2-834e-85d993ae8f3b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("be23cad0-a9d5-4cef-a23b-e743edda084a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e16bbf6-47ff-4970-9296-ebc323b8336d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d5eea2cc-bf8a-455a-ab24-96e2f328bc98"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("09869de5-5b2f-4a3d-a2ac-2c5123596fba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35fa043c-11db-4bfb-b9bb-95b32f1db96b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d8f073bb-b643-482b-b50d-69671743b7b3"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("295cb907-e1cd-461f-9d91-78b2056925ba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67fa6878-cb07-44c5-a9b0-500cd13bcb07"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e74eadb0-4417-4bc2-8059-60ab2552efa4"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a295c571-187b-4000-aadb-cf610558386f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("612e3942-b89d-4257-8f21-234074c23b46"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5cbfbbe4-0806-4c83-b3c4-30853da534ea"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d3fe36d9-3ff1-421e-8bcb-ba635cc107f0"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe1c9ede-4098-429a-9fbb-c98af22f52bd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6fa444a7-bbde-47c6-9726-aece011e94b3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("47f77909-6c1c-4661-95ee-d90d8ddbe7eb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("443329e5-ee14-4a26-9fee-17019c4dd919"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d16dfe84-41ef-4249-a801-b1f8ef552f32"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a7e8e0e2-7206-48f3-80e5-1637806e0343"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("676d1e64-bccf-42d6-becb-ccfa8c1d92c5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1dc9cf36-d353-4e38-8c78-c1dcd2f2722d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b8db4e8-4b1b-47e3-b62b-dd2011df36df"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5c8d7de3-7650-46da-a2d6-f89ec5f302c6"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0983ff03-8e0b-4e1a-aa8d-fcda96078ac8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fecb8a19-59f7-4791-acde-11e1440ce8ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("108177cb-418a-45ee-9351-3f49eb18a2f5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ff8e0514-5ce5-40d7-b305-a16273d131e2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e1bdd551-6b24-4bb9-b06c-deab99b9819f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("30a8651d-765a-4020-92cc-48ea8dfb3026"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ce6133dc-c47d-4e98-959d-3c1e4fa1cc24"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9479f8b6-4e84-42c4-8767-c033803a600f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("acb81b97-4ef8-4a1f-a160-8c831720bfbf"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2aa5b8da-43d8-4202-96fe-be4073593645"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("75e78f67-499d-454b-823a-0b438f6d3a84"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("df735bc9-fd30-4f9e-b767-5f38e5e2afb7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5d851b3d-817d-4fda-8d36-8b91bcc48fd4"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e6af6dcb-3fbd-46de-89ba-509b1da7ad0e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0b57fbac-80d5-4b2b-802b-267c401e4608"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a2f4858-24a4-41cf-8d98-ce4d799b9a69"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("83317ac1-bd02-418e-a347-57e047189776"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("905db28b-e7a9-4905-a15d-73b9fc5e8f7e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aa17eced-08d3-46d0-b4bb-c6dad91b6fb8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0f8a7ca8-4bc3-4b92-a95e-e9b1435aed99"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cad3a344-ba34-4394-be15-f94ffcc99c75"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("da3bf90c-82c8-4bbb-b89c-722cef2611bd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("163eacbb-fc86-453d-be20-b0066cacd672"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8f9ddb76-f61b-4d31-a93c-0c4ac4c204e8"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("92e15669-b136-4f54-b23a-41ee7ea4666f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f763e7d1-e823-4d85-b88f-088b8d697b1c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5b0fb6f1-d44a-429a-a4f7-7f4ec99f8f44"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ca750ed0-c8f4-4298-9b85-6d003a610d8e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c26cdfb4-1548-4ad7-bfb0-bbd56fda29af"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("add38620-6b64-4b7c-8074-f4dd8b57b0f8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f5ae36ac-785e-4b0e-9316-840dfc364fbc"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87a415ef-1eb1-4b16-9a23-5f984b34ff28"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("210d05f4-23a2-4152-b358-53fe4d1616bf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6c8d07c7-e73f-4265-9b9f-a112d7a3bd83"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("45b2e274-4b5b-4b91-a072-d84e6554c331"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e30cecdb-d3d8-445e-98e1-72f161317a65"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f1465c7f-605b-40ac-8890-c5174915d325"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9190a47e-0e1f-4e74-9c8a-b2718c6ce647"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fb2e2d82-4bcf-40e6-beb8-4459b4366f5f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("79c9487c-f3aa-42f6-9014-c1d4b32439b6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("49d36fbb-334a-4250-afec-896c1db93152"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3f2b4f12-96f1-4224-9119-ead316fbd86f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0432ae4c-be0a-4435-83a9-5b900a86bf84"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9e1528dc-1d12-4ecb-b9dc-36dc8e0f05b5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ba895c6-b2ec-47f0-b4ee-b1c434a9f472"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bd6b407b-4d59-4fd9-a3e3-63e8384bd3cd"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c4d06948-5cfa-41d2-8ceb-20c57b39e432"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d7d11ba1-65c3-4ac0-a177-68211e138128"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78fac632-d1a2-4806-9902-8e96f77c2638"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00f8d594-42e3-4b2d-99f3-2af18f63d3ac"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("424e4063-7d22-4f79-9c86-65c5d0446a89"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d3e0677e-258d-48cd-addb-d0bf2cdd4720"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("581aa728-3181-47fc-821b-9f4e53668b26"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ba2025d5-7c0e-44dc-ab24-53b4943b9cf5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("03d007c9-f9bf-47ee-9b26-82f5c48afc7f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f2ce4a9d-0fbf-4cbc-aacb-094b4a4e1de8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8cd61a80-0e02-4d13-ad2b-2b28eaa53704"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("741fd802-a7e4-474e-adb5-b6245d0b5908"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("812fefcd-3e6d-4f26-9870-c44a8039d083"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d790d563-7b91-46a2-834e-85d993ae8f3b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("be23cad0-a9d5-4cef-a23b-e743edda084a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e16bbf6-47ff-4970-9296-ebc323b8336d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d5eea2cc-bf8a-455a-ab24-96e2f328bc98"))));

            }
        }

#endregion

    }
}


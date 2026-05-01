

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
    Value = Guid.Parse("05fdaae6-db02-455e-ac2e-62a606e9b1c2"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 15,
    Value = Guid.Parse("14fd24a4-eaf6-4485-89bb-381c285484a4"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 5,
    Value = Guid.Parse("ad89bcbf-9c85-444d-9c6f-92cbe82fd782"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 21,
    Value = Guid.Parse("1004a5e2-e6a5-461f-9cff-2108a09d4468"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 30,
    Value = Guid.Parse("5c5e7f49-84c4-44e0-bf38-b12d03f373c3"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 12,
    Value = Guid.Parse("ac399411-b097-48ce-8720-b1cdfb1137db"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("4f2bf296-238a-4d74-8aed-53e91e0589d6"),
},
            new Guiduniqueidentifier0M
{
    Id = 37,
    Value = Guid.Parse("f5d8575b-64a0-4ab1-8b46-b14d0c1e0fdf"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 43,
    Value = Guid.Parse("3c4ecd7d-c1b6-4cf7-8001-95f4b1945c6a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 13,
    Value = Guid.Parse("a519a0e4-426e-4c94-bbb1-27d20187ac15"),
    NullableValue = Guid.Parse("f4533b5a-e6e9-4c50-a505-f674ebd4028b"),
},
    NullableValue = Guid.Parse("1a197eaf-8870-4bf6-b63e-d584968a1115"),
},
            new Guiduniqueidentifier0M
{
    Id = 50,
    Value = Guid.Parse("648cc46d-4ee7-4d45-9061-647a60d3c72a"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 53,
    Value = Guid.Parse("29528f30-a73d-423e-a54e-c07b1554a0fa"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 19,
    Value = Guid.Parse("dbf68e16-24bc-443a-b07c-bb9c0f528834"),
    NullableValue = Guid.Parse("c0767735-0f1a-4f68-80c0-58f03f13b248"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 59,
    Value = Guid.Parse("497b23fc-d531-47a9-95d0-32bd247c2f19"),
    ModelInner = null,
    NullableValue = Guid.Parse("931b34f3-8291-4dca-903a-0443860d530f"),
},
            new Guiduniqueidentifier0M
{
    Id = 63,
    Value = Guid.Parse("58c8676a-4ed0-413b-ad8b-e565de55f836"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 28,
    Value = Guid.Parse("2d0ca26e-b1ad-4adc-a507-e70b82cd9ced"),
    NullableValue = Guid.Parse("3b76a6f9-d414-47d8-abc6-ded72ab9b61f"),
},
    NullableValue = Guid.Parse("7a0fc193-dc4a-40ab-996d-7cc7579d10b3"),
},
            new Guiduniqueidentifier0M
{
    Id = 72,
    Value = Guid.Parse("c6af772a-352a-4cfc-8f19-d1083c2ebe55"),
    ModelInner = null,
    NullableValue = Guid.Parse("4d266fa1-b3b5-4c0c-b377-b6a342332b9f"),
},
            new Guiduniqueidentifier0M
{
    Id = 80,
    Value = Guid.Parse("7916a99b-4e5e-47a5-915d-a192d1357505"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 37,
    Value = Guid.Parse("c18e1241-cc79-4965-a2fc-afe459d1fe91"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 88,
    Value = Guid.Parse("35b5bbd1-d4f6-4b31-8593-cb9ef4deb2f1"),
    ModelInner = null,
    NullableValue = Guid.Parse("76e6c90d-3f8d-4e37-9cb0-ce2855a86884"),
},
            new Guiduniqueidentifier0M
{
    Id = 94,
    Value = Guid.Parse("1d7d034f-32e3-4d83-bd01-2f5a64dcf66c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 40,
    Value = Guid.Parse("366d4635-d0d1-4b8a-b02a-14442b35ff2f"),
    NullableValue = Guid.Parse("6dde31d8-a734-473b-8b42-be91079d5d35"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 100,
    Value = Guid.Parse("880c1c71-33bc-494d-b301-c3e054624ec3"),
    ModelInner = null,
    NullableValue = Guid.Parse("090cb8dc-09a6-49ab-9bef-f0c409df974e"),
},
            new Guiduniqueidentifier0M
{
    Id = 103,
    Value = Guid.Parse("094cbf46-4e7b-4043-9119-9ecce25fe759"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 46,
    Value = Guid.Parse("27161bc8-bb3d-4842-860f-ec2ea58a401d"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("161b200c-5dd4-46af-8b2f-3acecef31bff"),
},
            new Guiduniqueidentifier0M
{
    Id = 110,
    Value = Guid.Parse("c9a0213c-0926-4c31-994b-40521a3d6e76"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 116,
    Value = Guid.Parse("72659bd1-ecd4-4454-91b0-2dc0ec82e511"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 54,
    Value = Guid.Parse("23631b4e-8628-4764-b523-6176f1661162"),
    NullableValue = Guid.Parse("5bf1b785-2e81-48f3-8cd9-b326bda51d5e"),
},
    NullableValue = Guid.Parse("4c050957-a243-4ac1-98f3-1dc5ebca8b1c"),
},
            new Guiduniqueidentifier0M
{
    Id = 118,
    Value = Guid.Parse("35241f3a-41ca-4415-baea-1dd836e2f3f5"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 120,
    Value = Guid.Parse("84d395d8-6780-4d8c-95bf-715cf78ab0ba"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 58,
    Value = Guid.Parse("e714ea82-4783-4a86-8b24-d3dee0cbd591"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("1b5d632a-53da-4242-a5c3-70a89b26056f"),
},
            new Guiduniqueidentifier0M
{
    Id = 125,
    Value = Guid.Parse("03934887-81ea-41cd-875e-a29a3d290480"),
    ModelInner = null,
    NullableValue = Guid.Parse("a5b2321c-e93f-4bd2-a7ef-cf34a16ff0d3"),
},
            new Guiduniqueidentifier0M
{
    Id = 129,
    Value = Guid.Parse("35d6044d-7993-45f3-87c8-7d597df432c4"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 60,
    Value = Guid.Parse("b9480c11-60c5-4f4b-85ed-d46929f884d8"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("6e538115-9dad-4949-bc87-17d06a9b1043"),
},
            new Guiduniqueidentifier0M
{
    Id = 135,
    Value = Guid.Parse("6235030f-0d33-402c-815f-0e7a17a0af10"),
    ModelInner = null,
    NullableValue = Guid.Parse("66bc3094-6466-4df0-ae62-1a4acc1a6062"),
},
            new Guiduniqueidentifier0M
{
    Id = 144,
    Value = Guid.Parse("b752eb08-a619-4219-994b-9d0d55f00a15"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 69,
    Value = Guid.Parse("87d89163-85a6-411e-8995-e969902eafca"),
    NullableValue = Guid.Parse("c17e3407-eaf9-410b-bd36-1fe4ee4e9328"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 148,
    Value = Guid.Parse("77804d81-32d6-452b-ab71-e44145962176"),
    ModelInner = null,
    NullableValue = Guid.Parse("12e29649-58d9-427f-9436-37074fd142a0"),
},
            new Guiduniqueidentifier0M
{
    Id = 150,
    Value = Guid.Parse("b74d12a2-9601-46d8-ae8c-c7a7ec3023a8"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 76,
    Value = Guid.Parse("b7a2ee7b-575b-42ac-b1c2-dc74875c4588"),
    NullableValue = Guid.Parse("e57d1866-a57a-40a4-9d4c-34ef83c2b249"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 158,
    Value = Guid.Parse("3aa83e6e-7235-48fb-ae2c-2adb59049070"),
    ModelInner = null,
    NullableValue = Guid.Parse("8f9533f6-6150-4f96-992c-f93996e9b342"),
},
            new Guiduniqueidentifier0M
{
    Id = 164,
    Value = Guid.Parse("e157104d-bda4-4c28-bd42-d7b57a7d3b46"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 81,
    Value = Guid.Parse("52450ebe-1385-4f1a-8daa-f688a8b98ad6"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 170,
    Value = Guid.Parse("9a580ee1-1c62-42dd-be45-991d9dff0089"),
    ModelInner = null,
    NullableValue = Guid.Parse("db07831e-df2d-44f3-8ade-b070ef947a73"),
},
            new Guiduniqueidentifier0M
{
    Id = 177,
    Value = Guid.Parse("1b36706b-45cb-4518-86ab-070025080663"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 86,
    Value = Guid.Parse("0b6cfbd4-44fd-47fc-954e-32f4ede049c1"),
    NullableValue = Guid.Parse("8129f81d-d3b8-481d-aba2-cfc28c8bea9e"),
},
    NullableValue = Guid.Parse("76208a53-00a2-4312-9a74-c03d9979c045"),
},
            new Guiduniqueidentifier0M
{
    Id = 183,
    Value = Guid.Parse("d095986a-da35-456b-b629-9c9b65115ee6"),
    ModelInner = null,
    NullableValue = Guid.Parse("2f3e6ac3-2d6c-4348-857d-c8eb295d0642"),
},
            new Guiduniqueidentifier0M
{
    Id = 191,
    Value = Guid.Parse("23cc081a-e82c-41c4-9a55-826194c64283"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 91,
    Value = Guid.Parse("8f3c7ce1-85bf-40e1-81cb-e43346222769"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 196,
    Value = Guid.Parse("25c5ab39-3aa3-43f4-a1f9-36a3c4475c04"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 198,
    Value = Guid.Parse("c445252a-8b1d-488d-a642-6f4f1bcb84a4"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 97,
    Value = Guid.Parse("e999f085-6a6c-4db6-83dd-3766ac465c2f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("944feacf-8d6c-462c-828b-bfe52f6e137a"),
},
            new Guiduniqueidentifier0M
{
    Id = 206,
    Value = Guid.Parse("1546ac7d-6cab-4c25-8eb1-cc4b8f37a1d0"),
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
                parametr1.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 21;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[28],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 158, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 72, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[30],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 196, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 125, query1, 164, query2))
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 158, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 59, query1, 100, query2))
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 30, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 177, 118))
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 110, 7))
                {
                    if(++resultIndex == 1)
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[30], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[31], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[32], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[33], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 183);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[31], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[32], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[33], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("05fdaae6-db02-455e-ac2e-62a606e9b1c2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14fd24a4-eaf6-4485-89bb-381c285484a4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ad89bcbf-9c85-444d-9c6f-92cbe82fd782"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1004a5e2-e6a5-461f-9cff-2108a09d4468"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5c5e7f49-84c4-44e0-bf38-b12d03f373c3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ac399411-b097-48ce-8720-b1cdfb1137db"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4f2bf296-238a-4d74-8aed-53e91e0589d6"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f5d8575b-64a0-4ab1-8b46-b14d0c1e0fdf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c4ecd7d-c1b6-4cf7-8001-95f4b1945c6a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a519a0e4-426e-4c94-bbb1-27d20187ac15"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f4533b5a-e6e9-4c50-a505-f674ebd4028b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1a197eaf-8870-4bf6-b63e-d584968a1115"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("648cc46d-4ee7-4d45-9061-647a60d3c72a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("29528f30-a73d-423e-a54e-c07b1554a0fa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dbf68e16-24bc-443a-b07c-bb9c0f528834"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c0767735-0f1a-4f68-80c0-58f03f13b248"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("497b23fc-d531-47a9-95d0-32bd247c2f19"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("931b34f3-8291-4dca-903a-0443860d530f"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("58c8676a-4ed0-413b-ad8b-e565de55f836"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2d0ca26e-b1ad-4adc-a507-e70b82cd9ced"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3b76a6f9-d414-47d8-abc6-ded72ab9b61f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7a0fc193-dc4a-40ab-996d-7cc7579d10b3"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c6af772a-352a-4cfc-8f19-d1083c2ebe55"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4d266fa1-b3b5-4c0c-b377-b6a342332b9f"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7916a99b-4e5e-47a5-915d-a192d1357505"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c18e1241-cc79-4965-a2fc-afe459d1fe91"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35b5bbd1-d4f6-4b31-8593-cb9ef4deb2f1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("76e6c90d-3f8d-4e37-9cb0-ce2855a86884"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d7d034f-32e3-4d83-bd01-2f5a64dcf66c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("366d4635-d0d1-4b8a-b02a-14442b35ff2f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6dde31d8-a734-473b-8b42-be91079d5d35"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("880c1c71-33bc-494d-b301-c3e054624ec3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("090cb8dc-09a6-49ab-9bef-f0c409df974e"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("094cbf46-4e7b-4043-9119-9ecce25fe759"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("27161bc8-bb3d-4842-860f-ec2ea58a401d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("161b200c-5dd4-46af-8b2f-3acecef31bff"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9a0213c-0926-4c31-994b-40521a3d6e76"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72659bd1-ecd4-4454-91b0-2dc0ec82e511"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("23631b4e-8628-4764-b523-6176f1661162"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5bf1b785-2e81-48f3-8cd9-b326bda51d5e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c050957-a243-4ac1-98f3-1dc5ebca8b1c"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35241f3a-41ca-4415-baea-1dd836e2f3f5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("84d395d8-6780-4d8c-95bf-715cf78ab0ba"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e714ea82-4783-4a86-8b24-d3dee0cbd591"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1b5d632a-53da-4242-a5c3-70a89b26056f"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03934887-81ea-41cd-875e-a29a3d290480"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a5b2321c-e93f-4bd2-a7ef-cf34a16ff0d3"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35d6044d-7993-45f3-87c8-7d597df432c4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b9480c11-60c5-4f4b-85ed-d46929f884d8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6e538115-9dad-4949-bc87-17d06a9b1043"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6235030f-0d33-402c-815f-0e7a17a0af10"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("66bc3094-6466-4df0-ae62-1a4acc1a6062"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b752eb08-a619-4219-994b-9d0d55f00a15"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("87d89163-85a6-411e-8995-e969902eafca"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c17e3407-eaf9-410b-bd36-1fe4ee4e9328"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77804d81-32d6-452b-ab71-e44145962176"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("12e29649-58d9-427f-9436-37074fd142a0"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b74d12a2-9601-46d8-ae8c-c7a7ec3023a8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b7a2ee7b-575b-42ac-b1c2-dc74875c4588"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e57d1866-a57a-40a4-9d4c-34ef83c2b249"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3aa83e6e-7235-48fb-ae2c-2adb59049070"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8f9533f6-6150-4f96-992c-f93996e9b342"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e157104d-bda4-4c28-bd42-d7b57a7d3b46"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("52450ebe-1385-4f1a-8daa-f688a8b98ad6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9a580ee1-1c62-42dd-be45-991d9dff0089"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("db07831e-df2d-44f3-8ade-b070ef947a73"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1b36706b-45cb-4518-86ab-070025080663"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0b6cfbd4-44fd-47fc-954e-32f4ede049c1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("8129f81d-d3b8-481d-aba2-cfc28c8bea9e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("76208a53-00a2-4312-9a74-c03d9979c045"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d095986a-da35-456b-b629-9c9b65115ee6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2f3e6ac3-2d6c-4348-857d-c8eb295d0642"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("23cc081a-e82c-41c4-9a55-826194c64283"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8f3c7ce1-85bf-40e1-81cb-e43346222769"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("25c5ab39-3aa3-43f4-a1f9-36a3c4475c04"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c445252a-8b1d-488d-a642-6f4f1bcb84a4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e999f085-6a6c-4db6-83dd-3766ac465c2f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("944feacf-8d6c-462c-828b-bfe52f6e137a"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((206)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1546ac7d-6cab-4c25-8eb1-cc4b8f37a1d0"))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("05fdaae6-db02-455e-ac2e-62a606e9b1c2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14fd24a4-eaf6-4485-89bb-381c285484a4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ad89bcbf-9c85-444d-9c6f-92cbe82fd782"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1004a5e2-e6a5-461f-9cff-2108a09d4468"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5c5e7f49-84c4-44e0-bf38-b12d03f373c3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ac399411-b097-48ce-8720-b1cdfb1137db"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4f2bf296-238a-4d74-8aed-53e91e0589d6"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f5d8575b-64a0-4ab1-8b46-b14d0c1e0fdf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3c4ecd7d-c1b6-4cf7-8001-95f4b1945c6a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a519a0e4-426e-4c94-bbb1-27d20187ac15"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f4533b5a-e6e9-4c50-a505-f674ebd4028b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1a197eaf-8870-4bf6-b63e-d584968a1115"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("648cc46d-4ee7-4d45-9061-647a60d3c72a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("29528f30-a73d-423e-a54e-c07b1554a0fa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dbf68e16-24bc-443a-b07c-bb9c0f528834"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c0767735-0f1a-4f68-80c0-58f03f13b248"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("497b23fc-d531-47a9-95d0-32bd247c2f19"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("931b34f3-8291-4dca-903a-0443860d530f"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("58c8676a-4ed0-413b-ad8b-e565de55f836"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2d0ca26e-b1ad-4adc-a507-e70b82cd9ced"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3b76a6f9-d414-47d8-abc6-ded72ab9b61f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7a0fc193-dc4a-40ab-996d-7cc7579d10b3"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c6af772a-352a-4cfc-8f19-d1083c2ebe55"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4d266fa1-b3b5-4c0c-b377-b6a342332b9f"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7916a99b-4e5e-47a5-915d-a192d1357505"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c18e1241-cc79-4965-a2fc-afe459d1fe91"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35b5bbd1-d4f6-4b31-8593-cb9ef4deb2f1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("76e6c90d-3f8d-4e37-9cb0-ce2855a86884"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d7d034f-32e3-4d83-bd01-2f5a64dcf66c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("366d4635-d0d1-4b8a-b02a-14442b35ff2f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6dde31d8-a734-473b-8b42-be91079d5d35"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("880c1c71-33bc-494d-b301-c3e054624ec3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("090cb8dc-09a6-49ab-9bef-f0c409df974e"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("094cbf46-4e7b-4043-9119-9ecce25fe759"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("27161bc8-bb3d-4842-860f-ec2ea58a401d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("161b200c-5dd4-46af-8b2f-3acecef31bff"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9a0213c-0926-4c31-994b-40521a3d6e76"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72659bd1-ecd4-4454-91b0-2dc0ec82e511"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("23631b4e-8628-4764-b523-6176f1661162"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5bf1b785-2e81-48f3-8cd9-b326bda51d5e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c050957-a243-4ac1-98f3-1dc5ebca8b1c"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35241f3a-41ca-4415-baea-1dd836e2f3f5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("84d395d8-6780-4d8c-95bf-715cf78ab0ba"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e714ea82-4783-4a86-8b24-d3dee0cbd591"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1b5d632a-53da-4242-a5c3-70a89b26056f"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03934887-81ea-41cd-875e-a29a3d290480"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a5b2321c-e93f-4bd2-a7ef-cf34a16ff0d3"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("35d6044d-7993-45f3-87c8-7d597df432c4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b9480c11-60c5-4f4b-85ed-d46929f884d8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6e538115-9dad-4949-bc87-17d06a9b1043"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6235030f-0d33-402c-815f-0e7a17a0af10"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("66bc3094-6466-4df0-ae62-1a4acc1a6062"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b752eb08-a619-4219-994b-9d0d55f00a15"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("87d89163-85a6-411e-8995-e969902eafca"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c17e3407-eaf9-410b-bd36-1fe4ee4e9328"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77804d81-32d6-452b-ab71-e44145962176"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("12e29649-58d9-427f-9436-37074fd142a0"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b74d12a2-9601-46d8-ae8c-c7a7ec3023a8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b7a2ee7b-575b-42ac-b1c2-dc74875c4588"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e57d1866-a57a-40a4-9d4c-34ef83c2b249"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3aa83e6e-7235-48fb-ae2c-2adb59049070"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8f9533f6-6150-4f96-992c-f93996e9b342"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e157104d-bda4-4c28-bd42-d7b57a7d3b46"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("52450ebe-1385-4f1a-8daa-f688a8b98ad6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9a580ee1-1c62-42dd-be45-991d9dff0089"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("db07831e-df2d-44f3-8ade-b070ef947a73"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1b36706b-45cb-4518-86ab-070025080663"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0b6cfbd4-44fd-47fc-954e-32f4ede049c1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("8129f81d-d3b8-481d-aba2-cfc28c8bea9e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("76208a53-00a2-4312-9a74-c03d9979c045"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d095986a-da35-456b-b629-9c9b65115ee6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2f3e6ac3-2d6c-4348-857d-c8eb295d0642"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("23cc081a-e82c-41c4-9a55-826194c64283"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8f3c7ce1-85bf-40e1-81cb-e43346222769"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("25c5ab39-3aa3-43f4-a1f9-36a3c4475c04"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c445252a-8b1d-488d-a642-6f4f1bcb84a4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e999f085-6a6c-4db6-83dd-3766ac465c2f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("944feacf-8d6c-462c-828b-bfe52f6e137a"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((206)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1546ac7d-6cab-4c25-8eb1-cc4b8f37a1d0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


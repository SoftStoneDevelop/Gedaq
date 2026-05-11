

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
    Id = 8,
    Value = Guid.Parse("25663787-3783-4eac-85a0-8b6d466e2d0d"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 16,
    Value = Guid.Parse("abdb31e4-e451-4f8a-b77c-d3d0cdfa6deb"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 3,
    Value = Guid.Parse("101e75a4-cd6c-4762-a9a1-b356972e37bd"),
    NullableValue = Guid.Parse("65e2b614-4aa1-43bb-b271-5e24863ad690"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 25,
    Value = Guid.Parse("f9363e11-1c0e-4cfc-aba8-340e7ac40314"),
    ModelInner = null,
    NullableValue = Guid.Parse("5a382f31-70c7-4370-8f07-071289568be6"),
},
            new GuiduniqueidentifierE0M
{
    Id = 33,
    Value = Guid.Parse("0ef02ecd-1869-43c5-a2bd-23b309a5d2cd"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 11,
    Value = Guid.Parse("f0152f7d-6510-4757-94f6-e37f794a9de0"),
    NullableValue = Guid.Parse("621d9a84-7ea5-4ec3-9254-33785e0962b1"),
},
    NullableValue = Guid.Parse("4e676ad7-3343-4fb6-b4f2-db9d68b610c7"),
},
            new GuiduniqueidentifierE0M
{
    Id = 37,
    Value = Guid.Parse("375289e7-dd4f-4832-86ff-5aa8cc7875ce"),
    ModelInner = null,
    NullableValue = Guid.Parse("cf69ecd0-516e-4750-88a8-31a51381495e"),
},
            new GuiduniqueidentifierE0M
{
    Id = 41,
    Value = Guid.Parse("80ca7f8b-f7c3-4eea-b891-a473ca8b29cd"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 18,
    Value = Guid.Parse("d2e96fce-757a-4920-b841-d74bdbb42e8f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 42,
    Value = Guid.Parse("a5b219e5-3785-46c2-b2ae-b47c509aa4a8"),
    ModelInner = null,
    NullableValue = Guid.Parse("d1f720df-f6d0-4649-9f61-74bb784f7375"),
},
            new GuiduniqueidentifierE0M
{
    Id = 44,
    Value = Guid.Parse("40d10411-95c3-47a8-a7a6-a5ee83ef6f0b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 24,
    Value = Guid.Parse("084b1f46-4d3c-4418-9856-fed9921ed7f1"),
    NullableValue = Guid.Parse("d35e4527-a64c-436c-aee4-a8d4dc2ab94a"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 48,
    Value = Guid.Parse("8a0cfb86-992a-409a-b74f-aeb3d4ffe7de"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 52,
    Value = Guid.Parse("692288d5-9aea-4719-b14d-06c61eb2bc27"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 30,
    Value = Guid.Parse("c54428c3-f106-401f-a048-4bd4b897d33c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2ffa17a0-e30e-41a0-b1c6-2abc2a8c8ad2"),
},
            new GuiduniqueidentifierE0M
{
    Id = 60,
    Value = Guid.Parse("01c986bb-be9f-468a-a562-b19720958f30"),
    ModelInner = null,
    NullableValue = Guid.Parse("48f6e61a-2709-4f29-997c-504426c1cdeb"),
},
            new GuiduniqueidentifierE0M
{
    Id = 66,
    Value = Guid.Parse("cec13cc1-37d3-4d2d-a5b2-a242d859968b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 39,
    Value = Guid.Parse("8b0db3d9-6c64-4a39-94f1-900f725c80be"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 75,
    Value = Guid.Parse("900e6a06-59f5-4005-a0a2-e876136efd7f"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 81,
    Value = Guid.Parse("4427374f-61c1-4c55-969a-039a4ef74ef8"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 40,
    Value = Guid.Parse("222aab4f-e416-49c9-96c8-8dcb6d480a93"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("4464671a-fff3-4b1f-b4c7-07e85776332a"),
},
            new GuiduniqueidentifierE0M
{
    Id = 86,
    Value = Guid.Parse("cea1f925-1e47-49fd-b975-8e81e36882e3"),
    ModelInner = null,
    NullableValue = Guid.Parse("34782b18-c0dc-4306-b5e3-221977c21290"),
},
            new GuiduniqueidentifierE0M
{
    Id = 87,
    Value = Guid.Parse("878bd26f-ac49-4a36-9a8b-4af0212b044d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 48,
    Value = Guid.Parse("71ab26c2-181c-4307-8a83-d0538806636f"),
    NullableValue = Guid.Parse("2ffc82e6-b4c8-486c-aa22-d805a1d5e328"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 88,
    Value = Guid.Parse("adcddfff-8bf7-4477-b541-604f58c66160"),
    ModelInner = null,
    NullableValue = Guid.Parse("88465b46-176e-41d1-92c2-add464f7545f"),
},
            new GuiduniqueidentifierE0M
{
    Id = 92,
    Value = Guid.Parse("a0734daa-7ea2-46cb-9720-d21bb2e712b5"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 57,
    Value = Guid.Parse("65b31094-3d1f-4c7d-ba05-e9c53da9807b"),
    NullableValue = Guid.Parse("792b8992-b696-4d6c-b996-5b0ebcd1ce89"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 95,
    Value = Guid.Parse("093006b0-bd8b-4b20-9ae3-a7e526ca25ff"),
    ModelInner = null,
    NullableValue = Guid.Parse("f7ff3112-e622-4330-8356-42fd76394e6e"),
},
            new GuiduniqueidentifierE0M
{
    Id = 101,
    Value = Guid.Parse("f85235e0-588a-4630-b1e2-ede9958f92fb"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 58,
    Value = Guid.Parse("035ee4cf-6299-4b59-aeb1-ce6139bc8e98"),
    NullableValue = Guid.Parse("05b66c67-953c-418c-8b8a-6ad269e1b53e"),
},
    NullableValue = Guid.Parse("f8665ce2-3ba3-41ae-a895-7f8c498618d0"),
},
            new GuiduniqueidentifierE0M
{
    Id = 110,
    Value = Guid.Parse("c60df997-fa7e-46f1-8e7d-a56d81086304"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 118,
    Value = Guid.Parse("2bcf9734-f315-4220-80dd-5d467ebc206c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 64,
    Value = Guid.Parse("5dc39f04-f19d-44bd-99eb-c4a633002334"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 126,
    Value = Guid.Parse("fb6f348a-3c30-422b-ad44-384312e84ddc"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 133,
    Value = Guid.Parse("4f7b451c-3ec7-4620-8f4a-1078adba02fe"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 65,
    Value = Guid.Parse("1a8e2e3d-a303-4a8c-ad63-a121ca40a561"),
    NullableValue = Guid.Parse("4559c6e0-faeb-419b-80ef-4f6e1153abce"),
},
    NullableValue = Guid.Parse("cc4826f6-55cb-471e-97dd-63ac7b7279f0"),
},
            new GuiduniqueidentifierE0M
{
    Id = 135,
    Value = Guid.Parse("51c64da8-c37d-4bd5-a265-47e28f2e4cb7"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 138,
    Value = Guid.Parse("ff798a59-1a80-467c-abc5-40c3305f4792"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 74,
    Value = Guid.Parse("1ac91fbe-cbed-4815-b5be-9dd2c5d5eeb6"),
    NullableValue = Guid.Parse("60b96589-9554-4ee0-91b1-877e1e60d8cd"),
},
    NullableValue = Guid.Parse("ffca1d5c-2057-4acd-95ad-47dd3784eb4c"),
},
            new GuiduniqueidentifierE0M
{
    Id = 139,
    Value = Guid.Parse("4fb7c547-195c-40b3-b898-f5bf6d7d5172"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 140,
    Value = Guid.Parse("d38ac1ea-5e28-4852-80d6-4f26fbfd10ce"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 75,
    Value = Guid.Parse("2586302c-054b-4000-b97e-30cf6b4b0de8"),
    NullableValue = Guid.Parse("86ba7a3f-376f-410f-a624-b00e7f578a3a"),
},
    NullableValue = Guid.Parse("84a7f27f-5bee-4325-9d27-c69978ee7a2b"),
},
            new GuiduniqueidentifierE0M
{
    Id = 146,
    Value = Guid.Parse("2019fd17-6151-45a8-a5ea-53879a144ba6"),
    ModelInner = null,
    NullableValue = Guid.Parse("0def94b1-7e90-4422-9cf3-b0a008d91e01"),
},
            new GuiduniqueidentifierE0M
{
    Id = 148,
    Value = Guid.Parse("e2412fe8-bd5c-442d-b3d9-801fe924965c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 76,
    Value = Guid.Parse("51e6aaad-7810-439f-9a15-a17a0ba03be6"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("be37927c-a3be-4461-9230-c94480b93f69"),
},
            new GuiduniqueidentifierE0M
{
    Id = 153,
    Value = Guid.Parse("a82ee95e-3b39-45b1-b0ff-abc3dea5ca32"),
    ModelInner = null,
    NullableValue = Guid.Parse("3e89354e-c977-4cc8-9e2b-152d666b49c4"),
},
            new GuiduniqueidentifierE0M
{
    Id = 154,
    Value = Guid.Parse("4bf9d47e-6f50-40d7-847c-ac03a4cd5ac7"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 84,
    Value = Guid.Parse("aa2d71fd-45a5-48ba-93b0-672d9b4c8d3d"),
    NullableValue = Guid.Parse("5763743f-2805-47fd-9170-ee99b0b03ab3"),
},
    NullableValue = Guid.Parse("fd5555f3-123b-4fea-b642-9fd37f94bb77"),
},
            new GuiduniqueidentifierE0M
{
    Id = 162,
    Value = Guid.Parse("2c405da7-e2db-4cd8-8752-b444f5928834"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 165,
    Value = Guid.Parse("84bb2831-95e6-41a1-9237-020ab435ff79"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 85,
    Value = Guid.Parse("e92ab5f5-41d5-4922-bef6-e7c7e36263e6"),
    NullableValue = Guid.Parse("ebd0de0a-1318-49a8-8ffb-f6aaf272a3f9"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 169,
    Value = Guid.Parse("a031f888-a95f-43fe-a270-05452f615bda"),
    ModelInner = null,
    NullableValue = Guid.Parse("3a9a95ae-aa94-4b89-ad9c-eddfe6643e62"),
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
INSERT INTO dbo.guiduniqueidentifiere0m(
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
INSERT INTO dbo.guiduniqueidentifiere0m(
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
                parametr2.Value = 126;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 8;
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[34], false);
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 133, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 154, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 87, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 87, query2))
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 153, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[33],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 81, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[34], false);
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 75, 81))
                {
                    if(++resultIndex == 1)
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 146, 139))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[8], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[9], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[10], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[11], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[12], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[13], false);
                GuiduniqueidentifierE0M.AssertModel(models[6],_testData[14], false);
                GuiduniqueidentifierE0M.AssertModel(models[7],_testData[15], false);
                GuiduniqueidentifierE0M.AssertModel(models[8],_testData[16], false);
                GuiduniqueidentifierE0M.AssertModel(models[9],_testData[17], false);
                GuiduniqueidentifierE0M.AssertModel(models[10],_testData[18], false);
                GuiduniqueidentifierE0M.AssertModel(models[11],_testData[19], false);
                GuiduniqueidentifierE0M.AssertModel(models[12],_testData[20], false);
                GuiduniqueidentifierE0M.AssertModel(models[13],_testData[21], false);
                GuiduniqueidentifierE0M.AssertModel(models[14],_testData[22], false);
                GuiduniqueidentifierE0M.AssertModel(models[15],_testData[23], false);
                GuiduniqueidentifierE0M.AssertModel(models[16],_testData[24], false);
                GuiduniqueidentifierE0M.AssertModel(models[17],_testData[25], false);
                GuiduniqueidentifierE0M.AssertModel(models[18],_testData[26], false);
                GuiduniqueidentifierE0M.AssertModel(models[19],_testData[27], false);
                GuiduniqueidentifierE0M.AssertModel(models[20],_testData[28], false);
                GuiduniqueidentifierE0M.AssertModel(models[21],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[22],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[23],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[24],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[25],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 88);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("25663787-3783-4eac-85a0-8b6d466e2d0d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("abdb31e4-e451-4f8a-b77c-d3d0cdfa6deb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("101e75a4-cd6c-4762-a9a1-b356972e37bd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("65e2b614-4aa1-43bb-b271-5e24863ad690"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f9363e11-1c0e-4cfc-aba8-340e7ac40314"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5a382f31-70c7-4370-8f07-071289568be6"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0ef02ecd-1869-43c5-a2bd-23b309a5d2cd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f0152f7d-6510-4757-94f6-e37f794a9de0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("621d9a84-7ea5-4ec3-9254-33785e0962b1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4e676ad7-3343-4fb6-b4f2-db9d68b610c7"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("375289e7-dd4f-4832-86ff-5aa8cc7875ce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cf69ecd0-516e-4750-88a8-31a51381495e"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80ca7f8b-f7c3-4eea-b891-a473ca8b29cd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d2e96fce-757a-4920-b841-d74bdbb42e8f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a5b219e5-3785-46c2-b2ae-b47c509aa4a8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d1f720df-f6d0-4649-9f61-74bb784f7375"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40d10411-95c3-47a8-a7a6-a5ee83ef6f0b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("084b1f46-4d3c-4418-9856-fed9921ed7f1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d35e4527-a64c-436c-aee4-a8d4dc2ab94a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a0cfb86-992a-409a-b74f-aeb3d4ffe7de"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("692288d5-9aea-4719-b14d-06c61eb2bc27"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c54428c3-f106-401f-a048-4bd4b897d33c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2ffa17a0-e30e-41a0-b1c6-2abc2a8c8ad2"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01c986bb-be9f-468a-a562-b19720958f30"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("48f6e61a-2709-4f29-997c-504426c1cdeb"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cec13cc1-37d3-4d2d-a5b2-a242d859968b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8b0db3d9-6c64-4a39-94f1-900f725c80be"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("900e6a06-59f5-4005-a0a2-e876136efd7f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4427374f-61c1-4c55-969a-039a4ef74ef8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("222aab4f-e416-49c9-96c8-8dcb6d480a93"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4464671a-fff3-4b1f-b4c7-07e85776332a"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cea1f925-1e47-49fd-b975-8e81e36882e3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("34782b18-c0dc-4306-b5e3-221977c21290"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("878bd26f-ac49-4a36-9a8b-4af0212b044d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("71ab26c2-181c-4307-8a83-d0538806636f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2ffc82e6-b4c8-486c-aa22-d805a1d5e328"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("adcddfff-8bf7-4477-b541-604f58c66160"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("88465b46-176e-41d1-92c2-add464f7545f"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a0734daa-7ea2-46cb-9720-d21bb2e712b5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("65b31094-3d1f-4c7d-ba05-e9c53da9807b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("792b8992-b696-4d6c-b996-5b0ebcd1ce89"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("093006b0-bd8b-4b20-9ae3-a7e526ca25ff"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f7ff3112-e622-4330-8356-42fd76394e6e"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f85235e0-588a-4630-b1e2-ede9958f92fb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("035ee4cf-6299-4b59-aeb1-ce6139bc8e98"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("05b66c67-953c-418c-8b8a-6ad269e1b53e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f8665ce2-3ba3-41ae-a895-7f8c498618d0"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c60df997-fa7e-46f1-8e7d-a56d81086304"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2bcf9734-f315-4220-80dd-5d467ebc206c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5dc39f04-f19d-44bd-99eb-c4a633002334"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb6f348a-3c30-422b-ad44-384312e84ddc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f7b451c-3ec7-4620-8f4a-1078adba02fe"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1a8e2e3d-a303-4a8c-ad63-a121ca40a561"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4559c6e0-faeb-419b-80ef-4f6e1153abce"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cc4826f6-55cb-471e-97dd-63ac7b7279f0"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("51c64da8-c37d-4bd5-a265-47e28f2e4cb7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ff798a59-1a80-467c-abc5-40c3305f4792"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1ac91fbe-cbed-4815-b5be-9dd2c5d5eeb6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("60b96589-9554-4ee0-91b1-877e1e60d8cd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ffca1d5c-2057-4acd-95ad-47dd3784eb4c"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4fb7c547-195c-40b3-b898-f5bf6d7d5172"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d38ac1ea-5e28-4852-80d6-4f26fbfd10ce"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2586302c-054b-4000-b97e-30cf6b4b0de8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("86ba7a3f-376f-410f-a624-b00e7f578a3a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("84a7f27f-5bee-4325-9d27-c69978ee7a2b"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2019fd17-6151-45a8-a5ea-53879a144ba6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0def94b1-7e90-4422-9cf3-b0a008d91e01"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e2412fe8-bd5c-442d-b3d9-801fe924965c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("51e6aaad-7810-439f-9a15-a17a0ba03be6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("be37927c-a3be-4461-9230-c94480b93f69"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a82ee95e-3b39-45b1-b0ff-abc3dea5ca32"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3e89354e-c977-4cc8-9e2b-152d666b49c4"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4bf9d47e-6f50-40d7-847c-ac03a4cd5ac7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("aa2d71fd-45a5-48ba-93b0-672d9b4c8d3d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5763743f-2805-47fd-9170-ee99b0b03ab3"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fd5555f3-123b-4fea-b642-9fd37f94bb77"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2c405da7-e2db-4cd8-8752-b444f5928834"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("84bb2831-95e6-41a1-9237-020ab435ff79"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e92ab5f5-41d5-4922-bef6-e7c7e36263e6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ebd0de0a-1318-49a8-8ffb-f6aaf272a3f9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a031f888-a95f-43fe-a270-05452f615bda"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3a9a95ae-aa94-4b89-ad9c-eddfe6643e62"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("25663787-3783-4eac-85a0-8b6d466e2d0d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("abdb31e4-e451-4f8a-b77c-d3d0cdfa6deb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("101e75a4-cd6c-4762-a9a1-b356972e37bd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("65e2b614-4aa1-43bb-b271-5e24863ad690"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f9363e11-1c0e-4cfc-aba8-340e7ac40314"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5a382f31-70c7-4370-8f07-071289568be6"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0ef02ecd-1869-43c5-a2bd-23b309a5d2cd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f0152f7d-6510-4757-94f6-e37f794a9de0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("621d9a84-7ea5-4ec3-9254-33785e0962b1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4e676ad7-3343-4fb6-b4f2-db9d68b610c7"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("375289e7-dd4f-4832-86ff-5aa8cc7875ce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cf69ecd0-516e-4750-88a8-31a51381495e"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80ca7f8b-f7c3-4eea-b891-a473ca8b29cd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d2e96fce-757a-4920-b841-d74bdbb42e8f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a5b219e5-3785-46c2-b2ae-b47c509aa4a8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d1f720df-f6d0-4649-9f61-74bb784f7375"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40d10411-95c3-47a8-a7a6-a5ee83ef6f0b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("084b1f46-4d3c-4418-9856-fed9921ed7f1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d35e4527-a64c-436c-aee4-a8d4dc2ab94a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a0cfb86-992a-409a-b74f-aeb3d4ffe7de"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("692288d5-9aea-4719-b14d-06c61eb2bc27"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c54428c3-f106-401f-a048-4bd4b897d33c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2ffa17a0-e30e-41a0-b1c6-2abc2a8c8ad2"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01c986bb-be9f-468a-a562-b19720958f30"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("48f6e61a-2709-4f29-997c-504426c1cdeb"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cec13cc1-37d3-4d2d-a5b2-a242d859968b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8b0db3d9-6c64-4a39-94f1-900f725c80be"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("900e6a06-59f5-4005-a0a2-e876136efd7f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4427374f-61c1-4c55-969a-039a4ef74ef8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("222aab4f-e416-49c9-96c8-8dcb6d480a93"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4464671a-fff3-4b1f-b4c7-07e85776332a"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cea1f925-1e47-49fd-b975-8e81e36882e3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("34782b18-c0dc-4306-b5e3-221977c21290"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("878bd26f-ac49-4a36-9a8b-4af0212b044d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("71ab26c2-181c-4307-8a83-d0538806636f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2ffc82e6-b4c8-486c-aa22-d805a1d5e328"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("adcddfff-8bf7-4477-b541-604f58c66160"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("88465b46-176e-41d1-92c2-add464f7545f"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a0734daa-7ea2-46cb-9720-d21bb2e712b5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("65b31094-3d1f-4c7d-ba05-e9c53da9807b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("792b8992-b696-4d6c-b996-5b0ebcd1ce89"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("093006b0-bd8b-4b20-9ae3-a7e526ca25ff"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f7ff3112-e622-4330-8356-42fd76394e6e"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f85235e0-588a-4630-b1e2-ede9958f92fb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("035ee4cf-6299-4b59-aeb1-ce6139bc8e98"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("05b66c67-953c-418c-8b8a-6ad269e1b53e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f8665ce2-3ba3-41ae-a895-7f8c498618d0"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c60df997-fa7e-46f1-8e7d-a56d81086304"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2bcf9734-f315-4220-80dd-5d467ebc206c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5dc39f04-f19d-44bd-99eb-c4a633002334"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb6f348a-3c30-422b-ad44-384312e84ddc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f7b451c-3ec7-4620-8f4a-1078adba02fe"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1a8e2e3d-a303-4a8c-ad63-a121ca40a561"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4559c6e0-faeb-419b-80ef-4f6e1153abce"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cc4826f6-55cb-471e-97dd-63ac7b7279f0"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("51c64da8-c37d-4bd5-a265-47e28f2e4cb7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ff798a59-1a80-467c-abc5-40c3305f4792"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1ac91fbe-cbed-4815-b5be-9dd2c5d5eeb6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("60b96589-9554-4ee0-91b1-877e1e60d8cd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ffca1d5c-2057-4acd-95ad-47dd3784eb4c"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4fb7c547-195c-40b3-b898-f5bf6d7d5172"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d38ac1ea-5e28-4852-80d6-4f26fbfd10ce"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2586302c-054b-4000-b97e-30cf6b4b0de8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("86ba7a3f-376f-410f-a624-b00e7f578a3a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("84a7f27f-5bee-4325-9d27-c69978ee7a2b"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2019fd17-6151-45a8-a5ea-53879a144ba6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0def94b1-7e90-4422-9cf3-b0a008d91e01"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e2412fe8-bd5c-442d-b3d9-801fe924965c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("51e6aaad-7810-439f-9a15-a17a0ba03be6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("be37927c-a3be-4461-9230-c94480b93f69"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a82ee95e-3b39-45b1-b0ff-abc3dea5ca32"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3e89354e-c977-4cc8-9e2b-152d666b49c4"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4bf9d47e-6f50-40d7-847c-ac03a4cd5ac7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("aa2d71fd-45a5-48ba-93b0-672d9b4c8d3d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5763743f-2805-47fd-9170-ee99b0b03ab3"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fd5555f3-123b-4fea-b642-9fd37f94bb77"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2c405da7-e2db-4cd8-8752-b444f5928834"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("84bb2831-95e6-41a1-9237-020ab435ff79"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e92ab5f5-41d5-4922-bef6-e7c7e36263e6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ebd0de0a-1318-49a8-8ffb-f6aaf272a3f9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a031f888-a95f-43fe-a270-05452f615bda"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3a9a95ae-aa94-4b89-ad9c-eddfe6643e62"))));

            }
        }

#endregion

    }
}




using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidSingleTypeUUID
    {
    }
    
    internal partial class GuidSingleTypeUUID : IGuidSingleTypeUUID
    {


#region TestData

        private readonly GuidUUIDE0M[] _testData = new GuidUUIDE0M[]
        {
            new GuidUUIDE0M
{
    Id = 4,
    Value = Guid.Parse("067e7b94-45c0-4e40-a5c8-25851ce6e3d4"),
    ModelInner = new GuidUUID0MI
{
    Id = 7,
    Value = Guid.Parse("df52b66b-513c-4330-93ef-48f789f3e7d1"),
    NullableValue = Guid.Parse("cb28dcd1-92bb-4b65-b9aa-b78f3b0d004e"),
},
    NullableValue = Guid.Parse("c84667ea-fca4-4dcb-b14e-88fe5c7b9328"),
},
            new GuidUUIDE0M
{
    Id = 10,
    Value = Guid.Parse("a59f6e92-785d-498c-a860-9951ebfddd41"),
    ModelInner = new GuidUUID0MI
{
    Id = 10,
    Value = Guid.Parse("0fe8c8d4-1aac-4bc1-8383-d648930ed93b"),
    NullableValue = Guid.Parse("d089637a-2066-490a-8fcb-5f52547d2685"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 16,
    Value = Guid.Parse("b33e3efb-d149-495f-99bf-265de75b77db"),
    ModelInner = new GuidUUID0MI
{
    Id = 12,
    Value = Guid.Parse("9cac88db-abd3-47ae-8b14-3c63a423afcc"),
    NullableValue = Guid.Parse("ad2d7147-a65e-4dad-b43b-3d4cdea8c437"),
},
    NullableValue = Guid.Parse("cc52e0c2-816c-40eb-be59-ae16058f78ec"),
},
            new GuidUUIDE0M
{
    Id = 19,
    Value = Guid.Parse("c32b9da4-74c0-40ea-8e63-8ab5bc1b3e0e"),
    ModelInner = new GuidUUID0MI
{
    Id = 13,
    Value = Guid.Parse("00ca3549-3ace-4d32-9d0d-aabd1d5b6bb9"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 24,
    Value = Guid.Parse("7650e1ff-905a-4981-a93a-fd7e50dc2101"),
    ModelInner = new GuidUUID0MI
{
    Id = 14,
    Value = Guid.Parse("9db341c7-a301-402b-a27a-129f83421579"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b06ceb08-2b3d-412b-846c-d4abf36de506"),
},
            new GuidUUIDE0M
{
    Id = 26,
    Value = Guid.Parse("efd7f185-ad1d-4855-bf46-aaddd5187dac"),
    ModelInner = new GuidUUID0MI
{
    Id = 18,
    Value = Guid.Parse("d53ce3e7-0283-4188-880a-4834e273a3a6"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 31,
    Value = Guid.Parse("b3db78c1-387d-44b6-94f7-65f213d244dd"),
    ModelInner = new GuidUUID0MI
{
    Id = 19,
    Value = Guid.Parse("ae8a2c06-775c-4353-9ed4-6081370ffa48"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 32,
    Value = Guid.Parse("0a57bd63-d72b-4931-87be-3188e5f0dc75"),
    ModelInner = new GuidUUID0MI
{
    Id = 20,
    Value = Guid.Parse("56350b93-a6fe-47a6-a8d8-e2823e023bfe"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0805def5-248c-4876-8415-89c8739fa4b7"),
},
            new GuidUUIDE0M
{
    Id = 40,
    Value = Guid.Parse("5c71e923-8b8e-4fe3-8b6b-afd1debec2b1"),
    ModelInner = new GuidUUID0MI
{
    Id = 22,
    Value = Guid.Parse("233ecf9b-5ce1-46b5-b91f-640a1993a099"),
    NullableValue = Guid.Parse("b910952c-c41f-478e-9bbb-37001c623322"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 49,
    Value = Guid.Parse("a8ea9912-b913-4413-bf49-0f77ad1a97ee"),
    ModelInner = new GuidUUID0MI
{
    Id = 25,
    Value = Guid.Parse("850672c4-1ec8-41ac-a2b0-5d13297f9d3d"),
    NullableValue = Guid.Parse("00cac9b4-3f3b-436c-95a7-aaf81b104238"),
},
    NullableValue = Guid.Parse("708d2ee0-c2be-4e4d-b466-a4d3e1ede070"),
},
            new GuidUUIDE0M
{
    Id = 51,
    Value = Guid.Parse("6aa44a29-f964-4409-ac54-0d3e7702fb26"),
    ModelInner = new GuidUUID0MI
{
    Id = 32,
    Value = Guid.Parse("5bf8aba8-74f0-4508-8863-c9e8260bfaf7"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2c8fbd43-eeb7-4b5e-b100-056cd6e34b1d"),
},
            new GuidUUIDE0M
{
    Id = 54,
    Value = Guid.Parse("b72ccd62-146d-4052-8a29-f8242d390c78"),
    ModelInner = new GuidUUID0MI
{
    Id = 33,
    Value = Guid.Parse("9c4efd98-900b-4ec8-b24f-b09bfb7f5656"),
    NullableValue = Guid.Parse("762d98bf-7bd7-4bcd-938e-e3473da56f8f"),
},
    NullableValue = Guid.Parse("ba68440f-aa21-4987-b063-68d146ce18a4"),
},
            new GuidUUIDE0M
{
    Id = 60,
    Value = Guid.Parse("6ac8647e-de45-464e-a814-eefe47cc2e35"),
    ModelInner = new GuidUUID0MI
{
    Id = 36,
    Value = Guid.Parse("dcf8bf67-1b6e-44eb-b795-6e7ccd922917"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d78f34bd-1e4e-479c-a14e-1b0a6d34ad34"),
},
            new GuidUUIDE0M
{
    Id = 63,
    Value = Guid.Parse("7a4d137e-50f3-4be8-8c76-031dff59e70a"),
    ModelInner = new GuidUUID0MI
{
    Id = 43,
    Value = Guid.Parse("7a039289-e49b-48af-ad9b-4fb6081db8e9"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 69,
    Value = Guid.Parse("a7f9ad11-23dd-4c0f-98d0-a4384fc4505a"),
    ModelInner = new GuidUUID0MI
{
    Id = 51,
    Value = Guid.Parse("e068a058-e0cd-402e-951d-0498198e2ab7"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 73,
    Value = Guid.Parse("3eedf756-9841-44c6-ba64-69bbdaa44834"),
    ModelInner = new GuidUUID0MI
{
    Id = 57,
    Value = Guid.Parse("1cd3043f-4250-4d6d-bb1d-cc0fe9d0850b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 75,
    Value = Guid.Parse("b8bcdf07-ee9a-4cd8-9185-7b97a831d64c"),
    ModelInner = new GuidUUID0MI
{
    Id = 60,
    Value = Guid.Parse("45ca1efa-a703-4f71-8d59-67e42b6bd65a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("48098521-3197-4aed-8e30-4c536b1f1f4a"),
},
            new GuidUUIDE0M
{
    Id = 81,
    Value = Guid.Parse("38a6e104-5480-47f4-8e87-c63a6b63bfe4"),
    ModelInner = new GuidUUID0MI
{
    Id = 64,
    Value = Guid.Parse("f4d02252-c6e2-4e96-82a6-dea6a4a61786"),
    NullableValue = Guid.Parse("ea45e4f9-3ce9-413a-9fe2-42a53f8449e4"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 83,
    Value = Guid.Parse("1632b30b-62c4-454c-b5f7-4fa451a9d03e"),
    ModelInner = new GuidUUID0MI
{
    Id = 67,
    Value = Guid.Parse("cd32f047-7fdd-4e1a-824b-6a842abade9e"),
    NullableValue = Guid.Parse("9dbcb9ce-f4da-463e-b3f2-30da4b5f07f4"),
},
    NullableValue = Guid.Parse("2517be2b-720a-4d27-bffc-a37b3ef514e7"),
},
            new GuidUUIDE0M
{
    Id = 90,
    Value = Guid.Parse("871bc21e-75ca-460c-aea1-9820392b7e47"),
    ModelInner = new GuidUUID0MI
{
    Id = 71,
    Value = Guid.Parse("80c0d2a4-8a89-4251-9d88-169e103efa5c"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 91,
    Value = Guid.Parse("ef6ed4ee-e56a-4ed1-9c1b-e14c425b505a"),
    ModelInner = new GuidUUID0MI
{
    Id = 75,
    Value = Guid.Parse("887cc808-2141-46c0-9f80-3e4b381fe2ca"),
    NullableValue = Guid.Parse("7a20ab5a-a512-4bc1-854b-338a95f29e78"),
},
    NullableValue = Guid.Parse("5f1b2c22-b5e3-4444-824b-6264172d7c82"),
},
            new GuidUUIDE0M
{
    Id = 94,
    Value = Guid.Parse("993a04a4-0833-48e1-808a-47670bdccc7d"),
    ModelInner = new GuidUUID0MI
{
    Id = 82,
    Value = Guid.Parse("99feb940-07fb-4957-8cf0-bc51f2f68427"),
    NullableValue = Guid.Parse("c28e3812-de80-4526-acc1-b143a00ed73f"),
},
    NullableValue = Guid.Parse("36aef693-700f-4f8e-a00f-5a5b4ceec89f"),
},
            new GuidUUIDE0M
{
    Id = 100,
    Value = Guid.Parse("0ff9d695-9b60-4563-a16e-6ef47ed9b3e6"),
    ModelInner = new GuidUUID0MI
{
    Id = 85,
    Value = Guid.Parse("519e64df-158b-4e58-b85c-36252a50f5a2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 103,
    Value = Guid.Parse("0eafce5f-ee04-4e4f-b0c9-04a0b6b48f84"),
    ModelInner = new GuidUUID0MI
{
    Id = 93,
    Value = Guid.Parse("0ad68c7f-f7ff-4445-b584-5a3b82693710"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 106,
    Value = Guid.Parse("35af6d94-9fc5-4c66-905a-89be2062345b"),
    ModelInner = new GuidUUID0MI
{
    Id = 102,
    Value = Guid.Parse("eb3b0531-b30d-430d-a6c4-6cd457d4cdc8"),
    NullableValue = Guid.Parse("1a60f83e-cc7c-47c3-8262-22a710c1e5cf"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 107,
    Value = Guid.Parse("edaa356e-6e14-4762-b385-109917627ae4"),
    ModelInner = new GuidUUID0MI
{
    Id = 109,
    Value = Guid.Parse("3cd53fc5-7e3e-4355-af1e-c704f6cc1373"),
    NullableValue = Guid.Parse("ad1d5971-f69c-4838-8282-97baa7bc67f9"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 109,
    Value = Guid.Parse("454bd10f-3b2d-4aab-a3cd-9257e058563b"),
    ModelInner = new GuidUUID0MI
{
    Id = 118,
    Value = Guid.Parse("f6cdee65-862c-4b29-abb9-a4247e3a1f21"),
    NullableValue = Guid.Parse("c8a717d6-4ed9-4027-b67b-4dfc7482cd1d"),
},
    NullableValue = Guid.Parse("960770bc-1248-4860-b654-c4effe5a7a1a"),
},
            new GuidUUIDE0M
{
    Id = 112,
    Value = Guid.Parse("92fe76c9-15e7-4070-a46f-8e85b64f5d8a"),
    ModelInner = new GuidUUID0MI
{
    Id = 123,
    Value = Guid.Parse("dda91121-d8a4-4bbb-92bb-c1c50b0a59ab"),
    NullableValue = Guid.Parse("ae6f059a-5556-4f7f-9412-9703277ce199"),
},
    NullableValue = Guid.Parse("61c2d25e-bbc5-4867-bf38-441930892d2e"),
},
            new GuidUUIDE0M
{
    Id = 121,
    Value = Guid.Parse("28dc0664-778e-4d7b-923c-a36ea07ec09c"),
    ModelInner = new GuidUUID0MI
{
    Id = 124,
    Value = Guid.Parse("a8d760cb-b5c0-4b9e-b9b5-6b60e80ba7a3"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 124,
    Value = Guid.Parse("44e9fd55-0ba1-468b-95d3-9b41a78312fb"),
    ModelInner = new GuidUUID0MI
{
    Id = 129,
    Value = Guid.Parse("94eba3b0-5a03-4881-bfef-d12e2203db3a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("851b0ed3-e767-4550-bf26-f366087c58e5"),
},
            new GuidUUIDE0M
{
    Id = 130,
    Value = Guid.Parse("e63744cf-68cf-4420-bd9d-069c67b71e41"),
    ModelInner = new GuidUUID0MI
{
    Id = 136,
    Value = Guid.Parse("26c355f0-d1f3-415b-862f-8059beb52b7f"),
    NullableValue = Guid.Parse("9a6809dc-f8ca-4d00-98c5-0ba6fb990565"),
},
    NullableValue = Guid.Parse("bb357a07-bca1-4762-b13d-7e70de93b11d"),
},
            new GuidUUIDE0M
{
    Id = 134,
    Value = Guid.Parse("e0bb7b85-bc9c-4a81-88f7-8c65c17d3302"),
    ModelInner = new GuidUUID0MI
{
    Id = 137,
    Value = Guid.Parse("a5116985-1662-4ea5-ba22-a4d4112ed2a8"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("239c6f92-4d2f-40d2-aa53-468399861e9c"),
},
            new GuidUUIDE0M
{
    Id = 136,
    Value = Guid.Parse("a04c069c-9044-4661-b778-e382a31e63cc"),
    ModelInner = new GuidUUID0MI
{
    Id = 143,
    Value = Guid.Parse("037f9544-564d-45f7-b78a-a3815104a7fc"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 142,
    Value = Guid.Parse("a3273684-9e22-4a7f-b53c-e30ab9ef7017"),
    ModelInner = new GuidUUID0MI
{
    Id = 149,
    Value = Guid.Parse("90f7688b-c212-48df-8f75-739443142c83"),
    NullableValue = Guid.Parse("3ea9a425-569e-4b3c-8ef2-b88923d4d6ea"),
},
    NullableValue = Guid.Parse("7c36177b-48b3-4cbd-8cf8-a99265c23a68"),
},
            new GuidUUIDE0M
{
    Id = 144,
    Value = Guid.Parse("36e05489-4abb-481a-a150-792e04517013"),
    ModelInner = new GuidUUID0MI
{
    Id = 150,
    Value = Guid.Parse("a9f5d6dc-7ddc-4c06-ae03-a0d1ae65d643"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("42f9e7a2-d4b5-46de-8289-8234204618c9"),
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guiduuide0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UUID}, 
    {mi_id:Int32},
    {mi_value:UUID}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeUUID)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IGuidSingleTypeUUID)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IGuidSingleTypeUUID)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.guiduuide0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidUUIDE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeUUID)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IGuidSingleTypeUUID)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidUUIDE0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IGuidSingleTypeUUID)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidUUIDE0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


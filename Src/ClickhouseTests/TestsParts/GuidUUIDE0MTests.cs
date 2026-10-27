

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
    Value = Guid.Parse("a1214c61-dd55-4919-bd6d-f07d2e9fbdf8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 5,
    Value = Guid.Parse("c1c10092-3fa6-4fe1-91d2-1819fc61d81b"),
    NullableValue = Guid.Parse("b0116167-564f-4051-893e-e4593058cd06"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 5,
    Value = Guid.Parse("90b1ce67-ec1b-4aaa-9e38-6b6a6a37e180"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 9,
    Value = Guid.Parse("cf13261e-6030-4c5d-9ea8-da82704d39e9"),
    NullableValue = Guid.Parse("3d36cd6b-a24a-4328-8975-8548f16556b7"),
},
    NullableValue = Guid.Parse("891bac4d-239f-47d3-8092-c7aa23ba208a"),
},
            new GuidUUIDE0M
{
    Id = 14,
    Value = Guid.Parse("c0256f15-488f-437e-9bdc-c10ed364027b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 10,
    Value = Guid.Parse("b2bd73b4-97dd-4c04-9260-a2edb93fe5ef"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("940bc9f6-7e10-46cb-8b86-8f6b31b799db"),
},
            new GuidUUIDE0M
{
    Id = 19,
    Value = Guid.Parse("7e7d271f-8a29-4c92-b788-065545cdfb2b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 17,
    Value = Guid.Parse("c5dde199-9df9-42e0-8790-ee89d988431c"),
    NullableValue = Guid.Parse("dc25a4ec-0a60-468b-8839-dda8cfc1ed7e"),
},
    NullableValue = Guid.Parse("c84225a5-81eb-4a77-b6d8-c2b7bfb1633a"),
},
            new GuidUUIDE0M
{
    Id = 26,
    Value = Guid.Parse("979d084a-d831-4c39-b3c0-67d1e1a56a17"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 26,
    Value = Guid.Parse("72354981-63c5-4980-9133-a62bb81d21c0"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b81d9730-43bb-4cce-8184-fc256b831030"),
},
            new GuidUUIDE0M
{
    Id = 28,
    Value = Guid.Parse("aaa8dd59-f1aa-463c-a689-99e50434a830"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 35,
    Value = Guid.Parse("bc08a988-02dd-4e2c-9568-8a18706b84a2"),
    NullableValue = Guid.Parse("ff55b1bc-9e13-491e-8651-88fcd7203669"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 32,
    Value = Guid.Parse("c5ef4ada-bd5e-4dc1-b22c-1222a0e7dcf2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 38,
    Value = Guid.Parse("066937d3-5ac2-4314-bb6a-0565616f50c1"),
    NullableValue = Guid.Parse("00812c83-583c-485b-8f99-d67395e892d1"),
},
    NullableValue = Guid.Parse("4013d0ce-847d-4d11-9b75-11b52f4cc6be"),
},
            new GuidUUIDE0M
{
    Id = 38,
    Value = Guid.Parse("391a6af3-8071-4665-a948-2b758ccbe854"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 47,
    Value = Guid.Parse("7adb9017-fb13-4d0b-9ac4-9fcda9af4644"),
    NullableValue = Guid.Parse("f2d03709-d423-4942-8e98-6d52f42a1e07"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 39,
    Value = Guid.Parse("af443919-451c-4cb4-a3e0-e43810dca1b8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 56,
    Value = Guid.Parse("fd0f100b-a137-4928-b03b-1c2e08c82c9c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f8e233fb-ad76-4cf0-b0a8-fe6224b20ff4"),
},
            new GuidUUIDE0M
{
    Id = 40,
    Value = Guid.Parse("910e9a47-0309-4a57-830b-fa9645d996e4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 64,
    Value = Guid.Parse("595dad3c-9ad1-442c-92cf-d70cf49c01df"),
    NullableValue = Guid.Parse("07fb82e7-9bc0-4f9c-b5ef-f0f6a6735f43"),
},
    NullableValue = Guid.Parse("696ad049-9430-4632-85bf-81ed0dd788af"),
},
            new GuidUUIDE0M
{
    Id = 44,
    Value = Guid.Parse("e5c5d4e7-2f6f-4e90-97de-18f95204bbab"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 68,
    Value = Guid.Parse("22e70107-dede-4325-85ae-0345e352fe84"),
    NullableValue = Guid.Parse("fdb9fed7-86e1-4a11-ae35-0e658e6aa06a"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 46,
    Value = Guid.Parse("62b01512-cad9-44ed-a42d-a0d94e73b6dc"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 77,
    Value = Guid.Parse("f37c8536-9e54-45c1-bb90-0e204c8d6fb0"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d7ae39a6-e935-474f-ace9-515a54da3e79"),
},
            new GuidUUIDE0M
{
    Id = 47,
    Value = Guid.Parse("c657d124-d165-45cb-84c5-6c5ea4709b87"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 85,
    Value = Guid.Parse("fc17036e-bee9-4db1-bf00-5845bb700943"),
    NullableValue = Guid.Parse("de041a0e-de3c-46a7-baed-4a6aff01947d"),
},
    NullableValue = Guid.Parse("1d040a77-06ba-46b5-a797-7b8e1ab48d6c"),
},
            new GuidUUIDE0M
{
    Id = 51,
    Value = Guid.Parse("7eb5b853-466f-4886-ba1f-25663da605d1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 90,
    Value = Guid.Parse("91c3c42d-63e0-45f5-ab22-90ded97fe329"),
    NullableValue = Guid.Parse("035413c4-3f8e-41e5-b658-1005e2a2ce2b"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 56,
    Value = Guid.Parse("a8dc4760-6e01-4003-9eff-44a41c777bcf"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 94,
    Value = Guid.Parse("7eef92ee-e3fd-4389-b35c-5da7882e92fe"),
    NullableValue = Guid.Parse("4f268bca-dd68-469b-b95f-ab3561b36567"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 58,
    Value = Guid.Parse("f6521d91-99c8-4f93-9324-19e1e8d49619"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 97,
    Value = Guid.Parse("059ae6cf-c3ba-435a-9b27-c71f0f83a567"),
    NullableValue = Guid.Parse("531ea1e1-b960-4e03-a28c-0dc448b8199d"),
},
    NullableValue = Guid.Parse("68c1ae2c-d410-416f-865e-d5e7e56bfd87"),
},
            new GuidUUIDE0M
{
    Id = 60,
    Value = Guid.Parse("e0cc21ee-8fb9-4098-b0b3-8fa85c9a1844"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 102,
    Value = Guid.Parse("d2af2011-b1b2-435e-a63b-f8f4dc276391"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c916989f-1e8a-467d-9a0d-9257105b5e94"),
},
            new GuidUUIDE0M
{
    Id = 64,
    Value = Guid.Parse("cd2b4bb1-a79a-42b3-bcbf-c9e6a1b3ea6d"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 106,
    Value = Guid.Parse("ebb14c3f-8df4-42dc-8063-c70d87bb0ccc"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d2467cba-9b9b-4b9b-9538-6cca759d433b"),
},
            new GuidUUIDE0M
{
    Id = 66,
    Value = Guid.Parse("8f3d9d1e-d788-4333-a5d4-90ef9a751938"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 110,
    Value = Guid.Parse("e594d48d-4943-4455-9c37-8dc0e0495748"),
    NullableValue = Guid.Parse("734c1e3e-0065-42ab-bb2d-7e68b4577298"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 70,
    Value = Guid.Parse("3c70a76c-ada7-472c-9f45-3c84edc6f295"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 117,
    Value = Guid.Parse("193e073b-ea7e-48be-bc56-7afd0a47e697"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ca9fcf4e-9a82-4bb5-83a9-4bd75b8bfaa4"),
},
            new GuidUUIDE0M
{
    Id = 76,
    Value = Guid.Parse("ebdf3ddb-e828-49a3-8f80-211218c534e2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 126,
    Value = Guid.Parse("7a70aa95-67e3-4aab-9d00-25f65ebd5c77"),
    NullableValue = Guid.Parse("95be42ce-d67e-4f53-b9ab-dcdf2b098607"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 82,
    Value = Guid.Parse("50f56716-1e29-4ef0-b239-76dad327d4f1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 133,
    Value = Guid.Parse("345fac1f-f771-4cce-bb74-3beb9a9125d1"),
    NullableValue = Guid.Parse("6eaa0292-eff6-48ee-8418-eb90dc135a25"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 91,
    Value = Guid.Parse("424c351d-e34f-44a0-bb7e-a7ec70427eda"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 137,
    Value = Guid.Parse("d90c2695-b108-409d-9978-662df60a62eb"),
    NullableValue = Guid.Parse("0bb8dd86-2f3a-40ba-8d99-aba1e3c2683e"),
},
    NullableValue = Guid.Parse("96fbf8df-110d-4028-8098-649152afd62a"),
},
            new GuidUUIDE0M
{
    Id = 93,
    Value = Guid.Parse("de683d1a-1df6-48f7-99ef-0fae95c21ae8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 138,
    Value = Guid.Parse("77177dec-d259-4b70-9de4-ffe13232d4bc"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 97,
    Value = Guid.Parse("0fb96475-9b60-4dc4-8e9d-de3ec915e7e4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 146,
    Value = Guid.Parse("537a7ca9-db79-4c3e-8665-4afe58f44e76"),
    NullableValue = Guid.Parse("5cf91a36-cc73-4602-afd0-58d3e33d8ee6"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 103,
    Value = Guid.Parse("17459b7f-4e1a-4991-9f66-c98e5baf6a5d"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 154,
    Value = Guid.Parse("3cbd0ff4-9605-403a-bc05-7e239b698f0a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 105,
    Value = Guid.Parse("b2737324-bd98-4c73-bfa4-f48992cd0bcb"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 160,
    Value = Guid.Parse("d0b32e21-66f9-4c77-89a8-c2c1aa2a6730"),
    NullableValue = Guid.Parse("df3b1edd-2cc0-43f5-8d39-da096e120a81"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 111,
    Value = Guid.Parse("89a4a8c8-4198-4357-8909-ef7e47ab177b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 168,
    Value = Guid.Parse("2889a652-a436-4f6e-9276-a67a2cd3a80d"),
    NullableValue = Guid.Parse("9cb40eed-38f9-410f-bc23-9119fa564199"),
},
    NullableValue = Guid.Parse("2eb93b3e-cb2b-46d8-8e9f-da4a4b90cc64"),
},
            new GuidUUIDE0M
{
    Id = 115,
    Value = Guid.Parse("3d3a38bb-b78e-45b6-9a4c-4be135acffc1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 169,
    Value = Guid.Parse("f1b6df0f-0480-407d-b3cd-f07085e59e60"),
    NullableValue = Guid.Parse("05ef819c-8e9b-454a-b111-89d8ee5a7273"),
},
    NullableValue = Guid.Parse("b7045626-fc05-4d12-90bd-2aec59a9969d"),
},
            new GuidUUIDE0M
{
    Id = 121,
    Value = Guid.Parse("b813f5d8-b016-451e-8301-a2acceb7d7bc"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 174,
    Value = Guid.Parse("4b3bbfb3-3be2-41b6-9a6b-94d671cacab2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 123,
    Value = Guid.Parse("a651048a-c647-4c22-a031-2e2e73d73ce8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 181,
    Value = Guid.Parse("64b989f3-4534-4d92-8cdc-e47120568f69"),
    NullableValue = Guid.Parse("094870e8-15ed-46d5-917a-b5bae4b59ca8"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 126,
    Value = Guid.Parse("be23e255-bbb8-4c29-bca6-2215006acdc7"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 183,
    Value = Guid.Parse("1410d077-9b17-460b-9b57-15482e03a988"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("aba942a5-6621-406c-8d5b-5efc66bf0cfd"),
},
            new GuidUUIDE0M
{
    Id = 133,
    Value = Guid.Parse("631d5981-4706-4c1f-99d1-0b6fdb6a8559"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 189,
    Value = Guid.Parse("37a8e16c-5efe-420d-9243-287e3a00c7ec"),
    NullableValue = Guid.Parse("cfb03d56-b23d-41e7-a725-2a623fa0ed67"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 136,
    Value = Guid.Parse("216a6711-2785-4e6d-9da3-50229344e98a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 196,
    Value = Guid.Parse("39c47e63-daf6-46a4-bc8e-d84c86260faf"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a9ac8d54-fd32-4805-8f1c-ebd1f43183a5"),
},
            new GuidUUIDE0M
{
    Id = 142,
    Value = Guid.Parse("30ce5489-23ad-4747-9d67-4cd4262c1e22"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 204,
    Value = Guid.Parse("3d3e543a-797d-4279-abab-47264da52b78"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d0d3588d-9e90-4677-92b7-50234c721bbe"),
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


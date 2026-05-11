

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
    Id = 6,
    Value = Guid.Parse("a28ac691-173d-48e4-a871-322e1a412154"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 5,
    Value = Guid.Parse("e0dd8bfa-fed4-4d83-a3c4-a84aa687e7c0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 13,
    Value = Guid.Parse("c3217e41-c2ac-4f0e-8ecb-98e41a893004"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 6,
    Value = Guid.Parse("b230d72c-2d58-4023-a1d1-37ad7aff0af4"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2fa72e7e-13ce-4b8f-8cce-01691f517f4b"),
},
            new GuidUUIDE0M
{
    Id = 14,
    Value = Guid.Parse("7e5a7900-880e-4511-b885-91c2164f8809"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 11,
    Value = Guid.Parse("5557065d-1e11-4cf4-835e-91f8befb4815"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f41b4bb0-084e-40ed-b762-d0c3f1a43ff1"),
},
            new GuidUUIDE0M
{
    Id = 21,
    Value = Guid.Parse("72a47c17-b2af-4051-a1de-c4dd5a8bd965"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 14,
    Value = Guid.Parse("10440c1c-9a67-4406-b144-36b1b8197ffd"),
    NullableValue = Guid.Parse("ddfb6c36-a779-4abd-9838-1acebef86fb2"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 25,
    Value = Guid.Parse("be43b0ab-f412-4d13-8e9e-b8454a8ad36a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 18,
    Value = Guid.Parse("ca9d5ea8-5628-4c4d-946f-8b0f2bb46973"),
    NullableValue = Guid.Parse("94af3646-3524-45cd-9aa0-dd0f8f88bd54"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 28,
    Value = Guid.Parse("1c357c6d-400a-40bd-b739-b6235afdcaab"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 22,
    Value = Guid.Parse("bd3e945a-d860-4912-b0e6-56a36b6ead71"),
    NullableValue = Guid.Parse("1f8cf23d-1a90-45b6-bd1a-3bcd47fe6c92"),
},
    NullableValue = Guid.Parse("06943490-43d9-4120-abef-58e48a7ccee4"),
},
            new GuidUUIDE0M
{
    Id = 31,
    Value = Guid.Parse("c6eba810-d163-400d-a521-ef62b66cd7ce"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 31,
    Value = Guid.Parse("9239e9db-32b7-4f47-8e75-794288f6bffa"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 33,
    Value = Guid.Parse("2d1eaf6b-b917-4743-a26c-0a5c7892ec61"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 35,
    Value = Guid.Parse("25854559-151a-4f67-b7ef-c5752af85015"),
    NullableValue = Guid.Parse("de7a26f1-8f74-4ad0-8717-2318882d5776"),
},
    NullableValue = Guid.Parse("d1d104e9-2bf9-499e-a152-facf0a587b88"),
},
            new GuidUUIDE0M
{
    Id = 35,
    Value = Guid.Parse("31575752-587d-4718-ac6b-e35475635056"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 41,
    Value = Guid.Parse("b31e6135-6444-40a2-8c74-61dd08f8ab18"),
    NullableValue = Guid.Parse("4b1de638-f33d-4e39-a951-f8b27d91add9"),
},
    NullableValue = Guid.Parse("b586549a-0333-42d4-9233-53a5ae15d06c"),
},
            new GuidUUIDE0M
{
    Id = 37,
    Value = Guid.Parse("47c8d574-63e9-4a17-8706-6d28d108f933"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 44,
    Value = Guid.Parse("2b0897dd-0d9c-46dd-ae26-a83a55a7a7d5"),
    NullableValue = Guid.Parse("70cb8631-9c67-41f6-9c5b-c2bdbabc61fd"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 43,
    Value = Guid.Parse("f5ed9485-c003-460b-bac9-fa3dc8d209db"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 46,
    Value = Guid.Parse("91a4a044-f448-4d33-bc8d-dcbf089bc250"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 46,
    Value = Guid.Parse("0d37c7b6-9b83-4f7e-a3cd-3cc5f0f6b016"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 53,
    Value = Guid.Parse("e92ac46a-b0b5-4ffe-9ca8-4a522352fb62"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e97be94a-eefa-4e0d-b429-253e853792f8"),
},
            new GuidUUIDE0M
{
    Id = 54,
    Value = Guid.Parse("6170f103-6f73-4e02-9ae6-c77c1b322fa3"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 61,
    Value = Guid.Parse("cc6fce73-9bfc-4932-b48a-d16e79ddae7e"),
    NullableValue = Guid.Parse("948e5216-c68d-4b68-9c58-4153987a91bb"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 56,
    Value = Guid.Parse("1b0e829f-fa09-42c0-87f7-5f4041daa99a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 68,
    Value = Guid.Parse("0cf5878f-892c-4ddf-9930-4371b11ade1f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("6e8a0728-68f8-44cf-bf31-7c2dd1dca704"),
},
            new GuidUUIDE0M
{
    Id = 62,
    Value = Guid.Parse("ac790ecd-3be3-4c42-8f19-0530bc009831"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 69,
    Value = Guid.Parse("163cb6f0-2ca5-48b2-ac3e-84510d33bc7c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("307e224f-962c-4e8b-b34c-6a639df2e7ee"),
},
            new GuidUUIDE0M
{
    Id = 64,
    Value = Guid.Parse("63d7fe6f-6e18-4319-b530-692f31e9e9ad"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 72,
    Value = Guid.Parse("09447b58-fea9-4d69-b2f9-408ce35bf2f7"),
    NullableValue = Guid.Parse("9c4c91a7-4cbc-4d8f-880a-f4e092954972"),
},
    NullableValue = Guid.Parse("1b5858d6-22bd-4d70-b724-d887d9e564a1"),
},
            new GuidUUIDE0M
{
    Id = 72,
    Value = Guid.Parse("12547906-b2b3-4402-b448-44c830c1a9dc"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 81,
    Value = Guid.Parse("e84b01bb-fa08-4b73-811e-65c0bbb26d19"),
    NullableValue = Guid.Parse("ec9066bc-479f-4825-a3fa-6c04e4dfed37"),
},
    NullableValue = Guid.Parse("8412a532-8b3b-41ed-a26d-19c7dba02fb8"),
},
            new GuidUUIDE0M
{
    Id = 78,
    Value = Guid.Parse("309e3b2a-0b8b-4376-b963-7e55a2062154"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 90,
    Value = Guid.Parse("9681c82c-7596-409f-bb7d-59765f5f25a2"),
    NullableValue = Guid.Parse("6fec7c4e-c158-4b32-a096-d1e80aa8ad11"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 83,
    Value = Guid.Parse("94129607-e9e8-41be-95c5-58a13f8ddd13"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 92,
    Value = Guid.Parse("aa301f76-c493-4e81-9154-9ae5bb89fbfc"),
    NullableValue = Guid.Parse("3bc50544-838f-4c30-806f-76dce8f1e921"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 89,
    Value = Guid.Parse("5d2e8811-ed98-4464-a341-dfbd25cd682b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 93,
    Value = Guid.Parse("09363a53-ae65-4c07-9dbd-011bee3abdb5"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 92,
    Value = Guid.Parse("dae72ea3-9efd-4c63-8c9d-e1563355e371"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 94,
    Value = Guid.Parse("b77b8ef0-2e29-450b-925d-29d5737ca3f3"),
    NullableValue = Guid.Parse("5ab98db3-236f-45db-ac20-ac9a2f506b59"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 97,
    Value = Guid.Parse("5b07c482-2d9f-49d1-9bab-ef2c6dd2e57c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 102,
    Value = Guid.Parse("cb8d8f68-0649-47dc-b5e0-f35223cfd12e"),
    NullableValue = Guid.Parse("94f0e004-0b56-4bb3-b34c-436da57fb8aa"),
},
    NullableValue = Guid.Parse("fb4ed547-0c81-42f8-b2b2-6b30e49f39f0"),
},
            new GuidUUIDE0M
{
    Id = 105,
    Value = Guid.Parse("4405d1ca-29c3-49ef-91c0-a4d6b8b907cc"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 104,
    Value = Guid.Parse("1865e882-3d86-4a22-bdc2-121f421b4bd9"),
    NullableValue = Guid.Parse("19e0a983-035b-4bca-b5d4-ce616cca7097"),
},
    NullableValue = Guid.Parse("9b511e21-8fc3-4071-8916-47edb3a8aa13"),
},
            new GuidUUIDE0M
{
    Id = 112,
    Value = Guid.Parse("71279176-f347-49de-99d5-4f5aa936a423"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 111,
    Value = Guid.Parse("584a7e41-2a78-49fd-a0c9-54787558798b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 118,
    Value = Guid.Parse("045e618b-8083-4dc0-a416-bd1d4a79c2be"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 120,
    Value = Guid.Parse("234847a5-5808-4195-8cdb-0d91ca51d93d"),
    NullableValue = Guid.Parse("8f7dcf5b-5310-430b-b1fd-203e5912248b"),
},
    NullableValue = Guid.Parse("c301b91d-7e10-4b55-9214-192bfe35fcfc"),
},
            new GuidUUIDE0M
{
    Id = 126,
    Value = Guid.Parse("4dfda891-e92c-43a0-9e8b-0d2b3bfa28c1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 122,
    Value = Guid.Parse("df4e91f0-7663-4f00-bb34-ebcdac7c8d3b"),
    NullableValue = Guid.Parse("aa128f79-bc68-406e-aa38-4ae7c8793e07"),
},
    NullableValue = Guid.Parse("49697774-bb43-4f50-92cf-519fc995dae9"),
},
            new GuidUUIDE0M
{
    Id = 132,
    Value = Guid.Parse("c823d7fc-223a-4c8a-a330-b18dea0b4d65"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 123,
    Value = Guid.Parse("2ba6f5c1-356b-45ea-b7c4-64b030360d67"),
    NullableValue = Guid.Parse("61d0b7a2-c2d4-48aa-874b-e4055cded6f0"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 135,
    Value = Guid.Parse("e98fa042-40b4-4ccc-b584-ab1218c63bbf"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 125,
    Value = Guid.Parse("4be66a18-ae2f-49dc-896d-831136ec6cde"),
    NullableValue = Guid.Parse("1c523061-5e9d-4740-8dbe-3125cd65e4a2"),
},
    NullableValue = Guid.Parse("1165202c-264d-47bc-986b-2b4be8edbbfe"),
},
            new GuidUUIDE0M
{
    Id = 143,
    Value = Guid.Parse("5968f461-45d0-406c-b33f-1befc5fe12e4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 133,
    Value = Guid.Parse("021fa874-d81c-4dbd-b8d0-549c30add987"),
    NullableValue = Guid.Parse("bc53261f-f2bb-44bc-97e5-bb7a0cd91a7b"),
},
    NullableValue = Guid.Parse("eecf26ba-bd93-4827-a920-9dd1141f3268"),
},
            new GuidUUIDE0M
{
    Id = 148,
    Value = Guid.Parse("16f606f8-25bf-4bc0-8452-d60aef77577c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 140,
    Value = Guid.Parse("981bd3ec-3b23-4c67-9fe7-426a59334a4b"),
    NullableValue = Guid.Parse("d08d83d7-b710-41e2-aa8f-a2ae43358dcb"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 153,
    Value = Guid.Parse("219b60ec-8115-4bc0-b232-f7821691eb2b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 147,
    Value = Guid.Parse("d9716e44-36c2-4862-a616-afca4cc86704"),
    NullableValue = Guid.Parse("d187c5e6-ae33-4347-8707-3be3ccb720a9"),
},
    NullableValue = Guid.Parse("1f536dbe-4386-4a38-b8c2-ba3e2a9b41f3"),
},
            new GuidUUIDE0M
{
    Id = 154,
    Value = Guid.Parse("9ddbe3da-9240-4a57-9e49-70f895b42d89"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 152,
    Value = Guid.Parse("7dac6b20-33c1-484a-a747-5d6323bfe5a7"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 162,
    Value = Guid.Parse("2c0945f2-c0e4-4e45-aa47-849d36a03884"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 153,
    Value = Guid.Parse("f3324f19-9978-4cb7-960c-278bc347584d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 164,
    Value = Guid.Parse("314b131d-69bc-4852-bd5f-8fec7d64830f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 160,
    Value = Guid.Parse("09590ae0-f9bc-4947-968b-2f29d5891f7e"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("95b04381-aadb-4585-ba10-c9235cc4abf1"),
},
            new GuidUUIDE0M
{
    Id = 172,
    Value = Guid.Parse("a2a3dfd8-72ef-4b08-8806-906df5a21e1f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 165,
    Value = Guid.Parse("067624d4-9a1b-4770-a4aa-d5e9c1f859bc"),
    NullableValue = null,
},
    NullableValue = null,
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


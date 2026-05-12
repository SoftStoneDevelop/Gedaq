

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
    Value = Guid.Parse("d44642d0-8c63-4c44-b708-64324a6dee55"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 9,
    Value = Guid.Parse("02d73cf4-d150-4d86-be04-7651319661db"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b089f166-9dcc-47b7-99a6-cd0425b32308"),
},
            new GuidUUIDE0M
{
    Id = 10,
    Value = Guid.Parse("de66010e-dcc5-4162-848f-4667c36f0e20"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 15,
    Value = Guid.Parse("73b0bc8c-92f9-49d5-9ed3-837478757f1a"),
    NullableValue = Guid.Parse("c5268b91-67c8-4c3a-a849-9ea1a4da8e93"),
},
    NullableValue = Guid.Parse("ef5bdc57-eac2-4ba8-95db-1e50c3c06d76"),
},
            new GuidUUIDE0M
{
    Id = 14,
    Value = Guid.Parse("caa41bb7-aded-48b1-8665-5fe32dd65843"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 23,
    Value = Guid.Parse("9befe65e-d96c-46bb-9c28-004af846afb8"),
    NullableValue = Guid.Parse("dcdd2fe4-04f1-4c0f-b9fc-13a279214e20"),
},
    NullableValue = Guid.Parse("50cd55d4-a454-4bec-9875-43ca64e9e1cc"),
},
            new GuidUUIDE0M
{
    Id = 22,
    Value = Guid.Parse("78bccf24-58d9-4905-aa3b-ad796b25b26f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 31,
    Value = Guid.Parse("0911d3f1-78a1-4c8f-aac2-600a211a968d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 31,
    Value = Guid.Parse("8b1b3e04-5fae-4201-ad7e-6754ef8bdcac"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 34,
    Value = Guid.Parse("6497be0a-4b70-4411-ae72-96e6711b3791"),
    NullableValue = Guid.Parse("44a556cb-1d60-4f69-834b-9e973dd96108"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 38,
    Value = Guid.Parse("0dd07a2a-7357-4c46-b12e-035e88387cfc"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 36,
    Value = Guid.Parse("322762af-03d8-4466-b625-c845f19feb40"),
    NullableValue = Guid.Parse("9b71427d-ed43-42fe-933c-0ac462500479"),
},
    NullableValue = Guid.Parse("84bcd755-9f5f-4e55-bef5-bf1a35f4b7f6"),
},
            new GuidUUIDE0M
{
    Id = 46,
    Value = Guid.Parse("13374977-147b-4bb7-9ffd-83caf0c4736b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 42,
    Value = Guid.Parse("6ae14b1d-432b-43cf-b8e8-5d3a47e4e22e"),
    NullableValue = Guid.Parse("ebf2171f-ab9b-494f-ae0a-db5f171bb7a4"),
},
    NullableValue = Guid.Parse("c5d0904e-23fe-4af1-98c2-b50841189f5c"),
},
            new GuidUUIDE0M
{
    Id = 51,
    Value = Guid.Parse("f565af49-782f-439c-b561-c668339e9563"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 51,
    Value = Guid.Parse("6c30635e-6119-4347-985c-9e9183e6b582"),
    NullableValue = Guid.Parse("3135bba3-ec60-4f22-af04-5b8f4629bfdd"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 59,
    Value = Guid.Parse("ea5b00d4-3e90-47b0-b1bb-8212c21d2456"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 55,
    Value = Guid.Parse("bbdd798e-ae35-4398-b01d-2e3bb52b8abd"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("aa74ac4c-a3c7-44f3-b5dd-2d6c2b1eee47"),
},
            new GuidUUIDE0M
{
    Id = 61,
    Value = Guid.Parse("e33b857f-b304-480b-8630-bbcbc1d56dd0"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 57,
    Value = Guid.Parse("499f1ca2-43d2-4163-8721-ff5c77409c0f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("3001fdff-0a10-4a5b-8805-6870a450f772"),
},
            new GuidUUIDE0M
{
    Id = 67,
    Value = Guid.Parse("3bb6c44e-ef6b-4af9-8e22-97fe613347a1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 60,
    Value = Guid.Parse("f5eb3cac-f9e8-4f74-84f6-3b1f079010a9"),
    NullableValue = Guid.Parse("b305dab6-31de-4023-a935-9a9b4b0a7527"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 68,
    Value = Guid.Parse("a053bfcf-233f-4afe-8873-0dbb08217885"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 65,
    Value = Guid.Parse("ac1c0388-8bcf-4057-9c34-5571a243254a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("68f07c3f-2c50-44d4-897a-7ed2b82347c7"),
},
            new GuidUUIDE0M
{
    Id = 72,
    Value = Guid.Parse("daa0e667-448d-404a-8bd6-915bc979ca65"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 72,
    Value = Guid.Parse("d54c010f-5eab-46c2-a1e2-e14863aa0c00"),
    NullableValue = Guid.Parse("4df09620-2421-43ad-a669-bf99d97d8c64"),
},
    NullableValue = Guid.Parse("8ab07029-e9ae-4422-9b53-5f1d38b6d46c"),
},
            new GuidUUIDE0M
{
    Id = 76,
    Value = Guid.Parse("056723c2-4005-4bff-9410-b23428f66d07"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 77,
    Value = Guid.Parse("b9186422-5f7d-4242-927f-2f990a5a3d5d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 80,
    Value = Guid.Parse("f9596bb0-437b-490c-af6f-b4fe55ded9b6"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 84,
    Value = Guid.Parse("9c280bea-4f94-49b9-8d9f-9f4ce28c1bc1"),
    NullableValue = Guid.Parse("8ea7ebd5-9424-499a-87d9-9156f8533944"),
},
    NullableValue = Guid.Parse("c156ffe4-2ae5-4dec-b38f-edb03bf9ba53"),
},
            new GuidUUIDE0M
{
    Id = 83,
    Value = Guid.Parse("9b241e84-a945-4365-991b-5bb003303b95"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 93,
    Value = Guid.Parse("ad860bbd-3892-48ab-b074-8b45859b7791"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ae29e3bc-d266-4db5-84bd-2bc6de75ce7a"),
},
            new GuidUUIDE0M
{
    Id = 89,
    Value = Guid.Parse("a59fc7a8-89ed-4c83-89fc-26e549f6cb0b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 100,
    Value = Guid.Parse("db6a22f4-d1a1-4331-8dc1-6aece7b716b3"),
    NullableValue = Guid.Parse("d84a8d6b-0733-4ff9-aef4-3ee305688704"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 94,
    Value = Guid.Parse("24f177db-db34-4525-9d83-97a73fce4155"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 105,
    Value = Guid.Parse("03c5efb5-ef9c-4f3a-8b00-5886b0eb7b98"),
    NullableValue = Guid.Parse("d93dd737-ac71-40cc-a2c9-5cbc32ddbd0e"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 99,
    Value = Guid.Parse("b13b3caa-c61b-4836-b5dd-a098e6cfd8fc"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 113,
    Value = Guid.Parse("ea7d1cd5-d163-45c1-b826-e8e4ca33058a"),
    NullableValue = Guid.Parse("6f711cd3-7ba3-4967-b0fd-658e8da8e26d"),
},
    NullableValue = Guid.Parse("5f7a2b24-5694-461a-9302-4ea5a0e58769"),
},
            new GuidUUIDE0M
{
    Id = 102,
    Value = Guid.Parse("f644f263-8079-4a74-9935-321e906985fd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 115,
    Value = Guid.Parse("104b2084-eb6d-4307-b85e-d606e8587e77"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d3951621-ce18-4236-8253-a3e7aa3644ce"),
},
            new GuidUUIDE0M
{
    Id = 106,
    Value = Guid.Parse("003afc82-d915-4fc5-bbf8-5c35062e0906"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 120,
    Value = Guid.Parse("7215ea94-5fa0-49dd-af8d-410c16b86c89"),
    NullableValue = Guid.Parse("03b601e0-80f0-4187-a8fe-3a0992f5f76e"),
},
    NullableValue = Guid.Parse("f0e72364-1e96-4a81-857d-cb7268fd18e4"),
},
            new GuidUUIDE0M
{
    Id = 110,
    Value = Guid.Parse("abdc8531-ccda-4123-bbb3-ebd6b7580f39"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 126,
    Value = Guid.Parse("dc3762ce-a268-4d3a-96a3-1dd4c002635e"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("23e13ea6-e261-4061-9c67-aeff1e3683fd"),
},
            new GuidUUIDE0M
{
    Id = 117,
    Value = Guid.Parse("274f72e2-6508-4b7a-96bc-e8f16b433cbc"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 127,
    Value = Guid.Parse("4dda0fd5-402b-4fc2-85b5-d3b97a31c4dd"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 122,
    Value = Guid.Parse("ae60bd9f-9c1b-4850-9685-8ecc72dd1a78"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 136,
    Value = Guid.Parse("5b926513-1553-4295-9610-f23b3d7667b1"),
    NullableValue = Guid.Parse("72d266c0-4775-42a9-a953-98f375a17eb6"),
},
    NullableValue = Guid.Parse("8b6fef5e-20b3-442a-9156-157b0bf65cb9"),
},
            new GuidUUIDE0M
{
    Id = 123,
    Value = Guid.Parse("3107f746-a096-4982-9bd7-1626bc998566"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 137,
    Value = Guid.Parse("9ef1b900-e84d-4d58-bd3e-a46b9041793e"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ac9615ca-263e-41cb-be89-d663d5a093a3"),
},
            new GuidUUIDE0M
{
    Id = 129,
    Value = Guid.Parse("be8d2141-059c-41e9-8cc1-b8192ebc430a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 144,
    Value = Guid.Parse("d6d61f25-f2f3-45a9-b010-9c0eeb48f7ff"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e096d611-049e-4989-9ec3-00b34d5d4f26"),
},
            new GuidUUIDE0M
{
    Id = 130,
    Value = Guid.Parse("0feb2e18-92d8-4f51-8ca4-a1eb62227c2f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 149,
    Value = Guid.Parse("0f5489dc-eff5-47a1-b780-51256dbb72ce"),
    NullableValue = Guid.Parse("d590c115-7488-4ad7-abf8-d615a4c12bfd"),
},
    NullableValue = Guid.Parse("b885a61a-0c64-421d-96b5-8a2462612387"),
},
            new GuidUUIDE0M
{
    Id = 138,
    Value = Guid.Parse("09dd05b2-0885-4ca8-b12b-f2a243d36bc6"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 158,
    Value = Guid.Parse("11d2518a-2ac8-43bc-884f-b642197ce27e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 144,
    Value = Guid.Parse("ac7e12c6-3509-42b8-a308-737c7f0a4fba"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 159,
    Value = Guid.Parse("d4eca9a4-907f-4ef9-93f5-ca5ba22f24b9"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f6d47477-8ae1-43a1-a53e-c15fb892e6b0"),
},
            new GuidUUIDE0M
{
    Id = 153,
    Value = Guid.Parse("dd31d25d-becc-455f-8cd6-580175024fbd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 162,
    Value = Guid.Parse("f017a0df-f699-4e38-9596-85c78dd67504"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 159,
    Value = Guid.Parse("9e792125-320a-4cd0-85f0-368e2afe4ef4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 164,
    Value = Guid.Parse("3d591714-0b5b-4f85-9c2e-e8bd1d09fe85"),
    NullableValue = Guid.Parse("93dd0f2b-df9c-4233-a5de-416584055e5c"),
},
    NullableValue = Guid.Parse("f7cce0fa-3938-4109-9ae8-e56f047967a3"),
},
            new GuidUUIDE0M
{
    Id = 165,
    Value = Guid.Parse("bfc8ca9b-2282-41c8-9576-c3c5c9f45674"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 172,
    Value = Guid.Parse("6df7ebb9-6d56-47f4-9f32-6d19406b49d9"),
    NullableValue = Guid.Parse("121f1c14-b4c7-477a-92ba-cd4f9d64fadc"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 172,
    Value = Guid.Parse("cabe3032-66e0-4b26-91bd-3d139b2a2f43"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 175,
    Value = Guid.Parse("9aac5c3d-fd3e-4bcf-89e1-6636626b4ada"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("fd193392-71db-4fbe-9dec-668fb1492128"),
},
            new GuidUUIDE0M
{
    Id = 180,
    Value = Guid.Parse("54c6d01d-0921-427b-9769-42ae0f4aea59"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 177,
    Value = Guid.Parse("89c7c906-e943-490d-8517-6f39afc1def3"),
    NullableValue = Guid.Parse("e55514b5-0cf1-443d-844c-cef406027bf9"),
},
    NullableValue = Guid.Parse("8b682fc0-6fe4-4ce9-93de-f80902a3b3ce"),
},
            new GuidUUIDE0M
{
    Id = 188,
    Value = Guid.Parse("4d4a4c17-08a0-4401-a525-d469c1d4db8e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 184,
    Value = Guid.Parse("327d032a-d174-45d1-bce5-3cc86004a5b9"),
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


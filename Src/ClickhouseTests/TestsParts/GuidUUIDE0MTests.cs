

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
    Value = Guid.Parse("ff0c19b1-c48f-4e57-ac64-7f9f01649f1c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 7,
    Value = Guid.Parse("24e125d4-b937-40cd-80b6-3ef1e9ebc4ec"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 5,
    Value = Guid.Parse("40e22255-50d2-47b0-a3ad-f39607aae555"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 10,
    Value = Guid.Parse("d17f0897-08e6-4206-b704-1502ca35b6d5"),
    NullableValue = Guid.Parse("afb32743-d761-4048-ac1c-381c6b92ff44"),
},
    NullableValue = Guid.Parse("5f5ae2bb-3a18-47c8-a526-2dc1324d2ea2"),
},
            new GuidUUIDE0M
{
    Id = 7,
    Value = Guid.Parse("d15ac71e-3617-444d-9061-17fc45d98a7e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 19,
    Value = Guid.Parse("02b716fb-3bed-48af-a73d-4820aefaee37"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 16,
    Value = Guid.Parse("e902065e-237a-4952-9c37-e3a9c1388bec"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 26,
    Value = Guid.Parse("f0f798ff-9a0f-4bed-bd64-7e81d0a5a024"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 17,
    Value = Guid.Parse("88e2ac36-0959-42e7-99f0-a65d5dcb7006"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 35,
    Value = Guid.Parse("b9a70998-af5d-49db-a1ad-7d1d1c4d13ab"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b41931cd-2453-42ae-96ce-b73f5c665d49"),
},
            new GuidUUIDE0M
{
    Id = 21,
    Value = Guid.Parse("77593c4a-5c32-4a7e-9a43-24475ca1d008"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 44,
    Value = Guid.Parse("17ca0e91-2e98-407f-bd7c-0d290f705264"),
    NullableValue = Guid.Parse("998a6122-2d2d-42ed-8b02-fc278ac54435"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 27,
    Value = Guid.Parse("d072860e-2886-43d8-82f5-02a631ca5b12"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 46,
    Value = Guid.Parse("79d34c66-24b6-4ab5-ad82-bcaf77f86cb9"),
    NullableValue = Guid.Parse("d2e316ca-d9d3-42b9-abeb-b396a29d5bec"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 35,
    Value = Guid.Parse("67d4731f-c359-4ddb-ab56-568eb20dfcb9"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 54,
    Value = Guid.Parse("a2f088f1-4e87-492a-b1df-b160293b6697"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 37,
    Value = Guid.Parse("3a597d1f-95a8-46b7-932f-fa67aeb0561a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 56,
    Value = Guid.Parse("b3452543-e07b-481c-96d5-4adeb5370ecf"),
    NullableValue = Guid.Parse("9fe568d1-0572-4a1e-a4c4-3c26fbcf13e3"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 40,
    Value = Guid.Parse("07592c05-5aec-46dc-9123-32335fc3ff08"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 61,
    Value = Guid.Parse("db01a7e6-e4d7-4309-9284-fca0f6bc006e"),
    NullableValue = Guid.Parse("4c68af74-dfcb-40be-86cf-58a750c386cc"),
},
    NullableValue = Guid.Parse("c7efb629-0997-452b-89ec-a15e1bb4a54f"),
},
            new GuidUUIDE0M
{
    Id = 45,
    Value = Guid.Parse("5ed0541e-4f8a-4b4b-a806-211fe2e7f83b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 62,
    Value = Guid.Parse("15ba345c-1981-4f63-8cc1-696a7034d4e3"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2ade2c99-8411-467f-a0dd-f7b6f89595fd"),
},
            new GuidUUIDE0M
{
    Id = 52,
    Value = Guid.Parse("a356a48b-57c3-4a7c-b64b-7124f4c93fc0"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 69,
    Value = Guid.Parse("b41ece3e-ec96-44ce-a843-2987e52e106e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 57,
    Value = Guid.Parse("6d5232d2-4752-4d64-af10-93294ca64b94"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 74,
    Value = Guid.Parse("9ebc9f87-b6d6-4742-905d-402076129b35"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ab603c9a-48e4-4476-9214-af904fdc5c67"),
},
            new GuidUUIDE0M
{
    Id = 64,
    Value = Guid.Parse("0b4dc221-07a2-4f5e-9f1a-976f12fb38cd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 77,
    Value = Guid.Parse("512efb9d-ec88-4374-bfb2-23d1bce459f9"),
    NullableValue = Guid.Parse("10686b94-6de0-4f67-b502-34a3c30e1d46"),
},
    NullableValue = Guid.Parse("0c098eb2-63da-4237-9089-8b9dcd79a441"),
},
            new GuidUUIDE0M
{
    Id = 70,
    Value = Guid.Parse("ea0a28f8-f817-42f3-840e-f46eef134ffe"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 82,
    Value = Guid.Parse("6ef441c6-d7b4-4170-b699-3cd564c9c6e1"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 79,
    Value = Guid.Parse("8695c3fd-10db-4097-a5f5-d36b5b44c65a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 87,
    Value = Guid.Parse("f8c46625-0833-45fe-a5d6-9e85178d196e"),
    NullableValue = Guid.Parse("35864c50-ff24-4433-b5ae-cdba2e34c592"),
},
    NullableValue = Guid.Parse("b0f29780-3f57-4122-9397-25318d3f3f7f"),
},
            new GuidUUIDE0M
{
    Id = 88,
    Value = Guid.Parse("49c94cee-baff-4ce3-bcc8-db066785be0d"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 88,
    Value = Guid.Parse("b71f5346-7df7-4ef0-aedb-d73dea7dbd56"),
    NullableValue = Guid.Parse("f5bbf527-7b1f-45de-a5a9-4c3183fddbac"),
},
    NullableValue = Guid.Parse("b32c5cdd-a097-457a-82f8-0c408770f266"),
},
            new GuidUUIDE0M
{
    Id = 97,
    Value = Guid.Parse("a7b00ed5-9ca4-415e-bda1-fb22e1ebf31d"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 96,
    Value = Guid.Parse("fa41f6cd-81a2-40e9-a7ed-b3f0fd257746"),
    NullableValue = Guid.Parse("027899cf-79e6-4ea9-8b50-aaf7bf79aace"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 105,
    Value = Guid.Parse("22ddadff-fc7d-400e-9204-f333cc9a3bc4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 100,
    Value = Guid.Parse("fafbe3d7-372c-4dea-be69-e6a64e4a44ff"),
    NullableValue = Guid.Parse("5e94c6d3-115f-49b4-b81f-5aa5c0c36796"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 112,
    Value = Guid.Parse("6042df5c-d284-47f3-bd90-f06dc197e318"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 105,
    Value = Guid.Parse("a01f104b-a4d5-4fc6-9954-b0fbbff92f01"),
    NullableValue = Guid.Parse("93061f8f-c1c7-46b7-af46-937d6c988c40"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 114,
    Value = Guid.Parse("2e620c5d-9716-4e72-acba-22505a981ee1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 111,
    Value = Guid.Parse("a5405065-973d-45ff-9452-47e5fffe92bd"),
    NullableValue = Guid.Parse("5c972851-0d60-453e-991e-0bfa5af8881d"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 119,
    Value = Guid.Parse("d5f2eb25-322e-46c1-b8bc-61bbba14de19"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 114,
    Value = Guid.Parse("d5a66d5f-f504-409c-bd41-220614ee2fee"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a84a2df4-b144-4c6c-b46a-22a61a000626"),
},
            new GuidUUIDE0M
{
    Id = 127,
    Value = Guid.Parse("9eb8f597-a63f-4708-8b79-8126cb62ea5c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 116,
    Value = Guid.Parse("f8762106-21f7-41c9-9a2d-62ffba1b1e2e"),
    NullableValue = Guid.Parse("6ad8d6d8-03e8-4f04-adfd-9985113ae3a3"),
},
    NullableValue = Guid.Parse("26b7941e-2feb-4607-a15c-86d81ab3801c"),
},
            new GuidUUIDE0M
{
    Id = 133,
    Value = Guid.Parse("1f3ce860-7986-415a-96c3-bd165931610e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 124,
    Value = Guid.Parse("82a0205b-2709-45fb-9549-54cb3774dc8b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 141,
    Value = Guid.Parse("b504d648-bc39-40c4-8aa8-e7794d422b86"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 128,
    Value = Guid.Parse("de3f0b59-b877-4d9d-b0e6-75c6f28296fb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("8d676414-8f13-46ca-9b80-9192ea20494c"),
},
            new GuidUUIDE0M
{
    Id = 149,
    Value = Guid.Parse("8d865278-9c08-4b1f-9447-4426a08a3df2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 134,
    Value = Guid.Parse("3cdd8eb9-0383-4735-ba39-bf0fee58eec5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c2f00747-7f36-42d1-8680-2dba2cb50bd2"),
},
            new GuidUUIDE0M
{
    Id = 154,
    Value = Guid.Parse("b87c100e-75c5-4280-9b2d-0c51e90c8556"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 135,
    Value = Guid.Parse("57d6e8da-eac3-45bb-9798-062e80ccc3c4"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 155,
    Value = Guid.Parse("a4532843-8aa4-4aef-8abb-f279f6cc6df8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 138,
    Value = Guid.Parse("bb758792-c687-4010-8649-8a188b237503"),
    NullableValue = Guid.Parse("cd6f3099-218a-4718-8af0-56d6a6958622"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 156,
    Value = Guid.Parse("cc7d8eb7-d6c2-4070-8d7a-685ba44a47e5"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 143,
    Value = Guid.Parse("9b87f2b4-c83b-4711-8b97-b634f3bdb2c1"),
    NullableValue = Guid.Parse("d03e8735-909c-4a1e-a144-4aa04e8c21ad"),
},
    NullableValue = Guid.Parse("4234c38e-9acd-4884-8297-61c89750be29"),
},
            new GuidUUIDE0M
{
    Id = 162,
    Value = Guid.Parse("ab77d8fb-b40f-425f-a58f-b388448834bd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 149,
    Value = Guid.Parse("f7811cbb-9f3b-43e1-9e7a-6bba6ccdfe73"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 169,
    Value = Guid.Parse("b23ee712-ecbd-4496-a6d1-7f6439b93bbf"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 151,
    Value = Guid.Parse("52b7d22c-4a0d-4ef9-9d47-498e1a504546"),
    NullableValue = Guid.Parse("c9fa4416-28fb-469d-b18c-ede59d392d07"),
},
    NullableValue = Guid.Parse("b7251268-3ac2-424e-b2bb-764438b9beac"),
},
            new GuidUUIDE0M
{
    Id = 178,
    Value = Guid.Parse("58d6416f-00f8-4f7d-a054-885b73cf5a51"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 153,
    Value = Guid.Parse("ef1b0d68-628d-41d1-97f1-752249601fed"),
    NullableValue = Guid.Parse("552affb3-a4b7-48e9-a16f-0897a78b15d4"),
},
    NullableValue = Guid.Parse("469a2c1e-d52a-43ef-8679-5ebd035178d4"),
},
            new GuidUUIDE0M
{
    Id = 181,
    Value = Guid.Parse("601ec843-9e74-49ae-84a6-7a7938a5a3da"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 160,
    Value = Guid.Parse("f40b5639-bbd1-475c-8c8d-b2de53e7ddd5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d63e8a1e-afdd-42c2-ad53-5f6009899ac5"),
},
            new GuidUUIDE0M
{
    Id = 190,
    Value = Guid.Parse("e4f9c6bd-7c77-4d2f-bad8-f5f6a3d73528"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 161,
    Value = Guid.Parse("b14598b2-1a69-47a1-8cde-0afc47079838"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 191,
    Value = Guid.Parse("8ae710d2-3bba-4b77-8fca-3d0e8dbb121e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 170,
    Value = Guid.Parse("8cdb8dec-b2b9-409b-a7e6-b2712adcf0a1"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("5c901f9b-7e2a-4aeb-8066-f67f90ccfcf9"),
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


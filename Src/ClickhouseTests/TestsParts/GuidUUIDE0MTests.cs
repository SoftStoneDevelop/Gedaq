

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
    Id = 7,
    Value = Guid.Parse("f3663222-c30c-4269-8ad1-0458fe4e3ca2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 7,
    Value = Guid.Parse("9c1d48b8-769d-45eb-bb9c-9f2c82197a0b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 10,
    Value = Guid.Parse("a11bc9c9-46bb-4d9e-90ec-be431b0fae36"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 13,
    Value = Guid.Parse("3a7eafab-3241-49f9-89b9-8bd2389f3e1f"),
    NullableValue = Guid.Parse("706fe597-66c1-4782-8f32-271f134020db"),
},
    NullableValue = Guid.Parse("3810bc33-3182-43bb-b189-540f09d620e8"),
},
            new GuidUUIDE0M
{
    Id = 11,
    Value = Guid.Parse("73fd88f1-202f-4574-ae12-f5ac6fe5ad13"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 18,
    Value = Guid.Parse("7faf0cd3-1934-42df-8de1-c49e5a6b21fb"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 20,
    Value = Guid.Parse("1fd68275-b103-4e5b-9dd8-a9cbb20de410"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 21,
    Value = Guid.Parse("18b7fd95-0805-4caa-8e55-47188fbdad3a"),
    NullableValue = Guid.Parse("05a52660-8b31-431a-ae3a-d47e4e404085"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 26,
    Value = Guid.Parse("532598be-fbb7-43d7-92ce-0a1c3b308687"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 30,
    Value = Guid.Parse("4c1882b0-9bdb-428a-b682-b81c818e438b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 35,
    Value = Guid.Parse("bbea9053-6f8b-4509-8e1a-dd366d7537f2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 35,
    Value = Guid.Parse("536c35c8-f7e9-4f63-8329-2f48d1429c3b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("98bf5b3a-a3b1-4bf6-935d-94950e75ceb5"),
},
            new GuidUUIDE0M
{
    Id = 37,
    Value = Guid.Parse("40f7614b-21e0-4314-a01a-9b262ace51bb"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 39,
    Value = Guid.Parse("15be8b86-7c39-452b-bf1c-2214292f0fa8"),
    NullableValue = Guid.Parse("39358247-fa03-4192-8984-815ec927f480"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 43,
    Value = Guid.Parse("128073d6-4966-450a-8d88-547176f72afb"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 45,
    Value = Guid.Parse("aa0bb01e-8bc7-4107-86d1-a80140cb47da"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("54579f89-721e-4799-8480-42e4d85a6cc1"),
},
            new GuidUUIDE0M
{
    Id = 46,
    Value = Guid.Parse("159d1815-d64f-45f7-a208-78a6fa84f6a9"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 46,
    Value = Guid.Parse("247fbdbd-8178-45af-9f9e-6db4e9cc64a3"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("41e82329-f407-4a47-854a-e53cdb719719"),
},
            new GuidUUIDE0M
{
    Id = 48,
    Value = Guid.Parse("154ab945-3192-44a1-9e1d-d48cbc1802b2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 51,
    Value = Guid.Parse("81f29971-de76-41cb-8c91-104bf4235394"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("aa7eccf3-0687-458b-9bda-b7b8ad76aa57"),
},
            new GuidUUIDE0M
{
    Id = 56,
    Value = Guid.Parse("65cd10c2-4653-4957-9d95-c2117284b395"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 56,
    Value = Guid.Parse("a3a856d6-f6d9-43ba-a1c5-17433d7a9de3"),
    NullableValue = Guid.Parse("e7ff8eee-0682-45cf-935e-21767aa8494c"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 60,
    Value = Guid.Parse("595a2847-60bc-49df-8c25-4071ff7cf7e3"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 64,
    Value = Guid.Parse("6fbb1d9e-08cd-4695-9769-e2d7de6b5cef"),
    NullableValue = Guid.Parse("b607c1c6-0f5b-42a7-9d02-3fa6c4192ccf"),
},
    NullableValue = Guid.Parse("336c658a-29b3-4531-b986-faf7f4353757"),
},
            new GuidUUIDE0M
{
    Id = 63,
    Value = Guid.Parse("1b3eb362-cec5-489f-95e0-b021e7d63843"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 70,
    Value = Guid.Parse("696d4a06-945a-465c-83de-ebd9a249d31f"),
    NullableValue = Guid.Parse("d2226d41-de4b-4a2d-a86f-87a8f65a1847"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 70,
    Value = Guid.Parse("fb8e8d7f-8383-40c1-9a6e-4053692e4c5c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 71,
    Value = Guid.Parse("c4274e54-3419-4c09-b503-91fa50cf30e4"),
    NullableValue = Guid.Parse("22878cd1-9b8a-4f15-bb5e-0dc7dadfa472"),
},
    NullableValue = Guid.Parse("446489e5-3c2e-47b1-90ae-caafad38b63d"),
},
            new GuidUUIDE0M
{
    Id = 78,
    Value = Guid.Parse("eed9d5fd-a4e6-40ef-a004-c98fd805c4a3"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 76,
    Value = Guid.Parse("fe946af7-f319-49a2-847b-fb2d24e3f4cf"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e8c90fdc-1cba-41e4-91eb-5186c5767b96"),
},
            new GuidUUIDE0M
{
    Id = 85,
    Value = Guid.Parse("5e2e4d3b-a57d-4b02-b68a-ebc718ab4435"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 78,
    Value = Guid.Parse("28d9e81d-3990-4f10-9ab5-75910d5be5a2"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f5788d1f-bbad-4180-b398-df85b3f9765e"),
},
            new GuidUUIDE0M
{
    Id = 92,
    Value = Guid.Parse("2036a125-e706-4d82-ac83-cd06ccb3d767"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 80,
    Value = Guid.Parse("aae0033c-796f-491d-b23b-df4fcd1d0efd"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 101,
    Value = Guid.Parse("8511e952-05c2-4bce-b2cd-1ec11051f01e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 83,
    Value = Guid.Parse("574c33ed-e9b4-4aac-a0ff-9e0d22c8ce7b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b078f0bb-7385-4df3-ae4f-59995fd061e9"),
},
            new GuidUUIDE0M
{
    Id = 107,
    Value = Guid.Parse("e44bba62-4853-4c6d-be47-bf0bfebf2e82"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 89,
    Value = Guid.Parse("1cd74b0e-9507-4bf7-b33c-64c78cf8adb8"),
    NullableValue = Guid.Parse("988ed2d2-a005-44a1-b8c4-b35ef017d036"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 110,
    Value = Guid.Parse("ef7cfc88-ad8a-4dae-8c68-d1f7dd4cfedf"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 94,
    Value = Guid.Parse("96d909a8-da52-45d5-a521-ab7b2e1d75e3"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 112,
    Value = Guid.Parse("2141aa10-5cc1-4bdd-b958-44f9e0c4290a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 97,
    Value = Guid.Parse("af2f1752-9982-4821-bd8a-4d9818918728"),
    NullableValue = Guid.Parse("ee3a5370-8b5d-4525-92d6-0697e5de16e9"),
},
    NullableValue = Guid.Parse("17124f55-169b-41b7-b807-e6bfb78d72cc"),
},
            new GuidUUIDE0M
{
    Id = 120,
    Value = Guid.Parse("8761ad76-6196-410b-8c22-97c26f3b4180"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 103,
    Value = Guid.Parse("b2723483-2508-428c-a3f2-5f191800deeb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("55b4e237-c85f-4742-9698-6e471c5488d9"),
},
            new GuidUUIDE0M
{
    Id = 128,
    Value = Guid.Parse("c2f3a738-9c32-4cec-a33f-3ec822c18c8b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 110,
    Value = Guid.Parse("c65821d1-82ef-49af-8a26-b89955c40097"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 129,
    Value = Guid.Parse("c4adadc9-1f4a-485d-b998-9bccaf62cc6a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 115,
    Value = Guid.Parse("e6622eeb-a2e4-47ae-8c9f-97c1b4a92eee"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e20d7116-414f-4372-abf7-57f264cc97d4"),
},
            new GuidUUIDE0M
{
    Id = 137,
    Value = Guid.Parse("6a8f6433-edd9-434b-b3af-49a552ac97b8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 122,
    Value = Guid.Parse("0bb8cca1-3e94-490b-9601-21c18b4dcf38"),
    NullableValue = Guid.Parse("7b3059a4-48a3-4a46-b517-75bdb8453a78"),
},
    NullableValue = Guid.Parse("cd39f23b-51b1-4ae1-b9a6-865193a01a4e"),
},
            new GuidUUIDE0M
{
    Id = 139,
    Value = Guid.Parse("157509f0-cabf-4d2e-a310-507915dc3225"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 130,
    Value = Guid.Parse("e53b8c37-cb74-450f-b94d-515b05390978"),
    NullableValue = Guid.Parse("00b0d952-e038-4dd8-9942-27b4bb5f2e08"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 148,
    Value = Guid.Parse("0a182d82-79e2-4121-be5a-138a097e09d7"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 133,
    Value = Guid.Parse("40c5a01a-9f89-4731-872f-0c226bd61301"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("97305f9a-87f0-4aeb-9ffd-99fe92afd6a2"),
},
            new GuidUUIDE0M
{
    Id = 155,
    Value = Guid.Parse("810d8a27-bd0a-4982-bdf9-b66fb58337e9"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 140,
    Value = Guid.Parse("93bc420a-12a0-4328-b405-e76d0e3108f9"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 159,
    Value = Guid.Parse("92ac5b7a-a497-49c4-b14f-52dbf8bcf6c7"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 144,
    Value = Guid.Parse("57c55bd7-8e78-4881-bb51-3e2ca5ef76f7"),
    NullableValue = Guid.Parse("63667f10-58a3-49cb-97d9-0f2accb1d151"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 162,
    Value = Guid.Parse("0bf128b8-7b37-4f72-a845-409829b14ad0"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 146,
    Value = Guid.Parse("bea76364-e32c-45e7-89e5-2bd16f4806b3"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 164,
    Value = Guid.Parse("14e70701-5503-4b00-a1f8-78d692db1266"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 150,
    Value = Guid.Parse("4e251266-c5ef-49ad-9b44-39026ecb8f54"),
    NullableValue = Guid.Parse("b39812ed-e8ce-475d-b663-1be27e75a7ea"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 171,
    Value = Guid.Parse("2a56646a-3213-46d4-8a2d-7756065307ce"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 151,
    Value = Guid.Parse("81b93460-dba3-4ca1-b5bd-cc7f682a5bbc"),
    NullableValue = Guid.Parse("60f11c15-3299-4758-916c-e2e185b99ba7"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 179,
    Value = Guid.Parse("d786c1fa-847a-4bae-8fd5-4c02a8b49aa8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 157,
    Value = Guid.Parse("6c83e567-7ff4-4ef2-9748-d2b6f6536071"),
    NullableValue = Guid.Parse("dcf44bfd-1aa7-4cea-bd8f-3bf6bff6cb6b"),
},
    NullableValue = Guid.Parse("6498155b-75b6-4893-9e8a-fb4695770810"),
},
            new GuidUUIDE0M
{
    Id = 187,
    Value = Guid.Parse("2eb50e92-c12a-4b25-b9d9-924740288565"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 163,
    Value = Guid.Parse("1275f416-fa84-4f28-a121-23fc4b8f3932"),
    NullableValue = Guid.Parse("81be9d83-3472-4810-9d8c-fd7078b76553"),
},
    NullableValue = Guid.Parse("e4084fc4-9c72-4cad-932c-dbc63aebd005"),
},
            new GuidUUIDE0M
{
    Id = 191,
    Value = Guid.Parse("a5e53832-1501-4e94-9cff-df399f17efbd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 168,
    Value = Guid.Parse("3ecf7275-8a09-4b33-b899-b0d0caba9a47"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c1ddb2fd-47fb-47bb-b9e4-5b66bf6f2745"),
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


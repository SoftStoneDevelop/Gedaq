

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
    Id = 3,
    Value = Guid.Parse("1e426124-3397-4b4e-b07e-1c8150f16a22"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 1,
    Value = Guid.Parse("aaaca842-2e66-495a-9a40-3596642f2b6c"),
    NullableValue = Guid.Parse("c719e373-2be0-42e5-af39-193d982b2fac"),
},
    NullableValue = Guid.Parse("b60069d9-00b2-4277-b7e7-a40bb172fe05"),
},
            new GuidUUIDE0M
{
    Id = 4,
    Value = Guid.Parse("0c101577-3f22-48b6-b10f-9db0faa9c172"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 6,
    Value = Guid.Parse("04fa00db-4518-4d1b-835e-ec777d2bbbb6"),
    NullableValue = Guid.Parse("94132f8b-a5b2-4893-9c9f-feb67919745d"),
},
    NullableValue = Guid.Parse("2ed0675d-cbf8-432d-b824-42f0c19f2fa9"),
},
            new GuidUUIDE0M
{
    Id = 13,
    Value = Guid.Parse("6182be26-6a16-4370-aa81-e5e66f3ea326"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 13,
    Value = Guid.Parse("fb7f4874-e390-43c3-9f55-09f61c4e2ed3"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("93020a55-df5f-444b-8bf2-be1855e38283"),
},
            new GuidUUIDE0M
{
    Id = 15,
    Value = Guid.Parse("494d6de3-0436-4e3d-8faa-ad4bb3f01de6"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 15,
    Value = Guid.Parse("9fb42cd5-6669-44d0-9564-5d89d2878cf4"),
    NullableValue = Guid.Parse("6a2d5358-e4a6-4b67-96eb-f76bbfb047c0"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 18,
    Value = Guid.Parse("8e82e15d-3b40-4602-b87e-d2d35bde276f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 22,
    Value = Guid.Parse("bd4331ba-6398-4925-86c6-d9ac69fc156e"),
    NullableValue = Guid.Parse("3411f1f6-2253-4926-a0e2-df56f1139ac8"),
},
    NullableValue = Guid.Parse("d756f40f-078e-4247-b2c1-14c166d81fc5"),
},
            new GuidUUIDE0M
{
    Id = 25,
    Value = Guid.Parse("d876baa1-9bcd-4c57-8db6-e7692a0ae0f1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 27,
    Value = Guid.Parse("2995c755-616f-4e23-88a7-9dad363e82ea"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 26,
    Value = Guid.Parse("b9896303-69f2-4d87-aa4a-b633b07dc7d8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 33,
    Value = Guid.Parse("b1c8490b-082c-40e7-8a52-90ac18eb96af"),
    NullableValue = Guid.Parse("933d93b6-c045-41d6-afa7-d2d350c308e6"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 34,
    Value = Guid.Parse("f0fccdfc-0e54-4b38-955d-c0d3e46a4767"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 39,
    Value = Guid.Parse("f75f2376-74ed-48cd-abd2-eea48d680210"),
    NullableValue = Guid.Parse("37a5ee04-7749-486c-aa1d-b14ae5f30be5"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 42,
    Value = Guid.Parse("3856de4d-34d6-4d3c-baca-c888a2ec6af4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 43,
    Value = Guid.Parse("ca5a802c-f277-4c3f-abd0-d3b463d371c1"),
    NullableValue = Guid.Parse("dbe47488-5a32-435d-85d8-35af1ca76830"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 44,
    Value = Guid.Parse("d3757802-fbfa-4115-bcc9-dfe211438ffd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 46,
    Value = Guid.Parse("cf12cfe4-31d7-42ff-9c30-2ee00525f1fd"),
    NullableValue = Guid.Parse("32c11d47-3c1a-4dc8-8e4d-4bb15fe59a85"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 50,
    Value = Guid.Parse("f5581a6a-5d80-4faf-a9a0-abf2962025a4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 50,
    Value = Guid.Parse("b792c010-1f3f-446b-8ca9-3dd45eb3b8f5"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 55,
    Value = Guid.Parse("5eb17d3c-95e2-4ff0-9284-3205d17595b2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 53,
    Value = Guid.Parse("ad8193fc-bc9e-4a97-a73d-ad39c72bbd10"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 58,
    Value = Guid.Parse("31070a99-c3bf-45ea-b045-da6454a96f3d"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 56,
    Value = Guid.Parse("2c6c8fce-6c67-4e5b-90cc-caa376bbe71f"),
    NullableValue = Guid.Parse("30ea4ef3-fcb6-4b20-abe1-da9dafcecde9"),
},
    NullableValue = Guid.Parse("46a84d64-1fd0-4380-945f-93c19932c860"),
},
            new GuidUUIDE0M
{
    Id = 60,
    Value = Guid.Parse("3b1dea76-cb21-4b73-9fb1-a11ec22faefa"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 65,
    Value = Guid.Parse("6b980afd-4d58-47b2-9cfd-546b65343f20"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("052231a2-6aa0-4beb-b47f-c436bb05a830"),
},
            new GuidUUIDE0M
{
    Id = 64,
    Value = Guid.Parse("e7dba2ba-5810-42fc-b0c8-12b4e2d63de5"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 70,
    Value = Guid.Parse("dd4c3546-fa38-4d96-887a-bb73e32edf2a"),
    NullableValue = Guid.Parse("ca738d0f-d042-4b8c-8bf8-63fd9cd5b334"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 70,
    Value = Guid.Parse("18847329-a68c-4d04-9b2b-5c6b549ad221"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 74,
    Value = Guid.Parse("bc252531-8e69-4957-9382-ca91aad06e4b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 77,
    Value = Guid.Parse("b16280a3-7af5-4037-831e-23478badf96c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 79,
    Value = Guid.Parse("ae295817-6e0a-45f9-b9f3-5e6a3598301c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0e5eb031-8937-4cd4-82f8-95eb5bab7cc9"),
},
            new GuidUUIDE0M
{
    Id = 80,
    Value = Guid.Parse("62b82302-fe4b-45bd-97cd-c356810eda7c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 81,
    Value = Guid.Parse("c692e863-4659-4e7f-b653-248682206e43"),
    NullableValue = Guid.Parse("a4f50f90-43e6-475c-935e-b1b852d2a6b3"),
},
    NullableValue = Guid.Parse("af92ffdc-9a40-4a68-b5da-0821257080d6"),
},
            new GuidUUIDE0M
{
    Id = 84,
    Value = Guid.Parse("d7ee7439-3e33-4ce1-aad3-0783ac0d6273"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 85,
    Value = Guid.Parse("8c1be218-8bfa-457c-86a4-04ff951e323b"),
    NullableValue = Guid.Parse("3e50823e-e066-4b8a-b231-305a67531241"),
},
    NullableValue = Guid.Parse("fc441560-3c6a-4065-984e-8de6591cb33d"),
},
            new GuidUUIDE0M
{
    Id = 92,
    Value = Guid.Parse("08a23379-431e-45c9-927b-e21e6f126bf2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 88,
    Value = Guid.Parse("838d7a9e-508d-498e-bf71-961d522fd22a"),
    NullableValue = Guid.Parse("279f85f5-7e57-4163-bf7b-0807900bcfe2"),
},
    NullableValue = Guid.Parse("45ed349e-513e-4037-9caa-6125a84714ad"),
},
            new GuidUUIDE0M
{
    Id = 96,
    Value = Guid.Parse("6a6f975f-4d00-4819-a55d-c29851a3f202"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 90,
    Value = Guid.Parse("d5b5e4c3-046e-48dc-9077-5df4f7f25580"),
    NullableValue = Guid.Parse("0d0143f9-83ef-4171-b5e2-04f390626b48"),
},
    NullableValue = Guid.Parse("7bbe5527-ad2b-432c-b9fb-5bfce1a8e8e1"),
},
            new GuidUUIDE0M
{
    Id = 98,
    Value = Guid.Parse("9ab31970-5d81-4e08-a74b-643e4753bd0b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 96,
    Value = Guid.Parse("c2135e92-5f56-42ee-8e07-a72ab75105a4"),
    NullableValue = Guid.Parse("d979c4eb-8469-4c57-8dab-7a136044f169"),
},
    NullableValue = Guid.Parse("a41ed0ac-391d-4fa9-b066-970ba2958d64"),
},
            new GuidUUIDE0M
{
    Id = 106,
    Value = Guid.Parse("a5b649b5-6dbc-40cf-b1af-3d4cbb522b14"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 104,
    Value = Guid.Parse("3a60d57f-9008-454f-9043-1ef2e9bd66d9"),
    NullableValue = Guid.Parse("29637c1d-9fa0-447f-9928-717177fe3db4"),
},
    NullableValue = Guid.Parse("2f0ba83d-dc10-472d-9118-2e012e79ab01"),
},
            new GuidUUIDE0M
{
    Id = 115,
    Value = Guid.Parse("ef97c678-47b2-4241-8ce0-69f6228957d2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 106,
    Value = Guid.Parse("cb40fa38-60be-4bfe-bc9c-005393c8e037"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("3b932c6e-0b8f-4262-b73c-27830d591b27"),
},
            new GuidUUIDE0M
{
    Id = 121,
    Value = Guid.Parse("39d66662-c215-4852-8af4-cdfe3eaa2dc6"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 107,
    Value = Guid.Parse("a9e07330-ffec-4cca-9f3f-e0bf00c9e695"),
    NullableValue = Guid.Parse("2d0875c2-83a9-4e41-b543-43060e5c5046"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 126,
    Value = Guid.Parse("e8e1e746-0a7f-4ac4-8ddd-f3d6dcd7f88f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 113,
    Value = Guid.Parse("339fd5a8-e76f-42b7-a718-8dc6b41b2d1a"),
    NullableValue = Guid.Parse("3b2efd25-81b7-4249-b595-afd18d38bf28"),
},
    NullableValue = Guid.Parse("194e933c-d437-4cae-95eb-11e84c3d96a6"),
},
            new GuidUUIDE0M
{
    Id = 129,
    Value = Guid.Parse("82f7ad62-4370-4eca-9a30-6ea1710a63b0"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 120,
    Value = Guid.Parse("5ccfe239-b1ac-4dc2-9323-34dfbc192ca5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b270dbb3-101d-4dee-bcfa-1dec25e07f77"),
},
            new GuidUUIDE0M
{
    Id = 135,
    Value = Guid.Parse("d49d54c6-995f-4287-90fe-513a44bda2bd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 129,
    Value = Guid.Parse("8e04c21a-a780-4eac-b4df-d9dd297157e0"),
    NullableValue = Guid.Parse("419985a9-43a5-42fa-92af-9d72d54375fd"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 140,
    Value = Guid.Parse("3e2ef608-aa51-44bb-968f-88e066f13bcd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 135,
    Value = Guid.Parse("cd12b4fd-dea8-437f-9566-def3122c98f6"),
    NullableValue = Guid.Parse("d67417b7-e703-43a6-9a11-e5ae6dec6dc6"),
},
    NullableValue = Guid.Parse("8183f4f9-f3ea-4bf5-b7a2-15c9d2f1e290"),
},
            new GuidUUIDE0M
{
    Id = 142,
    Value = Guid.Parse("27dd8d0b-8e61-46cc-a91f-766aeac5d5e5"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 144,
    Value = Guid.Parse("649c4b54-9033-4e32-8b54-77a6fedd13ca"),
    NullableValue = Guid.Parse("ae13c197-9d12-4459-b269-bfffa2fa868b"),
},
    NullableValue = Guid.Parse("af50062a-3bd8-4890-9b19-5d309d206b53"),
},
            new GuidUUIDE0M
{
    Id = 145,
    Value = Guid.Parse("032479e7-24d7-4872-9883-133680b03c5e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 152,
    Value = Guid.Parse("a8f00571-e7d8-49aa-9253-2e7f9d01f7cb"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 150,
    Value = Guid.Parse("9b7276b3-bd52-41d6-93bd-349f422286bb"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 155,
    Value = Guid.Parse("86271f9a-22ab-4225-8a33-b88f5828d033"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 156,
    Value = Guid.Parse("b4488d54-ce94-40d3-b1ef-1802ec2164c8"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 159,
    Value = Guid.Parse("6ce63c5f-0d97-44f9-8ace-c2cc51c803ea"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 163,
    Value = Guid.Parse("ff3f0553-7c9c-41fd-95c2-4c07159cee36"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 161,
    Value = Guid.Parse("4f89b80f-dde4-4a86-ad50-5a640313cc8d"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("156d6f42-8e58-46b9-9637-2083a2d650b3"),
},
            new GuidUUIDE0M
{
    Id = 164,
    Value = Guid.Parse("585202ce-2dbd-4fda-832a-b2052bb4e513"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 162,
    Value = Guid.Parse("9d72343a-b6b2-4ebe-bd02-bfffb485a8b9"),
    NullableValue = Guid.Parse("a0ccbd9f-0276-41f7-9c0a-24c8cab63b35"),
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


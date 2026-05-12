

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

        private readonly Guidv7UUIDE0M[] _testData = new Guidv7UUIDE0M[]
        {
            new Guidv7UUIDE0M
{
    Id = 2,
    Value = Guid.Parse("019e1b45-9082-7abd-bd43-466f987b2e4e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 1,
    Value = Guid.Parse("019e1b45-9082-745a-a209-efdba4cadb25"),
    NullableValue = Guid.Parse("019e1b45-9082-7ba5-964b-d0d961a2044e"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7bcf-a3a8-219e94b27bfd"),
},
            new Guidv7UUIDE0M
{
    Id = 3,
    Value = Guid.Parse("019e1b45-9082-72fb-bc24-477054824325"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 5,
    Value = Guid.Parse("019e1b45-9082-7367-9076-72b965032c0b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 7,
    Value = Guid.Parse("019e1b45-9082-76c2-b1cb-f9e08616c860"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 8,
    Value = Guid.Parse("019e1b45-9082-7fb3-af2c-6126ade6c775"),
    NullableValue = Guid.Parse("019e1b45-9082-710c-9eb0-ca83dadb2c39"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 13,
    Value = Guid.Parse("019e1b45-9082-72e4-822b-1011ed277879"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 14,
    Value = Guid.Parse("019e1b45-9082-7010-9eba-26280794504c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9082-7b8b-a0cb-49ae74d8b8f7"),
},
            new Guidv7UUIDE0M
{
    Id = 22,
    Value = Guid.Parse("019e1b45-9082-7d0f-810a-a33b6604459d"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 21,
    Value = Guid.Parse("019e1b45-9082-7a4c-bbb4-860e7028522c"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 24,
    Value = Guid.Parse("019e1b45-9082-730f-83dc-96883fbc890b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 28,
    Value = Guid.Parse("019e1b45-9082-7770-bc5b-c43069043161"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9082-7321-9d62-9b2c4dd408ac"),
},
            new Guidv7UUIDE0M
{
    Id = 29,
    Value = Guid.Parse("019e1b45-9082-7185-bf1a-a8ecc04c70c4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 34,
    Value = Guid.Parse("019e1b45-9082-7910-b723-a28908df9a02"),
    NullableValue = Guid.Parse("019e1b45-9082-7548-aa44-ec726eaf6e6c"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7923-8020-2dc9f3578a61"),
},
            new Guidv7UUIDE0M
{
    Id = 30,
    Value = Guid.Parse("019e1b45-9082-7f9c-b45a-0e3eb534a931"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 41,
    Value = Guid.Parse("019e1b45-9082-70ef-a3d8-64ac302669a9"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9082-7ce1-98ec-e3134e6adff6"),
},
            new Guidv7UUIDE0M
{
    Id = 35,
    Value = Guid.Parse("019e1b45-9082-708b-89ce-d8274337f783"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 43,
    Value = Guid.Parse("019e1b45-9082-717e-91be-c9cd81374d52"),
    NullableValue = Guid.Parse("019e1b45-9082-7a7d-b781-1d1f201c5cbc"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 38,
    Value = Guid.Parse("019e1b45-9082-7af9-8ed4-727da59a12db"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 51,
    Value = Guid.Parse("019e1b45-9082-7fed-9b06-660392531a42"),
    NullableValue = Guid.Parse("019e1b45-9082-78e2-857b-9468eeb9c9ca"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7a1e-acaf-a2d131343763"),
},
            new Guidv7UUIDE0M
{
    Id = 46,
    Value = Guid.Parse("019e1b45-9082-7278-9aa7-47e93220900b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 54,
    Value = Guid.Parse("019e1b45-9082-7451-a53c-03b1d52b15af"),
    NullableValue = Guid.Parse("019e1b45-9082-7475-951a-9d12a6a5b0cb"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7aea-8d30-76e5bce7e947"),
},
            new Guidv7UUIDE0M
{
    Id = 49,
    Value = Guid.Parse("019e1b45-9082-7c4b-b73d-1b96b3ead2a0"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 59,
    Value = Guid.Parse("019e1b45-9082-7cf1-a171-cd7bf8a9e575"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9082-777a-baac-c6061d9e8669"),
},
            new Guidv7UUIDE0M
{
    Id = 52,
    Value = Guid.Parse("019e1b45-9082-7501-8ff2-8f512f4cc692"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 62,
    Value = Guid.Parse("019e1b45-9082-7850-bcf6-48a5aac54245"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9082-71ef-a6ca-6d1ed12f964f"),
},
            new Guidv7UUIDE0M
{
    Id = 61,
    Value = Guid.Parse("019e1b45-9082-7d7a-b3b2-e90f79df7fa4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 67,
    Value = Guid.Parse("019e1b45-9082-76bb-84ba-03a7fbdf1a79"),
    NullableValue = Guid.Parse("019e1b45-9082-751b-b816-3375f8a80304"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7abb-8b58-7be840636e0d"),
},
            new Guidv7UUIDE0M
{
    Id = 70,
    Value = Guid.Parse("019e1b45-9082-70e3-854b-7b171e19c0c2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 68,
    Value = Guid.Parse("019e1b45-9082-7a6f-9335-707daeb6b93d"),
    NullableValue = Guid.Parse("019e1b45-9082-7544-a157-83ad4439d913"),
},
    NullableValue = Guid.Parse("019e1b45-9082-79d4-bbb1-c62ef536c0a6"),
},
            new Guidv7UUIDE0M
{
    Id = 72,
    Value = Guid.Parse("019e1b45-9082-7a02-958d-89c46dfdc312"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 75,
    Value = Guid.Parse("019e1b45-9082-745c-adfd-297145ec115c"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 77,
    Value = Guid.Parse("019e1b45-9082-76c8-a5d4-939a6aad3412"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 81,
    Value = Guid.Parse("019e1b45-9082-7939-b1e1-c0d837e6c4a6"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 85,
    Value = Guid.Parse("019e1b45-9082-7307-8dcb-96039a6248ce"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 87,
    Value = Guid.Parse("019e1b45-9082-779f-9c11-a767674b9223"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 89,
    Value = Guid.Parse("019e1b45-9082-764a-9287-f0b23868f512"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 95,
    Value = Guid.Parse("019e1b45-9082-714d-8cef-2f1854c8f2e1"),
    NullableValue = Guid.Parse("019e1b45-9082-73ac-80f9-586f760369e7"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7a75-8d60-392eaebcb6ef"),
},
            new Guidv7UUIDE0M
{
    Id = 97,
    Value = Guid.Parse("019e1b45-9082-785a-b669-e199baf39a24"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 97,
    Value = Guid.Parse("019e1b45-9082-7e8b-9aaf-d40716c10a39"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9082-79f5-b047-890ff42b19cf"),
},
            new Guidv7UUIDE0M
{
    Id = 100,
    Value = Guid.Parse("019e1b45-9082-7431-89bd-4b8acf21efa1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 105,
    Value = Guid.Parse("019e1b45-9082-7046-a8f7-f6fddd3f8bcc"),
    NullableValue = Guid.Parse("019e1b45-9082-7202-b704-283e151b20f7"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 105,
    Value = Guid.Parse("019e1b45-9082-7ae3-96c6-5bbda6093f5a"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 113,
    Value = Guid.Parse("019e1b45-9082-7f7e-ac4a-0d8d1e138272"),
    NullableValue = Guid.Parse("019e1b45-9082-7e3a-8f54-4b4c78a995cc"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 106,
    Value = Guid.Parse("019e1b45-9082-7613-a022-b67634726c55"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 121,
    Value = Guid.Parse("019e1b45-9082-7cfb-8502-519f9d441c4a"),
    NullableValue = Guid.Parse("019e1b45-9082-7e60-a1cf-561228fab83f"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 109,
    Value = Guid.Parse("019e1b45-9082-7df0-9bb3-c472468c4e35"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 130,
    Value = Guid.Parse("019e1b45-9082-70a1-a819-0fb5eba9416f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 115,
    Value = Guid.Parse("019e1b45-9082-715d-82c5-69816deedd45"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 133,
    Value = Guid.Parse("019e1b45-9082-7059-a531-ffe2111d95d4"),
    NullableValue = Guid.Parse("019e1b45-9082-78df-9397-b95087c5ad7f"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7829-965d-175deb40b79f"),
},
            new Guidv7UUIDE0M
{
    Id = 120,
    Value = Guid.Parse("019e1b45-9082-743c-a36f-ef2d9db96d9b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 139,
    Value = Guid.Parse("019e1b45-9082-73cc-8fc4-1029efb259a0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 121,
    Value = Guid.Parse("019e1b45-9082-7c95-bb02-d3460a6d90f6"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 147,
    Value = Guid.Parse("019e1b45-9082-7920-a6da-6750a458b6f4"),
    NullableValue = Guid.Parse("019e1b45-9082-7b05-95a1-ba50a7f2ca7b"),
},
    NullableValue = Guid.Parse("019e1b45-9082-70b9-9c8b-6b784f6ba4d6"),
},
            new Guidv7UUIDE0M
{
    Id = 122,
    Value = Guid.Parse("019e1b45-9082-7bab-9770-a3a910207953"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 151,
    Value = Guid.Parse("019e1b45-9082-7aff-bcf9-7632fb089b05"),
    NullableValue = Guid.Parse("019e1b45-9082-76f3-b555-adbd87c8654a"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 123,
    Value = Guid.Parse("019e1b45-9082-715c-a225-0eb499650e95"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 154,
    Value = Guid.Parse("019e1b45-9082-7042-a418-02b22d1412a8"),
    NullableValue = Guid.Parse("019e1b45-9082-742c-9086-e1f109497e0f"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7d01-9b7c-b8174d3f3390"),
},
            new Guidv7UUIDE0M
{
    Id = 132,
    Value = Guid.Parse("019e1b45-9082-77ff-a8fb-6940eea9bde3"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 162,
    Value = Guid.Parse("019e1b45-9082-711d-bafe-ff67b65ceb51"),
    NullableValue = Guid.Parse("019e1b45-9082-7421-87bc-7625f2fca021"),
},
    NullableValue = Guid.Parse("019e1b45-9082-79f0-a07e-25ebf2e93082"),
},
            new Guidv7UUIDE0M
{
    Id = 133,
    Value = Guid.Parse("019e1b45-9082-7b1f-8bd9-475b93fde085"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 166,
    Value = Guid.Parse("019e1b45-9082-7ff1-84b2-8a07978f1ae5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9082-760d-ace1-c437eaa96e85"),
},
            new Guidv7UUIDE0M
{
    Id = 138,
    Value = Guid.Parse("019e1b45-9082-780d-82c4-d38fd25f595f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 174,
    Value = Guid.Parse("019e1b45-9082-7d8b-9adc-25bf0c591d27"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 143,
    Value = Guid.Parse("019e1b45-9082-703e-a031-b50ed5b59cb6"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 176,
    Value = Guid.Parse("019e1b45-9082-7980-9a3b-319e2d1450f8"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 145,
    Value = Guid.Parse("019e1b45-9082-7046-8d54-9293d9f5dbd9"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 182,
    Value = Guid.Parse("019e1b45-9082-70b1-b486-22f678d33c89"),
    NullableValue = Guid.Parse("019e1b45-9082-7ee4-bdbe-872068ff34f7"),
},
    NullableValue = Guid.Parse("019e1b45-9082-7ae0-8523-0d8c0b24f43c"),
},
            new Guidv7UUIDE0M
{
    Id = 146,
    Value = Guid.Parse("019e1b45-9082-7be1-bbdf-3cd9f83acfd2"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 186,
    Value = Guid.Parse("019e1b45-9082-72f4-a3c3-f75ab309beb8"),
    NullableValue = Guid.Parse("019e1b45-9082-7e69-992c-b06b1a077ba0"),
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
INSERT INTO gedaqtests.guidv7uuide0m(
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
FROM gedaqtests.guidv7uuide0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Guidv7UUIDE0M)],
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
                    Guidv7UUIDE0M.AssertModel(models[0],_testData[i], false);
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
                    Guidv7UUIDE0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


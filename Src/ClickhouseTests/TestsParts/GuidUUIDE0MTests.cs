

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
    Value = Guid.Parse("4a86312b-f8bf-433f-824f-f979950914d1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 8,
    Value = Guid.Parse("64866bd3-2771-496b-b979-d183e34fa3dd"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0ff47dec-dd55-43ee-addc-6bca3a2258cb"),
},
            new GuidUUIDE0M
{
    Id = 9,
    Value = Guid.Parse("569600c8-313c-46f8-806c-fc4536607b5c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 15,
    Value = Guid.Parse("eed722a8-c404-4225-9bb8-36f3439ba482"),
    NullableValue = Guid.Parse("536ad8cd-e64c-417d-a3c4-ae80908c7315"),
},
    NullableValue = Guid.Parse("dd1ca028-4f8e-4bef-859b-ea3406595a20"),
},
            new GuidUUIDE0M
{
    Id = 10,
    Value = Guid.Parse("c61f2fb8-b35f-4b30-80bd-f53721006026"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 17,
    Value = Guid.Parse("01a0e577-427e-4ac8-b5f3-763ef8da470f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("167c6ff3-883e-4f25-a51c-ae10ddfef888"),
},
            new GuidUUIDE0M
{
    Id = 15,
    Value = Guid.Parse("ace2910c-4900-4d41-8985-c9ebc23894dc"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 24,
    Value = Guid.Parse("4747a312-9530-47fe-8173-9252a7cfb032"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ced24aad-6421-4dfc-a116-9f44b478ab82"),
},
            new GuidUUIDE0M
{
    Id = 18,
    Value = Guid.Parse("df1af67f-734b-4457-a631-d8498ef5518f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 27,
    Value = Guid.Parse("56caf667-f6b9-428d-8036-bf7e621828b3"),
    NullableValue = Guid.Parse("8d443508-6609-4b2c-9692-8d2ecd683166"),
},
    NullableValue = Guid.Parse("a34ccab3-eaeb-4076-a09c-d090b523a8c2"),
},
            new GuidUUIDE0M
{
    Id = 27,
    Value = Guid.Parse("16e7eed3-48e5-4342-bbc2-888dfd571196"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 31,
    Value = Guid.Parse("5a26eb72-6da2-4a57-aced-08cc7898a4ab"),
    NullableValue = Guid.Parse("fddf065d-4f24-482f-8626-0096a0804486"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 33,
    Value = Guid.Parse("7d12277b-45ff-4b1a-87be-c68a0b78eac1"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 39,
    Value = Guid.Parse("0b308516-b8e4-489e-8204-06f9a328f403"),
    NullableValue = Guid.Parse("6870de1e-2bdb-4aa2-9ba1-69e659cbcf74"),
},
    NullableValue = Guid.Parse("bb5e63f7-ccb0-4ee7-a6c9-1e3d9c31ecdf"),
},
            new GuidUUIDE0M
{
    Id = 34,
    Value = Guid.Parse("bcbf32b4-4097-4f26-a723-b2824bd72053"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 42,
    Value = Guid.Parse("523c9880-a9bd-4638-8c20-4c3a51a3894a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d161853e-a8ad-4615-b7d7-74372bac5d90"),
},
            new GuidUUIDE0M
{
    Id = 35,
    Value = Guid.Parse("15eb0709-2a1a-48e7-b3e6-34eaaf1d591f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 43,
    Value = Guid.Parse("596350c3-b10b-4c3d-8580-1e4d3fb1e2d2"),
    NullableValue = Guid.Parse("3512cb15-80d1-4815-b3ab-41a9bc561385"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 36,
    Value = Guid.Parse("1aca7403-bd92-4bda-b556-2cbb8d60fea4"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 51,
    Value = Guid.Parse("17017408-b8c0-4dbd-93b5-a1445d89076d"),
    NullableValue = Guid.Parse("0e60c08e-65d9-46c5-ab7e-ec41d0f3397a"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 38,
    Value = Guid.Parse("b497b23a-9cb8-4a29-beac-41e1160225a3"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 52,
    Value = Guid.Parse("360bffd2-65ce-4bb1-9880-f0638b1dd37d"),
    NullableValue = Guid.Parse("a5cf4b8d-1714-4f37-b3d1-130f1fdc1f96"),
},
    NullableValue = Guid.Parse("fed385e1-ac02-4f43-a87a-1de7964cd2cf"),
},
            new GuidUUIDE0M
{
    Id = 39,
    Value = Guid.Parse("bcd5adef-e4b8-4e69-913d-b9ad01f1cbf7"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 59,
    Value = Guid.Parse("185a40ac-69ac-45b5-a41b-9d17738126ba"),
    NullableValue = Guid.Parse("47776f3f-fac1-4f47-aca5-c4fb6595c3a5"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 44,
    Value = Guid.Parse("c77e2289-76ad-4d77-bf8d-bcf185976980"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 61,
    Value = Guid.Parse("4e338136-c3dd-4502-bdb4-2781ba50e1a2"),
    NullableValue = Guid.Parse("cfdab24b-27b8-4632-b421-6850f81a5582"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 48,
    Value = Guid.Parse("8bd2c52f-bf76-4e9c-bfe7-fbfb95754c65"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 67,
    Value = Guid.Parse("11415f86-f897-45ea-8c79-4d60c4c4cd66"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("5eec28ba-4c1b-4ba8-9458-bda4335c02a6"),
},
            new GuidUUIDE0M
{
    Id = 50,
    Value = Guid.Parse("a66e48f6-e76f-497d-ba32-6f0f4abb039e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 69,
    Value = Guid.Parse("e42c86e2-8a11-4e10-835a-3c5f479852f6"),
    NullableValue = Guid.Parse("46a4c644-5bbe-4050-bd1d-349b943b9982"),
},
    NullableValue = Guid.Parse("96454413-b016-4634-b61b-eb53d2e3e902"),
},
            new GuidUUIDE0M
{
    Id = 58,
    Value = Guid.Parse("cfdd0a55-e298-43af-9401-a734a70cf7b5"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 74,
    Value = Guid.Parse("96c82ef4-6f0d-4890-b593-d90b8a3e37ca"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0b65e58b-d946-4d76-9df7-bf254e2a2b00"),
},
            new GuidUUIDE0M
{
    Id = 61,
    Value = Guid.Parse("2269bd03-7706-40d9-a6cb-f31fd6587607"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 78,
    Value = Guid.Parse("3d67081f-8ede-4670-abc8-9034cd41cfe8"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 65,
    Value = Guid.Parse("fcb3d6cb-01e4-4fb9-b040-369940f10e4c"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 84,
    Value = Guid.Parse("53da5fe4-1499-4c6b-98f2-14e4e09ac095"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("66e31456-4e03-4f01-adef-8b926ae58170"),
},
            new GuidUUIDE0M
{
    Id = 67,
    Value = Guid.Parse("57ba8ba8-04a9-452d-bb34-563bd5146e49"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 88,
    Value = Guid.Parse("520b892f-0a3b-4e5e-b674-88228273c7b9"),
    NullableValue = Guid.Parse("a39193a2-6d66-4c5a-b100-88bbb9a3cedf"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 71,
    Value = Guid.Parse("f23fccb5-2bab-4629-8dfc-969a25238576"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 96,
    Value = Guid.Parse("293bfa2c-987f-4429-8706-4048a724d2d9"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("daedfedf-53a6-4e52-a80d-a8079e5805ca"),
},
            new GuidUUIDE0M
{
    Id = 73,
    Value = Guid.Parse("dbf75108-372c-4fdc-b3b9-95b79ba6556e"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 104,
    Value = Guid.Parse("8c8ec583-06d3-495b-a86f-775df2f2b998"),
    NullableValue = Guid.Parse("8ca02d76-1c45-4eaa-8b40-18922e736841"),
},
    NullableValue = Guid.Parse("5a717790-a548-430e-8c10-7e4a813deb02"),
},
            new GuidUUIDE0M
{
    Id = 76,
    Value = Guid.Parse("393ad8cf-b69c-4bba-b787-101a4a1d1f92"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 109,
    Value = Guid.Parse("409e326e-8c53-40f6-b23c-d73601a894ab"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 82,
    Value = Guid.Parse("4482bc3c-0a6e-4a9e-9058-97be99fc2944"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 114,
    Value = Guid.Parse("8f67ea82-eee7-461e-9e39-b388aab33efd"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 89,
    Value = Guid.Parse("8724ebea-b7d1-4804-9509-c06fa05a3d49"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 123,
    Value = Guid.Parse("0bdadf21-38f7-4803-a1e8-19f4dd8b85ed"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 96,
    Value = Guid.Parse("3c0856f7-1f6e-41db-b08f-320f5d17ef71"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 131,
    Value = Guid.Parse("a41f3aa2-1fdd-471e-98d9-69d4d4355542"),
    NullableValue = Guid.Parse("c3664da9-04e4-48b3-bcf1-c1fd321abc77"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 101,
    Value = Guid.Parse("6b548909-7fa6-4e4e-bf97-0a51e9f4ec22"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 138,
    Value = Guid.Parse("4bb1e252-3010-498d-95a6-cf40cf0447b0"),
    NullableValue = Guid.Parse("c5a474d8-2426-447f-8237-d185d640ba28"),
},
    NullableValue = Guid.Parse("05b83a34-10bc-4048-a7d7-62df751ffbd5"),
},
            new GuidUUIDE0M
{
    Id = 103,
    Value = Guid.Parse("9b0a9520-2afe-4841-940e-3634d601a34d"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 141,
    Value = Guid.Parse("87e3bdd7-ab21-4957-9388-ce441a2833cb"),
    NullableValue = Guid.Parse("ceb3d966-4eda-432d-bc73-204fcca02b95"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 110,
    Value = Guid.Parse("ee3a72c8-4481-4048-a109-cddb3efd8be5"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 149,
    Value = Guid.Parse("b0432455-936d-4840-a32c-66c98653e776"),
    NullableValue = Guid.Parse("0ecd2cc6-4c7c-4d75-b7bd-144bfcaf503a"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 113,
    Value = Guid.Parse("45b55e09-4c93-4515-af07-b8c7bf0cf895"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 155,
    Value = Guid.Parse("10df678f-fc77-4cdd-b467-e8af01e29b0e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 115,
    Value = Guid.Parse("82d5c94c-1128-4592-8168-50d36ad7f00b"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 156,
    Value = Guid.Parse("6fc3eb88-60a0-4044-a0b6-ed63761caa80"),
    NullableValue = Guid.Parse("ebe7c547-6956-4198-8998-ad28c6e3d8fb"),
},
    NullableValue = Guid.Parse("adb90396-063f-4b7f-b08e-95f8c4d4e281"),
},
            new GuidUUIDE0M
{
    Id = 122,
    Value = Guid.Parse("d848ebdf-2114-40de-914b-88186ab14bfd"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 161,
    Value = Guid.Parse("2ad556b2-980e-4a8c-998a-7d20c14e9733"),
    NullableValue = Guid.Parse("26964dcb-bfcc-49a9-ae7f-159551f2df1a"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 125,
    Value = Guid.Parse("6fc8964e-dbfb-47e1-b37f-b3aeb6146b1f"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 168,
    Value = Guid.Parse("ed762486-ac33-4dc5-b469-0f47e26aed9e"),
    NullableValue = Guid.Parse("a02c687d-2200-4e96-86dd-79ce4075b92c"),
},
    NullableValue = null,
},
            new GuidUUIDE0M
{
    Id = 126,
    Value = Guid.Parse("4e36a95f-4379-494f-8954-153db3b177c0"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 177,
    Value = Guid.Parse("15d31788-4eab-4709-a841-ee8cd0641994"),
    NullableValue = Guid.Parse("c3b75220-c38b-4960-8168-60eb9fd20451"),
},
    NullableValue = Guid.Parse("ca3bdfeb-f9ad-4a88-9e3e-236f643e84c7"),
},
            new GuidUUIDE0M
{
    Id = 127,
    Value = Guid.Parse("5668126b-afee-4411-91b0-c75c280f0424"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 183,
    Value = Guid.Parse("54d279b2-6139-4e20-9f96-0afbec511eed"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c8666dff-e118-4b4c-a724-bf47feac0d8c"),
},
            new GuidUUIDE0M
{
    Id = 133,
    Value = Guid.Parse("154b1bfc-eedf-4dc7-974c-d22313656d7d"),
    ModelInner = new GuidUUIDE0MI
{
    Id = 184,
    Value = Guid.Parse("485040f8-f6af-44ee-ab36-db4e5ea3636f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("1b24c888-c710-449c-aa64-3a124a20127e"),
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


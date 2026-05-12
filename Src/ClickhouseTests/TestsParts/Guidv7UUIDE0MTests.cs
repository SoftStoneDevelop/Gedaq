

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
    internal partial interface IGuidv7SingleTypeUUID
    {
    }
    
    internal partial class Guidv7SingleTypeUUID : IGuidv7SingleTypeUUID
    {


#region TestData

        private readonly Guidv7UUIDE0M[] _testData = new Guidv7UUIDE0M[]
        {
            new Guidv7UUIDE0M
{
    Id = 3,
    Value = Guid.Parse("019e1b50-15aa-794a-8cda-a0b59af56ebc"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 1,
    Value = Guid.Parse("019e1b50-15aa-7f34-9cf2-1bf047ae7ace"),
    NullableValue = Guid.Parse("019e1b50-15aa-79a8-9122-98e7a757ece7"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-7fe8-8e7d-48c5d6311618"),
},
            new Guidv7UUIDE0M
{
    Id = 7,
    Value = Guid.Parse("019e1b50-15aa-7529-bff6-bb3136f63b58"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 2,
    Value = Guid.Parse("019e1b50-15aa-78ec-b1d1-ffe16bc0c7c7"),
    NullableValue = Guid.Parse("019e1b50-15aa-73b7-8245-4d6c65a01ae8"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 15,
    Value = Guid.Parse("019e1b50-15aa-7a01-b954-f7305e7cdf9f"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 11,
    Value = Guid.Parse("019e1b50-15aa-72d5-a139-84e1aef7e8c2"),
    NullableValue = Guid.Parse("019e1b50-15aa-7645-b11f-86dca32f7ca1"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 24,
    Value = Guid.Parse("019e1b50-15aa-7be7-af92-72a094506805"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 15,
    Value = Guid.Parse("019e1b50-15aa-7f13-855b-bf14a42b1d9c"),
    NullableValue = Guid.Parse("019e1b50-15aa-7b11-9e56-76a057b8992f"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-7896-870a-053595c2da46"),
},
            new Guidv7UUIDE0M
{
    Id = 31,
    Value = Guid.Parse("019e1b50-15aa-7978-9163-7b221d2e8b21"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 22,
    Value = Guid.Parse("019e1b50-15aa-7513-9a14-39aaae886788"),
    NullableValue = Guid.Parse("019e1b50-15aa-7990-9046-472809cd419d"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 34,
    Value = Guid.Parse("019e1b50-15aa-7e9e-95be-ceebecbc02c3"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 23,
    Value = Guid.Parse("019e1b50-15aa-7274-b2bb-0d066badd0db"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 37,
    Value = Guid.Parse("019e1b50-15aa-70b3-9fac-406de450426e"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 25,
    Value = Guid.Parse("019e1b50-15aa-796f-8fc8-d100063f2542"),
    NullableValue = Guid.Parse("019e1b50-15aa-7b03-ac70-80039450a701"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-7a0f-8c6e-d64a0cc1489f"),
},
            new Guidv7UUIDE0M
{
    Id = 41,
    Value = Guid.Parse("019e1b50-15aa-7f92-a981-dc087ff22d3f"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 33,
    Value = Guid.Parse("019e1b50-15aa-715f-9e69-15bc8d58f136"),
    NullableValue = Guid.Parse("019e1b50-15aa-760c-b8b3-384bd54df1b8"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-7fac-af93-a543abc864fc"),
},
            new Guidv7UUIDE0M
{
    Id = 48,
    Value = Guid.Parse("019e1b50-15aa-7e5f-8f80-c7019cfd5791"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 35,
    Value = Guid.Parse("019e1b50-15aa-7c56-b68a-721db476e005"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b50-15aa-715b-87d7-e3aef075c519"),
},
            new Guidv7UUIDE0M
{
    Id = 50,
    Value = Guid.Parse("019e1b50-15aa-7304-b848-902704c64af8"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 41,
    Value = Guid.Parse("019e1b50-15aa-73e8-bb8d-7d085194c542"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 54,
    Value = Guid.Parse("019e1b50-15aa-7428-8cac-6f7ba4365fdc"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 49,
    Value = Guid.Parse("019e1b50-15aa-7c3a-be8e-16e836c6a15d"),
    NullableValue = Guid.Parse("019e1b50-15aa-7ad5-9d86-324a8c5e0e38"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 57,
    Value = Guid.Parse("019e1b50-15aa-7eb8-8026-a5ffe5e829e6"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 56,
    Value = Guid.Parse("019e1b50-15aa-7336-853b-3ab2c9035ad2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 58,
    Value = Guid.Parse("019e1b50-15aa-7e70-a740-dc48876b4730"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 60,
    Value = Guid.Parse("019e1b50-15aa-786a-8a47-dbcd9d871b95"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 62,
    Value = Guid.Parse("019e1b50-15aa-7768-8669-3748109be658"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 69,
    Value = Guid.Parse("019e1b50-15aa-7c71-af61-3de49e0bb1a7"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 63,
    Value = Guid.Parse("019e1b50-15aa-7f23-92d7-b3114529fb6f"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 71,
    Value = Guid.Parse("019e1b50-15aa-725e-b51c-7b7e2e71a2ad"),
    NullableValue = Guid.Parse("019e1b50-15aa-78e3-9c19-b426b914de6a"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-7896-b4fe-08739bdb89fa"),
},
            new Guidv7UUIDE0M
{
    Id = 72,
    Value = Guid.Parse("019e1b50-15aa-7ae7-abb1-9ed5b6a8b9e9"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 78,
    Value = Guid.Parse("019e1b50-15aa-78e0-9906-ac4379b6a86b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 80,
    Value = Guid.Parse("019e1b50-15aa-7758-a523-b97ea9e66671"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 86,
    Value = Guid.Parse("019e1b50-15aa-7f4f-83cc-40676ce334ed"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 88,
    Value = Guid.Parse("019e1b50-15aa-79fe-bb93-891d57ba70a8"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 90,
    Value = Guid.Parse("019e1b50-15aa-7656-b393-21d2420aac7c"),
    NullableValue = Guid.Parse("019e1b50-15aa-78aa-9003-71e335d6673f"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-783b-8cdd-fbbb06b79b10"),
},
            new Guidv7UUIDE0M
{
    Id = 97,
    Value = Guid.Parse("019e1b50-15aa-7408-8516-7ea6d0e52922"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 96,
    Value = Guid.Parse("019e1b50-15aa-7b67-9c84-331cb39111de"),
    NullableValue = Guid.Parse("019e1b50-15aa-7019-ad09-11cb77bb47b1"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-70b1-8db6-c0b4e80eb1ce"),
},
            new Guidv7UUIDE0M
{
    Id = 103,
    Value = Guid.Parse("019e1b50-15aa-72e4-96ad-7291e2ad487b"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 99,
    Value = Guid.Parse("019e1b50-15aa-7ded-8fb4-91b228f7512f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 108,
    Value = Guid.Parse("019e1b50-15aa-7335-9701-9e9896bd841c"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 100,
    Value = Guid.Parse("019e1b50-15aa-78de-80f0-bcf1c9febcef"),
    NullableValue = Guid.Parse("019e1b50-15aa-738c-bd55-26f65533edc9"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 110,
    Value = Guid.Parse("019e1b50-15aa-7b14-b432-9cf7a0698758"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 104,
    Value = Guid.Parse("019e1b50-15aa-787c-991e-69f60467f2f3"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 111,
    Value = Guid.Parse("019e1b50-15aa-7ba4-8658-6049c81e7f38"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 111,
    Value = Guid.Parse("019e1b50-15aa-7d6b-9ef7-28f3198b623b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b50-15aa-7c8f-952b-24445f0323fd"),
},
            new Guidv7UUIDE0M
{
    Id = 112,
    Value = Guid.Parse("019e1b50-15aa-7f49-886d-879140a4154d"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 113,
    Value = Guid.Parse("019e1b50-15aa-7ad5-a325-e6716e5756f3"),
    NullableValue = Guid.Parse("019e1b50-15aa-738f-8fe2-252c0829e056"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 113,
    Value = Guid.Parse("019e1b50-15aa-71a0-a8bf-080884874367"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 118,
    Value = Guid.Parse("019e1b50-15aa-7ad3-aad4-170b8d66f515"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 114,
    Value = Guid.Parse("019e1b50-15aa-79d5-a3ca-6bc47dbabcb4"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 123,
    Value = Guid.Parse("019e1b50-15aa-7cc8-8e4e-f3ab8e1d25e6"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 119,
    Value = Guid.Parse("019e1b50-15aa-7efe-b0fe-9b0bca0d3532"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 127,
    Value = Guid.Parse("019e1b50-15aa-7ec3-a4aa-76546fe585bc"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b50-15aa-776d-a48a-74e5233bc190"),
},
            new Guidv7UUIDE0M
{
    Id = 123,
    Value = Guid.Parse("019e1b50-15aa-75a9-a25e-527d88779902"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 133,
    Value = Guid.Parse("019e1b50-15aa-7d0b-93e1-55961090f777"),
    NullableValue = Guid.Parse("019e1b50-15aa-77f9-9c2d-a48232c911bc"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-7cfc-a351-f98b0d1a4972"),
},
            new Guidv7UUIDE0M
{
    Id = 132,
    Value = Guid.Parse("019e1b50-15aa-77a3-9c01-ffe9cc0bf492"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 137,
    Value = Guid.Parse("019e1b50-15aa-7996-b20a-c0dffb6edbba"),
    NullableValue = Guid.Parse("019e1b50-15aa-7c5b-a0b0-ae0b5584a829"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 138,
    Value = Guid.Parse("019e1b50-15aa-732d-a427-2e4faccee782"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 144,
    Value = Guid.Parse("019e1b50-15aa-714f-b212-f5f870b59af3"),
    NullableValue = Guid.Parse("019e1b50-15aa-7f09-9167-de9f88ba2a43"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 144,
    Value = Guid.Parse("019e1b50-15aa-7238-ac1d-fdc303d34e0a"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 146,
    Value = Guid.Parse("019e1b50-15aa-7e3b-9470-6ab0d8e8cd5a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 147,
    Value = Guid.Parse("019e1b50-15aa-7f4d-a826-88b27ea9a248"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 152,
    Value = Guid.Parse("019e1b50-15aa-7326-a56b-ee3e11dc24d2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 155,
    Value = Guid.Parse("019e1b50-15aa-77dc-b1b5-d3bd2d32fc28"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 159,
    Value = Guid.Parse("019e1b50-15aa-7d5c-8948-0d6e3ea8edc8"),
    NullableValue = Guid.Parse("019e1b50-15aa-77c7-ae36-3355c4245a6b"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 159,
    Value = Guid.Parse("019e1b50-15aa-7799-aa9c-4320487cb16c"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 164,
    Value = Guid.Parse("019e1b50-15aa-75b9-92ea-4673071bb578"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b50-15aa-713d-ab58-b58e23b44def"),
},
            new Guidv7UUIDE0M
{
    Id = 167,
    Value = Guid.Parse("019e1b50-15aa-7278-ad2c-8a31443af80b"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 166,
    Value = Guid.Parse("019e1b50-15aa-77ae-82db-ae99a689c8e4"),
    NullableValue = Guid.Parse("019e1b50-15aa-7b3f-863e-390bd7da97f7"),
},
    NullableValue = Guid.Parse("019e1b50-15aa-7abc-b8c5-c4f0953960d2"),
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
            asPartInterface: typeof(IGuidv7SingleTypeUUID)),
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
                    await ((IGuidv7SingleTypeUUID)this).InsertModelDbConnectionAsync(
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
                     ((IGuidv7SingleTypeUUID)this).InsertModelDbConnection(
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
            asPartInterface: typeof(IGuidv7SingleTypeUUID)),
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
                    var models = await ((IGuidv7SingleTypeUUID)this).SelectModelDbConnectionAsync(
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
                    var models =  ((IGuidv7SingleTypeUUID)this).SelectModelDbConnection(
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


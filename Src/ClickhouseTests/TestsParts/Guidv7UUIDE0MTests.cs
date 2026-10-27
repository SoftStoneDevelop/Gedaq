

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
    Id = 1,
    Value = Guid.Parse("01a17ef0-392c-7ab1-a9ed-fc810467ce93"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 1,
    Value = Guid.Parse("01a17ef0-392c-7a21-bc05-302672ddb0b7"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-7d31-b2cf-dfce2a3556a5"),
},
            new Guidv7UUIDE0M
{
    Id = 2,
    Value = Guid.Parse("01a17ef0-392c-7aa5-9dfd-989179205c5a"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 4,
    Value = Guid.Parse("01a17ef0-392c-770b-8118-e992e71b3598"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 8,
    Value = Guid.Parse("01a17ef0-392c-7fb1-9be7-ceca6665a895"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 8,
    Value = Guid.Parse("01a17ef0-392c-7ac7-99b0-500e0d9774f0"),
    NullableValue = Guid.Parse("01a17ef0-392c-7d62-a9f3-c3c34530e65b"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-7cca-abb2-f74ed57cfae5"),
},
            new Guidv7UUIDE0M
{
    Id = 11,
    Value = Guid.Parse("01a17ef0-392c-7c1b-a8f6-dacde5fd067c"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 12,
    Value = Guid.Parse("01a17ef0-392c-7c9a-9c82-0e9e383a8457"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-7413-a476-fdcf0e9e689f"),
},
            new Guidv7UUIDE0M
{
    Id = 17,
    Value = Guid.Parse("01a17ef0-392c-7223-ad69-86aeae828a06"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 16,
    Value = Guid.Parse("01a17ef0-392c-7a7e-bbce-4f3d7d7e6841"),
    NullableValue = Guid.Parse("01a17ef0-392c-707b-8b04-2fcd203c93c1"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 21,
    Value = Guid.Parse("01a17ef0-392c-7071-a94a-25c4ae055423"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 21,
    Value = Guid.Parse("01a17ef0-392c-7e44-a3e3-5c48e407f98b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-78ae-a7e5-bf45dda241d1"),
},
            new Guidv7UUIDE0M
{
    Id = 22,
    Value = Guid.Parse("01a17ef0-392c-738d-b128-2b88add1b9a5"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 30,
    Value = Guid.Parse("01a17ef0-392c-7964-948d-4f8c7caeb3b6"),
    NullableValue = Guid.Parse("01a17ef0-392c-706e-86d6-a2aa087f0c1e"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-72ef-b20d-19985f2dfc78"),
},
            new Guidv7UUIDE0M
{
    Id = 23,
    Value = Guid.Parse("01a17ef0-392c-725a-ac75-e387eb5950ea"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 33,
    Value = Guid.Parse("01a17ef0-392c-741f-8d4d-4f61964efbe0"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-7bfa-8fdb-14fa53594aba"),
},
            new Guidv7UUIDE0M
{
    Id = 31,
    Value = Guid.Parse("01a17ef0-392c-7484-86f5-dd93789b01bc"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 41,
    Value = Guid.Parse("01a17ef0-392c-7947-8bfa-fc27f287e190"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 33,
    Value = Guid.Parse("01a17ef0-392c-7c50-a39a-aeec983af8d6"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 42,
    Value = Guid.Parse("01a17ef0-392c-7355-b2b7-8bd85566cfb9"),
    NullableValue = Guid.Parse("01a17ef0-392c-7f3e-9940-d545f1b5fc91"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-74fe-aa4a-e1a0ec7fd288"),
},
            new Guidv7UUIDE0M
{
    Id = 41,
    Value = Guid.Parse("01a17ef0-392c-781f-82e5-9fa538888476"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 46,
    Value = Guid.Parse("01a17ef0-392c-7b5b-af6d-eae46ad24694"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 42,
    Value = Guid.Parse("01a17ef0-392c-7d71-b1b8-1b7084a30292"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 51,
    Value = Guid.Parse("01a17ef0-392c-7344-aef7-a5cba43499b3"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-7d6e-800f-882ffd625b63"),
},
            new Guidv7UUIDE0M
{
    Id = 49,
    Value = Guid.Parse("01a17ef0-392c-7c2c-8a1c-92bee8e94f6f"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 54,
    Value = Guid.Parse("01a17ef0-392c-749d-b44a-cf06792374d1"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 58,
    Value = Guid.Parse("01a17ef0-392c-70a7-93b4-17225f33f352"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 62,
    Value = Guid.Parse("01a17ef0-392c-7b80-9607-b69d20a779c3"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 67,
    Value = Guid.Parse("01a17ef0-392c-7cfa-9dbd-867e23cf4929"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 67,
    Value = Guid.Parse("01a17ef0-392c-73df-a31e-ca83e6bd48d5"),
    NullableValue = Guid.Parse("01a17ef0-392c-76ee-9f24-cd9cd741acfe"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-7f56-963c-34c39a2bd7f3"),
},
            new Guidv7UUIDE0M
{
    Id = 73,
    Value = Guid.Parse("01a17ef0-392c-7502-b2bd-56bd67c64472"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 75,
    Value = Guid.Parse("01a17ef0-392c-7e5c-9e57-5fc7d74269e1"),
    NullableValue = Guid.Parse("01a17ef0-392c-7c7e-87d9-a4f6e0aca8fc"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 77,
    Value = Guid.Parse("01a17ef0-392c-73f6-8277-8882ebc66fd7"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 80,
    Value = Guid.Parse("01a17ef0-392c-7fbe-a9ff-e5792c0928b6"),
    NullableValue = Guid.Parse("01a17ef0-392c-715b-968d-5cc996f372d9"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-7f8c-8e28-18c38142c208"),
},
            new Guidv7UUIDE0M
{
    Id = 79,
    Value = Guid.Parse("01a17ef0-392c-78e4-958b-dd240ae5d6e8"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 88,
    Value = Guid.Parse("01a17ef0-392c-7474-bbce-beb2fba0dc57"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-7f9f-a909-c644a7c4da66"),
},
            new Guidv7UUIDE0M
{
    Id = 82,
    Value = Guid.Parse("01a17ef0-392c-7895-a657-7b22018f234c"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 97,
    Value = Guid.Parse("01a17ef0-392c-7c50-9da6-b2f2f6681135"),
    NullableValue = Guid.Parse("01a17ef0-392c-7180-b441-29837c1ef2b6"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-716c-ad34-13d5af0d50cf"),
},
            new Guidv7UUIDE0M
{
    Id = 89,
    Value = Guid.Parse("01a17ef0-392c-7607-9b45-0fca0bc630ab"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 104,
    Value = Guid.Parse("01a17ef0-392c-7c6e-8d90-e91efd15e50e"),
    NullableValue = Guid.Parse("01a17ef0-392c-77c8-a6f9-0a71b91fa75c"),
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 91,
    Value = Guid.Parse("01a17ef0-392c-7a07-82c5-915abb094ead"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 113,
    Value = Guid.Parse("01a17ef0-392c-76eb-9e22-9485e1d7e4fd"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-72b4-98e8-2ed9d0f5b4f8"),
},
            new Guidv7UUIDE0M
{
    Id = 94,
    Value = Guid.Parse("01a17ef0-392c-7873-8a18-95eefcf6b926"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 121,
    Value = Guid.Parse("01a17ef0-392c-7c30-b16e-03ced4d5ae85"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-7438-a565-d01061910c9b"),
},
            new Guidv7UUIDE0M
{
    Id = 102,
    Value = Guid.Parse("01a17ef0-392c-70de-b175-49e53dddfcb5"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 126,
    Value = Guid.Parse("01a17ef0-392c-78d9-83f1-0c22163605e0"),
    NullableValue = Guid.Parse("01a17ef0-392c-7b22-8ce0-230bedde4891"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-762a-8b6e-78b90359890b"),
},
            new Guidv7UUIDE0M
{
    Id = 104,
    Value = Guid.Parse("01a17ef0-392c-7933-a233-57d29a3cb605"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 133,
    Value = Guid.Parse("01a17ef0-392c-7c5b-a78d-5980a8245cfe"),
    NullableValue = Guid.Parse("01a17ef0-392c-71c6-a8b1-4dd50110b6db"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-7e0a-ab4b-012474286464"),
},
            new Guidv7UUIDE0M
{
    Id = 111,
    Value = Guid.Parse("01a17ef0-392c-73cd-be8e-4f76dfc1f06c"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 142,
    Value = Guid.Parse("01a17ef0-392c-7cac-945c-ec30a9409deb"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 113,
    Value = Guid.Parse("01a17ef0-392c-78fa-99a1-868560e3af42"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 151,
    Value = Guid.Parse("01a17ef0-392c-7014-b8fc-ad9636aca383"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 121,
    Value = Guid.Parse("01a17ef0-392c-7bbd-b3af-00ec9ffc1fe4"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 152,
    Value = Guid.Parse("01a17ef0-392c-7c86-97c4-d3c4f445efe4"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 129,
    Value = Guid.Parse("01a17ef0-392c-7076-8d5e-43b5dddd5e59"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 154,
    Value = Guid.Parse("01a17ef0-392c-7318-b444-0ddbb8bc6580"),
    NullableValue = Guid.Parse("01a17ef0-392c-730c-9b63-f43193dbd9ac"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-74a9-8bd5-1aeb3e6de768"),
},
            new Guidv7UUIDE0M
{
    Id = 138,
    Value = Guid.Parse("01a17ef0-392c-7bce-b49a-435353e23d88"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 161,
    Value = Guid.Parse("01a17ef0-392c-795e-b1c2-ea0f3ac5810d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 141,
    Value = Guid.Parse("01a17ef0-392c-7c6e-a9be-2215c5c4bc31"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 164,
    Value = Guid.Parse("01a17ef0-392c-7a7f-a9f5-41a247003253"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 147,
    Value = Guid.Parse("01a17ef0-392c-7750-b238-3529f5a1187b"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 173,
    Value = Guid.Parse("01a17ef0-392c-72a7-b844-61be3c72e7f1"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-75be-a9fc-a3eef757306a"),
},
            new Guidv7UUIDE0M
{
    Id = 154,
    Value = Guid.Parse("01a17ef0-392c-754d-bd07-733985c0ec8e"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 174,
    Value = Guid.Parse("01a17ef0-392c-7d2b-b0f4-4e4d090affe5"),
    NullableValue = Guid.Parse("01a17ef0-392c-720b-a345-25bb2594315d"),
},
    NullableValue = Guid.Parse("01a17ef0-392c-7c69-94dc-6298afe09276"),
},
            new Guidv7UUIDE0M
{
    Id = 162,
    Value = Guid.Parse("01a17ef0-392c-7334-8fe8-0aa339befcf0"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 175,
    Value = Guid.Parse("01a17ef0-392c-7d91-8914-f0ca3a77e628"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-757b-8257-e9b2b445125a"),
},
            new Guidv7UUIDE0M
{
    Id = 166,
    Value = Guid.Parse("01a17ef0-392c-7498-a278-9c317500cb56"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 176,
    Value = Guid.Parse("01a17ef0-392c-71d6-b585-ac472cb68e18"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7UUIDE0M
{
    Id = 171,
    Value = Guid.Parse("01a17ef0-392c-7597-9945-29982fa6e1c2"),
    ModelInner = new Guidv7UUIDE0MI
{
    Id = 184,
    Value = Guid.Parse("01a17ef0-392c-7131-9024-df8b3ba88c04"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("01a17ef0-392c-7ca2-a794-f2ceecd4587d"),
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


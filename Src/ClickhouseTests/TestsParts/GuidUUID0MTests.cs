

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

        private readonly GuidUUID0M[] _testData = new GuidUUID0M[]
        {
            new GuidUUID0M
{
    Id = 5,
    Value = Guid.Parse("0d1c0f93-9bb6-4d95-955f-b735372d7523"),
    ModelInner = new GuidUUID0MI
{
    Id = 5,
    Value = Guid.Parse("07f3d7ee-a8bc-4a5b-b573-a62489f0851f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ae47ea20-26f5-48ff-8e5b-2c39b5a89f90"),
},
            new GuidUUID0M
{
    Id = 13,
    Value = Guid.Parse("fcf4de62-269f-46c1-928f-bf4d4839f1e2"),
    ModelInner = new GuidUUID0MI
{
    Id = 7,
    Value = Guid.Parse("2bd3b768-8fad-45c3-8e2c-1837fe074c96"),
    NullableValue = Guid.Parse("f515a85a-2d40-43da-b0f7-1f2fa97017e8"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 14,
    Value = Guid.Parse("397af87e-54bc-49f4-ada2-0eac48e495b9"),
    ModelInner = new GuidUUID0MI
{
    Id = 10,
    Value = Guid.Parse("1af7e727-107e-44c8-a3dc-40da5622eb37"),
    NullableValue = Guid.Parse("c3bef241-4e5f-493a-83b8-9d962154937a"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 16,
    Value = Guid.Parse("d41396cc-3b4e-4ca6-8c74-21c2b6b2c3ac"),
    ModelInner = new GuidUUID0MI
{
    Id = 14,
    Value = Guid.Parse("59be6705-26c9-43c3-ade9-53cb922c2484"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c811c9bf-8a59-4dc1-95c0-c7d2cb3e080f"),
},
            new GuidUUID0M
{
    Id = 21,
    Value = Guid.Parse("14480bbd-dcbf-44b2-b1f3-4c40a1aa06d1"),
    ModelInner = new GuidUUID0MI
{
    Id = 15,
    Value = Guid.Parse("9b22c7fc-e530-42cd-b719-9eb15a835b53"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 27,
    Value = Guid.Parse("3f015779-3620-4d9e-8758-5da25ec1c1a4"),
    ModelInner = new GuidUUID0MI
{
    Id = 23,
    Value = Guid.Parse("4a8891c9-0fd1-45cb-b783-606cc4d2846d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 31,
    Value = Guid.Parse("13630ebf-d281-4b90-b275-aa4bc5aad9ca"),
    ModelInner = new GuidUUID0MI
{
    Id = 31,
    Value = Guid.Parse("1ca42a6e-5c07-49dc-b93b-3574e5d13d4a"),
    NullableValue = Guid.Parse("43a8d8d3-e973-44d7-9db6-4c8dbdf688d8"),
},
    NullableValue = Guid.Parse("59c7efb3-472e-4d97-b05e-c7cb7453d680"),
},
            new GuidUUID0M
{
    Id = 39,
    Value = Guid.Parse("b64b3206-59f2-410d-939a-e4f36e5f372f"),
    ModelInner = new GuidUUID0MI
{
    Id = 33,
    Value = Guid.Parse("706feccd-fadf-4d6d-b90b-0482949fc964"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 44,
    Value = Guid.Parse("f34dc5cd-a35c-4749-90cc-7380468d7513"),
    ModelInner = new GuidUUID0MI
{
    Id = 37,
    Value = Guid.Parse("fac42f69-e07b-4bfc-87da-eaa8ee249cc9"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 53,
    Value = Guid.Parse("ffaec974-4bbd-41b4-8ae6-db0923860e5a"),
    ModelInner = new GuidUUID0MI
{
    Id = 42,
    Value = Guid.Parse("309dde08-fba6-46a3-a49f-3a9411691bbe"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d58ef7a1-3a79-4033-9cf4-55b1827be03e"),
},
            new GuidUUID0M
{
    Id = 56,
    Value = Guid.Parse("81dd54dc-92c7-49c7-ae79-054df4a11081"),
    ModelInner = new GuidUUID0MI
{
    Id = 49,
    Value = Guid.Parse("30bc59ec-18a7-49d4-aa52-7d127eec9438"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 58,
    Value = Guid.Parse("999b3b09-c5ba-468f-a463-0e6939a4f1ae"),
    ModelInner = new GuidUUID0MI
{
    Id = 54,
    Value = Guid.Parse("5372cc61-1f11-48c4-acc6-de811dea225a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 66,
    Value = Guid.Parse("4e73c656-fd8a-49df-b51d-0e9180f08a63"),
    ModelInner = new GuidUUID0MI
{
    Id = 63,
    Value = Guid.Parse("44f4a9f2-fadd-401d-9d67-010cfc55c4da"),
    NullableValue = Guid.Parse("a5f2617b-fc5c-4881-9d31-d3209732c2b0"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 72,
    Value = Guid.Parse("47175806-2e78-4d53-9c5e-3fef019311ca"),
    ModelInner = new GuidUUID0MI
{
    Id = 70,
    Value = Guid.Parse("5e0b1c74-7e7c-48d1-ab77-3d8db862cf56"),
    NullableValue = Guid.Parse("0d5b429f-88dc-47be-a2e5-afb38ffbcc04"),
},
    NullableValue = Guid.Parse("07902145-bdb1-480f-a24e-2ee149611530"),
},
            new GuidUUID0M
{
    Id = 75,
    Value = Guid.Parse("150f468c-f7bf-454c-9bb6-b86d4bdb7541"),
    ModelInner = new GuidUUID0MI
{
    Id = 75,
    Value = Guid.Parse("f722c357-dcdf-4abb-80d8-3894f5d470b0"),
    NullableValue = Guid.Parse("569b3b52-2c00-4fae-bfe3-961d0e2eb0c0"),
},
    NullableValue = Guid.Parse("9909b379-c67e-4573-b6b1-5325a595125c"),
},
            new GuidUUID0M
{
    Id = 80,
    Value = Guid.Parse("e6cf0829-061a-4fef-9462-08e203b7bfc2"),
    ModelInner = new GuidUUID0MI
{
    Id = 78,
    Value = Guid.Parse("3a79001f-8e4f-421b-97df-60c02cfa5db0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 82,
    Value = Guid.Parse("39eb1410-c418-4991-bb03-e05072f09f83"),
    ModelInner = new GuidUUID0MI
{
    Id = 85,
    Value = Guid.Parse("7c631639-69c4-4077-b3df-10d561144409"),
    NullableValue = Guid.Parse("c53e6fad-c43c-4b4b-b674-23af65894fd4"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 83,
    Value = Guid.Parse("15f8f7ea-1526-4fa7-8369-4f06fe957a4f"),
    ModelInner = new GuidUUID0MI
{
    Id = 89,
    Value = Guid.Parse("2448e24c-fc66-4eeb-9aa7-1748946f5b61"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("5314605b-8b2e-4363-8a80-03f15d6a8ae1"),
},
            new GuidUUID0M
{
    Id = 87,
    Value = Guid.Parse("d854d738-a99d-431f-b686-dac180a99abc"),
    ModelInner = new GuidUUID0MI
{
    Id = 95,
    Value = Guid.Parse("e49ad3da-a148-45b4-a4fc-42bdffba5f6d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 89,
    Value = Guid.Parse("90d7caa3-e95b-4375-beb5-35fa6c4cfc38"),
    ModelInner = new GuidUUID0MI
{
    Id = 102,
    Value = Guid.Parse("679ab8ca-5476-4d50-bc95-d09a45fc52c7"),
    NullableValue = Guid.Parse("0bd5b4c7-ef5d-4858-8610-f8cfab29d7a2"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 92,
    Value = Guid.Parse("d437db71-a754-4307-87d7-f9b6763be0e4"),
    ModelInner = new GuidUUID0MI
{
    Id = 109,
    Value = Guid.Parse("63015ba7-1995-46dd-bf8f-dc4281483a62"),
    NullableValue = Guid.Parse("c9e80a4a-09ae-4450-b606-5029f1cce54e"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 96,
    Value = Guid.Parse("d85729e5-6d25-4503-a2fd-5d47b59cfd1b"),
    ModelInner = new GuidUUID0MI
{
    Id = 113,
    Value = Guid.Parse("4819034a-c710-4dbe-b523-59dec82d323b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 101,
    Value = Guid.Parse("65bea95c-e793-4e77-90e3-81fa7e887cfb"),
    ModelInner = new GuidUUID0MI
{
    Id = 117,
    Value = Guid.Parse("0efc86bd-6402-4c21-b1cc-9bba0292a766"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b7cecb3e-ce93-4303-9af4-c8ecdd72deb2"),
},
            new GuidUUID0M
{
    Id = 108,
    Value = Guid.Parse("8ae4babc-7bce-40b4-ad6b-cf08694df3b9"),
    ModelInner = new GuidUUID0MI
{
    Id = 120,
    Value = Guid.Parse("4078da47-c573-497f-8c6e-0f055d1aa1a1"),
    NullableValue = Guid.Parse("39e5116a-2a39-4485-b69f-d085cb9f0a92"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 113,
    Value = Guid.Parse("50e96794-b8ac-4772-8917-d5721d9eaa93"),
    ModelInner = new GuidUUID0MI
{
    Id = 125,
    Value = Guid.Parse("8fa134f3-f2e7-4b39-9f88-cd11502bb02b"),
    NullableValue = Guid.Parse("9baa5054-79b5-41af-bd61-4a22a50e94f0"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 118,
    Value = Guid.Parse("f2dbce1b-e71a-44f2-90b9-91ed2e842844"),
    ModelInner = new GuidUUID0MI
{
    Id = 132,
    Value = Guid.Parse("7d9ed3a1-666d-4202-84f7-3240ec8f5109"),
    NullableValue = Guid.Parse("d92e352f-d742-47e7-85bd-b57eefbdbc19"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 125,
    Value = Guid.Parse("732a0512-5c17-4df1-8fff-7e922ef606ca"),
    ModelInner = new GuidUUID0MI
{
    Id = 138,
    Value = Guid.Parse("4e1cf8a3-e40f-45bb-a522-b8e8ef3114aa"),
    NullableValue = Guid.Parse("f6a9c401-c5c0-4d79-b2b2-749dabd65d32"),
},
    NullableValue = Guid.Parse("1b2240de-99f9-4e33-bd94-533bf54ea4a4"),
},
            new GuidUUID0M
{
    Id = 126,
    Value = Guid.Parse("5f2ad557-7733-43af-aa5f-30559844f8e0"),
    ModelInner = new GuidUUID0MI
{
    Id = 145,
    Value = Guid.Parse("960ef89c-301e-4a6d-af12-4faeeb8f78ff"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c590a897-c5f8-47f5-a738-cb7cf1869f6a"),
},
            new GuidUUID0M
{
    Id = 135,
    Value = Guid.Parse("0715d6b1-2c7b-47e3-9236-9b42c522cb69"),
    ModelInner = new GuidUUID0MI
{
    Id = 150,
    Value = Guid.Parse("76b7b1c8-7914-4980-aa3b-83cad51b8182"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c65a7391-6ad4-4be8-bd04-1b595185d4d9"),
},
            new GuidUUID0M
{
    Id = 144,
    Value = Guid.Parse("9b5e13d5-e588-4810-913c-fcb9631cd4e8"),
    ModelInner = new GuidUUID0MI
{
    Id = 152,
    Value = Guid.Parse("57df5087-4c2f-4b4c-aadc-d103b8db5020"),
    NullableValue = Guid.Parse("11b38c67-48c6-4327-ae31-413bcc5fe2a4"),
},
    NullableValue = Guid.Parse("df9bee8c-7a77-437b-bb00-ad32a6c16ef4"),
},
            new GuidUUID0M
{
    Id = 152,
    Value = Guid.Parse("ad2eb1e9-ce68-4d5a-8322-e9f7143ee8f3"),
    ModelInner = new GuidUUID0MI
{
    Id = 154,
    Value = Guid.Parse("c2f175ed-8e8d-4088-8358-10087a0e4314"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("7d301f3a-680d-4912-994a-6480daf9b37d"),
},
            new GuidUUID0M
{
    Id = 155,
    Value = Guid.Parse("8b23a54f-6e31-479e-a715-3fc5ab00bf89"),
    ModelInner = new GuidUUID0MI
{
    Id = 157,
    Value = Guid.Parse("13361d14-fa5a-4b77-816e-9858f9f91bfc"),
    NullableValue = Guid.Parse("2e688954-a069-465e-9a8e-8445b993145b"),
},
    NullableValue = Guid.Parse("84118791-8c29-4775-8cfa-11e78eb78ab6"),
},
            new GuidUUID0M
{
    Id = 157,
    Value = Guid.Parse("4c1e7dd6-f20a-4cd8-b562-6d490d4722aa"),
    ModelInner = new GuidUUID0MI
{
    Id = 158,
    Value = Guid.Parse("17ceaeb6-8057-4628-9d5d-ff41225af294"),
    NullableValue = Guid.Parse("8a10ee71-f075-4585-99c0-da60fee03412"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 165,
    Value = Guid.Parse("2f508501-6a10-4021-9774-d6d998a8ab75"),
    ModelInner = new GuidUUID0MI
{
    Id = 163,
    Value = Guid.Parse("b9e5791f-7b08-4cf9-be74-627f31c0b481"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("41c5ad29-fd72-47f2-b815-bf93a2a8eee3"),
},
            new GuidUUID0M
{
    Id = 170,
    Value = Guid.Parse("8bdad319-372e-49dd-974e-52d19a85da78"),
    ModelInner = new GuidUUID0MI
{
    Id = 164,
    Value = Guid.Parse("56c056ef-7e61-4fd5-9a62-185d44b7bc9c"),
    NullableValue = Guid.Parse("1477e567-50a3-4869-ab10-0f337891851d"),
},
    NullableValue = Guid.Parse("051e535f-a487-4568-8bfe-0c9ba33bb21e"),
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guiduuid0m(
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
FROM gedaqtests.guiduuid0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidUUID0M)],
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
                    GuidUUID0M.AssertModel(models[0],_testData[i], false);
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
                    GuidUUID0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


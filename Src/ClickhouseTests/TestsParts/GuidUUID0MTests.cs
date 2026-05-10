

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
    Id = 2,
    Value = Guid.Parse("4bba6d39-f19a-4f9e-b3a4-c7a65e8eeed9"),
    ModelInner = new GuidUUID0MI
{
    Id = 2,
    Value = Guid.Parse("9ce1102f-18a5-470a-8023-1952523775cb"),
    NullableValue = Guid.Parse("cab7018c-4293-46d0-b7e0-7b55d7c424a8"),
},
    NullableValue = Guid.Parse("f084f3af-1f13-4a1d-a6a6-75f8cf5f115e"),
},
            new GuidUUID0M
{
    Id = 6,
    Value = Guid.Parse("09533dab-960d-4d49-989a-1b3dc07202fe"),
    ModelInner = new GuidUUID0MI
{
    Id = 6,
    Value = Guid.Parse("bf206fcd-94ce-4827-a351-91e3c0f491ac"),
    NullableValue = Guid.Parse("8794e7c4-dd9d-42fb-af70-3f8555e788d7"),
},
    NullableValue = Guid.Parse("a9f0906b-07a4-4c7c-9641-629786d3a2bd"),
},
            new GuidUUID0M
{
    Id = 9,
    Value = Guid.Parse("ef3d87b9-87a5-4b48-a490-f4b473791af0"),
    ModelInner = new GuidUUID0MI
{
    Id = 9,
    Value = Guid.Parse("19f5304a-3877-4f1c-af5f-0cbd965f85da"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 14,
    Value = Guid.Parse("6eaa553c-ed15-4937-8c29-4224ce097cc0"),
    ModelInner = new GuidUUID0MI
{
    Id = 10,
    Value = Guid.Parse("ae84f388-8342-44bb-8165-962c32a13435"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 21,
    Value = Guid.Parse("12c8cddf-5ca5-46d4-9248-779525a9062e"),
    ModelInner = new GuidUUID0MI
{
    Id = 18,
    Value = Guid.Parse("50c81b55-b547-4405-baa2-99f058a9cf69"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 23,
    Value = Guid.Parse("1e94338b-35dc-428c-9496-7b3449bc35c8"),
    ModelInner = new GuidUUID0MI
{
    Id = 26,
    Value = Guid.Parse("b1657fd3-f994-4a31-9f8a-448513750901"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 29,
    Value = Guid.Parse("c27692e1-ed35-4d34-b853-93ab876bfed4"),
    ModelInner = new GuidUUID0MI
{
    Id = 28,
    Value = Guid.Parse("94827005-bdea-4965-b4fe-e439d6eb18ce"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a07933f0-ee31-433f-98f3-b8862c8ec835"),
},
            new GuidUUID0M
{
    Id = 35,
    Value = Guid.Parse("af731e03-9741-445a-a09e-059dbd4fe8f1"),
    ModelInner = new GuidUUID0MI
{
    Id = 36,
    Value = Guid.Parse("ba91a5a0-1350-4199-86ef-cf2bab1d82f9"),
    NullableValue = Guid.Parse("43cd63fc-460b-497e-81e9-79a2e4cdca85"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 42,
    Value = Guid.Parse("4aba8bbf-00ad-45f6-b9f6-bd40188e5575"),
    ModelInner = new GuidUUID0MI
{
    Id = 43,
    Value = Guid.Parse("f166fbf8-82bf-4b54-ae99-a7585b44508e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 46,
    Value = Guid.Parse("7b488728-520c-4b4d-9da3-9847692d8593"),
    ModelInner = new GuidUUID0MI
{
    Id = 51,
    Value = Guid.Parse("fccf24b3-6132-421f-a488-938cf11327e6"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("7350d8d8-1540-45e1-aa77-023e78b19fe5"),
},
            new GuidUUID0M
{
    Id = 51,
    Value = Guid.Parse("83b3b2b6-7fc0-40b5-84bf-c15ea82eb2af"),
    ModelInner = new GuidUUID0MI
{
    Id = 53,
    Value = Guid.Parse("ad9770de-652b-4dfe-b655-5582579c836a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 57,
    Value = Guid.Parse("a326db2e-6c50-434e-a332-bd3ec53eeb87"),
    ModelInner = new GuidUUID0MI
{
    Id = 57,
    Value = Guid.Parse("5c5872e5-3d05-4331-90a8-51e24b443479"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c271b630-9732-4125-8228-9a6898f89265"),
},
            new GuidUUID0M
{
    Id = 61,
    Value = Guid.Parse("21762223-a257-428d-8198-3dc4d36c52e9"),
    ModelInner = new GuidUUID0MI
{
    Id = 66,
    Value = Guid.Parse("339dc58d-aad4-47e8-ac40-a861b990c7eb"),
    NullableValue = Guid.Parse("a2ae60d3-b036-4530-a54a-5ce8ddcbeb67"),
},
    NullableValue = Guid.Parse("1dffa5e8-0772-4d36-802c-97122e1f4b51"),
},
            new GuidUUID0M
{
    Id = 62,
    Value = Guid.Parse("613c1056-8e5d-450b-a40d-f1244d183269"),
    ModelInner = new GuidUUID0MI
{
    Id = 71,
    Value = Guid.Parse("ad8b5fe9-ae40-4f86-88dc-8c14ebb7cf25"),
    NullableValue = Guid.Parse("45705463-036a-4736-91ca-5f4199c746b3"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 63,
    Value = Guid.Parse("ef83f416-ecb4-40fb-938a-1787477b1585"),
    ModelInner = new GuidUUID0MI
{
    Id = 73,
    Value = Guid.Parse("f8b28528-a0e0-4125-aa70-ba338788c305"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 71,
    Value = Guid.Parse("76732caa-c516-4e77-b424-77fd8400690a"),
    ModelInner = new GuidUUID0MI
{
    Id = 76,
    Value = Guid.Parse("90952dc5-4676-411e-be60-9aa9797a5a72"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 80,
    Value = Guid.Parse("8c9fbaa2-a78e-483b-ace0-2b1e4ccf592e"),
    ModelInner = new GuidUUID0MI
{
    Id = 85,
    Value = Guid.Parse("a758c79b-fc07-4be2-838a-5f2d8963260f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("4f8cf23f-a520-4500-af51-6991ed5483e7"),
},
            new GuidUUID0M
{
    Id = 89,
    Value = Guid.Parse("93e14455-bf64-4d66-98de-f931e4727071"),
    ModelInner = new GuidUUID0MI
{
    Id = 87,
    Value = Guid.Parse("1c8be426-c66a-4ae7-a16c-e4b6ad71e8d3"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("061bd0c7-2220-401b-ad36-e80140e32389"),
},
            new GuidUUID0M
{
    Id = 94,
    Value = Guid.Parse("c8588fb4-3be2-475f-afa8-f919ea42633c"),
    ModelInner = new GuidUUID0MI
{
    Id = 95,
    Value = Guid.Parse("59f439d2-9307-4e00-b654-e09df6409704"),
    NullableValue = Guid.Parse("992cee30-5dc7-474d-9960-52d1f160bcd6"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 98,
    Value = Guid.Parse("bec3df10-8da2-4877-8634-b4ef2d6d5ee2"),
    ModelInner = new GuidUUID0MI
{
    Id = 101,
    Value = Guid.Parse("5fb35d30-cbb7-46a6-bca6-68a068518717"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c6d6fd7c-c553-4a6b-8dcd-a809a3ecccc8"),
},
            new GuidUUID0M
{
    Id = 102,
    Value = Guid.Parse("d560bdf9-feac-4049-a3fa-0cacf3337a3d"),
    ModelInner = new GuidUUID0MI
{
    Id = 102,
    Value = Guid.Parse("a654780c-003f-46c1-beb1-e422840ed238"),
    NullableValue = Guid.Parse("6478a037-df5b-432d-90f8-333aaa44f96e"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 108,
    Value = Guid.Parse("cd287823-194b-4953-9eff-378346c0871c"),
    ModelInner = new GuidUUID0MI
{
    Id = 110,
    Value = Guid.Parse("29b5cb86-1dd8-467e-9de8-307ad9ae028c"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 109,
    Value = Guid.Parse("20d7853d-538a-43ec-aa81-45951dbeb9f4"),
    ModelInner = new GuidUUID0MI
{
    Id = 116,
    Value = Guid.Parse("58e918c5-b234-472a-a0f0-604566d470b7"),
    NullableValue = Guid.Parse("70d50245-3317-432c-a531-46279f972552"),
},
    NullableValue = Guid.Parse("03cb3e53-be76-4a75-a829-d85fa64d16e9"),
},
            new GuidUUID0M
{
    Id = 110,
    Value = Guid.Parse("a93c77c2-42eb-4600-8942-58f4d2b5d5a4"),
    ModelInner = new GuidUUID0MI
{
    Id = 121,
    Value = Guid.Parse("ee04de71-e5af-4856-a791-b7a6faec387a"),
    NullableValue = Guid.Parse("c25c1cce-d69d-47ae-bfd8-c48263b08197"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 116,
    Value = Guid.Parse("e600628c-84bc-47af-9b95-39a43178939e"),
    ModelInner = new GuidUUID0MI
{
    Id = 126,
    Value = Guid.Parse("0629eaf6-3a43-4a38-8d61-14c61387e6d1"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a5565ccc-7f07-4a6a-8f9b-1746a60a621c"),
},
            new GuidUUID0M
{
    Id = 119,
    Value = Guid.Parse("525a8587-de31-4546-8042-ee1d3ea9755c"),
    ModelInner = new GuidUUID0MI
{
    Id = 130,
    Value = Guid.Parse("c39fb49f-78e3-4c70-af89-3b0441ef6fb0"),
    NullableValue = Guid.Parse("ac5cd10e-c2e6-4036-9e96-4e4ee4f53f8b"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 125,
    Value = Guid.Parse("8972a245-da52-477f-bcc7-a9dace29e707"),
    ModelInner = new GuidUUID0MI
{
    Id = 135,
    Value = Guid.Parse("89c839c7-dd81-4321-a8b0-e6b69fcbfcae"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 128,
    Value = Guid.Parse("9cd3087e-ff85-458d-8167-931765b54cb0"),
    ModelInner = new GuidUUID0MI
{
    Id = 136,
    Value = Guid.Parse("33baec8d-66de-4476-b37a-851c32ee4dc0"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("117dd30c-58dd-4a67-847f-7ade3838f706"),
},
            new GuidUUID0M
{
    Id = 134,
    Value = Guid.Parse("88fd4ce6-e3f4-406f-ace7-f18a301ee22f"),
    ModelInner = new GuidUUID0MI
{
    Id = 145,
    Value = Guid.Parse("e67d7597-f2b2-4206-8a26-cf8c26ed8e74"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("05be7639-802f-42ee-9b47-4366dd869ac8"),
},
            new GuidUUID0M
{
    Id = 135,
    Value = Guid.Parse("286dc3e1-9036-4637-a7d2-a8cb29011642"),
    ModelInner = new GuidUUID0MI
{
    Id = 148,
    Value = Guid.Parse("83f2eb07-2089-445b-bbee-caa0e1f7b615"),
    NullableValue = Guid.Parse("5e9d5472-ba38-4065-aea7-965d5600dd32"),
},
    NullableValue = Guid.Parse("e2c41d35-4aac-4f46-b0dd-add61fd41f0c"),
},
            new GuidUUID0M
{
    Id = 142,
    Value = Guid.Parse("f6a00fe5-a736-41e2-b0ac-2ff7061797fc"),
    ModelInner = new GuidUUID0MI
{
    Id = 149,
    Value = Guid.Parse("4bc7df3e-2049-49c7-b8f9-7e21c015e402"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e8441c8c-f390-498a-a7c6-4e4e5313b2f4"),
},
            new GuidUUID0M
{
    Id = 147,
    Value = Guid.Parse("c66cb8ad-878e-4c27-8b7e-112b03009f49"),
    ModelInner = new GuidUUID0MI
{
    Id = 158,
    Value = Guid.Parse("b65291d6-8834-4cd8-b999-e41aa3ea0666"),
    NullableValue = Guid.Parse("d3867df5-3a8d-466f-ae0d-c3a17888ffbc"),
},
    NullableValue = Guid.Parse("497efd7c-3a6a-40d6-a658-16fa2b38c67b"),
},
            new GuidUUID0M
{
    Id = 156,
    Value = Guid.Parse("cf7640e0-1102-4c34-a783-3622bc4e44ea"),
    ModelInner = new GuidUUID0MI
{
    Id = 167,
    Value = Guid.Parse("63fe056e-4650-45a4-b8ec-7edf5889a3ae"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 157,
    Value = Guid.Parse("df887b74-3f2d-43c3-9034-71185004f8da"),
    ModelInner = new GuidUUID0MI
{
    Id = 168,
    Value = Guid.Parse("45f3acf4-011d-43d9-bce2-cd923a10a014"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("95968ea9-724c-4f09-b7b5-c0c6ab7357c5"),
},
            new GuidUUID0M
{
    Id = 162,
    Value = Guid.Parse("e2389d5a-071d-49e6-b369-ca39411ceefb"),
    ModelInner = new GuidUUID0MI
{
    Id = 170,
    Value = Guid.Parse("9b874213-6d52-4bfe-b67c-42c7025248cb"),
    NullableValue = Guid.Parse("c0560864-6fe4-4eca-b9c8-e5881b4558de"),
},
    NullableValue = Guid.Parse("a385191b-b821-4b70-93a6-1177e8b0a927"),
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


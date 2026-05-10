

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
    Id = 3,
    Value = Guid.Parse("bc876137-2df6-4ee6-9bdb-dc451253593a"),
    ModelInner = new GuidUUID0MI
{
    Id = 8,
    Value = Guid.Parse("8f0bce44-988b-41c8-b113-00174f1921c2"),
    NullableValue = Guid.Parse("27aa1135-c61b-42d9-82f7-aadd8a9f942d"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 9,
    Value = Guid.Parse("7eeed226-de50-4bca-a594-7dc97e29d165"),
    ModelInner = new GuidUUID0MI
{
    Id = 15,
    Value = Guid.Parse("82e53ffc-97d5-434e-b957-610b9ffe2f8d"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("504d092a-e05e-428d-afe9-e0fd81f41492"),
},
            new GuidUUID0M
{
    Id = 10,
    Value = Guid.Parse("287ca2a4-7736-431e-8411-10fd01adc626"),
    ModelInner = new GuidUUID0MI
{
    Id = 24,
    Value = Guid.Parse("0a05225f-4b38-4a02-8850-d3d908b7a178"),
    NullableValue = Guid.Parse("58ef60e9-e59e-4cc5-9f4f-8314a8a2f260"),
},
    NullableValue = Guid.Parse("ce2c9183-fa25-48f1-bf2d-550bef018464"),
},
            new GuidUUID0M
{
    Id = 15,
    Value = Guid.Parse("81e78905-a402-4cb9-b62d-cc3d940fc48d"),
    ModelInner = new GuidUUID0MI
{
    Id = 30,
    Value = Guid.Parse("9f414e91-ed4d-4235-b0e0-ea13f697aa48"),
    NullableValue = Guid.Parse("4cab462b-428a-4c71-9728-b9ff61c05b17"),
},
    NullableValue = Guid.Parse("a11f6de0-2c08-48cf-8b3a-c063c9f50448"),
},
            new GuidUUID0M
{
    Id = 22,
    Value = Guid.Parse("213bacc2-3104-452b-98ff-a0d9068b7cfa"),
    ModelInner = new GuidUUID0MI
{
    Id = 35,
    Value = Guid.Parse("0efee35d-4688-4057-be2e-fc0f618f69f0"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c80dda0a-ba4d-45e4-9355-6439ba4c8620"),
},
            new GuidUUID0M
{
    Id = 24,
    Value = Guid.Parse("6982617b-0dae-483a-aa14-2aa2365f52f7"),
    ModelInner = new GuidUUID0MI
{
    Id = 43,
    Value = Guid.Parse("bf97aaab-a265-4507-b335-266e41070b88"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 25,
    Value = Guid.Parse("07e202d8-de0f-495e-a5e3-69627fea6608"),
    ModelInner = new GuidUUID0MI
{
    Id = 49,
    Value = Guid.Parse("e1c2555f-3161-45e8-a101-fbb278fafdff"),
    NullableValue = Guid.Parse("90f5d5c4-d7f7-4931-b57a-c35f8aa2739c"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 32,
    Value = Guid.Parse("a6dcbf1e-96cb-4cb7-98e7-ef706ffe0262"),
    ModelInner = new GuidUUID0MI
{
    Id = 55,
    Value = Guid.Parse("c796799f-03ae-4fb8-91e1-29ee65875917"),
    NullableValue = Guid.Parse("567ac815-d10b-478b-990e-1d0189c65082"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 37,
    Value = Guid.Parse("5e4814c5-7f8b-4b70-98d0-ff8e00c6a621"),
    ModelInner = new GuidUUID0MI
{
    Id = 58,
    Value = Guid.Parse("8a7f0924-73fd-4bbd-9cc3-7fe21f3af14c"),
    NullableValue = Guid.Parse("62138807-c578-436e-9ab5-169e5a8204f9"),
},
    NullableValue = Guid.Parse("dba46071-d9d7-4b77-a849-45fe2ae30bcd"),
},
            new GuidUUID0M
{
    Id = 46,
    Value = Guid.Parse("5cd6107e-4640-45cb-9573-cafaf73781b4"),
    ModelInner = new GuidUUID0MI
{
    Id = 61,
    Value = Guid.Parse("e5d0843c-120d-4fe9-a32a-52266b891af1"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 53,
    Value = Guid.Parse("85bb354a-4eea-43af-9a56-348a1f4a344d"),
    ModelInner = new GuidUUID0MI
{
    Id = 62,
    Value = Guid.Parse("6a542868-5dff-4eb1-9567-85392b5c2d5a"),
    NullableValue = Guid.Parse("f56e017e-a1cc-425d-afab-339d8874d8d5"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 58,
    Value = Guid.Parse("d8975ed7-2638-4485-8923-265c2962b022"),
    ModelInner = new GuidUUID0MI
{
    Id = 63,
    Value = Guid.Parse("8d763d76-85dd-462c-8838-46c44fdae8d6"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0244f143-5b9d-4a0b-bec1-7cb158eccd54"),
},
            new GuidUUID0M
{
    Id = 67,
    Value = Guid.Parse("6bc611f2-89d3-4693-b65d-c2301d59ba84"),
    ModelInner = new GuidUUID0MI
{
    Id = 67,
    Value = Guid.Parse("71e4160a-a828-4a7e-809a-d90b41e9034f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("aa7b9ba6-88a0-4504-bc8b-f67bab0c504b"),
},
            new GuidUUID0M
{
    Id = 72,
    Value = Guid.Parse("63140acf-3f93-48a5-a1b5-abc3d81d5dab"),
    ModelInner = new GuidUUID0MI
{
    Id = 72,
    Value = Guid.Parse("609449fd-6497-4a98-b14c-f75c091ef6cb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("77c01f13-9e79-43f0-a73d-54878d2f1af0"),
},
            new GuidUUID0M
{
    Id = 75,
    Value = Guid.Parse("a4c576d1-037b-4ae1-b521-2e1901f73601"),
    ModelInner = new GuidUUID0MI
{
    Id = 81,
    Value = Guid.Parse("f490453f-9adf-407d-b318-ebf6935e28d5"),
    NullableValue = Guid.Parse("462804ed-84e5-43fd-9e66-bf5b2ffd9d10"),
},
    NullableValue = Guid.Parse("05168be7-999b-44ef-a8eb-65b51e4f241c"),
},
            new GuidUUID0M
{
    Id = 84,
    Value = Guid.Parse("ccd38b1e-82dd-4dd9-8826-286377e0911c"),
    ModelInner = new GuidUUID0MI
{
    Id = 83,
    Value = Guid.Parse("bf111a1c-09d0-4cf7-9b0d-fd79b002bde2"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("081b9bb8-cabe-4199-b148-22560f3f6b04"),
},
            new GuidUUID0M
{
    Id = 86,
    Value = Guid.Parse("70992bfe-a25f-47c6-844d-3be64e8769fa"),
    ModelInner = new GuidUUID0MI
{
    Id = 90,
    Value = Guid.Parse("976c13a8-4f59-4c8f-9b31-ffcc23e2f8c3"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b903893d-d645-42ab-bde6-342eb5f13824"),
},
            new GuidUUID0M
{
    Id = 94,
    Value = Guid.Parse("cb4baf62-9078-412a-a3e5-314d47311972"),
    ModelInner = new GuidUUID0MI
{
    Id = 92,
    Value = Guid.Parse("ebd82ed4-c52d-4b4d-93f3-ca4c68d9ea0b"),
    NullableValue = Guid.Parse("5986bfdd-e36a-494d-978a-03d063f390f1"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 103,
    Value = Guid.Parse("05f68f03-dd96-4d17-b390-9368bb9273f4"),
    ModelInner = new GuidUUID0MI
{
    Id = 99,
    Value = Guid.Parse("20d42902-e25e-492d-9925-b33480ab68d0"),
    NullableValue = Guid.Parse("c373ceb1-b760-451c-acbe-ce5071049dc9"),
},
    NullableValue = Guid.Parse("1f9d351c-f671-4c77-b114-3c68dcd3ab47"),
},
            new GuidUUID0M
{
    Id = 109,
    Value = Guid.Parse("e7fe7860-82c6-4381-add4-29877dd9ee78"),
    ModelInner = new GuidUUID0MI
{
    Id = 104,
    Value = Guid.Parse("beef49a4-9b4f-4546-b037-3d972dc1e88d"),
    NullableValue = Guid.Parse("87648980-85e7-4730-ac80-6d91be601d05"),
},
    NullableValue = Guid.Parse("f77ed443-376b-4e86-8846-1dfd4188788f"),
},
            new GuidUUID0M
{
    Id = 117,
    Value = Guid.Parse("648c2789-c402-4860-a241-e8f128930004"),
    ModelInner = new GuidUUID0MI
{
    Id = 112,
    Value = Guid.Parse("a15899c0-42b6-4354-b0c9-1ef168b56b7e"),
    NullableValue = Guid.Parse("2f99cc86-db26-48bd-b2c8-f7eb4eeac16c"),
},
    NullableValue = Guid.Parse("b87bde32-597e-4e3f-b0b5-a990cdebe81e"),
},
            new GuidUUID0M
{
    Id = 122,
    Value = Guid.Parse("6ee26777-4a41-4fc8-ac29-68203bd361d1"),
    ModelInner = new GuidUUID0MI
{
    Id = 115,
    Value = Guid.Parse("36ca14e3-4c0a-4a45-966e-e983ba981071"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 127,
    Value = Guid.Parse("4b9a1caf-e3a4-4af3-9126-7ed458a2ef83"),
    ModelInner = new GuidUUID0MI
{
    Id = 116,
    Value = Guid.Parse("3c17c949-2d8a-44a7-89d6-23d3329e0c53"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("9520f785-9801-4eb8-851e-ea2160733baa"),
},
            new GuidUUID0M
{
    Id = 131,
    Value = Guid.Parse("4c51a50a-1d0e-4182-b312-1cbf03f1e471"),
    ModelInner = new GuidUUID0MI
{
    Id = 117,
    Value = Guid.Parse("58ab887f-174a-419d-8b9f-9a49e3c5c829"),
    NullableValue = Guid.Parse("0f884474-d91a-458e-beed-a49a46177fb6"),
},
    NullableValue = Guid.Parse("ec4e214c-5798-42dd-b5c9-88e6978e2e2a"),
},
            new GuidUUID0M
{
    Id = 140,
    Value = Guid.Parse("0062cf03-444c-44e5-a60d-75c5e57a2bdd"),
    ModelInner = new GuidUUID0MI
{
    Id = 125,
    Value = Guid.Parse("04c6cf3b-e6b9-4782-b3e6-d96110832a7b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("812c05f5-a574-424e-ae0c-a66a85691060"),
},
            new GuidUUID0M
{
    Id = 143,
    Value = Guid.Parse("c0a6ecc2-ffa4-4dc1-a52f-926a04134da6"),
    ModelInner = new GuidUUID0MI
{
    Id = 127,
    Value = Guid.Parse("a6d90d76-f1e9-4c04-8370-ec42674f5e26"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 144,
    Value = Guid.Parse("b8f36054-8c36-46a5-8d13-5d9d17b22f9e"),
    ModelInner = new GuidUUID0MI
{
    Id = 136,
    Value = Guid.Parse("eb8bd058-4586-4e59-96aa-dda8dc3d88f7"),
    NullableValue = Guid.Parse("d687f20e-a375-45e9-aeac-1319e8e07d5d"),
},
    NullableValue = Guid.Parse("59f1d9b7-16c3-4063-a9f2-411c3c4de5de"),
},
            new GuidUUID0M
{
    Id = 148,
    Value = Guid.Parse("4c9d0574-3aa2-4435-bbd6-2c66f16de36e"),
    ModelInner = new GuidUUID0MI
{
    Id = 141,
    Value = Guid.Parse("b6e42dd1-73a2-448e-8cc1-6f6dde4b5372"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 151,
    Value = Guid.Parse("ac652a5e-b0e1-480d-bdd6-ed752d4c4b08"),
    ModelInner = new GuidUUID0MI
{
    Id = 145,
    Value = Guid.Parse("4374e120-31d8-465d-b9ee-42a808e4ca50"),
    NullableValue = Guid.Parse("e4f10c75-a36d-4eac-a88f-5b99ef80b3eb"),
},
    NullableValue = Guid.Parse("6eb04de9-372d-4919-acb9-fb05652efa92"),
},
            new GuidUUID0M
{
    Id = 154,
    Value = Guid.Parse("e4edd46c-46bd-48e2-b1bd-05e71b23f80f"),
    ModelInner = new GuidUUID0MI
{
    Id = 146,
    Value = Guid.Parse("d6ae86f7-f8b7-4076-b273-f7d4017d2fb6"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a5d528f1-de45-41db-b49a-76ac5feee331"),
},
            new GuidUUID0M
{
    Id = 155,
    Value = Guid.Parse("4dba1f72-7d51-4d13-82d7-0e636fad5de9"),
    ModelInner = new GuidUUID0MI
{
    Id = 153,
    Value = Guid.Parse("4a857fd4-62b1-4399-bd7e-82fb1a5a82ec"),
    NullableValue = Guid.Parse("902aba65-b170-4075-9e34-c88657a9b02d"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 162,
    Value = Guid.Parse("3984f8c2-9927-4d3d-85bd-88ffd9a8e54d"),
    ModelInner = new GuidUUID0MI
{
    Id = 154,
    Value = Guid.Parse("eb89fced-7a12-4c96-8e7b-ffc4830877e4"),
    NullableValue = Guid.Parse("3ee17979-0b7a-49ba-a3d9-c9de4b809efb"),
},
    NullableValue = Guid.Parse("19c9da12-8927-40c5-b96e-368646e90cfc"),
},
            new GuidUUID0M
{
    Id = 166,
    Value = Guid.Parse("75518562-b7cf-4a3a-95aa-587f3c63cf33"),
    ModelInner = new GuidUUID0MI
{
    Id = 160,
    Value = Guid.Parse("ba2bfb7a-d78d-4ba8-aa91-71b4da40a1b1"),
    NullableValue = Guid.Parse("b631038e-5fa4-40e4-8e8e-062e483c94c4"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 170,
    Value = Guid.Parse("411b7a6b-ea04-48f1-9e8c-bd02488ea17c"),
    ModelInner = new GuidUUID0MI
{
    Id = 167,
    Value = Guid.Parse("e515ba05-0a65-4483-9bed-63b36346a6cf"),
    NullableValue = Guid.Parse("85e12b7c-1e2c-4081-ac13-37aa44289f2f"),
},
    NullableValue = null,
},
            new GuidUUID0M
{
    Id = 175,
    Value = Guid.Parse("fdb910c7-90cf-4bd5-9776-a17bc5534204"),
    ModelInner = new GuidUUID0MI
{
    Id = 168,
    Value = Guid.Parse("1cb110e2-381c-4fcb-ac14-5e2baa888611"),
    NullableValue = Guid.Parse("0177f830-2041-41f3-8085-ff62376615d5"),
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


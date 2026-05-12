

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidv7MArrayuuidMMArrayD1
    {
    }
    
    internal partial class Guidv7MArrayuuidMMArrayD1 : IGuidv7MArrayuuidMMArrayD1
    {


#region TestData

        private readonly Guidv7uuidMMArrayD1E1M[] _testData = new Guidv7uuidMMArrayD1E1M[]
        {
            new Guidv7uuidMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7b47-b61e-0439da5a4f26"),
Guid.Parse("019e1b50-171b-7321-81bc-f67d7712d68e"),
Guid.Parse("019e1b50-171b-7961-be3f-ee2374426de0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7de1-8223-6cd3ca7e6fd0"),
Guid.Parse("019e1b50-171b-7181-958e-90d669860e58"),
Guid.Parse("019e1b50-171b-74e1-a082-d25632032049"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7aad-8f8a-166cc293846a"),
Guid.Parse("019e1b50-171b-7405-afd7-3b4e8ff060a8"),
Guid.Parse("019e1b50-171b-70cd-8771-db48efc76dcd"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-729e-ba9c-a09d79a0c897"),
Guid.Parse("019e1b50-171b-7fbe-8f30-11b22c52cf1f"),
Guid.Parse("019e1b50-171b-76d3-8554-abd8ef211d39"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7d6f-8364-f9c0103cd5a9"),
Guid.Parse("019e1b50-171b-7a43-a8b5-bd7ee5ea476b"),
Guid.Parse("019e1b50-171b-713f-9c4e-0d8862e38a7b"),
Guid.Parse("019e1b50-171b-7f3c-9786-6baf602509c0"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7285-ad6c-2f5591a76e79"),
Guid.Parse("019e1b50-171b-752a-9c8b-427e5d1ff202"),
Guid.Parse("019e1b50-171b-74a5-a4c0-767414a8a3d8"),
Guid.Parse("019e1b50-171b-798b-a1aa-5e449b90647f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7ae8-9b7c-1777b3ddb2c6"),
Guid.Parse("019e1b50-171b-76d3-b264-d84a91b1ae92"),
Guid.Parse("019e1b50-171b-73ad-afc1-c4555a16dcaf"),
Guid.Parse("019e1b50-171b-7112-a826-f87a525b13da"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7c4d-b658-64d551d3ea5e"),
Guid.Parse("019e1b50-171b-7c66-9718-fb2a7a5c424e"),
Guid.Parse("019e1b50-171b-7114-9217-7f0da68e96bc"),
Guid.Parse("019e1b50-171b-70a9-9c55-bc5b7bb3cf61"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-786f-a2ee-65865d197150"),
Guid.Parse("019e1b50-171b-7e3d-9853-e5dde05b5fbd"),
Guid.Parse("019e1b50-171b-7750-a74f-e728bca58b14"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7c1b-bc81-b8f2540515c0"),
Guid.Parse("019e1b50-171b-7648-b6d4-62889d60d259"),
Guid.Parse("019e1b50-171b-7f87-a8aa-fac77e456cd8"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-70ad-8e88-a6f10aef517c"),
Guid.Parse("019e1b50-171b-7d0a-9d56-750cc5bdc541"),
Guid.Parse("019e1b50-171b-757b-857a-cecb0232e848"),
Guid.Parse("019e1b50-171b-7756-b226-c25efcdfbe1b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-74a0-8926-478b3273b4d8"),
Guid.Parse("019e1b50-171b-7fc6-bc18-2fd83bb4d309"),
Guid.Parse("019e1b50-171b-7787-819e-f5c7cdd0a783"),
Guid.Parse("019e1b50-171b-77e4-86c6-9e26f2f7f972"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7db0-a8f1-d4f3239146e5"),
Guid.Parse("019e1b50-171b-75f1-956f-842ea4daf229"),
Guid.Parse("019e1b50-171b-7f45-8d16-43823ece07b4"),
Guid.Parse("019e1b50-171b-705c-b11b-2b347703dbe0"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-74f6-87e1-85a0a7e2245b"),
Guid.Parse("019e1b50-171b-7f26-8fbd-0e4258a3eaa3"),
Guid.Parse("019e1b50-171b-7696-995f-66d5e0d589af"),
Guid.Parse("019e1b50-171b-765a-8bce-aeac6ce58668"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7d16-8129-d73247eb441a"),
Guid.Parse("019e1b50-171b-7848-b5a8-09dad3d7a956"),
Guid.Parse("019e1b50-171b-7e46-b9bd-8812d1c65041"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-74b9-a7fc-3d68a9960e78"),
Guid.Parse("019e1b50-171b-7b1b-8196-8982e86d369b"),
Guid.Parse("019e1b50-171b-74df-90e6-d11d78004bf9"),
Guid.Parse("019e1b50-171b-7b19-802c-b8cca083ec89"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-74d6-9052-e3bf439edc89"),
Guid.Parse("019e1b50-171b-7f05-b86b-a221efe1980f"),
Guid.Parse("019e1b50-171b-7e61-93e7-b76fd8d5fc9c"),
Guid.Parse("019e1b50-171b-739f-92bc-5e28ab1db181"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7370-91d4-e42229646ac7"),
Guid.Parse("019e1b50-171b-779f-ad13-de6fa0a9d25e"),
Guid.Parse("019e1b50-171b-7d2c-a0fd-3b24e1f8d2e2"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-74c2-a223-63df85babfae"),
Guid.Parse("019e1b50-171b-751a-861b-82cd6a58aff4"),
Guid.Parse("019e1b50-171b-7cbb-b5f9-9599a52d6b8d"),
Guid.Parse("019e1b50-171b-79bb-a574-0c2d98033958"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7c71-9bd6-a49eebbab090"),
Guid.Parse("019e1b50-171b-7fa3-a4d3-e0e99e8853e8"),
Guid.Parse("019e1b50-171b-7c41-89a5-94d17333850e"),
Guid.Parse("019e1b50-171b-71e2-ac8f-e0729cf851cf"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7299-abe6-d659d2a528d6"),
Guid.Parse("019e1b50-171b-7955-ab61-b62ac98e7bec"),
Guid.Parse("019e1b50-171b-709e-b561-d365a9972b54"),
Guid.Parse("019e1b50-171b-74d9-bdf1-ec71ff5251b8"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7bfc-bfaa-ee02b2bf8878"),
Guid.Parse("019e1b50-171b-7cd2-a861-f73624e6f911"),
Guid.Parse("019e1b50-171b-7492-ab83-86667328a58d"),
Guid.Parse("019e1b50-171b-77b2-ae09-35f9073a7843"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7ce5-84d9-2f0494cb08d7"),
Guid.Parse("019e1b50-171b-74dd-a876-711a51b58d30"),
Guid.Parse("019e1b50-171b-76c7-9202-f888f3fcce12"),
Guid.Parse("019e1b50-171b-7f42-8c12-93a9a80a2390"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7435-bf1d-cae603e27ea7"),
Guid.Parse("019e1b50-171b-7ae7-8a15-e61a8c93b8e2"),
Guid.Parse("019e1b50-171b-72ab-9451-b043485f765a"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-70b0-8e19-deb7bbb06ae4"),
Guid.Parse("019e1b50-171b-7dbc-8ae2-a7794d3922fa"),
Guid.Parse("019e1b50-171b-71d3-83d1-b89dbc6e2cf3"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7111-a655-f7f422142295"),
Guid.Parse("019e1b50-171b-794f-9f5d-ec392048176f"),
Guid.Parse("019e1b50-171b-7ff4-bf62-41051f7f1c21"),
Guid.Parse("019e1b50-171b-74b7-862b-a69dfdd3c2ba"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7e10-ba6d-07b941ea925a"),
Guid.Parse("019e1b50-171b-7b94-880c-55c8130606ce"),
Guid.Parse("019e1b50-171b-7ebf-a6fb-649f66dd3d8b"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7bd3-a105-165dd25d4faf"),
Guid.Parse("019e1b50-171b-75b0-a5de-d0893c3a36eb"),
Guid.Parse("019e1b50-171b-7a89-8500-6368621e341b"),
Guid.Parse("019e1b50-171b-74e0-ab71-3377e7bda5fe"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-77e5-8fad-d7615033c759"),
Guid.Parse("019e1b50-171b-7bf3-bc27-7072af4ad64e"),
Guid.Parse("019e1b50-171b-7f86-b2ea-dfc9e3e7edc6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-765b-9e62-df00da6b3b6e"),
Guid.Parse("019e1b50-171b-7d0b-9fe4-7abb20fb76ac"),
Guid.Parse("019e1b50-171b-7e7e-b2bd-64b47f5e1c01"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-734d-b4d7-ae9f10d5e8d1"),
Guid.Parse("019e1b50-171b-7c29-aa58-e21eff46ee6f"),
Guid.Parse("019e1b50-171b-7108-a625-a668c097c98e"),
Guid.Parse("019e1b50-171b-7556-a246-fd9592309acf"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7ef4-99c1-8b960462a537"),
Guid.Parse("019e1b50-171b-7f8a-98f0-e7b31274f3e8"),
Guid.Parse("019e1b50-171b-778f-b210-ae0d67470a00"),
Guid.Parse("019e1b50-171b-79d9-9820-945819c067f9"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7237-9e2c-d73eed3e9baf"),
Guid.Parse("019e1b50-171b-78d8-b432-d035512d14f7"),
Guid.Parse("019e1b50-171b-77ce-95e7-a5be2ab6bd5c"),
Guid.Parse("019e1b50-171b-78c6-af37-88d9db2aff50"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7c00-afd5-673efa307e8f"),
Guid.Parse("019e1b50-171b-78c6-96ee-dd88ef2a44be"),
Guid.Parse("019e1b50-171b-72b0-a139-dba3947574eb"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-78cd-966d-97b8da3c14eb"),
Guid.Parse("019e1b50-171b-74dd-a003-d7b3f26a55df"),
Guid.Parse("019e1b50-171b-73c5-96df-f43d3dc81267"),
Guid.Parse("019e1b50-171b-7932-b986-fbcbd585f406"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7d91-89cc-c48aacc8033e"),
Guid.Parse("019e1b50-171b-765c-9ce9-6483e1bb5cb1"),
Guid.Parse("019e1b50-171b-7ba9-83f3-2f500a5bc739"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-763f-a673-b78a2b517e30"),
Guid.Parse("019e1b50-171b-7c6a-9c85-bbc587d1bf33"),
Guid.Parse("019e1b50-171b-7cc7-a268-023b5aa88874"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7424-860c-968aebd82123"),
Guid.Parse("019e1b50-171b-7c1d-9fc7-d37e35938435"),
Guid.Parse("019e1b50-171b-7d5d-bf88-7b070c5b029b"),
Guid.Parse("019e1b50-171b-76b6-b36a-e4488ccad3b4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7e20-86b0-9e94b0935227"),
Guid.Parse("019e1b50-171b-78ee-9f6f-55963ba0966e"),
Guid.Parse("019e1b50-171b-7268-a0d3-ba840933e2ab"),
Guid.Parse("019e1b50-171b-74f9-a329-a4dc14399df1"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7069-8922-35d908d1d22d"),
Guid.Parse("019e1b50-171b-7cdc-bc23-1d3e5656a1c4"),
Guid.Parse("019e1b50-171b-7cd2-b73e-d8d4650a0582"),
Guid.Parse("019e1b50-171b-7d37-b10f-543595cfd16c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-779e-8222-e83e6d867a6a"),
Guid.Parse("019e1b50-171b-710e-8b43-291402804d65"),
Guid.Parse("019e1b50-171b-71df-a302-0d916411359e"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7817-bd32-cb89e98f02bc"),
Guid.Parse("019e1b50-171b-7f82-a90c-22c7b51e10a0"),
Guid.Parse("019e1b50-171b-7b50-bd20-3b5455625d2c"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7ff8-b81c-b0ccc73f4b7a"),
Guid.Parse("019e1b50-171b-7e93-9ebf-9a1ce6433aee"),
Guid.Parse("019e1b50-171b-7ccf-b995-2468d3e9526e"),
Guid.Parse("019e1b50-171b-7702-85cf-9eb6fdc08522"),
},
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7c94-8f8d-21265b3b7d79"),
Guid.Parse("019e1b50-171b-7d15-8c65-ae961947d4e3"),
Guid.Parse("019e1b50-171b-7e26-a64f-7a7362ce2b16"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 110,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-74ea-bd29-c4b07eb63759"),
Guid.Parse("019e1b50-171b-7173-9e9d-9993a58a84d3"),
Guid.Parse("019e1b50-171b-7fbd-9558-c64d52d5bb73"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-73dd-a25b-056a94d08f8a"),
Guid.Parse("019e1b50-171b-731c-8704-10b2aa1dca0b"),
Guid.Parse("019e1b50-171b-777c-9e04-0e50b33e4d65"),
Guid.Parse("019e1b50-171b-7fdd-ab35-d31f174e98e1"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-762b-b906-63f658b1590a"),
Guid.Parse("019e1b50-171b-7485-a46e-4e7ef7a3ecca"),
Guid.Parse("019e1b50-171b-7128-a42d-4378d4330988"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-77b2-881f-08479b653a0e"),
Guid.Parse("019e1b50-171b-787b-9662-2df0b7d7d547"),
Guid.Parse("019e1b50-171b-7c2b-980a-9e51631474b9"),
Guid.Parse("019e1b50-171b-7b68-b50c-3ea01dd18e4b"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-729f-9e79-b906934fbb0e"),
Guid.Parse("019e1b50-171b-759a-b06d-79bf3fabb204"),
Guid.Parse("019e1b50-171b-7123-b8c9-7723436208c4"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7084-a5f2-a6f42550c183"),
Guid.Parse("019e1b50-171b-71be-a56f-e7b37dba2f64"),
Guid.Parse("019e1b50-171b-7b67-a8fb-5a93c092e4ba"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7ecf-ba78-915214302644"),
Guid.Parse("019e1b50-171b-7ab6-9d14-7093d53c2da2"),
Guid.Parse("019e1b50-171b-7748-a0b1-dcae49c3f8cd"),
Guid.Parse("019e1b50-171b-728d-a5c7-a9fb15e4daa6"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7ddf-8c30-f17e7b701b5e"),
Guid.Parse("019e1b50-171b-72b9-8ded-5650751360fb"),
Guid.Parse("019e1b50-171b-78c5-9e77-401540cc53a6"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7e76-80c9-1d72ad4bee26"),
Guid.Parse("019e1b50-171b-79d1-a418-b0b9e670ba87"),
Guid.Parse("019e1b50-171b-7f95-8901-1aa0ceb7d63f"),
Guid.Parse("019e1b50-171b-7f4b-a833-a9521b5c42b0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-797e-bdd7-11b57f1754b8"),
Guid.Parse("019e1b50-171b-7876-b2fa-2077f296dc42"),
Guid.Parse("019e1b50-171b-7088-8bd7-9db43b81af3d"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-704e-aabd-ff4c16fb55ca"),
Guid.Parse("019e1b50-171b-772e-93f8-2229c9726d2a"),
Guid.Parse("019e1b50-171b-713b-b256-b53de533ac2b"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-716b-87c6-06ba374ec63c"),
Guid.Parse("019e1b50-171b-7486-a1b4-bf0579ec2883"),
Guid.Parse("019e1b50-171b-770b-950b-bdc7abf44752"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7cea-a158-7fbb29561af2"),
Guid.Parse("019e1b50-171b-7bef-a9cb-ea4ce7e66cf9"),
Guid.Parse("019e1b50-171b-7ed6-ba3d-405cb4d7f78f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-76e4-a3d7-0965438af9a9"),
Guid.Parse("019e1b50-171b-78c7-90e7-cdf2c95eb18e"),
Guid.Parse("019e1b50-171b-7d51-9d16-32b24c819424"),
Guid.Parse("019e1b50-171b-7687-83ea-2a944140a8e4"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7535-9aaa-367f5a2339d2"),
Guid.Parse("019e1b50-171b-7695-b5ee-fabfbeb942c1"),
Guid.Parse("019e1b50-171b-7810-ade3-0d9fbc57f38d"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7b8f-93be-a7c26040ae22"),
Guid.Parse("019e1b50-171b-70e1-9c73-19da8fdaa599"),
Guid.Parse("019e1b50-171b-7587-934c-ed8b855945d0"),
Guid.Parse("019e1b50-171b-7ad4-9dc6-7fa9b83b2e4c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7506-a2aa-44a2df1ca364"),
Guid.Parse("019e1b50-171b-7ba8-9794-bb9533c521f1"),
Guid.Parse("019e1b50-171b-7d3a-8171-daa4eeae29d2"),
Guid.Parse("019e1b50-171b-77ee-ba0b-b23189728b74"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7f96-8a0d-1d79499446be"),
Guid.Parse("019e1b50-171b-7ec4-91cf-4c0986742436"),
Guid.Parse("019e1b50-171b-736a-9828-550055046e59"),
Guid.Parse("019e1b50-171b-77ad-97d9-55a831d2502d"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7dc9-a694-a32df8aab4a4"),
Guid.Parse("019e1b50-171b-747c-9830-3820068ce1ec"),
Guid.Parse("019e1b50-171b-7e7c-a524-21c68fa3aa77"),
Guid.Parse("019e1b50-171b-7451-bd1a-ebc025aa733f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7fa9-b50b-14f100790c2f"),
Guid.Parse("019e1b50-171b-7961-9316-04d5818e451b"),
Guid.Parse("019e1b50-171b-73de-a541-abddf8505efd"),
Guid.Parse("019e1b50-171b-7240-97d3-e7beaf18aa3d"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7b7f-b6ca-3768b1fbb459"),
Guid.Parse("019e1b50-171b-7b31-9741-34e06486f023"),
Guid.Parse("019e1b50-171b-7432-8c96-946657723a9b"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-73e5-bfd9-7a0dd29e9d17"),
Guid.Parse("019e1b50-171b-71d0-811b-25ecade2f570"),
Guid.Parse("019e1b50-171b-75b5-bf94-4be77032fbb1"),
Guid.Parse("019e1b50-171b-79da-a011-1816a8f66403"),
},
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7798-9542-ba80d1896901"),
Guid.Parse("019e1b50-171b-7cae-88da-a6f35be0a5aa"),
Guid.Parse("019e1b50-171b-7c5f-994d-f0b340689531"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7e40-bd34-6b693fc8a3cd"),
Guid.Parse("019e1b50-171b-7277-b84a-43df9a9b2851"),
Guid.Parse("019e1b50-171b-7420-9e49-56e62f6f6d55"),
Guid.Parse("019e1b50-171b-77ac-bc70-beb17c096ea5"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7027-b260-d9236a37f6ef"),
Guid.Parse("019e1b50-171b-77ed-9797-22fff2ea076f"),
Guid.Parse("019e1b50-171b-72c4-8548-e515f4f48408"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7b49-9285-4701f0619c13"),
Guid.Parse("019e1b50-171b-759e-9c67-58242fa60115"),
Guid.Parse("019e1b50-171b-7578-ad53-8d373b9582c1"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-716c-bbfb-ddcc3c34408b"),
Guid.Parse("019e1b50-171b-745a-8e25-e72f74baf17b"),
Guid.Parse("019e1b50-171b-7343-8157-27d606c242ee"),
Guid.Parse("019e1b50-171b-72c5-8eb9-94050ed50179"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7d87-ae59-f3ff6207b3c7"),
Guid.Parse("019e1b50-171b-7f95-b7e2-60373124540c"),
Guid.Parse("019e1b50-171b-7994-888a-7f2042fba3a1"),
},
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7cfe-8bd8-0d315eb52f92"),
Guid.Parse("019e1b50-171b-756d-8af6-1fafc4446f9b"),
Guid.Parse("019e1b50-171b-7586-809e-98d415ffbd3a"),
Guid.Parse("019e1b50-171b-765f-8381-ee9c68bc7043"),
},
    ModelInner = new Guidv7uuidMMArrayD1E1MI
{
    Id = 107,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7531-bea9-9703c6973307"),
Guid.Parse("019e1b50-171b-7292-b927-226d30f03850"),
Guid.Parse("019e1b50-171b-761d-acdd-13145a3981d1"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidMMArrayD1E1M
{
    Id = 178,
    Value = 
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-71c9-9e35-2178a95e53a9"),
Guid.Parse("019e1b50-171b-7025-a7e9-ec550507a8d7"),
Guid.Parse("019e1b50-171b-7fcc-b34a-9080c751dda3"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd1e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guidv7uuidmmarrayd1e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd1e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    guidv7uuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-74a0-8926-478b3273b4d8"),
Guid.Parse("019e1b50-171b-7fc6-bc18-2fd83bb4d309"),
Guid.Parse("019e1b50-171b-7787-819e-f5c7cdd0a783"),
Guid.Parse("019e1b50-171b-77e4-86c6-9e26f2f7f972"),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-74b9-a7fc-3d68a9960e78"),
Guid.Parse("019e1b50-171b-7b1b-8196-8982e86d369b"),
Guid.Parse("019e1b50-171b-74df-90e6-d11d78004bf9"),
Guid.Parse("019e1b50-171b-7b19-802c-b8cca083ec89"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guidv7uuidmmarrayd1e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    guidv7uuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guidv7uuidmmarrayd1e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                nullable =  ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("019e1b50-171b-7370-91d4-e42229646ac7"),
Guid.Parse("019e1b50-171b-779f-ad13-de6fa0a9d25e"),
Guid.Parse("019e1b50-171b-7d2c-a0fd-3b24e1f8d2e2"),
}));
                nullable =  ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                nullable = await ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7bfc-bfaa-ee02b2bf8878"),
Guid.Parse("019e1b50-171b-7cd2-a861-f73624e6f911"),
Guid.Parse("019e1b50-171b-7492-ab83-86667328a58d"),
Guid.Parse("019e1b50-171b-77b2-ae09-35f9073a7843"),
}));
                nullable = await ((IGuidv7MArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("019e1b50-171b-7111-a655-f7f422142295"),
Guid.Parse("019e1b50-171b-794f-9f5d-ec392048176f"),
Guid.Parse("019e1b50-171b-7ff4-bf62-41051f7f1c21"),
Guid.Parse("019e1b50-171b-74b7-862b-a69dfdd3c2ba"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD1E1M> models = null;

                models =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidMMArrayD1E1M> models = null;

                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidv7MArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M), typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
LEFT JOIN public.guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M), typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
LEFT JOIN public.guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M), typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
LEFT JOIN public.guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M), typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 148, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var models2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 160, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 25, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 93, query1, 160, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 149, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 14, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuidv7uuidMMArrayD1E1M>();
                 ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 149, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuidv7uuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.guidv7uuidmmarrayd1e1m m
LEFT JOIN public.guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guidv7uuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidv7MArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 68, 155))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidv7MArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidv7MArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 137);
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidv7MArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidv7MArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models =  ((IGuidv7MArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Guidv7uuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                Guidv7uuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guidv7uuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guidv7uuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guidv7uuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guidv7uuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Guidv7uuidMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guidv7uuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guidv7uuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Guidv7uuidMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_guidv7uuidmmarrayd1e1m m
LEFT JOIN public.binary_guidv7uuidmmarrayd1e1mi mi ON mi.id = m.guidv7uuidmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guidv7uuidMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidv7MArrayuuidMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Guidv7uuidMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidv7MArrayuuidMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guidv7uuidMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guidv7uuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidv7MArrayuuidMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guidv7uuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA), typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA), typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MI), typeof(Guidv7uuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Guidv7uuidMMArrayD1E1MI>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MI>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Guidv7uuidMMArrayD1E1MI>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MI>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guidv7uuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA), typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                await ((IGuidv7MArrayuuidMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                var models2 = new List<Guidv7uuidMMArrayD1E1MIWA>();
                ((IGuidv7MArrayuuidMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guidv7uuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayuuidMMArrayD1))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidv7MArrayuuidMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidv7MArrayuuidMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guidv7uuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

